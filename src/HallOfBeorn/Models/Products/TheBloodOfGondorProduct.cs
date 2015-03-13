using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheBloodOfGondorProduct : Product
    {
        public TheBloodOfGondorProduct()
            : base("The Blood of Gondor", "MEC22", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-the-blood-of-gondor.pdf";

            CardSets.Add(CardSet.TheBloodOfGondor);
        }
    }
}