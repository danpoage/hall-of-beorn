using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class UnderTheAshMountainsPreorderPromotionProduct
        : Product
    {
        public UnderTheAshMountainsPreorderPromotionProduct()
            : base("Under the Ash Mountains Preorder Promotion", "MEC81-PRM", ImageType.Jpg, new DateTime(2020, 6, 5))
        {
            AddCardSet(CardSet.UnderTheAshMountainsPreorderPromotion);
        }
    }
}
