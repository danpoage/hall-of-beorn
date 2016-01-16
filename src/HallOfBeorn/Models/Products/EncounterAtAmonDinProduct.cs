using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class EncounterAtAmonDinProduct : Product
    {
        public EncounterAtAmonDinProduct()
            : base("Encounter at Amon Dîn", "MEC20", ImageType.Png, new DateTime(2013, 7, 5))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-encounter-at-amon-din.pdf";

            AddCardSet(CardSet.EncounterAtAmonDin);

            AddScenario(new HallOfBeorn.Models.Scenarios.EncounterAtAmonDin());
        }
    }
}