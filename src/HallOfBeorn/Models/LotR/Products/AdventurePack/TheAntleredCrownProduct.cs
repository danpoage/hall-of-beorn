using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheAntleredCrownProduct : Product
    {
        public TheAntleredCrownProduct()
            : base("The Antlered Crown", "MEC31", ImageType.Jpg, new DateTime(2014, 12, 23))
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/a9/19/a91988d8-41a3-4653-9b3e-c2a970c1b2a8/mec31-the-antlered-crown-rulesheet.pdf";

            AddCardSet(CardSet.TheAntleredCrown);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheRingMaker.TheAntleredCrown());
        }
    }
}