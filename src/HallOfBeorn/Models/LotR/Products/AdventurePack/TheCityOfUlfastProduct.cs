using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheCityOfUlfastProduct : Product
    {
        public TheCityOfUlfastProduct()
            : base("The City of Ulfast", "MEC79", ImageType.Jpg, new DateTime(2020, 1, 9))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC79.pdf";

            AddCardSet(CardSet.TheCityOfUlfast);
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor.TheCityOfUlfastScenario());
        }
    }
}