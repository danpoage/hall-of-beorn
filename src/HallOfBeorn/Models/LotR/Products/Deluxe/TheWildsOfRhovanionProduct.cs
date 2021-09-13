using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheWildsOfRhovanionProduct : Product
    {
        public TheWildsOfRhovanionProduct()
            : base("The Wilds of Rhovanion", "MEC65", ImageType.Jpg, new DateTime(2018, 6, 15))
        {
            AddCardSet(CardSet.TheWildsOfRhovanion);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC65.pdf";

            AddScenario(Scenario.JourneyUpTheAnduin);
            AddScenario(Scenario.LostInMirkwood);
            AddScenario(Scenario.TheKingsQuest);
        }
    }
}