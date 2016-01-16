using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheDeadMarshesProduct : Product
    {
        public TheDeadMarshesProduct()
            : base("The Dead Marshes", "MEC06", ImageType.Png, new DateTime(2011, 11, 2))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/The_Dead_Marshes_rulesheet.pdf";

            AddCardSet(CardSet.TheDeadMarshes);

            AddScenario(new HallOfBeorn.Models.Scenarios.TheDeadMarshes());
        }
    }
}