using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.ProductGroups
{
    public class ValorProductGroup : DigitalProductGroup
    {
        public ValorProductGroup()
            : base("Valor Cards")
        {
            MainProduct = DigitalProduct.ValorCards;
        }
    }
}