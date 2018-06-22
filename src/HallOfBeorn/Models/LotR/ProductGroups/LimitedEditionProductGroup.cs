using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class LimitedEditionProductGroup : ProductGroup
    {
        public LimitedEditionProductGroup()
            : base("Starter")
        {
            MainProduct = Product.TwoPlayerLimitedEditionStarter;
        }
    }
}