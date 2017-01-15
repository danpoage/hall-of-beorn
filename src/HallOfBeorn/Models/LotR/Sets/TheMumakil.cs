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

            addCard(LotRCard.Hero("Kahliel", string.Empty, Sphere.Leadership, 10, 2, 2, 2, 4)
                .WithTraits("Harad.", "Noble.")
                .WithText("You may use resources from Kahliel's resource pool to pay for Harad ally cards of any sphere.\r\nAction: Discard a Harad ally card from your hand to ready a Harad character in play. (Limit once per phase.)")
                .WithFlavor("...the Southrons were bold men and grim...\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Unknown));

            addCard(LotRCard.Ally("Jubayr", Sphere.Spirit, 5, 1, 2, 3, 3)
                .WithUnique()
                .WithTraits("Harad.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Jubayr exhausts to defend an attack, discard 1 facedown shadow card from a non-unique enemy. (Limit once per phase.)")
                .WithInfo(6, 3, Artist.Colin_Boyer));

            addCard(LotRCard.Ally("Firyal", Sphere.Lore, 5, 3, 1, 2, 3)
                .WithUnique()
                .WithTraits("Harad.", "Scout.")
                .WithText("Response: After Firyal commits to the quest, look at the top card of the encounter deck. Then, you may discard the looked at card.")
                .WithInfo(8, 3, Artist.Tawny_Fritzinger));
            addCard(LotRCard.Event("Coney in a Trap", string.Empty, Sphere.Lore, 1)
                .WithText("Play only if you control a unique character with the Ranger trait and another unique character with the Warrior trait.\r\nResponse: After you engage an enemy, that enemy cannot attack you until the end of the round.")
                .WithInfo(9, 3, Artist.Jon_Bosco));
        }
    }
}