using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AJourneyToRhosgobelNightmareProduct : Product
    {
        public AJourneyToRhosgobelNightmareProduct()
            : base("A Joureny to Rhosgobel Nightmare Deck", "MEN06", ImageType.Jpg)
        {
            CardSets.Add(CardSet.AJourneyToRhosgobelNightmare);
        }
    }
}