using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class EncounterAtAmonDinProduct : Product
    {
        public EncounterAtAmonDinProduct()
            : base("Encounter at Amon Dîn", "MEC20", ImageType.Png, new DateTime(2013, 7, 5))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC20.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-encounter-at-amon-din.pdf";

            AddCardSet(CardSet.EncounterAtAmonDin);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow.EncounterAtAmonDinScenario());
        }
    }
}