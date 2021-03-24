using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class ChildrenOfEorlProduct
        : Product
    {
        public ChildrenOfEorlProduct()
            : base("Children of Eorl", "ALEP01", ImageType.Png, new DateTime(2021, 4, 15))
        {
            AddCardSet(CardSet.ChildrenOfEorl);

            AddScenario(new Scenarios.ChildrenOfEorl.AmbushAtErelasScenario());
            AddScenario(new Scenarios.ChildrenOfEorl.TheBattleForTheBeaconScenario());
            AddScenario(new Scenarios.ChildrenOfEorl.TheHorseLordsIreScenario());
        }
    }
}