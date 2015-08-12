using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheLandOfShadowProduct : Product
    {
        public TheLandOfShadowProduct()
            : base("The Land of Shadow", "MEC46", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheLandOfShadow);
        }
    }
}