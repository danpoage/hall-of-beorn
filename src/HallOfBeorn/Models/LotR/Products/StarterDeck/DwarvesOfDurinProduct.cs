using System;

namespace HallOfBeorn.Models.LotR.Products.StarterDeck
{
    public class DwarvesOfDurinProduct
        : Product
    {
        public DwarvesOfDurinProduct()
            : base("Dwarves of Durin", "MEC103", ImageType.Png, new DateTime(2022, 1, 28))
        {
            AddCardSet(CardSet.DwarvesOfDurin);
        }
    }
}