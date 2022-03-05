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
        public StringBasicQueryFilter(string query, Language? lang)
        {
            if (string.IsNullOrWhiteSpace(query))
                return;

            predicate = (score) =>
            {
                var points = 0f;

                points += Matches((card, q) => card.Title.ToLowerSafe().Split(new char[]{' ', '-'}).Any(token => token.Equals(q)), query, score, 48);

                if (lang.GetValueOrDefault(Language.EN) != Language.EN) {
                    points += Matches((card, q) => card.GetTitle(lang.Value).ToLowerSafe().Split(new char[]{' ', '-'}).Any(token => token.Equals(q)), query, score, 48);
                    points += Matches((card, q) => card.GetTitle(lang.Value).IsEqualToLower(q), query, score, 36);
                    points += Matches((card, q) => card.GetTitle(lang.Value).ContainsLower(q), query, score, 12);
                    points += Matches((card, q) => card.GetTitle(lang.Value).FuzzyMatches(q), query, score, 6);
                    points += Matches((card, q) => card.GetText(lang.Value).ContainsLower(q), query, score, 4);
                    //points += Matches((card, q) => card.GetText(lang.Value).FuzzyMatches(q), query, score, 2);
                    points += Matches((card, q) => card.GetOppositeText(lang.Value).ContainsLower(q), query, score, 2);
                    //points += Matches((card, q) => card.GetOppositeText(lang.Value).FuzzyMatches(q), query, score, 1);
                    points += Matches((card, q) => card.TraitsByLang(lang.Value).Any(tr => tr.ToLowerSafe().Equals(q)), query, score, 4);    
                    points += Matches((card, q) => card.TraitsByLang(lang.Value).Any(tr => tr.ToLowerSafe().Contains(q)), query, score, 2);
                    points += Matches((card, q) => card.KeywordsByLang(lang.Value).Any(kw => kw.ToLowerSafe().Equals(q)), query, score, 4);
                    points += Matches((card, q) => card.KeywordsByLang(lang.Value).Any(kw => kw.ToLowerSafe().Contains(q)), query, score, 2);
                }

                points += Matches((card, q) => card.NormalizedTitle.ToLowerSafe().Split(new char[]{' ', '-'}).Any(token => token.Equals(q)), query, score, 48);
                points += Matches((card, q) => card.Title.IsEqualToLower(q), query, score, 36);
                points += Matches((card, q) => card.NormalizedTitle.IsEqualToLower(q), query, score, 36);
                points += Matches((card, q) => card.Title.StartsWithLower(q), query, score, 24);
                points += Matches((card, q) => card.NormalizedTitle.StartsWithLower(q), query, score, 24);
                points += Matches((card, q) => card.Title.ContainsLower(q), query, score, 12);
                points += Matches((card, q) => card.NormalizedTitle.ContainsLower(q), query, score, 12);
                points += Matches((card, q) => card.Title.FuzzyMatches(q), query, score, 6);
                points += Matches((card, q) => card.Text.ContainsLower(q), query, score, 4);
                //points += Matches((card, q) => card.Text.FuzzyMatches(q), query, score, 2);
                points += Matches((card, q) => card.OppositeText.ContainsLower(q), query, score, 2);
                //points += Matches((card, q) => card.OppositeText.FuzzyMatches(q), query, score, 1);
                points += Matches((card, q) => card.Traits.Any(tr => tr.ToLowerSafe().Equals(q)), query, score, 4);
                points += Matches((card, q) => card.NormalizedTraits.Any(tr => tr.ToLowerSafe().Equals(q)), query, score, 4);
                points += Matches((card, q) => card.Traits.Any(tr => tr.ToLowerSafe().Contains(q)), query, score, 2);
                points += Matches((card, q) => card.NormalizedTraits.Any(tr => tr.ToLowerSafe().Contains(q)), query, score, 2);
                points += Matches((card, q) => card.Keywords.Any(kw => kw.ToLowerSafe().Equals(q)), query, score, 4);
                points += Matches((card, q) => card.Keywords.Any(kw => kw.ToLowerSafe().Contains(q)), query, score, 2);

                score.AddScore(points);

                return points > 0;
            };
        }

        private float Matches(Func<LotRCard, string, bool> match, string query, CardScore score, float points)
        {
            return match(score.Card, query) ? points : 0;
        }
    }
}