using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
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

            Cards.Add(LotRCard.Hero("Kahliel", string.Empty, Sphere.Leadership, 10, 2, 2, 2, 4)
                .WithTraits("Harad.", "Noble.")
                .WithText("You may use resources from Kahliel's resource pool to pay for Harad ally cards of any sphere.\r\nAction: Discard a Harad ally card from your hand to ready a Harad character in play. (Limit once per phase.)")
                .WithFlavor("...the Southrons were bold men and grim...\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Unknown));

            Cards.Add(LotRCard.Event("Coney in a Trap", string.Empty, Sphere.Lore, 1)
                .WithText("Play only if you control a unique character with the Ranger trait and another unique character with the Warrior trait.\r\nResponse: After you engage an enemy, that enemy cannot attack you until the end of the round.")
                .WithInfo(9, 3, Artist.Jon_Bosco));
        }
    }
}