using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheWitheredHeathProduct : Product
    {
        public TheWitheredHeathProduct()
            : base("The Withered Heath", "MEC66", ImageType.Jpg, new DateTime(2018, 7, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC66.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/63/c6/63c6a123-897c-483e-acdf-224c566542a7/mec66_the_withered_heath_rules-insert-compressed.pdf";

            AddCardSet(CardSet.TheWitheredHeath);

            AddScenario(new Scenarios.EredMithrin.TheWitheredHeathScenario());
        }
    }
}