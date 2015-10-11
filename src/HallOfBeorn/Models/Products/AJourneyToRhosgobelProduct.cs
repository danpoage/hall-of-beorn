using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AJourneyToRhosgobelProduct : Product
    {
        public AJourneyToRhosgobelProduct()
            : base("A Journey to Rhosgobel", "MEC04", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/A-Journey-to-Rhosgobel-Rules.pdf";

            AddCardSet(CardSet.AJourneyToRhosgobel);

            AddScenario(new HallOfBeorn.Models.Scenarios.AJourneyToRhosgobel());
        }
    }
}