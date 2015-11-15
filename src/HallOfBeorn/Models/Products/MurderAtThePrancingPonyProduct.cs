using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class MurderAtThePrancingPonyProduct : Product
    {
        public MurderAtThePrancingPonyProduct()
            : base("Murder at the Prancing Pony", "OP015", ImageType.Jpg)
        {
            AddCardSet(CardSet.MurderAtThePrancingPony);

            AddScenario(new HallOfBeorn.Models.Scenarios.MurderAtThePrancingPony());
        }
    }
}