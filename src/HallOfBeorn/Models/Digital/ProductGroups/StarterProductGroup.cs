using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.ProductGroups
{
    public class StarterProductGroup : DigitalProductGroup
    {
        public StarterProductGroup()
            : base("Starter")
        {
            AddMainProduct(DigitalProduct.Starter);
        }
    }
}