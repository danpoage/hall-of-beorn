using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheBlackRidersNightmareProduct : Product
    {
        public TheBlackRidersNightmareProduct()
            : base("The Black Riders Nightmare Decks", "MEN19", ImageType.Jpg, new DateTime(2015, 4, 10))
        {
            IsPremier = true;
            IsNewSubGroup = true;
            AddCardSet(CardSet.AShadowOfThePastNightmare);
            AddCardSet(CardSet.AKnifeInTheDarkNightmare);
            AddCardSet(CardSet.FlightToTheFordNightmare);
        }
    }
}