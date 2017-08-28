using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class TheWastesOfEriadorNightmare : CardSet
    {
        private const string setName = "The Wastes of Eriador Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWoEN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2075;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.")
                .WithFlavor("As the light grew stronger it showed a silent shrouded world. Below their refuge were white humps and domes and shapeless deeps beneath which the path that they had trodden was altogether lost...\r\n-The Fellowship of the Rings")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for The Wastes of Eriador scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

2x Northern Warg
1x White Warg
1x Sudden Darkness
1x North Downs
2x Eriador Wastes
1x Cold from Angmar
3x Biting Wind
1x Freezing Blast
1x Shrouded Hills
3x Rugged Country
2x Pressing Needs

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Wasts of Eriador encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Enemy("Pack Hunters", string.Empty, setName, 45, 3, 2, 1, 3)
                .WithTraits("Creature.", "Warg.")
                .WithText("While it is Night, Pack Hunters gets -30 engagement cost.\r\nForced: When you engage Pack Hunters, search the top 5 cards of the encounter deck for a Warg enemy, and put it into play engaged with you (top 10 cards instead if it is Night). Shuffle the encounter deck.")
                .WithInfo(2, 5, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Location("Shrouded Wilderness", string.Empty, setName, 6, 4)
                .WithTraits("Arnor.")
                .WithText("While it is Night, progress cannot be placed on Shrouded Wilderness.\r\nTravel: Flip the Time objective from Daybreak to Nightfall.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. Then, if it is Night, deal attacking enemy another shadow card.")
                .WithInfo(3, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Location("Snowy Badlands", string.Empty, setName, 3, 5)
                .WithTraits("Arnor.", "Hills.")
                .WithText("While Snowy Badlands is in the staging area, each enemy in the staging area cannot take damage.\r\nTravel: Each player deals 1 damage to an exhausted character he controls to travel here (2 damage instead if it is Night).")
                .WithInfo(4, 3, Artist.Lukasz_Jaskolski));
            addCard(LotRCard.Treachery("Cunning Wolves", string.Empty, setName)
                .WithText("When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Attached quest gets +3 quest points. Each Warg enemy cannot be optionally engaged.\")")
                .WithShadow("Shadow: If it is Night, deal attacking enemy 2 additional shadow cards")
                .WithInfo(5, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Treachery("Torrent of Hail", string.Empty, setName)
                .WithText("When Revealed: Deal 1 damage to each questing character. If it is Night, discard an attachment from each character damaged by this effect.")
                .WithShadow("Shadow: Discard 1 attachment you control (2 attachments instead if it is Night).")
                .WithInfo(6, 3, Artist.Guillaume_Ducos));
            addCard(LotRCard.EncounterSideQuest("Make a Stand", string.Empty, setName, 255)
                .WithText("When Revealed: If it is a Day, flip the Time objective to Nightfall, The Time objective cannot flip to Daybreak.\r\nResponse: After an enemy is defeated, place 1 resource token on Make a Stand. Then, if there are 2 resource tokens per player on Make a Stand, or if there are no enemies in play, add Make a Stand to the victory display.")
                .WithVictoryPoints(10)
                .WithInfo(7, 1, Artist.Michele_Frigo));
            addCard(LotRCard.EncounterSideQuest("Forced Off Track", string.Empty, setName, 8)
                .WithKeywords("Surge.")
                .WithText("Forced: At the end of the round, remove X progress from the main quest, where X is the number of Warg enemies in play.\r\nResponse: When this quest is defeated, discard a non-unique Warg enemy in the staging area.")
                .WithVictoryPoints(10)
                .WithInfo(8, 1, Artist.Anthony_Devine));
        }
    }
}