using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class ReturnToMirkwoodProduct : Product
    {
        public ReturnToMirkwoodProduct()
            : base("Return to Mirkwood", "MEC07", ImageType.Png, new DateTime(2011, 11, 23))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Return_to_Mirkwood_rulesheet.pdf";

            AddCardSet(CardSet.ReturnToMirkwood);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood.ReturnToMirkwood());
        }
    }
}