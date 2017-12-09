using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class RhovanionProductGroup : ProductGroup
    {
        public RhovanionProductGroup()
            : base("Rhovanion Cycle")
        {
            MainProduct = Product.TheWildsOfRhovanion;
        }
    }
}