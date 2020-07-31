using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PrintOnDemand
{
    public class EscapeFromKhazadDumProduct
        : Product
    {
        public EscapeFromKhazadDumProduct()
            : base("Escape from Khazad-dûm", "UMEC85", ImageType.Jpg, new DateTime(2020, 7, 29))
        {
            AddCardSet(CardSet.EscapeFromKhazadDum);
        }
    }
}
