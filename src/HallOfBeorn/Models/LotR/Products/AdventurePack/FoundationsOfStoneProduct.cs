using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class FoundationsOfStoneProduct : Product
    {
        public FoundationsOfStoneProduct()
            : base("Foundations of Stone", "MEC13", ImageType.Png, new DateTime(2012, 6, 20))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC13.pdf";
            
            AddCardSet(CardSet.FoundationsOfStone);

            AddScenario(Scenario.FoundationsOfStone);
        }
    }
}