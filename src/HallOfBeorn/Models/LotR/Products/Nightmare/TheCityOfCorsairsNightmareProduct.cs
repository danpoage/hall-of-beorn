using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheCityOfCorsairsNightmareProduct : Product
    {
        public TheCityOfCorsairsNightmareProduct()
            : base("The City of the Corsairs Nightmare", "MEN50", ImageType.Jpg, new DateTime(2018, 3, 3))
        {
            AddCardSet(CardSet.TheCityOfCorsairsNightmare);
        }
    }
}