using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Arkham.Products
{
    public class TheDunwichLegacy : ArkhamProduct
    {
        public TheDunwichLegacy()
            : base("The Dunwich Legacy", "TDL", "ACH02", 2, new DateTime(2016, 12, 31))
        {
        }
    }
}