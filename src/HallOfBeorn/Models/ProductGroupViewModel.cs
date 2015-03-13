using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ProductGroupViewModel
    {
        public ProductGroupViewModel(ProductGroup productGroup)
        {
            Name = productGroup.Name;

            if (productGroup.MainProduct != null)
            {
                MainProduct = new ProductViewModel(productGroup.MainProduct);
            }

            ChildProducts = new List<ProductViewModel>();

            foreach (var product in productGroup.ChildProducts)
            {
                ChildProducts.Add(new ProductViewModel(product));
            }
        }

        public string Name { get; private set; }
        public ProductViewModel MainProduct { get; private set; }
        public List<ProductViewModel> ChildProducts { get; private set; }
    }
}