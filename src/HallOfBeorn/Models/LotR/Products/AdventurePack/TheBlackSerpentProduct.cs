using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheBlackSerpentProduct : Product
    {
        public TheBlackSerpentProduct()
            : base("The Black Serpent", "MEC59", ImageType.Png, new DateTime(2017, 7, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC59.pdf";
            
            AddCardSet(CardSet.TheBlackSerpent);

            AddScenario(Scenario.TheBlackSerpent);
        }
    }
}