using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheCityOfCorsairsProduct : Product
    {
        public TheCityOfCorsairsProduct()
            : base("The City of Corsairs", "MEC53", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheCityOfCorsairs);
        }
    }
}