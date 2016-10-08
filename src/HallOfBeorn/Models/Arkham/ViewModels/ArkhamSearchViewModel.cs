using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HallOfBeorn.Models.Arkham.ViewModels
{
    public class ArkhamSearchViewModel
    {
        private readonly List<ArkhamCardViewModel> cards = new List<ArkhamCardViewModel>();

        public ArkhamSort? Sort { get; set; }

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(ArkhamSort).GetSelectListItems(", "); }
        }

        public List<ArkhamCardViewModel> Cards()
        {
            return cards;
        }

        public void LoadCards(IEnumerable<ArkhamCardViewModel> cards)
        {
            this.cards.Clear();
            this.cards.AddRange(cards);
        }

        public string GetResultsCount()
        {
            if (cards.Count == 0)
            {
                return "No results";
            }

            return cards.Count == 1 ? "1 result" : string.Format("{0} results", cards.Count);
        }
    }
}