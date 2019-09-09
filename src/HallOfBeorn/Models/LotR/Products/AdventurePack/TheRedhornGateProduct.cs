using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheRedhornGateProduct : Product
    {
        public TheRedhornGateProduct()
            : base("The Redhorn Gate", "MEC09", ImageType.Png, new DateTime(2012, 3, 1))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/The-Redhorn-Gate-rulesheet.pdf";

            AddCardSet(CardSet.TheRedhornGate);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf.TheRedhornGateScenario());
        }
    }
}