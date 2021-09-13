using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RoadToRivendellProduct : Product
    {
        public RoadToRivendellProduct()
            : base("Road to Rivendell", "MEC10", ImageType.Png, new DateTime(2012, 3, 21))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC10.pdf";
            
            AddCardSet(CardSet.RoadToRivendell);

            AddScenario(Scenario.RoadToRivendell);
        }
    }
}