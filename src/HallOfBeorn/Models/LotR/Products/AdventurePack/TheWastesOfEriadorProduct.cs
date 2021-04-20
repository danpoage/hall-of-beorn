using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheWastesOfEriadorProduct : Product
    {
        public TheWastesOfEriadorProduct()
            : base("The Wastes of Eriador", "MEC39", ImageType.Jpg, new DateTime(2015, 7, 2))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC39.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/a7/af/a7af4d1b-efd3-4e61-a2bb-765124f2d6ec/mec39_rules_web.pdf";

            AddCardSet(CardSet.TheWastesOfEriador);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened.TheWastesOfEriadorScenario());
        }
    }
}