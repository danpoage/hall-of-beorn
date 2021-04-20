using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class ConflictAtTheCarrockProduct : Product
    {
        public ConflictAtTheCarrockProduct()
            : base("Conflict at the Carrock", "MEC03", ImageType.Png, new DateTime(2011, 8, 10))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC03.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-ConflictAtTheCarrock.pdf";

            AddCardSet(CardSet.ConflictAtTheCarrock);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood.ConflictAtTheCarrockScenario());
        }
    }
}