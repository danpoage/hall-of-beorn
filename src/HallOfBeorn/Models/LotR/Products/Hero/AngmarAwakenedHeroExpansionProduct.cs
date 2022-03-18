using System;

namespace HallOfBeorn.Models.LotR.Products.Hero
{
    public class AngmarAwakenedHeroExpansionProduct
        : Product
    {
        public AngmarAwakenedHeroExpansionProduct()
            : base("Angmar Awakened Hero Expansion", "MEC107", ImageType.Jpg, new DateTime(2022, 6, 17))
        {
            AddCardSet(CardSet.AngmarAwakenedHeroExpansion);
        }
    }
}