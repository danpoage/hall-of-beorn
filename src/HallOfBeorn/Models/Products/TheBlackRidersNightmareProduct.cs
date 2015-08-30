using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheBlackRidersNightmareProduct : Product
    {
        public TheBlackRidersNightmareProduct()
            : base("The Black Riders Nightmare Decks", "MEN19", ImageType.Jpg)
        {
            IsPremier = true;
            IsNewSubGroup = true;
            AddCardSet(CardSet.AShadowOfThePastNightmare);
            AddCardSet(CardSet.AKnifeInTheDarkNightmare);
            AddCardSet(CardSet.FlightToTheFordNightmare);
        }
    }
}