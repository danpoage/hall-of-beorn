using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheSiegeOfAnnuminas : CardSet
    {
        private const string setName = "The Siege of Annúminas";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TSoA";
            SetType = Models.SetType.Fellowship_Deck;
            Cycle = "GenCon";
            Number = 3007;

            Cards.Add(Card.GenConSetup("Standard Game Mode", setName)
                .WithText("Setup: Arrange the quest cards into three separate quest decks: 1A-3A, 1C-3C, and 1E-3E. Remove the 1C-3C deck and 1E-3E deck from the game. Search the encounter deck for Annúminas, add it to the staging area, and set its city strength to 20. Flip this card over and place it next to the quest deck.")
                .WithFlavor("Elendil was the High King and dwelt in the North at Annúminas... -The Return of the King")
                .WithOppositeText("Forced: When the players advance to stage 2A (and before resolving its 'when revealed' effect), shuffle each set aside ~Dúnedain of Annúminas into the encounter deck. Then shuffle X copies of Host of Angmar into the encounter deck, where X is one less than the number of players in the game, to a minimum of 1.\r\nIf a player is eliminated from the game, deal 9 damage to Annúminas.")
                .WithOppositeFlavor("...chief among their foes was was the dread realm of Angmar and its sorcerer king. -The Return of the King")
                .WithInfo(1, 1, Artist.Andreia_Ugrai));
            Cards.Add(Card.GenConSetup("Epic Multiplayer Mode", setName)
                .WithText("Setup: Arrange the quest cards into three separate quest decks: 1A-3A, 1C-3C, and 1E-3E. Create three separate staging area, one for each quest. Give each stage its own encounter deck. Divide the players into 3 teams, one team for each stage. The team at stage 1A searches the encounter deck for Annúminas, adds it to the staging area and sets its city strength to 50. Each other team removes their copy of Annúminas from the game. Flip over all 3 Setup cards and place 1 next to each quest deck.")
                .WithOppositeText("Each stage 2 can only be defeated at the beginning of the round, and only if each other stage 2 is complete.\r\nWhile the players are at stage 2, each stage gains: \"Forced: At the end of the round, each Host of Angmar in the staging area moves to the next staging area in descending alphabetical order. If it cannot move, discard it and deal 9 damage to Annúminas.\"\r\nFor example: At the end of the round, there is a Host of Angmar in the staging area at stage 2F. After the teams at stage 2B and 2D resolve their end-of-round effects, the Host of Angmar in the staging area at stage 2F moves to the staging area of 2D.\r\nIf the last player at a stage is eliminated, the enemy has broken through the city's defenses and all teams lose the game.")
                .WithOppositeFlavor("\"...in their latter days they defended the hills for a while against the evil that came out of Angmar.\"\r\n-Aragorn, The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Joshua_Cairos));
            Cards.Add(Card.Quest("Rebuild the Defenses", string.Empty, 7, 1, setName, null)
                .WithFlavor("An army from Angmar marches on the Dúnedain capital of Annúminas. You rush to prepare the defenses as best you can before the Orcs reach the city.")
                .WithText("Setup: Set Lieutenant of Angmar, Battering Ram, Enemy Camp, Siege Tunnel, each copy of Host Angmar, and each copy of Dúnedain of Annúminas aside, out of play. Each player searches the encounter deck for a different location and adds it to the staging area. One of those locations must be Gate of Annúminas. Shuffle the encounter deck.")
                .WithOppositeFlavor("Many hands hurry to reinforce the gate with heavy timbers and large stones while the enemy draws steadily nearer.")
                .WithOppositeText("Forced: At the beginning of the round (before the resource phase), place 1 resource here. Then, if there are 4 resources here, advance to stage 2.\r\nResponse: At the end of the round, remove 10 progress from this stage to increase the city strength of Annúminas by 10.")
                .WithInfo(3, 1, Artist.Joshua_Cairos));
            Cards.Add(Card.Quest("Defend the City", string.Empty, 7, 2, setName, 50)
                .WithFlavor("You've prepared the defenses as best you could, but the enemy has broken through in several places. It's up to you to protect the people inside the city.")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck and discard cards from the top until their are X enemies are discarded. X is one less than the number of players at this stage, to a minimum of 1. Add each enemy discarded in this way to the staging area.")
                .WithOppositeText("This stage gets -10 quest points for each Host of Angmar in a victory display.\r\nForced: After the players have committed characters to the quest, the highest Attack enemy in the staging area makes an attack against each player in turn order. If no attacks are made in this way, reveal the top card of the encounter deck.\r\nResponse: At the end of the round, choose a stage. Each player at that stage heals 1 damage from a character he controls.")
                .WithInfo(4, 1, Artist.Rafal_Hrynkiewicz));
            Cards.Add(Card.Quest("Lead the Sortie", string.Empty, 7, 3, setName, null)
                .WithFlavor("You've held back the host of Angmar, but a dark figure appears to lead the final assault. With a terrifying cry, he orders a battering ram against the gate. The old timbers won't endure for long, so you rally your troops for a desperate counter-attack. It's victory or death!")
                .WithText("When Revealed: Shuffle the encounter discard pile into the encounter deck. The first player adds Battering Ram and Lieutenant of Angmar to the staging area. Each player reveals an encounter card.")
                .WithOppositeText("Progress cannot be placed here while Battering Ram is in play.\r\nResponse: At the end of the round, raise each player's threat by 1 and reveal an encounter card to choose a non-unique enemy worth no victory points at another stage. Discard the chosen enemy.\r\nIf the Lieutenant of Angmar is in a victory display at the end of the round, the players have routed the enemy and win the game.")
                .WithInfo(5, 1, Artist.Javier_Charro_Martinez));
            Cards.Add(Card.Quest("Raise the Levee", string.Empty, 7, 1, setName, null)
                .WithStageLetter('C')
                .WithFlavor("An army from Angmar marches on the Dúnedain city of Annúminas. You ring the alarm bells and hurry to gather what strength you can.")
                .WithText("Setup: Set Lieutenant of Angmar, Battering Ram, Enemy Camp, Siege Tunnel, each copy of Host of Angmar, and each copy of Dúnedain of Annúminas aside, out of play. Shuffle the encounter deck. Each player discards cards from the top of the encounter deck until he discards an enemy or location. Add each enemy and location discarded in this way to the staging area.")
                .WithOppositeFlavor("You race along the shores of Lake Nenuial to gather the Dúnedain inside the walls. \"To arms!\" you shout. \"Everyone into the city! Angmar approaches!\"")
                .WithOppositeText("Forced: At the beginning of the round (before the resource phase), place 1 resource here. Then, if there are 4 resources here, advance to stage 2.\r\nResponse: At the end of the round, remove 10 progress from this stage. Then, the first player at each stage takes control of a set aside Dúnedain of Annúminas.")
                .WithInfo(6, 1, Artist.Joshua_Cairos));

            Cards.Add(Card.Hero("Boromir", "", Sphere.Tactics, 11, 1, 3, 2, 5)
                .WithTraits("Gondor.", "Noble.", "Warrior.")
                .WithText("Action: Raise your threat by 1 to ready Boromir.\r\nAction: Discard Boromir to deal 2 damage to each enemy engaged with a single player.")
                .WithInfo(95, 1, Artist.Aurore_Folay));
        }
    }
}