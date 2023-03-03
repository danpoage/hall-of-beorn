using System;

namespace HallOfBeorn.Models.LotR.Products.Hero
{
    public class DreamChaserHeroExpansionProduct
        : Product
    {
        public DreamChaserHeroExpansionProduct()
            : base("Dream-chaser Hero Expansion", "MEC110", ImageType.Jpg, new DateTime(2023, 4, 15))
        {
            AddCardSet(CardSet.DreamChaserHeroExpansion);
        }
    }
}