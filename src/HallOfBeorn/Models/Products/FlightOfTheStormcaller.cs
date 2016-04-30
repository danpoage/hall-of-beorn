using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class FlightOfTheStormcaller : Product
    {
        public FlightOfTheStormcaller()
            : base("Flight of the Stormcaller", "MEC48", ImageType.Jpg)
        {
            AddCardSet(CardSet.FlightOfTheStormcaller);
        }
    }
}