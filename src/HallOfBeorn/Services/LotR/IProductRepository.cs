using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR
{
    public interface IProductRepository
    {
        IEnumerable<ProductGroup> ProductGroups();
        IEnumerable<Product> Products();
        IEnumerable<CardSet> CardSets();
    }
}
