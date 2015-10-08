using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public abstract class CoreSetScenario : Scenario
    {
        protected CoreSetScenario()
            : base(true)
        {
            ProductName = "Core Set";
            GroupName = "Core Set";
        }

        protected void ExcludeDolGuldurOrcsForEasyMode()
        {
            ExcludeFromEasyMode("Chieftain-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
        }

        protected void ExcludeSpidersOfMirkwoodForEasyMode()
        {
            ExcludeFromEasyMode("Caught-in-a-Web-Core", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-Core", 1);
            ExcludeFromEasyMode("Hummerhorns-Core", 1);
        }

        protected void ExcludeSauronsReachForEasyMode()
        {
            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
        }

        protected void ExcludeWilderlandsForEasyMode()
        {
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);
        }
    }
}