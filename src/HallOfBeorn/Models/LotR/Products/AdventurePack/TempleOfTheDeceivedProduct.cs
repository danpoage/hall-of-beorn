using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TempleOfTheDeceivedProduct : Product
    {
        public TempleOfTheDeceivedProduct()
            : base("Temple of the Deceived", "MEC50", ImageType.Jpg, new DateTime(2016, 6, 15))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC50.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/75/c2/75c2b2b9-ff75-4084-9c6f-b986a2eadfdc/mec50_rules.pdf";

            AddCardSet(CardSet.TempleOfTheDeceived);

            AddScenario(new Scenarios.DreamChaser.TempleOfTheDeceivedScenario());
        }
    }
}