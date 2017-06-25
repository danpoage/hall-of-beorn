using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheStoneOfErechProduct : Product
    {
        public TheStoneOfErechProduct()
            : base("The Stone of Erech GenCon 2013", "MEC33", ImageType.Jpg, new DateTime(2013, 10, 30))
        {
            AddCardSet(CardSet.TheStoneOfErech);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand.TheStoneOfErech());
        }
    }
}