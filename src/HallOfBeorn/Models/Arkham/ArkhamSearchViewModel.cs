using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HallOfBeorn.Models.Arkham
{
    public class ArkhamSearchViewModel
    {
        public ArkhamSort? Sort { get; set; }

        public static IEnumerable<SelectListItem> Sorts
        {
            get { return typeof(ArkhamSort).GetSelectListItems(", "); }
        }
    }
}