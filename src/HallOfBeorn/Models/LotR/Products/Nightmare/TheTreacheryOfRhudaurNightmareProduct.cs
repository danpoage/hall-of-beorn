using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheTreacheryOfRhudaurNightmareProduct : Product
    {
        public TheTreacheryOfRhudaurNightmareProduct()
            : base("The Treachery of Rhudaur Nightmare", "MEN40", ImageType.Jpg, new DateTime(2017, 1, 1))
        {
            AddCardSet(CardSet.TheTreacheryOfRhudaurNightmare);
        }
    }
}