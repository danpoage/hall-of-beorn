using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheRingMaker
{
    public class TheNinInEilphNightmare : CardSet
    {
        private const string setName = "The Nîn-in-Eilph Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            NormalizedName = "The Nin-in-Eilph Nightmare";
            Abbreviation = "NiEN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2071;

            Cards.Add(LotRCard.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: When the players advance to stage 2A, add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player).")
                .WithFlavor("There was a deep silence, only scraped on its surfaces by the faint quiver of empty seed plumes, and broken grass-blades trembling in small air-movements that they could not feel. -The Two Towers")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for The Nîn-in-Eilph scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x A Weary Passage (Stage 1B)
1x Impassable Marshland (Stage 2B)
3x Neekerbreekers
1x Hidden Eyot
3x Finger of Glanduin
2x Off Track
1x Low on Provisions

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Nin-in-Eilph encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effects remain active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Claudio_Pozas));
            Cards.Add(LotRCard.Enemy("Deadly Marsh Adder", "", setName, 30, 3, 4, 2, 5)
                .WithTraits("Creature.")
                .WithText("Forced: After Deadly Marsh Adder engages you, discard a damaged character you control.\r\nForced: After the players advance to a quest stage return Deadly Marsh Adder to the staging area.")
                .WithInfo(2, 3, Artist.Rafal_Hrynkiewicz));
            Cards.Add(LotRCard.Enemy("Swarm of Mosquitoes", "", setName, 25, 2, 3, 1, 7)
                .WithTraits("Creature.", "Insect.")
                .WithText("Cannot have attachments.\r\nWhile Swarm of Mosquitoes is in the victory display, it gains: \"Forced: After the players advance to a quest stage, return Swarm of Mosquitoes to the staging area.\"")
                .WithInfo(3, 3, Artist.Yog_Joshi));
            Cards.Add(LotRCard.Location("Desolate Meadow", "", setName, 2, 5)
                .WithTraits("Marsh.")
                .WithText("While Desolate Meadow is in the staging area, it gains: \"Forced: After any number of time counters are removed from the current quest, heal 2 damage on each Creature enemy in play.\"")
                .WithShadow("Shadow: If this attack destroys a character, remove all progress from the current quest.")
                .WithInfo(4, 3, Artist.Matthew_Cowdery));
            Cards.Add(LotRCard.Location("Peat Bog", "", setName, 3, 3)
                .WithTraits("Marsh.")
                .WithText("While Peat Bog is in the staging area, it gains: \"Forced: After the players advance to a quest stage, each player discards 1 random card from his hand.\"")
                .WithFlavor("Dead grasses and rotting reeds loomed up in the mists like ragged shadows of long-forgotten summers.\r\n-The Two Towers")
                .WithInfo(5, 4, Artist.Igor_Burlakov));
            Cards.Add(LotRCard.Treachery("Quicksand", "", setName)
                .WithText("When Revealed: Either remove 1 time counter from the current quest or remove each character with 3 or more Willpower from the quest.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(6, 2, Artist.Mark_Molnar));
            Cards.Add(LotRCard.Treachery("Rotten Stench", "", setName)
                .WithText("When Revealed: Return the topmost location in the encounter discard pile to the staging area. Until the end of the phase, each location in the staging area gets +1 Willpower.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(7, 2, Artist.Nele_Diel));
            Cards.Add(LotRCard.Quest("Through the Marsh", 2, setName, 13)
                .WithOppositeTitle("An Arduous Journey", true)
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithFlavor("As you trudge through endless swamp, you begin to wonder if you will ever reach the other side.")
                .WithText("When Revealed: Raise each player's threat by 1.")
                .WithKeywords("Time 3.")
                .WithOppositeText("Forced: After the last time counter is removed from this stage, advance to a different stage 2A at random. Return this stage to the quest deck.\r\nAllies enter play exhausted.\r\nForced: When the players defeat this stage, advance to a random stage 3A.")
                .WithBackArtist(Artist.Von_Caberte)
                .WithInfo(8, 1, Artist.Mariusz_Gandzel));
            Cards.Add(LotRCard.Quest("Lost in the Swanfleet", 3, setName, 16)
                .WithOppositeTitle("Deadly Waters", true)
                .WithIncludedEncounterSets(EncounterSet.WearyTravelers)
                .WithFlavor("Lost as you are, your presence in the marsh has not gone unnoticed. An ancient and foul swamp creature stalks your company...")
                .WithText("When Revealed: Raise each player's threat by 1. Add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player) and heal all damage from it.")
                .WithKeywords("Time 3.")
                .WithText("Forced: After the last time counter is removed from this stage, advance to a different stage 3A at random. Return this stage to the quest deck.\r\nTreachery card effects cannot be canceled.")
                .WithBackArtist(Artist.Claudio_Pozas)
                .WithInfo(9, 1, Artist.Silver_Saaremael));
        }
    }
}