using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class MountGundabadProduct : Product
    {
        public MountGundabadProduct()
            : base("Mount Gundabad", "MEC70", ImageType.Png, new DateTime(2019, 2, 1))
        {
            AddCardSet(CardSet.MountGundabad);
            AddScenario(new Models.LotR.Scenarios.EredMithrin.MountGundabadScenario());
        }
    }
}