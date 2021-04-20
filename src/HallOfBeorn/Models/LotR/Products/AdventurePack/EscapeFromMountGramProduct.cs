using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class EscapeFromMountGramProduct : Product
    {
        public EscapeFromMountGramProduct()
            : base("Escape from Mount Gram", "MEC40", ImageType.Jpg, new DateTime(2015, 7, 30))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC40.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/75/84/7584bda4-45de-4b47-b816-fa28b1303c08/mec40-escape-from-mount-gram-rulesheet.pdf";

            AddCardSet(CardSet.EscapeFromMountGram);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened.EscapeFromMountGramScenario());
        }
    }
}