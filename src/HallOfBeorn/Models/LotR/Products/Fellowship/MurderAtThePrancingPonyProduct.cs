using System;

namespace HallOfBeorn.Models.LotR.Products.Fellowship
{
    public class MurderAtThePrancingPonyProduct : Product
    {
        public MurderAtThePrancingPonyProduct()
            : base("Murder at the Prancing Pony", "OP015", ImageType.Jpg, new DateTime(2015, 11, 14))
        {
            AddCardSet(CardSet.MurderAtThePrancingPony);

            AddScenario(Scenario.MurderAtThePrancingPony);
        }
    }
}