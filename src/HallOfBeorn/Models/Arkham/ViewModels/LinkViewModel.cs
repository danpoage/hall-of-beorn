using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.ViewModels
{
    public class LinkViewModel
    {
        public LinkViewModel()
        {
            CssClass = "arkham-link";
        }

        public string Name { get; set; }
        public string Title { get; set; }
        public string Href { get; set; }
        public string Target { get; set; }
        public string CssClass { get; set; }

        public override string ToString()
        {
            return string.Format("<a title='{0}' href='{1}' target='{2}' class='{3}'>{4}</a>", Title, Href, Target, CssClass, Name);
        }
    }
}