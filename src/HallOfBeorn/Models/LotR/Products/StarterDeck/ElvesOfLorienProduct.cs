using System;

namespace HallOfBeorn.Models.LotR.Products.StarterDeck
{
    public class ElvesOfLorienProduct
        : Product
    {
        public ElvesOfLorienProduct()
            : base("Elves of Lórien", "MEC104", ImageType.Png, new DateTime(2022, 1, 28))
        {
            AddCardSet(CardSet.ElvesOfLorien);
        }
    }
}