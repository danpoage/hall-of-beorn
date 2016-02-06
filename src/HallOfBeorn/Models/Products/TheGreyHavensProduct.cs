using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheGreyHavensProduct : Product
    {
        public TheGreyHavensProduct()
            : base("The Grey Havens", "MEC47", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheGreyHavens);
        }
    }
}