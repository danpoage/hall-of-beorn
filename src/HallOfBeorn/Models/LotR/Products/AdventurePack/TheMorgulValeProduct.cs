using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheMorgulValeProduct : Product
    {
        public TheMorgulValeProduct()
            : base("The Morgul Vale", "MEC23", ImageType.Png, new DateTime(2013, 11, 15))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC23.pdf";
            
            AddCardSet(CardSet.TheMorgulVale);

            AddScenario(Scenario.TheMorgulVale);
        }
    }
}