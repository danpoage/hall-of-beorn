using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class FoundationsOfStoneProduct : Product
    {
        public FoundationsOfStoneProduct()
            : base("Foundations of Stone", "MEC13", ImageType.Png, new DateTime(2012, 6, 20))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC13.pdf";
                //"http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Foundations_of_Stone_rulesheet.pdf";

            AddCardSet(CardSet.FoundationsOfStone);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.Dwarrowdelf.FoundationsOfStoneScenario());
        }
    }
}