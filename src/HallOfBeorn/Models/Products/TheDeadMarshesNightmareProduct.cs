using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheDeadMarshesNightmareProduct : Product
    {
        public TheDeadMarshesNightmareProduct()
            : base("The Dead Marshes Nightmare Deck", "MEN08", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheDeadMarshesNightmare);
        }
    }
}