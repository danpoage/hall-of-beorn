using System;

namespace HallOfBeorn.Models.LotR.Sets.AngmarAwakened
{
    public class AcrossTheEttenmoorsNightmareSet : CardSet
    {
        protected override void Initialize()
        {
            Name = EncounterSet.AcrossTheEttenmoorsNightmare.Name;
            Abbreviation = "AtEN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2077;

            addNightmareSetup(EncounterSet.AcrossTheEttenmoorsNightmare.Name)
                .WithText("You are playing Nightmare mode.\r\nForced: When resolving the 'when revealed' effect on stage 2A or stage 3A, also discard cards from the top of the encounter deck until a location with the safe keyword is discarded. Attach that location to the newly revealed side quest, as a guarded objective.")
                .WithFlavor("\"I reached here at last by a long hard road, up the Hoarwell and through the Ettenmoors, and down from the north. It took me nearly fourteen days from Weathertop, for I could not ride among the rocks of the troll-fells, and Shadowfax departed.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithOppositeText(
@"Begin with the standard quest deck and encounter deck for the Across the ~Ettenmoors scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x Into the Ettenmoors
2x Shrouded Hills
3x No Rest
2x Arador's Bane
1x Troll-fells
2x Goblin Pursuer
2x Cold from Angmar

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Across the Ettenmoors encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Anthony_Devine);
            addQuest("Into the Ettenmoors", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 1, 'A', 10)
                .WithText("Setup: Set aside each side quest and each location with the safe keyword. Reveal 1 of those side quests and 1 of those safe locations at random, adding them to the staging area with the safe location guarded by the side quest. Shuffle the remaining side quests and safe location into the encounter deck. Discard cards from the top of the encounter deck until X enemies are discarded, where X is the number of players in the game. Add the discarded enemies to the staging area. The first player gains control of Amarthiúl.")
                .WithOppositeFlavor("You have escaped from the prisons of Mount Gram, but you are not safe yet.")
                .WithOppositeText("Forced: At the beginning of the quest phase, if there are no encounter side quests in play, discard cards from the top of the encounter deck until a side quest is discarded, reveal it, and add it to the staging area.")
                .WithInfo(2, 1, Artist.Alvaro_Calvo_Escudero);
            addEnemy("Hoarwell River Serpent", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 38, 3, 4, 3, 5)
                .WithTraits("Creature.")
                .WithText("As an additional cost to travel to a safe location, one player must engaged Hoarwell River Serpent.\r\nForced: When you engage Hoarwell River Serpent, deal 1 damage to each damaged character you control.")
                .WithInfo(3, 2, Artist.Guillaume_Ducos);
            addEnemy("Scavenging Stone-troll", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 42, 1, 7, 2, 14)
                .WithTraits("Troll.")
                .WithText("You cannot travel to a safe location while Scavenging Stone-troll has no damage on it.\r\nWhile Scavenging Stone-troll is in the staging area, cards in each player's discard pule cannot leave that discard pile.")
                .WithInfo(4, 2, Artist.Sebastian_Zakrzewski);
            addEnemy("Giant Beetle", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 14, 2, 3, 3, 3)
                .WithTraits("Creature.", "Insect.")
                .WithText("While Giant Beetle is engaged with a player, it gains: \"As an additional cost to travel to a safe location, Giant Beetle makes an immediate attack against the engaged player.\"\r\nDamaged characters cannot be declared as attackers or defenders against Giant Beetle.")
                .WithInfo(5, 2, Artist.Guillaume_Ducos);
            addLocation("Rocky Foothills", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 2, 2)
                .WithTraits("Ettenmoors.")
                .WithText("When face with the otpion to travel, the players must travel to Rocky Foothills, if able.\r\nRocky Foothills gets +2 quest points for each quest in play.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damage on the defending character.")
                .WithInfo(6, 2, Artist.Lukasz_Jaskolski);
            addLocation("Vast Troll-fells", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 3, 4)
                .WithTraits("Ettenmoors.")
                .WithText("As an additional cost to travel to a safe location, each player must spend 1 resource.\r\nHeroes cannot gain resources by card effects.")
                .WithShadow("Shadow: If no progress was placed on a side quest this round, attacking enemy gets +4 Attack.")
                .WithInfo(7, 2, Artist.Mariusz_Gandzel);
            addTreachery("Crashing Thunder", EncounterSet.AcrossTheEttenmoorsNightmare.Name)
                .WithTraits("Weather.")
                .WithText("When Revealed: Each player assigns X damage among characters he controls, where X is the number of quests in play. Exhaust each damaged character in play.")
                .WithShadow("Shadow: Shuffle each Weather cards from the encounter discard pile into the encounter deck.")
                .WithInfo(8, 3, Artist.JB_Casacop);
            addTreachery("Barren and Desolate", EncounterSet.AcrossTheEttenmoorsNightmare.Name)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Attach to a side quest. (Counts as a Condition attachment with the text: \"Limit 1 per quest. While attached quest is the current quest, each character gets -1 Willpower.\")")
                .WithInfo(9, 3, Artist.Lucas_Staniec);
            addEncounterSideQuest("Isolated", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 7)
                .WithFlavor("Caught in a dense fog, you suddenly find yourself separated from your companions.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Players cannot draw cards by card effects.")
                .WithTextLine("Forced: When this stage is defeated, each player draws 1 card.")
                .WithVictoryPoints(10)
                .WithInfo(10, 1, Artist.Michele_Frigo);
            addEncounterSideQuest("Rescue from the Trolls", EncounterSet.AcrossTheEttenmoorsNightmare.Name, 15)
                .WithText("When Revealed: Each player places the lowest-threat-cost hero he controls facedown underneath Rescue from the Trolls, out of play.\r\nResponse: After a Troll enemy is destroyed, place 3 progress on Rescue from the Trolls.\r\nForced: When Rescue from the Trolls is defeated, each player takes control of each of his heroes underneath it.")
                .WithVictoryPoints(10)
                .WithInfo(11, 1, Artist.Anthony_Devine);
        }
    }
}
