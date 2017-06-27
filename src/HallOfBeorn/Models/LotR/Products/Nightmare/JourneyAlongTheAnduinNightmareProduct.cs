using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class JourneyAlongTheAnduinNightmareProduct : Product
    {
        public JourneyAlongTheAnduinNightmareProduct()
            : base("Journey Along the Anduin Nightmare Deck", "MEN02", ImageType.Jpg, new DateTime(2013, 8, 1))
        {
            IsPremier = true;

            AddCardSet(CardSet.JourneyAlongTheAnduinNightmare);
        }
    }
}