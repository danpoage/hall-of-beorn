using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheMorgulValeProduct : Product
    {
        public TheMorgulValeProduct()
            : base("The Morgul Vale", "MEC23", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-the-morgul-vale.pdf";

            CardSets.Add(CardSet.TheMorgulVale);
        }
    }
}