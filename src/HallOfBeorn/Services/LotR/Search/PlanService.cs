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

namespace HallOfBeorn.Services.LotR.Search
{
    public class PlanService : IPlanService
    {
        public PlanService(INoteService noteService,
            IScenarioService scenarioService,
            ICategoryService<PlayerCategory> playerCategoryService, 
            ICategoryService<EncounterCategory> encounterCategoryService, 
            ICategoryService<QuestCategory> questCategoryService, 
            IRingsDbService ringsDbService,
            IFilterService filterService)
        {
            _noteService = noteService;
            _scenarioService = scenarioService;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _filterService = filterService;
            _getPopularity = (slug) => { return ringsDbService.GetPopularity(slug); };
            _getVotes = (card) => { return card.CardType == CardType.Hero ? 10000 + ringsDbService.GetVotes(card.Slug) : ringsDbService.GetVotes(card.Slug); };
        }

        private readonly INoteService _noteService;
        private readonly IScenarioService _scenarioService;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly IFilterService _filterService;
        private readonly Func<string, byte> _getPopularity;
        private readonly Func<LotRCard, int> _getVotes;

        private const string defaultCardSet = "Core Set";
        private const CardType defaultCardType = CardType.Hero;
        private const int defaultOffset = 0;
        private const int defaultLimit = 200;

        private IEnumerable<IComponent> CreateFilters(SearchViewModel model)
        {
            var filters = new List<IComponent>();

            AddFilter(filters, new StringBasicQueryFilter(model.BasicQuery()));
            AddFilter(filters, new StringAdvancedQueryFilter(model.Query, _filterService));

            AddFilter(filters, new StringExactFilter((score) => score.Card.Artist != null ? score.Card.Artist.Name : string.Empty, model.Artist));
            
            AddFilter(filters, new GenericFilter(model.CardSet, (score, target) => score.Card.MatchesCardSet(target)));
            AddFilter(filters, new GenericFilter(model.Scenario, (score, target) =>  _scenarioService.BelongsToScenario(score.Card.Slug, score.Card.CardType, target)));
            AddFilter(filters, new GenericFilter(model.EncounterSet, (score, target) => score.Card.EncounterSet == target, (score, target) => score.Card.AlternateEncounterSet == target));

            AddFilter(filters, new CardTypeFilter(model.CardType));
            AddFilter(filters, new EnumFilter<CardSubtype>((score) => score.Card.CardSubtype, model.CardSubtype, (target) => { return target == "No Subtype" ? "None" : target; }));
            AddFilter(filters, new EnumFilter<DeckType>((score) => score.Card.DeckType, model.DeckType));

            AddFilter(filters, new EnumFilter<Sphere>((score) => score.Card.Sphere, model.Sphere));
            AddFilter(filters, new EnumFilter<Uniqueness>((score) => score.Card.IsUnique ? Uniqueness.Yes : Uniqueness.No, model.IsUnique));
            AddFilter(filters, new Filter((score) => _scenarioService.HasSetType(score.Card, model.SetType)));

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

            AddFilter(filters, new TraitFilter(model.Trait));
            AddFilter(filters, new KeywordFilter(model.Keyword));
            AddFilter(filters, new VictoryPointFilter(model.VictoryPoints));

            AddFilter(filters, new CategoryFilter<PlayerCategory>((score, cat) => _playerCategoryService.HasCategory(score.Card, cat), model.Category));
            AddFilter(filters, new CategoryFilter<EncounterCategory>((score, cat) => _encounterCategoryService.HasCategory(score.Card, cat), model.EncounterCategory));
            AddFilter(filters, new CategoryFilter<QuestCategory>((score, cat) => _questCategoryService.HasCategory(score.Card, cat), model.QuestCategory));

            if (filters.Count == 1 && !model.SetType.HasValue)
            {
                AddFilter(filters, new StringExactFilter((score) => score.Card.CardSet.Name, defaultCardSet));
                AddFilter(filters, new EnumFilter<CardType>((score) => score.Card.CardType, defaultCardType));
            }

            return filters;
        }

        private IEnumerable<IComponent> CreateSorts(SearchViewModel model)
        {
            var sorts = new List<IComponent>();

            if (!model.Sort.HasValue)
            {
                AddSort(sorts, (score) => score.Score(), false, true);
                AddSort(sorts, (score) => _getPopularity(score.Card.Slug), false, false);
                AddSort(sorts, (score) => _getVotes(score.Card), false, false);
                return sorts;
            }

            if (model.Sort.Value == Sort.Alphabetical)
            {
                AddSort(sorts, (score) => score.Card.Title, true, true);
                AddSort(sorts, (score) => (int)score.Card.CardType, true, false);
            }
            if (model.Sort.Value == Sort.Popularity)
            {
                AddSort(sorts, (score) => _getPopularity(score.Card.Slug), false, true);
                AddSort(sorts, (score) => _getVotes(score.Card), false, false);
            }
            if (model.Sort.Value == Sort.StatScore)
            {
                AddSort(sorts, (score) => score.Card.StatScore(), false, true);
            }
            if (model.Sort.Value == Sort.StatEfficiency)
            {
                AddSort(sorts, (score) => score.Card.StatEfficiency(), false, true);
            }
            if (model.Sort.Value == Sort.Released)
                AddSort(sorts, (score) => score.Card.CardSet.Product.Code, false, true);
            if (model.Sort.Value == Sort.Set_Number)
            {
                AddSort(sorts, (score) => score.Card.CardSet.Product.Code, true, true);
                AddSort(sorts, (score) => score.Card.CardNumber, true, false);
            }
            if (model.Sort.Value == Sort.Sphere_Type_Cost)
            {
                AddSort(sorts, (score) => score.Card.Sphere, true, true);
                AddSort(sorts, (score) => score.Card.CardType, true, false);
                AddSort(sorts, (score) => score.Card.SortCost(), true, false);
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

        private IEnumerable<IComponent> CreateLimits(SearchViewModel model)
        {
            var limits = new List<IComponent>();

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

        private void AddSort<TKey>(ICollection<IComponent> sorts, Func<CardScore, TKey> keySelector, bool isAscending, bool isTopLevel)
        {
            sorts.Add(new Sort<TKey>(keySelector, isAscending, isTopLevel));
        }

        private void AddOffset(ICollection<IComponent> offsets, int count)
        {
            offsets.Add(new Offset(count));
        }

        private void AddLimit(ICollection<IComponent> limits, int count)
        {
            limits.Add(new Limit(count));
        }

        public Plan CreatePlan(SearchViewModel model)
        {
            var steps = new List<IComponent>();

            steps.AddRange(CreateFilters(model));
            steps.AddRange(CreateSorts(model));
            steps.AddRange(CreateOffsets(model));
            steps.AddRange(CreateLimits(model));

            return new Plan(steps);
        }
    }
}
