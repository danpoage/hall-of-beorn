using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;
using HallOfBeorn.Services.LotR.Tags;
using HallOfBeorn.Services.LotR.Translation;

namespace HallOfBeorn.Services.LotR.Search
{
    public class PlanService : IPlanService
    {
        public PlanService(INoteService noteService,
            IScenarioService scenarioService,
            ICategoryService<PlayerCategory> playerCategoryService, 
            ICategoryService<EncounterCategory> encounterCategoryService, 
            ICategoryService<QuestCategory> questCategoryService,
            ICategoryService<Region> regionService,
            ICategoryService<Archetype> archetypeService,
            IRingsDbService ringsDbService,
            IFilterService filterService,
            ITranslationService translationService)
        {
            _noteService = noteService;
            _scenarioService = scenarioService;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _regionService = regionService;
            _archetypeService = archetypeService;
            _filterService = filterService;
            _translationService = translationService;
            _getPopularity = (slug) => { return ringsDbService.GetPopularity(slug); };
            _getVotes = (card) => { return ringsDbService.GetVotes(card.Slug); };
        }

        private readonly INoteService _noteService;
        private readonly IScenarioService _scenarioService;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly ICategoryService<Region> _regionService;
        private readonly ICategoryService<Archetype> _archetypeService;
        private readonly IFilterService _filterService;
        private readonly ITranslationService _translationService;
        private readonly Func<string, byte> _getPopularity;
        private readonly Func<LotRCard, uint> _getVotes;

        private const string defaultCardSet = "Core Set";
        private const CardType defaultCardType = CardType.Hero;
        private const int defaultOffset = 0;

        private string getTranslatedCardType(Language? lang, string cardTypeName)
        {
            if (lang.GetValueOrDefault(Language.EN) == Language.EN)
            {
                return cardTypeName;
            }

            return _translationService.EnglishCardTypeName(lang.Value, cardTypeName);
        }

        private string getTranslatedTrait(Language? lang, string trait)
        {
            if (lang.GetValueOrDefault(Language.EN) == Language.EN)
            {
                return trait;
            }

            return _translationService.EnglishTrait(lang.Value, trait);
        }

        private string getTranslatedKeyword(Language? lang, string keyword)
        {
            if (lang.GetValueOrDefault(Language.EN) == Language.EN)
            {
                return keyword;
            }

            return _translationService.EnglishKeyword(lang.Value, keyword);
        }

