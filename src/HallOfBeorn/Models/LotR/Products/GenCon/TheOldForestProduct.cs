using System;

namespace HallOfBeorn.Models.LotR.Products.GenCon
{
    public class TheOldForestProduct : Product
    {
        public TheOldForestProduct()
            : base("The Old Forest", "MEC37", ImageType.Jpg, new DateTime(2014, 11, 11))
        {
            AddCardSet(CardSet.TheOldForest);

            AddScenario(Scenario.TheOldForest);
        }
    }
}