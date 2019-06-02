using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheMumakilProduct : Product
    {
        public TheMumakilProduct()
            : base("The Mûmakil", "MEC56", ImageType.Jpg, new DateTime(2017, 2, 1))
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/03/0a/030a4e90-544d-4d24-a160-c5e05f34c778/mec56_rule_set.pdf";

            AddCardSet(CardSet.TheMumakil);
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.Haradrim.TheMumakilScenario());
        }
    }
}