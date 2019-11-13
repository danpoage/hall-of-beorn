using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheWainridersChallengeProduct
        : Product
    {
        public TheWainridersChallengeProduct()
            : base("The Wainriders' Challenge", "MEC80", ImageType.Jpg, new DateTime(2019, 12, 1))
        {
            AddCardSet(CardSet.TheWainridersChallenge);
        }
    }
}