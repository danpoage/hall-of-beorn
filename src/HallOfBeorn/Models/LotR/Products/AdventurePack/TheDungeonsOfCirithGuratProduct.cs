using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDungeonsOfCirithGuratProduct : Product
    {
        public TheDungeonsOfCirithGuratProduct()
            : base("The Dungeons of Cirith Gurat", "MEC60", ImageType.Png)
        {
            AddCardSet(CardSet.TheDungeonsOfCirithGurat);
        }
    }
}