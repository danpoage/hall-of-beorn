using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ProductListViewModel
    {
        public ProductListViewModel()
        {
            ProductGroups = new List<ProductGroupViewModel>();
        }

        public List<ProductGroupViewModel> ProductGroups { get; private set; }

        public ProductDetailViewModel Detail { get; set; }
    }
}