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
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/88/d6/88d6e80d-e75d-468f-8484-76c56b15e895/mec38_insert_web.pdf";

            CardSets.Add(CardSet.TheLostRealm);
        }
    }
}