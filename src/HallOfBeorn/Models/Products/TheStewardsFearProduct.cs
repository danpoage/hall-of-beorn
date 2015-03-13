using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheStewardsFearProduct : Product
    {
        public TheStewardsFearProduct()
            : base("The Steward's Fear", "MEC18", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/MEC18-the-stewards-fear-rulesheet.pdf";

            CardSets.Add(CardSet.TheStewardsFear);
        }
    }
}