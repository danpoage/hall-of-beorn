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

namespace HallOfBeorn.Services.LotR.Search
{
    public class PlanBuilder : IPlanBuilder
    {
        public PlanBuilder(IScenarioService scenarioService, 
            ICategoryService<PlayerCategory> playerCategoryService, 
            ICategoryService<EncounterCategory> encounterCategoryService, 
            ICategoryService<QuestCategory> questCategoryService, 
            IRingsDbService ringsDbService, 
            IAdvancedSearchService advancedSearchService,
            IFilterService filterService)
        {
            _scenarioService = scenarioService;
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
            _advancedSearchService = advancedSearchService;
            _filterService = filterService;
            _getPopularity = (slug) => { return ringsDbService.GetPopularity(slug); };
            _getVotes = (card) => { return card.CardType == CardType.Hero ? 10000 + ringsDbService.GetVotes(card.Slug) : ringsDbService.GetVotes(card.Slug); };
        }

        private readonly IScenarioService _scenarioService;
        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly IAdvancedSearchService _advancedSearchService;
        private readonly IFilterService _filterService;
        private readonly Func<string, byte> _getPopularity;
        private readonly Func<LotRCard, int> _getVotes;

        private readonly List<IComponent> _filters = new List<IComponent>();
        private readonly List<IComponent> _sorts = new List<IComponent>();
        private readonly List<IComponent> _offsets = new List<IComponent>();
        private readonly List<IComponent> _limits = new List<IComponent>();

        private const string defaultCardSet = "Core Set";
        private const CardType defaultCardType = CardType.Hero;
        private const int defaultOffset = 0;
        private const int defaultLimit = 100;

        private void BuildFilters(SearchViewModel model)
        {
            _filters.Clear();

            AddFilter(new StringBasicQueryFilter(model.BasicQuery()));
            AddFilter(new StringAdvancedQueryFilter(model.Query, _advancedSearchService, _filterService));

            AddFilter(new StringExactFilter((score) => score.Card.Artist != null ? score.Card.Artist.Name : string.Empty, model.Artist));
            
            AddFilter(new GenericFilter(model.CardSet, (score, target) => score.Card.MatchesCardSet(target)));
            AddFilter(new GenericFilter(model.Scenario, (score, target) =>  _scenarioService.BelongsToScenario(score.Card.Slug, score.Card.CardType, target)));
            AddFilter(new GenericFilter(model.EncounterSet, (score, target) => score.Card.EncounterSet == target, (score, target) => score.Card.AlternateEncounterSet == target));

            AddFilter(new CardTypeFilter(model.CardType));
            AddFilter(new EnumFilter<CardSubtype>((score) => score.Card.CardSubtype, model.CardSubtype, (target) => { return target == "No Subtype" ? "None" : target; }));
            AddFilter(new EnumFilter<DeckType>((score) => score.Card.DeckType, model.DeckType));

            AddFilter(new EnumFilter<Sphere>((score) => score.Card.Sphere, model.Sphere));
            AddFilter(new EnumFilter<Uniqueness>((score) => score.Card.IsUnique ? Uniqueness.Yes : Uniqueness.No, model.IsUnique));
            AddFilter(new Filter((score) => _scenarioService.HasSetType(score.Card, model.SetType)));

            AddFilter(new ByteComparisonFilter((score) => score.Card.ResourceCost, model.Cost, model.CostOperator));
            AddFilter(new ByteComparisonFilter((score) => score.Card.ThreatCost, model.ThreatCost, model.ThreatCostOperator));
            AddFilter(new ByteComparisonFilter((score) => score.Card.EngagementCost, model.EngagementCost, model.EngagementCostOperator));
            
            AddFilter(new ByteComparisonFilter((score) => score.Card.Attack, model.Attack, model.AttackOp));
            AddFilter(new ByteComparisonFilter((score) => score.Card.Defense, model.Defense, model.DefenseOp));
            AddFilter(new ByteComparisonFilter((score) => score.Card.HitPoints, model.HitPoints, model.HitPointsOp));
            
            AddFilter(new ByteComparisonFilter((score) => score.Card.Willpower, model.Willpower, model.WillpowerOp));
            AddFilter(new ByteComparisonFilter((score) => score.Card.Threat, model.Threat, model.ThreatOp));
            AddFilter(new ByteComparisonFilter((score) => score.Card.QuestPoints, model.QuestPoints, model.QuestPointsOp));

            AddFilter(new TraitFilter(model.Trait));
            AddFilter(new KeywordFilter(model.Keyword));
            AddFilter(new VictoryPointFilter(model.VictoryPoints));

            AddFilter(new CategoryFilter<PlayerCategory>((score, cat) => _playerCategoryService.HasCategory(score.Card, cat), model.Category));
            AddFilter(new CategoryFilter<EncounterCategory>((score, cat) => _encounterCategoryService.HasCategory(score.Card, cat), model.EncounterCategory));
            AddFilter(new CategoryFilter<QuestCategory>((score, cat) => _questCategoryService.HasCategory(score.Card, cat), model.QuestCategory));

            if (_filters.Count == 1 && !model.SetType.HasValue)
            {
                AddFilter(new StringExactFilter((score) => score.Card.CardSet.Name, defaultCardSet));
                AddFilter(new EnumFilter<CardType>((score) => score.Card.CardType, defaultCardType));
            }
        }

