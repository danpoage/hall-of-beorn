using System;

namespace HallOfBeorn.Models.LotR.Products.GenCon
{
    public class TheStoneOfErechProduct : Product
    {
        public TheStoneOfErechProduct()
            : base("The Stone of Erech GenCon 2013", "MEC33", ImageType.Jpg, new DateTime(2013, 10, 30))
        {
            AddCardSet(CardSet.TheStoneOfErech);

            AddScenario(Scenario.TheStoneOfErech);
        }
    }
}