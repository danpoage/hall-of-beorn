using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheScouringTheShireProductGroup
        : ProductGroup
    {
        public TheScouringTheShireProductGroup()
            : base("The Scouring of the Shire")
        {
            AddMainProduct(Product.TheScouringOfTheShire);
        }
    }
}