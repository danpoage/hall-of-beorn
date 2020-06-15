using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class TheCityOfUlfastPreorderPromotionProduct
        : Product
    {
        public TheCityOfUlfastPreorderPromotionProduct()
            : base("The City of Ulfast Preorder Promotion", "MEC79-PRM", ImageType.Jpg, new DateTime(2020, 1, 9))
        {
            AddCardSet(CardSet.TheCityOfUlfastPreorderPromotion);
        }
    }
}
