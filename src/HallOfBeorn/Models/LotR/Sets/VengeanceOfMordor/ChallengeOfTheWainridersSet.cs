using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.VengeanceOfMordor
{
    public class ChallengeOfTheWainridersSet 
        : CardSet
    {
        public const string setName = "Challenge of the Wainriders";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "CotW";
            Number = 59;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Vengeance of Mordor";

            addHero("Saruman", 13, Sphere.Lore, 3, 4, 2, 4)
                .WithTraits("Istari.", "Isengard.")
                .WithTextLine("When a player card effect would reduce your threat by any amount, reduce that amount to 1.")
                .WithTextLine("While playing an event with the printed doomed keyword, Saruman gains the printed Leadership, Spirit, and Tactics icons.")
                .WithTextLine("Response: After you play a card with the doomed keyword, ready Saruman.")
                .WithInfo(54, 1, Artist.Martin_de_Diego_Sadaba);
            addAttachment("Power of Command", 1, Sphere.Leadership, false)
                .WithTraits("Master.")
                .WithTextLine("Attach to the hero with The One Ring.")
                .WithTextLine("Limit 1 per hero. Attached hero gets +1 Willpower.")
                .WithTextLine("Response: After attached hero commits to the quest, exhaust The One Ring and raise your threat by 1 to give each other unique character you control +1 Willpower until the end of the phase.")
                .WithInfo(55, 3, Artist.Borja_Pindado);
            addEvent("Horns! Horns! Horns!", 0, Sphere.Leadership)
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("Action: Each player may put one ally card into play from his hand. At the end of the phase, shuffle each of those allies that are still in play into their owners' decks.")
                .WithInfo(56, 3, Artist.Federico_Musetti);
            addAlly("Soldier of Isengard", 2, Sphere.Lore, false, 2, 2, 2, 2)
                .WithTraits("Isengard.")
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("Response: After a player raises his threat from the doomed keyword, give control of Soldier of ~Isengard to that player.")
                .WithInfo(57, 3, Artist.Stanislav_Dikolenko);
            addEvent("Far-sighted", 0, Sphere.Lore)
                .WithKeywords("Doomed 1.")
                .WithTextLine("Doomed 1.")
                .WithTextLine("Action: Look at the top 5 cards of the encounter deck. Put them back in the same order.")
                .WithFlavorLine("...Legolas was standing, gazing northwards into the darkness, thoughtful and silent as a young tree in a windless night.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(58, 3, Artist.Vilius_Petrauskas);
            addAlly("Nori", 3, Sphere.Tactics, true, 1, 2, 1, 2)
                .WithTraits("Dwarf.")
                .WithTextLine("Response: After Nori participates in an attack that destroys an enemy, put the top card of your discard pile on the bottom of your deck.")
                .WithFlavorLine("\"You've left the burglar behind again!\"")
                .WithFlavorLine("-Nori, The Hobbit")
                .WithCommunityVersion("RiddermarkLord/Nori-MotK-Tactics-Hero")
                .WithInfo(59, 3, Artist.David_Keen);
            addAttachment("Golden Belt", 0, Sphere.Tactics, false)
                .WithTraits("Item.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Attached hero can have 1 additional restricted attachment.")
                .WithFlavorLine("The lady bowed her head, and she turned to Boromir and to him she gave a belt of gold...")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(60, 3, Artist.Nino_Vecia);
            addAlly("Rohirrim Scout", 2, Sphere.Spirit, false, 1, 1, 0, 2)
                .WithTraits("Rohan.", "Scout.")
                .WithTextLine("Action: Discard Rohirrim Scout to choose a non-unique enemy in the staging area. That enemy does not make engagement checks against you this round.")
                .WithFlavorLine("Swiftly a scout rode back and reported that wolf-riders were abroad in the valley...")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(61, 3, Artist.Federico_Musetti);
            addEvent("The Muster of Rohan", 4, Sphere.Spirit)
                .WithTextLine("While paying for The Muster of ~Rohan, each Rohan hero you control is considered to have a Spirit icon.")
                .WithTextLine("Planning Action: ~Search the top 10 cards of your deck for up to 4 Rohan allies and put them into play. Shuffle your deck. If any of those allies are still in play at the end of the round, discard them.")
                .WithInfo(62, 3, Artist.Vilius_Petrauskas);
            addAttachment("Saruman's Staff", 2, Sphere.Neutral, true)
                .WithTraits("Artifact.", "Item.", "Staff.")
                .WithKeywords("Restricted.")
                .WithTextLine("Attach to Saruman. Restricted.")
                .WithTextLine("Action: Exhaust Saruman's Staff to (choose 1): Reduce the X value of the next Doomed X event you play this phase by 2, or search the top 5 cards of your deck for a Doomed event and add it to your hand. Shuffle your deck.)")
                .WithFlavorLine("His hand clutched his heavy black staff like a claw.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(63, 3, Artist.Nikolas_Hagialas);
            addObjective("The Wainriders", EncounterSet.ChallengeOfTheWainriders)
                .WithTextLine("If The Wainriders' stage has damage on it equal to or greater than its quest points, The Wainriders advances to the next stage in the circuit. Place any excess damage on that stage.")
                .WithTextLine("Forced: At the end of the quest phase, place X damage on The Wainriders' stage, where X is the total Threat of each enemy in the staging area.")
                .WithInfo(64, 1, Artist.Piotr_Arendzikowski);
            addObjective("The Challengers", EncounterSet.ChallengeOfTheWainriders)
                .WithTextLine("Forced: When the players defeat a quest stage with the race keyword, advance this card to the next quest stage in the circuit.")
                .WithTextLine("If The Challengers completes two circuits before the Wainriders, the players win the game. If The Wainriders completes two circuits before the challenges, the players lose the game.")
                .WithInfo(65, 1, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Wainrider Champion", EncounterSet.ChallengeOfTheWainriders, 50, Card.VALUE_X, 4, Card.VALUE_X, 5)
                .WithUnique()
                .WithTraits("Easterling.")
                .WithKeywords("Indestructible.")
                .WithTextLine("X is 2 per player. Indestructible.")
                .WithTextLine("Immune to player card effects. Cannot leave the staging area.")
                .WithTextLine("While The Challengers is at the same stage as The Wainriders, Wainrider Champion is considered to be engaged with each player.")
                .WithVictoryPoints(4)
                .WithInfo(66, 1, Artist.Ryan_Valle);
            addEnemy("Aggressive Racer", EncounterSet.ChallengeOfTheWainriders, 28, 1, 4, 2, 3)
                .WithTraits("Easterling.")
                .WithKeywords("Archery 1.")
                .WithTextLine("Archery 1.")
                .WithTextLine("While The Challengers is ahead of the The Wainriders, Aggressive Racer gains surge.")
                .WithTextLine("Forced: After Aggressive Racer attacks and destroys a character, place 2 damage on The Wainriders' stage.")
                .WithEasyModeQuantity(3)
                .WithTurn()
                .WithInfo(67, 4, Artist.Federico_Musetti);
            addEnemy("Chariot Driver", EncounterSet.ChallengeOfTheWainriders, 38, 3, 5, 1, 6)
                .WithTraits("Easterling.")
                .WithTextLine("When Revealed: Either place 3 damage on The Wainriders' stage, or Chariot Driver makes an attack against the first player.")
                .WithShadow("Shadow: If this attack destroys a character, return attacking enemy to the the staging area.")
                .WithEasyModeQuantity(2)
                .WithStraight()
                .WithInfo(68, 3, Artist.Guillaume_Ducos);
            addEnemy("Veteran Wainrider", EncounterSet.ChallengeOfTheWainriders, 45, 2, 3, 1, 4)
                .WithTraits("Easterling.")
                .WithTextLine("While The Challengers is ahead of The Wainriders, Veteran Wainrider gets +2 Threat and cannot leave the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack if The Challengers is ahead of the Wainriders.")
                .WithStraight()
                .WithInfo(69, 3, Artist.Guillaume_Ducos);
            addLocation("Narrow Pass", EncounterSet.ChallengeOfTheWainriders, 3, 5)
                .WithTraits("Plains.")
                .WithTextLine("while Narrow Pass is the active location, it gains: \"Response: When damage would be placed on Wainrider Champion, remove an equal amount of damage from The Wainriders' stage instead.\"")
                .WithFlavorLine("Perhaps they were waiting to make some ambush in a narrow place?")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithStraight()
                .WithInfo(70, 3, Artist.Alyn_Spiller);
            addLocation("Crowded Track", EncounterSet.ChallengeOfTheWainriders, 0, 6)
                .WithTraits("Plains.")
                .WithTextLine("Crowded Track gets +1 Threat for each character controlled by the first player.")
                .WithTextLine("Forced: After Crowded Track becomes the active location, each player searches the encounter deck and discard pile for an enemy and adds it to the staging area. Shuffle the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithStraight()
                .WithInfo(71, 2, Artist.Greg_Bobrowski);
            addLocation("Ravine Ledge", EncounterSet.ChallengeOfTheWainriders, 4, 4)
                .WithTraits("Plains.")
                .WithTextLine("While Ravine Ledge is in the staging area, each racing test requires 1 additional matching result.")
                .WithTextLine("Travel: The first player makes a racing Attack test. To pass requires 1 TURN result. If the players pass the test, each player draws 1 card. If the players faill the test, each player discards 1 random card from his hand.")
                .WithEasyModeQuantity(1)
                .WithTurn()
                .WithInfo(72, 2, Artist.Alyn_Spiller);
            addTreachery("Wainrider Chariot", EncounterSet.ChallengeOfTheWainriders)
                .WithTraits("Easterling.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("While attached, counts as a Weapon attachment with the text: \"Attached enemy gets +1 Attack. Excess damage dealt by attached enemy must be placed on The Wainriders' stage.\"")
                .WithTextLine("When Revealed: Attach to a non-unique Easterling enemy without a Wainrider Chariot attached.")
                .WithEasyModeQuantity(1)
                .WithStraight()
                .WithInfo(73, 2, Artist.Greg_Bobrowski);
            addTreachery("The Champion's Cunning", EncounterSet.ChallengeOfTheWainriders)
                .WithTextLine("When Revealed: Wainrider Champion makes an attack against each engaged player. If no attacks were made, place damage on The Wainriders' stage equal to the Wainrider Champion's Threat.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attacks destroys a character, place 2 damage on The Wainriders' stage.")
                .WithEasyModeQuantity(2)
                .WithWild()
                .WithInfo(73, 3, Artist.Stanislav_Dikolenko);
            addContract("The Grey Wanderer")
                .WithTextLine("You cannot choose more than 1 starting hero.")
                .WithTextLine("Setup: ~Search your deck for an attachment with a printed cost of 1 and put it into play. Then, flip this card over.")
                .WithFlavorLine("\"...the rule of no realm is mine, neither of Gondor nor any other, great or small. But all worthy things that are in peril as the world now stands, those are my card.\"")
                .WithFlavorLine("-Gandalf, The Return of the King")
                .WithOppositeTextLine("The first non-unique card you play each planning phase does not require a resource match.")
                .WithOppositeTextLine("Action: Exhaust this card and raise your threat by 1 to (choose two): Ready your starting hero, add 2 resources to your starting hero's resource pool, or heal 3 damage from your starting hero.")
                .WithOppositeFlavorLine("\"...this shall be his great task, and maybe the end of his labours.\"")
                .WithOppositeFlavorLine("-Elrond, The Fellowship of the Ring")
                .WithInfo(74, 1, Artist.Justin_Gerard);
            addQuest("Wainrider Camp", EncounterSet.ChallengeOfTheWainriders, 1, 'A', 0)
                .WithKeywords("Race.")
                .WithFlavorLine("The Wainriders have challenged you to a chariot race. Win, and you earn your freedom. Lose, and the Wainriders will sell you as prisoners to Mordor.")
                .WithTextLine("Setup: Build the circuit (see insert). Place The Wainriders and The Challengers objective cards at this stage. The first player adds Wainrider Champion to the staging area. Each other player adds 1 different location to the staging area. Shuffle the encounter deck.")
                .WithOppositeTextLine("Race. This stage gets +4 quest points per player.")
                .WithOppositeTextLine("Forced: When this stage is defeated, make a racing Defense test. To pass requires 1 STRAIGHT result, plus an additional STRAIGHT result for each stage you have completed this round. If the players pass the test, excess progress is placed on the next stage. If the players fail the test, each player discards 1 random card from his hand.")
                .WithIncludedEncounterSets(EncounterSet.RollingPlains, EncounterSet.RidersOfRhun)
                .WithInfo(75, 1, Artist.Tropa_Entertainment);
            addQuest("First Sprint", EncounterSet.ChallengeOfTheWainriders, 2, 'A', 0)
                .WithKeywords("Race.")
                .WithFlavorLine("The Wainriders have created a track that winds around their camp. The first part of the track is an open field that the racers sprint across to gain position before the track narrows.")
                .WithOppositeTextLine("Race. This stage gets +4 quest points per player.")
                .WithOppositeTextLine("Forced: When this stage is defeated, make a racing Attack test. To pass requires 1 STRAIGHT result, plus an additional STRAIGHT result for each stage you have completed this round. If the players pass the test, excess progress is placed on the next stage. If the players fail the test, deal 1 damage to each character.")
                .WithIncludedEncounterSets(EncounterSet.RollingPlains, EncounterSet.RidersOfRhun)
                .WithInfo(76, 1, Artist.Carlos_Palma_Cruchaga);
            addQuest("The Turnaround", EncounterSet.ChallengeOfTheWainriders, 3, 'A', 0)
                .WithKeywords("Race.")
                .WithFlavorLine("At the far end of the Wainrider's track is a sharp turn along the side of a ravine. The racers have to pull hard on their reins to keep their horses from charging over the edge.")
                .WithOppositeTextLine("Race. This stage gets +4 quest points per player.")
                .WithOppositeTextLine("Forced: When this stage is defeated, make a racing Willpower test. To pass requires 1 TURN result, plus an additional TURN result for each stage you have completed this round. If the players pass the test, excess progress is placed on the next stage. If the players fail the test, each player discards an ally he controls.")
                .WithIncludedEncounterSets(EncounterSet.RollingPlains, EncounterSet.RidersOfRhun)
                .WithInfo(77, 1, Artist.Alvaro_Calvo_Escudero);
            addQuest("The Farthest Edge", EncounterSet.ChallengeOfTheWainriders, 4, 'A', 0)
                .WithKeywords("Race.")
                .WithFlavorLine("After navigating a dangerous turn, the Wainrider's track wanders through difficult terrain at the far edge of their camp.")
                .WithOppositeTextLine("Race. This stage gets +4 quest points per player.")
                .WithOppositeTextLine("Forced: When this stage is defeated, make a racing Defense test. To pass requires 1 STRAIGHT result, plus an additional STRAIGHT result for each stage you have completed this round. If the players pass the test, excess progress is placed on the next stage. If the players fail the test, reveal the top card of the encounter deck (top 2 cards instead if there are 3 or more players).")
                .WithIncludedEncounterSets(EncounterSet.RollingPlains, EncounterSet.RidersOfRhun)
                .WithInfo(78, 1, Artist.Carlos_Palma_Cruchaga);
            addQuest("Last Climb", EncounterSet.ChallengeOfTheWainriders, 5, 'A', 0)
                .WithKeywords("Race.")
                .WithFlavorLine("Before returning to the camp. the Wainrider's track climbs a steep hill that rises above the plains surrounding it.")
                .WithOppositeTextLine("Race. This stage gets +4 quest points per player.")
                .WithOppositeTextLine("Forced: When this stage is defeated, make a racing Willpower test. To pass requires 1 STRAIGHT result, plus an additional STRAIGHT result for each stage you have completed this round. If the players pass the test, excess progress is placed on the next stage. If the players fail the test, place 2 damage per player on The Wainriders' stage.")
                .WithIncludedEncounterSets(EncounterSet.RollingPlains, EncounterSet.RidersOfRhun)
                .WithInfo(79, 1, Artist.Sam_White);
            addQuest("Home Stretch", EncounterSet.ChallengeOfTheWainriders, 6, 'A', 0)
                .WithKeywords("Race.")
                .WithFlavorLine("The final sprint of the Wainrider's track is another sharp turn at the bottom of the last climb. The drivers push themseleves to take the turn as fast as they can in order to finish ahead of the competition.")
                .WithOppositeTextLine("Race. This stage gets +4 quest points per player.")
                .WithOppositeTextLine("Forced: When this stage is defeated, make a racing Attack test. To pass requires 1 TURN result, plus an additional TURN result for each stage you have completed this round. If the players pass the test, excess progress is placed on the next stage. If the players fail the test, this stage is not defeated and all progress here is discarded.")
                .WithIncludedEncounterSets(EncounterSet.RollingPlains, EncounterSet.RidersOfRhun)
                .WithInfo(80, 1, Artist.Martin_de_Diego_Sadaba);
        }
    }
}
