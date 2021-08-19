﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheScouringOfTheShire
{
    public class TheScouringOfTheShireCardSet
        : CardSet
    {
        private const string setName = "The Scouring of the Shire";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TSotS";
            Number = 10008;
            SetType = Models.SetType.A_Long_extended_Party;

            /*
            addGenConSetup("The Scouring of the Shire", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("We would like to thank the hard-working people at FFG for creating the card game we all love. We hope we have done proper justice to its legacy with this fan expansion. In particular, we would like to thank Nate French, Lukas Litzsinger, MJ Newman, and Caleb Grace for their role in leading the game design over the last 10 years. And finally, we would like to thank you, the player, for taking interest in our project and making this community one of the best communities in Arda.")
                .WithTextLine("—The ALeP Team")
                .WithInfo(0, 1, Artist.Unknown);
            addGenConSetup("The Scouring of the Shire Rules 1", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("Welcome to The Scouring of the Shire, an unofficial fan Saga Expansion, developed by A Long-extended Party (ALeP).")
                .WithTextLine("Component Overview")
                .WithTextLine("The Scouring of the Shire Saga Expansion includes 69 cards, consisting of:")
                .WithTextLine("• 1 Rules Card • 56 Encounter Cards")
                .WithTextLine("• 1 Hero Card • 5 Quest Cards")
                .WithTextLine("• 4 Boon Cards • 1 Campaign Card")
                .WithTextLine("• 1 Contract Card")
                .WithTextLine("Expansion Symbol")
                .WithTextLine("The cards in The Scouring of the Shire Saga Expansion can be identified by this symbol before each card's collector number.")
                .WithTextLine("Sharkey Deck")
                .WithTextLine("The Sharkey deck is a separate deck that represents the dangerous powers of Sharkey. To create the Sharkey deck, take each treachery card with the Sharkey trait from the encounter deck and shuffle them together. This is the Sharkey deck.")
                .WithTextLine("Page 1/2")
                .WithInfo(0, 1, Artist.Unknown);
            addGenConSetup("The Scouring of the Shire Rules 2", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("Special Saga Rules")
                .WithTextLine("When playing The Scouring of the Shire, follow the “New Staging Rules” found on page 3 of The Black Riders Saga expansion rulebook. When setting up The Scouring of the Shire, the first player takes control of the Fellowship Frodo Baggins included in this expansion. This version of Fellowship Frodo Baggins can only be used while playing The Scouring of the Shire and cannot be used in any other quests. Players cannot use any other version(s) of Frodo Baggins or cards with the title “Saruman” when playing this quest.")
                .WithTextLine("Campaign Mode")
                .WithTextLine("New campaign and boon cards are included in The Scouring of the Shire. These cards allow the players to play The Scouring of the Shire as part of The Lord of the Rings campaign. It should be played after Mount Doom, from The Mountain of Fire Saga Expansion.")
                .WithTextLine("The complete rules for campaign mode can be found in The Black Riders Saga Expansion, which is required to play campaign mode.")
                .WithTextLine("Campaign Rewards")
                .WithTextLine("The Scouring of the Shire includes 1 contract card, Into the West, which cannot be used until the players have earned it while playing campaign mode. Once earned, this card may be used by the players who earned it when playing any quest (not just Saga quests).")
                .WithTextLine("Page 2/2")
                .WithInfo(0, 1, Artist.Unknown);
            */
            addHero("Frodo Baggins", 7, Sphere.Leadership, 2, 1, 2, 2)
                .WithTraits("Hobbit.")
                .WithTextLine("Response: After Frodo Baggins commits to the quest, spend 1 resource from his resource pool to ready another unique character committed to the quest. If you quest successfully this phase, reduce your threat by 1.")
                .WithInfo(2, 1, Artist.Lukasz_Jaskolski);
            addQuest("Many Partings", EncounterSet.TheScouringOfTheShire, 1, 'A', Card.VALUE_NA)
                .WithTextLine("Side A Setup: Create the Sharkey deck (see insert). Set Saruman, Brandywine Gate, Three-Farthing Stone, and each encounter side quest aside, out of play. Shuffle the encounter deck.")
                .WithFlavorLine("Side A: As they came out again into the open country at sundown they overtook an old man leaning on a staff, and he was clothed in rags of grey or dirty white, and at his heels went another beggar, slouching and whining.")
                .WithFlavorLine("The Return of the King Side B: “You don't care what a beggar lacks, do you? For you have all you want, food and fine clothes, and the best weed for your pipes. Oh yes, I know! I know where it comes from. You would not give a pipeful to a beggar, would you?”")
                .WithFlavorLine("Saruman, The Return of the King")
                .WithOppositeTextLine("Action: Exhaust a non-Fellowship hero and discard a resource token from its pool. Then, add 2 resources to the set-aside Saruman.")
                .WithOppositeTextLine("At the end of the planning phase, advance to the next quest stage.")
                .WithIncludedEncounterSets(EncounterSet.TheScouringOfTheShire)
                .WithInfo(1, 1, Artist.Unknown);
            addQuest("Escorted “Prisoners”", EncounterSet.TheScouringOfTheShire, 2, 'A', 12)
                .WithTextLine("Side A When Revealed: Make Brandywine Gate the active location and add Three-Farthing Stone to the staging area.")
                .WithFlavorLine("Side A: After a brief encounter on the road with the disgraced Saruman, Frodo and his companions encounter resistance and hostility from the Shirriffs of the Shire. Side B: “It's the Chief's orders that you're to come along quiet. We're going to take you to Bywater and hand you over to the Chief's Men.”")
                .WithFlavorLine("The Return of the King")
                .WithOppositeTextLine("This stage cannot have more than 12 progress tokens on it.")
                .WithOppositeTextLine("Forced: At the end of the quest phase, if no progress was placed here as a result of questing successfully, the first player raises their threat by 3. If more than 3 progress was placed, each player engaged with more than 1 Shirriff enemy may discard 1 of them.")
                .WithOppositeTextLine("The players cannot advance while Three-Farthing Stone is in play.")
                .WithIncludedEncounterSets(EncounterSet.TheScouringOfTheShire)
                .WithInfo(2, 1, Artist.Unknown);
            addQuest("Raise the Shire", EncounterSet.TheScouringOfTheShire, 3, 'A', Card.VALUE_NA)
                .WithTextLine("Side A When Revealed: Randomly select 3 of the set aside non-Doom side quests and put them into play (4 side quests instead if there are 3 or 4 players).")
                .WithFlavorLine("Side A: The Shire has fallen under the sway of a gang of ruffians led by a man known as “Sharkey”. Frodo and his friends must prepare Bywater and raise support to contest him. Side B: “As soon as they saw how things were, most of them took off their feathers and joined in the revolt.”")
                .WithFlavorLine("The Return of the King")
                .WithOppositeTextLine("Forced: After a side quest is defeated, search the encounter deck for a Shirriff enemy and add it to the staging area. Shuffle the encounter deck.")
                .WithOppositeTextLine("Forced: At the end of the round, place 1 resource token here and raise each player's threat by the total number of resource tokens here. Then, the players may choose to advance to the next quest stage.")
                .WithIncludedEncounterSets(EncounterSet.TheScouringOfTheShire)
                .WithInfo(3, 1, Artist.Unknown);
            addQuest("The Battle of Bywater", EncounterSet.TheScouringOfTheShire, 4, 'A', Card.VALUE_NA)
                .WithTextLine("Side A When Revealed: Shuffle the encounter discard pile into the encounter deck. Remove each Shirriff enemy in play and in the encounter deck from the game. The first player searches the encounter deck and victory display for 1 copy of Gang of Ruffians and engages it. Then, each player not engaged with a Ruffian enemy searches the encounter deck for a Ruffian enemy and engages it. Shuffle the encounter deck. Discard cards from the encounter deck until X enemies are discarded, and add those enemies to the staging area. X is the number of encounter side quests in play. Then, remove those side quests from the game.")
                .WithFlavorLine("Side A:  Side B: The ruffians could not now be cowed so easily. A few of them obeyed, but were immediately set on by their fellows. A score or more broke back and charged the wagons.")
                .WithFlavorLine("The Return of the King")
                .WithOppositeTextLine("While any Ruffian enemy in play has any remaining hit points, all Ruffian enemies gain indestructible.")
                .WithOppositeTextLine("If there are no enemies in play, advance to the next quest stage.")
                .WithIncludedEncounterSets(EncounterSet.TheScouringOfTheShire)
                .WithInfo(4, 1, Artist.Unknown);
            addQuest("The Very Last Stroke", EncounterSet.TheScouringOfTheShire, 5, 'A', Card.VALUE_X)
                .WithTextLine("Side A When Revealed: If it is the combat phase, end the phase. Add Saruman and Gríma's Choice to the staging area.")
                .WithFlavorLine("Side A: With Sharkey's forces scattered, Frodo sets out to confront him. To Frodo's surprise, he is greeted by none other than Saruman, with Gríma Wormtongue cowering nearby. Side B: “You are wise, and cruel. You have robbed my revenge of sweetness, and now I must go hence in bitterness.”")
                .WithFlavorLine("Saruman, The Return of the King")
                .WithOppositeTextLine("X is 6 Per Player. This stage cannot have more progress than the number of resource tokens on Saruman.")
                .WithOppositeTextLine("Action: Exhaust a hero and discard 1 resource token from its pool to add 1 resource to Saruman.")
                .WithOppositeTextLine("This stage cannot be defeated while Saruman is in play. When this stage is defeated, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.TheScouringOfTheShire)
                .WithInfo(5, 1, Artist.Unknown);
            addHero("Frodo Baggins", 0, Sphere.Fellowship, 2, 1, 2, 2)
                .WithSlugSuffix("Fellowship")
                .WithTraits("Hobbit.")
                .WithTextLine("The first player gains control of Frodo Baggins.")
                .WithTextLine("Response: After Frodo Baggins is declared as a defender, spend 1 Fellowship resource to reduce your threat by the attacking enemy's Threat. Until the end of the round, that enemy cannot take damage.")
                .WithTextLine("If Frodo Baggins leaves play, the players lose the game.")
                .WithInfo(6, 1, Artist.Unknown);
            addEnemy("Saruman", EncounterSet.TheScouringOfTheShire, 0, 4, 5, 4, 9)
                .WithUnique()
                .WithTraits("Istari.", "Traitor.")
                .WithTextLine("Immune to player card effects. Cannot be engaged. Sharkey card effects cannot be cancelled.")
                .WithTextLine("Forced: At the end of the staging step, add 1 Per Player resource tokens to Saruman and reveal the top card of the Sharkey deck. Then, put the revealed card on the bottom of the Sharkey deck.")
                .WithInfo(7, 1, Artist.Unknown);
            addLocation("Brandywine Gate", EncounterSet.TheScouringOfTheShire, 3, 1)
                .WithUnique()
                .WithTraits("Shire.", "Gate.")
                .WithTextLine("Immune to player card effects.")
                .WithTextLine("Forced: After Brandywine Gate is explored, each player searches the encounter deck for a Feather-capped Shirriff and engages it. Shuffle the encounter deck.")
                .WithFlavorLine("At either end of the Bridge there was a great spiked gate.")
                .WithFlavorLine("The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(8, 1, Artist.Unknown);
            addLocation("Three-Farthing Stone", EncounterSet.TheScouringOfTheShire, 1, Card.VALUE_X)
                .WithUnique()
                .WithTraits("Shire.", "Road.")
                .WithTextLine("X is 3 Per Player. Immune to player card effects. The players cannot travel here unless there are 12 progress tokens on Escorted “Prisoners”.")
                .WithTextLine("Response: After Three-Farthing Stone leaves play as an explored location, each player reduces their threat by 3.")
                .WithFlavorLine("They were hungry and very footsore and they could not stand the pace.")
                .WithFlavorLine("The Return of the King")
                .WithVictoryPoints(1)
                .WithInfo(9, 1, Artist.Unknown);
            addTreachery("Hidden Blade", EncounterSet.TheScouringOfTheShire)
                .WithTraits("Sharkey.")
                .WithTextLine("When Revealed: Saruman makes an immediate attack against each player in turn order. Allies cannot defend against Saruman.")
                .WithFlavorLine("“A knife flashed in his hand, and he stabbed swiftly.”")
                .WithFlavorLine("The Return of the King")
                .WithInfo(10, 1, Artist.Unknown);
            addTreachery("One Ill Turn", EncounterSet.TheScouringOfTheShire)
                .WithTraits("Sharkey.")
                .WithTextLine("When Revealed: Deal 1 damage to each exhausted character. Until the end of the round, characters cannot be healed.")
                .WithFlavorLine("“It would have been a sharper lesson, if only you had given me a little more time.”")
                .WithFlavorLine("Saruman, The Return of the King")
                .WithInfo(11, 1, Artist.Unknown);
            addTreachery("Voice of Saruman", EncounterSet.TheScouringOfTheShire)
                .WithTraits("Sharkey.")
                .WithTextLine("When Revealed: Randomly select 1 ally controlled by each player, if able. Each player deals X damage to one of their heroes, where X is their chosen ally's Attack, then discards that ally. If a player controls no allies, that player instead discards all attachments from the hero they control with the most attachments.")
                .WithFlavorLine("“He has lost all power, save his voice that can still daunt you and deceive you, if you let it.”")
                .WithFlavorLine("Frodo Baggins, The Return of the King")
                .WithInfo(12, 1, Artist.Unknown);
            addTreachery("Curse Upon the Shire", EncounterSet.TheScouringOfTheShire)
                .WithTraits("Sharkey.")
                .WithTextLine("When Revealed: Each player must choose: either raise your threat by 1 for each ally you control, or discard 2 allies you control.")
                .WithFlavorLine("“Long may your land be short of leaf!”")
                .WithFlavorLine("Saruman, The Return of the King")
                .WithInfo(13, 1, Artist.Unknown);
            addTreachery("To the Road Again, Worm!", EncounterSet.TheScouringOfTheShire)
                .WithTraits("Sharkey.")
                .WithTextLine("When Revealed: Discard cards from the encounter deck until a location is discarded and add that location to the staging area. Deal X damage among characters in play. X is twice the number of locations in play (3 times the number of locations in play if there are 3 or more players).")
                .WithFlavorLine("Saruman laughed. “You do what Sharkey says, always, don't you, Worm?”")
                .WithFlavorLine("The Return of the King")
                .WithInfo(14, 1, Artist.Unknown);
            addEncounterSideQuest("Gríma's Choice", EncounterSet.TheScouringOfTheShire, Card.VALUE_X)
                .WithTraits("Doom.")
                .WithTextLine("X is 3 Per Player. This stage cannot be chosen as the current quest while The Very Last Stroke has remaining quest points.")
                .WithTextLine("Forced: When this stage is defeated, discard Saruman from play.")
                .WithFlavorLine("“Wormtongue!” called Frodo. “You need not follow him. I know of no evil you have done to me. You can have rest and food here for a while, until you are stronger and can go your own ways.”")
                .WithFlavorLine("The Return of the King")
                .WithInfo(15, 1, Artist.Unknown);
            addEncounterSideQuest("Rouse the Cottons", EncounterSet.TheScouringOfTheShire, 6)
                .WithTextLine("While Rouse the Cottons is the current quest, allies cannot commit to the quest.")
                .WithTextLine("Forced: When this quest is defeated, flip it over.")
                .WithFlavorLine("“Come on now, lads! Bywater is up! We must be in it!”")
                .WithFlavorLine("Tom Cotton, The Return of the King")
                .WithSideA()
                .WithInfo(16, 1, Artist.Unknown);
            addObjective("Roused Hobbits", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("While attached, counts as a Condition attachment with the text: “Attached card loses indestructible and the enemy card type and gains the ally card type with Willpower equal to its Threat. If either attached card or Roused Hobbits would leave play, remove both cards from the game.”")
                .WithTextLine("When Revealed: Choose 1 player to take control of a Shirriff enemy engaged with them and attach Roused Hobbits to it (if there are no engaged Shirriff enemies, remove Roused Hobbits from the game).")
                .WithSideB()
                .WithInfo(16, 1, Artist.Unknown);
            addEncounterSideQuest("Awake! Fire, Foes! Awake!", EncounterSet.TheScouringOfTheShire, 12)
                .WithTextLine("Encounter Action: Engage a Ruffian enemy in the encounter discard pile. Any player may trigger this effect.")
                .WithTextLine("Response: After the first player destroys an enemy, place 2 progress here.")
                .WithTextLine("Forced: When this quest is defeated, flip it over.")
                .WithFlavorLine("He had not gone far when he heard a sudden clear horn-call go up ringing into the sky. Far over hill and field it echoed.")
                .WithFlavorLine("-The Return of the King")
                .WithSideA()
                .WithInfo(17, 1, Artist.Unknown);
            addObjective("Roused Hobbits", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("While attached, counts as a Condition attachment with the text: “Attached card loses indestructible and the enemy card type and gains the ally card type with Willpower equal to its Threat. If either attached card or Roused Hobbits would leave play, remove both cards from the game.”")
                .WithTextLine("When Revealed: Choose 1 player to take control of a Shirriff enemy engaged with them and attach Roused Hobbits to it (if there are no engaged Shirriff enemies, remove Roused Hobbits from the game).")
                .WithSideB()
                .WithInfo(17, 1, Artist.Unknown);
            addEncounterSideQuest("Set up Barriers", EncounterSet.TheScouringOfTheShire, 12)
                .WithTextLine("Players cannot draw cards.")
                .WithTextLine("Action: Spend 1 Per Player resources as a group to place 3 progress on Set up Barriers.")
                .WithTextLine("Forced: When this quest is completed, the first player discards all resources from each hero they control. Then, flip this card over.")
                .WithFlavorLine("Others at Merry's orders were setting up barriers across the road at each end of the village.")
                .WithFlavorLine("-The Return of the King")
                .WithSideA()
                .WithInfo(18, 1, Artist.Unknown);
            addObjective("Roused Hobbits", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("While attached, counts as a Condition attachment with the text: “Attached card loses indestructible and the enemy card type and gains the ally card type with Willpower equal to its Threat. If either attached card or Roused Hobbits would leave play, remove both cards from the game.”")
                .WithTextLine("When Revealed: Choose 1 player to take control of a Shirriff enemy engaged with them and attach Roused Hobbits to it (if there are no engaged Shirriff enemies, remove Roused Hobbits from the game).")
                .WithSideB()
                .WithInfo(18, 1, Artist.Unknown);
            addEncounterSideQuest("Muster the Tooks", EncounterSet.TheScouringOfTheShire, Card.VALUE_X)
                .WithTextLine("X is 4 Per Player. While Muster the Tooks is the current quest, heroes cannot commit to the quest.")
                .WithTextLine("Forced: When this quest is defeated, flip it over.")
                .WithFlavorLine("“It's only fourteen miles or so over the fields. I'll bring you back an army of Tooks in the morning.”")
                .WithFlavorLine("-Pippin, The Return of the King")
                .WithSideA()
                .WithInfo(19, 1, Artist.Unknown);
            addObjective("Roused Hobbits", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("While attached, counts as a Condition attachment with the text: “Attached card loses indestructible and the enemy card type and gains the ally card type with Willpower equal to its Threat. If either attached card or Roused Hobbits would leave play, remove both cards from the game.”")
                .WithTextLine("When Revealed: Choose 1 player to take control of a Shirriff enemy engaged with them and attach Roused Hobbits to it (if there are no engaged Shirriff enemies, remove Roused Hobbits from the game).")
                .WithSideB()
                .WithInfo(19, 1, Artist.Unknown);
            addEncounterSideQuest("Ambush Sharkey's Men", EncounterSet.TheScouringOfTheShire, Card.VALUE_NA)
                .WithTextLine("Forced: After a Gang of Ruffians is defeated, flip this card over.")
                .WithTextLine("Forced: At the end of the quest phase, if no progress was placed on Ambush Sharkey's Men this round, search the encounter deck and discard pile for a Ruffian enemy and add it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("“I warned you not to come back here. I warn you again: you are standing in the light.”")
                .WithFlavorLine("-Merry, The Return of the King")
                .WithSideA()
                .WithInfo(20, 1, Artist.Unknown);
            addObjective("Roused Hobbits", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("While attached, counts as a Condition attachment with the text: “Attached card loses indestructible and the enemy card type and gains the ally card type with Willpower equal to its Threat. If either attached card or Roused Hobbits would leave play, remove both cards from the game.”")
                .WithTextLine("When Revealed: Choose 1 player to take control of a Shirriff enemy engaged with them and attach Roused Hobbits to it (if there are no engaged Shirriff enemies, remove Roused Hobbits from the game).")
                .WithSideB()
                .WithInfo(20, 1, Artist.Unknown);
            addEncounterSideQuest("Find the Gaffer", EncounterSet.TheScouringOfTheShire, 8)
                .WithTextLine("Travel Action: Exhaust a hero you control to place 2 progress on Find the Gaffer. You cannot declare defenders or attackers this round. Any player may trigger this effect.")
                .WithTextLine("Forced: When this quest is defeated, flip it over.")
                .WithFlavorLine("“I want to see him. That Boss and that Sharkey, as they spoke of, they might do a mischief up there before the morning.”")
                .WithSideA()
                .WithFlavorLine("-Sam, The Return of the King")
                .WithInfo(21, 1, Artist.Unknown);
            addObjective("Roused Hobbits", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("While attached, counts as a Condition attachment with the text: “Attached card loses indestructible and the enemy card type and gains the ally card type with Willpower equal to its Threat. If either attached card or Roused Hobbits would leave play, remove both cards from the game.”")
                .WithTextLine("When Revealed: Choose 1 player to take control of a Shirriff enemy engaged with them and attach Roused Hobbits to it (if there are no engaged Shirriff enemies, remove Roused Hobbits from the game).")
                .WithSideB()
                .WithInfo(21, 1, Artist.Unknown);
            addEncounterSideQuest("Watch the East Road", EncounterSet.TheScouringOfTheShire, Card.VALUE_X)
                .WithTextLine("Cannot be chosen as the active quest. X is 1 plus 1 Per Player.")
                .WithTextLine("Response: At the beginning of the staging step, place any number of progress here and reveal an equal number of encounter cards.")
                .WithTextLine("Forced: When this quest is defeated, flip it over.")
                .WithFlavorLine("“There's a big band about four miles away… there must be close on a hundred of them; and they're fire-raising as they come.”")
                .WithFlavorLine("-Merry, The Return of the King")
                .WithSideA()
                .WithInfo(22, 1, Artist.Unknown);
            addObjective("Roused Hobbits", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("While attached, counts as a Condition attachment with the text: “Attached card loses indestructible and the enemy card type and gains the ally card type with Willpower equal to its Threat. If either attached card or Roused Hobbits would leave play, remove both cards from the game.”")
                .WithTextLine("When Revealed: Choose 1 player to take control of a Shirriff enemy engaged with them and attach Roused Hobbits to it (if there are no engaged Shirriff enemies, remove Roused Hobbits from the game).")
                .WithSideB()
                .WithInfo(22, 1, Artist.Unknown);
            addEnemy("Feather-capped Shirriff", EncounterSet.TheScouringOfTheShire, 25, 1, 2, 1, 2)
                .WithTraits("Hobbit.", "Shirriff.")
                .WithKeywords("Indestructible.")
                .WithTextLine("Indestructible. Damage dealt by Feather-capped Shirriff to your characters is instead assigned as an increase to your threat.")
                .WithTextLine("While the engaged player's threat is higher than Feather-capped Shirriff's engagement cost, Feather-capped Shirriff gets +1 Attack.")
                .WithInfo(23, 6, Artist.Unknown);
            addEnemy("Thieving Ruffian", EncounterSet.TheScouringOfTheShire, 25, 2, 3, 2, 2)
                .WithTraits("Ruffian.")
                .WithTextLine("Forced: When Thieving Ruffian attacks you, raise your threat by 1 for each attachment on the defending character.")
                .WithFlavorLine("“So that's your tone, is it? Change it, or we'll change it for you.”")
                .WithFlavorLine("The Return of the King")
                .WithInfo(24, 4, Artist.Unknown);
            addEnemy("Highway Robber", EncounterSet.TheScouringOfTheShire, 30, 3, 4, 3, 3)
                .WithTraits("Ruffian.")
                .WithTextLine("Forced: When Highway Robber attacks you, either discard 1 resource from a hero you control or Highway Robber gets +2 Attack for this attack.")
                .WithFlavorLine("Scaring Breeland peasants, and bullying bewildered hobbits, had been their work.")
                .WithFlavorLine("The Return of the King")
                .WithInfo(25, 3, Artist.Unknown);
            addEnemy("Gang of Ruffians", EncounterSet.TheScouringOfTheShire, 40, 4, 8, 3, 8)
                .WithTraits("Ruffian.")
                .WithTextLine("Response: When Gang of Ruffians would deal damage during an attack, instead distribute that damage among characters controlled by the defending player.")
                .WithTextLine("Forced: After Gang of Ruffians attacks, if the attack destroyed at least 1 of your characters, discard 1 card at random from your hand and raise your threat by 1.")
                .WithInfo(26, 3, Artist.Unknown);
            addLocation("The Lockholes", EncounterSet.TheScouringOfTheShire, 2, 3)
                .WithTraits("Shire.", "Underground.")
                .WithKeywords("Peril.")
                .WithTextLine("Peril.")
                .WithTextLine("When Revealed: Remove all attachments and discard all tokens from the highest cost ally you control and attach it facedown under The Lockholes.")
                .WithTextLine("Forced: After The Lockholes is explored, return the attached ally to its owner's control, faceup and ready.")
                .WithFlavorLine("“Lockholes, as they call ‘em: the old storage-tunnels at Michel Delving that they've made into prisons for those as stand up to them.”")
                .WithFlavorLine("Tom Cotton, The Return of the King")
                .WithInfo(27, 2, Artist.Unknown);
            addLocation("East Road", EncounterSet.TheScouringOfTheShire, 4, 2)
                .WithTraits("Shire.", "Road.")
                .WithKeywords("Peril.")
                .WithTextLine("Peril.")
                .WithTextLine("When Revealed: Either raise your threat by 2 or East Road gains surge.")
                .WithFlavorLine("Round a bend, about a furlong from the main road, they met a stout barrier of old farm-carts upturned. That halted them.")
                .WithFlavorLine("The Return of the King")
                .WithInfo(28, 3, Artist.Unknown);
            addLocation("Shirriff House", EncounterSet.TheScouringOfTheShire, 3, 3)
                .WithTraits("Hideout.")
                .WithTextLine("Forced: After Shirriff House becomes the active location, exhaust each character with 2 or more printed Attack.")
                .WithTextLine("Forced: After Shirriff House leaves play, the first player must search the encounter deck and discard pile for a Shirriff enemy and engage it, if able. Shuffle the encounter deck.")
                .WithFlavorLine("Inside it was damp and cheerless.")
                .WithFlavorLine("The Return of the King")
                .WithInfo(29, 2, Artist.Unknown);
            addLocation("Hobbiton Road", EncounterSet.TheScouringOfTheShire, 2, 1)
                .WithTraits("Shire.", "Road.")
                .WithTextLine("Forced: After Hobbiton Road leaves play, put a Ruffian enemy in the discard pile into play engaged with a player.")
                .WithShadow("Shadow: Deal 1 damage to the defending character or raise your threat by 1.")
                .WithInfo(30, 3, Artist.Unknown);
            addLocation("Brick Building", EncounterSet.TheScouringOfTheShire, 1, 5)
                .WithTraits("Hideout.")
                .WithTextLine("While Brick Building is in the staging area, characters cannot be healed.")
                .WithShadow("Shadow: Deal 2 damage to the defending character or raise your threat by 2.")
                .WithFlavorLine("Through rows of new mean houses along each side of the road, they saw the new mill in all its frowning and dirty ugliness.")
                .WithFlavorLine("The Return of the King")
                .WithInfo(31, 2, Artist.Unknown);
            addLocation("Wooden Shed", EncounterSet.TheScouringOfTheShire, 1, 5)
                .WithTraits("Hideout.")
                .WithTextLine("While Wooden Shed is in the staging area, players cannot reduce their threat by more than 1 each round.")
                .WithShadow("Shadow: Either raise your threat by 1 or exhaust a character you control.")
                .WithFlavorLine("There were piles of refuse everywhere. The door was scarred; the bell-chain was dangling loose, and the bell would not ring.")
                .WithFlavorLine("The Return of the King")
                .WithInfo(32, 2, Artist.Unknown);
            addTreachery("Once Beloved Place", EncounterSet.TheScouringOfTheShire)
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("When Revealed: Each location gets +1 Threat until the end of the round. If there are fewer than 1 Per Player locations in the staging area, discard cards from the encounter deck until a location is discarded and add it to the staging area.")
                .WithFlavorLine("All the chestnuts were gone. The banks and hedgerows were broken.")
                .WithFlavorLine("The Return of the King")
                .WithInfo(33, 2, Artist.Unknown);
            addTreachery("Against the Rules", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("When Revealed: Exhaust each character with 3 or more printed Attack. Each player that exhausted no characters by this effect must choose and exhaust 1 character they control.")
                .WithShadow("Shadow: If your threat is higher than the attacking enemy's engagement cost, the attacking enemy gets +2 Attack. Otherwise, raise your threat by 2.")
                .WithInfo(34, 3, Artist.Unknown);
            addTreachery("Take Him, Lads!", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("When Revealed: Raise each player's threat by 4. Then, each player discards an ally they control and reduces their threat by X, where X is the printed cost of their discarded ally.")
                .WithShadow("Shadow: If your threat is higher than the attacking enemy's engagement cost, the attacking enemy gets +2 Attack. Otherwise, raise your threat by 2.")
                .WithInfo(35, 2, Artist.Unknown);
            addTreachery("Sharkey's Men", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("When Revealed: Each enemy in play gets +1 Attack until the end of the round. If there are fewer than 1 Per Player Ruffian enemies in play, discard cards from the encounter deck until a Ruffian enemy is discarded and add it to the staging area.")
                .WithShadow("Shadow: If the attacking enemy is a Ruffian, it makes an additional attack. The defending player may discard an ally they control to cancel this effect.")
                .WithInfo(36, 3, Artist.Unknown);
            addAttachment("Star-like Gem", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.", "Hobbit.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Willpower.")
                .WithTextLine("If attached hero is a Hobbit, it does not exhaust to quest.")
                .WithFlavorLine("“When the memory of the fear and the darkness troubles you, this will bring you aid.”")
                .WithFlavorLine("Arwen, The Return of the King")
                .WithInfo(38, 1, Artist.Unknown);
            addAttachment("Bright Mail", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Item.", "Armor.", "Gondor.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gets +1 Defense (+2 Defense instead if attached hero is a Hobbit).")
                .WithFlavorLine("“They wouldn't go for armed folk, with swords and helmets and shields and all. Make them think twice, that would.”")
                .WithFlavorLine("Barliman Butterbur, The Return of the King")
                .WithInfo(39, 1, Artist.Unknown);
            addAttachment("Scatha's Horn", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Artifact.", "Item.", "Rohan.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Action: Exhaust Scatha's Horn to choose an attacking enemy. Until the end of the phase, that enemy gets −1 Attack (−2 Attack instead if the defending character is a Hobbit hero).")
                .WithFlavorLine("“He that blows it at need shall set fear in the hearts of his enemies.”")
                .WithFlavorLine("Éowyn, The Return of the King")
                .WithInfo(40, 1, Artist.Unknown);
            addAttachment("Heightened Stature", 0, Sphere.Neutral, true)
                .WithBoon()
                .WithTraits("Condition.", "Ent.")
                .WithTextLine("Attach to a hero.")
                .WithTextLine("Attached hero gains +2 hit points (+3 hit points instead if attached hero is a Hobbit).")
                .WithTextLine("Action: Exhaust Heightened Stature to heal 1 damage from attached hero.")
                .WithFlavorLine("“Mortals cannot go drinking ent-draughts and expect no more to come of them than of a pot of beer.”")
                .WithFlavorLine("Gimli, The Return of the King")
                .WithInfo(41, 1, Artist.Unknown);
            /*
            addGenConSetup("Back Card", EncounterSet.TheScouringOfTheShire)
                .WithTextLine("Side A Credits")
                .WithTextLine("CEO: Seastan Art: banania")
                .WithTextLine("COO: A.R. Playtesting: Shellin")
                .WithTextLine("Game Design: Seastan Rules: McDog3")
                .WithTextLine("Storytelling: John Leo Software: A.R.")
                .WithTextLine("Editing: Darkling Door Printing: thaurdir")
                .WithTextLine("Graphic Design: thaurdir Community: secondhandtook")
                .WithTextLine("Lore: Levanthalas")
                .WithTextLine("Assistants: [DTP]Anzu, AdamKrafty, Admiral Polaris, ALeP Cron Bot, alonewolf87, Annaeru, argonui, AstroSnail (Stephen), Baloosh, Barthadra, Beleg489, Beorn, BeornBot, bgamerjoe, BobbinmcSmallburrow, Brewer Bear, Brinx, Bullroarer Took, Bundeswill, CamMitchell, carlosm88, ceciltettledeer, Celia, Comtedelafere, croatoan, Cryoshark, d20woodworking, DavidJMartin, deiseach, Dieter, doomguard, du, dwaynek, Edmund, EdY, Eldandil, eldub, Elessar 010 (Patrick), Emilius, Emmental, Emreis, estel_edain, filgonfin, Franlag, fuzzyslippers, granny.sheep, Great Glorfindel, GreenWizard, Helena Real, Hrodebert, Ira, JasonRed3, Jaywana, Jban, KingDom, KYpatzer, LeeA, Lively, Lorunks, Mag, Magus, Makoshark13, Mazdaist, Mormegil, MrSpaceBear, MurstonThor, nelloianiro, Nesnaj, Nuls, oldoly, Onidsen, Pawlo, Pining For Fimbrethil, RedSpiderr, RegisF, Rimogard, RogueThirteen, Salted Pork, SamthemanGamgee, sappidus, Speder, Splice, Stavo343, tamhas, Taudir, Tegyrius, Thaimor, thanatopsis, TheChap, thorsome, tlawrence, Trialus, TritonWreck, Truck, Tuhma, VeggieGollum, Verwegner (Jan), Watch-Captain Alain, Watcher in the Water, wlk, wolframius, xaviermutant, ycarium, Zapier, zoomboy")
                .WithTextLine("Special thanks to HeavyKaragh for his work on the Strange Eons plugin, RiddermarkLord and Gorthaur for their work on the card templates, and Troy L for the ALeP logo and encounter set icon designs. We credit Marko Manev for the ALeP encounter card back art.")
                .WithOppositeTextLine("Facing peril after peril, you have destroyed the One Ring at last and diminished Sauron's power once and for all. With the hosts of evil scattered, it is time to return to where your adventures began — but all is not well in the Shire, for Sharkey and his ruffians have taken power in your absence. Now is the time to sound the horn-call of Buckland, rally the Shire to your cause, and free the land in the final battle of the War of the Ring.")
                .WithInfo(999, 1, Artist.Unknown);
             * */
        }
    }
}