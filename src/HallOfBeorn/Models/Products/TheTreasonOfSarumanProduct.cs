using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheTreasonOfSarumanProduct : Product
    {
        public TheTreasonOfSarumanProduct()
            : base("The Treason of Saruman", "MEC45", ImageType.Png)
        {
            CardSets.Add(CardSet.TheTreasonOfSaruman);
        }
    }
}