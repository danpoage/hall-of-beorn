using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheWildsOfRhovanionProduct : Product
    {
        public TheWildsOfRhovanionProduct()
            : base("The Wilds of Rhovanion", "MEC65", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheWildsOfRhovanion);
            AddScenario(new Scenarios.TheWildsOfRhovanion.JourneyUpTheAnduin());
            AddScenario(new Scenarios.TheWildsOfRhovanion.LostInMirkwood());
            AddScenario(new Scenarios.TheWildsOfRhovanion.TheKingsQuest());
        }
    }
}