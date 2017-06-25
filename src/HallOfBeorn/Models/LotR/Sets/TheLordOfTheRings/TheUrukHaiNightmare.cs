using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheLordOfTheRings
{
    public class TheUrukHaiNightmare : CardSet
    {
        private const string setName = "The Uruk-hai Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TUHN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2068;

            addCard(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nEach Captive is immune to player card effects.\r\nSetup: Set Mauhúr aisde, out of play.\r\nForced: When the players advance to  stage 2A, add Mauhúr to the staging area.")
                .WithFlavor("\r\n-The Two Towers")
                .WithOppositeText("Begin with the standard and encounter deck for The Passage of the Marshes scenario.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\n3x Groping Dead\r\n3x Dead Things\r\n3x Soft Mires\r\n3x Haunted Mere\r\n3x Bitter Reek\r\nThen, shuffle the encounter cards in this Nightmare ~Deck into the remainder of the standard The Passage of the Marshes encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Lucas_Staniec));
        }
    }
}