        private void BuildSorts(SearchViewModel model)
        {
            _sorts.Clear();

            if (!model.Sort.HasValue)
            {
                AddSort((score) => score.Score(), false, true);
                AddSort((score) => _getPopularity(score.Card.Slug), false, false);
                AddSort((score) => _getVotes(score.Card), false, false);
                return;
            }

            if (model.Sort.Value == Sort.Alphabetical)
            {
                AddSort((score) => score.Card.Title, true, true);
                AddSort((score) => (int)score.Card.CardType, true, false);
            }
            if (model.Sort.Value == Sort.Popularity)
            {
                AddSort((score) => _getPopularity(score.Card.Slug), false, true);
                AddSort((score) => _getVotes(score.Card), false, false);
            }
            if (model.Sort.Value == Sort.Released)
                AddSort((score) => score.Card.CardSet.Product.Code, false, true);
            if (model.Sort.Value == Sort.Set_Number)
            {
                AddSort((score) => score.Card.CardSet.Product.Code, true, true);
                AddSort((score) => score.Card.CardNumber, true, false);
            }
            if (model.Sort.Value == Sort.Sphere_Type_Cost)
            {
                AddSort((score) => score.Card.Sphere, true, true);
                AddSort((score) => score.Card.CardType, true, false);
                AddSort((score) => score.Card.SortCost(), true, false);
            }
        }

        private void BuildOffsets(SearchViewModel model)
        {
            _offsets.Clear();

            var offset = model.Offset.HasValue ? model.Offset.Value : defaultOffset;
            AddOffset(offset);
        }

        private void BuildLimits(SearchViewModel model)
        {
            _limits.Clear();

            var limit = model.Limit.HasValue ? model.Limit.Value : defaultLimit;
            AddLimit(limit);
        }

        private IEnumerable<IComponent> Steps()
        {
            foreach (var filter in _filters)
                yield return filter;
            foreach (var sort in _sorts)
                yield return sort;
            foreach (var offset in _offsets)
                yield return offset;
            foreach (var limit in _limits)
                yield return limit;
        }

        private void AddFilter(IComponent filter)
        {
            if (filter == null || filter.IsEmpty)
                return;

            _filters.Add(filter);
        }

        private void AddSort<TKey>(Func<CardScore, TKey> keySelector, bool isAscending, bool isTopLevel)
        {
            _sorts.Add(new Sort<TKey>(keySelector, isAscending, isTopLevel));
        }

        private void AddOffset(int count)
        {
            _offsets.Add(new Offset(count));
        }

        private void AddLimit(int count)
        {
            _limits.Add(new Limit(count));
        }

        public Plan Build(SearchViewModel model)
        {
            BuildFilters(model);
            BuildSorts(model);
            BuildOffsets(model);
            BuildLimits(model);

            return new Plan(Steps());
        }
    }
}