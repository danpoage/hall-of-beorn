using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.Arkham;
using HallOfBeorn.Models.Arkham.ViewModels;

namespace HallOfBeorn.Services.Arkham
{
    public class ArkhamSearchService
    {
        public ArkhamSearchService(ArkhamProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        private readonly ArkhamProductRepository productRepository;

        private bool cardMatchesNumberFilter(string modelValue, Number? cardValue)
        {
            if (!cardValue.HasValue)
            {
                return false;
            }

            var isPerInvestigator = modelValue.EndsWith(ArkhamCardViewModel.PerInvestigatorDescription);
            var isX = modelValue == "X";
            var isNA = modelValue == "-";
            byte value = 0;
            if (!isX && !isNA)
            {
                byte.TryParse(modelValue.Replace(ArkhamCardViewModel.PerInvestigatorDescription, string.Empty).Trim(), out value);
            }

            if (cardValue.Value.Value != value)
            {
                return false;
            }
            if (cardValue.Value.IsX != isX)
            {
                return false;
            }
            if (cardValue.Value.IsPerInvestigator != isPerInvestigator)
            {
                return false;
            }
            if (cardValue.Value.IsNotApplicable != isNA)
            {
                return false;
            }

            return true;
        }

        #region Filters

        private static Func<string, byte?, bool> hasVictoryPoints = (filter, vp) =>
        {
            if (!vp.HasValue)
                return false;

            var f = filter.Replace("Victory ", string.Empty).Trim();
            if (string.IsNullOrEmpty(f))
                return false;
            byte fNum = 0;
            byte.TryParse(f, out fNum);

            return fNum == vp.Value;
        };

        private static Func<string, string> normalizer = x => { return x.ToLowerSafe().NormalizeString().Replace(".", string.Empty).Replace("\"", string.Empty); };

        private Func<string, ArkhamCard, float> scoreTitle = (query, card) =>
        {
            var title = normalizer(card.Title);
            var score = 0;

            if (title == query)
            {
                score = 90 + query.Length;
            }
            else if (title.StartsWith(query))
            {
                score = 70 + query.Length;
            }
            else if (title.EndsWith(query))
            {
                score = 50 + query.Length;
            }
            else if (title.Contains(query))
            {
                score = 40 + query.Length;
            }

            return score;
        };

        private Func<string, ArkhamCard, float> scoreSubtitle = (query, card) =>
        {
            var score = 0;
            var subtitle = card.Subtitle.ToLowerSafe().NormalizeString();

            if (subtitle == query) {
                score = 90 + query.Length;
            } else if (subtitle.StartsWith(query)) {
                score = 70 + query.Length;
            } else if (subtitle.EndsWith(query)) {
                score = 40 + query.Length;
            } else if (subtitle.Contains(query)) {
                score = 30 + query.Length;
            }

            return score;
        };

        private Func<string, ArkhamCard, float> scoreTraits = (query, card) =>
        {
            var highest = 0;
            var current = 0;
            
            foreach (var trait in card.Traits().Select(normalizer))
            {
                if (trait == query) {
                    current = 50;
                } else if (query.Length > 3) {
                    if (trait.StartsWith(query)) {
                        current = 25;
                    } else if (trait.EndsWith(query)) {
                        current = 20;
                    } else if (trait.Contains(query)) {
                        current = 15;
                    }
                }

                if (current > highest)
                    highest = current;
            }

            return highest;
        };

        private Func<string, ArkhamCard, float> scoreKeywords = (query, card) =>
        {
            var normQuery = query.Replace(".", string.Empty);
            var highest = 0;
            var current = 0;
            
            foreach (var keyword in card.Keywords().Select(normalizer))
            {
                if (keyword == normQuery) {
                    current = 33;
                } else if (normQuery.Length > 3) {
                    if (keyword.StartsWith(normQuery)) {
                        current = 17;
                    } else if (keyword.EndsWith(normQuery)) {
                        current = 13;
                    } else if (keyword.Contains(normQuery)) {
                        current = 7;
                    }
                }

                if (current > highest)
                    highest = current;
            }

            return highest;
        };

        private static Func<string, string, float> scoreText = (query, text) =>
        {
            if (text == query) {
                return 100;
            } else if (text.StartsWith(query)) {
                return 50 + query.Length;
            } else if (text.EndsWith(query)) {
                return 45 + query.Length;
            } else if (text.Contains(query)) {
                return 35 + query.Length;
            }

            return 0;
        };

        private Func<string, ArkhamCard, float> scoreFrontText = (query, card) =>
        {
            return scoreText(query, normalizer(card.FrontText));
        };

        private Func<string, ArkhamCard, float> scoreBackText = (query, card) =>
        {
            return scoreText(query, normalizer(card.BackText));
        };

        #endregion

        private float getQueryScore(ArkhamSearchViewModel model, ArkhamCard card)
        {
            var query = normalizer(model.Query);

            var filters = new List<Func<string, ArkhamCard, float>>
                {
                    scoreTitle, scoreSubtitle,
                    scoreTraits, scoreKeywords,
                    scoreFrontText, scoreBackText
                };
            
            float highest = 0;
            float current = 0;

            foreach (var filter in filters)
            {
                current = filter(query, card);
                if (current > highest)
                {
                    if (current > 100)
                        current = 100;

                    highest = current;
                }
            }

            return highest;
        }

        private bool checkByteValue(byte filterValue, NumericOperator op, Number cardValue)
        {
            return checkStringValue(filterValue.ToString(), op, cardValue);
        }

        private bool checkStringValue(string filterValue, NumericOperator op, Number cardValue)
        {
            if (string.IsNullOrEmpty(filterValue) || filterValue == "Any") {
                return true;
            }

            var IsPerInvestigator = filterValue.Contains(ArkhamCardViewModel.PerInvestigatorDescription);
            var isX = false;
            var isNotApplicable = false;
            byte val = 0;
            var token = filterValue.Replace(ArkhamCardViewModel.PerInvestigatorDescription, string.Empty).Trim();
            if (!byte.TryParse(token, out val)) {
                isX = (token == "X");
                isNotApplicable = (token == "-");
            }

            var filterNumber = new Number { Value = val, IsX = isX, IsNotApplicable = isNotApplicable, IsPerInvestigator = IsPerInvestigator };

            if (!filterNumber.FlagsMatch(cardValue))
                return false;

            if (isNotApplicable || isX) {
                return true;
            }

            switch (op)
            {
                case NumericOperator.gt:
                    return cardValue > filterNumber;
                case NumericOperator.gteq:
                    return cardValue >= filterNumber;
                case NumericOperator.lt:
                    return cardValue < filterNumber;
                case NumericOperator.lteq:
                    return cardValue <= filterNumber;
                default:
                case NumericOperator.eq:
                    return cardValue == filterNumber;
            }
        }

        private bool byteFiltersCheck(ArkhamSearchViewModel model, ArkhamCard card, bool filterCheck) {

            var checks = new List<Tuple<byte?, NumericOperator?, Number?>>() {
                    new Tuple<byte?, NumericOperator?, Number?>(model.Willpower, model.WillpowerOp, card.Willpower),
                    new Tuple<byte?, NumericOperator?, Number?>(model.Intellect, model.IntellectOp, card.Intellect),
                    new Tuple<byte?, NumericOperator?, Number?>(model.Combat, model.CombatOp, card.Combat),
                    new Tuple<byte?, NumericOperator?, Number?>(model.Agility, model.AgilityOp, card.Agility)
            };

            foreach (var c in checks) {
                if (c.Item1.HasValue && c.Item2.HasValue)
                {
                    if (filterCheck) {
                        return true;
                    } else {
                        if (!c.Item3.HasValue)
                            return false;

                        if (!checkByteValue(c.Item1.Value, c.Item2.Value, c.Item3.Value))
                            return false;
                    }
                }
            }

            return !filterCheck;
        }

        private bool stringFiltersCheck(ArkhamSearchViewModel model, ArkhamCard card, bool filterCheck) {

            var checks = new List<Tuple<string, NumericOperator?, Number?>>() {
                    new Tuple<string, NumericOperator?, Number?>(model.Cost, model.CostOp, card.Cost),
                    new Tuple<string, NumericOperator?, Number?>(model.Level, model.LevelOp, Number.Optional(card.Level)),
                    new Tuple<string, NumericOperator?, Number?>(model.EnemyFightValue, model.EnemyFightValueOp, card.EnemyFightValue),
                    new Tuple<string, NumericOperator?, Number?>(model.EnemyHealthValue, model.EnemyHealthValueOp, card.EnemyHealthValue),
                    new Tuple<string, NumericOperator?, Number?>(model.EnemyEvadeValue, model.EnemyEvadeValueOp, card.EnemyEvadeValue),
                    new Tuple<string, NumericOperator?, Number?>(model.Damage, model.DamageOp, card.Damage),
                    new Tuple<string, NumericOperator?, Number?>(model.Horror, model.HorrorOp, card.Horror),
                    new Tuple<string, NumericOperator?, Number?>(model.DoomThreshold, model.DoomThresholdOp, card.DoomThreshold),
                    new Tuple<string, NumericOperator?, Number?>(model.ClueThreshold, model.ClueThresholdOp, card.ClueThreshold),
                    new Tuple<string, NumericOperator?, Number?>(model.Health, model.HealthOp, card.Health),
                    new Tuple<string, NumericOperator?, Number?>(model.Sanity, model.SanityOp, card.Sanity)
            };

            foreach (var c in checks) {
                if (!string.IsNullOrEmpty(c.Item1) && c.Item2.HasValue)
                {
                    if (filterCheck) {
                        return true;
                    } else {
                        if (!c.Item3.HasValue)
                            return false;

                        if (!checkStringValue(c.Item1, c.Item2.Value, c.Item3.Value))
                            return false;
                    }
                }
            }

            return !filterCheck;
        }

        public IEnumerable<ArkhamSearchResult> Search(ArkhamSearchViewModel model)
        {
            var results = new List<ArkhamSearchResult>();

            foreach (var product in productRepository.Products())
            {
                foreach (var card in product.Cards())
                {
                    float score = string.IsNullOrEmpty(model.Query) ? 100 : 0;
                    var hasFilter = false;

                    if (!string.IsNullOrEmpty(model.Query))
                    {
                        hasFilter = true;
                        score = getQueryScore(model, card);

                        if (score == 0)
                            continue;
                    }

                    if (!string.IsNullOrEmpty(model.Product) && model.Product != "Any")
                    {
                        hasFilter = true;
                        if (card.Product.Name != model.Product)
                            continue;
                    }
                    if (model.CardType.HasValue && model.CardType != ArkhamCardType.None)
                    {
                        hasFilter = true;
                        if (card.CardType != model.CardType.Value)
                            continue;
                    }
                    if (model.DeckType.HasValue && model.DeckType.Value != ArkhamDeckType.None) {
                        hasFilter = true;
                        if (card.DeckType != model.DeckType.Value)
                            continue;
                    }
                    if (model.IsUnique.HasValue && model.IsUnique.Value != Uniqueness.Any) {
                        hasFilter = true;
                        if (model.IsUnique == Uniqueness.Yes && !card.IsUnique || model.IsUnique == Uniqueness.No && card.IsUnique)
                            continue;
                    }
                    if (model.ClassSymbol.HasValue && model.ClassSymbol != ClassSymbol.None)
                    {
                        hasFilter = true;
                        if (card.ClassSymbol != model.ClassSymbol.Value)
                            continue;
                    }
                    
                    if (model.SkillIcon.HasValue && model.SkillIcon.Value != SkillIcon.None) {
                        hasFilter = true;
                        if (!card.SkillIcons().Any(x => x == model.SkillIcon))
                            continue;
                    }

                    if (model.Slot.HasValue && model.Slot.Value != AssetSlot.None)
                    {
                        hasFilter = true;
                        if (!card.Slot.HasValue || card.Slot.Value != model.Slot.Value)
                            continue;
                    }

                    if (byteFiltersCheck(model, card, true)) {
                        hasFilter = true;
                        if (!byteFiltersCheck(model, card, false)) {
                            continue;
                        }
                    }

                    if (stringFiltersCheck(model, card, true)) {
                        hasFilter = true;
                        if (!stringFiltersCheck(model, card, false)) {
                            continue;
                        }
                    }

                    if (!string.IsNullOrEmpty(model.Trait) && model.Trait != "Any")
                    {
                        hasFilter = true;
                        if (!card.Traits().Any(x => x.Replace(".", "") == model.Trait.Replace(".", "")))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Keyword) && model.Keyword != "Any")
                    {
                        hasFilter = true;
                        if (!card.Keywords().Any(x => x.Replace(".", "") == model.Keyword.Replace(".", "")))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.VictoryPoints) && model.VictoryPoints != "Any")
                    {
                        hasFilter = true;
                        if (!hasVictoryPoints(model.VictoryPoints, card.VictoryPoints))
                            continue;
                    }
                    if (model.LocationSymbol.HasValue && model.LocationSymbol.Value != ConnectionSymbol.None)
                    {
                        hasFilter = true;
                        if ((!card.LocationSymbol.HasValue || model.LocationSymbol.Value != card.LocationSymbol))
                            continue;
                    }
                    if (model.ConnectsTo.HasValue && model.ConnectsTo.Value != ConnectionSymbol.None)
                    {
                        hasFilter = true;
                        if (!card.Connections().Any(x => x == model.ConnectsTo.Value))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.EnemyFightValue) && model.EnemyFightValue != "Any")
                    {
                        hasFilter = true;
                        if (!cardMatchesNumberFilter(model.EnemyFightValue, card.EnemyFightValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.EnemyHealthValue) && model.EnemyHealthValue != "Any")
                    {
                        hasFilter = true;
                        if (!cardMatchesNumberFilter(model.EnemyHealthValue, card.EnemyHealthValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.EnemyEvadeValue) && model.EnemyEvadeValue != "Any")
                    {
                        hasFilter = true;
                        if (!cardMatchesNumberFilter(model.EnemyEvadeValue, card.EnemyEvadeValue))
                            continue;
                    }

                    if (!string.IsNullOrEmpty(model.Artist) && model.Artist != "Any") {
                        hasFilter = true;
                        if (model.Artist != card.Artist.Name)
                            continue;
                    }

                    if (!hasFilter && card.CardType != ArkhamCardType.Investigator) {
                        continue;
                    }

                    results.Add(new ArkhamSearchResult(card, score));
                }
            }

            if (!model.Sort.HasValue)
            {
                return results.OrderByDescending(x => x.Score).ToList();
            }

            switch (model.Sort)
            {
                case ArkhamSearchSort.Alphabetical:
                    return results.OrderBy(x => x.Card.Title).ToList();
                case ArkhamSearchSort.Set_Number:
                    return results.OrderBy(x => x.Card.Product.ReleaseDate).ThenBy(x => x.Card.CardNumber).ToList();
                default:
                    return results.OrderByDescending(x => x.Score).ToList();
            }
        }
    }
}