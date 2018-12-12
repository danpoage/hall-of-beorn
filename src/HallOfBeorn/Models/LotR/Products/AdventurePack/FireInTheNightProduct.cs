using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class FireInTheNightProduct : Product
    {
        public FireInTheNightProduct()
            : base("Fire in the Night", "MEC68", ImageType.Jpg, new DateTime(2018, 12, 11))
        {
            AddCardSet(CardSet.FireInTheNight);
        }
    }
}