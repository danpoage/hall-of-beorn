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

        public ProductView? View { get; set; }

        public IEnumerable<ProductViewModel> OfficialChronologicalProducts()
        {
            return ProductGroups
                .SelectMany(pg => pg.AllProducts())
                .Where(p => p.IsOfficial())
                .OrderBy(p => p.FirstReleased);
        }

        public IEnumerable<ProductViewModel> CommunityChronologicalProducts()
        {
            return ProductGroups
                .SelectMany(pg => pg.AllProducts())
                .Where(p => !p.IsOfficial())
                .OrderBy(p => p.FirstReleased);
        }

        public List<ProductGroupViewModel> ProductGroups { get; private set; }

        public ProductDetailViewModel Detail { get; set; }
    }
}