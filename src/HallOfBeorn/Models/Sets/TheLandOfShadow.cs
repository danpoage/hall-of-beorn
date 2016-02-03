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
                .WithVictoryPoints(2)
                .WithInfo(14, 4, Artist.Cristina_Vela));
            Cards.Add(Card.Treachery("The Searching Eye", "", "The Passage of the Marshes")
                .WithBurden()
                .WithText("The Searching Eye functions like a player card.\r\nForced: After you draw this card, either exhaust each hero you control, or reveal an encounter card.")
                .WithFlavor("...that horrible growing sense of a hostile will that strove with great power to pierce all shadows of cloud, and earth, and flesh... —The Two Towers")
                .WithInfo(15, 4, Artist.Julepe));
            Cards.Add(Card.Enemy("Groping Dead", "", "The Passage of the Marshes", 24, 2, 3, 1, 4)
                .WithTraits("Undead.")
                .WithText("The engaged player cannot reduce his threat.\r\nForced: After Groping Dead attacks and destroys a character, place 1 mire token on the active location.")
                .WithShadow("Shadow: If this attack destroys a character, place 1 mire token on the active location.")
                .WithInfo(16, 3, Artist.Crystal_Sully));
            Cards.Add(Card.Enemy("Dead Things", "", "The Passage of the Marshes", 32, 3, 4, 2, 5)
                .WithTraits("Undead.")
                .WithText("The engaged player cannot reduce his threat.\r\nForced: After Dead Things attacks and destroys a character, the defending player raises his threat by 3.")
                .WithShadow("Shadow: Raise your threat by 1 for each Undead enemy engaged with you.")
                .WithInfo(17, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Enemy("Candle-bearer", "", "The Passage of the Marshes", 36, 3, 5, 2, 6)
                .WithTraits("Undead.")
                .WithText("The engaged player cannot reduce his threat.\r\nForced: After Candle-bearer attacks and destroys a character, it cannot take damage until the end of the round.")
                .WithShadow("Shadow: Until the end of the round, attacking enemy cannot take damage.")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 3, Artist.Michael_Wolmarans));
            Cards.Add(Card.Location("Evil-smelling Fens", "", "The Passage of the Marshes", 3, 4)
                .WithTraits("Marsh.")
                .WithKeywords("Mire 3.")
                .WithText("Forced: When Evil-smelling Fens is discarded by the Mire keyword, deal 1 damage to each character.\r\nTravel: Raise each player’s threat by 1 to travel here.")
                .WithShadow("Shadow: Deal 1 damage to defending character.")
                .WithEasyModeQuantity(2)
                .WithInfo(19, 3, Artist.Michael_Wolmarans));
            Cards.Add(Card.Location("Shifting Quagmire", "", "The Passage of the Marshes", 1, 3)
                .WithTraits("Marsh.")
                .WithKeywords("Surge.", "Mire 1.")
                .WithText("Forced: When Shifting Quagmire is discarded by the Mire keyword, either return a random location from the victory display to the staging area, or raise each player's threat by 1 for each location in the victory display.\r\nTravel: Spend 1 Fellowship resource to travel here.")
                .WithInfo(20, 2, Artist.Fabio_Rodrigues));
            Cards.Add(Card.Location("Haunted Mere", "", "The Passage of the Marshes", 4, 5)
                .WithTraits("Marsh.")
                .WithKeywords("Mire 2.")
                .WithText("Forced: When Haunted Mere is discarded by the Mire keyword, search the encounter deck and discard pile for an Undead enemy, reveal it, and add it to the staging area. Shuffle the encounter deck.\r\nTravel: Exhaust Smeagol to travel here.")
                .WithFlavor("\"They lie in all the pools, pale faces, deep deep under the dark water.\" —Frodo, The Two Towers")
                .WithInfo(21, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Location("Stagnant Pools", "", "The Passage of the Marshes", 3, 7)
                .WithTraits("Marsh.")
                .WithKeywords("Mire 5.")
                .WithText("Forced: When Stagnant Pools is discarded by the Mire keyword, raise each player's threat by 5.\r\nStagnant Pools gets +1 Threat for each mire token on it.\r\nTravel: Exhaust Smeagol to travel here.")
                .WithFlavor("Mists curled and smoked from dark and noisome pools. The reek of them hung stifling in the still air. —The Two Towers")
                .WithInfo(22, 2, Artist.Carlos_Palma_Cruchaga));
            Cards.Add(Card.Location("Soft Mires", "", "The Passage of the Marshes", 2, 4)
                .WithTraits("Marsh.")
                .WithKeywords("Mire 1.")
                .WithText("Forced: When Soft Mires is discarded by the Mire keyword, the first player reveals an encounter card.\r\nTravel: Raise each player's threat by 1 to travel here.")
                .WithFlavor("The hobbits soon found that what had looked like one vast fen was really an endless network of pools, and soft mires... —The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(23, 3, Artist.Carlos_Palma_Cruchaga));
            Cards.Add(Card.Treachery("Creeping Marshes", "", "The Passage of the Marshes")
                .WithKeywords("Surge.", "Doomed 1.")
                .WithText("When Revealed: Attach to the current quest. (Counts as a Condition attachment with the text: \"Forced: At the end of the refresh phase, place 1 mire token on each location in the staging area. Then, discard Creeping Marshes.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 2, Artist.Carlos_Palma_Cruchaga));
            Cards.Add(Card.Treachery("Bitter Reek", "", "The Passage of the Marshes")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either raise your threat by 1 for each character you control that is committed to the quest, or deal 1 damage to each character committed to the quest.")
                .WithShadow("Shadow: Raise your threat by the attacking enemy’s Threat.")
                .WithEasyModeQuantity(2)
                .WithInfo(25, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Treachery("A Fell Light", "", "The Passage of the Marshes")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Put the topmost Undead enemy in the discard pile into play engaged with you. Each Undead enemy engaged with you makes an immediate attack.")
                .WithShadow("Shadow: Put the topmost Undead enemy in the discard pile into play engaged with you.")
                .WithEasyModeQuantity(1)
                .WithInfo(26, 2, Artist.Cristina_Vela));
            Cards.Add(Card.Objective("The Black Gate", "", "Journey to the Cross-roads")
                .WithUnique()
                .WithText("Forced: At the end of the planning phase, place each Harad enemy in the staging area facedown underneath The Black ~Gate.\r\nIf there are at least X facedown cards underneath The Black Gate, the players lose the game. X is 3 more than the number of players.")
                .WithInfo(27, 1, Artist.Davis_Engel));
            Cards.Add(Card.Enemy("Man of Harad", "", "Journey to the Cross-roads", 36, 1, 3, 1, 4)
                .WithTraits("Harad.")
                .WithKeywords("Surge.", "Archery 1.")
                .WithText("Forced: After Man of Harad engages you, discard 1 random card from your hand.")
                .WithShadow("Shadow: Discard 1 random card from your hand.")
                .WithInfo(28, 4, Artist.Beth_Sobel));
            Cards.Add(Card.Enemy("Captain of Harad", "", "Journey to the Cross-roads", 38, 4, 4, 3, 5)
                .WithTraits("Harad.")
                .WithText("Forced: After Captain of Harad engages you, each Harad enemy gets +1 [Attack] and -10 engagement cost until the end of the round.")
                .WithShadow("Shadow: If this attack destroys a character, return attacking enemy to the staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(29, 3, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Location("The Cross-roads", "", "Journey to the Cross-roads", 9, 9)
                .WithUnique()
                .WithTraits("Road.")
                .WithText("Immune to player card effects.\r\nThe Cross-roads gets -1 Threat for each facedown card under it. The players cannot travel here unless there are 0 facedown cards under The Cross-roads and at least 20 progress tokens on stage 1B.")
                .WithFlavor("\"We must go to the Cross-roads. But make haste! Be silent!\" —Gollum, The Two Towers")
                .WithInfo(30, 1, Artist.Cristina_Vela));
            Cards.Add(Card.Location("Henneth Annûn", "", "Journey to the Cross-roads", 1, 1)
                .WithUnique()
                .WithNormalizedTitle("Henneth Annun")
                .WithTraits("Refuge.")
                .WithText("While Henneth Annûn is the active location, skip both the encounter phase and combat phase, and ignore the Forced effects on stage 1B and The Black Gate.\r\nForced: After Henneth Annûn becomes the active location, return each engaged enemy to the staging area.")
                .WithFlavor("\"This is the Window of the Sunset, Henneth Annûn, fairest of all the falls of Ithilien...\" —Faramir, The Two Towers")
                .WithInfo(31, 1, Artist.Julepe));
            Cards.Add(Card.Location("Southward Road", "", "Journey to the Cross-roads", 4, 5)
                .WithTraits("Road.")
                .WithText("While Southward Road is the active location, each player may optionally engage an additional enemy during the encounter phase.\r\nTravel: The first player reveals the top facedown card under The Cross-roads and adds it to the staging area to travel here.")
                .WithFlavor("\"These cursed Southrons come now marching up the ancient roads to swell the hosts of the Dark Tower.\" —Mablung, The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(32, 2, Artist.Julepe));
            Cards.Add(Card.Location("Foothills of Ephel Dúath", "", "Journey to the Cross-roads", 3, 6)
                .WithNormalizedTitle("Foothills of Ephel Duath")
                .WithTraits("Hills.")
                .WithText("While Foothills of Ephel Dúath is the active location, each Harad enemy gets -1 Threat.\r\nTravel: The first player engages an enemy in the staging area to travel here.")
                .WithFlavor("\"And they go ever more heedlessly, we learn, thinking that the power of their new master is great enough, so that the mere shadow of His hills will protect them.\" —Mablung, The Two Towers")
                .WithInfo(33, 3, Artist.Dimitri_Bielak));
            Cards.Add(Card.Location("Ithilien Woods", "", "Journey to the Cross-roads", 2, 3)
                .WithTraits("Forest.")
                .WithText("While Ithilien Woods is the active location, it gains: \"Forced: After a player engages a Harad enemy, he readies a character he controls.\"\r\nTravel: The first player reveals an encounter card to travel here.")
                .WithFlavor("Ithilien, the garden of Gondor now desolate kept still a dishevelled dryad loveliness. —The Two Towers")
                .WithInfo(34, 2, Artist.Julepe));
            Cards.Add(Card.Location("Hills of Ithilien", "", "Journey to the Cross-roads", 2, 4)
                .WithTraits("Forest.", "Hills.")
                .WithText("While Hills of Ithilien is the active location, it gains: \"Forced: After a player engages a Harad enemy, deal 1 damage to that enemy.\"")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithInfo(35, 3, Artist.Julepe));
            Cards.Add(Card.Treachery("The Dark Lord's Summons", "", "Journey to the Cross-roads")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either place the lowest Attack Harad enemy engaged with you facedown under The Black Gate, or reveal the top card from under The Cross-roads and put it into play engaged with you.")
                .WithFlavor("\"Always more people coming to Mordor. One day all the peoples will be inside.\" —Gollum, The Two Towers")
                .WithInfo(36, 3, Artist.Jon_Bosco));
            Cards.Add(Card.Treachery("Marching Up the Road", "", "Journey to the Cross-roads")
                .WithText("When Revealed: Each player must either return an enemy engaged with him to the staging area, or search the encounter deck for a Harad enemy and put it into play engaged with him.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, place attacking enemy facedown under The Black ~Gate.")
                .WithEasyModeQuantity(1)
                .WithInfo(37, 2, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Treachery("Fierce Southrons", "", "Journey to the Cross-roads")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either place the lowest Threat Harad enemy in the staging area facedown under The Black Gate and reveal an additional encounter card, or each enemy in the staging area makes an immediate attack against you.")
                .WithFlavor("\"Not nice; very cruel wicked Men they look. Almost as bad as Orcs...\" —Gollum, The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(38, 2, Artist.Crystal_Sully));
            Cards.Add(Card.Treachery("Arrows Thick in the Air", "", "Journey to the Cross-roads")
                .WithText("When Revealed: Until the end of the round, each Harad enemy gains Archery 2.")
                .WithShadow("Shadow: Either place attacking enemy facedown under The Black Gate after this attack, or it makes an additional attack against you after this one.")
                .WithInfo(39, 2, Artist.Julepe));
            Cards.Add(Card.Enemy("Shelob", "", "Shelob's Lair", 50, 4, 4, 4, 8)
                .WithUnique()
                .WithTraits("Spider.")
                .WithKeywords("Indestructible.")
                .WithText("Cannot have attachments.\r\nShelob gets +1 Threat for each resource on her.\r\nForced: At the beginning of the quest phase, either place 1 resource on Shelob, or she makes an immediate attack against the first player.")
                .WithInfo(40, 1, Artist.Dimitri_Bielak));
            Cards.Add(Card.Enemy("Morgul Orc", "", "Shelob's Lair", 35, 1, 3, 2, 3)
                .WithTraits("Orc.", "Uruk.")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either discard 1 random card from your hand, or reveal an additional encounter card.")
                .WithShadow("Shadow: If this attack destroys a character, discard 1 random card from your hand.")
                .WithEasyModeQuantity(3)
                .WithInfo(41, 4, Artist.Michael_Wolmarans));
            Cards.Add(Card.Enemy("Orc of Cirith Ungol", "", "Shelob's Lair", 40, 2, 4, 2, 5)
                .WithTraits("Orc.", "Uruk.")
                .WithKeywords("Peril.")
                .WithText("When Revealed: Either discard 1 random card from each player’s hand, or Orc of Cirith Ungol makes an immediate attack against you.")
                .WithFlavor("\"I say, something has slipped. And we’ve got to look out. Always the poor Uruks to put slips right.\" —Gorbag, The Two Towers")
                .WithEasyModeQuantity(2)
                .WithInfo(42, 3, Artist.Diego_Gisbert_Llorens));
            Cards.Add(Card.Location("Morgul Vale", "", "Shelob's Lair", 4, 2)
                .WithUnique()
                .WithTraits("Vale.")
                .WithText("Immune to player card effects.\r\nForced: After Morgul Vale is explored, search the encounter deck and discard pile for a Morgul Wraith and add it to the staging area. Shuffle the encounter deck. Then, the first player must either exhaust The One Ring, or discard 1 random card from each player's hand.")
                .WithInfo(43, 1, Artist.Chris_Rahn));
            Cards.Add(Card.Location("Sméagol's Secret Way", "", "Shelob's Lair", 2, 2)
                .WithUnique()
                .WithNormalizedTitle("Smeagol's Secret Way")
                .WithTraits("Mountain.")
                .WithText("Immune to player card effects.\r\nTravel: Either exhaust Sméagol, or discard 1 random card from each player's hand.\r\nForced: After Sméagol's Secret Way is explored, each player either exhausts a character he controls, or discards 1 random card from his hand.")
                .WithFlavor("\"...a stair, a narrow stair, O yes, very long and narrow. And then more stairs.\" —Gollum, The Two Towers")
                .WithInfo(44, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Location("Cleft of Cirith Ungol", "", "Shelob's Lair", 4, 4)
                .WithUnique()
                .WithTraits("Mountain.")
                .WithText("Immune to player card effects.\r\nWhile The Cleft of Cirith Ungol is in the victory display, Shelob gets +2 Attack, loses the Indestructible keyword, and gains: \"Shelob engages the first player.\"\r\nTravel: Place 1 resource on Shelob to travel here.")
                .WithFlavor("The Cleft, Cirith Ungol, was before him, a dim notch in the black ridge... —The Two Towers")
                .WithInfo(45, 1, Artist.Jokubas_Uoginitas));
            Cards.Add(Card.Location("The Spider's Lair", "", "Shelob's Lair", 3, 4)
                .WithTraits("Underground.")
                .WithText("Forced: When The Spider's Lair is explored, remove 1 resource from Shelob.\r\nForced: After The Spider’s Lair becomes the active location, Shelob makes an attack against the first player.")
                .WithFlavor("There agelong she had dwelt, an evil thing in spider-form, even such as once of old had lived in the Land of the Elves in the West that is now under the Sea... —The Two Towers")
                .WithInfo(46, 2, Artist.Dimitri_Bielak));
            Cards.Add(Card.Location("The Under-way", "", "Shelob's Lair", 2, 3)
                .WithTraits("Underground.")
                .WithText("While The Under-way is in the staging area, each Orc enemy gets -5 engagement cost and gains: \"Forced: After this enemy engages a player, deal it a shadow card.\"")
                .WithShadow("Shadow: Deal the attacking enemy 2 additional shadow cards.")
                .WithEasyModeQuantity(1)
                .WithInfo(47, 2, Artist.Fabio_Rodrigues));
            Cards.Add(Card.Location("Deep Dark Passage", "", "Shelob's Lair", 2, 5)
                .WithTraits("Underground.")
                .WithText("While Deep Dark Passage is in the staging area, it gains: \"Forced: When any amount of progress would be placed on a location in the staging area, reduce that amount by 1.\"\r\nTravel: Exhaust Sméagol to travel here.")
                .WithFlavor("Not since the lightless passages of Moria had Frodo or Sam known such darkness, and if possible here it was deeper and denser. —The Two Towers")
                .WithInfo(48, 3, Artist.Davis_Engel));
            Cards.Add(Card.Location("Den of Night", "", "Shelob's Lair", 1, 4)
                .WithTraits("Underground.")
                .WithText("While Den of Night is in the staging area, it gains: \"Forced: After a ‘When Revealed’ effect is canceled, place 1 resource on Shelob.\"\r\nTravel: Place 1 resource on Shelob to travel here.")
                .WithFlavor("Here was some opening in the rock far wider than any they had yet passed; and out of it came a reek so foul, and a sense of lurking malice so intense, that Frodo reeled. —The Two Towers")
                .WithInfo(49, 3, Artist.Davis_Engel));
            Cards.Add(Card.Treachery("Exhalation of Decay", "", "Shelob's Lair")
                .WithText("When Revealed: Each player discards 1 random card from his hand and 1 non-objective attachment he controls.")
                .WithShadow("Shadow: Discard a non-objective attachment you control.")
                .WithFlavor("\"Ugh! That smell!\" he said. \"It's getting stronger and stronger.\" —The Two Towers")
                .WithInfo(50, 2, Artist.Dimitri_Bielak));
            Cards.Add(Card.Treachery("Many Openings", "", "Shelob's Lair")
                .WithText("When Revealed: Each location in the staging area gets +1 Attack until the end of the round. If the number of locations in the staging area is less than the number of players in the game, reveal an additional encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is the active location's Threat.")
                .WithEasyModeQuantity(1)
                .WithInfo(51, 2, Artist.Jokubas_Uoginitas));
            Cards.Add(Card.Objective("A Heavy Burden", "", "Shelob's Lair")
                .WithTraits("Condition.")
                .WithKeywords("Permanent.")
                .WithText("Setup: Attach to the Ring-bearer.\r\nForced: At the end of the planning phase, either raise each player's threat by 1, or exhaust the Ring-bearer.")
                .WithFlavor("\"It's heavy on me, Sam lad, very heavy. I wonder how far I can carry it?\" —Frodo Baggins, The Two Towers")
                .WithInfo(52, 1, Artist.Kara_Williams));
            Cards.Add(Card.Enemy("Morgul Wraith", "", "Nazgûl", 45, 4, 5, 4, 9)
                .WithTraits("Nazgûl.")
                .WithText("Cannot have non-Morgul attachments.\r\nWhile The One Ring is exhausted, Morgul Wraith gets -30 engagement cost and gains: \"Immune to player card effects.\"")
                .WithFlavor("\"They see everything, everything. Nothing can hide from them.\" —Gollum, The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(53, 2, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Treachery("Call of the Ring", "", "Nazgûl")
                .WithText("When Revealed: The first player must choose: either search the encounter deck, discard pile, and victory display for a Nazgul enemy and add it to the staging area, or exhaust The One Ring and reveal the top card of the encounter deck.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(54, 2, Artist.Melanie_Maier));
            Cards.Add(Card.Treachery("We Hates Them!", "", "Gollum")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Either flip Sméagol to ~Gollum, or ~Gollum makes an immediate attack. The first player may spend 1 Fellowship resource and exhaust The One ~Ring to cancel this effect.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the attacking enemy is Gollum).")
                .WithEasyModeQuantity(1)
                .WithInfo(55, 2, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Enemy("Oliphaunt", "", "Men of Harad", 44, 3, 6, 2, 9)
                .WithTraits("Harad.", "Creature.")
                .WithText("Cannot have attachments or take more than 3 damage each round.\r\nForced: After Oliphaunt engages you, exhaust each ally you control.")
                .WithShadow("Shadow: Attacking enemy gets +3 Attack.")
                .WithInfo(56, 3, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Enemy("Haradrim Soldier", "", "Men of Harad", 40, 2, 4, 3, 4)
                .WithTraits("Harad.")
                .WithText("Forced: After Haradrim Soldier engages you, it makes an immediate attack.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithInfo(57, 3, Artist.Jon_Bosco));
            Cards.Add(Card.Enemy("Haradrim Archer", "", "Men of Harad", 42, 255, 3, 1, 5)
                .WithTraits("Harad.")
                .WithKeywords("Archery X.")
                .WithText("X is the number of players in the game.\r\nForced: After Haradrim Archer engages you, assign X damage among characters you control.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(58, 3, Artist.Melanie_Maier));
            Cards.Add(Card.Location("Blocked Tunnel", "", "The Great Spider", 3, 9)
                .WithTraits("Underground.")
                .WithText("When Revealed: Make Blocked Tunnel the active location, returning any previous active location to the staging area.\r\nAction: Exhaust a character with a Weapon attachment to place 3 progress on Blocked Tunnel. (Any player may trigger this effect.)")
                .WithFlavor("Across the width and height of the tunnel a vast web was spun, orderly as the web of some huge spider... —The Two Towers")
                .WithEasyModeQuantity(1)
                .WithInfo(59, 2, Artist.Julepe));
            Cards.Add(Card.Treachery("Shelob's Poison", "", "The Great Spider")
                .WithTraits("Poison.")
                .WithText("When Revealed: Attach to a hero you control and exhaust that hero. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Treat attached hero’s text box as blank, except for Traits. Attached hero cannot ready.\")")
                .WithShadow("Shadow: If attacking enemy is Shelob, resolve the 'When Revealed' effect on Shelob’s Poison.")
                .WithEasyModeQuantity(1)
                .WithInfo(60, 2, Artist.Dimitri_Bielak));
            Cards.Add(Card.Treachery("Lurking Malice", "", "The Great Spider")
                .WithKeywords("Peril.", "Surge.")
                .WithText("When Revealed: Either place 1 resources on Shelob, or she makes an immediate attack against you.")
                .WithShadow("Shadow: If attacking enemy is Shelob, place 1 resource on her. Then, she gets +1 Attack for each resource on her.")
                .WithEasyModeQuantity(2)
                .WithInfo(61, 3, Artist.Michael_Wolmarans));
            Cards.Add(Card.Treachery("Rage and Hunger", "", "The Great Spider")
                .WithText("When Revealed: Shelob gets +2 Attack until the end of the phase. Then, she makes an immediate attack against each player in turn order.")
                .WithShadow("Shadow: If attacking enemy is Shelob, she makes an additional attack against you after this one.")
                .WithEasyModeQuantity(2)
                .WithInfo(62, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Objective("The One Ring", "", "")
                .WithTraits("Artifact.", "Item.", "Ring.")
                .WithText("Setup: The first player claims The One ~Ring and attaches it to the Ring-bearer.\r\nAttached hero does not count against the hero limit. The first player gains control of attached hero.\r\nIf The One Ring leaves play, the players lose the game.")
                .WithInfo(63, 1, Artist.Mike_Nash));
            Cards.Add(Card.Quest("The Taming of Sméagol", "", 10, 1, "The Passage of the Marshes", 6)
                .WithNormalizedTitle("The Taming of Smeagol")
                .WithFlavor("Frodo and Sam left the Fellowship above the falls of Rauros and crossed the great river to climb the Emyn Muil upon the Eastern shore. After days of wandering through that maze of rocky crags, they have finally reached the edge of the Dead Marshes only to discover that Gollum is following them.")
                .WithText("Setup: Put Gollum into play engaged with the first player. Each player searches the encounter deck for 1 location, reveals it, and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("Things would have gone ill with Sam, if he had been alone. But Frodo sprang up, and drew Sting from its sheath. —The Two Towers")
                .WithOppositeText("The players cannot advance unless the first player controls Sméagol.\r\nForced: After a player declares any number of attackers against Gollum, discard the top card of the encounter deck. Gollum gets +X Defense for this attack, where X is the discarded card’s Threat.")
                .WithIncludedEncounterSets(EncounterSet.Gollum, EncounterSet.Nazgul)
                .WithInfo(64, 1, Artist.Cristina_Vela));
            Cards.Add(Card.Quest("Across the Marshes", "", 10, 2, "The Passage of the Marshes", 12)
                .WithFlavor("The Hobbits soon found that what had looked like one vast fen was really an endless network of pools, and soft mires, and winding half-strangled watercourses. Among these a cunning eye and foot could thread a wandering path. —The Two Towers")
                .WithText("When Revealed: If the number of locations in the staging area is less than the number of players in the game, discard cards from the encounter deck until a location is discarded. Add the discarded location to the staging area.")
                .WithOppositeText("Progress cannot be placed on locations in the staging area.\r\nThe players cannot advance unless the first player controls Sméagol and there are at least 4 locations in the victory display.\r\nForced: At the end of the staging step, if the number of locations in the staging area is less than the number of players in the game, reveal the top card of the encounter deck.")
                .WithIncludedEncounterSets(EncounterSet.Gollum, EncounterSet.Nazgul)
                .WithInfo(65, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Quest("Don't Look at the Lights!", "", 10, 3, "The Passage of the Marshes", 24)
                .WithFlavor("For a moment the water below him looked like some window, glazed with grimy glass, through which he was peering. Wrenching his hands out of the bog, he sprang back with a cry. \"There are dead things, dead faces in the water,\" he said with horror. —The Two Towers")
                .WithText("When Revealed: Each player searches the encounter deck and discard pile for an Undeadenemy and puts it into play engaged with him. Shuffle all locations in the victory display into the encounter deck.")
                .WithOppositeFlavor("Gollum laughed. \"The Dead Marshes, yes, yes: that is their names,\" he cackled. \"You should not look in when the candles are lit.\" —The Two Towers")
                .WithOppositeText("While any player is engaged with an Undead enemy, progress cannot be placed on this stage.\r\nThe players cannot defeat this stage unless the first player controls Sméagol. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.Gollum, EncounterSet.Nazgul)
                .WithInfo(66, 1, Artist.Cristina_Vela));
            Cards.Add(Card.Campaign("The Passage of the Marshes", "", 10, "The Passage of the Marshes", "The Lord of the Rings - Part 10")
                .WithText("You are playing campaign mode.\r\nSetup: Each player may change hero cards he controls without incurring the +1 threat penalty. Each player shuffles 1 copy of The Searching Eye into his deck. Remove each burden with the following burden set icons from the encounter deck and each player's deck: Helm's Deep, The Road to Isengard")
                .WithFlavor("\"It's that Gollum! Snakes and adders! And to think that I thought that we’d puzzle him with our bit of a climb! Look at him! Like a nasty crawling spider on a wall.\" —Sam Gamgee, The Two Towers")
                .WithOppositeText("Resolution: Each player must choose: either take a permanent +2 starting threat penalty, or earn 1 copy of The Searching Eye. Record each player's choice in the campaign log.")
                .WithOppositeFlavor("The marshes were at an end, dying away into dead peats and wide flats of dry cracked mud. The land ahead rose in long shallow slopes, barren and pitiless, towards the desert that lay at Sauron's gate.\r\n-The Two Towers")
                .WithInfo(67, 1, Artist.Cristina_Vela));
            Cards.Add(Card.Quest("Ambush the Men of Harad", "", 11, 1, "Journey to the Cross-roads", 20)
                .WithFlavor("\"These cursed Southrons come now marching up the ancient roads to swell the hosts of the Dark Tower. Yea, up the very roads that craft of Gondor made.\" —Mablung, The Two Towers")
                .WithText("Setup: Add The Black Gate and The Cross-roads to the staging area. Shuffle the Harad encounter set and place it facedown under The Cross-roads. Each player, except for the first player, searches the encounter deck for a different non-unique location and adds it to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("\"The road may pass, but they shall not!\"\r\n—Mablung, The Two Towers")
                .WithOppositeText("Forced: At the beginning of the quest phase, reveal the top facedown card from under The Cross-roads and add it to the staging area.\r\nThe players cannot defeat this stage while The Cross-roads is in play. When The Cross-roads is explored, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.MenOfHarad)
                .WithInfo(68, 1, Artist.Julepe));
            Cards.Add(Card.Campaign("Journey to the Cross-roads", "", 11, "Journey to the Cross-roads", "The Lord of the Rings - Part 11")
                .WithText("You are playing campaign mode.\r\nSetup: Each player must choose: either add 1 resource to each of his heroes’ pools, or shuffle 1 copy of Brace of Coneys into his deck. Remove each burden with the following burden set icons from the encounter deck and each player's deck: Helm's Deep, The Road to Isengard")
                .WithFlavor("So they passed into the northern marches of that land that Men once called Ithilien, a fair country of climbing woods and swift-falling streams. —The Two Towers")
                .WithOppositeText("Resolution: Each player who chose to shuffle a copy of Brace of Coneys into his deck during setup has earned that boon. Add each earned copy to the campaign pool. Record the name and quantity of each enemy underneath The Black Gate in the notes section of the campaign log.")
                .WithOppositeFlavor("\"Here is the last parting of our ways,\" said Faramir.\r\n\"If you take my counsel, you will not turn eastward yet. Go straight on, for thus you will have the cover of the woodland for many miles.\" -The Two Towers")
                .WithInfo(69, 1, Artist.Julepe));
            Cards.Add(Card.Quest("The Stairs of Cirith Ungol", "", 12, 1, "Shelob's Lair", 255)
                .WithFlavor("Sméagol has led Frodo and Sam to the Morgul Vale, where he promises to show them a secret way over the Mountains of Shadow and into the land of Mordor, but Sam fears that Gollum may be leading them into a trap...")
                .WithText("Setup: Set Cleft of Cirith Ungol, Shelob and The Great ~Spider encounter set aside, out of play. Put Sméagol into play under the first player's control. Make ~Morgul Vale the active location. Add Sméagol's Secret Way to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Progress cannot be placed on Underground locations.\r\nResponse: After Sméagol's Secret Way is explored, discard 3 random cards from each player's hand to discard each Nazgûl enemy in the staging area.\r\nForced: At the end of the quest phase, if Sméagol's Secret Way is in the victory display, advance to stage 2A.")
                .WithIncludedEncounterSets(EncounterSet.Gollum, EncounterSet.Nazgul, EncounterSet.TheGreatSpider)
                .WithInfo(70, 1, Artist.Chris_Rahn));
            Cards.Add(Card.Quest("The Spider's Pass", "", 12, 2, "Shelob's Lair", 16)
                .WithFlavor("Presently they were under the shadow, and there in the midst of it they saw the opening of a cave. \"This is the way in,\" said Gollum softly. \"This is the entrance to the tunnel.\" He did not speak its name: Torech Ungol, Shelob’s Lair. —The Two Towers")
                .WithText("When Revealed: Add Shelob to the staging area and shuffle all cards from The Great ~Spider encounter set and the encounter discard pile into the encounter deck.")
                .WithOppositeFlavor("They had not gone more than a few yards when from behind them came a sound, startling and horrible in the heavy padded silence: a gurgling, bubbling noise, and a long venomous hiss. —The Two Towers")
                .WithOppositeText("Shelob cannot leave the staging area and Sméagol cannot attack or defend.\r\nEach player cannot play, or put into play, more than 1 ally each round.\r\nNo more than 4 progress can be placed on this stage each round.")
                .WithIncludedEncounterSets(EncounterSet.Gollum, EncounterSet.Nazgul, EncounterSet.TheGreatSpider)
                .WithInfo(71, 1, Artist.Dimitri_Bielak));
            Cards.Add(Card.Quest("Gollum's Betrayal", "", 12, 3, "Shelob's Lair", 8)
                .WithFlavor("\"Got him!\" hissed Gollum in his ear. \"At last, my precious, we've got him, yet, the nassty hobbit. We takes this one. She'll get the other. O yes, Selob will get him, not Sméagol: he promised; he won't hurt Master at all. But he's got you, you nassty filthy little sneak!\" He spat on Sam's neck. -The Two Towers")
                .WithText("When Revealed: Add Cleft of Cirith Ungol to the staging area. Flip Sméagol to Gollum and heal all damage from Shelob. Each player places 1 resource on Shelob.")
                .WithOppositeText("If Gollum is defeated, add him to the victory display. (Do not flip him over.)\r\nWhile Shelob has at least 1 resource on her, she gains: \"Forced: When Shelob is dealt any amount of damage, cancel that damage and discard 1 resource from Shelob instead.\"\r\nThe players cannot defeat this stage unless both Shelob and Gollum are in the victory display. If the players defeat this stage, they win the game.")
                .WithIncludedEncounterSets(EncounterSet.Gollum, EncounterSet.Nazgul, EncounterSet.TheGreatSpider)
                .WithInfo(72, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Campaign("Shelob's Lair", "", 12, "Shelob's Lair", "The Lord of the Rings - Part 12")
                .WithText("You are playing campaign mode.\r\nSetup: Attach A Heavy Burden to the Ring-bearer. Remove each burden with the following burden set icons from the encounter deck and each player’s deck: Helm’s Deep, The Road to Isengard")
                .WithFlavor("\"There is another way. O yes indeed there is. Another way, darker, more difficult to find, more secret. But Sméagolnknows it. Let Sméagol show you!\" —The Two Towers")
                .WithOppositeText("Resolution: Add a Heavy Burden to the campaign pool. The players have earned that burden.")
                .WithOppositeFlavor("\"Master, dear master,\" he said, but Frodo did not speak. Ass hehad run forward, eager, rejoicing to be free, Shelob with hideous speed had come behind and with one swift stroke had stung him in the neck. He lay now pale, and heard no voice, and did not move.\r\n-The Two Towers")
                .WithInfo(73, 1, Artist.Chris_Rahn));
            Cards.Add(Card.Enemy("Gollum", "", "Gollum", 30, 2, 2, 2, 5)
                .WithTraits("Gollum.")
                .WithText("Immune to non-Fellowship player card effects. ~Gollum engages the first player.\r\nForced: After ~Gollum engages the first player during the refresh phase, he makes an immediate attack.\r\nForced: When ~Gollum is defeated, flip him to Sméagol exhausted.")
                .WithInfo(75, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.ObjectiveAlly("Sméagol", "", "Gollum", 2, 2, 2, 5)
                .WithNormalizedTitle("Smeagol")
                .WithTraits("Gollum.")
                .WithText("Immune to player card effects. The first player gains control of Sméagol.\r\nForced: After the players quest unsuccessfully, flip Sméagol to ~Gollum.\r\nIf Sméagol is destroyed, the players lose the game.")
                .WithInfo(76, 1, Artist.Lukasz_Jaskolski));

            /*
            
            */

        }
    }
}