using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class TheMinesOfMoriaPreorderPromotionProduct
        : Product
    {
        public TheMinesOfMoriaPreorderPromotionProduct()
            : base("The Mines of Moria Preorder Promotion", "UMEC84-PRM", ImageType.Jpg, new DateTime(2020, 7, 29))
        {
            AddCardSet(CardSet.TheMinesOfMoriaPreorderPromotion);
        }
    }
}