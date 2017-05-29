using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheLostRealmNightmareProduct : Product
    {
        public TheLostRealmNightmareProduct()
            : base("The Lost Realm Nightmare", "MEN35", ImageType.Jpg)
        {
            IsPremier = true;
            IsNewSubGroup = true;
            AddCardSet(CardSet.IntrudersInChetwoodNightmare);
        }
    }
}