using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheBloodOfGondorNightmareProduct : Product
    {
        public TheBloodOfGondorNightmareProduct()
            : base("The Blood of Gondor Nightmare Deck", "MEN26", ImageType.Jpg, new DateTime(2015, 3, 19))
        {
            AddCardSet(CardSet.TheBloodOfGondorNightmare);
        }
    }
}