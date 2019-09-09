using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class AcrossTheEttenmoorsProduct : Product
    {
        public AcrossTheEttenmoorsProduct()
            : base("Across the Ettenmoors", "MEC41", ImageType.Jpg, new DateTime(2015, 9, 3))
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/c1/67/c1675a0b-18dd-4a2f-be04-b98d9ec55175/mec41_rules.pdf";

            AddCardSet(CardSet.AcrossTheEttenmoors);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened.AcrossTheEttenmoorsScenario());
        }
    }
}