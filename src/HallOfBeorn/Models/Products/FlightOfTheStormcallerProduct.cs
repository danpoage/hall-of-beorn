using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class FlightOfTheStormcallerProduct : Product
    {
        public FlightOfTheStormcallerProduct()
            : base("Flight of the Stormcaller", "MEC48", ImageType.Jpg)
        {
            AddCardSet(CardSet.FlightOfTheStormcaller);

            AddScenario(new Scenarios.FlightOfTheStormcaller());
        }
    }
}