using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class BetrayingTheFalathrimProduct
        : Product
    {
        public BetrayingTheFalathrimProduct()
            : base("Betraying the Falathrim", "LOF02", ImageType.Png, new DateTime(2022, 2, 1))
        {
            AddCardSet(CardSet.BetrayingTheFalathrim);
        }
    }
}