using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheFlameOfTheWestProduct : Product
    {
        public TheFlameOfTheWestProduct()
            : base("The Flame of the West", "MEC54", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheFlameOfTheWest);

            AddScenario(new HallOfBeorn.Models.Scenarios.ThePassingOfTheGreyCompany());
            AddScenario(new HallOfBeorn.Models.Scenarios.TheSiegeOfGondor());
            AddScenario(new HallOfBeorn.Models.Scenarios.TheBattleOfThePelennorFields());
        }
    }
}