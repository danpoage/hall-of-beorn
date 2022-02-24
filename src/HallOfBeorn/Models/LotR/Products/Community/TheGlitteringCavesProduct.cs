using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheGlitteringCavesProduct : Product
    {
        public TheGlitteringCavesProduct()
            : base("The Glittering Caves", "ALEP05", ImageType.Png, new DateTime(2022, 2, 23))
        {
            AddCardSet(CardSet.TheGlitteringCaves);
            AddScenario(Scenario.TheGlitteringCaves);
            
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP05.pdf";
        }
    }
}