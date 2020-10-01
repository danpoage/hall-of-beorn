using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheFortressOfNurnProduct
        : Product
    {
        public TheFortressOfNurnProduct()
            : base("The Fortress of Nurn", "MEC83", ImageType.Jpg, new DateTime(2020, 9, 30))
        {
            AddCardSet(CardSet.TheFortressOfNurn);
            AddScenario(new Scenarios.VengeanceOfMordor.TheFortressOfNurnScenario());
        }
    }
}