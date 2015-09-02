using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AcrossTheEttenmoorsProduct : Product
    {
        public AcrossTheEttenmoorsProduct()
            : base("Across the Ettenmoors", "MEC41", ImageType.Jpg)
        {
            AddCardSet(CardSet.AcrossTheEttenmoors);
        }
    }
}