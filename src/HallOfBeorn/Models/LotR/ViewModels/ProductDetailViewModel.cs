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

                    searchUrl = string.Format("/LotR?CardSet={0}&Sort=Set_Number", cardSet);
                }
                else
                {
                    var query = string.Format("%2Bproduct%3A{0}", product.Name.Replace(":", string.Empty).Replace(' ', '_'));

                    searchUrl = string.Format("/LotR?Query={0}&Sort=Set_Number", query);
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

        public IEnumerable<CardQuantityViewModel> CardQuantities()
        {
            var playerCardCount = 0;
            foreach (var pc in cardViewModels.Where(c => c.CardType.IsPlayerCard()))
            {
                playerCardCount += pc.Card.Quantity;
                yield return new CardQuantityViewModel(pc.Title, pc.Card.Quantity, pc.CardType, pc.Url);
            }

            if (playerCardCount > 0)
            {
                yield return new CardQuantityViewModel("Player Cards", playerCardCount);
            }

            var encounterCardCount = 0;
            foreach (var ec in cardViewModels.Where(c => c.CardType.IsEncounterCard()))
            {
                encounterCardCount += ec.Card.Quantity;
                yield return new CardQuantityViewModel(ec.Title, ec.Card.Quantity, ec.CardType, ec.Url);
            }

            if (encounterCardCount > 0)
            {
                yield return new CardQuantityViewModel("Encounter Cards", encounterCardCount);
            }

            var questCardCount = 0;
            foreach (var qc in cardViewModels.Where(c => c.CardType.IsQuestCard()))
            {
                questCardCount += qc.Card.Quantity;
                yield return new CardQuantityViewModel(qc.Title, qc.Card.Quantity, qc.CardType, qc.Url);
            }

            if (questCardCount > 0)
            {
                yield return new CardQuantityViewModel("Quest Cards", questCardCount);
            }

            var otherCardCount = 0;
            foreach (var oc in cardViewModels.Where(
                c => !c.CardType.IsPlayerCard() && !c.CardType.IsEncounterCard() && !c.CardType.IsQuestCard()))
            {
                otherCardCount += oc.Card.Quantity;
                yield return new CardQuantityViewModel(oc.Title, oc.Card.Quantity, oc.CardType, oc.Url);
            }

            if (otherCardCount > 0)
            {
                yield return new CardQuantityViewModel("Other Cards", otherCardCount);
            }

            var totalCardCount = playerCardCount + encounterCardCount + questCardCount + otherCardCount;
            yield return new CardQuantityViewModel("TOTAL CARDS", totalCardCount);
        }

        public IEnumerable<ScenarioViewModel> Scenarios()
        {
            return product.Scenarios().Select(sc => new ScenarioViewModel(sc, null, null, null, null));
        }
    }
}