using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheSandsOfHaradProduct : Product
    {
        public TheSandsOfHaradProduct()
            : base("The Sands of Harad", "MEC55", ImageType.Jpg, new DateTime(2016, 11, 1))
        {
            AddCardSet(CardSet.TheSandsOfHarad);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheSandsOfHarad.EscapeFromUmbarScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheSandsOfHarad.DesertCrossingScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheSandsOfHarad.TheLongArmOfMordorScenario());

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/b6/a2/b6a24632-929f-4bd5-a436-bd8c617e4bd2/mec55_rules_webready.pdf";
        }
    }
}