using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheStewardsFearProduct : Product
    {
        public TheStewardsFearProduct()
            : base("The Steward's Fear", "MEC18", ImageType.Png, new DateTime(2013, 5, 9))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC18.pdf";
            
            AddCardSet(CardSet.TheStewardsFear);

            AddScenario(Scenario.TheStewardsFear);
        }
    }
}