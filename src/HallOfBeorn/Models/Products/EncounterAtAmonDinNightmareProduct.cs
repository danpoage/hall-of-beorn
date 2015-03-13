using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class EncounterAtAmonDinNightmareProduct : Product
    {
        public EncounterAtAmonDinNightmareProduct()
            : base("Encounter at Amon Dîn Nightmare Deck", "MEN24", ImageType.Jpg)
        {
            CardSets.Add(CardSet.EncounterAtAmonDinNightmare);
        }
    }
}