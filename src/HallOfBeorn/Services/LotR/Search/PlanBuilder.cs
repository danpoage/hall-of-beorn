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
        public PlanBuilder(SearchViewModel model, ScenarioService scenarioService, CategoryService categoryService)
        {
            this.scenarioService = scenarioService;
            this.categoryService = categoryService;

            BuildFilters(model);
            BuildSorts(model);
            BuildLimits(model);
        }

        private readonly ScenarioService scenarioService;
        private readonly CategoryService categoryService;

        private readonly List<IComponent> filters = new List<IComponent>();
        private readonly List<IComponent> sorts = new List<IComponent>();
        private readonly List<IComponent> limits = new List<IComponent>();

        private void BuildFilters(SearchViewModel model)
        {
            AddFilter(new StringExactFilter((score) => score.Card.Artist.Name, model.Artist));
            
            AddFilter(new GenericFilter(model.CardSet, (score, target) => score.Card.MatchesCardSet(target)));
            AddFilter(new GenericFilter(model.Scenario, (score, target) =>  scenarioService.BelongsToScenario(score.Card.Slug, score.Card.CardType, target)));
            AddFilter(new GenericFilter(model.EncounterSet, (score, target) => score.Card.EncounterSet == target, (score, target) => score.Card.AlternateEncounterSet == target));

            AddFilter(new EnumFilter<CardType>((score) => score.Card.CardType, model.CardType));
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
        }

        private void BuildSorts(SearchViewModel model)
        {
        }

        private void BuildLimits(SearchViewModel model)
        {
        }

        private IEnumerable<IComponent> Steps()
        {
            foreach (var filter in filters)
                yield return filter;
            foreach (var sort in sorts)
                yield return sort;
            foreach (var limit in limits)
                yield return limit;
        }

        private void AddFilter(Filter filter)
        {
            if (filter == null || filter.IsEmpty)
                return;

            filters.Add(filter);
        }

        private void AddSortAscending<TKey>(Func<CardScore, TKey> keySelector)
        {
            sorts.Add(new Sort<TKey>(keySelector, true));
        }

        private void AddSortDescending<TKey>(Func<CardScore, TKey> keySelector)
        {
            sorts.Add(new Sort<TKey>(keySelector, false));
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