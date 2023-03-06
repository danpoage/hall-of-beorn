using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheLegacyOfFeanorProduct
        : Product
    {
        public TheLegacyOfFeanorProduct()
            : base("The Legacy of Fëanor", "LOF01", ImageType.Png, new DateTime(2022, 1, 1))
        {
            AddCardSet(CardSet.TheLegacyOfFeanor);
        }
    }
}