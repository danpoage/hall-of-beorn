using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Services.LotR.Categories;

namespace HallOfBeorn.Services.LotR.Search
{
    public class FilterService : IFilterService
    {
        public FilterService(ICategoryService<PlayerCategory> playerCategoryService, ICategoryService<EncounterCategory> encounterCategoryService, ICategoryService<QuestCategory> questCategoryService)
        {
            _playerCategoryService = playerCategoryService;
            _encounterCategoryService = encounterCategoryService;
            _questCategoryService = questCategoryService;

            Register("cardtype", (val, neg) => new CardTypeFilter(val, neg));

            Register("cycle", (val, neg) =>
                new StringFuzzyFilter(
                    (score) => score.Card.CardSet.Cycle, val,
                    (cycle, st) => cycle.MatchesWildcard(st),
                    neg)
                );

            Register("set", (val, neg) =>
                new StringFuzzyFilter(
                    (score) => score.Card.CardSet.Name, val,
                    (name, st) => name.MatchesWildcard(st),
                    neg)
                );

            Register("product", (val, neg) =>
                new StringFuzzyFilter(
                    (score) => score.Card.CardSet.Product.Name, val,
                    (name, st) => name.MatchesWildcard(st),
                    neg)
                );

            Register("encounter", (val, neg) =>
                new StringFuzzyFilter(
                    (score) => score.Card.EncounterSet, val,
                    (name, st) => name.MatchesWildcard(st),
                    neg)
                );

            Register("artist", (val, neg) =>
                new StringFuzzyFilter(
                    (score) => score.Card.Artist != null ? score.Card.Artist.Name : string.Empty, val,
                    (name, st) => name.MatchesWildcard(st),
                    neg)
                );

            Register("sphere", (val, neg) =>
                new EnumFilter<Sphere>(
                    (score) => score.Card.Sphere, val, neg)
                );

            Register("category", (val, neg) =>
                new CategoryFilter<PlayerCategory>(
                    (score, cat) => _playerCategoryService.HasCategory(score.Card, cat), val, neg)
                );

            Register("ecategory", (val, neg) =>
                new CategoryFilter<EncounterCategory>(
                    (score, cat) => _encounterCategoryService.HasCategory(score.Card, cat), val, neg)
                );

            Register("qcategory", (val, neg) =>
                new CategoryFilter<QuestCategory>(
                    (score, cat) => _questCategoryService.HasCategory(score.Card, cat), val, neg)
                );

            Register("unique", (val, neg) => new BooleanFilter((score) => score.Card.IsUnique == true, neg));
            Register("custom", (val, neg) => new BooleanFilter((score) => score.Card.CardSet.SetType == Models.SetType.CUSTOM, neg));
            Register("saga", (val, neg) => new BooleanFilter((score) => 
                score.Card.Sphere == Sphere.Baggins || score.Card.Sphere == Sphere.Fellowship || score.Card.CardType == CardType.Treasure ||
                score.Card.CardSubtype == Models.CardSubtype.Boon || score.Card.CardSubtype == Models.CardSubtype.Burden, 
                neg));

            Register("text", (val, neg) => 
                new StringFuzzyFilter(
                    (score) => score.Card.Text, val, 
                    (text, st) => text.ToLowerSafe().Contains(st.ToLowerSafe()), 
                    neg)
                );

            Register("text2", (val, neg) => 
                new StringFuzzyFilter(
                    (score) => score.Card.OppositeText, val, 
                    (text, st) => text.ToLowerSafe().Contains(st.ToLowerSafe()), 
                    neg)
                );

            Register("shadow", (val, neg) => 
                new StringFuzzyFilter(
                    (score) => score.Card.Shadow, val, 
                    (text, st) => text.ToLowerSafe().Contains(st.ToLowerSafe()), 
                    neg)
                );

            Register("flavor", (val, neg) => 
                new StringFuzzyFilter(
                    (score) => score.Card.FlavorText, val, 
                    (text, st) => text.ToLowerSafe().Contains(st.ToLowerSafe()), 
                    neg)
                );

            Register("flavor2", (val, neg) => 
                new StringFuzzyFilter(
                    (score) => score.Card.OppositeFlavorText, val, 
                    (text, st) => text.ToLowerSafe().Contains(st.ToLowerSafe()), 
                    neg)
                );
        }

        private readonly ICategoryService<PlayerCategory> _playerCategoryService;
        private readonly ICategoryService<EncounterCategory> _encounterCategoryService;
        private readonly ICategoryService<QuestCategory> _questCategoryService;
        private readonly Dictionary<string, Func<string, bool, IComponent>> _builders = new Dictionary<string, Func<string, bool, IComponent>>();

        private void Register(string name, Func<string, bool, IComponent> builder)
        {
            _builders[name] = builder;
        }

        public IComponent GetFilter(string name, string value, bool isNegation)
        {
            return _builders.ContainsKey(name) ?
                _builders[name](value, isNegation)
                : null;
        }
    }
}