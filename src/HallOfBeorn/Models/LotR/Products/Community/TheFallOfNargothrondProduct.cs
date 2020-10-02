using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheFallOfNargothrondProduct
        : Product
    {
        public TheFallOfNargothrondProduct()
            : base("The Fall of Nargothrond", "FA05", ImageType.Jpg, new DateTime(2018, 3, 30))
        {
            AddCardSet(CardSet.TheFallOfNargothrond);
            AddScenario(new Scenarios.DoomMastered.TheFallOfNargothrondScenario());
        }
    }
}
