using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheGapOfRohanProduct : Product
    {
        public TheGapOfRohanProduct()
            : base("The Gap of Rohan", "ALEP04", ImageType.Png, new DateTime(2021, 12, 8))
        {
            AddCardSet(CardSet.TheGapOfRohan);
            AddScenario(Scenario.TheGapOfRohan);
        }
    }
}