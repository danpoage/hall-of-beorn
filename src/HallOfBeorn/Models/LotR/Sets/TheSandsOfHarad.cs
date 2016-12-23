using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheSandsOfHarad : CardSet
    {
        private string setEscape = EncounterSet.EscapeFromUmbar.Name;
        private string setLongArm = EncounterSet.TheLongArmOfMordor.Name;
        private string setMordorOrcs = EncounterSet.MordorOrcs.Name;
        private string setJungle = EncounterSet.JungleForest.Name;
        private string setHaradSoldiers = EncounterSet.HaradSoldiers.Name;
        private string setHaradTerritory = EncounterSet.HaradTerritory.Name;
        private string setCrossing = EncounterSet.DesertCrossing.Name;
        private string setCreatures = EncounterSet.DesertCreatures.Name;
        private string setSands = EncounterSet.DesertSands.Name;

        protected override void Initialize()
        {
            Name = "The Sands of Harad";
            Abbreviation = "TSoH";
            Number = 42;
            SetType = Models.SetType.Deluxe_Expansion;

            addCard(LotRCard.Hero("Gimli", string.Empty, Sphere.Leadership, 11, 2, 2, 2, 5)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Gimli is declared as a defender, spend 1 resource from his pool to ready another hero. If that hero is Legolas, he gets +1 Attack until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"Faithless is he that says farewell when the road darkens...\"\r\n-The Fellowship of the Ring")
                .WithInfo(1, 1, Artist.Owen_William_Weber));
            addCard(LotRCard.Hero("Legolas", string.Empty, Sphere.Spirit, 9, 1, 3, 1, 4)
                .WithTraits("Silvan.", "Noble.", "Scout.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Legolas commits to a quest, discard a card from your hand to ready another hero. If that hero is Gimli, he gets +1 Willpower until the end of the phase. (Limit once per phase.)")
                .WithFlavor("\"I go to find the Sun!\"\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Aleksander_Karcz));
            addCard(LotRCard.Ally("Greenwood Archer", string.Empty, Sphere.Leadership, 2, 0, 2, 0, 1)
                .WithGeneric()
                .WithTraits("Silvan.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Greenwood Archer enters play, ready a hero.")
                .WithFlavor("They dwelt most often by the edges of the woods, from which they could escape at times to hunt...\r\n-The Hobbit")
                .WithInfo(3, 3, Artist.Tawny_Fritzinger));
            addCard(LotRCard.Ally("Erebor Guard", string.Empty, Sphere.Spirit, 4, 0, 1, 2, 3)
                .WithGeneric()
                .WithTraits("Dwarf.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: When you play Erebor Guard from your hand, discard the top 2 cards of your deck to reduce its cost by 2.")
                .WithFlavor("...the fortress of the dwarves could not be taken by surprise.\r\n-The Hobbit")
                .WithInfo(4, 3, Artist.Marius_Bota));
            addCard(LotRCard.Ally("Halfling Bounder", string.Empty, Sphere.Lore, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Hobbit.")
                .WithText("While there is a side quest in the victory display, Halfling Bounder gains: \"Response: Discard Halfling Bounder to cancel the 'when revealed' effects of an encounter card that was just revealed from the encounter deck.\"")
                .WithFlavor("\"The Bounders have never been so busy before.\"\r\n-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(5, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Ally("Vigilant Dúnadan", string.Empty, Sphere.Tactics, 4, 1, 3, 2, 3)
                .WithNormalizedTitle("Vigilant Dunadan")
                .WithGeneric()
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("While there is a side quest in the victory display, Vigilant Dúnadan does not exhaust to defend.")
                .WithFlavor("\"I don't think we've rightly understood till now what they did for us.\"\r\n-Barliman Butterbur, The Return of the King")
                .WithInfo(6, 3, Artist.JB_Casacop));
            addCard(LotRCard.Event("Unlikely Friendship", string.Empty, Sphere.Leadership, 0)
                .WithText("Play only if you control a unique character with the Silvan trait and another unique character with the Dwarf trait.\r\nAction: Draw 1 card and add 1 resource to the resource pool of a hero you control.")
                .WithFlavor("...folk that saw them pass marvelled to see such companions...\r\n-The Return of the King")
                .WithInfo(7, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Event("Well Warned", string.Empty, Sphere.Spirit, 0)
                .WithText("Play only if you control a unique character with the Noble trait and another unique character with the Scout trait.\r\nResponse: After a player engages an enemy, reduce his threat by X, where X is that enemy's printed Threat.")
                .WithFlavor("...the Captains of the West were well warned by their scouts...\r\n-The Return of the King")
                .WithInfo(8, 3, Artist.Ashley_Lange));
            addCard(LotRCard.Event("Dour-handed", string.Empty, Sphere.Tactics, 1)
                .WithText("Action: Deal X damage to an enemy engaged with you. X is the number of side quests in the victory display.")
                .WithFlavor("...the tides of fate had turned against them and their doom was at hand. -The Return of the King")
                .WithInfo(9, 3, Artist.JB_Casacop));
            addCard(LotRCard.Attachment("Dwarven Shield", string.Empty, Sphere.Leadership, 2)
                .WithGeneric()
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dwarf hero.\r\nAttached hero gets +1 Defense.\r\nResponse: After attached hero takes damage from an enemy attack, exhaust Dwarven Shield to add 1 resource to attached hero's pool.")
                .WithFlavor("...each of them had also a short broad sword at his side and a round shield slung at his back.\r\n-The Hobbit")
                .WithInfo(10, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Attachment("Mirkwood Long-knife", string.Empty, Sphere.Spirit, 2)
                .WithGeneric()
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Silvan hero.\r\nAttached hero gets +1 Willpower and +1 Attack.")
                .WithFlavor("Legolas had a bow and a quiver, and at his belt a long white knife.\r\n-The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Alexandr_Elichev));
            addCard(LotRCard.Attachment("The Road Goes Ever On", string.Empty, Sphere.Lore, 0)
                .WithTraits("Song.")
                .WithText("Attach to a quest card in play.\r\nResponse: When attached quest is defeated, the first player chooses a player. That player searches his deck for a side quest, adds it to his hand, and shuffles his deck.")
                .WithFlavor("\"Now far ahead the Road has gone,\r\nAnd I must follow, if I can...\"\r\n-Frodo Baggins, The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Jason_Jenicke));
            addCard(LotRCard.PlayerSideQuest("The Storm Comes", string.Empty, Sphere.Neutral, 0, 5)
                .WithText("Limit 1 copy of The Storm Comes in the victory display.\r\nWhile this quest is in the victory display, the first ally played by each player each round does not require a resource match.")
                .WithFlavor("\"For behold! The storm comes, and now all friends should gather together, lest each singly be destroyed.\"\r\n-Gandalf, The Two Towers")
                .WithVictoryPoints(1)
                .WithInfo(13, 3, Artist.Tomasz_Jedruszek));
            addCard(LotRCard.Objective("\"Seize Them!\"", string.Empty, setEscape)
                .WithText("Forced: After an enemy attacks and destroys a character, remove X progress from the main quest, X is the attacking enemy's Threat.\r\nAt the end of the round, if the main quest has been in play the entire round and there are no progress tokens on it, the players lose the game.")
                .WithInfo(14, 1, Artist.Victor_Manuel_Leza_Moreno));
            addCard(LotRCard.Enemy("Umbar Sentry", string.Empty, setEscape, 28, 1, 2, 1, 3)
                .WithTraits("Harad.")
                .WithKeywords("Surge.", "Archery 1.")
                .WithText("Forced: When ~Umbar Sentry attacks, either remove 1 progress token from the main quest, or it gets +2 Attack for this attack.")
                .WithFlavor("Umbar remained at war with Gondor for many lives of men...\r\n-The Return of the King")
                .WithInfo(15, 5, Artist.Victor_Manuel_Leza_Moreno));
            addCard(LotRCard.Location("Narrow Alleyway", string.Empty, setEscape, 2, 2)
                .WithTraits("City.")
                .WithText("Response: After the player travel here, choose a non-unique enemy engaged with a player and place it faceup under this location. While an enemy is under this location, that enemy is considered to be out of play.\r\nForced: After Narrow Alleyway leaves play, put each enemy under it into play, engaged with the first player.")
                .WithInfo(16, 2, Artist.Pavel_Kolomeyets));
            addCard(LotRCard.Location("Umbar Street", string.Empty, setEscape, 3, 3)
                .WithTraits("City.")
                .WithText("While Street of Umbar is the active location, each enemy gets -1 engagement cost for each progress token on the main quest.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(17, 2, Artist.Pavel_Kolomeyets));
            addCard(LotRCard.Location("Umbar Square", string.Empty, setEscape, 2, 3)
                .WithTraits("City.")
                .WithText("While Umbar Square is the active location, it gains: \"Response: After an enemy is defeated, place 1 progress on the main quest, bypassing the active location.\"\r\nTravel: Reveal the top card of the encounter deck to travel here.")
                .WithFlavor("The loss of Umbar was grievous to Gondor...\r\n-The Return of the King")
                .WithInfo(18, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Location("Port of Harad", string.Empty, setEscape, 254, 4)
                .WithTraits("City.")
                .WithText("X is the number of engaged enemies.\r\nTravel: Assign X damage among characters in play to travel here.")
                .WithFlavor("Often those on who suspicion fell had fled to Umbar and there joined the rebels...\r\n-The Return of the King")
                .WithInfo(19, 2, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Location("Haradrim Estate", string.Empty, setEscape, 3, 1)
                .WithTraits("City.")
                .WithText("While Haradrim Estate is in the staging area, progress cannot be placed here.\r\nTravel: Search the encounter deck and discard pile for a Harad enemy and put it into play engaged with the first player. Then, place 1 progress on the main quest, bypassing the active location. Shuffle the encounter deck.")
                .WithInfo(20, 2, Artist.Pavel_Kolomeyets));
            addCard(LotRCard.Treachery("Enemy Pursuit", string.Empty, setEscape)
                .WithText("When Revealed: Either remove all progress from the main quest, or assign X damage among characters in play. X is the number of progress tokens on the main quest.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(21, 2, Artist.Will_O_Brien));
            addCard(LotRCard.Treachery("Mirage", string.Empty, setCrossing)
                .WithTraits("Weather.")
                .WithText("When Revealed: Discard a the active location. Shuffle the encounter discard pile into the encounter deck and discard cards from the top until a location is discarded. Make that location the active location.")
                .WithInfo(22, 2, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.EncounterSideQuest("Seek Shade", string.Empty, setCrossing, 6)
                .WithFlavor("You must find a cool place to rest, out of the sun’s burning gaze...")
                .WithKeywords("Surge.")
                .WithText("Forced: At the end of the round, remove X progress from the main quest. X is the tens digit of the temperature.\r\nResponse: When Seek Shade is defeated, reduce the temperature by 10.")
                .WithInfo(23, 1, Artist.Victor_Garcia));
            addCard(LotRCard.Enemy("Carrion Bird", string.Empty, setCrossing, 40, 2, 2, 1, 3)
                .WithGeneric()
                .WithTraits("Creature.")
                .WithText("Carrior Birds gets -1 engagement cost for each damaged character in play.\r\nForced: After Carrion Bird engages you, discard a damaged character you control.")
                .WithInfo(24, 2, Artist.Dimitri_Bielak));
            addCard(LotRCard.Location("Burnt Sands", string.Empty, setCrossing, 2, 3)
                .WithTraits("Desert.")
                .WithText("While the temperature is 40 or higher, Burnt Sands gets +2 Threat.\r\nForced: After Burnt Sands becomes the active location, increase the temperature by 2.")
                .WithFlavor("...all seemed ruinous and dead, a desert burned and choked. -The Return of the King")
                .WithInfo(25, 4, Artist.Katy_Grierson));
            addCard(LotRCard.Location("Scorched Hamada", string.Empty, setCrossing, 254, 4)
                .WithTraits("Desert.")
                .WithText("X is the tens digit of the temperature.\r\nForced: After Scorched Hamada becomes the active location, assign X damage among characters in play.")
                .WithShadow("Shadow: Raise your threat by X, where X is the tens digit of the temperature.")
                .WithInfo(26, 2, Artist.Pavel_Kolomeyets));
            addCard(LotRCard.Location("Parched Wadi", string.Empty, setCrossing, 3, 3)
                .WithTraits("Desert.")
                .WithText("While Parched Wadi is in the staging area, each Creature enemy gets +1 Threat and +1 Attack.\r\nForced: After Parched Wadi becomes the active location, shuffle the encounter discard pile into the encounter deck and discard cards from the top until a Creature enemy is discarded. Add that enemy to the staging area.")
                .WithInfo(27, 2, Artist.Katy_Grierson));
            addCard(LotRCard.Enemy("Were-worm", string.Empty, setCrossing, 22, 255, 255, 255, 5)
                .WithTraits("Creature.")
                .WithText("X is the tens digit of the temperature.\r\nForced: After Were-worm engages you, it makes an immediate attack. (Do not deal it a shadow card.)")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the temperature is 40 or higher).")
                .WithInfo(28, 4, Artist.Dmitry_Prosvirnin));
            addCard(LotRCard.Treachery("Unbearable Heat", string.Empty, setCrossing)
                .WithTraits("Weather.")
                .WithText("When Revealed: Each player assigns X damage among characters he controls, where X is the tens digit of the temperature.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the tens digit of the temperature.")
                .WithInfo(29, 2, Artist.Kim_Sokol));
            addCard(LotRCard.Treachery("Scorching Sun", string.Empty, setCrossing)
                .WithTraits("Weather.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Increase the temperature by 4.")
                .WithShadow("Shadow: Either raise the temperature by 2, or return attacking enemy to the staging area after this attack.")
                .WithInfo(30, 2, Artist.Dimitri_Bielak));
            addCard(LotRCard.ObjectiveHero("Kahliel", setLongArm, 2, 2, 2, 3)
                .WithTraits("Harad.", "Noble.")
                .WithText("Response: At the beginning of the planning phase, add 1 resource to a hero's pool.\r\nIf Kahliel leaves play, you are eliminated from the game.")
                .WithInfo(31, 1, Artist.David_A_Nash));
            addCard(LotRCard.ObjectiveHero("Firyal", setLongArm, 3, 1, 2, 3)
                .WithTraits("Harad.", "Scout.")
                .WithText("Response: After Firyal commits to a quest, look at the top of the encounter deck. Then, you may discard that card.\r\nIf Firyal leaves play, you are eliminated from the game.")
                .WithInfo(32, 1, Artist.Tawny_Fritzinger));
            addCard(LotRCard.ObjectiveHero("Yazan", setLongArm, 2, 3, 1, 3)
                .WithTraits("Harad.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Response: After Yazan is declared as an attacker, deal 1 damage to a non-unique enemy in play. (Limit once per phase.)\r\nIf Yazan leaves play, you are eliminated from the game.")
                .WithInfo(33, 1, Artist.David_A_Nash));
            addCard(LotRCard.ObjectiveHero("Jubayr", setLongArm, 1, 2, 3, 3)
                .WithTraits("Harad.", "Warrior.")
                .WithKeywords("Sentinel.")
                .WithText("Response: After Jubayr is declared as a defender, discard 1 facedown shadow card from a non-unique enemy. (Limit once per phase.)\r\nIf Jubayr leaves play, you are eliminated from the game.")
                .WithInfo(34, 1, Artist.Colin_Boyer));
            addCard(LotRCard.Enemy("Sauron's Enforcers", string.Empty, setLongArm, 30, 255, 255, 255, 3)
                .WithTraits("Orc.", "Uruk.")
                .WithText("X is the sequence number on the main quest.\r\nForced: At the end of the round, assign X damage among characters in play.")
                .WithFlavor("Fierce and shrill rose the yells of the Orcs...\r\n-The Fellowship of the Ring")
                .WithInfo(35, 4, Artist.Ken_McCuen));
            addCard(LotRCard.Location("Southron Boma", string.Empty, setLongArm, 254, 4)
                .WithTraits("Forest.", "Village.")
                .WithText("X is the stage number of the main quest.\r\nTravel: Each player spends 1 resource to travel here.")
                .WithShadow("Shadow: If the defending character is an objective-hero, ready it and cancel all damage from this attack.")
                .WithInfo(36, 2, Artist.Pavel_Kolomeyets));
            addCard(LotRCard.Location("Village Hut", string.Empty, setLongArm, 2, 2)
                .WithTraits("Forest.", "Village.")
                .WithText("Response: After the players travel to Village Hut, the first player discards the top card of his deck. If that card is an ally, he puts it into play under his control, exhausted.\r\nTravel: Discard the top card of the encounter deck. If that card is an enemy, add it to the staging area.")
                .WithInfo(37, 2, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Treachery("Savage Attack", string.Empty, setLongArm)
                .WithText("When Revealed: Each player must choose: either discard the highest cost ally you control, or reveal an encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, reveal the top card of the encounter deck.")
                .WithInfo(38, 2, Artist.Dimitri_Bielak));
            addCard(LotRCard.Treachery("Overrun by Orcs", string.Empty, setLongArm)
                .WithText("When Revealed: Until the end of the phase, increase the total Threat in the staging area by X, where X is twice the stage number of the main quest.")
                .WithShadow("Shadow: Assign X damage among characters you control, where X is the stage number of the main quest.")
                .WithInfo(39, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.EncounterSideQuest("Southron Champion", string.Empty, setHaradSoldiers, 4)
                .WithText("When Revealed: Discard cards from the encounter deck until a Harad enemy is discarded. Add that enemy to the staging area and place a resource token on it. That enemy is \"the Champion.\" While this stage is in play, the Champion gets +2 Threat, +2 Attack, +2 Defense and gains: Immune to player card effects. The main quest stage cannot be defeated while the Champion is in play.\"\r\nThe champion cannot take damage unless there are at least 4 progress tokens here. This stage cannot be defeated while the champion is in play.")
                .WithInfo(40, 1, Artist.Alexandr_Elichev));
            addCard(LotRCard.Enemy("Southron Captain", string.Empty, setHaradSoldiers, 40, 2, 5, 3, 6)
                .WithUnique()
                .WithTraits("Harad.")
                .WithText("While Southron Captain is in the staging area, each other Harad enemy gets +1 Threat.\r\nWhile Southron Captain is engaged with you, each other Harad enemy engaged with you gets +1 Attack.")
                .WithInfo(41, 1, Artist.Ellyson_Ferrari_Lifante));
            addCard(LotRCard.Enemy("Southron Soldier", string.Empty, setHaradSoldiers, 32, 3, 3, 2, 5)
                .WithTraits("Harad.")
                .WithText("Forced: After Southron Soldier engages you, either remove 2 progress tokens from the main quest, or Southron Soldier makes an immediate attack.")
                .WithShadow("Shadow: Choose an enemy in the staging area. Engage it and deal it a shadow card.")
                .WithInfo(42, 3, Artist.Alexandr_Elichev)); 
            addCard(LotRCard.Enemy("Southron Archer", string.Empty, setHaradSoldiers, 36, 2, 4, 3, 4)
                .WithTraits("Harad.")
                .WithKeywords("Archery 2.")
                .WithText("Forced: After Southron Archer engages you, either remove 2 progress tokens from the main quest, or discard an ally you control.")
                .WithInfo(43, 4, Artist.J_Lonnee));
            addCard(LotRCard.Treachery("Nowhere to Hide", string.Empty, setHaradSoldiers)
                .WithText("When Revealed: The first player discards cards from the top of the encounter deck until an enemy is discarded, and puts that enemy into play engaged with him.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if it was engaged this round).")
                .WithInfo(44, 3, Artist.Kim_Sokol));
            addCard(LotRCard.EncounterSideQuest("In Enemy Territory", string.Empty, setHaradTerritory, 8)
                .WithFlavor("Alone in a hostile land, cut off from help, you struggle to find your bearings...")
                .WithKeywords("Surge.")
                .WithText("Each player cannot have more than 5 cards in his hand. (If you have more than 5, immediately choose and discard cards from hand until you have only 5.)\r\nResponse: When this stage is defeated, each player draws a card.")
                .WithInfo(45, 1, Artist.Will_O_Brien));
            addCard(LotRCard.Treachery("Injured Companion", string.Empty, setHaradTerritory)
                .WithText("When Revealed: Each player must choose: either raise your threat by 1 for each character you control, or discard a character you control.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise each player's threat by 1.")
                .WithInfo(46, 3, Artist.Ilich_Henriquez));
            addCard(LotRCard.Treachery("Enfeebled", string.Empty, setHaradTerritory)
                .WithText("When Revealed: Each player exhausts a character he controls. Until the end of the combat phase, exhausted characters cannot ready.")
                .WithShadow("Shadow: Until the end of the round, defending character cannot ready.")
                .WithInfo(47, 2, Artist.Adam_Duff));
            addCard(LotRCard.EncounterSideQuest("Find Water", string.Empty, setSands, 6)
                .WithFlavor("Your companions grow weary from thirst. They need water to drink.")
                .WithText("Characters cannot be readied by player card effects.\r\nResponse: When this stage is defeated, each player readies 1 hero he controls.")
                .WithInfo(48, 1, Artist.Marius_Bota));
            addCard(LotRCard.Location("Towering Dunes", string.Empty, setSands, 3, 4)
                .WithTraits("Desert.")
                .WithText("While Towering Dunes is in the staging area, progress cannot be placed on locations in the staging area not named Towering Dunes.\r\nForced: After Towering Dunes becomes the active location, reveal the top card of the encounter deck.")
                .WithInfo(49, 3, Artist.Katy_Grierson));
            addCard(LotRCard.Location("Desert Oasis", string.Empty, setSands, 2, 2)
                .WithTraits("Desert.")
                .WithText("While Desert Oasis is the active location, it gains: \"Response: When Desert Oasis is explored, heal 4 damage from among characters in play.\"\r\nForced: After Desert Oasis becomes the active location, each player exhausts a character he controls.")
                .WithInfo(50, 2, Artist.Katy_Grierson));
            addCard(LotRCard.Treachery("Sandstorm", string.Empty, setSands)
                .WithTraits("Weather.")
                .WithText("When Revealed: Each player either discards his hand, or assigns X damage among characters he controls. X is the number of cards in his hand.")
                .WithShadow("Shadow: Either discard the highest cost attachment you control, or assign X damage among characters you control where X is the number of attachments you control.")
                .WithInfo(51, 2, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Treachery("Heat Exhaustion", string.Empty, setSands)
                .WithText("When Revealed: Each player exhausts a character he controls and deals 1 damage to that character.")
                .WithShadow("Shadow: Exhaust a character you control.")
                .WithInfo(52, 2, Artist.Victor_Garcia));
            addCard(LotRCard.EncounterSideQuest("Craft Remedy", string.Empty, setCreatures, 6)
                .WithFlavor("Some of your companions have been poisoned! They need a remedy to counteract the venom.")
                .WithText("Treat the printed text box of each damaged character as if it were blank (except for Traits).\r\nResponse: When this is defeated, heal 1 damage from each character in play.")
                .WithInfo(53, 1, Artist.Ashley_Lange));
            addCard(LotRCard.Enemy("Sand Viper", string.Empty, setCreatures, 44, 4, 1, 1, 3)
                .WithTraits("Creature.")
                .WithText("Players cannot declare defenders against Sand Viper.\r\nForced: After the players travel to a location, Sand Viper engages the first player.")
                .WithFlavor("To some suddenly it seemed that they saw a snake coiling itself to strike.\r\n-The Two Towers")
                .WithInfo(54, 2, Artist.Piya_Wannachaiwong));
            addCard(LotRCard.Enemy("Giant Scorpion", string.Empty, setCreatures, 33, 3, 3, 2, 4)
                .WithTraits("Creature.")
                .WithText("Forced: After Giant Scorpion damages a character, that character cannot ready until the end of the round.")
                .WithShadow("Shadow: If this attack deals damage, the defending character cannot ready until the end of the round.")
                .WithInfo(55, 3, Artist.Dimitri_Bielak));
            addCard(LotRCard.Location("Jungle Trail", string.Empty, setJungle, 4, 4)
                .WithTraits("Forest.")
                .WithText("While Jungle Trail is the active location, each location in the staging area gets -1 Threat.\r\nTravel: Reveal the top card of the encounter deck to travel here.")
                .WithFlavor("The path itself was narrow and wound in and out among the trunks.\r\n-The Hobbit")
                .WithInfo(56, 2, Artist.Katy_Grierson));
            addCard(LotRCard.Location("Forest Clearing", string.Empty, setJungle, 3, 2)
                .WithTraits("Forest.")
                .WithText("Forced: When Forest Clearing is explored, discard the top card of the encounter deck. If that card is an enemy, add that enemy to the staging area.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithInfo(57, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Location("Dense Jungle", string.Empty, setJungle, 2, 3)
                .WithTraits("Forest.")
                .WithText("Forced: When Dense Jungle is explored, discard the top card of the encounter deck. If that card is a location, add that location to the staging area.")
                .WithShadow("Shadow: Discard a random card from your hand.")
                .WithInfo(58, 3, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Treachery("Overgrown", string.Empty, setJungle)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to the highest Threat location in the staging area without a copy of Overgrown attached. (Counts as a Condition attachment with the text: \"Attached location gets +1 Threat and gains 'Immune to player card effects.'\"")
                .WithInfo(59, 2, Artist.Kamila_Tzutenberg));
            addCard(LotRCard.EncounterSideQuest("Uruks of the Eye", string.Empty, setMordorOrcs, 5)
                .WithFlavor("The Uruks of Mordor attack with a savagery that is difficult to match.")
                .WithKeywords("Surge.")
                .WithText("Each Orc enemy in the staging area gets -5 engagement cost.\r\nEach Orc enemy engaged with a player gets +1 Threat.")
                .WithInfo(60, 1, Artist.Victor_Garcia));
            addCard(LotRCard.Enemy("Uruk Chieftain", string.Empty, setMordorOrcs, 50, 4, 5, 3, 6)
                .WithUnique()
                .WithTraits("Orc.", "Uruk.")
                .WithText("Cannot have player card attachments or be optionally engaged.\r\nWhile the engaged player is engaged with another Orc enemy, ~Uruk Chieftain cannot take damage.\r\nForced: At the end of the encounter phase, ~Uruk Chieftain engages the player engaged with the most non-unique Orc enemies.")
                .WithInfo(61, 1, Artist.Sam_Lamont));
            addCard(LotRCard.Enemy("Uruk of Mordor", string.Empty, setMordorOrcs, 35, 2, 4, 2, 4)
                .WithTraits("Orc.", "Uruk.")
                .WithText("Each ally with less Willpower than Uruk of Mordor's Threat cannot defend against Uruk of Mordor.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if its Threat is greater than the defending character's Willpower.")
                .WithInfo(62, 3, Artist.Diego_Gisbert_Llorens));
            addCard(LotRCard.Enemy("Uruk Warg-rider", string.Empty, setMordorOrcs, 40, 3, 3, 1, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithText("Uruk Warg-Rider gets +X Attack while attacking a character with less Willpower than Uruk Warg-rider's Threat. X is the difference.")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithInfo(63, 2, Artist.Piya_Wannachaiwong));
            addCard(LotRCard.Enemy("Mordor Warg", string.Empty, setMordorOrcs, 20, 2, 2, 2, 2)
                .WithTraits("Creature.")
                .WithText("When Revealed: Attach to an Orc enemy and return that enemy to the staging area. Limit 1 per enemy. (Counts as a Mount attachment with the text: \"Attached enemy gets +2 Threat, +2 Attack, +2 Defense and +2 hit points.\r\nForced: When attached enemy leaves play, add Mordor Warg to the staging area.\"")
                .WithInfo(64, 2, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Treachery("Fear of Mordor", string.Empty, setMordorOrcs)
                .WithText("When Revealed: Each ally in play gets -1 Willpower, -1 Attack, and -1 Defense until the end of the round.")
                .WithShadow("Shadow: If attacking enemy's Threat is greater than the defending character's Willpower, it makes an additional attack after this one.")
                .WithInfo(65, 2, Artist.Mariusz_Gandzel));
            addCard(LotRCard.Quest("Stranded in Umbar", string.Empty, 1, 1, setEscape, 15)
                .WithFlavor("At the end of a long sea-voyage, you have reached the port of Umbar but your ship was dashed upon the rocks. Though you completed the quest that brought you to Harad, it has left you stranded in enemy territory, far from help.")
                .WithText("Setup: Add “Seize them!” to the staging area. Each player adds 1 different location to the staging area and puts 1 copy of ~Umbar Sentry into play engaged with him. Shuffle the encounter deck.")
                .WithOppositeFlavor("Alarm bells ring from high watchtowers and the city guard shouts for you to lay down your arms and surrender. You must run or be captured!")
                .WithOppositeText("This stage cannot have more than 15 progress tokens on it.\r\nWhile at least 1 player is engaged with an enemy, the players cannot defeat this stage.")
                .WithInfo(66, 1, Artist.Nikolas_Hagialas));
            addCard(LotRCard.Quest("Flee the City", string.Empty, 1, 2, setEscape, 15)
                .WithFlavor("The whole of Umbar is astir, and the Southrons chase you through the streets. If you cannot escape the city quickly, you are certain to be taken prisoner.")
                .WithText("When Revealed: End the current phase. Shuffle the encounter discard pile into the encounter deck. Starting with the first player, each player discards cards from the top of the encounter deck until he discards an enemy, and puts that enemy into play engaged with him.")
                .WithOppositeText("This stage cannot have more than 15 progress tokens on it.\r\nForced: At the beginning of the quest phase, if any player is not engaged with an enemy, discard cards from the top of the encounter deck until an enemy is discarded and add it to the staging area.\r\nWhile at least 1 player is engaged with an enemy, the players cannot defeat this stage. If the players defeat this stage, they win the game.")
                .WithInfo(67, 1, Artist.Joshua_Cairos));
            addCard(LotRCard.Quest("The Desert of Harad", string.Empty, 2, 1, setCrossing, 8)
                .WithFlavor("You have escaped from Umbar and thrown off your pursuers by fleeing into the desert, but many barren miles lie between you and the other side. To turn back is to walk into the arms of the Haradrim, so you set out on a dangerous desert crossing.")
                .WithText("Setup: Each player searches the encounter deck for a copy of Burnt Sands and adds it to the staging area. Shuffle the encounter deck. Place the heat tracker next to the quest deck and set the temperature to 10.")
                .WithOppositeFlavor("As the sun climbs into the sky, you can feel the rising heat begin to take its toll on you...")
                .WithOppositeText("Forced: After an ally enters play, either exhaust it, or deal 1 damage to it.\r\nForced: At the end of the round, increase the temperature by 4.\r\nIf the temperature is 60 or higher, the players lose the game.")
                .WithInfo(68, 1, Artist.Kim_Sokol));
            addCard(LotRCard.Quest("Under the Merciless Sun", string.Empty, 2, 2, setCrossing, 14)
                .WithFlavor("You trudge across the barren desert with the blazing sun overhead and deadly creatures underfoot, but nothing is more dangerous to you than your lack of water.")
                .WithText("When Revealed: Increase the temperature by 2. Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithOppositeFlavor("If you cannot make it across the desert soon, you are certain to die of thrist...")
                .WithOppositeText("Forced: At the end of the round, increase the temperature by 4. Then, each player assigns X damage among characters he controls, where X is the tens digit of the temperature.\r\nIf the temperature is 60 or higher, the players lose the game.")
                .WithInfo(69, 1, Artist.Victor_Garcia));
            addCard(LotRCard.Quest("Beasts of Legend", string.Empty, 2, 3, setCrossing, 16)
                .WithFlavor("You have wandered through the trackless desert and discovered the legendary nesting grounds of the wild Were-worms. The beasts rear up and circle to attack. You must drive them off or meet your end upon the desert sands.")
                .WithText("When Revealed: Increase the temperature by 2. Each player searches the encounter deck, discard pile, and victory display for a Were-worm and adds it to the staging area, if able. Shuffle the encounter deck.")
                .WithOppositeText("During the quest phase, add X Threat to the total Threat in the staging area, where X is the tens digit of the temperature.\r\nForced: At the end of the round, increase the temperature by 4.\r\nWhile at least 1 Were-worm is in play, the players cannot defeat this stage. If the players defeat this stage, they win the game. If the temperature is 60 or higher, the players lose the game.")
                .WithInfo(70, 1, Artist.Dimitri_Bielak));
            addCard(LotRCard.Quest("Surprise Attack", string.Empty, 3, 1, setLongArm, 0)
                .WithFlavor("A tribe of Haradrim has rescued you, but their village is attacked by Orcs!")
                .WithText("Setup: Set Uruk Chieftain aside, out of play. Each player adds 1 copy of Sauron’s Enforcers to the staging area. Move each hero to the staging area. Each player takes control of an objective-hero and adds 2 resources to its resource pool. Remove each remaining objective-hero from the game. For the remainder of the game, heroes in the staging area are in play but under no player’s control, immune to player card effects, and their text boxes are considered to be blank.")
                .WithOppositeText("Damage from undefended attacks must be dealt to a hero in the staging area, if able.\r\nThe first card each player plays each phase does not require a resource match.\r\nForced: After placing progress from questing successfully, each player chooses a hero he owns in the staging area and, takes control of that hero, and exhausts it. Advance to stage 2A.")
                .WithInfo(71, 1, Artist.Alexandr_Elichev));
            addCard(LotRCard.Quest("Find the Others", string.Empty, 3, 2, setLongArm, 5)
                .WithFlavor("Still weary from the long journey across the desert, your companions are somewhere in the village. In your weakened state you are no match for the attacking Orcs. Your only chance to survive is to flee into the jungle, but you will not abandon your friends.")
                .WithOppositeText("Damage from undefended attacks must be dealt to a hero in the staging area, if able.\r\nThe first card each player plays each phase does not require a resource match.\r\nForced: When this stage is defeated, each player chooses a hero he owns in the staging area, takes control of that hero, and exhausts it.")
                .WithInfo(72, 1, Artist.Joshua_Cairos));
            addCard(LotRCard.Quest("Free the Captives", string.Empty, 3, 3, setLongArm, 10)
                .WithFlavor("Orcs have seized your friends and are now dragging them away as captives.")
                .WithText("When Revealed: Each player searches the encounter deck and discard pile for an Orc enemy and adds it to the staging area. Shuffle the encounter deck. Attach each hero in the staging area to a different Orc enemy in the staging area. Each hero attached to an enemy is guarded by that enemy. Guarded heroes are under no player’s control, immune to player card effects, and their text boxes are considered to be blank.")
                .WithOppositeText("While an enemy is guarding a hero it gets +1 Threat, +1 Attack, +1 Defense and is immune to player card effects.\r\nForced: When the enemy guarding a hero is defeated, that hero’s owner takes control of that hero and exhausts it.\r\nThis stage cannot be defeated while an enemy is guarding a hero.")
                .WithInfo(73, 1, Artist.Nikolas_Hagialas));
            addCard(LotRCard.Quest("Escape into the Jungle", string.Empty, 3, 4, setLongArm, 15)
                .WithFlavor("The Orcs run rampant through the Haradrim boma. Amidst the chaos, you see an opportunity to escape but a large Uruk chieftain bars your way. You will have to defeat the chieftain in order to get past him.")
                .WithText("When Revealed: Add Uruk Chieftain to the staging area. Shuffle the encounter discard pile into the encounter deck and reveal 1 encounter card per player.")
                .WithOppositeText("Uruk Chieftain cannot take non-combat damage.\r\nEach non-unique Orc enemy gets -10 engagement cost.\r\nForced: After Uruk Chieftain engages a player, it makes an immediate attack.\r\nThe players cannot defeat this stage while Uruk Chieftain is in play. If the players defeat this stage, they win the game.")
                .WithInfo(74, 1, Artist.David_A_Nash));
        }
    }
}