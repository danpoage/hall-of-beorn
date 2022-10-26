using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class FlightOfTheStormcallerNightmareSet : CardSet
    {
        private const string setName = "Flight of the Stormcaller Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "FotSN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2084;

            addNightmareSetup(setName)
                .WithText("You are playing Nightmare mode.\r\nWhile you are at the same stage as the Stormcaller, the main quest gets +X quest points, where X is the Stormcaller's remaining hit points.")
                .WithFlavor("...the Sea became a word of fear among them, and a token of death, and they turned their faces away from the hills in the west.\r\n-The Fellowship of the Ring")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the Flight of the Stormcaller scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("2x Calm Waters")
                .WithOppositeTextLine("2x Corsair Skiff")
                .WithOppositeTextLine("2x Southron Sailor")
                .WithOppositeTextLine("2x Serpent's Blade")
                .WithOppositeTextLine("1x Hidden Cove")
                .WithOppositeTextLine("2x Jagged Reef")
                .WithOppositeTextLine("Then shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Flight on the Stormcaller encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithOppositeTextLine("☸*: Some Cards in the Flight of the Stormcaller Nightmare Deck have Sailing Success symbols (☸) with an asterisk (*) next to them. This indicates that the card has a Forced effect which will trigger when the card is discarded during a sailing test.")
                .WithInfo(1, 1, Artist.Federico_Musetti);
            addEnemy("Raider of the Storm", setName, 28, 0, 3, 3, 4)
                .WithTraits("Corsair.")
                .WithTextLine("While Raider of the Storm is engaged with you, each Ship enemy engaged with you gets +1 Threat, +1 Attack, +1 Defense, and contributes its Threat to the total Threat in the staging area.")
                .WithInfo(2, 4, Artist.Monztre);
            addShipEnemy("Tide-runner", setName, 44, 4, 4, 2, 9)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Cannot have attachments.")
                .WithTextLine("While you are off-course (Cloudy, Rainy, or Stormy), Tide-runner is considered to be in the Stormcaller's area and the staging area, regardless of its current location.")
                .WithTextLine("When Revealed: Either choose a player to engage Tide-runner, or add Tide-runner to the Stormcaller's area and it gains surge.")
                .WithInfo(3, 2, Artist.Brenda_Bae);
            addShipEnemy("Venom's Bite", setName, 34, 5, 8, 5, 14)
                .WithUnique()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithTextLine("Boarding 2. Cannot have attachments.")
                .WithTextLine("*Forced: After this Sailing test ends, if you are off-course (Cloudy, Rainy, or Stormy), put the Venom's Bite into play in the staging area. If you are on-course (Sunny), put it into play in the Stormcaller's area instead.")
                .WithTextLine("☸*")
                .WithVictoryPoints(5)
                .WithInfo(4, 1, Artist.Brenda_Bae);
            addLocation("Sharp Jetties", setName, 2, 6)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("When Revealed: If your heading is off-course (Cloudy, Rainy, or Stormy), make Sharp Jetties the active location, returning any currently active location to the staging area.")
                .WithTextLine("Forced: When any amount of progress is placed on Sharp Jetties, either remove an equal amount of progress from the current quest, or deal an equal amount of damage to each Ship objective.")
                .WithInfo(5, 3, Artist.Jordan_Saia);
            addLocation("Cliffside Inlet", setName, 4, 3)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("While Cliffside Inlet is in the staging area, the main quest gets +2 quest points.")
                .WithTextLine("Travel: Discard cards from the top of the encounter deck until a Ship enemy is discarded. Put that enemy into play in the Stormcaller's area.")
                .WithTextLine("☸")
                .WithInfo(6, 3, Artist.Jordan_Saia);
            addTreachery("Dark and Stormy", setName)
                .WithTraits("Weather.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Deal 1 shadow card to each Ship enemy in play. Until the end of the round, shadow effects cannot be canceled.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack after this one.")
                .WithInfo(7, 3, Artist.Federico_Musetti);
            addTreachery("Sahír's Getting Away!", setName)
                .WithTextLine("When Revealed: For each Ship enemy in the Stormcaller's area, place 1 progress on the Stormcaller's quest stage. Then, either shift your heading off-course or add 8 Threat to the staging area until the end of the phase.")
                .WithShadow("Shadow: If this attack damages a Ship objective, place 1 progress on the Stormcaller's quest stage.")
                .WithInfo(8, 3, Artist.Guillaume_Ducos);
        }
    }
}
