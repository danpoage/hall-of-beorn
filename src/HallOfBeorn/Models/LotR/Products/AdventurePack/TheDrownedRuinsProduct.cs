using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDrownedRuinsProduct : Product
    {
        public TheDrownedRuinsProduct()
            : base("The Drowned Ruins", "MEC51", ImageType.Jpg, new DateTime(2016, 9, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC51.pdf";
            
            AddCardSet(CardSet.TheDrownedRuins);

            AddScenario(Scenario.TheDrownedRuins);
        }
    }
}