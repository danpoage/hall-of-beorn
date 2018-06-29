using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class FlightOfTheStormcallerNightmareProduct : Product
    {
        public FlightOfTheStormcallerNightmareProduct()
            : base("Flight of the Stormcaller Nightmare", "MEN45", ImageType.Jpg, new DateTime(2017, 9, 1))
        {
            AddCardSet(CardSet.FlightOfTheStormcallerNightmare);
        }
    }
}