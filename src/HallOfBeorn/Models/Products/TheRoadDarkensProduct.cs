using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheRoadDarkensProduct : Product
    {
        public TheRoadDarkensProduct()
            : base("The Road Darkens", "MEC34", ImageType.Png)
        {
            AddCardSet(CardSet.TheRoadDarkens);
        }
    }
}