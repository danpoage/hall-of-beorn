using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheBloodOfGondorProduct : Product
    {
        public TheBloodOfGondorProduct()
            : base("The Blood of Gondor", "MEC22", ImageType.Png, new DateTime(2013, 10, 17))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-the-blood-of-gondor.pdf";

            AddCardSet(CardSet.TheBloodOfGondor);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow.TheBloodOfGondorScenario());
        }
    }
}