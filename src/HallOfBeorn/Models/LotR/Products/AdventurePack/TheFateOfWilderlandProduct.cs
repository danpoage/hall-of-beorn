using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheFateOfWilderlandProduct : Product
    {
        public TheFateOfWilderlandProduct()
            : base("The Fate of Wilderland", "MEC71", ImageType.Jpg, new DateTime(2019, 6, 6))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC71.pdf";

            AddCardSet(CardSet.TheFateOfWilderland);

            AddScenario(new Scenarios.EredMithrin.TheFateOfWilderlandScenario());
        }
    }
}