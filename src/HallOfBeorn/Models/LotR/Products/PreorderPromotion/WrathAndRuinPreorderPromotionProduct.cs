using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class WrathAndRuinPreorderPromotionProduct
        : Product
    {
        public WrathAndRuinPreorderPromotionProduct()
            : base("Wrath and Ruin Preorder Promotion", "MEC78-PRM", ImageType.Jpg, new DateTime(2019, 11, 12))
        {
            AddCardSet(CardSet.WrathAndRuinPreorderPromotion);
        }
    }
}
