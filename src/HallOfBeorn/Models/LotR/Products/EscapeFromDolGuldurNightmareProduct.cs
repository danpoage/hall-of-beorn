using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class EscapeFromDolGuldurNightmareProduct : Product
    {
        public EscapeFromDolGuldurNightmareProduct()
            : base("Escape from Dol Guldur Nightmare Deck", "MEN03", ImageType.Jpg, new DateTime(2013, 8, 1))
        {
            IsPremier = true;

            AddCardSet(CardSet.EscapeFromDolGuldurNightmare);
        }
    }
}