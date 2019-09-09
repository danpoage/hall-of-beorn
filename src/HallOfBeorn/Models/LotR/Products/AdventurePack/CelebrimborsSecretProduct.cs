using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class CelebrimborsSecretProduct : Product
    {
        public CelebrimborsSecretProduct()
            : base("Celebrimbor's Secret", "MEC30", ImageType.Png, new DateTime(2014, 11, 13))
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/d5/4c/d54cf57f-de1d-4934-abfc-c0fdbc9e0f7a/celebrimbors-secret-rulesheet.pdf";

            AddCardSet(CardSet.CelebrimborsSecret);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheRingMaker.CelebrimborsSecretScenario());
        }
    }
}