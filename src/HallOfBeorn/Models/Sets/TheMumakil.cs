using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheMumakil : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Mûmakil";
            Abbreviation = "TMk";
            Number = 43;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            Cards.Add(Card.Event("Coney in a Trap", string.Empty, Sphere.Lore, 1)
                .WithText("Play only if you control a unique character with the Ranger trait and another unique character with the Warrior trait.\r\nResponse: After you engage an enemy, that enemy cannot attack you until the end of the round.")
                .WithInfo(9, 3, Artist.Jon_Bosco));
        }
    }
}