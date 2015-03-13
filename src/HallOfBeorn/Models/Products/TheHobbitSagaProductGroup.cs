using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHobbitSagaProductGroup : ProductGroup
    {
        public TheHobbitSagaProductGroup()
            : base("The Hobbit Saga")
        {
            AddProduct(new TheHobbitOverHillAndUnderHillProduct());
            AddProduct(new TheHobbitOnTheDoorstepProduct());
        }
    }
}