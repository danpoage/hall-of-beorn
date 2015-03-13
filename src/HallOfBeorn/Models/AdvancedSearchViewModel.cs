using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HallOfBeorn.Models
{
    public class AdvancedSearchViewModel
    {
        public AdvancedSearchViewModel()
        {
            AdvancedSearchFilter lastFilter = null;
            AdvancedSearchFilter filter = null; 

            for (var i = 0; i < 10; i++)
            {
                filter = new AdvancedSearchFilter { Number = i, IsEnabled = true };

                if (lastFilter != null)
                {
                    lastFilter.Next = filter;
                }

                _filters.Add(filter);

                lastFilter = filter;
            }
        }

        private readonly List<AdvancedSearchFilter> _filters = new List<AdvancedSearchFilter>();

        public string Query { get; set; }

        public List<CardViewModel> Cards { get; set; }

        public IEnumerable<AdvancedSearchFilter> Filters
        {
            get { return _filters; }
        }
    }

    public enum FilterType
    {
        Set,
        Type,
        Sphere,
        Cost,
        Trait,
        Keyword,
        Encounter,
        Artist
    }

    public class AdvancedSearchFilter
    {
        public int Number { get; set; }
        public bool IsEnabled { get; set; } 
        public AdvancedSearchFilter Next { get; set; }
        public FilterType FilterType { get; set; }

        public static IEnumerable<SelectListItem> CardTypes
        {
            get { return typeof(CardType).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> Keywords
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> Traits
        {
            get;
            set;
        }

        public static IEnumerable<SelectListItem> FilterTypes
        {
            get { return typeof(FilterType).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> CardSets { get; set; }

        public static IEnumerable<SelectListItem> EncounterSets { get; set; }

        public static IEnumerable<SelectListItem> Costs { get; set; }

        public static IEnumerable<SelectListItem> Spheres
        {
            get { return typeof(Sphere).GetSelectListItems(); }
        }

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(Sort).GetSelectListItems(", "); }
        }

        public static IEnumerable<SelectListItem> Artists
        {
            get
            {
                yield return new SelectListItem { Text = "Any", Value = "Any" };

                foreach (var artist in HallOfBeorn.Models.Artist.All())
                    yield return new SelectListItem { Text = artist.Name, Value = artist.Name };
            }
        }
    }
}