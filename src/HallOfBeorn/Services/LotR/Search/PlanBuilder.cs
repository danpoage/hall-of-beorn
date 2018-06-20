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
            AddFilter(new StringExactFilter((score) => score.Card.Artist.Name, model.Artist));
            AddFilter(new ByteComparisonFilter((score) => score.Card.Attack, model.Attack, model.AttackOp));
            //AddFilter(new StringFuzzyFilter((score) => score.Card.CardSet.
                //Name, model.CardSet, (s1, s2) => );
            AddFilter(new EnumFilter<CardSubtype>((score) => score.Card.CardSubtype, model.CardSubtype));
            AddFilter(new ByteComparisonFilter((score) => score.Card.Defense, model.Defense, model.DefenseOp));
            
            //if (HasFilter(model.Artist))
            //    AddFilter((score) => score.Card.Artist != null && score.Card.Artist.Name == model.Artist);
            //if (HasFilter(model.Attack))
            //    AddNumericFilter<byte?>((score) => score.Card.Attack, model.AttackOp, model.Attack);
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