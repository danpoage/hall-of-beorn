using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PrintOnDemand
{
    public class TheMinesOfMoriaProduct
        : Product
    {
        public TheMinesOfMoriaProduct()
            : base("The Mines of Moria", "UMEC84", ImageType.Jpg, new DateTime(2020, 7, 29))
        {
            AddCardSet(CardSet.TheMinesOfMoria);
        }
    }
}