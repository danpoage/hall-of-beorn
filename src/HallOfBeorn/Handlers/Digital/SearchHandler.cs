using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models;
using HallOfBeorn.Models.Digital;
using HallOfBeorn.Models.Digital.ViewModels;
using HallOfBeorn.Services.Digital;

namespace HallOfBeorn.Handlers.Digital
{
    public class SearchHandler
    {
        public SearchHandler(DigitalProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        private readonly DigitalProductRepository _productRepository;

        public void HandleSearch(DigitalSearchViewModel model)
        {
            model.Cards = new List<DigitalCardViewModel>();

            foreach (var cardSet in _productRepository.CardSets())
            {
                foreach (var card in cardSet.Cards)
                {
                    if (model.Trait.HasValue && model.Trait.Value != DigitalTrait.None && card.Trait != model.Trait)
                        continue;

                    if (model.Keyword.HasValue && model.Keyword.Value != DigitalKeyword.None)
                    {
                        var keyword = model.Keyword.Value.ToString().ToLower();
                        if (!card.Text.StartsWithLower(keyword) && !card.Text.ContainsLower(" " + keyword))
                            continue;
                    }

                    if (!string.IsNullOrEmpty(model.Query))
                    {
                        if (!card.Title.ContainsLower(model.Query) && !card.Text.ContainsLower(model.Query) && (!card.Trait.HasValue || !card.Trait.Value.ToString().ContainsLower(model.Query)))
                            continue;
                    }

                    model.Cards.Add(new DigitalCardViewModel(card));
                }
            }
        }
    }
}