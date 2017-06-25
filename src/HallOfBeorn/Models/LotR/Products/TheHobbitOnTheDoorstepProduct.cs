using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheHobbitOnTheDoorstepProduct : Product
    {
        public TheHobbitOnTheDoorstepProduct()
            : base("The Hobbit: On the Doorstep", "MEC24", ImageType.Png, new DateTime(2013, 2, 22))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/hobbit_on_the_doorstep_rulesheet.pdf";

            AddCardSet(CardSet.TheHobbitOnTheDoorstep);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheHobbit.FliesAndSpiders());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheHobbit.TheLonelyMountain());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheHobbit.TheBattleOfFiveArmies());
        }
    }
}