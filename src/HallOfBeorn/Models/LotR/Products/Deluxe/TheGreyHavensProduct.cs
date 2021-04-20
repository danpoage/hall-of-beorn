using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheGreyHavensProduct : Product
    {
        public TheGreyHavensProduct()
            : base("The Grey Havens", "MEC47", ImageType.Jpg, new DateTime(2016, 2, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC47.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/82/67/82674691-bd21-4e45-8a31-2749ca2e5bd9/mec47_rules.pdf";

            AddCardSet(CardSet.TheGreyHavens);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheGreyHavens.VoyageAcrossBelegaerScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheGreyHavens.TheFateOfNumenorScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheGreyHavens.RaidOnTheGreyHavensScenario());
        }
    }
}