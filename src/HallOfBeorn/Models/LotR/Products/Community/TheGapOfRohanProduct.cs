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

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP04.pdf";
        }
    }
}