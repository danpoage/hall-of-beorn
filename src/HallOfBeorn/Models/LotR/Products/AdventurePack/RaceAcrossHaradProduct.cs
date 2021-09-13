using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RaceAcrossHaradProduct : Product
    {
        public RaceAcrossHaradProduct()
            : base("Race Across Harad", "MEC57", ImageType.Jpg, new DateTime(2017, 3, 15))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC57.pdf";
            
            AddCardSet(CardSet.RaceAcrossHarad);

            AddScenario(Scenario.RaceAcrossHarad);
        }
    }
}