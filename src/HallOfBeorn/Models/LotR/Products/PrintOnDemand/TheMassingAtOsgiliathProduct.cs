using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PrintOnDemand
{
    public class TheMassingAtOsgiliathProduct : Product
    {
        public TheMassingAtOsgiliathProduct()
            : base("The Massing at Osgiliath GenCon 2011", "MEC15", ImageType.Jpg, new DateTime(2011, 9, 21))
        {
            AddCardSet(CardSet.TheMassingAtOsgiliath);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand.TheMassingAtOsgiliath());
        }
    }
}