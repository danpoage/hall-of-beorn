using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class EscapeFromDolGuldurNightmareProduct : Product
    {
        public EscapeFromDolGuldurNightmareProduct()
            : base("Escape from Dol Guldur Nightmare Deck", "MEN03", ImageType.Jpg)
        {
            IsPremier = true;

            CardSets.Add(CardSet.EscapeFromDolGuldurNightmare);
        }
    }
}