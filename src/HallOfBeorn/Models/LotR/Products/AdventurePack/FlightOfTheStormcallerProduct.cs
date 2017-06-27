using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class FlightOfTheStormcallerProduct : Product
    {
        public FlightOfTheStormcallerProduct()
            : base("Flight of the Stormcaller", "MEC48", ImageType.Jpg)
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/02/50/025015c8-ce58-46cd-a473-ecc3e8151618/mec48_rules.pdf";

            AddCardSet(CardSet.FlightOfTheStormcaller);

            AddScenario(new Scenarios.DreamChaser.FlightOfTheStormcaller());
        }
    }
}