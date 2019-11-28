using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class TheCityOfCorsairsNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The City of Corsairs Nightmare";
            Abbreviation = "TCoCN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2089;

            addNightmareSetup(EncounterSet.TheCityOfCorsairsNightmare)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Setup: When choosing a Dol Amroth objective to put into play during setup, players must choose randomly among all 6 Dol Amroth objectives.")
                .WithTextLine("Raider Flagship cannot guard objectives.")
                .WithTextLine("While any player is engaged with Raider Flagship, no more than 5 progress can be placed on the current quest each round.")
                .WithFlavorLine("And in the morning the banner of Dol Amroth, a white ship like a swan upon blue water, floated from the Tower...")
                .WithFlavorLine("-The Return of the King")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the A Storm on Cobas Haven scenario.")
                .WithOppositeTextLine("Remove the following card, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("2x Belfalas Islet")
                .WithOppositeTextLine("2x Cobas Haven")
                .WithOppositeTextLine("2x Fog Bank")
                .WithOppositeTextLine("2x Corsair Skirmisher")
                .WithOppositeTextLine("1x Ramming Speed!")
                .WithOppositeTextLine("2x Corsair Infiltrator")
                .WithOppositeTextLine("1x Cunning Pirate")
                .WithOppositeTextLine("1x Umbar Raider")
                .WithOppositeTextLine("Then, shuffle the encounter card in this Nightmare Deck into the remainder of the standard A Storm on Cobas Haven encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and placr it next to the quest deck. Its effect remains active throughout the game, which is now ready to being.")
                .WithOppositeTextLine("Wheel*: Some cards in the A Storm on Cobas Haven Nightmare Deck having Sailing success symbols (Wheel) with an asterist (*) next to them. This indicates that the card has a Forced effect which will trigger when the card is discarded during a Sailing test.")
                .WithInfo(1, 1, Artist.Logan_Feliciano);
        }
    }
}