using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheSiegeOfEreborProduct
        : Product
    {
        public TheSiegeOfEreborProduct()
            : base("The Siege of Erebor", "ALEP10", ImageType.Png, new DateTime(2023, 9, 6))
        {
            AddCardSet(CardSet.TheSiegeOfErebor);
            AddScenario(Scenario.TheSiegeOfErebor);
            
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP10.pdf";
        }
    }
}