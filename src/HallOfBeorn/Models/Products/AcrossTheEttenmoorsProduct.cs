using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AcrossTheEttenmoorsProduct : Product
    {
        public AcrossTheEttenmoorsProduct()
            : base("Across the Ettenmoors", "MEC41", ImageType.Jpg, new DateTime(2015, 9, 3))
        {
            AddCardSet(CardSet.AcrossTheEttenmoors);

            AddScenario(new HallOfBeorn.Models.Scenarios.AcrossTheEttenmoors());
        }
    }
}