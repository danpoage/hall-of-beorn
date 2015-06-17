using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.ProductGroups
{
    public class CustomProductGroup : ProductGroup
    {
        public CustomProductGroup()
            : base("Custom Expansions")
        {
            AddProduct(Product.FirstAge);
        }
    }
}