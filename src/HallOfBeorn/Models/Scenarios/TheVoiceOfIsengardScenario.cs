using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Scenarios
{
    public class TheVoiceOfIsengardScenario : Scenario
    {
        protected TheVoiceOfIsengardScenario()
            : base(false)
        {
        }

        protected TheVoiceOfIsengardScenario(bool hasNightmareMode)
            : base(hasNightmareMode)
        {
        }
    }
}