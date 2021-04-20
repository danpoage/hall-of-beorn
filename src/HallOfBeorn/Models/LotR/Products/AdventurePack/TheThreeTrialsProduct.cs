using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheThreeTrialsProduct : Product
    {
        public TheThreeTrialsProduct()
            : base("The Three Trials", "MEC27", ImageType.Png, new DateTime(2014, 7, 24))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC27.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/the-three-trials-rulesheet.pdf";

            AddCardSet(CardSet.TheThreeTrials);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheRingMaker.TheThreeTrialsScenario());
        }
    }
}