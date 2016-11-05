using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheDeadMarshesNightmareProduct : Product
    {
        public TheDeadMarshesNightmareProduct()
            : base("The Dead Marshes Nightmare Deck", "MEN08", ImageType.Jpg, new DateTime(2014, 4, 16))
        {
            AddCardSet(CardSet.TheDeadMarshesNightmare);
        }
    }
}