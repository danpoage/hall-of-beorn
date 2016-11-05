using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class EncounterAtAmonDinNightmareProduct : Product
    {
        public EncounterAtAmonDinNightmareProduct()
            : base("Encounter at Amon Dîn Nightmare Deck", "MEN24", ImageType.Jpg, new DateTime(2015, 2, 12))
        {
            AddCardSet(CardSet.EncounterAtAmonDinNightmare);
        }
    }
}