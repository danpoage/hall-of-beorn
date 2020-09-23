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
            AddMainProduct(Product.TheSandsOfHarad);
            AddChildProduct(Product.TheMumakil);
            AddChildProduct(Product.RaceAcrossHarad);
            AddChildProduct(Product.BeneathTheSands);
            AddChildProduct(Product.TheBlackSerpent);
            AddChildProduct(Product.TheDungeonsOfCirithGurat);
            AddChildProduct(Product.TheCrossingsOfPoros);
        }
    }
}