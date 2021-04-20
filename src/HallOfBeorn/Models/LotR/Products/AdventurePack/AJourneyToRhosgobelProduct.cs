﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class AJourneyToRhosgobelProduct : Product
    {
        public AJourneyToRhosgobelProduct()
            : base("A Journey to Rhosgobel", "MEC04", ImageType.Png, new DateTime(2011, 9, 11))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC04.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/A-Journey-to-Rhosgobel-Rules.pdf";

            AddCardSet(CardSet.AJourneyToRhosgobel);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood.AJourneyToRhosgobelScenario());
        }
    }
}