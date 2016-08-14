using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheThingInTheDepthsProduct : Product
    {
        public TheThingInTheDepthsProduct()
            : base("The Thing in the Depths", "MEC49", ImageType.Jpg)
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/b0/20/b0205282-e7d4-4853-aa49-54853975be27/mec49_rules.pdf";

            AddCardSet(CardSet.TheThingInTheDepths);

            AddScenario(new Scenarios.TheThingInTheDepths());
        }
    }
}