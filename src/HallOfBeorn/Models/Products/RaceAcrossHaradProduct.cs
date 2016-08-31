using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class RaceAcrossHaradProduct : Product
    {
        public RaceAcrossHaradProduct()
            : base("Race Across Harad", "MEC57", ImageType.Jpg)
        {
            AddCardSet(CardSet.RaceAcrossHarad);
        }
    }
}