using System;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class EscapeFromKhazadDumPreorderPromotionProduct
        : Product
    {
        public EscapeFromKhazadDumPreorderPromotionProduct()
            : base("Escape from Khazad-dûm Preorder Promotion", "UMEC85-PRM", ImageType.Jpg, new DateTime(2020, 7, 29))
        {
            AddCardSet(CardSet.EscapeFromKhazadDumPreorderPromotion);
        }
    }
}