using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class TheFateOfWilderlandSet : CardSet
    {
        private const string setName = "The Fate of Wilderland";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoW";
            Number = 55;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            addHero("Radagast", 11, Sphere.Lore, 2, 2, 3, 4)
                .WithTraits("Istari.")
                .WithText("You may use resources from Radagast's pool to pay for Creature allies of any sphere.\r\nResponse: After you play a Creature card, Radagast does not exhaust to quest this round.")
                .WithFlavor("\"..he has much lore of herbs and beasts, and birds are especially his friends.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(145, 1, Artist.Aleksander_Karcz);
            addAlly("Messenger Raven", 1, Sphere.Leadership, false, 1, 0, 0, 1)
                .WithTraits("Creature.")
                .WithText("Cannot attack, defend, of have attachments.\r\nRefresh Action: Return Messenger ~Raven to it's owner's hand and name a card type. Choose a player to look at the top card of his deck. If that card is the named type, add it to its owner's hand. If it is not, discard it.")
                .WithInfo(146, 3, Artist.Derek_D_Edgell);
            addEvent("The King's Return", 1, Sphere.Leadership)
                .WithTraits("Song.")
                .WithText("Action: Search your deck for a Guarded attachment and put it into play. Shuffle your deck.")
                .WithFlavor("His crown shall be upholden,\r\nHis harp shall be restrung,\r\nHis halls shall echo golden\r\nTo songs of yore re-sung\r\n-The Hobbit")
                .WithInfo(147, 3, Artist.Tyler_Edlin);
            addAlly("Loyal Hound", 2, Sphere.Lore, false, 1, 2, 0, 2)
                .WithTraits("Creature.")
                .WithText("Cannot have attachments.\r\nResponse: Discard Loyal ~Hound to cancel up to 2 damage just dealt to a hero you control.")
                .WithInfo(148, 3, Artist.Alvaro_Calvo_Escudero);
            addEvent("The Great Hunt", 3, Sphere.Lore)
                .WithText("You must use resources from 3 different heroes' pools to pay for this card.\r\nCombat Action: Choose and discard a non-unique enemy in the staging area.")
                .WithFlavor("...it seemed they could hear the noise of a great hunt going by to the north of the path...\r\n-The Hobbit")
                .WithInfo(149, 3, Artist.Carlos_Palma_Cruchaga);
            addAlly("Bywater Shirriff", 2, Sphere.Tactics, false, 1, 1, 1, 2)
                .WithTraits("Hobbit.", "Shirriff.")
                .WithText("Bywater ~Shirriff gets +1 Willpower, +1 Attack, and +1 Defense while you are engaged with an enemy with engagement cost higher than your threat.")
                .WithFlavor("The Shirriffs was the name that the Hobbits gave to their police, or the nearest equivalent that they possessed.\r\n-The Hobbit")
                .WithInfo(150, 3, Artist.Romana_Kendelic);
            addEvent("Gwaihir's Debt", 1, Sphere.Tactics)
                .WithText("Play only if you control a unique character with the Istari trait and another unique character with the Eagle trait.\r\nAction: ~Search the top 5 cards of your deck for an Eagle or Istari ally and put it into play. Shuffle your deck. At the end of the round, if that ally is still in play, return it to your hand.")
                .WithInfo(151, 3, Artist.Justin_Gerard);
            addAttachment("Mithril Shirt", 1, Sphere.Spirit, true)
                .WithTraits("Artifact.", "Item.", "Armor.")
                .WithKeywords("Guarded (location).")
                .WithText("Guarded (location).\r\nAttach to a hero.\r\nResponse: When attached hero is dealt any amount of damage, reduce that damage by 1.")
                .WithFlavor("It was of silver-steel which the Elves call mithril, and with it went a belt of pearls and crystals.\r\n-The Hobbit")
                .WithTemplate("<p class='main-text'>{keyword:Guarded (location).}</p><p class='main-text;'>Attach to a hero.</p><p class='main-text'><b>Response:</b> When attached hero is dealt any amount of damage, reduce that damage by 1.</p><p class='flavor-text'>It was of silver-steel which the Elves call mithril, and with it went a belt of pearls and crystals. &ndash;The Hobbit</p>")
                .WithInfo(152, 3, Artist.Sebastian_Zakrzewski);
            addEvent("Reforged", Card.VALUE_X, Sphere.Spirit)
                .WithText("Action: Choose an attachment with a printed cost of X in any player's discard pile and play that attachment for no cost. (The chosen attachment can belong to any sphere of influence.)")
                .WithFlavor("The Sword of Elendil was forged anew by Elvish smiths... -The Fellowship of the Ring")
                .WithInfo(153, 3, Artist.Sebastian_Zakrzewski);
            addAttachment("Radagast's Staff", 2, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithText("Attach to Radagast.\r\nAction: Exhaust Radagast's ~Staff to choose one: Reduce the cost of the next Creature ally you play this phase by 2, ready a Creature ally, or return a non-unique Creature enemy engaged with you to the staging area.")
                .WithInfo(154, 3, Artist.Sebastian_Zakrzewski);
            addObjective("The Goblins' Assault", setName)
                .WithTraits("Assault.")
                .WithText("Urdug gets +2 Defense for each other enemy in play and cannot be dealt damage unless he had resolved an attack this phase.\r\nForced: After players quest unsuccessfully, place 1 progress here for each player in the game.")
                .WithInfo(155, 1, Artist.Rafal_Hrynkiewicz);
            addObjective("The Heroes' Defense", setName)
                .WithTraits("Defense.")
                .WithText("While there are X or more resources on The Heroes' ~Defense, Urdug is considered to be engaged with each player, X is five times the number of players.\r\nResponse: After an enemy is destroyed, place 1 resource here.")
                .WithInfo(156, 1, Artist.Jason_Jenicke);
            addEnemy("Urdug", setName, 50, 2, 3, 2, 5)
                .WithUnique()
                .WithTraits("Orc.", "Goblin.")
                .WithText("Immune to player card effects. Cannot leave the staging area.\r\nForced: When Urdug attacks, discard the top card of the encounter deck. He gets +X Attack for this attack, where X is the discarded card's printed Threat.\r\nWhen Urdug is destroyed, the players win the game.")
                .WithVictoryPoints(5)
                .WithInfo(157, 1, Artist.Ivan_Dixon);
            addEnemy("Urdug's Elite", setName, 25, 2, 3, 2, 5)
                .WithTraits("Orc.", "Goblin.")
                .WithText("Forced: After Urdug's Elite engages you, either exhaust a character you control, or place 1 progress on The Goblins' ~Assault.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(158, 3, Artist.Monztre);
            addEnemy("Fierce Vanguard", setName, 20, 2, 2, 2, 3)
                .WithTraits("Orc.", "Goblin.")
                .WithText("Forced: After Fierce Vanguard engages you, either it gets +2 Attack until the end of the round, or place 1 progress on the The Goblins' ~Assault.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack and +2 Defense until the end of the phase.")
                .WithEasyModeQuantity(2)
                .WithInfo(159, 3, Artist.John_Gravato);
            addEnemy("Warg-rider", setName, 30, 3, 4, 1, 4)
                .WithTraits("Orc.", "Goblin.")
                .WithText("Forced: After Warg-rider is dealt a shadow card with no effect, either return it to the staging area or place 1 progress on The Goblins' ~Assault.")
                .WithInfo(160, 2, Artist.Guillaume_Ducos);
            addLocation("Gate of Gundabad", setName, 4, 4)
                .WithUnique()
                .WithTraits("Mountain.", "Gate.")
                .WithText("Immune to player card effects.\r\nWhile Gate of Gundabad is in the staging area, resources cannot be placed on The Heroes' ~Defense.\r\nTravel: Search the encounter deck, discard pile, and victory display for a Goblin Troop and add it to the staging area. Shuffle the encounter deck.")
                .WithVictoryPoints(1)
                .WithInfo(161, 1, Artist.Leanna_Crossan);
            addLocation("Hilltop Battlements", setName, 3, 3)
                .WithTraits("Mountain.", "Fortification.")
                .WithText("While Hilltop Battlements is in the staging area, each non-unique enemy gets -5 engagement cost.\r\nForced: When Hilltop Battlements is explored, discard the top X cards of the encounter deck, where X is the number of players in the game. Add each enemy discarded by this effect to the staging area.")
                .WithInfo(162, 3, Artist.Andreas_Adamek);
            addLocation("Dwarven Watchtower", setName, 2, 5)
                .WithTraits("Mountain.", "Fortification.")
                .WithText("While Dwarven Watchtower is the active location, each hero gets +1 Defense.\r\nResponse: After Dwarven Watchtower is explored, the first player chooses: either place 1 resource on The Heroes' ~Defense, or remove 1 progress from The Goblins' ~Assault.")
                .WithVictoryPoints(2)
                .WithInfo(163, 3, Artist.Greg_Bobrowski);
            addLocation("Slopes of Gundabad", setName, 2, 4)
                .WithTraits("Mountain.")
                .WithText("When Revealed: Either place 1 progress on The Goblins' ~Assault, or reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy cannot take damage this phase.")
                .WithEasyModeQuantity(1)
                .WithInfo(164, 3, Artist.Leanna_Crossan);
            addTreachery("Fierce Attack", setName)
                .WithKeywords("Doomed 1.")
                .WithText("Doomed 1.\r\nWhen Revealed: Place X progress on The Goblins' ~Assault, where X is in the stage number of the main quest.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the stage number of the current quest.")
                .WithEasyModeQuantity(2)
                .WithInfo(165, 3, Artist.Jason_Jenicke);
            addTreachery("Urdug's Command", setName)
                .WithText("When Revealed: Urdug makes an immediate attack against the first player. If this attack destroys a character, place 1 progress on The Goblins' ~Assault.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place 1 progress on The Goblins' ~Assault.")
                .WithEasyModeQuantity(2)
                .WithInfo(166, 3, Artist.Ivan_Dixon);
            addTreachery("Dark Clouds", setName)
                .WithText("When Revealed: Each enemy and each location in the staging area gets +1 Threat until the end of the phase. If the players quest unsuccessfully this phase, place 1 progress on The Goblins' ~Assault.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(167, 2, Artist.Alyn_Spiller);
            addQuest("Urdug's Assault", setName, 1, 'A', Card.VALUE_NA)
                .WithFlavor("Dagnir is dead. In a move long-planned, Urdug has returned with an army of Goblins to lay claim to Gundabad and the Dragon's Wealth.")
                .WithText("Setup: Add The Goblins' ~Assault, The Heroes' ~Defense, and Urdug to the staging area. Shuffle the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players in the game. Add those enemies to the staging area.")
                .WithOppositeFlavor("Goblins swarm up the mountain slopes and you fight to keep them back.")
                .WithOppositeText("Forced: At the end of the round, place 1 progress on The Goblins' ~Assault for each enemy in the staging area. Then, if there is X or more progress on The Goblins' ~Assault, advance. X is equal to 2, plus 2 per player.")
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.GatheringGloom, EncounterSet.HillsOfWilderland)
                .WithInfo(168, 1, Artist.Ivan_Dixon);
            addQuest("Outflanked", setName, 2, 'A', Card.VALUE_NA)
                .WithFlavor("A new force of Goblins has scaled the cliff above the gate and attacks you from the rear.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is number of players in the game. Add those enemies to the staging area.")
                .WithOppositeFlavor("Hammered now on two fronts, you struggle to hold the gate.")
                .WithOppositeText("Forced: After an enemy attacks, place 1 progress on The Goblins' ~Assault.\r\nForced: At the end of the round, if there is X or more progress on The Goblins' ~Assault, advance. X is equal to 4, plus 4 per player.")
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.GatheringGloom, EncounterSet.HillsOfWilderland)
                .WithInfo(169, 1, Artist.Tomasz_Jedruszek);
            addQuest("The Final Push", setName, 3, 'A', Card.VALUE_NA)
                .WithFlavor("Urdug commits the last of his reserves to the attack. Weary as you are from fighting so long, you reel at this fresh assault.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players in the game. Add those enemies to the staging area.")
                .WithOppositeFlavor("Your saga through Rhovanion has reached its final test. If you fail, the Goblins of Gundabad will reestablish themseleves as a threat to the North and all your achievements will be for naught. The fate of Wilderland is in your hands.")
                .WithOppositeText("Forced: At the end of the round, place 1 progress on the Goblins' ~Assault for each enemy in play. Then, if there is X or more progress on The Goblins' ~Assault, the players lose the game. X is equal to 8, plus 8 per player.")
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.GatheringGloom, EncounterSet.HillsOfWilderland)
                .WithInfo(170, 1, Artist.Monztre);
        }
    }
}