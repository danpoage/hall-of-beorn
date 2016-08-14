using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TempleOfTheDeceivedProduct : Product
    {
        public TempleOfTheDeceivedProduct()
            : base("Temple of the Deceived", "MEC50", ImageType.Jpg)
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/75/c2/75c2b2b9-ff75-4084-9c6f-b986a2eadfdc/mec50_rules.pdf";

            AddCardSet(CardSet.TempleOfTheDeceived);

            AddScenario(new Scenarios.TempleOfTheDeceived());
        }
    }
}