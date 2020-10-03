using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ProductDetailViewModel
    {
        public ProductDetailViewModel(Product product, Func<string, IEnumerable<PlayerCategory>> getPlayerCategories, Func<string, IEnumerable<EncounterCategory>> getEncounterCategories, Func<string, IEnumerable<QuestCategory>> getQuestCategories)
        {
            this.product = product;

            foreach (var cardSet in product.CardSets)
            {
                foreach (var card in cardSet.Cards.OrderBy(x => x.CardNumber))
                {
                    cardViewModels.Add(new CardViewModel(card, getPlayerCategories, getEncounterCategories, getQuestCategories, null));
                }
            }

            if (product.CardSets.Count() == 1)
                {
                    var cardSet = string.Empty;

                    var first = product.CardSets.FirstOrDefault();
                    if (first != null)
                    {
                        cardSet = first.Name.Replace(' ', '+');
                    }

                    searchUrl = string.Format("/Cards/Search?CardSet={0}&Sort=Set_Number", cardSet);
                }
                else
                {
                    var query = string.Format("%2Bproduct%3A{0}", product.Name.Replace(":", string.Empty).Replace(' ', '_'));

                    searchUrl = string.Format("/Cards/Search?Query={0}&Sort=Set_Number", query);
                }
        }

        private readonly Product product;
        private readonly List<CardViewModel> cardViewModels = new List<CardViewModel>();
        private readonly string searchUrl;

        public string Name
        {
            get { return product.Name; }
        }

        public string Code
        {
            get { return product.Code; }
        }

        public string ImageUrl
        {
            get
            {
                var ext = product.ImageType == ImageType.Jpg ? "jpg" : "png";
                return string.Format(
                    "https://hallofbeorn-resources.s3.amazonaws.com/Images/Products/{0}.{1}",
                    Code, 
                    ext);
            }
        }

        public string Type
        {
            get { 
                var firstType = product.CardSets.First().SetType;
                switch (firstType)
                {
                    case SetType.Core:
                        return "Core Set";
                    case SetType.Starter:
                        return "Two-Player Limited Edition Stater";
                    case SetType.GenConSaga_Expansion:
                        return "GenCon Saga Expansion";
                    case SetType.FellowshipSaga_Deck:
                        return "Fellowship Saga Deck";
                    case SetType.A_Long_extended_Party:
                        return "A Long-extended Party";
                    default:
                        return firstType.ToString().Replace("_", " ");
                }
            }
        }

        public string FirstReleased
        {
            get { return product.FirstReleased.ToString("dd MMMM yyyy"); }
        }

        public string SearchUrl
        {
            get { return searchUrl; }
        }

        public IEnumerable<CardViewModel> Cards
        {
            get { return cardViewModels; }
        }

        public IEnumerable<ScenarioViewModel> Scenarios()
        {
            return product.Scenarios().Select(sc => new ScenarioViewModel(sc, null, null, null, null));
        }
    }
}