using System;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class TheFortressOfNurnPreorderPromotionProduct
        : Product
    {
        public TheFortressOfNurnPreorderPromotionProduct()
            : base("The Fortress of Nurn Preorder Promotion", "MEC83-PRM", ImageType.Jpg, new DateTime(2020, 9, 30))
        {
            AddCardSet(CardSet.TheFortressOfNurnPreorderPromotion);
        }
    }
}
