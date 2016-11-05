using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class BrowseProductViewModel
    {
        public BrowseProductViewModel(Product product)
        {
            this.product = product;

            foreach (var cardSet in product.CardSets())
            {
                foreach (var card in cardSet.Cards.OrderBy(x => x.Number))
                {
                    cardViewModels.Add(new CardViewModel(card));
                }
            }

            if (product.CardSets().Count() == 1)
                {
                    var cardSet = string.Empty;

                    var first = product.CardSets().FirstOrDefault();
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

        public string SearchUrl
        {
            get { return searchUrl; }
        }

        public IEnumerable<CardViewModel> Cards
        {
            get { return cardViewModels; }
        }
    }
}