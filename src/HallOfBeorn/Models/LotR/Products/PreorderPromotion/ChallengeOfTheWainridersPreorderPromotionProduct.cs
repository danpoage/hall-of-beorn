using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PreorderPromotion
{
    public class ChallengeOfTheWainridersPreorderPromotionProduct
        : Product
    {
        public ChallengeOfTheWainridersPreorderPromotionProduct()
            : base("Challenge of the Wainriders Preorder Promotion", "MEC80-PRM", ImageType.Jpg, new DateTime(2019, 12, 1))
        {
            AddCardSet(CardSet.ChallengeOfTheWainridersPreorderPromotion);
        }
    }
}
