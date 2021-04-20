using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class ChallengeOfTheWainridersProduct
        : Product
    {
        public ChallengeOfTheWainridersProduct()
            : base("Challenge of the Wainriders", "MEC80", ImageType.Jpg, new DateTime(2019, 12, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC80.pdf";

            AddCardSet(CardSet.ChallengeOfTheWainriders);
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.VengeanceOfMordor.ChallengeOfTheWainridersScenario());
        }
    }
}