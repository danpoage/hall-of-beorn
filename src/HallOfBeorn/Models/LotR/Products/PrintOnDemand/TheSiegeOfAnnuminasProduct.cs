using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PrintOnDemand
{
    public class TheSiegeOfAnnuminasProduct : Product
    {
        public TheSiegeOfAnnuminasProduct()
            : base("The Siege of Annúminas", "OP016", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheSiegeOfAnnuminas);

            AddScenario(new Scenarios.PrintOnDemand.TheSiegeOfAnnuminas());
        }
    }
}