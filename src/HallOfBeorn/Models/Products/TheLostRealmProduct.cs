using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheLostRealmProduct : Product
    {
        public TheLostRealmProduct()
            : base("The Lost Realm", "MEC38", ImageType.Jpg)
        {
            CardSets.Add(CardSet.TheLostRealm);
        }
    }
}