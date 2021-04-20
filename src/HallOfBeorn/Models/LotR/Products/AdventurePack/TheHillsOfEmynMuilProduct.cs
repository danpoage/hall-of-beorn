using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheHillsOfEmynMuilProduct : Product
    {
        public TheHillsOfEmynMuilProduct()
            : base("The Hills of Emyn Muil", "MEC05", ImageType.Png, new DateTime(2011, 9, 30))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC05.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/The_Hills_of_Emyn_Muil_rulesheet.pdf";

            AddCardSet(CardSet.TheHillsOfEmynMuil);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood.TheHillsOfEmynMuilScenario());
        }
    }
}