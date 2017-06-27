using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheHobbitOnTheDoorstepNightmareProduct : Product
    {
        public TheHobbitOnTheDoorstepNightmareProduct()
            : base("The Hobbit: On The Doorstep Nightmare Decks", "MEN18", ImageType.Jpg, new DateTime(2014, 12, 18))
        {
            IsPremier = true;
            AddCardSet(CardSet.FliesAndSpidersNightmare);
            AddCardSet(CardSet.TheLonelyMountainNightmare);
            AddCardSet(CardSet.TheBattleOfFiveArmiesNightmare);
        }
    }
}