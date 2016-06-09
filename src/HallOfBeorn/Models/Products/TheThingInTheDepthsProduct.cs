using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheThingInTheDepthsProduct : Product
    {
        public TheThingInTheDepthsProduct()
            : base("The Thing in the Depths", "MEC49", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheThingInTheDepths);

            AddScenario(new Scenarios.TheThingInTheDepths());
        }
    }
}