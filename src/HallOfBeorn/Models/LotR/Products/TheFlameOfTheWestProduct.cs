using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheFlameOfTheWestProduct : Product
    {
        public TheFlameOfTheWestProduct()
            : base("The Flame of the West", "MEC54", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheFlameOfTheWest);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.ThePassingOfTheGreyCompany());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheSiegeOfGondor());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheBattleOfThePelennorFields());
        }
    }
}