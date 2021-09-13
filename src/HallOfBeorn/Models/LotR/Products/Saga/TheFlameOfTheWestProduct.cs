using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheFlameOfTheWestProduct : Product
    {
        public TheFlameOfTheWestProduct()
            : base("The Flame of the West", "MEC54", ImageType.Jpg, new DateTime(2016, 8, 1))
        {
            AddCardSet(CardSet.TheFlameOfTheWest);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC54.pdf";

            AddScenario(Scenario.ThePassingOfTheGreyCompany);
            AddScenario(Scenario.TheSiegeOfGondor);
            AddScenario(Scenario.TheBattleOfThePelennorFields);
        }
    }
}