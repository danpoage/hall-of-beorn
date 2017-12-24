using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class FlightOfTheStormcallerNightmareProduct : Product
    {
        public FlightOfTheStormcallerNightmareProduct()
            : base("Flight of the Stormcaller Nightmare", "MEN45", ImageType.Png)
        {
            AddCardSet(CardSet.FlightOfTheStormcallerNightmare);
        }
    }
}