        private IEnumerable<IComponent> CreateFilters(SearchViewModel model, UserSettings settings)
        {
            var filters = new List<IComponent>();

            AddFilter(filters, new StringBasicQueryFilter(model.BasicQuery(), model.Lang));
            AddFilter(filters, new StringAdvancedQueryFilter(model.Query, _filterService));

            AddFilter(filters, new StringExactFilter((score) => score.Card.Artist != null ? score.Card.Artist.Name : string.Empty, model.Artist));
            
            AddFilter(filters, new GenericFilter(model.CardSet, (score, target) => score.Card.MatchesCardSet(target)));
            AddFilter(filters, new GenericFilter(model.Scenario, (score, target) =>  _scenarioService.BelongsToScenario(score.Card.Slug, score.Card.CardType, target)));
            AddFilter(filters, new GenericFilter(model.EncounterSet, (score, target) => score.Card.EncounterSet == target, (score, target) => score.Card.AlternateEncounterSet == target));

            AddFilter(filters, new CardTypeFilter(getTranslatedCardType(model.Lang, model.CardType)));
            AddFilter(filters, new EnumFilter<CardSubtype>((score) => score.Card.CardSubtype, model.CardSubtype, (target) => { return target == "No Subtype" ? "None" : target; }));
            AddFilter(filters, new EnumFilter<DeckType>((score) => score.Card.DeckType, model.DeckType));

            AddFilter(filters, new EnumFilter<Sphere>((score) => score.Card.Sphere, model.Sphere));
            AddFilter(filters, new EnumFilter<Uniqueness>((score) => score.Card.IsUnique ? Uniqueness.Yes : Uniqueness.No, model.IsUnique));
            AddFilter(filters, new Filter((score) => _scenarioService.HasSetType(score.Card, model.SetType, settings)));

            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.ResourceCost, model.Cost, model.CostOperator));
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.ThreatCost, model.ThreatCost, model.ThreatCostOperator));
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.EngagementCost, model.EngagementCost, model.EngagementCostOperator));
            
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.Attack, model.Attack, model.AttackOp));
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.Defense, model.Defense, model.DefenseOp));
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.HitPoints, model.HitPoints, model.HitPointsOp));
            
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.Willpower, model.Willpower, model.WillpowerOp));
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.Threat, model.Threat, model.ThreatOp));
            AddFilter(filters, new ByteComparisonFilter((score) => score.Card.QuestPoints, model.QuestPoints, model.QuestPointsOp));

            AddFilter(filters, new NumericComparisonFilter((score) => _getPopularity(score.Card.Slug), model.Popularity, model.PopularityOp));

            AddFilter(filters, new ErrataFilter((score, version) => _noteService.HasErrata(score.Card.Slug, version), model.Errata));

            AddFilter(filters, new TraitFilter(getTranslatedTrait(model.Lang, model.Trait)));
            AddFilter(filters, new KeywordFilter(getTranslatedKeyword(model.Lang, model.Keyword)));
            AddFilter(filters, new VictoryPointFilter(model.VictoryPoints));

            AddFilter(filters, new CategoryFilter<PlayerCategory>((score, cat) => _playerCategoryService.HasCategory(score.Card, cat), model.Category));
            AddFilter(filters, new CategoryFilter<EncounterCategory>((score, cat) => _encounterCategoryService.HasCategory(score.Card, cat), model.EncounterCategory));
            AddFilter(filters, new CategoryFilter<QuestCategory>((score, cat) => _questCategoryService.HasCategory(score.Card, cat), model.QuestCategory));
            AddFilter(filters, new CategoryFilter<Region>((score, reg) => _regionService.HasCategory(score.Card, reg), model.Region));
            AddFilter(filters, new CategoryFilter<Archetype>((score, arc) => _archetypeService.HasCategory(score.Card, arc), model.Archetype));

            AddFilter(filters, new GenericFilter(model.Age, (score, target) => score.Card.IncludesAge(target)));

            if (filters.Count == 1 && !model.SetType.HasValue)
            {
                AddFilter(filters, new StringExactFilter((score) => score.Card.CardSet.Name, defaultCardSet));
                AddFilter(filters, new EnumFilter<CardType>((score) => score.Card.CardType, defaultCardType));
            }

            return filters;
        }

        private IEnumerable<IComponent> CreateSorts(SearchViewModel model, UserSettings settings)
        {
            var sorts = new List<IComponent>();

            if (!model.Sort.HasValue)
            {
                AddDescendingSort(sorts, (score) => score.Score());
            }

            if (model.Sort.GetValueOrDefault(Sort.None) == Sort.Alphabetical || 
                (!model.Sort.HasValue && settings.DefaultSort == "Alphabetical"))
            {
                AddAscendingSort(sorts, (score) => score.Card.Title);
                AddDescendingSort(sorts, (score) => (int)score.Card.CardType);
            }
            if (model.Sort.GetValueOrDefault(Sort.None) == Sort.Popularity ||
                (!model.Sort.HasValue && settings.DefaultSort == "Popularity"))
            {
                AddDescendingSort(sorts, (score) => _getPopularity(score.Card.Slug));
                AddDescendingSort(sorts, (score) => _getVotes(score.Card));
            }
            if (model.Sort.GetValueOrDefault(Sort.None) == Sort.StatScore || 
                (!model.Sort.HasValue && settings.DefaultSort == "StatScore"))
            {
                AddDescendingSort(sorts, (score) => score.Card.StatScore());
            }
            if (model.Sort.GetValueOrDefault(Sort.None) == Sort.StatEfficiency || 
                (!model.Sort.HasValue && settings.DefaultSort =="StatEfficiency"))
            {
                AddDescendingSort(sorts, (score) => score.Card.StatEfficiency());
            }
            if (model.Sort.GetValueOrDefault(Sort.None) == Sort.Released || 
                (!model.Sort.HasValue && settings.DefaultSort == "Released"))
            {
                AddDescendingSort(sorts, (score) => score.Card.CardSet.Product.Code);
            }
            if (model.Sort.GetValueOrDefault(Sort.None) == Sort.Set_Number || 
                (!model.Sort.HasValue && settings.DefaultSort == "SetNumber"))
            {
                AddAscendingSort(sorts, (score) => score.Card.CardSet.Product.Code);
                AddAscendingSort(sorts, (score) => score.Card.CardNumber);
            }
            if (model.Sort.GetValueOrDefault(Sort.None) == Sort.Sphere_Type_Cost || 
                (!model.Sort.HasValue && settings.DefaultSort == "SphereTypeCost"))
            {
                AddAscendingSort(sorts, (score) => score.Card.Sphere);
                AddAscendingSort(sorts, (score) => score.Card.CardType);
                AddAscendingSort(sorts, (score) => score.Card.SortCost());
            }
            return sorts;
        }

        private IEnumerable<IComponent> CreateOffsets(SearchViewModel model)
        {
            var offsets = new List<IComponent>();

            var offset = model.Offset.HasValue ? model.Offset.Value : defaultOffset;
            AddOffset(offsets, offset);

            return offsets;
        }

        private IEnumerable<IComponent> CreateLimits(SearchViewModel model, UserSettings settings)
        {
            var limits = new List<IComponent>();

            var defaultLimit = 200;
            switch (settings.DefaultLimit)
            {
                case "400":
                    defaultLimit = 400;
                    break;
                case "600":
                    defaultLimit = 600;
                    break;
                case "200":
                default:
                    break;
            }

            var limit = model.Limit.HasValue ? model.Limit.Value : defaultLimit;
            AddLimit(limits, limit);

            return limits;
        }

        private void AddFilter(ICollection<IComponent> filters, IComponent filter)
        {
            if (filter == null || filter.IsEmpty)
                return;

            filters.Add(filter);
        }

        private void AddAscendingSort<TKey>(ICollection<IComponent> sorts, Func<CardScore, TKey> keySelector)
        {
            var isTopLevel = sorts.Count == 0;
            sorts.Add(new Sort<TKey>(keySelector, true, isTopLevel));
        }

        private void AddDescendingSort<TKey>(ICollection<IComponent> sorts, Func<CardScore, TKey> keySelector)
        {
            var isTopLevel = sorts.Count == 0;
            sorts.Add(new Sort<TKey>(keySelector, false, isTopLevel));
        }

        private void AddOffset(ICollection<IComponent> offsets, int count)
        {
            offsets.Add(new Offset(count));
        }

        private void AddLimit(ICollection<IComponent> limits, int count)
        {
            limits.Add(new Limit(count));
        }

        public Plan CreatePlan(SearchViewModel model, UserSettings settings)
        {
            var steps = new List<IComponent>();

            steps.AddRange(CreateFilters(model, settings));
            steps.AddRange(CreateSorts(model, settings));
            steps.AddRange(CreateOffsets(model));
            steps.AddRange(CreateLimits(model, settings));

            return new Plan(steps);
        }
    }
}
