using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheWatcherInTheWaterProduct : Product
    {
        public TheWatcherInTheWaterProduct()
            : base("The Watcher in the Water", "MEC11", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/The_Watcher_in_the_Water_rulesheet.pdf";

            AddCardSet(CardSet.TheWatcherInTheWater);

            AddScenario(new HallOfBeorn.Models.Scenarios.TheWatcherInTheWater());
        }
    }
}