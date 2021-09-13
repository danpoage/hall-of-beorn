using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheWatcherInTheWaterProduct : Product
    {
        public TheWatcherInTheWaterProduct()
            : base("The Watcher in the Water", "MEC11", ImageType.Png, new DateTime(2012, 4, 25))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC11.pdf";
            
            AddCardSet(CardSet.TheWatcherInTheWater);

            AddScenario(Scenario.TheWatcherInTheWater);
        }
    }
}