using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheLandOfShadowNightmareProduct : Product
    {
        public TheLandOfShadowNightmareProduct()
            : base("The Land of Shadow Nightmare", "MEN43", ImageType.Jpg)
        {
            AddCardSet(CardSet.ThePassageOfTheMarshesNightmare);
            AddCardSet(CardSet.JourneyToTheCrossRoadsNightmare);
            AddCardSet(CardSet.ShelobsLairNightmare);
        }
    }
}