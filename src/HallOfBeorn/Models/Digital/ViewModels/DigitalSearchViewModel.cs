using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfBeorn.Models.Digital.ViewModels
{
    public class DigitalSearchViewModel
    {
        public string Query { get; set; }

        public DigitalSort? Sort { get; set; }
        public DigitalView? View { get; set; }

        public DigitalTrait? Trait { get; set; }
        public DigitalKeyword? Keyword { get; set; }

        public List<DigitalCardViewModel> Cards { get; set; }

        //public List<DigitalProductViewModel> Products { get; set; }

        //public List<CharacterViewModel> Characters { get; set; }

        public void Initialize()
        {
            //TODO: Set defaults
        }

        public string GetResultsCount() {
            if (Cards == null || Cards.Count == 0)
                return "No Results";

            return Cards.Count > 1 ? string.Format("{0} Results", Cards.Count) : "1 Result";
        }

        public bool? IsCardView { get { return true; } }
        public bool? IsProductView { get { return false; } }
        public bool? IsCharacterView { get { return false; } } 

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(DigitalSort).GetSelectListItems(", "); }
        }

        public static IEnumerable<SelectListItem> Views
        {
            get { return typeof(DigitalView).GetSelectListItems(); }
        }
    }
}