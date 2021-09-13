using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheAntleredCrownProduct : Product
    {
        public TheAntleredCrownProduct()
            : base("The Antlered Crown", "MEC31", ImageType.Jpg, new DateTime(2014, 12, 23))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC31.pdf";
            
            AddCardSet(CardSet.TheAntleredCrown);

            AddScenario(Scenario.TheAntleredCrown);
        }
    }
}