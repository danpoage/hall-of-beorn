using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class ReturnToMirkwoodProduct : Product
    {
        public ReturnToMirkwoodProduct()
            : base("Return to Mirkwood", "MEC07", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Return_to_Mirkwood_rulesheet.pdf";

            CardSets.Add(CardSet.ReturnToMirkwood);
        }
    }
}