using System;

namespace HallOfBeorn.Models.LotR.Sets.Dwarrowdelf
{
    public class TheRedhornGateNightmare : CardSet
    {
        private const string setName = "The Redhorn Gate Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TRGN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2053;

            addNightmareSetup(EncounterSet.TheRedhornGateNightmare)
                .WithTextLine("You are playing in Nightmare mode.")
                .WithTextLine("Setup: Remove all copies of Blinding Blizzard from the encounter deck and set them aside, out of play. During this game, player cards in the victory display do not count their victory points.")
                .WithTextLine("Forced: When stage 2b is revealed, shuffle each set aside copy of Blinding Blizzard into the encounter deck.")
                .WithFlavorLine("A cold wind flowed down behind them, as they turned their backs on the Redhorn Gate, and stumbled wearily down the slope. Caradhras had defeated them.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for The Redhorn Gate scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("1x Black Uruks")
                .WithOppositeTextLine("3x Mountain Warg")
                .WithOppositeTextLine("1x Knees of the Mountain")
                .WithOppositeTextLine("2x Turbulent Waters")
                .WithOppositeTextLine("2x Warg Lair")
                .WithOppositeTextLine("1x The Dimrill Stair")
                .WithOppositeTextLine("2x Fell Voices")
                .WithOppositeTextLine("2x Fallen Stones")
                .WithOppositeTextLine("3x Mountain Goblin")
                .WithOppositeTextLine("Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Redhorn Gate encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Alyn_Spiller);
            addEnemy("Wolfpelt Goblin", EncounterSet.TheRedhornGateNightmare, 20, 2, 3, 2, 4)
                .WithTraits("Goblin.", "Orc.", "Snow.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After engaging Wolfpelt Goblin, the engaged player must deal X damage to 1 character he controls, where X is the active location's remaining quest points. Then, remove 2 progress from the active location, if able.")
                .WithInfo(2, 3, Artist.Diego_Gisbert_Llorens);
            addEnemy("Silvertide Marauder", EncounterSet.TheRedhornGateNightmare, 28, 2, 3, 3, 6)
                .WithTraits("Orc.")
                .WithTextLine("While attacking, Silvertine Marauder gets +2 Attack if the defending character has less than 2 Willpower.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack if the defending character has less than 2 Willpower.")
                .WithInfo(3, 4, Artist.Aurelien_Hubert);
            addEnemy("Snow-Giant", setName, 42, 4, 6, 4, 10)
                .WithTraits("Giant.", "Snow.")
                .WithText("While Snow-Giant is in the staging area, it attacks the first player during the combat phase, as if it were engaged.\r\nForced: After Snow-Giant engages you, discard the ally you control with the highest Willpower.")
                .WithVictoryPoints(1)
                .WithInfo(4, 2, Artist.Jason_Ward);
            addLocation("Icy Cavern", EncounterSet.TheRedhornGateNightmare, Card.VALUE_X, 6)
                .WithTraits("Mountain.", "Snow.")
                .WithTextLine("X is the number of Snow cards in the staging area.")
                .WithTextLine("Travel: Search the encounter deck and discard pile for 1 copy of Freezing Cold and reveal it to travel here. Shuffle the encounter deck.")
                .WithShadow("Shadow: Defending character gets -1 Willpower. Deal the attacking enemy 1 additional shadow card.")
                .WithInfo(5, 3, Artist.Julian_Kok);
            addLocation("Frozen Silverlode", EncounterSet.TheRedhornGateNightmare, 3, 3)
                .WithTraits("Mountain.", "River.")
                .WithTextLine("While Frozen Silverlode is in the staging area, characters cannot gain Willpower from player card effects.")
                .WithShadow("Shadow: Defending character gets -1 Willpower. Deal the attacking enemy 1 additional shadow card.")
                .WithFlavorLine("\"...and there the River Silverlode rises in its icy springs.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Alyn_Spiller);
            addTreachery("Blinding Blizzard", EncounterSet.TheRedhornGateNightmare)
                .WithTraits("Snow.")
                .WithTextLine("While Blinding Blizzard is in play, heroes do not collect resources during the resource phase.")
                .WithTextLine("When Revealed: Add Blinding Blizzard to the staging area. Progress that would be placed on the current quest or on Snow locations are instead placed on Blinding Blizzard. When the 5th progress is placed on Blinding Blizzard, discard it.")
                .WithInfo(7, 2, Artist.Julian_Kok);
            addTreachery("Caradhras the Cruel", EncounterSet.TheRedhornGateNightmare)
                .WithTextLine("When Revealed: Return all Snow cards in the encounter discard pile to the top of the encounter deck, in random order. Reveal the top card of the encounter deck (reveal the top 2 cards instead if there are 3 or 4 players in the game).")
                .WithFlavorLine("\"Caradhras has not forgiven us,\" he said. \"He has more snow yet to fling at us, if we go on.\"")
                .WithFlavorLine("-Gimli, The Fellowship of the Ring")
                .WithInfo(8, 2, Artist.Alvaro_Calvo_Escudero);
        }
    }
}