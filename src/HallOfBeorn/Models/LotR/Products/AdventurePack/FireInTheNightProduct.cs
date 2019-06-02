using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class FireInTheNightProduct : Product
    {
        public FireInTheNightProduct()
            : base("Fire in the Night", "MEC68", ImageType.Jpg, new DateTime(2018, 12, 11))
        {
            AddCardSet(CardSet.FireInTheNight);
            AddScenario(new Scenarios.EredMithrin.FireInTheNightScenario());

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/ee/b6/eeb6cbe2-c6dc-4a98-aa75-8187d166097a/mec68_web_fire_in_the_night_rules.pdf";
        }
    }
}