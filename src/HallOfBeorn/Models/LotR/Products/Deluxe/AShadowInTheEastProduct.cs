using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class AShadowInTheEastProduct : Product
    {
        public AShadowInTheEastProduct()
            : base("A Shadow in the East", "MEC77", ImageType.Jpg, new DateTime(2019, 7, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC77.pdf";

            AddCardSet(CardSet.AShadowInTheEast);

            AddScenario(new Scenarios.AShadowInTheEast.TheRiverRunningScenario());
            AddScenario(new Scenarios.AShadowInTheEast.DangerInDorwinionScenario());
            AddScenario(new Scenarios.AShadowInTheEast.TempleOfDoomScenario());
        }
    }
}