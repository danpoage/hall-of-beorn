using System;

namespace HallOfBeorn.Models.LotR.Products.GenCon
{
    public class TheBattleOfLakeTownProduct : Product
    {
        public TheBattleOfLakeTownProduct()
            : base("The Battle of Lake-town GenCon 2012", "MEC35", ImageType.Jpg, new DateTime(2012, 10, 16))
        {
            AddCardSet(CardSet.TheBattleOfLakeTown);

            AddScenario(Scenario.TheBattleOfLakeTown);
        }
    }
}