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
        public PlanBuilder(SearchViewModel model)
        {
            BuildFilters(model);
            BuildSorts(model);
            BuildLimits(model);
        }

        private readonly List<IComponent> filters = new List<IComponent>();
        private readonly List<IComponent> sorts = new List<IComponent>();
        private readonly List<IComponent> limits = new List<IComponent>();

        private void BuildFilters(SearchViewModel model)
        {
            if (HasFilter(model.Artist))
                AddFilter((score) => score.Card.Artist != null && score.Card.Artist.Name == model.Artist);
            if (HasFilter(model.Attack))
                AddNumericFilter<byte?>((score) => score.Card.Attack, model.AttackOp, model.Attack);
        }

        private void BuildSorts(SearchViewModel model)
        {
        }

        private void BuildLimits(SearchViewModel model)
        {
        }

        private bool HasFilter(string value)
        {
            return !string.IsNullOrWhiteSpace(value) && value != "Any";
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

        private void AddFilter(Func<CardScore, bool> predicate)
        {
            filters.Add(new Filter(predicate));
        }

        private void AddNumericFilter<TValue>(Func<CardScore, TValue> valueSelector, NumericOperator? op, string target)
        {
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