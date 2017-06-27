using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDunlandTrapProduct : Product
    {
        public TheDunlandTrapProduct()
            : base("The Dunland Trap", "MEC26", ImageType.Png, new DateTime(2014, 6, 26))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/the-dunland-trap-rulesheet.pdf";

            AddCardSet(CardSet.TheDunlandTrap);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheRingMaker.TheDunlandTrap());
        }
    }
}