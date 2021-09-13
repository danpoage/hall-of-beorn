using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class ShadowAndFlameProduct : Product
    {
        public ShadowAndFlameProduct()
            : base("Shadow and Flame", "MEC14", ImageType.Png, new DateTime(2012, 8, 8))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC14.pdf";
            
            AddCardSet(CardSet.ShadowAndFlame);

            AddScenario(Scenario.ShadowAndFlame);
        }
    }
}