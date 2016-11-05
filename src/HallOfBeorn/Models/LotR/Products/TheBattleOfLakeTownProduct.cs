using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheBattleOfLakeTownProduct : Product
    {
        public TheBattleOfLakeTownProduct()
            : base("The Battle of Lake-town GenCon 2012", "MEC35", ImageType.Jpg, new DateTime(2012, 10, 16))
        {
            AddCardSet(CardSet.TheBattleOfLakeTown);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheBattleOfLakeTown());
        }
    }
}