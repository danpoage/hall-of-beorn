using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR.Search
{
    public class PlanBuilder
    {
        public PlanBuilder(SearchViewModel model, ScenarioService scenarioService, CategoryService categoryService, RingsDbService ringsDbService, AdvancedSearchService advancedSearchService)
        {
            this.scenarioService = scenarioService;
            this.categoryService = categoryService;
            this.advancedSearchService = advancedSearchService;
            this.getPopularity = (slug) => { return ringsDbService.GetPopularity(slug); };
            this.getVotes = (card) => { return card.CardType == CardType.Hero ? 10000 + ringsDbService.GetVotes(card.Slug) : ringsDbService.GetVotes(card.Slug); };

            BuildFilters(model);
            BuildSorts(model);
            BuildOffsets(model);
            BuildLimits(model);
        }

        private readonly ScenarioService scenarioService;
        private readonly CategoryService categoryService;
        private readonly AdvancedSearchService advancedSearchService;
        private readonly Func<string, byte> getPopularity;
        private readonly Func<LotRCard, int> getVotes;

        private readonly List<IComponent> filters = new List<IComponent>();
        private readonly List<IComponent> sorts = new List<IComponent>();
        private readonly List<IComponent> offsets = new List<IComponent>();
        private readonly List<IComponent> limits = new List<IComponent>();

        private const string defaultCardSet = "Core Set";
        private const CardType defaultCardType = CardType.Hero;
        private const int defaultOffset = 0;
        private const int defaultLimit = 100;

        private void BuildFilters(SearchViewModel model)
        {
            AddFilter(new StringBasicQueryFilter(model.BasicQuery()));
            AddFilter(new StringAdvancedQueryFilter(model.Query, advancedSearchService));

            AddFilter(new StringExactFilter((score) => score.Card.Artist != null ? score.Card.Artist.Name : string.Empty, model.Artist));
            
            AddFilter(new GenericFilter(model.CardSet, (score, target) => score.Card.MatchesCardSet(target)));
            AddFilter(new GenericFilter(model.Scenario, (score, target) =>  scenarioService.BelongsToScenario(score.Card.Slug, score.Card.CardType, target)));
            AddFilter(new GenericFilter(model.EncounterSet, (score, target) => score.Card.EncounterSet == target, (score, target) => score.Card.AlternateEncounterSet == target));

            AddFilter(new CardTypeFilter(model.CardType));
            AddFilter(new EnumFilter<CardSubtype>((score) => score.Card.CardSubtype, model.CardSubtype, (target) => { return target == "No Subtype" ? "None" : target; }));
            AddFilter(new EnumFilter<DeckType>((score) => score.Card.DeckType, model.DeckType));

            AddFilter(new EnumFilter<Sphere>((score) => score.Card.Sphere, model.Sphere));
            AddFilter(new EnumFilter<Uniqueness>((score) => score.Card.IsUnique ? Uniqueness.Yes : Uniqueness.No, model.IsUnique));
            AddFilter(new Filter((score) => scenarioService.HasSetType(score.Card, model.SetType)));

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

            AddFilter(new CategoryFilter<Category>((score, cat) => categoryService.HasPlayerCategory(score.Card, cat), model.Category));
            AddFilter(new CategoryFilter<EncounterCategory>((score, cat) => categoryService.HasEncounterCategory(score.Card, cat), model.EncounterCategory));
            AddFilter(new CategoryFilter<QuestCategory>((score, cat) => categoryService.HasQuestCategory(score.Card, cat), model.QuestCategory));

            if (filters.Count == 1 && !model.SetType.HasValue)
            {
                AddFilter(new StringExactFilter((score) => score.Card.CardSet.Name, defaultCardSet));
                AddFilter(new EnumFilter<CardType>((score) => score.Card.CardType, defaultCardType));
            }
        }

        private void BuildSorts(SearchViewModel model)
        {
            if (!model.Sort.HasValue)
            {
                AddSort((score) => score.Score(), false, true);
                AddSort((score) => getPopularity(score.Card.Slug), false, false);
                AddSort((score) => getVotes(score.Card), false, false);
                return;
            }

            if (model.Sort.Value == Sort.Alphabetical)
            {
                AddSort((score) => score.Card.Title, true, true);
                AddSort((score) => (int)score.Card.CardType, true, false);
            }
            if (model.Sort.Value == Sort.Popularity)
            {
                AddSort((score) => getPopularity(score.Card.Slug), false, true);
                AddSort((score) => getVotes(score.Card), false, false);
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
            var offset = model.Offset.HasValue ? model.Offset.Value : defaultOffset;
            AddOffset(offset);
        }

        private void BuildLimits(SearchViewModel model)
        {
            var limit = model.Limit.HasValue ? model.Limit.Value : defaultLimit;
            AddLimit(limit);
        }

        private IEnumerable<IComponent> Steps()
        {
            foreach (var filter in filters)
                yield return filter;
            foreach (var sort in sorts)
                yield return sort;
            foreach (var offset in offsets)
                yield return offset;
            foreach (var limit in limits)
                yield return limit;
        }

        private void AddFilter(IComponent filter)
        {
            if (filter == null || filter.IsEmpty)
                return;

            filters.Add(filter);
        }

        private void AddSort<TKey>(Func<CardScore, TKey> keySelector, bool isAscending, bool isTopLevel)
        {
            sorts.Add(new Sort<TKey>(keySelector, isAscending, isTopLevel));
        }

        private void AddOffset(int count)
        {
            offsets.Add(new Offset(count));
        }

        private void AddLimit(int count)
        {
            limits.Add(new Limit(count));
        }

        public Plan ToPlan()
        {
            return new Plan(Steps());
        }
    }
}