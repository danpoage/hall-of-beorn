using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheMassingAtOsgiliathProduct : Product
    {
        public TheMassingAtOsgiliathProduct()
            : base("The Massing at Osgiliath GenCon 2011", "MEC15", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheMassingAtOsgiliath);
        }
    }
}