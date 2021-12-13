using System;

namespace HallOfBeorn.Models.LotR.Products.StarterDeck
{
    public class DefendersOfGondorProduct
        : Product
    {
        public DefendersOfGondorProduct()
            : base("Defenders of Gondor", "MEC105", ImageType.Png, new DateTime(2022, 1, 28))
        {
            AddCardSet(CardSet.DefendersOfGondor);
        }
    }
}