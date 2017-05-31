using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
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
        }
    }
}