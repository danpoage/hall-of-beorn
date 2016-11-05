using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HallOfBeorn;

namespace HallOfBeorn.Models.LotR
{
    public class SearchResult
    {
        [Display(Name="Search")]
        public string Query { get; set; }
        
        [Display(Name="Advanced Search")]
        public bool IsAdvancedSearch { get; set; }
        
        [Display(Name="Card Type")]
        public CardType CardType { get; set; }

        [Display(Name = "Card Set")]
        public string CardSet { get; set; }

        [Display(Name = "Trait")]
        public string Trait { get; set; }

        [Display(Name="Results")]
        public List<LotRCard> Cards { get; set; }

        public static IEnumerable<SelectListItem> CardTypes
        {
            get { return typeof(CardType).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> Traits
        {
            get;
            set;
        }

        public static List<SelectListItem> CardSets { get; set; }
    }
}