using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheTreacheryOfRhudaurNightmare : CardSet
    {
        private const string setName = "The Treachery of Rhudaur Nightmare";
        private const string setDecipherAncientTexts = "Decipher Ancient Texts";
        private const string setSiftThroughTheDebris = "Sift through the Debris";
        private const string setQuietTheSpirits = "Quiet the Spirits";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TToRN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2078;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nSetup: Set the Sift through the Debris, Decipher Ancient Texts and Quiet the Spirits encounter sets aside, out of play. These sets are indicated by the following icons, respectively:\r\n\r\nForced: After you advance to stage 2b, for each of the above sidequests that was not defeated, shuffle the encounter set that matches its title into the encounter deck, and shuffle the encounter discard pile into the encounter deck.")
                .WithOppositeText("Begin with the standard quest deck and encounter deck for The Treachery of Rhudaur scenario.\r\n\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n\r\n2x Decrepit Ramains\r\n2x Eerie Halls\r\n1x ~Dark Covenant\r\n2x ~Ruins of ~Arnor\r\n2x Tragic Discovery\r\n5x Cursed Dead\r\n\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard The Treachery of Rhudaur encounter deck.\r\n\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Unknown));
            addCard(LotRCard.Enemy("Thaurdir's Hunter", string.Empty, setName, 16, 2, 2, 1, 6)
                .WithTraits("Undead.")
                .WithText("Forced: When Thaurdir's Hunter attacks, either remove 1 time counter from the main quest, or treat this attack as undefended.")
                .WithShadow("Shadow: If this attack is undefended, either remove 1 time counter or 5 progress from a quest.")
                .WithInfo(2, 2, Artist.Anthony_Devine));
            addCard(LotRCard.Enemy("Undead Thrall", string.Empty, setName, 1, 2, 2, 2, 2)
                .WithTraits("Undead.")
                .WithKeywords("Indestructible.", "Surge.")
                .WithShadow("Shadow: Put Undead Thrall into play engaged with the defending player and deal it a shadow card.")
                .WithInfo(3, 2, Artist.Alexander_Kozachenko));
            addCard(LotRCard.Location("Forgotten Courtyard", string.Empty, setName, 1, 6)
                .WithTraits("Ruins.")
                .WithText("Forgotten Courtyard gets +1 Threat for each resource on it.\r\nForced: After an Undead enemy enters play, place 1 resource on Forgotten Courtyard.")
                .WithInfo(4, 2, Artist.Unknown));
            addCard(LotRCard.Location("Charred Cellar", string.Empty, setName, 5, 4)
                .WithTraits("Ruins.")
                .WithText("While Charred Ruins is the active location, it gains: \"Forced: After a player's threat is increased by an encounter card effect, that player must deal 2 damage to a character he controls.\"")
                .WithInfo(5, 2, Artist.Federico_Musetti));
            addCard(LotRCard.Treachery("Malevolent Forces", string.Empty, setName)
                .WithText("When Revealed: Remove the questing character with the higest Willpower from the quest. The player who controls that character raises his threat by an amount equal to that character's Willpower.")
                .WithShadow("Shadow: If this attack destroys a character, heal all damage from each Undead enemy in play.")
                .WithInfo(6, 2, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Apostate of Angmar", string.Empty, setQuietTheSpirits, 38, 5, 2, 2, 12)
                .WithTraits("Undead.")
                .WithText("While you are engaged with Apostate of Angmar, you cannot attack Thaurdir.")
                .WithShadow("Shadow: Discard the top card of the encounter deck. Attacking enemy gets +X Attack, where X is that card's printed threat.")
                .WithInfo(7, 3, Artist.Unknown));
            addCard(LotRCard.Location("Secret Antechamber", string.Empty, setSiftThroughTheDebris, 2, 5)
                .WithTraits("Ruins.")
                .WithText("Immune to player card effects.\r\nWhile Secret Antechamber is in the staging area, no more than 5 progress can be placed on the main quest each round.\r\nTravel: Raise each player's threat by 3 to travel here.")
                .WithInfo(8, 3, Artist.Federico_Musetti));
            addCard(LotRCard.Treachery("Life Drain", string.Empty, setDecipherAncientTexts)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Deal Life Drain to Thaurdir, as a shadow card.")
                .WithShadow("Shadow: If attacking enemy is Thaurdir, he gets +3 for this attack. If this attack destroys a character, attach Life Drain to Thaurdir. (Counts as a Condition attachment with the text: \"Thaurdir gets +3 hit points.\")")
                .WithInfo(9, 3, Artist.Unknown));
        }
    }
}