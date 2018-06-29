using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDungeonsOfCirithGuratProduct : Product
    {
        public TheDungeonsOfCirithGuratProduct()
            : base("The Dungeons of Cirith Gurat", "MEC60", ImageType.Png, new DateTime(2018, 1, 1))
        {
            AddCardSet(CardSet.TheDungeonsOfCirithGurat);

            AddScenario(new Scenarios.Haradrim.TheDungeonsOfCirithGuratScenario());
        }
    }
}