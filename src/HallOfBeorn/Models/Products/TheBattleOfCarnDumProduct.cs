using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheBattleOfCarnDumProduct : Product
    {
        public TheBattleOfCarnDumProduct()
            : base("The Battle of Carn Dûm", "MEC43", ImageType.Jpg, new DateTime(2015, 11, 6))
        {
            AddCardSet(CardSet.TheBattleOfCarnDum);

            AddScenario(new HallOfBeorn.Models.Scenarios.TheBattleOfCarnDum());
        }
    }
}