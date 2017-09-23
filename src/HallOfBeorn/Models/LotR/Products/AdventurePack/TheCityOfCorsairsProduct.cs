using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheCityOfCorsairsProduct : Product
    {
        public TheCityOfCorsairsProduct()
            : base("The City of Corsairs", "MEC53", ImageType.Jpg)
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/64/ff/64ff1288-9607-430b-8f24-6b6d09939d6c/mec53_rules.pdf";

            AddCardSet(CardSet.TheCityOfCorsairs);

            AddScenario(new Scenarios.DreamChaser.TheCityOfCorsairs());
        }
    }
}