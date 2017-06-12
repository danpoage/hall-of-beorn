using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLostRealm
{
    public class DeadmensDikeNightmare : CardSet
    {
        private const string setName = "Deadmen's Dike Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "DDN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2074;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nEach player's deck cannot include more than 50 total cards.\r\nSetup: Each player searches the encounter deck for a copy of Cursed Dead and places it in the encounter discard pile. Shuffle the encounter deck.")
                .WithFlavor("\"Men call it Deadmen's Dike, and they fear to tread there. For the folk of Arnor dwindled, and their foes devoured them...\"\r\n-Elrond, The Fellowship of the Ring")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Deadmen's Dike scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

2x Fornost Square
3x Broken Battlements
2x Norbury Tombs
2x Restless Evil

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Deadmen's Dike encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(19, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Undead Horde", string.Empty, setName, 34, 4, 6, 3, 8)
                .WithTraits("Undead.")
                .WithText("Cannot have attachments.\r\nFor each excess point of combat damage deal by Undead Horde (damage that is dealt beyond the remaining hit points of the character damaged by its attack) you must discard 1 card from the top of your deck.")
                .WithInfo(20, 2, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Cursed Dead", string.Empty, setName, 27, 1, 3, 1, 2)
                .WithTraits("Undead.")
                .WithText("When Revealed: Put each copy of Cursed Dead in the discard pile into play in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if there is a copy of the defending character in its owner's discard pile.")
                .WithInfo(21, 4, Artist.Helge_C_Balzer));
            addCard(LotRCard.Location("Palace Ruins", string.Empty, setName, 9, 9)
                .WithTraits("Fornost.", "Ruins.")
                .WithText("Action: Discard the top X of your deck to reduce Palace Ruins' Threat by X until the end of the phase. Any player may trigger this action. (Limit once per phase.)")
                .WithShadow("Shadow: Discard 1 card from the top of your deck for each Undead enemy engaged with you.")
                .WithInfo(22, 2, Artist.Joel_Hustak));
            addCard(LotRCard.Location("Fornost Street", string.Empty, setName, 1, 6)
                .WithTraits("Fornost.", "Ruins.")
                .WithText("While Fornost Street is in the staging area, each other Fornost location gets +1 Threat.\r\nTravel: Return the topmost enemy in the encounter discard pile to the staging area.")
                .WithShadow("Shadow: Each Undead enemy engaged with you gets +1 Attack and +1 Defense until the end of the phase.")
                .WithInfo(23, 2, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Location("Decrepit City", string.Empty, setName, 5, 5)
                .WithTraits("Fornost.", "Ruins.")
                .WithText("While Decrepit City is the active location, 'when revealed' effects cannot be canceled.")
                .WithShadow("Shadow: Either discard 3 cards from the top of your deck, or this attack is considered undefended.")
                .WithInfo(24, 2, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Treachery("Paralyzing Fear", string.Empty, setName)
                .WithTraits("Sorcery.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to a hero and exhaust that hero. (Counts as a Condition attachment with the text: \"Forced: When attached hero would ready, it does not ready unless attached hero's controller discard a card from the top of his deck.\")")
                .WithInfo(25, 2, Artist.Unknown));
            addCard(LotRCard.Treachery("Curse of Angmar", string.Empty, setName)
                .WithTraits("Sorcery.")
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player discards each card in his hand that has the same title as a card in his discard pile. If no cards are discarded by this effect, Curse of Angmar gains surge.")
                .WithFlavor("...the Dúnedain were now few and all the peoples of Eriador diminished. -The Return of the King")
                .WithInfo(26, 2, Artist.Anthony_Feliciano));
            addCard(LotRCard.EncounterSideQuest("Gather Your Courage", string.Empty, setName, 8)
                .WithFlavor("Battling the dead drains your spirit as well as your body.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Each player placed the top 8 cards fo his deck facedown under this quest.\r\nForced: When this quest is defeated, shuffle each card under this quest into its owner's deck.")
                .WithVictoryPoints(10)
                .WithInfo(27, 1, Artist.Aleksander_Karcz));
        }
    }
}