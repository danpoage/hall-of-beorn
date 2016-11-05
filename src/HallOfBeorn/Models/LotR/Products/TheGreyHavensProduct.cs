using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheGreyHavensProduct : Product
    {
        public TheGreyHavensProduct()
            : base("The Grey Havens", "MEC47", ImageType.Jpg)
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/82/67/82674691-bd21-4e45-8a31-2749ca2e5bd9/mec47_rules.pdf";

            AddCardSet(CardSet.TheGreyHavens);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.VoyageAcrossBelegaer());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheFateOfNumenor());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.RaidOnTheGreyHavens());
        }
    }
}