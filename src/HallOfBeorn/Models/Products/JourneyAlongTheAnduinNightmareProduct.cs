using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class JourneyAlongTheAnduinNightmareProduct : Product
    {
        public JourneyAlongTheAnduinNightmareProduct()
            : base("Journey Along the Anduin Nightmare Deck", "MEN02", ImageType.Jpg)
        {
            IsPremier = true;

            CardSets.Add(CardSet.JourneyAlongTheAnduinNightmare);
        }
    }
}