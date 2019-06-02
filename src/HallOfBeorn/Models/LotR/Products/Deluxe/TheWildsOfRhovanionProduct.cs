using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheWildsOfRhovanionProduct : Product
    {
        public TheWildsOfRhovanionProduct()
            : base("The Wilds of Rhovanion", "MEC65", ImageType.Jpg, new DateTime(2018, 6, 15))
        {
            AddCardSet(CardSet.TheWildsOfRhovanion);
            AddScenario(new Scenarios.TheWildsOfRhovanion.JourneyUpTheAnduinScenario());
            AddScenario(new Scenarios.TheWildsOfRhovanion.LostInMirkwoodScenario());
            AddScenario(new Scenarios.TheWildsOfRhovanion.TheKingsQuestScenario());

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/cb/d0/cbd06b38-8657-40c8-8c3a-678a4346383d/mec65_web_the-wilds-of_rhovanion_rules.pdf";
        }
    }
}