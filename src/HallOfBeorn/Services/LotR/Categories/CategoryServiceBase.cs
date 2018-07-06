using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public abstract class CategoryServiceBase<TCategory> : ICategoryService<TCategory>
        where TCategory: struct
    {
        protected CategoryServiceBase(CardRepository cardRepository)
        {
            _cardRepository = cardRepository;

            var filters = GetCategoryFilters();

            foreach (var card in _cardRepository.Cards().Where(x => IsCategorizable(x)))
            {
                foreach (var filter in filters)
                {
                    var category = filter(card);
                    if (category.Equals(default(TCategory)))
                        continue;

                    if (!categoriesBySlug.ContainsKey(card.Slug)) {
                        categoriesBySlug[card.Slug] = new List<TCategory>();
                    }
                    categoriesBySlug[card.Slug].Add(category);

                    var categoryKey = category.ToString();
                    if (!categories.ContainsKey(categoryKey))
                    {
                        categories.Add(categoryKey, category);
                    }
                }
            }
        }

        private readonly CardRepository _cardRepository;
        private readonly Dictionary<string, TCategory> categories = new Dictionary<string, TCategory>();
        private readonly Dictionary<string, List<TCategory>> categoriesBySlug = new Dictionary<string,List<TCategory>>();

        protected abstract bool IsCategorizable(LotRCard card);

        protected abstract List<Func<LotRCard, TCategory>> GetCategoryFilters();

        protected bool textContains(LotRCard card, string[] values)
        {
            foreach (var text in values)
            {
                if (!string.IsNullOrEmpty(card.Text) && card.Text.Contains(text))
                {
                    return true;
                }

                if (!string.IsNullOrEmpty(card.OppositeText) && card.OppositeText.Contains(text))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HasCategory(LotRCard card, TCategory category)
        {
            return categoriesBySlug.ContainsKey(card.Slug) && categoriesBySlug[card.Slug].Any(x => x.Equals(category));
        }

        public IEnumerable<string> CategoryNames()
        {
            return categories.Values.ToList().Select(x => x.ToString().Replace('_', ' ')).OrderBy(x => x);
        }

        public IEnumerable<TCategory> Categories(string slug)
        {
            return categoriesBySlug.ContainsKey(slug) ? categoriesBySlug[slug] : Enumerable.Empty<TCategory>();
        }
    }
}