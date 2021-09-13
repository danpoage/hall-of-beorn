using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TempleOfTheDeceivedProduct : Product
    {
        public TempleOfTheDeceivedProduct()
            : base("Temple of the Deceived", "MEC50", ImageType.Jpg, new DateTime(2016, 6, 15))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC50.pdf";
            
            AddCardSet(CardSet.TempleOfTheDeceived);

            AddScenario(Scenario.TempleOfTheDeceived);
        }
    }
}