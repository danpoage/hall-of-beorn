using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RaceAcrossHaradProduct : Product
    {
        public RaceAcrossHaradProduct()
            : base("Race Across Harad", "MEC57", ImageType.Jpg, new DateTime(2017, 3, 15))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC57.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/e6/68/e66896e0-6e11-49f4-901c-724ad64cd173/mec57_web_race_across_harad-rules.pdf";

            AddCardSet(CardSet.RaceAcrossHarad);
            AddScenario(new Scenarios.Haradrim.RaceAcrossHaradScenario());
        }
    }
}