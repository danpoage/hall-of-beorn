using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class BrowseViewModel
    {
        public BrowseViewModel()
        {
            ProductGroups = new List<ProductGroupViewModel>();
        }

        public List<ProductGroupViewModel> ProductGroups { get; private set; }

        public BrowseProductViewModel Detail { get; set; }
    }
}