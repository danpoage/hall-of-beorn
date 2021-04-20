using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class BeneathTheSandsProduct : Product
    {
        public BeneathTheSandsProduct()
            : base("Beneath the Sands", "MEC58", ImageType.Png, new DateTime(2017, 5, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC58.pdf";

            AddCardSet(CardSet.BeneathTheSands);

            AddScenario(new Scenarios.Haradrim.BeneathTheSandsScenario());
        }
    }
}