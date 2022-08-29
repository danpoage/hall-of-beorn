/* Generated CardSet class: The Fate of Wilderland */

using System;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class TheFateOfWilderlandSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Fate of Wilderland";
            Abbreviation = "TFoW";
            Number = 55;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            addHero("Radagast", 11, Sphere.Lore, 2, 2, 3, 4)
                .WithTraits("Istari.")
                .WithTextLine("You may use resources from Radagast's pool to pay for Creature allies of any sphere.")
                .WithTextLine("Response: After you play a Creature card, Radagast does not exhaust to quest this round.")
                .WithFlavorLine("\"..he has much lore of herbs and beasts, and birds are especially his friends.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithCommunityVersion("Radagast-Nightmare-in-the-Fog")
                .WithInfo(145, 1, Artist.Aleksander_Karcz);
            addAlly("Messenger Raven", 1, Sphere.Leadership, false, 1, 0, 0, 1)
                .WithTraits("Creature.")
                .WithTextLine("Cannot attack, defend, of have attachments.")
                .WithTextLine("Refresh Action: Return Messenger ~Raven to it's owner's hand and name a card type. Choose a player to look at the top card of his deck. If that card is the named type, add it to its owner's hand. If it is not, discard it.")
                .WithInfo(146, 3, Artist.Derek_D_Edgell);
            addEvent("The King's Return", 1, Sphere.Leadership)
                .WithTraits("Song.")
                .WithTextLine("Action: Search your deck for a Guarded attachment and put it into play. Shuffle your deck.")
                .WithFlavorLine("His crown shall be upholden,")
                .WithFlavorLine("His harp shall be restrung,")
                .WithFlavorLine("His halls shall echo golden")
                .WithFlavorLine("To songs of yore re-sung")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(147, 3, Artist.Tyler_Edlin);
            addAlly("Loyal Hound", 2, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Creature.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("Response: Discard Loyal ~Hound to cancel up to 2 damage just dealt to a hero you control.")
                .WithCommunityVersion("Loyal-Hound-Con-of-the-Rings-2019")
                .WithInfo(148, 3, Artist.Alvaro_Calvo_Escudero);
            addEvent("The Great Hunt", 3, Sphere.Lore)
                .WithTextLine("You must use resources from 3 different heroes' pools to pay for this card.")
                .WithTextLine("Combat Action: Choose and discard a non-unique enemy in the staging area.")
                .WithFlavorLine("...it seemed they could hear the noise of a great hunt going by to the north of the path...")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(149, 3, Artist.Carlos_Palma_Cruchaga);
            addAlly("Bywater Shirriff", 2, Sphere.Tactics, false, 1, 1, 1, 2)
                .WithTraits("Hobbit.", "Shirriff.")
                .WithTextLine("Bywater ~Shirriff gets +1 Willpower, +1 Attack, and +1 Defense while you are engaged with an enemy with engagement cost higher than your threat.")
                .WithFlavorLine("The Shirriffs was the name that the Hobbits gave to their police, or the nearest equivalent that they possessed.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(150, 3, Artist.Romana_Kendelic);
            addEvent("Gwaihir's Debt", 1, Sphere.Tactics)
                .WithTextLine("Play only if you control a unique character with the Istari trait and another unique character with the Eagle trait.")
                .WithTextLine("Action: ~Search the top 5 cards of your deck for an Eagle or Istari ally and put it into play. Shuffle your deck. At the end of the round, if that ally is still in play, return it to your hand.")
                .WithInfo(151, 3, Artist.Justin_Gerard);
            addAttachment("Mithril Shirt", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.", "Armor.")
                .WithKeywords("Guarded (location).")
                .WithTextLine("Guarded (location).")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Response: When attached hero is dealt any amount of damage, reduce that damage by 1.")
                .WithFlavorLine("It was of silver-steel which the Elves call mithril, and with it went a belt of pearls and crystals.")
                .WithFlavorLine("-The Hobbit")
                .WithInfo(152, 3, Artist.Sebastian_Zakrzewski);
            addEvent("Reforged", 254, Sphere.Spirit)
                .WithTextLine("Action: Choose an attachment with a printed cost of X in any player's discard pile and play that attachment for no cost. (The chosen attachment can belong to any sphere of influence.)")
                .WithFlavorLine("The Sword of Elendil was forged anew by Elvish smiths... -The Fellowship of the Ring")
                .WithInfo(153, 3, Artist.Sebastian_Zakrzewski);
            addAttachment("Radagast's Staff", 2, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithTextLine("Attach to Radagast.")
                .WithTextLine("Action: Exhaust Radagast's ~Staff to choose one: Reduce the cost of the next Creature ally you play this phase by 2, ready a Creature ally, or return a non-unique Creature enemy engaged with you to the staging area.")
                .WithInfo(154, 3, Artist.Sebastian_Zakrzewski);
            addObjective("The Goblins' Assault", EncounterSet.TheFateOfWilderland)
                .WithTraits("Assault.")
                .WithTextLine("Urdug gets +2 Defense for each other enemy in play and cannot be dealt damage unless he had resolved an attack this phase.")
                .WithTextLine("Forced: After players quest unsuccessfully, place 1 progress here for each player in the game.")
                .WithInfo(155, 1, Artist.Rafal_Hrynkiewicz);
            addObjective("The Heroes' Defense", EncounterSet.TheFateOfWilderland)
                .WithTraits("Defense.")
                .WithTextLine("While there are X or more resources on The Heroes' ~Defense, Urdug is considered to be engaged with each player, X is five times the number of players.")
                .WithTextLine("Response: After an enemy is destroyed, place 1 resource here.")
                .WithInfo(156, 1, Artist.Jason_Jenicke);
            addEnemy("Urdug", EncounterSet.TheFateOfWilderland, 50, 2, 3, 2, 5)
                .WithUnique()
                .WithTraits("Orc.", "Goblin.")
                .WithTextLine("Immune to player card effects. Cannot leave the staging area.")
                .WithTextLine("Forced: When Urdug attacks, discard the top card of the encounter deck. He gets +X Attack for this attack, where X is the discarded card's printed Threat.")
                .WithTextLine("When Urdug is destroyed, the players win the game.")
                .WithVictoryPoints(5)
                .WithInfo(157, 1, Artist.Ivan_Dixon);
            addEnemy("Urdug's Elite", EncounterSet.TheFateOfWilderland, 25, 2, 3, 2, 5)
                .WithTraits("Orc.", "Goblin.")
                .WithTextLine("Forced: After Urdug's Elite engages you, either exhaust a character you control, or place 1 progress on The Goblins' ~Assault.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(158, 3, Artist.Monztre);
            addEnemy("Fierce Vanguard", EncounterSet.TheFateOfWilderland, 20, 2, 2, 2, 3)
                .WithTraits("Orc.", "Goblin.")
                .WithTextLine("Forced: After Fierce Vanguard engages you, either it gets +2 Attack until the end of the round, or place 1 progress on the The Goblins' ~Assault.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack and +2 Defense until the end of the phase.")
                .WithEasyModeQuantity(2)
                .WithInfo(159, 3, Artist.John_Gravato);
            addEnemy("Warg-rider", EncounterSet.TheFateOfWilderland, 30, 3, 4, 1, 4)
                .WithTraits("Orc.", "Goblin.")
                .WithTextLine("Forced: After Warg-rider is dealt a shadow card with no effect, either return it to the staging area or place 1 progress on The Goblins' ~Assault.")
                .WithInfo(160, 2, Artist.Guillaume_Ducos);
            addLocation("Gate of Gundabad", EncounterSet.TheFateOfWilderland, 4, 4)
                .WithUnique()
                .WithTraits("Mountain.", "Gate.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("While Gate of Gundabad is in the staging area, resources cannot be placed on The Heroes' ~Defense.")
                .WithTextLine("Travel: Search the encounter deck, discard pile, and victory display for a Goblin Troop and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(1)
                .WithInfo(161, 1, Artist.Leanna_Crossan);
            addLocation("Hilltop Battlements", EncounterSet.TheFateOfWilderland, 3, 3)
                .WithTraits("Mountain.", "Fortification.")
                .WithTextLine("While Hilltop Battlements is in the staging area, each non-unique enemy gets -5 engagement cost.")
                .WithTextLine("Forced: When Hilltop Battlements is explored, discard the top X cards of the encounter deck, where X is the number of players in the game. Add each enemy discarded by this effect to the staging area.")
                .WithInfo(162, 3, Artist.Andreas_Adamek);
            addLocation("Dwarven Watchtower", EncounterSet.TheFateOfWilderland, 2, 5)
                .WithTraits("Mountain.", "Fortification.")
                .WithTextLine("While Dwarven Watchtower is the active location, each hero gets +1 Defense.")
                .WithTextLine("Response: After Dwarven Watchtower is explored, the first player chooses: either place 1 resource on The Heroes' ~Defense, or remove 1 progress from The Goblins' ~Assault.")
                .WithVictoryPoints(2)
                .WithInfo(163, 3, Artist.Greg_Bobrowski);
            addLocation("Slopes of Gundabad", EncounterSet.TheFateOfWilderland, 2, 4)
                .WithTraits("Mountain.")
                .WithTextLine("When Revealed: Either place 1 progress on The Goblins' ~Assault, or reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy cannot take damage this phase.")
                .WithEasyModeQuantity(1)
                .WithInfo(164, 3, Artist.Leanna_Crossan);
            addTreachery("Fierce Attack", EncounterSet.TheFateOfWilderland)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Place X progress on The Goblins' ~Assault, where X is in the stage number of the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the stage number of the current quest.")
                .WithEasyModeQuantity(2)
                .WithInfo(165, 3, Artist.Jason_Jenicke);
            addTreachery("Urdug's Command", EncounterSet.TheFateOfWilderland)
                .WithTextLine("When Revealed: Urdug makes an immediate attack against the first player. If this attack destroys a character, place 1 progress on The Goblins' ~Assault.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 progress on The Goblins' ~Assault.")
                .WithEasyModeQuantity(2)
                .WithInfo(166, 3, Artist.Ivan_Dixon);
            addTreachery("Dark Clouds", EncounterSet.TheFateOfWilderland)
                .WithTextLine("When Revealed: Each enemy and each location in the staging area gets +1 Threat until the end of the phase. If the players quest unsuccessfully this phase, place 1 progress on The Goblins' ~Assault.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(167, 2, Artist.Alyn_Spiller);
            addQuest("Urdug's Assault", EncounterSet.TheFateOfWilderland, 1, 'A', Card.VALUE_NA)
                .WithTextLine("Setup: Add The Goblins' ~Assault, The Heroes' ~Defense, and Urdug to the staging area. Shuffle the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players in the game. Add those enemies to the staging area.")
                .WithFlavorLine("Dagnir is dead. In a move long-planned, Urdug has returned with an army of Goblins to lay claim to Gundabad and the Dragon's Wealth.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 progress on The Goblins' ~Assault for each enemy in the staging area. Then, if there is X or more progress on The Goblins' ~Assault, advance. X is equal to 2, plus 2 per player.")
                .WithOppositeFlavorLine("Goblins swarm up the mountain slopes and you fight to keep them back.")
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.GatheringGloom, EncounterSet.HillsOfWilderland)
                .WithInfo(168, 1, Artist.Ivan_Dixon);
            addQuest("Outflanked", EncounterSet.TheFateOfWilderland, 2, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is number of players in the game. Add those enemies to the staging area.")
                .WithFlavorLine("A new force of Goblins has scaled the cliff above the gate and attacks you from the rear.")
                .WithOppositeTextLine("Forced: After an enemy attacks, place 1 progress on The Goblins' ~Assault.")
                .WithOppositeTextLine("Forced: At the end of the round, if there is X or more progress on The Goblins' ~Assault, advance. X is equal to 4, plus 4 per player.")
                .WithOppositeFlavorLine("Hammered now on two fronts, you struggle to hold the gate.")
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.GatheringGloom, EncounterSet.HillsOfWilderland)
                .WithInfo(169, 1, Artist.Tomasz_Jedruszek);
            addQuest("The Final Push", EncounterSet.TheFateOfWilderland, 3, 'A', Card.VALUE_NA)
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players in the game. Add those enemies to the staging area.")
                .WithFlavorLine("Urdug commits the last of his reserves to the attack. Weary as you are from fighting so long, you reel at this fresh assault.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 progress on the Goblins' ~Assault for each enemy in play. Then, if there is X or more progress on The Goblins' ~Assault, the players lose the game. X is equal to 8, plus 8 per player.")
                .WithOppositeFlavorLine("Your saga through Rhovanion has reached its final test. If you fail, the Goblins of Gundabad will reestablish themseleves as a threat to the North and all your achievements will be for naught. The fate of Wilderland is in your hands.")
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.GatheringGloom, EncounterSet.HillsOfWilderland)
                .WithInfo(170, 1, Artist.Monztre);
        }
    }
}
