using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class UnderTheAshMountainsProduct : Product
    {
        public UnderTheAshMountainsProduct()
            : base("Under the Ash Mountains", "MEC81", ImageType.Jpg, new DateTime(2020, 6, 5))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC81.pdf";

            AddCardSet(CardSet.UnderTheAshMountains);

            AddScenario(Scenario.UnderTheAshMountains);
        }
    }
}