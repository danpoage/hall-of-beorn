using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheBloodOfGondorNightmareProduct : Product
    {
        public TheBloodOfGondorNightmareProduct()
            : base("The Blood of Gondor Nightmare Deck", "MEN26", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheBloodOfGondorNightmare);
        }
    }
}