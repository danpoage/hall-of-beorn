using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.ProductGroups
{
    public class TheHobbitSagaProductGroup : ProductGroup
    {
        public TheHobbitSagaProductGroup()
            : base("The Hobbit Saga")
        {
            AddProduct(Product.TheHobbitOverHillAndUnderHill);
            AddProduct(Product.TheHobbitOnTheDoorstep);
        }
    }
}