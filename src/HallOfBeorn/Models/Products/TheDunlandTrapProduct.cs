using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheDunlandTrapProduct : Product
    {
        public TheDunlandTrapProduct()
            : base("The Dunland Trap", "MEC26", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/the-dunland-trap-rulesheet.pdf";

            AddCardSet(CardSet.TheDunlandTrap);
        }
    }
}