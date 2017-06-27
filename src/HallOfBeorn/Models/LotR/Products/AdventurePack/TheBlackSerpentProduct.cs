using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheBlackSerpentProduct : Product
    {
        public TheBlackSerpentProduct()
            : base("The Black Serpent", "MEC59", ImageType.Png)
        {
            AddCardSet(CardSet.TheBlackSerpent);
        }
    }
}