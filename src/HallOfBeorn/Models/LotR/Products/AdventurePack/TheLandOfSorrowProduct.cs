using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheLandOfSorrowProduct
        : Product
    {
        public TheLandOfSorrowProduct()
            : base("The Land of Sorrow", "MEC82", ImageType.Jpg, new DateTime(2020, 8, 4))
        {
            AddCardSet(CardSet.TheLandOfSorrow);
            AddScenario(new Scenarios.VengeanceOfMordor.TheLandOfSorrowScenario());
        }
    }
}