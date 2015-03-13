using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheBattleOfLakeTownProduct : Product
    {
        public TheBattleOfLakeTownProduct()
            : base("The Battle of Lake-town GenCon 2012", "MEC35", ImageType.Jpg)
        {
            CardSets.Add(CardSet.TheBattleOfLakeTown);
        }
    }
}