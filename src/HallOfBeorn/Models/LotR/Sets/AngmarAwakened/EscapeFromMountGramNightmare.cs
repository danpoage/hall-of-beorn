using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class EscapeFromMountGramNightmare : CardSet
    {
        private const string setName = "Escape from Mount Gram Nightmare";
        private const string angmarOrcsSetName = "Angmar Orcs Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "EfMGN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2076;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: After choosing a starting hero and randomly setting another hero aside facedown, instead of the standard captured deck setup, shuffle any remaining heroes into your captured deck, then place the facedown set aside hero on the bottom of your captured deck.\r\nThe players cannot win the game while a hero is captured (underneath an encounter card, or in their captured deck).")
                .WithFlavor("\"Slash them! Beat them! Bite them! Gnash them! Take them away to dark holes full of snakes, and never let them see the light again!\"\r\n-The Great Goblin, The Hobbit")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the ~Escape from ~Mount ~Gram scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

4x Prison Cell
3x Dungeon Guard
1x Jailor Gornákh
2x Interrogation
1x Goblin Tormentor
1x Cruel Torturer

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Escape from ~Mount ~Gram encounter deck.

Note: This Nightmare Deck includes a card for the Angmar Orcs encounter set, Orc of Thaurdir. During setup, this card should be set aside along with the rest of the Angmar Orcs encounter set.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithTemplate2(
@"<p>Begin with the standard quest deck and encounter deck for the Escape from Mount Gram scenario.</p>
<p>Remove the following cards, in the specified quantities, from the standard encounter deck:</p>
<ul style='list-style-type:none'><b>
<li>4x Prison Cell</li>
<li>3x Dungeon Guard</li>
<li>1x Jailor Gornákh</li>
<li>2x Interrogation</li>
<li>1x Goblin Tormentor</li>
<li>1x Cruel Torturer</li>
<b></ul>
<p>Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Escape from Mount Gram encounter deck.</p>
<p><b>Note:</b> This Nightmare Deck includes a card for the Angmar Orcs encounter set, Orc of Thaurdir. During setup, this card should be set aside along with the rest of the Angmar Orcs encounter set.</p>
<p>Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.</p>")
                .WithInfo(1, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Jailor Gornákh", string.Empty, setName, 45, 4, 5, 5, 14)
                .WithUnique()
                .WithTraits("Goblin.", "Orc.")
                .WithText("Forced: After Jailor Gornákh enters playt each player searches his captured deck for each hero and captures thme underneath Jailor Gornákh.\r\nForced: After a player rescues any number of cards, Jailor Gornákh attacks that player.")
                .WithVictoryPoints(5)
                .WithInfo(2, 1, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Enemy("Prison Guard", string.Empty, setName, 26, 2, 2, 1, 4)
                .WithTraits("Goblin.", "Orc.")
                .WithKeywords("Capture 1.")
                .WithText("While you are engaged with Prison Guard, it gainst: \"Planning Action: Rescue a random card from underneath Prison Guard. Then, raise each player's threat by X, where X is that card's printed cost. (Limit once per round).\"")
                .WithInfo(3, 2, Artist.Ivan_Dixon));
            addCard(LotRCard.Location("Prison Cell", string.Empty, setName, 2, 3)
                .WithTraits("Underground.")
                .WithKeywords("Capture 1.")
                .WithText("While Prison Cell is the active location, it gains: \"Planning Action: Rescue a random cards from underneath Prison Cell. Then, raise each player's threat by X, where X is that card's printed cost. (Limit once per round).\"")
                .WithInfo(4, 2, Artist.Guillaume_Ducos));
            addCard(LotRCard.Location("Torture Chamber", string.Empty, setName, 0, 255)
                .WithTraits("Underground.")
                .WithKeywords("Capture 1.", "Surge.")
                .WithText("X is twice the number of cards captured underneath Torture Chamber.\r\nForced: At the end of the combat phase, if Torture Chamber is in the staging area, deal 1 damage to each exhausted character.")
                .WithInfo(5, 2, Artist.Ivan_Dixon));
            addCard(LotRCard.Treachery("Cruel Torment", string.Empty, setName)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to the current quest. Counts as a Condition attachment with the text: \"Each player cannot have more than 6 cards in his hand. (Each player with more than 6 cards in his hand must immediately discard cards until he has 6 cards in his hand.)\"")
                .WithInfo(6, 2, Artist.Guillaume_Ducos));
            addCard(LotRCard.Treachery("Goblin Patrol", string.Empty, setName)
                .WithText("When Revealed: Each player may capture any number of random cards from his hand underneat the current quest. Each player raises his threat by the number of cards in his hand.")
                .WithShadow("Shadow: Capture 3 random cards from your hand underneath attacking enemy.")
                .WithInfo(7, 2, Artist.Mariusz_Gandzel));
            addCard(LotRCard.EncounterSideQuest("Raid Golfimbul's Vault", string.Empty, setName, 9)
                .WithKeywords("Surge.", "Capture 3.")
                .WithText("Forced: After a card is captured by another card effect, capture a random cards from each player's hand underneath Raid Golfimbul's Vault.\r\nForced: When the captured cards underneath Golfimbul's Vault are rescued, put each rescued Item card into its owner's hand and discard the rest.")
                .WithVictoryPoints(10)
                .WithInfo(8, 1, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Enemy("Orc of Thaurdir", string.Empty, angmarOrcsSetName, 35, 3, 4, 3, 5)
                .WithTraits("Orc.")
                .WithText("Forced: When Orc of Thaurdir attacks you, either discard the top 2 cards of your captured deck, or deal Orc of Thaurdir 2 additional shadow cards.")
                .WithShadow("Shadow: For each damage dealt by this attack, discard the top card of your captured deck.")
                .WithInfo(9, 2, Artist.Rafal_Hrynkiewicz));
        }
    }
}