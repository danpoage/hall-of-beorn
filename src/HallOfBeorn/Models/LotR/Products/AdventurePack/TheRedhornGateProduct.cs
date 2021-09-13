using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheRedhornGateProduct : Product
    {
        public TheRedhornGateProduct()
            : base("The Redhorn Gate", "MEC09", ImageType.Png, new DateTime(2012, 3, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC09.pdf";
            
            AddCardSet(CardSet.TheRedhornGate);

            AddScenario(Scenario.TheRedhornGate);
        }
    }
}