using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheMorgulValeProduct : Product
    {
        public TheMorgulValeProduct()
            : base("The Morgul Vale", "MEC23", ImageType.Png, new DateTime(2013, 11, 15))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-the-morgul-vale.pdf";

            AddCardSet(CardSet.TheMorgulVale);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow.TheMorgulVale());
        }
    }
}