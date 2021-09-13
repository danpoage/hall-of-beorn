using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheHobbitOnTheDoorstepProduct : Product
    {
        public TheHobbitOnTheDoorstepProduct()
            : base("The Hobbit: On the Doorstep", "MEC24", ImageType.Png, new DateTime(2013, 2, 22))
        {
            AddCardSet(CardSet.TheHobbitOnTheDoorstep);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC24.pdf";

            AddScenario(Scenario.FliesAndSpiders);
            AddScenario(Scenario.TheLonelyMountain);
            AddScenario(Scenario.TheBattleOfFiveArmies);
        }
    }
}