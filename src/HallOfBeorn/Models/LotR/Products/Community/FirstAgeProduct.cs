using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class FirstAgeProduct : Product
    {
        public FirstAgeProduct()
            : base("First Age", "FA01", ImageType.Jpg, new DateTime(2014, 6, 13))
        {
            AddCardSet(CardSet.FirstAge);

            AddScenario(Scenario.HuntingOfTheWolf);
            AddScenario(Scenario.TheIsleOfWerewolves);
            AddScenario(Scenario.TheSeatOfMorgoth);
        }
    }
}