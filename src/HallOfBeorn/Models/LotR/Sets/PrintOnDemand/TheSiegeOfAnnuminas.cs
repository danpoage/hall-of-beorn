using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class TheSiegeOfAnnuminas : CardSet
    {
        private const string setName = "The Siege of Annúminas";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TSoA";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "Fellowship";
            Number = 3007;

            addGenConSetup("Standard Game Mode", setName)
                .WithText("Setup: Arrange the quest cards into three separate quest decks: 1A-3A, 1C-3C, and 1E-3E. Remove the 1C-3C deck and 1E-3E deck from the game. Search the encounter deck for Annúminas, add it to the staging area, and set its city strength to 20. Flip this card over and place it next to the quest deck.")
                .WithFlavor("Elendil was the High King and dwelt in the North at Annúminas... -The Return of the King")
                .WithOppositeText("Forced: When the players advance to stage 2A (and before resolving its 'when revealed' effect), shuffle each set aside ~Dúnedain of Annúminas into the encounter deck. Then shuffle X copies of Host of Angmar into the encounter deck, where X is one less than the number of players in the game, to a minimum of 1.")
                .WithOppositeTextLine("If a player is eliminated from the game, deal 9 damage to Annúminas.")
                .WithOppositeFlavorLine("...chief among their foes was was the dread realm of Angmar and its sorcerer king.")
                .WithOppositeFlavorLine("-The Return of the King")
                .WithInfo(1, 1, Artist.Andreia_Ugrai);
            addGenConSetup("Epic Multiplayer Mode", setName)
                .WithText("Setup: Arrange the quest cards into three separate quest decks: 1A-3A, 1C-3C, and 1E-3E. Create three separate staging area, one for each quest. Give each stage its own encounter deck. Divide the players into 3 teams, one team for each stage. The team at stage 1A searches the encounter deck for Annúminas, adds it to the staging area and sets its city strength to 50. Each other team removes their copy of Annúminas from the game. Flip over all 3 Setup cards and place 1 next to each quest deck.")
                .WithOppositeText("Each stage 2 can only be defeated at the beginning of the round, and only if each other stage 2 is complete.")
                .WithOppositeTextLine("While the players are at stage 2, each stage gains: \"Forced: At the end of the round, each Host of Angmar in the staging area moves to the next staging area in descending alphabetical order. If it cannot move, discard it and deal 9 damage to Annúminas.\"")
                .WithOppositeTextLine("For example: At the end of the round, there is a Host of Angmar in the staging area at stage 2F. After the teams at stage 2B and 2D resolve their end-of-round effects, the Host of Angmar in the staging area at stage 2F moves to the staging area of 2D.")
                .WithOppositeTextLine("If the last player at a stage is eliminated, the enemy has broken through the city's defenses and all teams lose the game.")
                .WithOppositeFlavorLine("\"...in their latter days they defended the hills for a while against the evil that came out of Angmar.\"")
                .WithOppositeFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Joshua_Cairos);
            addQuest("Rebuild the Defenses", setName, 1, 'A', Card.VALUE_NA)
                .WithFlavor("An army from Angmar marches on the Dúnedain capital of Annúminas. You rush to prepare the defenses as best you can before the Orcs reach the city.")
                .WithText("Setup: Set Lieutenant of Angmar, Battering Ram, Enemy Camp, Siege Tunnel, each copy of Host Angmar, and each copy of Dúnedain of Annúminas aside, out of play. Each player searches the encounter deck for a different location and adds it to the staging area. One of those locations must be Gate of Annúminas. Shuffle the encounter deck.")
                .WithOppositeFlavorLine("Many hands hurry to reinforce the gate with heavy timbers and large stones while the enemy draws steadily nearer.")
                .WithOppositeTextLine("Forced: At the beginning of the round (before the resource phase), place 1 resource here. Then, if there are 4 resources here, advance to stage 2.")
                .WithOppositeTextLine("Response: At the end of the round, remove 10 progress from this stage to increase the city strength of Annúminas by 10.")
                .WithInfo(3, 1, Artist.Joshua_Cairos);
            addQuest("Defend the City", setName, 2, 'A', 50)
                .WithFlavor("You've prepared the defenses as best you could, but the enemy has broken through in several places. It's up to you to protect the people inside the city.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until their are X enemies are discarded. X is one less than the number of players at this stage, to a minimum of 1. Add each enemy discarded in this way to the staging area.")
                .WithOppositeTextLine("This stage gets -10 quest points for each Host of Angmar in a victory display.")
                .WithOppositeTextLine("Forced: After the players have committed characters to the quest, the highest Attack enemy in the staging area makes an attack against each player in turn order. If no attacks are made in this way, reveal the top card of the encounter deck.")
                .WithOppositeTextLine("Response: At the end of the round, choose a stage. Each player at that stage heals 1 damage from a character he controls.")
                .WithInfo(4, 1, Artist.Rafal_Hrynkiewicz);
            addQuest("Lead the Sortie", EncounterSet.TheSiegeOfAnnuminas.Name, 3, 'A', Card.VALUE_NA)
                .WithFlavor("You've held back the host of Angmar, but a dark figure appears to lead the final assault. With a terrifying cry, he orders a battering ram against the gate. The old timbers won't endure for long, so you rally your troops for a desperate counter-attack. It's victory or death!")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player adds Battering Ram and Lieutenant of Angmar to the staging area. Each player reveals an encounter card.")
                .WithOppositeTextLine("Progress cannot be placed here while Battering Ram is in play.")
                .WithOppositeTextLine("Response: At the end of the round, raise each player's threat by 1 and reveal an encounter card to choose a non-unique enemy worth no victory points at another stage. Discard the chosen enemy.")
                .WithOppositeTextLine("If the Lieutenant of Angmar is in a victory display at the end of the round, the players have routed the enemy and win the game.")
                .WithInfo(5, 1, Artist.Javier_Charro_Martinez);
            addQuest("Raise the Levee", EncounterSet.TheSiegeOfAnnuminas.Name, 1, 'C', Card.VALUE_NA)
                .WithFlavor("An army from Angmar marches on the Dúnedain city of Annúminas. You ring the alarm bells and hurry to gather what strength you can.")
                .WithTextLine("Setup: Set Lieutenant of Angmar, Battering Ram, Enemy Camp, Siege Tunnel, each copy of Host of Angmar, and each copy of Dúnedain of Annúminas aside, out of play. Shuffle the encounter deck. Each player discards cards from the top of the encounter deck until he discards an enemy or location. Add each enemy and location discarded in this way to the staging area.")
                .WithOppositeFlavor("You race along the shores of Lake Nenuial to gather the Dúnedain inside the walls. \"To arms!\" you shout. \"Everyone into the city! Angmar approaches!\"")
                .WithOppositeTextLine("Forced: At the beginning of the round (before the resource phase), place 1 resource here. Then, if there are 4 resources here, advance to stage 2.")
                .WithOppositeTextLine("Response: At the end of the round, remove 10 progress from this stage. Then, the first player at each stage takes control of a set aside Dúnedain of Annúminas.")
                .WithInfo(6, 1, Artist.Joshua_Cairos);
            addQuest("Guard the Gate", EncounterSet.TheSiegeOfAnnuminas.Name, 2, 'C', 50)
                .WithFlavor("You've gathered everyone you can into Annúminas but the host of Angmar is hot on your heels. Once you reach the city gate, you draw your weapons and turn to face the charging Orcs. They cannot be allowed to enter this way.")
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded. X is one less than the number of players in the game, to a minimum of 1. Add each enemy discarded this way to the staging area.")
                .WithOppositeTextLine("This stage gets -10 quest points for each Host of Angmar in a victory display.")
                .WithOppositeTextLine("Forced: Reveal 1 additional card during the quest phase.")
                .WithOppositeTextLine("Response: At the end of the round, choose a stage. Each player at that stage chooses a hero he controls and adds 1 resource to that hero's pool.")
                .WithInfo(7, 1, Artist.Joshua_Cairos);
            addQuest("Rescue the Captives", EncounterSet.TheSiegeOfAnnuminas.Name, 3, 'C', Card.VALUE_NA)
                .WithFlavor("You've driven back the Orcs, but they've captured some of your companions. You won't abandon your friends, so you follow them to the enemy camp.")
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player adds Enemy Camp to the staging area. Each other player reveals an encounter card. Each player at each stage chooses a hero he controls, discards all tokens and attachments from it, and places it facedown under the main quest at their stage.")
                .WithOppositeTextLine("Process cannot be placed here while Enemy Camp is in play.")
                .WithOppositeTextLine("Response: At the end of the round, raise each player's threat by 1 and reveal an encounter card to choose a non-unique enemy worth no victory points at another stage. Discard the chosen enemy.")
                .WithOppositeTextLine("If the Lieutenant of Angmar is in the victory display at the end of the round, the players have routed the enemy and won the game.")
                .WithInfo(8, 1, Artist.Rafal_Hrynkiewicz);
            addQuest("Delay the Enemy", EncounterSet.TheSiegeOfAnnuminas.Name, 1, 'E', Card.VALUE_NA)
                .WithFlavor("An army from Angmar marches on the Dúnedain city of Annúminas. Your friends need time to prepare the defense, so you ride out to meet the enemy.")
                .WithText("Setup: Set Lieutenant of Angmar, Battering Ram, Enemy Camp, Siege Tunnel, each copy of Host of Angmar, and each copy of Dúnedain of Annúminas aside, out of play. Each player searches the encounter deck for a different enemy and adds it to the staging area. One of these enemies must be Vanguard of Carn Dûm. Shuffle the encounter deck.")
                .WithOppositeFlavor("It's up to you to harry the Orcs and slow their approach to the city.")
                .WithOppositeText("Forced: At the beginning of the round (before the resource phase), place 1 resource here. Then, if there are 4 resources here, advance to stage 2.")
                .WithOppositeTextLine("Response: At the end of the round, remove 10 progress from this stage, then the players at each other stage reveal 1 fewer encounter card during their next quest phase (to a minimum of 0).")
                .WithInfo(9, 1, Artist.Javier_Charro_Martinez);
            addQuest("Man the Walls", EncounterSet.TheSiegeOfAnnuminas.Name, 2, 'E', 50)
                .WithFlavor("You've done all you can to slow the enemy, so you retreat inside Annúminas and man the walls. Grappling hooks and ladders are raised against the battlements and arrows whistle overhead as the host of Angmar attacks the city.")
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded. X is one less than the number of players in the game, to a minimum of 1. Add each enemy discarded this way to the staging area.")
                .WithOppositeText("This stage gets -10 quest points for each Host of Angmar in a victory display.")
                .WithOppositeTextLine("Forced: At the beginning of the round, add 1 set aside Host of Angmar (from any stage's set aside area) to this staging area.")
                .WithOppositeTextLine("Response: At the end of the round, choose a stage. Each player at that stage draws 1 card.")
                .WithInfo(10, 1, Artist.Andreia_Ugrai);
            addQuest("Stop the Attack", EncounterSet.TheSiegeOfAnnuminas.Name, 3, 'E', Card.VALUE_NA)
                .WithFlavorLine("You've driven the enemy from the battlements when you hear a commotion from below. Orcs have tunneled under the walls and atack you from the rear. You charge down the stairs to stem the tide of Orcs and block the tunnel entrance.")
                .WithTextLine("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player adds Siege Tunnel to the staging area. Each other player reveals an encounter card.")
                .WithOppositeText("Progress cannot be placed here while Siege Tunnel is in play.")
                .WithOppositeTextLine("Response: At the end of the round, raise each player's threat by 1 and reveal an encounter card to choose a non-unique enemy worth no victory points at another stage. Discard the chosen enemy.")
                .WithOppositeTextLine("If the Lieutenant of Angmar is in the victory display at the end of the round, the players have routed the enemy and won the game.")
                .WithInfo(11, 1, Artist.Marius_Bota);
            addObjective("Annúminas", EncounterSet.TheSiegeOfAnnuminas.Name)
                .WithUnique()
                .WithTraits("City.")
                .WithTextLine("Forced: At the end of the round, deal 1 damage to Annúminas for each enemy at each stage.")
                .WithTextLine("If the city strength of Annúminas reaches 0, the city is overrun by the forces of Angmar and all teams lose the game.")
                .WithInfo(12, 1, Artist.DinoDrawing);
            addEnemy("Lieutenant of Angmar", setName, 0, 4, 6, 4, 9)
                .WithUnique()
                .WithTraits("Angmar.", "Sorcerer.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Lieutenant of ~Angmar cannot take damage unless there is at least 10 progress on the main quest.")
                .WithTextLine("Forced: At the end of the round, Lieutenant of ~Angmar moves to the staging area with the lowest total Threat and makes an immediate attack against the first player.")
                .WithVictoryPoints(4)
                .WithInfo(13, 1, Artist.Sam_Lamont);
            addLocation("Battering Ram", setName, Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("Siege.")
                .WithTextLine("X is 1 more than the number of resources on Battering Ram. Immune to player card effects.")
                .WithTextLine("Forced: At the end of the round, place 1 resource on Battering Ram. Then, deal X damage to Annúminas.")
                .WithTextLine("Travel: Reveal 1 encounter card per player to travel here.")
                .WithVictoryPoints(5)
                .WithInfo(14, 1, Artist.Marius_Bota);
            addLocation("Enemy Camp", setName, 5, 5)
                .WithUnique()
                .WithTraits("Siege.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: At the end of the round, if Enemy Camp is in play, discard 1 random facedown hero from under each stage 3. If Enemy Camp is in the victory display, return each hero under each stage 3 to its owner's control instead.")
                .WithTextLine("Travel: Reveal 1 encounter card per player to travel here.")
                .WithVictoryPoints(5)
                .WithInfo(15, 1, Artist.DinoDrawing);
            addLocation("Siege Tunnel", setName, 5, 5)
                .WithUnique()
                .WithTraits("Siege.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: At the end of the round, each team discards from the top of their encounter deck until an enemy is discarded and adds that enemy to their staging area.")
                .WithTextLine("Travel: Reveal 1 encounter card per player to travel here.")
                .WithVictoryPoints(5)
                .WithInfo(16, 1, Artist.DinoDrawing);
            addEnemy("Host of Angmar", setName, 50, 4, 9, 4, 12)
                .WithTraits("Orc.")
                .WithKeywords("Archery 2.")
                .WithTextLine("Archery 2.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: After Host of Angmar attacks and destroys a character, either remove 2 progress from the main quest, or return Host of Angmar to the staging area.")
                .WithVictoryPoints(4)
                .WithInfo(17, 3, Artist.Marius_Bota);
            addObjectiveAlly("Dúnedain of Annúminas", setName, 1, 2, 2, 3)
                .WithTraits("Dúnedain.")
                .WithKeywords("Surge.", "Ranged.", "Sentinel.")
                .WithTextLine("Surge. Ranged. Sentinel.")
                .WithTextLine("When Revealed: Any player may spend 1 resource to take control of Dúnedain of Annúminas. Otherwise, discard it.")
                .WithShadow("Ready the defending character and give it +2 Defense for this attack.")
                .WithInfo(18, 3, Artist.Andreia_Ugrai);
            addLocation("Gate of Annúminas", setName, Card.VALUE_X, 5)
                .WithTraits("Arnor.", "City.")
                .WithTextLine("X is 1 more than the number of enemies in play.")
                .WithTextLine("Travel: Each player engages an enemy in the staging area to travel here.")
                .WithFlavorLine("\"...the Men of Westernesse were diminished, and their city of of Annúminas beside lake Evendim fell into ruin...\"")
                .WithFlavorLine("-Elrond, The Fellowship of the Ring")
                .WithInfo(19, 2, Artist.DinoDrawing);
            addLocation("City Wall", setName, 3, 4)
                .WithTraits("Arnor.", "City.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: At the end of the round, place 1 resource on City Wall. Then, if there are 3 resources here, discard City Wall to deal 4 damage to Annúminas and reveal an encounter card.")
                .WithTextLine("Travel: Reveal the top card of the encounter deck to travel here.")
                .WithInfo(20, 3, Artist.DinoDrawing);
            addLocation("Arnor Battlefield", setName, 3, 3)
                .WithTraits("Arnor.")
                .WithTextLine("While Arnor Battlefield is in the staging area, each non-unique enemy gets -5 engagement cost.")
                .WithTextLine("Travel: Each player deals 1 damage to a hero he controls to travel here.")
                .WithFlavorLine("A smoke as of fire and battle arose, and again the sun went down in a burning red that faded into a grey mist...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(21, 3, Artist.Stanislav_Dikolenko);
            addLocation("Hills of Evendim", setName, 4, 4)
                .WithTraits("Arnor.")
                .WithTextLine("While Hills of Evendim is in the staging area, 'when revealed' effects cannot be canceled.")
                .WithTextLine("Travel: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until an enemy is discarded. Add the discarded enemy to the staging area to travel here.")
                .WithInfo(22, 2, Artist.DinoDrawing);
            addLocation("Shores of Lake Nenuial", setName, 2, 6)
                .WithTraits("Arnor.")
                .WithTextLine("While Shores of Lake Nenuial is in the staging area, progress cannot be placed on other locations in the staging area.")
                .WithTextLine("Travel: Raise each player's threat by 2 to travel here.")
                .WithFlavorLine("\"...that is so long ago that the hills have forgotten them, though a shadow still lies on the land.\"")
                .WithFlavorLine("-Aragorn, The Fellowship of the Ring")
                .WithInfo(23, 2, Artist.DinoDrawing);
            addEnemy("Warg of Carn Dûm", setName, 20, 1, 2, 1, 2)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: After Warg of Carn Dûm engages you, either remove 1 progress from the main quest, or exhaust a character you control.")
                .WithFlavorLine("Up from the dark plain below came the crying of fell voices, and the howling of many wolves")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(24, 3, Artist.Stanislav_Dikolenko);
            addEnemy("Orc of Angmar", setName, 30, 2, 4, 2, 3)
                .WithTraits("Orc.")
                .WithKeywords("Archery 1.")
                .WithTextLine("Archery 1.")
                .WithTextLine("Forced: When Orc of Angmar attacks, either remove 1 progress from the main quest, or it gets +2 Defense until the end of the phase.")
                .WithShadow("Shadow: Defender gets -2 Defense until end of round.")
                .WithInfo(25, 3, Artist.Marius_Bota);
            addEnemy("Angmar Warg-rider", setName, 35, 2, 3, 2, 4)
                .WithTraits("Orc.")
                .WithKeywords("Archery 1.")
                .WithTextLine("Archery 1.")
                .WithTextLine("Forced: After Angmar Warg-rider engages you, either remove 2 progress from the main quest, or it makes an immediate attack.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(26, 3, Artist.Stanislav_Dikolenko);
            addEnemy("Savage Werewolf", setName, 40, 3, 5, 2, 5)
                .WithTraits("Creature.")
                .WithTextLine("Forced: After Savage Werewolf attacks and destroys a character, remove 3 progress from the main quest.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(27, 2, Artist.Stanislav_Dikolenko);
            addEnemy("Vanguard of Carn Dûm", setName, 45, 3, 6, 3, 8)
                .WithTraits("Orc.")
                .WithTextLine("Cannot have attachments.")
                .WithTextLine("While Vanguard of Carn Dûm is in the staging area, no more than 5 progress can be placed on the main quest each round.")
                .WithShadow("Shadow: Defender cannot ready this round.")
                .WithInfo(28, 2, Artist.Marius_Bota);
            addTreachery("The Hordes of Angmar", setName)
                .WithTextLine("When Revealed: Each player must choose: either return the highest Threat enemy engaged with you to the staging area, or search the encounter deck and discard pile for an enemy and put it into play engaged with you.")
                .WithShadow("Shadow: If this attack destroys a character, reveal the top card of the encounter deck.")
                .WithInfo(29, 2, Artist.Stanislav_Dikolenko);
            addTreachery("Sorcery of Carn Dûm", setName)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("When Revealed: Each player must choose: either discard the highest cost attachment you control, or assign X damage among characters you control, where X is the number of attachments you control.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(30, 2, Artist.Sam_Lamont);
            addTreachery("Caught in the Press", setName)
                .WithTextLine("Each player must choose: either deal 1 damage to each questing character you control, or each questing character you control gets -1 Willpower until the end of the phase.")
                .WithShadow("Shadow: Either remove 2 progress from the main quest, or return attacking enemy to the staging area after this attack.")
                .WithInfo(31, 3, Artist.Rafal_Hrynkiewicz);
            addTreachery("Weary Warriors", setName)
                .WithTextLine("When Revealed: Each player deals 1 damage to a hero he controls. If that hero is questing, remove it from the quest. Until the end of the round, treat each damaged character's text box as if it were blank (except for Traits).")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defender is damaged).")
                .WithInfo(32, 3, Artist.Andreia_Ugrai);
            addHero("Boromir", 11, Sphere.Tactics,  1, 3, 2, 5)
                .WithTraits("Gondor.", "Noble.", "Warrior.")
                .WithTextLine("Action: Raise your threat by 1 to ready Boromir.")
                .WithTextLine("Action: Discard Boromir to deal 2 damage to each enemy engaged with a single player.")
                .WithTemplate("<p class='main-text'><b>Action:</b> Raise your threat by 1 to ready {self}.</p><p class='main-text'><b>Action:</b> Discard {self} to deal 2 damage to each enemy engaged with a single player.</p>")
                .WithPromotion()
                .WithInfo(95, 1, Artist.Aurore_Folny);
            addHero("Faramir", 11, Sphere.Leadership, 2, 2, 2, 5)
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithTextLine("Ranged.")
                .WithTextLine("Response: After you engage an enemy, ready an ally you control. (Limit once per phase.)")
                .WithTemplate("<p class='main-text'>{keyword:Ranged.} <b>Response:</b> After you engage an enemy, ready an ally you control. (Limit once per phase.)</p>")
                .WithPromotion()
                .WithInfo(2, 1, Artist.Aurore_Folny);
        }
    }
}
