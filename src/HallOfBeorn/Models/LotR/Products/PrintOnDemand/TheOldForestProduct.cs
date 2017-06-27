using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PrintOnDemand
{
    public class TheOldForestProduct : Product
    {
        public TheOldForestProduct()
            : base("The Old Forest", "MEC37", ImageType.Jpg, new DateTime(2014, 11, 11))
        {
            AddCardSet(CardSet.TheOldForest);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand.TheOldForest());
        }
    }
}