using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheDreadRealmNightmareProduct : Product
    {
        public TheDreadRealmNightmareProduct()
            : base("The Dread Realm Nightmare", "MEN42", ImageType.Jpg, new DateTime(2017, 1, 1))
        {
            AddCardSet(CardSet.TheDreadRealmNightmare);
        }
    }
}