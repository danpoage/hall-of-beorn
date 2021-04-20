using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheCrossingsOfPorosProduct : Product
    {
        public TheCrossingsOfPorosProduct()
            : base("The Crossings of Poros", "MEC61", ImageType.Png, new DateTime(2018, 2, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC61.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/32/39/3239576b-d63a-4b52-a07c-a66453424f63/mec61_web_the_crossing_of_poros-rules.pdf";

            AddCardSet(CardSet.TheCrossingsOfPoros);
            AddScenario(new Scenarios.Haradrim.TheCrossingsOfPorosScenario());
        }
    }
}