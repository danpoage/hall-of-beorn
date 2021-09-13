using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheThreeTrialsProduct : Product
    {
        public TheThreeTrialsProduct()
            : base("The Three Trials", "MEC27", ImageType.Png, new DateTime(2014, 7, 24))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC27.pdf";
            
            AddCardSet(CardSet.TheThreeTrials);

            AddScenario(Scenario.TheThreeTrials);
        }
    }
}