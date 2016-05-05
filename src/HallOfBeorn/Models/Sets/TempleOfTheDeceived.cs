using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TempleOfTheDeceived : CardSet
    {
        private const string setName = "Temple of the Deceived";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TotD";
            Number = 38;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Ally("Ceorl", "", Sphere.Leadership, 2, 1, 2, 0, 2)
                .WithUnique()
                .WithTraits("Rohan.", "Scout.")
                .WithText("Action: Spend 1 Spirit resource to ready Ceorl. Then, you may give control of Ceorl to another player. Any player may trigger this action. (Limit once per phase).")
                .WithFlavor("He drew himself up. Then he knelt, offering his notched sword to the king. \"Command me, lord!\" he cried.\r\n-The Two Towers")
                .WithInfo(58, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Ally("Rhovanion Outrider", "", Sphere.Spirit, 3, 1, 2, 1, 2)
                .WithGeneric()
                .WithTraits("Dale.", "Scout.")
                .WithText("Response: After Rhovanion Outrider coomits to the quest, place 1 progress on a location in the staging area. If that location is not explored by this effect, give Rhovanion Outrider +1 Willpower until the end of the phase.")
                .WithInfo(62, 3, Artist.Beth_Sobel));
            Cards.Add(Card.Event("Scouting Party", "", Sphere.Spirit, 2)
                .WithText("Response: After you commit characters to the quest, if each character you have commited to the quest is a Scout, each of these characters gets +2 Willpower until the end of the phase.")
                .WithInfo(63, 3, Artist.Guillaume_Ducos));
        }
    }
}