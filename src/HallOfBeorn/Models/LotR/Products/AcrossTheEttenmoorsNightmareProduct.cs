using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class AcrossTheEttenmoorsNightmareProduct : Product
    {
        public AcrossTheEttenmoorsNightmareProduct()
            : base("Across the Ettenmoors Nightmare", "MEN40", ImageType.Jpg)
        {
            AddCardSet(CardSet.AcrossTheEttenmoorsNightmare);
        }
    }
}