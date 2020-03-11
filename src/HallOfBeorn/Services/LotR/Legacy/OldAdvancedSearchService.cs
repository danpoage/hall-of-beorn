/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Categories;

namespace HallOfBeorn.Services.LotR.Search
{
    [Obsolete]
    public class OldAdvancedSearchService : IAdvancedSearchService
    {
        public OldAdvancedSearchService(ICategoryService<PlayerCategory> playerCategoryService,
            ICategoryService<EncounterCategory> encounterCategoryService, 
            ICategoryService<QuestCategory> questCategoryService)
        {
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;
        }

        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;

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
                case "flavor":
                    if (orFilters)
                    {
                        predicate = (score) => { return names.Any(y => (!string.IsNullOrEmpty(score.Card.FlavorText) && score.Card.FlavorText.ContainsLower(y))); };
                    }
                    else
                    {
                        predicate = (score) => { return names.All(y => (!string.IsNullOrEmpty(score.Card.FlavorText) && score.Card.FlavorText.ContainsLower(y))); };
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
                    predicate = (score) => { return enums.Any(y => _playerCategoryService.HasCategory(score.Card, y.ToEnum<PlayerCategory>())); };
                    break;
                case "ecategory":
                    predicate = (score) => { return enums.Any(y => _encounterCategoryService.HasCategory(score.Card, y.ToEnum<EncounterCategory>())); };
                    break;
                case "qcategory":
                    predicate = (score) => { return enums.Any(y => _questCategoryService.HasCategory(score.Card, y.ToEnum<QuestCategory>())); };
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

            var orMode = false;
            var orResults = new List<CardScore>();

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

                List<CardScore> filterResults = new List<CardScore>();

                switch (field)
                {
                    case "and":
                        orMode = false;
                        if (orResults.Count > 0) {
                            results = orResults.Distinct().ToList();
                        }
                        break;
                    case "or":
                        orMode = true;
                        break;
                    case "title": 
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "cycle":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "set":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "product":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "type":
                        filterResults = FilterByEnum<CardType>(value, results, negate);
                        break;
                    case "sphere":
                        filterResults = FilterByEnum<Sphere>(value, results, negate);
                        break;
                    case "rcost":
                    case "tcost":
                    case "ecost":
                    case "threat":
                    case "wp":
                    case "atk":
                    case "def":
                    case "hp":
                        filterResults = FilterByByte(field, value, results, negate);
                        break;
                    case "trait":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "keyword":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "encounter":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "artist":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    case "category":
                    case "ecategory":
                    case "qcategory":
                        filterResults = FilterByEnum<PlayerCategory>(value, results, negate);
                        break;
                    case "victory":
                        filterResults = FilterByByte(field, value, results, negate);
                        break;
                    case "unique":
                        filterResults = FilterByBool(field, results, negate);
                        break;
                    case "saga":
                        filterResults = FilterByBool(field, results, negate);
                        break;
                    case "text":
                    case "shadow":
                    case "flavor":
                        filterResults = FilterByString(field, value, results, negate);
                        break;
                    default:
                        break;
                }

                if (orMode) {
                    orResults.AddRange(filterResults);
                } else {
                    results = filterResults;
                }
            }

            return orMode ? orResults.Distinct().ToList() : results;
        }
    }
}
*/