using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Search
{
    public class StringBasicQueryFilter : Filter
    {
        public StringBasicQueryFilter(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return;

            predicate = (score) =>
            {
                var points = 0f;

                points += Matches((card, q) => card.Title.IsEqualToLower(q), query, score, 20);
                points += Matches((card, q) => card.NormalizedTitle.IsEqualToLower(q), query, score, 20);
                points += Matches((card, q) => card.Title.StartsWithLower(q), query, score, 14);
                points += Matches((card, q) => card.NormalizedTitle.StartsWithLower(q), query, score, 14);
                points += Matches((card, q) => card.Title.ContainsLower(q), query, score, 11);
                points += Matches((card, q) => card.NormalizedTitle.ContainsLower(q), query, score, 11);
                points += Matches((card, q) => card.Text.ContainsLower(q), query, score, 10);
                points += Matches((card, q) => card.OppositeText.ContainsLower(q), query, score, 10);
                points += Matches((card, q) => card.Traits.Any(tr => tr.ToLowerSafe().Equals(q)), query, score, 13);
                points += Matches((card, q) => card.NormalizedTraits.Any(tr => tr.ToLowerSafe().Equals(q)), query, score, 13);
                points += Matches((card, q) => card.Traits.Any(tr => tr.ToLowerSafe().Contains(q)), query, score, 12);
                points += Matches((card, q) => card.NormalizedTraits.Any(tr => tr.ToLowerSafe().Contains(q)), query, score, 12);
                points += Matches((card, q) => card.Keywords.Any(kw => kw.ToLowerSafe().Equals(q)), query, score, 15);
                points += Matches((card, q) => card.Keywords.Any(kw => kw.ToLowerSafe().Contains(q)), query, score, 11);
                
                return points > 0;
            };
        }

        private float Matches(Func<LotRCard, string, bool> match, string query, CardScore score, float points)
        {
            return match(score.Card, query) ? points : 0;
        }
    }
}