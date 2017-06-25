using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheDreadRealmProduct : Product
    {
        public TheDreadRealmProduct()
            : base("The Dread Realm", "MEC44", ImageType.Jpg, new DateTime(2015, 12, 17))
        {
            AddCardSet(CardSet.TheDreadRealm);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened.TheDreadRealm());
        }
    }
}
