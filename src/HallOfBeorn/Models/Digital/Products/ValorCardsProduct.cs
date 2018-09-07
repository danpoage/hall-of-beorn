using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.Products
{
    public class ValorCardsProduct : DigitalProduct
    {
        public ValorCardsProduct()
            : base("Valor Cards", "V")
        {
            addCardSet(DigitalCardSet.ValorCards);
        }
    }
}