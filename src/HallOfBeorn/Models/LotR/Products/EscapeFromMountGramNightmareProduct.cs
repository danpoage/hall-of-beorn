using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class EscapeFromMountGramNightmareProduct : Product
    {
        public EscapeFromMountGramNightmareProduct()
            : base("Escape from Mount Gram Nightmare", "MEN38", ImageType.Jpg)
        {
            AddCardSet(CardSet.EscapeFromMountGramNightmare);
        }
    }
}