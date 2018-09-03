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
                    model.Cards.Add(new DigitalCardViewModel(card));
                }
            }
        }
    }
}