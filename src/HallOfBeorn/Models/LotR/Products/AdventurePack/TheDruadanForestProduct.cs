using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDruadanForestProduct : Product
    {
        public TheDruadanForestProduct()
            : base("The Drúadan Forest", "MEC19", ImageType.Png, new DateTime(2013, 5, 31))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC19.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/MEC19-the-druadan-forest-rulesheet.pdf";

            AddCardSet(CardSet.TheDruadanForest);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow.TheDruadanForestScenario());
        }
    }
}