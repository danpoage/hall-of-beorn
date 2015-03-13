using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class ConflictAtTheCarrockNightmareProduct : Product
    {
        public ConflictAtTheCarrockNightmareProduct()
            : base("Conflict at the Carrock Nightmare Deck", "MEN05", ImageType.Jpg)
        {
            CardSets.Add(CardSet.ConflictAtTheCarrockNightmare);
        }
    }
}