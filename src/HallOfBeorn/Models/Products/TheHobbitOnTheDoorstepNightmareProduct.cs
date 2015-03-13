using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHobbitOnTheDoorstepNightmareProduct : Product
    {
        public TheHobbitOnTheDoorstepNightmareProduct()
            : base("The Hobbit: On The Doorstep Nightmare Decks", "MEN18", ImageType.Jpg)
        {
            IsPremier = true;
            CardSets.Add(CardSet.FliesAndSpidersNightmare);
            CardSets.Add(CardSet.TheLonelyMountainNightmare);
            CardSets.Add(CardSet.TheBattleOfFiveArmiesNightmare);
        }
    }
}