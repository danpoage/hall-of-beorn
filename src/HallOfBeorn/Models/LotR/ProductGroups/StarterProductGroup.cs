using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class StarterProductGroup : ProductGroup
    {
        public StarterProductGroup()
            : base("Starter")
        {
            AddProduct(Product.TwoPlayerLimitedEditionStarter);
        }
    }
}