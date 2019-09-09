using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDrownedRuinsProduct : Product
    {
        public TheDrownedRuinsProduct()
            : base("The Drowned Ruins", "MEC51", ImageType.Jpg, new DateTime(2016, 9, 1))
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/09/2f/092fb408-c906-4521-994e-031fd90b11ba/mec51_rules.pdf";

            AddCardSet(CardSet.TheDrownedRuins);

            AddScenario(new Scenarios.DreamChaser.TheDrownedRuinsScenario());
        }
    }
}