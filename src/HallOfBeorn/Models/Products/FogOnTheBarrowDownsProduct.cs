using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class FogOnTheBarrowDownsProduct : Product
    {
        public FogOnTheBarrowDownsProduct()
            : base("Fog on the Barrow-downs", "MEC36", ImageType.Jpg)
        {
            CardSets.Add(CardSet.FogOnTheBarrowDowns);
        }
    }
}