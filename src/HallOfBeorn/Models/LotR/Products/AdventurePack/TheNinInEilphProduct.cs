using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheNinInEilphProduct : Product
    {
        public TheNinInEilphProduct()
            : base("The Nîn-in-Eilph", "MEC29", ImageType.Png, new DateTime(2014, 10, 23))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC29.pdf";
            
            AddCardSet(CardSet.TheNinInEilph);

            AddScenario(Scenario.TheNinInEilph);
        }
    }
}