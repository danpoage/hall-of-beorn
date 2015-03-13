using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheNinInEilphProduct : Product
    {
        public TheNinInEilphProduct()
            : base("The Nîn-in-Eilph", "MEC29", ImageType.Png)
        {
            CardSets.Add(CardSet.NinInEilph);
        }
    }
}