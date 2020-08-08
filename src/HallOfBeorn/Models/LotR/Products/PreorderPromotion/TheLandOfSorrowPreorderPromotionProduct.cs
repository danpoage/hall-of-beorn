using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class TheLandOfSorrowPreorderPromotionProduct
        : Product
    {
        public TheLandOfSorrowPreorderPromotionProduct()
            : base("The Land of Sorrow Preorder Promotion", "MEC82-PRM", ImageType.Jpg, new DateTime(2020, 8, 4))
        {
            AddCardSet(CardSet.TheLandOfSorrowPreorderPromotion);
        }
    }
}