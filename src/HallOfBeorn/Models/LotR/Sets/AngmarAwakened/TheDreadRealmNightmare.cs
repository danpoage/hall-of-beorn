using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheDreadRealmNightmare : CardSet
    {
        private const string setName = "The Dread Realm Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TDRN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2080;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.")
                .WithFlavor("For at that time the realm of Angmar arose in the North beyond the Ettenmoors. Its lands lay on both sides of the Mountains, and there were gathered many evil men, and Orcs, and other fell creatures.\r\n-The Return of the King")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for The Dread Realm scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Witch of Angmar
2x A Fell Dread
1x Unholy Crypt
1x Sinister Dungeon
2x Dead Lord
3x Terror of the North

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Dread Realm encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for The Dread Realm scenario.</p>
<p>Remove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>3x Witch of Angmar</li>
<li>2x A Fell Dread</li>
<li>1x Unholy Crypt</li>
<li>1x Sinister Dungeon</li>
<li>2x Dead Lord</li>
<li>3x Terror of the North</li>
</b></ul>
<p>Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Dread Realm encounter deck.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>")
                .WithInfo(1, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Silent Guardian", string.Empty, setName, 36, 4, 2, 4, 10)
                .WithTraits("Undead.")
                .WithText("While you are engaged with Silent Guardian, it gains: \"Forced: The first time you play an event card each round, instead of discarding that card after playing it, reanimate it.\"")
                .WithInfo(2, 2, Artist.JB_Casacop));
            addCard(LotRCard.Enemy("Necromancer of Carn Dûm", string.Empty, setName, 28, 2, 254, 3, 3)
                .WithTraits("Sorcerer.")
                .WithText("Forced: When Necromancer of Carn Dûm would attack you, instead reanimate the top card of your deck and deal it each of the Necromancer of Carn Dûm's shadow cards.")
                .WithInfo(3, 3, Artist.Sara_Biddle));
            addCard(LotRCard.Location("Inner Sanctum", string.Empty, setName, 6, 4)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithText("Progress cannot be placed on Inner Sanctum while it is in the staging area.\r\nTravel: Discard the top 3 cards of the encounter deck. Resolve the 'when revealed' effects of each Sorcery card discarded by this effect.")
                .WithInfo(4, 2, Artist.Federico_Musetti));
            addCard(LotRCard.Location("Cursed Halls", string.Empty, setName, 3, 5)
                .WithTraits("Carn Dûm.", "Underground.")
                .WithText("While Cursed Halls is in the staging area, Sorcery attachments are immune to player card effects.")
                .WithShadow("Shadow: Until the end of the phase, attacking enemy gets +1 Attack and +1 Defense for each Reanimated Dead engaged with you.")
                .WithInfo(5, 3, Artist.Federico_Musetti));
            addCard(LotRCard.Treachery("Power Beyond Death", string.Empty, setName)
                .WithTraits("Sorcery.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to the main quest. (Counts as a Condition attachment with the text: \"Daechanar gets +2 Defense.\")")
                .WithShadow("Shadow: If this attack destroys a character, resolve this card's 'when revealed' effect.")
                .WithInfo(6, 3, Artist.JB_Casacop));
            addCard(LotRCard.Treachery("Daechanar's Curse", string.Empty, setName)
                .WithTraits("Sorcery.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach Daechanar's Curse to the top of the first player's deck. (Counts as a Condition attachment with the text: \"The next time a player would draw 1 or more cards from attached deck, reanimate those cards instead. Then, discard Daechanar's Curse.\")")
                .WithInfo(7, 3, Artist.Jokubas_Uoginitas));
            addCard(LotRCard.Treachery("All is Lost", string.Empty, setName)
                .WithTraits("Sorcery.")
                .WithText("When Revealed: Attach All is Lost to the first player's threat dial. (Counts as a Condition attachment with the text: \"Each time you attack a Reanimated Dead, raise your threat by 1.\")")
                .WithShadow("Shadow: If attacking enemy is a Reanimated Dead, it attacks again after this attack.")
                .WithInfo(8, 2, Artist.Guillaume_Ducos));
            addCard(LotRCard.EncounterSideQuest("The Witch-king's Gift", string.Empty, setName, 8)
                .WithFlavor("Daechanar is powerful in the art of necromancy. His army will not rest until you join them in death.")
                .WithKeywords("Time 5.")
                .WithText("Forced: When the last time counter is removed from this quest, reanimated each card in each player's discard pile. Then, remove The Witch-king's Gift from the game.\r\nWhen this quest is defeated, place it in the encounter discard pile.")
                .WithInfo(9, 1, Artist.Guillaume_Ducos));
        }
    }
}