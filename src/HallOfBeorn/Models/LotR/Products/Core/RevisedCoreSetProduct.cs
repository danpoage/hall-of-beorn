using System;

namespace HallOfBeorn.Models.LotR.Products.Core
{
    public class RevisedCoreSetProduct
        : Product
    {
        public RevisedCoreSetProduct()
            : base("Revised Core Set", "MC01", ImageType.Png, new DateTime(2022, 1, 15))
        {
            AddCardSet(CardSet.RevisedCore);
        }
    }
}