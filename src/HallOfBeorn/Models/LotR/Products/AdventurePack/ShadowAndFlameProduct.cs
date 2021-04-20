﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class ShadowAndFlameProduct : Product
    {
        public ShadowAndFlameProduct()
            : base("Shadow and Flame", "MEC14", ImageType.Png, new DateTime(2012, 8, 8))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC14.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Shadow_and_Flame_rulesheet.pdf";

            AddCardSet(CardSet.ShadowAndFlame);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf.ShadowAndFlameScenario());
        }
    }
}