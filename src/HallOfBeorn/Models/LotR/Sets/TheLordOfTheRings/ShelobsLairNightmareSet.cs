using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class ShelobsLairNightmareSet : CardSet
    {
        private const string setName = "Shelob's Lair Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "SLN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2073;
   
            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nDo not discard unresolved shadow cards from Shelob at the end of the combat phase.\r\nWhile Cleft of Cirith Ungol is in the staging area, players cannot travel to locations not named Cleft of Cirith Ungol.")
                .WithFlavor("...she was there, who was there before Sauron, and before the first stone of Barad-dûr; and she served none but herself, drinking the blood of Elves and Men, bloated and grown fat with endless brooding on her feasts, weaving webs of shadow...\r\nThe Two Towers")
                .WithOppositeText("Begin with the standard quest deck and encounter deck for the Shelob's Lair scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n4x ~Mogul ~Orc\r\n2x The Under-way\r\n3x Deep ~Dark Passage\r\n2x Many Openings\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard Shelob's Lair encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Foul-smelling Cave", string.Empty, setName, 4, 1)
                .WithTraits("Underground.")
                .WithText("Forced: When Foul-smelling Cave is explored, place 1 resource on Shelob, if able.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if attacking enemy is Shelob).")
                .WithInfo(2, 2, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Location("Torech Ungol", string.Empty, setName, 2, 4)
                .WithTraits("Underground.")
                .WithText("While Torech Ungol is in the staging area, Shelob gets +1 Attack and +1 Defense.\r\nTravel: Exhaust Sméagol to travel here.")
                .WithFlavor("There agelong she had dwelt, and evil thing in spider-form, even such as once of old had lived in the Land of the Elves in the West that is now under the Sea...\r\n-The Two Towers")
                .WithInfo(3, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Cobwebbed Tunnel", string.Empty, setName, 2, 5)
                .WithTraits("Underground.")
                .WithText("Immune to player card effects.\r\nWhile Cobwebbed Tunnel is in the staging area, each Underground location in the staging area gets +1 Threat and +5 quest points.\r\nTravel: The first player reveals an encounter card to travel here.")
                .WithInfo(4, 3, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Enemy("Orc of Minas Morgul", string.Empty, setName, 35, 2, 3, 2, 4)
                .WithTraits("Orc.")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either discard a random card from your hand, or engage Orc of Minas Morgul and reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithInfo(5, 3, Artist.Martin_de_Diego_Sadaba));
            addCard(LotRCard.Enemy("Under-gate Sentry", string.Empty, setName, 30, 3, 5, 3, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithText("Forced: After Under-gate Sentry attacks and destroys a character you control, discard a random card from your hand.")
                .WithShadow("Shadow: Either discard a random card from your hand, or exhaust a character you control.")
                .WithInfo(6, 3, Artist.Monztre));
            addCard(LotRCard.Treachery("Impenetrable Dark", string.Empty, setName)
                .WithText("When Revealed: Each player removes a character he controls from the quest and exhausts that character. Until the end of the round, characters cannot be readied by player card effects.")
                .WithShadow("Shadow: Exhaust a character you control. Until the end of the round, that character cannot ready.")
                .WithInfo(7, 3, Artist.Alexander_Kozachenko));
            addCard(LotRCard.Treachery("Growing Stench", string.Empty, setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Deal Growing Stench to Shelob as a facedown shadow card.")
                .WithShadow("Shadow: Defending character cannot ready. If the attacking enemy is Shelob and this attack destroys a character, place 1 progress on Shelob.")
                .WithInfo(8, 2, Artist.Rafal_Hrynkiewicz));
        }
    }
}