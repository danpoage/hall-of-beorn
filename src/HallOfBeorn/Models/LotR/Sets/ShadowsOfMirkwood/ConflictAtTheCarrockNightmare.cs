using System;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
{
    public class ConflictAtTheCarrockNightmare : CardSet
    {
        public const string setName = "Conflict at the Carrock Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CatCN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2004;

            addNightmareSetup(setName)
                .WithTextLine("You are playing Nightmare mode.")
                .WithTextLine("Stage 1A should read, \"Remove 5 unique Troll cards\" instead of 4.")
                .WithTextLine("Stage 2B should read, \"When Revealed: Place Louis, Morris, Rupert and Stuart into the staging area.\"")
                .WithTextLine("Forced: At the end of the quest phase, if no progress was placed on the current quest this phase, place 1 progress on the current quest (bypassing the active location).")
                .WithTextLine("Reponse: After defeating a unique Troll enemy, you may choose and discard 1 \"Sacked!\" card from play.")
                .WithOppositeTextLine("Begin with the standard quest deck and encounter deck for the Conflict at the Carrock scenario.")
                .WithOppositeTextLine("Remove the following cards, in the specified quantities, from the standard encounter deck:")
                .WithOppositeTextLine("1x Grimbeorn the Old")
                .WithOppositeTextLine("1x Louis")
                .WithOppositeTextLine("1x Morris")
                .WithOppositeTextLine("1x Stuart")
                .WithOppositeTextLine("1x Rupert")
                .WithOppositeTextLine("3x Bee Pastures")
                .WithOppositeTextLine("3x Oak-wood Grove")
                .WithOppositeTextLine("1x Roasted Slowly")
                .WithOppositeTextLine("3x Misty ~Mountain Goblins")
                .WithOppositeTextLine("2x Banks of the Anduin")
                .WithOppositeTextLine("1x Wolf Rider")
                .WithOppositeTextLine("2x ~Goblin Sniper")
                .WithOppositeTextLine("2x Wargs")
                .WithOppositeTextLine("2x Despair")
                .WithOppositeTextLine("2x The Brown Lands")
                .WithOppositeTextLine("2x The East Bight")
                .WithOppositeTextLine("Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Conflict at the Carrock encounter deck.")
                .WithOppositeTextLine("Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Jake_Murray);
            addEnemy("Savage Hill-troll", setName, 21, 1, 3, 2, 6)
                .WithTraits("Troll.")
                .WithTextLine("While Savage Hill-troll is in the victory display, each Troll enemy gets +1 hit point.")
                .WithShadow("Shadow: If attacking enemy is a Troll, defending character does not ready during the refresh phase this round.")
                .WithVictoryPoints(1)
                .WithInfo(2, 4, Artist.Jim_Pavelec);
            addEnemy("Rob and Bob", setName, 34, 4, 5, 4, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("Forced: After Rob and Bob makes its first attack each round, if there are two or more players, it engages the next player and makes an additional attack (discard and deal a new shadow card for this attack).")
                .WithFlavorLine("Yes, I am afraid trolls do behave like that, even those with only one head each.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(3, 1, Artist.Jim_Pavelec);
            addEnemy("Louis", setName, 34, 4, 4, 2, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("Forced: After Louis attacks, the defending player must raise his threat by 3.")
                .WithTextLine("While Louis is in the victory display, each Troll enemy gains, \"Forced: After this enemy attacks, the defending player must raise his threat by 1.\"")
                .WithVictoryPoints(2)
                .WithInfo(4, 1, Artist.Jake_Murray);
            addEnemy("Morris", setName, 34, 3, 4, 2, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("Immune to player events.")
                .WithTextLine("While Morris is in the victory display, each Troll enemy gets +1 Attack and gains \"Immune to player events.\".")
                .WithVictoryPoints(2)
                .WithInfo(5, 1, Artist.Mariusz_Gandzel);
            addEnemy("Rupert", setName, 34, 2, 5, 3, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("Rupert's Defense cannot be reduced.")
                .WithTextLine("While Rupert is in the victory display, the Defense of each Troll enemy cannot be reduced.")
                .WithVictoryPoints(2)
                .WithInfo(6, 1, Artist.Sidharth_Chatursedi);
            addEnemy("Stuart", setName, 34, 2, 4, 4, 10)
                .WithUnique()
                .WithTraits("Troll.")
                .WithTextLine("Cannot have player attachments.")
                .WithTextLine("While Stuart is in the victory display, each Troll enemy gets +1 Defense and gains \"Cannot have player attachments.\"")
                .WithVictoryPoints(2)
                .WithInfo(7, 1, Artist.Mariusz_Gandzel);
            addLocation("Troll Lair", setName, 2, 5)
                .WithTraits("Forest.")
                .WithTextLine("While Troll Lair is in the staging area, players cannot reduce their threat.")
                .WithShadow("Shadow: If attacking enemy is a Troll, remove 4 damage tokens from it.")
                .WithInfo(8, 3, Artist.Ed_Mattinian);
            addLocation("Hives and Hives", setName, 3, 3)
                .WithTraits("Wilderlands.")
                .WithTextLine("Forced: After any amount of progress is placed on Hives and Hives, deal 1 damage to each character in play.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithFlavorLine("There was a buzzing and a whirring and a droning in the air. Bees were busy everywhere. And such bees! Bilbo had never seen anything like them.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(9, 3, Artist.Jose_Vega);
            addTreachery("Time for Supper", setName)
                .WithTextLine("When Revealed: The first player chooses a hero in any player's discard pile and removes that hero from the game. Then, heal all damage from each Troll enemy in play. If no damage is removed from any Troll enemy as a result of this effect, Time for Supper gains surge.")
                .WithFlavorLine("In the end they decided to mince them fine and boil them. So they got a black pot, and they took out their knives.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(10, 3, Artist.Alvaro_Calvo_Escudero);
            addQuest("Grimbeorn's Folly", setName, 3, 'A', Card.VALUE_NA)
                .WithFlavorLine("Just as you think the fight is over, you find tracks that lead you to what appears to be the leader of this group of Trolls. You can see Grimbeorn the Old, captured and ready to be cooked. It's up to you to save him!")
                .WithTextLine("When Revealed: Add Rob and Bob to the staging area. Then, each player must search the encounter deck and discard pile for a non-unique Troll enemy and add it to the staging area, if able. Shuffle the encounter deck.")
                .WithOppositeFlavorLine("A nice pickle they were all in now. -The Hobbit")
                .WithOppositeTextLine("When Rob and Bob have been defeated, the players have rescued Grimbeon the Old from certain death, and won the game.")
                .WithIncludedEncounterSets(EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands)
                .WithInfo(11, 1, Artist.Tiziano_Baracchi);
        }
    }
}