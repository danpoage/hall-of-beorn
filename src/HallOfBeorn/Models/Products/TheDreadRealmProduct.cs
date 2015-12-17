using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheDreadRealmProduct : Product
    {
        public TheDreadRealmProduct()
            : base("The Dread Realm", "MEC44", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheDreadRealm);
        }
    }
}