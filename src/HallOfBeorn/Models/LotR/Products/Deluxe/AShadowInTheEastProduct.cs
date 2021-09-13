using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class AShadowInTheEastProduct : Product
    {
        public AShadowInTheEastProduct()
            : base("A Shadow in the East", "MEC77", ImageType.Jpg, new DateTime(2019, 7, 1))
        {
            AddCardSet(CardSet.AShadowInTheEast);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC77.pdf";

            AddScenario(Scenario.TheRiverRunning);
            AddScenario(Scenario.DangerInDorwinion);
            AddScenario(Scenario.TempleOfDoom);
        }
    }
}