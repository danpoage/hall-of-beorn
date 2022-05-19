using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.ViewModels;
using HallOfBeorn.Services.LotR.Design;

namespace HallOfBeorn.Handlers.LotR
{
    public class CardDesignSearchHandler
        : ISearchViewHandler
    {
        public CardDesignSearchHandler(ICardDesignService cardDesignService)
        {
            this.cardDesignService = cardDesignService;
        }

        private readonly ICardDesignService cardDesignService;

        public void HandleSearch(Models.LotR.ViewModels.SearchViewModel model, Models.LotR.UserSettings settings)
        {
            var lang = model.Lang.GetValueOrDefault(Language.EN);

            var designs = cardDesignService.WithVersions(
                model.Cards.Select(viewModel => viewModel.Card), lang)
                .Select(design => new CardDesignViewModel(design, lang)).ToList();

            model.CardDesigns.AddRange(designs);
        }
    }
}