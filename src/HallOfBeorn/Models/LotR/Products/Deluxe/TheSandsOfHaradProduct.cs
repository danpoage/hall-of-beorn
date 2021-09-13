using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheSandsOfHaradProduct : Product
    {
        public TheSandsOfHaradProduct()
            : base("The Sands of Harad", "MEC55", ImageType.Jpg, new DateTime(2016, 11, 1))
        {
            AddCardSet(CardSet.TheSandsOfHarad);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC55.pdf";

            AddScenario(Scenario.EscapeFromUmbar);
            AddScenario(Scenario.DesertCrossing);
            AddScenario(Scenario.TheLongArmOfMordor);
        }
    }
}