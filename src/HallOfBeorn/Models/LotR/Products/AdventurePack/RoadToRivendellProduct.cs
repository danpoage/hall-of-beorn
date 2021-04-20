using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class RoadToRivendellProduct : Product
    {
        public RoadToRivendellProduct()
            : base("Road to Rivendell", "MEC10", ImageType.Png, new DateTime(2012, 3, 21))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC10.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Road-to-Rivendell-rulesheet.pdf";

            AddCardSet(CardSet.RoadToRivendell);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf.RoadToRivendellScenario());
        }
    }
}