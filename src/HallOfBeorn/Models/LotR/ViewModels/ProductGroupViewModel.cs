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

            MainProducts = new List<ProductViewModel>();
            foreach (var product in productGroup.MainProducts)
            {
                MainProducts.Add(new ProductViewModel(product, getPopularity));
            }
            
            ChildProducts = new List<ProductViewModel>();
            foreach (var product in productGroup.ChildProducts)
            {
                ChildProducts.Add(new ProductViewModel(product, getPopularity));
            }
        }

        public string Name { get; private set; }
        public List<ProductViewModel> MainProducts { get; private set; }
        public List<ProductViewModel> ChildProducts { get; private set; }

        public IEnumerable<ProductViewModel> AllProducts()
        {
            foreach (var main in MainProducts)
                yield return main;

            foreach (var child in ChildProducts)
                yield return child;
        }
    }
}