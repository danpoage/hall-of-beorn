using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class HaradrimProductGroup : ProductGroup
    {
        public HaradrimProductGroup()
            : base("Haradrim Cycle")
        {
            MainProduct = Product.TheSandsOfHarad;
            AddProduct(Product.TheMumakil);
            AddProduct(Product.RaceAcrossHarad);
            AddProduct(Product.BeneathTheSands);
            AddProduct(Product.TheBlackSerpent);
            AddProduct(Product.TheDungeonsOfCirithGurat);
            AddProduct(Product.TheCrossingsOfPoros);
        }
    }
}