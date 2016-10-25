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

        private static Func<string, string> normalizer = x => { return x.ToLowerSafe().NormalizeString().Replace(".", string.Empty); };

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

        public IEnumerable<ArkhamSearchResult> Search(ArkhamSearchViewModel model)
        {
            var results = new List<ArkhamSearchResult>();

            foreach (var product in productRepository.Products())
            {
                foreach (var card in product.Cards())
                {
                    float score = string.IsNullOrEmpty(model.Query) ? 100 : 0;

                    if (!string.IsNullOrEmpty(model.Query))
                    {
                        score = getQueryScore(model, card);

                        if (score == 0)
                            continue;
                    }

                    if (!string.IsNullOrEmpty(model.Product) && model.Product != "Any" && card.Product.Name != model.Product)
                    {
                        continue;
                    }
                    if (model.CardType.HasValue && model.CardType != ArkhamCardType.None && card.CardType != model.CardType.Value)
                    {
                        continue;
                    }
                    if (model.DeckType.HasValue && model.DeckType.Value != ArkhamDeckType.None && card.DeckType != model.DeckType.Value) {
                        continue;
                    }
                    if (model.IsUnique.HasValue && model.IsUnique.Value != Uniqueness.Any && (model.IsUnique == Uniqueness.Yes && !card.IsUnique || model.IsUnique == Uniqueness.No && card.IsUnique)) {
                        continue;
                    }
                    if (model.CardClass.HasValue && model.CardClass != ClassSymbol.None && card.ClassSymbol != model.CardClass.Value)
                    {
                        continue;
                    }
                    if (model.Health.HasValue && model.Health.Value > 0 && card.Health != model.Health.Value) {
                        continue;
                    }
                    if (model.Sanity.HasValue && model.Sanity.Value > 0 && card.Sanity != model.Sanity.Value) {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.Cost) && model.Cost != "Any" && (!card.Cost.HasValue || model.Cost != card.Cost.Value.ToString()))
                    {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.Level) && model.Level != "Any" && (!card.Level.HasValue || model.Level != card.Level.Value.ToString()))
                    {
                        continue;
                    }

                    if (model.SkillIcon.HasValue && model.SkillIcon.Value != SkillIcon.None && !card.SkillIcons().Any(x => x == model.SkillIcon)) {
                        continue;
                    }
                    if (model.Willpower.HasValue && model.Willpower.Value > 0 && card.Willpower.HasValue && model.Willpower.Value != card.Willpower.Value.Value)
                    {
                        continue;
                    }
                    if (model.Intellect.HasValue && model.Intellect.Value > 0 && card.Intellect.HasValue && model.Intellect.Value != card.Intellect.Value.Value)
                    {
                        continue;
                    }
                    if (model.Combat.HasValue && model.Combat.Value > 0 && card.Combat.HasValue && model.Combat.Value != card.Combat.Value.Value)
                    {
                        continue;
                    }
                    if (model.Agility.HasValue && model.Agility.Value > 0 && card.Agility.HasValue && model.Agility.Value != card.Agility.Value.Value)
                    {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.Trait) && model.Trait != "Any" && !card.Traits().Any(x => x.Replace(".", "") == model.Trait.Replace(".", "")))
                    {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.Keyword) && model.Keyword != "Any" && !card.Keywords().Any(x => x.Replace(".", "") == model.Keyword.Replace(".", "")))
                    {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.VictoryPoints) && model.VictoryPoints != "Any" && !hasVictoryPoints(model.VictoryPoints, card.VictoryPoints))
                    {
                        continue;
                    }
                    if (model.LocationSymbol.HasValue && model.LocationSymbol.Value != ConnectionSymbol.None && (!card.LocationSymbol.HasValue || model.LocationSymbol.Value != card.LocationSymbol))
                    {
                        continue;
                    }
                    if (model.ConnectsTo.HasValue && model.ConnectsTo.Value != ConnectionSymbol.None && !card.Connections().Any(x => x == model.ConnectsTo.Value))
                    {
                        continue;
                    }
                    if (!string.IsNullOrEmpty(model.EnemyFightValue) && model.EnemyFightValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.EnemyFightValue, card.EnemyFightValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.EnemyHealthValue) && model.EnemyHealthValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.EnemyHealthValue, card.EnemyHealthValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.EnemyEvadeValue) && model.EnemyEvadeValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.EnemyEvadeValue, card.EnemyEvadeValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Damage) && model.Damage != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.Damage, card.Damage))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Horror) && model.Horror != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.Horror, card.Horror))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Shroud) && model.Shroud != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.Shroud, card.Shroud))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.ClueValue) && model.ClueValue != "Any")
                    {
                        if (!cardMatchesNumberFilter(model.ClueValue, card.ClueValue))
                            continue;
                    }
                    if (!string.IsNullOrEmpty(model.Artist) && model.Artist != "Any" && model.Artist != card.Artist.Name) {
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