using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheAldburgPlotProduct
        : Product
    {
        public TheAldburgPlotProduct()
            : base("The Aldburg Plot", "ALEP02", ImageType.Jpg, new DateTime(2021, 6, 28))
        {
            AddCardSet(CardSet.TheAldburgPlot);
            AddScenario(new Scenarios.OathsOfTheRohirrim.TheAldburgPlotScenario());

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP02.pdf";
        }
    }
}