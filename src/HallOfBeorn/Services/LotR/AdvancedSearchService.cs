using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;

namespace HallOfBeorn.Services.LotR
{
    public class AdvancedSearchService
    {
        private Func<CardScore, bool> NegateFilter(Func<CardScore, bool> predicate)
        {
            return (score) => { return !predicate(score); };
        }

        private List<CardScore> FilterByByte(string typeName, string value, List<CardScore> results, bool negate)
        {
            //Params: card value, filter values. returns bool
            Func<byte, List<byte>, bool> comparison = null;

            if (value.StartsWith(">"))
            {
                comparison = (cardValue, filters) => { return filters.Any(f => cardValue > f); };
            }
            else if (value.StartsWith("<"))
            {
                comparison = (cardValue, filters) => { return filters.Any(f => cardValue < f); };
            }
            else if (value.Contains("-"))
            {
                comparison = (cardValue, filters) =>
                {
                    if (filters.Count != 2 || filters[0] > filters[1])
                        return false;

                    return cardValue >= filters[0] && cardValue <= filters[1];
                };
            }
            else
            {
                comparison = (cardValue, filters) => { return filters.Any(f => cardValue == f); };
            }

            value = value.TrimStart('>', '<').Replace("-", ",");

            var tokens = value.SplitOnComma();

            var bytes = new List<byte>();

            foreach (var token in tokens)
            {
                var item = (byte)0;
                if (byte.TryParse(token, out item))
                {
                    bytes.Add(item);
                }
            }

            Func<CardScore, bool> predicate = null;

            switch (typeName)
            {
                case "rcost":
                    predicate = (score) => { return score.Card.ResourceCost.HasValue && comparison(score.Card.ResourceCost.Value, bytes); };
                    break;
                case "tcost":
                    predicate = (score) => { return score.Card.ThreatCost.HasValue && comparison(score.Card.ThreatCost.Value, bytes); };
                    break;
                case "ecost":
                    predicate = (score) => { return score.Card.EngagementCost.HasValue && comparison(score.Card.EngagementCost.Value, bytes); };
                    break;
                case "threat":
                    predicate = (score) => { return score.Card.Threat.HasValue && comparison(score.Card.Threat.Value, bytes); };
                    break;
                case "wp":
                    predicate = (score) => { return score.Card.Willpower.HasValue && comparison(score.Card.Willpower.Value, bytes); };
                    break;
                case "qp":
                    predicate = (score) => { return score.Card.QuestPoints.HasValue && comparison(score.Card.QuestPoints.Value, bytes); };
                    break;
                case "atk":
                    predicate = (score) => { return score.Card.Attack.HasValue && comparison(score.Card.Attack.Value, bytes); };
                    break;
                case "def":
                    predicate = (score) => { return score.Card.Defense.HasValue && comparison(score.Card.Defense.Value, bytes); };
                    break;
                case "hp":
                    predicate = (score) => { return score.Card.HitPoints.HasValue && comparison(score.Card.HitPoints.Value, bytes); };
                    break;
                case "victory":
                    predicate = (score) => { return comparison(score.Card.VictoryPoints, bytes); };
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        private List<CardScore> FilterByString(string typeName, string value, List<CardScore> results, bool negate)
        {
            var names = value.SplitOnCommaOrPipe().Select(x => x.Replace('+', ' ').Replace('_', ' ')).ToList();
            Func<CardScore, bool> predicate = null;

            var orFilters = value.Contains('|');

            switch (typeName)
            {
                case "title":
                    predicate = (score) => { return names.Any(y => score.Card.Title.MatchesWildcard(y) || score.Card.NormalizedTitle.MatchesWildcard(y)); };
                    break;
                case "cycle":
                    predicate = (score) => { return names.Any(y => score.Card.CardSet.Cycle.MatchesWildcard(y)); };
                    break;
                case "set":
                    predicate = (score) => { return names.Any(y => score.Card.CardSet.Name.MatchesWildcard(y) || score.Card.CardSet.Abbreviation.MatchesWildcard(y) || (!string.IsNullOrEmpty(score.Card.CardSet.AlternateName) && score.Card.CardSet.AlternateName.MatchesWildcard(y)) || (!string.IsNullOrEmpty(score.Card.CardSet.NormalizedName) && score.Card.CardSet.NormalizedName.MatchesWildcard(y))); };
                    break;
                case "product":
                    predicate = (score) => { return names.Any(y => score.Card.CardSet.Product != null && (score.Card.CardSet.Product.Name.Replace(":", string.Empty).MatchesWildcard(y))); };
                    break;
                case "encounter":
                    predicate = (score) => { return names.Any(y => score.Card.EncounterSet.MatchesWildcard(y)); };
                    break;
                case "trait":
                    predicate = (score) => { return names.Any(y => score.Card.Traits.Select(z => z.Trim(' ', '.')).Any(a => a.MatchesWildcard(y)) || score.Card.NormalizedTraits.Select(z => z.Trim(' ', '.')).Any(a => a.MatchesWildcard(y))); };
                    break;
                case "keyword":
                    predicate = (score) => { return names.Any(y => score.Card.Keywords.Select(z => z.Trim(' ', '.')).Any(a => a.MatchesWildcard(y)) || score.Card.NormalizedKeywords.Select(z => z.Trim(' ', '.')).Any(a => a.MatchesWildcard(y))); };
                    break;
                case "artist":
                    predicate = (score) => { return names.Any(y => (score.Card.Artist != null && score.Card.Artist.Name.MatchesWildcard(y)) || (score.Card.SecondArtist != null && score.Card.SecondArtist.Name.MatchesWildcard(y))); };
                    break;
                case "text":
                    if (orFilters)
                    {
                        predicate = (score) => { return names.Any(y => (score.Card.Text.ContainsLower(y))); };
                    }
                    else
                    {
                        predicate = (score) => { return names.All(y => (score.Card.Text.ContainsLower(y))); };
                    }
                    break;
                case "shadow":
                    if (orFilters)
                    {
                        predicate = (score) => { return names.Any(y => (!string.IsNullOrEmpty(score.Card.Shadow) && score.Card.Shadow.ContainsLower(y))); };
                    }
                    else
                    {
                        predicate = (score) => { return names.All(y => (!string.IsNullOrEmpty(score.Card.Shadow) && score.Card.Shadow.ContainsLower(y))); };
                    }
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        private List<CardScore> FilterByBool(string typeName, List<CardScore> results, bool negate)
        {
            Func<CardScore, bool> predicate = null;

            switch (typeName)
            {
                case "unique":
                    predicate = (score) => { return score.Card.IsUnique; };
                    break;
                case "custom":
                    predicate = (score) => { return score.Card.CardSet.SetType == SetType.CUSTOM; };
                    break;
                case "saga":
                    predicate = (score) => { return score.Card.CardSet.SetType == SetType.Saga_Expansion && (score.Card.CardType == CardType.Treasure || score.Card.CardSubtype == CardSubtype.Boon || score.Card.CardSubtype == CardSubtype.Burden || score.Card.Sphere == Sphere.Baggins || score.Card.Sphere == Sphere.Fellowship); };
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        private List<CardScore> FilterByEnum<TEnum>(string value, List<CardScore> results, bool negate)
            where TEnum : struct
        {
            var tokens = value.SplitOnComma();

            var enums = new List<TEnum>();

            foreach (var token in tokens)
            {
                var parsedItem = token.ParseEnum<TEnum>();
                if (parsedItem.Item2)
                {
                    enums.Add(parsedItem.Item1);
                }
            }

            var typeName = typeof(TEnum).Name.ToLowerSafe();
            Func<CardScore, bool> predicate = null;

            switch (typeName)
            {
                case "cardtype":
                    predicate = (score) => { return enums.Any(y => y.ToEnum<CardType>() == score.Card.CardType); };
                    break;
                case "sphere":
                    predicate = (score) => { return enums.Any(y => y.ToEnum<Sphere>() == score.Card.Sphere); };
                    break;
                case "category":
                    predicate = (score) => { return enums.Any(y => score.Card.Categories.Any(z => y.ToEnum<Category>() == z)); };
                    break;
                default:
                    break;
            }

            if (predicate != null)
            {
                if (negate)
                {
                    predicate = NegateFilter(predicate);
                }

                results = results.Where(predicate).ToListSafe();
            }

            return results;
        }

        public List<CardScore> Search(SearchViewModel searchModel, List<CardScore> results)
        {
            var query = searchModel.Query;
            var filters = query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe().Where(x => x.StartsWith("-") || x.StartsWith("+")).ToListSafe();

            foreach (var filter in filters)
            {
                var fields = filter.Split(new char[] { ':', '=' }, StringSplitOptions.RemoveEmptyEntries).ToListSafe();

                if (fields.Count == 0 || string.IsNullOrEmpty(fields[0]))
                    continue;

                var negate = (fields[0][0] == '-');
                var field = fields[0].ToLower().Trim('-', '+');
                var value = string.Empty;

                if (fields.Count > 1)
                {
                    value = fields[1];
                }

                switch (field)
                {
                    case "title":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "cycle":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "set":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "product":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "type":
                        results = FilterByEnum<CardType>(value, results, negate);
                        break;
                    case "sphere":
                        results = FilterByEnum<Sphere>(value, results, negate);
                        break;
                    case "rcost":
                    case "tcost":
                    case "ecost":
                    case "threat":
                    case "wp":
                    case "atk":
                    case "def":
                    case "hp":
                        results = FilterByByte(field, value, results, negate);
                        break;
                    case "trait":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "keyword":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "encounter":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "artist":
                        results = FilterByString(field, value, results, negate);
                        break;
                    case "category":
                        results = FilterByEnum<Category>(value, results, negate);
                        break;
                    case "victory":
                        results = FilterByByte(field, value, results, negate);
                        break;
                    case "unique":
                        results = FilterByBool(field, results, negate);
                        break;
                    case "saga":
                        results = FilterByBool(field, results, negate);
                        break;
                    case "text":
                    case "shadow":
                        results = FilterByString(field, value, results, negate);
                        break;
                    /*
                    case "custom":
                        results = FilterByBool(field, results, negate);
                        if (!negate)
                        {
                            searchModel.Custom = true;
                        }
                        break;*/
                    default:
                        break;
                }
            }

            return results;
        }
    }
}