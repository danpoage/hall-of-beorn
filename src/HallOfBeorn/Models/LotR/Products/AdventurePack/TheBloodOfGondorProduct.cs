using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheBloodOfGondorProduct : Product
    {
        public TheBloodOfGondorProduct()
            : base("The Blood of Gondor", "MEC22", ImageType.Png, new DateTime(2013, 10, 17))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC22.pdf";
            
            AddCardSet(CardSet.TheBloodOfGondor);

            AddScenario(Scenario.TheBloodOfGondor);
        }
    }
}