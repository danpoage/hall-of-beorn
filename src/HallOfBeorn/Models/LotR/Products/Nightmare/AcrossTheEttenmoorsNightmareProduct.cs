using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class AcrossTheEttenmoorsNightmareProduct : Product
    {
        public AcrossTheEttenmoorsNightmareProduct()
            : base("Across the Ettenmoors Nightmare", "MEN39", ImageType.Jpg, new DateTime(2016, 8, 15))
        {
            AddCardSet(CardSet.AcrossTheEttenmoorsNightmare);
        }
    }
}