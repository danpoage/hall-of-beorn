using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheBlackSerpentProduct : Product
    {
        public TheBlackSerpentProduct()
            : base("The Black Serpent", "MEC59", ImageType.Png, new DateTime(2017, 7, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC59.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/93/f7/93f700b6-5273-4d47-9e8a-76b2a2259d7a/mec59_web_the_black_serpent-rules.pdf";

            AddCardSet(CardSet.TheBlackSerpent);
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.Haradrim.TheBlackSerpentScenario());
        }
    }
}