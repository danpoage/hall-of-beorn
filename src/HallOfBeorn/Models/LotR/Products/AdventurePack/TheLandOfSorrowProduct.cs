using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheLandOfSorrowProduct
        : Product
    {
        public TheLandOfSorrowProduct()
            : base("The Land of Sorrow", "MEC82", ImageType.Jpg, new DateTime(2020, 8, 4))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC82.pdf";

            AddCardSet(CardSet.TheLandOfSorrow);

            AddScenario(Scenario.TheLandOfSorrow);
        }
    }
}