using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheWeatherHillsNightmare : CardSet
    {
        private const string setName = "The Weather Hills Nightmare";
        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TWHN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2073;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nSetup: Shuffle each copy of Captive Villager and Rearguard Ambusher into the Orc deck.\r\nThe players cannot win the game while a Captive Villager is guarded by an encounter card. If a Captive Villager leaves play, the players lose the game.")
                .WithFlavor("The land before them began to rise again, Away in the distance eastward they could not see a line of hills.\r\n-The Fellowship of the Ring")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for The ~Weather Hills scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

3x Cornered ~Orc
3x Sheltered Valley
1x Concealed Orc-camp
1x ~Angmar Marauder
2x ~Angmar ~Orc
3x Ruins of ~Arnor
2x Tragic Discovery

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Weather Hills encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(11, 1, Artist.Juan_Carlos_Barquet));
            addCard(LotRCard.ObjectiveAlly("Captive Villager", string.Empty, setName, 0, 0, 1, 2)
                .WithTraits("Bree.")
                .WithText("Forced: After Captive Villager enters play, reveal the top card of the Orc deck and attach it to Captie Villager, guarding it.\r\nWhile Captive Villager is free of encounters, the first player gains control of it and is considered to have +5 threat while making engagement checks.")
                .WithInfo(12, 4, Artist.Unknown));
        }
    }
}