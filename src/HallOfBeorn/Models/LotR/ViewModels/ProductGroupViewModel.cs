using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ViewModels
{
    public class ProductGroupViewModel
    {
        public ProductGroupViewModel(IProductGroup<Product, CardSet, LotRCard> productGroup, Func<string, byte> getPopularity)
        {
            Name = productGroup.Name;

            if (productGroup.MainProduct != null)
            {
                MainProduct = new ProductViewModel(productGroup.MainProduct, getPopularity);
            }

            if (productGroup.SecondProduct != null)
            {
                SecondProduct = new ProductViewModel(productGroup.SecondProduct, getPopularity);
            }

            ChildProducts = new List<ProductViewModel>();

            foreach (var product in productGroup.ChildProducts)
            {
                ChildProducts.Add(new ProductViewModel(product, getPopularity));
            }
        }

        public string Name { get; private set; }
        public ProductViewModel MainProduct { get; private set; }
        public ProductViewModel SecondProduct { get; private set; }
        public List<ProductViewModel> ChildProducts { get; private set; }
    }
}