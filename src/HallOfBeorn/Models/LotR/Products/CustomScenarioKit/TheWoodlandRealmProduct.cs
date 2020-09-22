using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.CustomScenarioKit
{
    public class TheWoodlandRealmProduct : Product
    {
        public TheWoodlandRealmProduct()
            : base("The Woodland Realm", "OP077", ImageType.Jpg, new DateTime(2018, 8, 24))
        {
            AddCardSet(CardSet.TheWoodlandRealm);
        }
    }
}