using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheWastesOfEriadorProduct : Product
    {
        public TheWastesOfEriadorProduct()
            : base("The Wastes of Eriador", "MEC39", ImageType.Jpg, new DateTime(2015, 7, 2))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC39.pdf";
            
            AddCardSet(CardSet.TheWastesOfEriador);

            AddScenario(Scenario.TheWastesOfEriador);
        }
    }
}