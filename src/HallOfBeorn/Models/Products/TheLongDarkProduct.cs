using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheLongDarkProduct : Product
    {
        public TheLongDarkProduct()
            : base("The Long Dark", "MEC12", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/The_Long_Dark_rulesheet.pdf";

            AddCardSet(CardSet.TheLongDark);

            AddScenario(new HallOfBeorn.Models.Scenarios.TheLongDark());
        }
    }
}