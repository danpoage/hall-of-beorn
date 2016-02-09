using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web.Mvc
{
    public class SelectListItemExtends : SelectListItem
    {
        public bool Enabled { get; set; }
        public IDictionary<string, string> PropExtends { get; set; }
    }
}