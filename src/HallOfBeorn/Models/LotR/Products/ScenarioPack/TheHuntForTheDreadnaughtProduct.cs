using System;

namespace HallOfBeorn.Models.LotR.Products.ScenarioPack
{
    public class TheHuntForTheDreadnaughtProduct
        : Product
    {
        public TheHuntForTheDreadnaughtProduct()
            : base("The Hunt for the Dreadnaught", "MEC86", ImageType.Jpg, new DateTime(2020, 12, 1))
        {
            AddCardSet(CardSet.TheHuntForTheDreadnaught);

            AddScenario(Scenario.TheHuntForTheDreadnaught);
        }
    }
}