using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheDreadRealmNightmareProduct : Product
    {
        public TheDreadRealmNightmareProduct()
            : base("The Dread Realm Nightmare", "MEN42", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheDreadRealmNightmare);
        }
    }
}