using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class AJourneyToRhosgobelNightmareProduct : Product
    {
        public AJourneyToRhosgobelNightmareProduct()
            : base("A Joureny to Rhosgobel Nightmare Deck", "MEN06", ImageType.Jpg, new DateTime(2013, 12, 30))
        {
            AddCardSet(CardSet.AJourneyToRhosgobelNightmare);
        }
    }
}