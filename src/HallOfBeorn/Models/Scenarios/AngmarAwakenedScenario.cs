using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public abstract class AngmarAwakenedScenario : Scenario
    {
        protected void ExcludeAngmarOrcsFromEasyMode()
        {
            ExcludeFromEasyMode("Angmar-Captain-TLR", 1);
            ExcludeFromEasyMode("Angmar-Marauder-TLR", 1);
        }

        protected void ExcludeDarkSorceryFromEasyMode()
        {
            ExcludeFromEasyMode("Dark-Sorcery-TLR", 1);
            ExcludeFromEasyMode("Heavy-Curse-TLR", 2);
            ExcludeFromEasyMode("Terror-of-the-North-TLR", 1);
        }
    }
}