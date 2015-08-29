using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheLandOfShadow : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Land of Shadow";
            Abbreviation = "TLoS";
            Number = 1006;
            SetType = Models.SetType.Saga_Expansion;
            Cycle = "The Lord of the Rings";

            Cards.Add(new Card()
            {
                Title = "Frodo Baggins",
                IsUnique = true,
                ImageType = Models.ImageType.Jpg,
                CardType = CardType.Hero,
                Sphere = Models.Sphere.Fellowship,
                ThreatCost = 0,
                Willpower = 2,
                Attack = 1,
                Defense = 2,
                HitPoints = 2,
                Traits = new List<string> { "Hobbit.", "Ring-bearer." },
                Text = "Action: Spend 1 Fellowship resource and exhaust The One ~Ring to give Frodo Baggins +2 Willpower and +2 Attack until the end of the round.",
                FlavorText = "\"It's my doom, I think, to go to that Shadow yonder, so that a way will be found.\" -The Two Towers",
                Number = 1,
                Quantity = 1,
                Artist = Artist.Melanie_Maier
            });
            Cards.Add(Card.Hero("Faramir", "", Sphere.Leadership, 11, 2, 2, 2, 5)
                .WithTraits("Gondor.", "Noble.", "Ranger.")
                .WithKeywords("Ranged.")
                .WithText("Response: After you engage an enemy, ready an ally you control. (Limit once per phase.)")
                .WithFlavor("\"That will be the Captain: he can master both beasts and men\" -Beregond, The Return of the King")
                .WithInfo(2, 1, Artist.Jason_Cheeseman_Meyer));
            Cards.Add(Card.Hero("Damrod", "", Sphere.Lore, 9, 2, 2, 1, 4)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Reduce the cost of the first Trap card you play each round by 1 (to a minimum of 0).\r\nResponse: After a Trap card you control is attached to an enemy, draw 1 card.")
                .WithFlavor("\"See! Some of the Southrons have broken from the trap and are flying from the road.\" -The Two Towers")
                .WithInfo(3, 1, Artist.Joshua_Cairos));
            Cards.Add(Card.Ally("Anborn", "", Sphere.Leadership, 4, 1, 3, 1, 3)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After an enemy is added to the staging area, exhaust Anborn to give that enemy +5 enagement cost until the end of the round. Then, deal 1 damage to that enemy.")
                .WithFlavor("\"Now I have him at arrow-point.\" -The Two Towers")
                .WithInfo(4, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Ally("Mablung", "", Sphere.Lore, 2, 2, 1, 0, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After Mablung enters play, choose an enemy to get +5 engagement cost until the end of the round. Then, you may engage that enemy, or return it to the staging area.")
                .WithFlavor("\"But still we will not sit idle and let Him do all as He would.\" -The Two Towers")
                .WithInfo(5, 3, Artist.Beth_Sobel));
            Cards.Add(Card.Ally("Skinbark", "", Sphere.Tactics, 3, 0, 4, 2, 3)
                .WithTraits("Ent.")
                .WithText("Cannot have restricted attachments. Enters play exhausted.\r\nWhile Skinbark is attacking alone against an Orc enemy, that enemy does not count its Defense.")
                .WithFlavor("\"He was wounded by the Orcs, and many of his folk and his tree-herds have been murdered and destroyed.\" -Treebeard, The Two Towers")
                .WithInfo(6, 3, Artist.Dimitri_Bielak));
            Cards.Add(Card.Ally("Gamling", "", Sphere.Spirit, 3, 1, 1, 2, 2)
                .WithTraits("Rohan.", "Warrior.")
                .WithText("Response: After a Rohan ally you control is discarded from play, exhaust Gamling to return that ally to your hand.")
                .WithFlavor("\"...we have a thousand fit to fight on foot,\" said Gamling, an old man, the leader of those that watched the Dike. -The Two Towers")
                .WithInfo(7, 3, Artist.Melanie_Maier));
            Cards.Add(Card.Attachment("Staff of Lebethron", "", Sphere.Leadership, 1)
                .WithTraits("Item.")
                .WithText("Attach to a Gondor or Hobbit hero. Restricted.\r\nResponse: After attached hero exhausts to defend an attack from an enemy with engagement cost higher than your threat, exhaust Staff of Lebethron to discard a shadow card from that enemy.")
                .WithFlavor("\"They are made of the fair tree lebethron, beloved of the woodwrights of Gondor...\" -Faramir, The Two Towers")
                .WithInfo(8, 3, Artist.Kara_Williams));
            Cards.Add(Card.Attachment("Ambush", "", Sphere.Lore, 2)
                .WithTraits("Condition.", "Trap.")
                .WithText("Play Ambush into the staging area unattached. If unattached, attach Ambush to the next eligible enemy that enters the staging area.\r\nCombat Action: The engaged player discards Ambush to declare an attack against the attached enemy.")
                .WithFlavor("\"But we have a new errand on this journey: we come to ambush the Men of Harad.\" -Mablung, The Two Towers")
                .WithInfo(9, 3, Artist.Cristina_Vela));
            Cards.Add(Card.Attachment("Snowmane", "", Sphere.Spirit, 1)
                .WithUnique()
                .WithTraits("Mount.")
                .WithText("Attach to a Rohan hero. Restricted.\r\nIf attached hero is Theoden, Snowmane loses the restricted keyword.\r\nResponse: After attached hero quests successfully, ready attached hero.")
                .WithFlavor("Suddenly the king cried to Snowmane and the horse sprang away. -The Return of the King")
                .WithInfo(10, 3, Artist.Julepe));
            Cards.Add(Card.Event("Taste it Again!", "", Sphere.Leadership, 1)
                .WithText("Response: After a hero you control defends an attack made by an enemy with engagement cost higher than your threat, ready that hero. Until the end of the phase, that hero gets +2 Attack while attacking that enemy.")
                .WithFlavor("\"We're going on; but we'll settle with you first. Come on, and taste it again!\" -Sam Gamgee, The Two Towers")
                .WithInfo(11, 3, Artist.Piya_Wannachaiwong));
            Cards.Add(Card.Event("In the Shadows", "", Sphere.Lore, 3)
                .WithText("Lower the cost to play In the Shadows by 1 for each Hobbit or Ranger hero you control.\r\nCombat Action: Each enemy engaged with you with engagement cost higher than your threat gets -1 Attack and -1 Defense until the end of the phase.")
                .WithFlavor("He could see them stealing up the slopes, singly or in long files, keeping always to the shade of grove or thicket... -The Two Towers")
                .WithInfo(12, 3, Artist.Piya_Wannachaiwong));
            Cards.Add(Card.Event("Speak Your Promise!", "", Sphere.Fellowship, 1)
                .WithText("Action: Ready the Ring-bearer to choose an enemy engaged with you. If the Ring-bearer's Willpower is greater than that enemy’s Threat, lower its Attack and Defense by the difference until the end of the phase.")
                .WithFlavor("For a moment it appeared to Sam that his master had grown and Gollum had shrunk... -The Two Towers")
                .WithInfo(13, 3, Artist.Cristina_Vela));
            Cards.Add(Card.Event("Brace of Coneys", "", Sphere.Neutral, 0)
                .WithBoon()
                .WithText("Play only if you control the Ring-bearer.\r\nPlanning Action: Add Brace of Coneys to the victory display to (choose 2): heal up to 2 damage from a hero, add 2 resources to a hero's pool, draw 2 cards, or reduce a player's threat by 2.")
                .WithFlavor("\"'Sméagol always helps,' he said. 'He has brought rabbits, nice rabbits.'\" —Gollum, The Two Towers")
                .WithInfo(14, 4, Artist.Cristina_Vela));

            Cards.Add(Card.Enemy("Dead Things", "", "The Passage of the Marshes", 32, 3, 4, 2, 5)
                .WithTraits("Undead.")
                .WithText("The engaged player cannot reduce his threat.\r\nForced: After Dead Things attacks and destroys a character, the defending player raises his threat by 3.")
                .WithShadow("Shadow: Raise your threat by 1 for each Undead enemy engaged with you.")
                .WithInfo(17, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Enemy("Candle-bearer", "", "The Passage of the Marshes", 36, 3, 5, 2, 6)
                .WithTraits("Undead.")
                .WithText("The engaged player cannot reduce his threat.\r\nForced: After Candle-bearer attacks and destroys a character, it cannot take damage until the end of the round.")
                .WithShadow("Shadow: Until the end of the round, attacking enemy cannot take damage.")
                .WithInfo(18, 2, Artist.Michael_Wolmarans));
            Cards.Add(Card.Location("Evil-smelling Fens", "", "The Passage of the Marshes", 3, 4)
                .WithTraits("Marsh.")
                .WithKeywords("Mire 3.")
                .WithText("Forced: When Evil-smelling Fens is discarded by the Mire keyword, deal 1 damage to each character.\r\nTravel: Raise each player’s threat by 1 to travel here.")
                .WithShadow("Shadow: Deal 1 damage to defending character.")
                .WithInfo(19, 3, Artist.Michael_Wolmarans));

            Cards.Add(Card.Treachery("Creeping Marshes", "", "The Passage of the Marshes")
                .WithKeywords("Surge.", "Doomed 1.")
                .WithText("When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: At the end of the refresh phase, place 1 mire token on each location in the staging area. Then, discard Creeping Marshes.\")")
                .WithInfo(24, 1, Artist.Carlos_Palma_Cruchaga));
            Cards.Add(Card.Treachery("Bitter Reek", "", "The Passage of the Marshes")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either raise your threat by 1 for each character you control that is committed to the quest, or deal 1 damage to each character committed to the quest.")
                .WithShadow("Shadow: Raise your threat by the attacking enemy’s Threat.")
                .WithInfo(25, 2, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Treachery("A Fell Light", "", "The Passage of the Marshes")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Put the topmost Undead enemy in the discard pile into play engaged with you. Each Undead enemy engaged with you makes an immediate attack.")
                .WithShadow("Shadow: Put the topmost Undead enemy in the discard pile into play engaged with you.")
                .WithInfo(26, 2, Artist.Cristina_Vela));

            Cards.Add(Card.Enemy("Captain of Harad", "", "Journey to the Cross-roads", 38, 4, 4, 3, 5)
                .WithTraits("Harad.")
                .WithText("Forced: After Captain of Harad engages you, each Harad enemy gets +1 [Attack] and -10 engagement cost until the end of the round.")
                .WithShadow("Shadow: If this attack destroys a character, return attacking enemy to the staging area.")
                .WithInfo(29, 2, Artist.Tiziano_Baracchi));

            Cards.Add(Card.Treachery("Dark Lord's Summons", "", "Journey to the Cross-roads")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either place the lowest Attack Harad enemy engaged with you facedown under The Black Gate, or reveal the top card from under The Cross-roads and put it into play engaged with you.")
                .WithFlavor("\"Always more people coming to Mordor. One day all the peoples will be inside.\" —Gollum, The Two Towers")
                .WithInfo(36, 3, Artist.Jon_Bosco));

            Cards.Add(Card.Treachery("Arrows Thick in the Air", "", "Journey to the Cross-roads")
                .WithText("When Revealed: Until the end of the round, each Harad enemy gains Archery 2.")
                .WithShadow("Shadow: Either place attacking enemy facedown under The Black Gate after this attack, or it makes an additional attack against you after this one.")
                .WithInfo(39, 2, Artist.Julepe));

            Cards.Add(Card.Location("Cleft of Cirith Ungol", "", "Shelob's Lair", 4, 4)
                .WithTraits("Mountain.")
                .WithText("Immune to player card effects.\r\nWhile The Cleft of Cirith Ungol is in the victory display, Shelob gets +2 Attack, loses the Indestructible keyword, and gains: \"Shelob engages the first player.\"\r\nTravel: Place 1 resource on Shelob to travel here.")
                .WithFlavor("The Cleft, Cirith Ungol, was before him, a dim notch in the black ridge... —The Two Towers")
                .WithInfo(45, 1, Artist.Jokubas_Uoginitas));

            Cards.Add(Card.Location("Deep Dark Passage", "", "Shelob's Lair", 2, 5)
                .WithTraits("Underground.")
                .WithText("While Deep Dark Passage is in the staging area, it gains: \"Forced: When any amount of progress would be placed on a location in the staging area, reduce that amount by 1.\"\r\nTravel: Exhaust Smeagol to travel here.")
                .WithFlavor("Not since the lightless passages of Moria had Frodo or Sam known such darkness, and if possible here it was deeper and denser. —The Two Towers")
                .WithInfo(48, 3, Artist.Davis_Engel));
            Cards.Add(Card.Location("Den of Night", "", "Shelob's Lair", 1, 4)
                .WithTraits("Underground.")
                .WithText("While Den of Night is in the staging area, it gains: \"Forced: After a ‘When Revealed’ effect is canceled, place 1 resource on Shelob.\"\r\nTravel: Place 1 resource on Shelob to travel here.")
                .WithFlavor("Here was some opening in the rock far wider than any they had yet passed; and out of it came a reek so foul, and a sense of lurking malice so intense, that Frodo reeled. —The Two Towers")
                .WithInfo(49, 3, Artist.Davis_Engel));

            Cards.Add(Card.Objective("A Heavy Burden", "", "Shelob's Lair")
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to the Ring-bearer.\r\nForced: At the end of the planning phase, either raise each player's threat by 1, or exhaust the Ring-bearer.")
                .WithFlavor("\"It's heavy on me, Sam lad, very heavy. I wonder how far I can carry it?\" —Frodo Baggins, The Two Towers")
                .WithInfo(52, 1, Artist.Kara_Williams));

            Cards.Add(Card.Treachery("Call of the Ring", "", "Nazgûl")
                .WithText("When Revealed: The first player must choose: either search the encounter deck, discard pile, and victory display for a Nazgul enemy and add it to the staging area, or exhaust The One Ring and reveal the top card of the encounter deck.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(54, 2, Artist.Melanie_Maier));

            Cards.Add(Card.Location("Blocked Tunnel", "", "The Great Spider", 3, 9)
                .WithTraits("Underground.")
                .WithText("When Revealed: Make Blocked Tunnel the active location, returning any previous active location to the staging area.\r\nAction: Exhaust a character with a Weapon attachment to place 3 progress on Blocked Tunnel. (Any player may trigger this effect.)")
                .WithFlavor("Across the width and height of the tunnel a vast web was spun, orderly as the web of some huge spider... —The Two Towers")
                .WithInfo(59, 2, Artist.Julepe));

            Cards.Add(Card.Quest("Across the Marshes", "", 10, 2, "The Passage of the Marshes", 12)
                .WithFlavor("The Hobbits soon found that what had looked like one vast fen was really an endless network of pools, and soft mires, and winding half-strangled watercourses. Among these a cunning eye and foot could thread a wandering path. —The Two Towers")
                .WithText("When Revealed: If the number of locations in the staging area is less than the number of players in the game, discard cards from the encounter deck until a location is discarded. Add the discarded location to the staging area.")
                .WithOppositeText("Progress cannot be placed on locations in the staging area.\r\nThe players cannot advance unless the first player controls Smeagol and there are at least 4 locations in the victory display.\r\nForced: At the end of the staging step, if the number of locations in the staging area is less than the number of players in the game, reveal the top card of the encounter deck.")
                .WithInfo(65, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Quest("Don't Look at the Lights!", "", 10, 3, "The Passage of the Marshes", 24)
                .WithFlavor("For a moment the water below him looked like some window, glazed with grimy glass, through which he was peering. Wrenching his hands out of the bog, he sprang back with a cry. \"There are dead things, dead faces in the water,\" he said with horror. —The Two Towers")
                .WithText("When Revealed: Each player searches the encounter deck and discard pile for an Undeadenemy and puts it into play engaged with him. Shuffle all locations in the victory display into the encounter deck.")
                .WithOppositeFlavor("Gollum laughed. \"The Dead Marshes, yes, yes: that is their names,\" he cackled. \"You should not look in when the candles are lit.\" —The Two Towers")
                .WithOppositeText("While any player is engaged with an Undead enemy, progress cannot be placed on this stage.\r\nThe players cannot defeat this stage unless the first player controls Sméagol. If the players defeat this stage, they win the game.")
                .WithInfo(66, 1, Artist.Cristina_Vela));

            Cards.Add(Card.Quest("Ambush the Men of Harad", "", 11, 1, "Journey to the Cross-roads", 20)
                .WithFlavor("\"These cursed Southrons come now marching up the ancient roads to swell the hosts of the Dark Tower. Yea, up the very roads that craft of Gondor made.\" —Mablung, The Two Towers")
                .WithText("Setup: Add The Black Gate and The Cross-roads to the staging area. Shuffle the Harad encounter set and place it facedown under The Cross-roads. Each player, except for the first player, searches the encounter deck for a different non-unique location and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("\"The road may pass, but they shall not!\"\r\n—Mablung, The Two Towers")
                .WithOppositeText("Forced: At the beginning of the quest phase, reveal the top facedown card from under The Cross-roads and add it to the staging area.\r\nThe players cannot defeat this stage while The Cross-roads is in play. When The Cross-roads is explored, the players win the game.")
                .WithInfo(68, 1, Artist.Julepe));

/*



Exhalation of Decay 
Type: Treachery 
Encounter Set: Shelob’s Lair 
When Revealed: Each player discards 1 random card from his hand and 1 non-objective attachment he controls. 
Shadow: Discard a non-objective attachment you control. 
“Ugh! That smell!” he said. “It’s getting stronger and stronger.” —The Two Towers 
Set: The Land of Shadow Number: 50 
Quantity: 2 
Illustrator: Dimitri Bielak


Fierce Southrons 
Type: Treachery 
Encounter Set: Journey to the Cross-roads 
Peril.
When Revealed: Either place the lowest [Threat] Harad enemy in the staging area facedown under The Black Gate and reveal an additional encounter card, or each enemy in the staging area makes an immediate attack against you. 

“Not nice; very cruel wicked Men they look. Almost as bad as Orcs...” —Gollum, The Two Towers 
Set: The Land of Shadow Number: 38 
Quantity: 2 
Illustrator: Crystal Sully
Foothills of Ephel Duath 
Type: Location 
Encounter Set: Journey to the Cross-roads 
Threat: 3 Quest Points: 6 
Hills. 
While Foothills of Ephel Duath is the active location, each Harad enemy gets -1 [Threat].
Travel: The first player engages an enemy in the staging area to travel here. 

“And they go ever more heedlessly, we learn, thinking that the power of their new master is great enough, so that the mere shadow of His hills will protect them.” —Mablung, The Two Towers 
Set: The Land of Shadow Number: 33 
Quantity: 3 
Illustrator: Dimitri Bielak


Gollum 
Type: Enemy 
Encounter Set: Gollum 
Threat Threshold: 30 
Threat: 2 Attack: 2 Defense: 2 Hit Points: 5 
Gollum. 
Immune to non-[Fellowship] player card effects. Gollum engages the first player.
Forced: After Gollum engages the first player during the refresh phase, he makes an immediate attack.
Forced: When Gollum is defeated, flip him to Smeagol exhausted. 
Set: The Land of Shadow Number: 75 
Quantity: 1 
Illustrator: Lukasz Jaskolski


Groping Dead 
Type: Enemy 
Encounter Set: The Passage of the Marshes 
Threat Threshold: 24 
Threat: 2 Attack: 3 Defense: 1 Hit Points: 4 
Undead. 
The engaged player cannot reduce his threat.
Forced: After Groping Dead attacks and destroys a character, place 1 mire token on the active location.
Shadow: If this attack destroys a character, place 1 mire token on the active location. 
Set: The Land of Shadow Number: 16 
Quantity: 3 
Illustrator: Crystal Sully


Haradrim Archer 
Type: Enemy 
Encounter Set: Harad 
Threat Threshold: 42 
Threat: 0 Attack: 3 Defense: 1 Hit Points: 5 
Harad. 
Archery X. X is the number of players in the game.
Forced: After Haradrim Archer engages you, assign X damage among characters you control. 
Shadow: Deal 1 damage to the defending character. 
Set: The Land of Shadow Number: 58 
Quantity: 3 
Illustrator: Melanie Maier


Haradrim Soldier 
Type: Enemy 
Encounter Set: Harad 
Threat Threshold: 40 
Threat: 2 Attack: 4 Defense: 3 Hit Points: 4 
Harad. 
Forced: After Haradrim Soldier engages you, it makes an immediate attack. 
Shadow: Attacking enemy makes an additional attack against you after this one. 
Set: The Land of Shadow Number: 57 
Quantity: 3 
Illustrator: Jon Bosco


Haunted Mere 
Type: Location 
Encounter Set: The Passage of the Marshes 
Threat: 4 Quest Points: 5 
Marsh. 
Mire 2. Forced: When Haunted Mere is discarded by the Mire keyword, search the encounter deck and discard pile for an Undead enemy, reveal it, and add it to the staging area. Shuffle the encounter deck.
Travel: Exhaust Smeagol to travel here. 

“They lie in all the pools, pale faces, deep deep under the dark water.” —Frodo, The Two Towers 
Set: The Land of Shadow Number: 21 
Quantity: 3 
Illustrator: Álvaro Calvo Escudero


Henneth Annun 
Type: Location 
Encounter Set: Journey to the Cross-roads 
Threat: 1 Quest Points: 1 
Refuge. 
While Henneth Annun is the active location, skip both the encounter phase and combat phase, and ignore the Forced effects on stage 1B and The Black Gate.
Forced: After Henneth Annun becomes the active location, return each engaged enemy to the staging area. 

“This is the Window of the Sunset, Henneth Annûn, fairest of all the falls of Ithilien...” —Faramir, The Two Towers 
Set: The Land of Shadow Number: 31 
Quantity: 1 
Illustrator: Julepe


Hills of Ithilien 
Type: Location 
Encounter Set: Journey to the Cross-roads 
Threat: 2 Quest Points: 4 
Forest. Hills. 
While Hills of Ithilien is the active location, it gains: “Forced: After a player engages a Harad enemy, deal 1 damage to that enemy.”
Shadow: Discard a non-objective attachment you control. 
Set: The Land of Shadow Number: 35 
Quantity: 3 
Illustrator: Julepe


Ithilien Woods 
Type: Location 
Encounter Set: Journey to the Cross-roads 
Threat: 2 Quest Points: 3 
Forest. 
While Ithilien Woods is the active location, it gains: “Forced: After a player engages a Harad enemy, he readies a character he controls.”
Travel: The first player reveals an encounter card to travel here. 

Ithilien, the garden of Gondor now desolate kept still a dishevelled dryad loveliness. —The Two Towers 
Set: The Land of Shadow Number: 34 
Quantity: 2 
Illustrator: Julepe


Journey to the Cross-roads 
Type: Campaign Side A 
Encounter Set: Journey to the Cross-roads 
You are playing campaign mode.
Setup: Each player must choose: either add 1 resource to each of his heroes’ pools, or shuffle 1 copy of Brace of Coneys into his deck. Remove each burden with the following burden set icons from the encounter deck and each player’s deck: Helm’s Deep, The Road to Isengard
So they passed into the northern marches of that land that Men once called Ithilien, a fair country of climbing woods and swift-falling streams. —The Two Towers 

Set: The Land of Shadow Number: 69 
Quantity: 1 
Illustrator: Julepe


Lurking Malice 
Type: Treachery 
Encounter Set: The Great Spider 
Peril. Surge.
When Revealed: Either place 1 resources on Shelob, or she makes an immediate attack against you. 
Shadow: If attacking enemy is Shelob, place 1 resource on her. Then, she gets +1 [Attack] for each resource on her. 
Set: The Land of Shadow Number: 61 
Quantity: 3 
Illustrator: Michael Wolmarans

Man of Harad 
Type: Enemy 
Encounter Set: Journey to the Cross-roads 
Threat Threshold: 36 
Threat: 1 Attack: 3 Defense: 1 Hit Points: 4 
Harad. 
Surge. Archery 1.
Forced: After Man of Harad engages you, discard 1 random card from your hand. 
Shadow: Discard 1 random card from your hand. 
Set: The Land of Shadow Number: 28 
Quantity: 4 
Illustrator: Beth Sobel


Many Openings 
Type: Treachery 
Encounter Set: Shelob’s Lair 
When Revealed: Each location in the staging area gets +1 [Attack] until the end of the round. If the number of locations in the staging area is less than the number of players in the game, reveal an additional encounter card. 
Shadow: Attacking enemy gets +X [Attack], where X is the active location’s [Threat]. 
Set: The Land of Shadow Number: 51 
Quantity: 2 
Illustrator: Jokubas Uogintas


Marching Up the Road 
Type: Treachery 
Encounter Set: Journey to the Cross-roads 
When Revealed: Each player must either return an enemy engaged with him to the staging area, or search the encounter deck for a Harad enemy and put it into play engaged with him. 
Shadow: Attacking enemy gets +1 [Attack]. If this attack destroys a character, place attacking enemy facedown under The Black Gate. 
Set: The Land of Shadow Number: 37 
Quantity: 2 
Illustrator: Yoann Boissonnet


Morgul Orc 
Type: Enemy 
Encounter Set: Shelob’s Lair 
Threat Threshold: 35 
Threat: 1 Attack: 3 Defense: 2 Hit Points: 3 
Orc. Uruk. 
Peril.
When Revealed: Either discard 1 random card from your hand, or reveal an additional encounter card.
Shadow: If this attack destroys a character, discard 1 random card from your hand. 
Set: The Land of Shadow Number: 41 
Quantity: 4 
Illustrator: Michael Wolmarans


Morgul Vale 
Type: Location 
Encounter Set: Shelob’s Lair 
Threat: 4 Quest Points: 2 
Vale. 
Immune to player card effects.
Forced: After Morgul Vale is explored, search the encounter deck and discard pile for a Morgul Wraith and add it to the staging area. Shuffle the encounter deck. Then, the first player must either exhaust The One Ring, or discard 1 random card from each player’s hand. 
Set: The Land of Shadow Number: 43 
Quantity: 1 
Illustrator: Chris Rahn


Morgul Wraith 
Type: Enemy 
Encounter Set: Nazgul 
Threat Threshold: 45 
Threat: 4 Attack: 5 Defense: 4 Hit Points: 9 
Nazgul. 
Cannot have non-Morgul attachments.
While The One Ring is exhausted, Morgul Wraith gets -30 engagement cost and gains: “Immune to player card effects.” 

“They see everything, everything. Nothing can hide from them.” —Gollum, The Two Towers 
Set: The Land of Shadow Number: 53 
Quantity: 2 
Illustrator: Lukasz Jaskolski


Oliphaunt 
Type: Enemy 
Encounter Set: Harad 
Threat Threshold: 44 
Threat: 3 Attack: 6 Defense: 2 Hit Points: 9 
Harad. Creature. 
Cannot have attachments or take more than 3 damage each round.
Forced: After Oliphaunt engages you, exhaust each ally you control. 
Shadow: Attacking enemy gets +3 [Attack]. 
Set: The Land of Shadow Number: 56 
Quantity: 3 
Illustrator: Lukasz Jaskolski


Orc of Cirith Ungol 
Type: Enemy 
Encounter Set: Shelob’s Lair 
Threat Threshold: 40 
Threat: 2 Attack: 4 Defense: 2 Hit Points: 5 
Orc. Uruk. 
Peril.
When Revealed: Either discard 1 random card from each player’s hand, or Orc of Cirith Ungol makes an immediate attack against you. 

“I say, something has slipped. And we’ve got to look out. Always the poor Uruks to put slips right.” —Gorbag, The Two Towers 
Set: The Land of Shadow Number: 42 
Quantity: 3 
Illustrator: Diego Gisbert Llorens


Rage and Hunger 
Type: Treachery 
Encounter Set: The Great Spider 
When Revealed: Shelob gets +2 [Attack] until the end of the phase. Then, she makes an immediate attack against each player in turn order. 
Shadow: If attacking enemy is Shelob, she makes an additional attack against you after this one. 
Set: The Land of Shadow Number: 62 
Quantity: 3 
Illustrator: Álvaro Calvo Escudero


Shelob 
Type: Enemy 
Encounter Set: Shelob’s Lair 
Threat Threshold: 50 
Threat: 4 Attack: 4 Defense: 4 Hit Points: 8 
Creature. Spider. 
Indestructible. Cannot have attachments. 
Shelob gets +1 [Threat] for each resource on her.
Forced: At the beginning of the quest phase, either place 1 resource on Shelob, or she makes an immediate attack against the first player.
Set: The Land of Shadow Number: 40 
Quantity: 1 
Illustrator: Dimitri Bielak


Shelob’s Lair 
Type: Campaign Side A 
Encounter Set: Shelob’s Lair 
You are playing campaign mode.
Setup: Attach A Heavy Burden to the Ring-bearer. Remove each burden with the following burden set icons from the encounter deck and each player’s deck: Helm’s Deep, The Road to Isengard
“There is another way. O yes indeed there is. Another way, darker, more difficult to find, more secret. But Sméagolnknows it. Let Sméagol show you!” —The Two Towers 
Set: The Land of Shadow Number: 73 
Quantity: 1 
Illustrator: Chris Rahn

Shelob’s Poison 
Type: Treachery 
Encounter Set: The Great Spider 
Poison. 
When Revealed: Attach to a hero you control and exhaust that hero. (Counts as a Conditionattachment with the text: “Limit 1 per hero. Treat attached hero’s text box as blank, except for Traits. Attached hero cannot ready.”) 
Shadow: If attacking enemy is Shelob, resolve the ‘When Revealed’ effect on Shelob’s Poison. 
Set: The Land of Shadow Number: 60 
Quantity: 2 
Illustrator: Dimitri Bielak


Shifting Quagmire 
Type: Location 
Encounter Set: The Passage of the Marshes 
Threat: 1 Quest Points: 3 
Marsh. 
Surge.
Mire 1. Forced: When Shifting Quagmire is discarded by the Mire keyword, either return a random location from the victory display to the staging area, or raise each player’s threat by 1 for each location in the victory display.
Travel: Spend 1 [Fellowship] resource to travel here. 
Set: The Land of Shadow Number: 20 
Quantity: 2 
Illustrator: Fabio Rodrigues


Smeagol’s Secret Way 
Type: Location 
Encounter Set: Shelob’s Lair 
Threat: 2 Quest Points: 2 
Mountain. 
Immune to player card effects.
Travel: Either exhaust Smeagol, or discard 1 random card from each player’s hand.
Forced: After Smeagol’s Secret Way is explored, each player either exhausts a character he controls, or discards 1 random card from his hand.

“...a stair, a narrow stair, O yes, very long and narrow. And then more stairs.” —Gollum, The Two Towers 
Set: The Land of Shadow Number: 44 
Quantity: 1 
Illustrator: Álvaro Calvo Escudero


Soft Mires 
Type: Location 
Encounter Set: The Passage of the Marshes 
Threat: 2 Quest Points: 4 
Marsh. 
Mire 1. Forced: When Soft Mires is discarded by the Mire keyword, the first player reveals an encounter card.
Travel: Raise each player’s threat by 1 to travel here. 

The hobbits soon found that what had looked like one vast fen was really an endless network of pools, and soft mires... —The Two Towers 
Set: The Land of Shadow Number: 23 
Quantity: 3 
Illustrator: Carlos Palma Cruchaga


Southward Road 
Type: Location 
Encounter Set: Journey to the Cross-roads 
Threat: 4 Quest Points: 5 
Road. 
While Southward Road is the active location, each player may optionally engage an additional enemy during the encounter phase.
Travel: The first player reveals the top facedown card under The Cross-roads and adds it to the staging area to travel here. 

“These cursed Southrons come now marching up the ancient roads to swell the hosts of the Dark Tower.” —Mablung, The Two Towers 
Set: The Land of Shadow Number: 32 
Quantity: 2 
Illustrator: Julepe


Stagnant Pools 
Type: Location 
Encounter Set: The Passage of the Marshes 
Threat: 3 Quest Points: 7 
Marsh. 
Mire 5. Forced: When Stagnant Pools is discarded by the Mire keyword, raise each player’s threat by 5.
Stagnant Pools gets +1 [Threat] for each mire token on it.
Travel: Exhaust Smeagol to travel here.

Mists curled and smoked from dark and noisome pools. The reek of them hung stifling in the still air. —The Two Towers 
Set: The Land of Shadow Number: 22 
Quantity: 2 
Illustrator: Carlos Palma Cruchaga


The Black Gate 
Type: Objective 
Encounter Set: Journey to the Cross-roads 
Forced: At the end of the planning phase, place each Harad enemy in the staging area facedown underneath The Black Gate. 
If there are at least X facedown cards underneath The Black Gate, the players lose the game. X is 3 more than the number of players. 
Set: The Land of Shadow Number: 27 
Quantity: 1 
Illustrator: Davis Engel


The Cross-roads 
Type: Location 
Encounter Set: Journey to the Cross-roads 
Threat: 9 Quest Points: 9 
Road. 
Immune to player card effects. 
The Cross-roads gets -1 [Threat] for each facedown card under it. The players cannot travel here unless there are 0 facedown cards under The Cross-roads and at least 20 progress tokens on stage 1B. 

“We must go to the Cross-roads. But make haste! Be silent!” —Gollum, The Two Towers 
Set: The Land of Shadow Number: 30 
Quantity: 1 
Illustrator: Cristina Vela


The One Ring 
Type: Objective 
Encounter Set: 
Artifact. Item. Ring. 
Setup: The first player claims The One Ring and attaches it to the Ring-bearer. 
Attached hero does not count against the hero limit. The first player gains control of attached hero. 
If The One Ring leaves play, the players lose the game. 
Set: The Land of Shadow Number: 63 
Quantity: 1 
Illustrator: Mike Nash


The Passage of the Marshes 
Type: Campaign Side A 
Encounter Set: The Passage of the Marshes 
You are playing campaign mode.
Setup: Each player shuffles 1 copy of The Searching Eye into his deck. Remove each burden with the following burden set icons from the encounter deck and each player’s deck: Helm’s Deep, The Road to Isengard
“It’s that Gollum! Snakes and adders! And to think that I thought that we’d puzzle him with our bit of a climb! Look at him! Like a nasty crawling spider on a wall.” —Sam Gamgee, The Two Towers 

campaign 
Set: The Land of Shadow Number: 67 
Quantity: 1 
Illustrator: Cristina Vela


The Searching Eye 
Type: burden treachery 
Encounter Set: The Passage of the Marshes 
The Searching Eye functions like a player card.
Forced: After you draw this card, either exhaust each hero you control, or reveal an encounter card. 

...that horrible growing sense of a hostile will that strove with great power to pierce all shadows of cloud, and earth, and flesh... —The Two Towers 
Set: The Land of Shadow Number: 15 
Quantity: 4 
Illustrator: Julepe


The Spider’s Lair 
Type: Location 
Encounter Set: Shelob’s Lair 
Threat: 3 Quest Points: 4 
Underground. 
Forced: When The Spider’s Lair is explored, remove 1 resource from Shelob.
Forced: After The Spider’s Lair becomes the active location, Shelob makes an attack against the first player. 

There agelong she had dwelt, an evil thing in spider-form, even such as once of old had lived in the Land of the Elves in the West that is now under the Sea... —The Two Towers 
Set: The Land of Shadow Number: 46 
Quantity: 2 
Illustrator: Dimitri Bielak


The Spider’s Pass 
Type: Quest 
Encounter Set: Shelob’s Lair 
Encounter Info: 
Quest Points: 16 
Presently they were under the shadow, and there in the midst of it they saw the opening of a cave. “This is the way in,” said Gollum softly. “This is the entrance to the tunnel.” He did not speak its name: Torech Ungol, Shelob’s Lair. —The Two Towers
When Revealed: Add Shelob to the staging area and shuffle all cards from The Great Spider encounter set and the encounter discard pile into the encounter deck.

They had not gone more than a few yards when from behind them came a sound, startling and horrible in the heavy padded silence: a gurgling,
bubbling noise, and a long venomous hiss. —The Two Towers
Shelob cannot leave the staging area and Smeagol cannot attack or defend.
Each player cannot play, or put into play, more than 1 ally each round.
No more than 4 progress can be placed on this stage each round. 
Set: The Land of Shadow Number: 71 
Quantity: 1 
Illustrator: Dimitri Bielak


The Stairs of Cirith Ungol 
Type: Quest 
Encounter Set: Shelob’s Lair 
Encounter Info: 
Quest Points: 0 
Sméagol has led Frodo and Sam to the Morgul Vale, where he promises to show them a secret way over the Mountains of Shadow and into the land of Mordor, but Sam fears that Gollum may be leading them into a trap...
Setup: Set Cleft of Cirith Ungol, Shelob and The Great Spider encounter set aside, out of play. Put Smeagol into play under the first player’s control. Make Morgul Vale the active location. Add Smeagol’s Secret Way to the staging area. Shuffle the encounter deck.

Progress cannot be placed on Underground locations. 
Response: After Smeagol’s Secret Way is explored, discard 3 random cards from each player’s hand to discard each Nazgul enemy in the staging area.
Forced: At the end of the quest phase, if Smeagol’s Secret Way is in the victory display, advance to stage 2A. 
Set: The Land of Shadow Number: 70 
Quantity: 1 
Illustrator: Chris Rahn


The Taming of Smeagol 
Type: Quest 
Encounter Set: The Passage of the Marshes 
Encounter Info: 
Quest Points: 6 
Frodo and Sam left the Fellowship above the falls of Rauros and crossed the great river to climb the Emyn Muil upon the Eastern shore. After days of wandering through that maze of rocky crags, they have finally reached the edge of the Dead Marshes only to discover that Gollum is following them.
Setup: Put Gollum into play engaged with the fi rst player. Each player searches the encounter deck for 1 location, reveals it, and adds it to the staging area. Shuffle the encounter deck.

Things would have gone ill with Sam, if he had been alone. But Frodo sprang up, and drew Sting from its sheath. —The Two Towers
The players cannot advance unless the first player controls Smeagol.
Forced: After a player declares any number of attackers against Gollum, discard the top card of the encounter deck. Gollum gets +X [Defense] for this attack, where X is the discarded card’s [Threat].
Set: The Land of Shadow Number: 64 
Quantity: 1 
Illustrator: Cristina Vela


The Under-way 
Type: Location 
Encounter Set: Shelob’s Lair 
Threat: 2 Quest Points: 3 
Underground. 
While The Under-way is in the staging area, each Orc enemy gets -5 engagement cost and gains: “Forced: After this enemy engages a player, deal it a shadow card.” 
Shadow: Deal the attacking enemy 2 additional shadow cards. 
Set: The Land of Shadow Number: 47 
Quantity: 2 
Illustrator: Fabio Rodrigues


We Hates Them 
Type: Treachery 
Encounter Set: Gollum 
Gollum. 
Surge.
When Revealed: Either flip Smeagol to Gollum, or Gollum makes an immediate attack. The first player may spend 1 [Fellowship] resource and exhaust The One Ring to cancel this effect.
Shadow: Attacking enemy gets +1 [Attack] (+3 [Attack] instead if the attacking enemy is Gollum). 
Set: The Land of Shadow Number: 55 
Quantity: 2 
Illustrator: Álvaro Calvo Escudero
*/

        }
    }
}