using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheRuinsOfBelegostProduct : Product
    {
        public TheRuinsOfBelegostProduct()
            : base("The Ruins of Belegost", "OP014", ImageType.Jpg, new DateTime(2015, 8, 2))
        {
            AddCardSet(CardSet.TheRuinsOfBelegost);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand.TheRuinsOfBelegost());
        }
    }
}