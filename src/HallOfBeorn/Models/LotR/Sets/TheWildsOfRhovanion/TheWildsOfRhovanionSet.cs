using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheWildsOfRhovanion
{
    public class TheWildsOfRhovanionSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Wilds of Rhovanion";
            Abbreviation = "TWoR";
            Number = 49;
            SetType = Models.SetType.Deluxe_Expansion;

            addHero("Brand son of Bain", 10, Sphere.Leadership, 2, 3, 2, 3)
                .WithTraits("Dale.", "Noble.")
                .WithText("Each Dale character you control with a player attachment gets +1 Willpower.\r\nResponse: After you play an attachment on a Dale character without an attachment, draw a card.")
                .WithFlavor("\"He is a strong king, and his realm now reaches south and east of Esgaroth.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(1, 1, Artist.Antonio_Jose_Manzanedo);
            addCard(LotRCard.Hero("Bard son of Brand", string.Empty, Sphere.Spirit, 9, 2, 2, 2, 3)
                .WithTraits("Dale.", "Noble.")
                .WithText("While playing an Item attachment, Bard son of Brand is considered to have the printed Leadership, Lore, and Tactics icons.\r\nResponse: When a character leaves play, return each attachment attached to that character to its owners hand. (Limit once per phase.)")
                .WithInfo(2, 1, Artist.Antonio_Jose_Manzanedo));
            addAlly("Redwater Sentry", 3, Sphere.Leadership, false, 0, 1, 2, 3)
                .WithTraits("Dale.", "Warrior.")
                .WithText("Reduce the cost to play Armor attachments on Redwater Sentry by 1.\r\nRedward Sentry gets +1 Defense and gains sentinel while it has an Armor attachment.")
                .WithInfo(3, 3, Artist.JB_Casacop);
            addAlly("North Realm Lookout", 2, Sphere.Spirit, false, 1, 1, 1, 2)
                .WithTraits("Dale.", "Scout.")
                .WithText("North Realm Lookout gets +1 Willpower and does not exhaust to quest while it has an Item attachment.")
                .WithFlavor("There were people on the look-out on the banks.\r\n-The Hobbit")
                .WithInfo(4, 3, Artist.JB_Casacop);
            addAlly("Warrior of Dale", 3, Sphere.Tactics, false, 0, 2, 1, 3)
                .WithTraits("Dale.", "Warrior.")
                .WithText("Reduce the cost to play Weapon attachments on ~Warrior of ~Dale by 1.\r\n~Warrior of ~Dale gets +1 Attack and gains ranged while it has a Weapon attachment.")
                .WithInfo(5, 3, Artist.Aleksander_Karcz);
            addCard(LotRCard.Ally("Long Lake Trader", Sphere.Lore, 2, 1, 1, 0, 2)
                .WithTraits("Dale.")
                .WithText("Action: Exhaust Long Lake Trader to move an Item attachment from a character you control to another eligible character.")
                .WithFlavor("\"Nowhere are there any men so friendly to us as the Men of Dale.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Torbjorn_Kallstrom));
            addAttachment("Hauberk of Mail", 1, Sphere.Leadership, false)
                .WithTraits("Item.", "Armor.")
                .WithText("Attach to a Dale or Warrior character. Limit 1 per character.\r\nAttached character gets +1 Defense (and +1 hit point if attached character has the sentinel keyword).")
                .WithFlavor("Each one of his folk was clad in hauberk of steel mail that hung to his knees...\r\n-The Hobbit")
                .WithInfo(7, 3, Artist.Sara_Biddle);
            addAttachment("King of Dale", 2, Sphere.Spirit, true)
                .WithTraits("Title.")
                .WithText("Attach to a Dale or Esgaroth hero.\r\nPlanning Action: Exhaust King of ~Dale to reduce the cost of the next Dale ally you play this phase by 1 for each different player attachment on attached hero. That ally does not require a resource match.")
                .WithFlavor("Then Bard II, Brand's son, became King of Dale..\r\n-The Return of the King")
                .WithInfo(8, 3, Artist.Antonio_Jose_Manzanedo);
            addAttachment("Bow of Yew", 0, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dale or Warrior character.\r\nResponse: After attack character is declaed as an attacker, exhaust Bow of Yew to deal 1 damage to the defending enemy.")
                .WithFlavor("\"They would shoot at us with their great bows of yew...\"\r\n-The Lord of the Eagles, The Hobbit")
                .WithInfo(9, 3, Artist.Sara_Biddle);
            addAttachment("Map of Rhovanion", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithText("Attach to a Dale or Scout character. Limit 1 per character.\r\nResponse: After attached character commits to the quest, place 1 progress on the active location.")
                .WithFlavor("\"You are come to the very edge of the Wild...\"\r\n-Gandalf, The Hobbit")
                .WithInfo(10, 3, Artist.Yoann_Boissonnet);
            addCard(LotRCard.Attachment("Necklace of Girion", string.Empty, Sphere.Neutral, 1)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Guarded (enemy or location).")
                .WithText("Attach to a hero.\r\nAttached hero gets +2 Willpower and collects an additional resource during the resource phase.")
                .WithFlavor("...the necklace of Girion, Lord of Dale, made of five hundred emeralds green as grass, which he gave for the arming of his eldest son...\r\n-The Hobbit")
                .WithInfo(11, 3, Artist.Drazenka_Kimpel));
            addCard(LotRCard.Event("Traffic from Dale", string.Empty, Sphere.Leadership, 1)
                .WithText("Planning Action: Choose a Dale hero you control. Add 1 resource to its pool for each character you control with a player attachment. You can only play 1 copy of Traffic from ~Dale each round.")
                .WithFlavor("The talk was all of the trade that came and went on the waterways and the growth of the traffic on the river...\r\nThe Hobbit")
                .WithInfo(12, 3, Artist.Torbjorn_Kallstrom));
            addEvent("To Arms!", 0, Sphere.Spirit)
                .WithText("Action: Choose an ally with a player attachment. Ready that ally.")
                .WithFlavor("...the grim-voiced fellow ran hotfoot to the Master. \"The dragon is coming or I am a fool!\" he cried. \"Cut the bridges! To arms! To arms!\"\r\n-The Hobbit")
                .WithInfo(13, 3, Artist.Aleksander_Karcz);
            addEvent("Valour of the North", 0, Sphere.Tactics)
                .WithText("Response: After a character is declared as an attacker or defender against an enemy with an attachment, that character gets +3 Attack and +3 Defense until the end of this attack.")
                .WithFlavor("\"Dwarf-mail may be good, but they will soon be hard put to it.\"\r\n-Bard the Bowman, The Hobbit")
                .WithInfo(14, 3, Artist.Ivan_Dixon);
            addEvent("Bartering", 0, Sphere.Lore)
                .WithText("Planning Action: Choose a ready player attachment on a character you control. Return that attachment to its owner's hand to reduce the cost of the next attachment played this phase by X, where X is the chosen attachment's cost.")
                .WithInfo(15, 3, Artist.Torbjorn_Kallstrom);
            addLocation("The Old Ford", EncounterSet.JourneyUpTheAnduin.Name, 5, 5)
                .WithUnique()
                .WithTraits("Riverland.")
                .WithText("Immune to player card effects.\r\nThe Old Ford gets +5 quest points for each enemy in play.\r\nForced: After The Old Ford becomes the active location, each enemy in the staging area makes an immediate attack against the first player.")
                .WithInfo(16, 1, Artist.Mariusz_Gandzel);
            addLocation("Wooded Riverbank", EncounterSet.JourneyUpTheAnduin.Name, 3, 1)
                .WithTraits("Riverland.")
                .WithText("Forced: When Wooded Riverbank is explored, put the top card of the Evil Creatures deck into play engaged with the first player.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithInfo(17, 3, Artist.David_Demaret);
            addTreachery("Frenzied Creature", EncounterSet.JourneyUpTheAnduin.Name)
                .WithText("When Revealed: Add the top card of the Evil Creatures deck to the staging area and attach Frenzied Creature to it. (Counts as a Condition attachment with the text: \"Attached enemy gets +1 Threat, +1 Attack, +1 Defense and is immune to player card effects\")")
                .WithShadow("Shadow: Attach this card to attacking enemy.")
                .WithEasyModeQuantity(1)
                .WithInfo(18, 2, Artist.Alexander_Kozachenko);
            addTreachery("Dangerous Crossing", EncounterSet.JourneyUpTheAnduin.Name)
                .WithText("When Revealed: Each player assigns X damage among characters he controls, where X is the total Threat of the active location. If X is less than 3, Treacherous Crossing gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is damaged).")
                .WithInfo(19, 3, Artist.John_Gravato);
            addEnemy("Goblin Troop", EncounterSet.GreyMountainGoblins.Name, 35, 3, 5, 4, 6)
                .WithTraits("Orc.", "Goblin.")
                .WithText("Cannot have player card attachments.\r\nWhile Goblin Troop is engaged with you, each other Goblin enemy engaged with you gets +1 Attack and +1 Defense.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(20, 2, Artist.Stanislav_Dikolenko);
            addEnemy("Stray Goblin", EncounterSet.GreyMountainGoblins.Name, 50, 1, 2, 0, 3)
                .WithTraits("Orc.", "Goblin.")
                .WithKeywords("Surge.")
                .WithText("Cannot be optionally engaged.\r\nWhile Stray Goblin is in the staging area, it gains: \"Forced: After a player engages an enemy, Stray Goblin engages that player.\"")
                .WithShadow("Shadow: Add Stray Goblin to staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(21, 3, Artist.Carolina_Eade);
            addEnemy("Pack of Wargs", EncounterSet.HillsOfWilderland.Name, 40, 4, 4, 3, 5)
                .WithTraits("Creature.", "Warg.")
                .WithText("Forced: If Pack of Wargs is dealt a shadow card with no effect, Pack of Wargs makes an additional attack after this one. (Do not deal it a shadow card.)")
                .WithShadow("Shadow: Return attacking enemy to the staging area after this attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(22, 2, Artist.Lukasz_Jaskolski);
            addLocation("Hills of Wilderland", EncounterSet.HillsOfWilderland.Name, 254, 254)
                .WithTraits("Hills.")
                .WithText("X is the number of characters controlled by the player with the most characters.\r\nQuest Action: Exhaust a character to reduce Hills of Wilderland Threat by 1 until the end of the phase. Only the first player can trigger this effect.")
                .WithEasyModeQuantity(1)
                .WithInfo(23, 2, Artist.Leanna_Crossan);
            addLocation("Lonely Lands", EncounterSet.HillsOfWilderland.Name, 2, 5)
                .WithTraits("Hills.")
                .WithText("Lonely Lands gets +2 Threat for each facedown card under it.\r\nWhile Lonely Lands is in the staging area, it gains: \"Forced: After an event is played during the quest phase, place it facedown under Lonely Lands.\"")
                .WithEasyModeQuantity(2)
                .WithInfo(24, 3, Artist.Leanna_Crossan);
            addTreachery("Ruined Supplies", EncounterSet.LostInWilderland.Name)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player must choose: either raise your threat by 1 for each ally you control, or deal 1 damage to each ally you control.")
                .WithShadow("Shadow: Raise your threat by 1 for each enemy engaged with you.")
                .WithEasyModeQuantity(1)
                .WithInfo(25, 2, Artist.Diego_Gisbert_Llorens);
            addTreachery("Lost in the Wild", EncounterSet.LostInWilderland.Name)
                .WithText("When Revealed: The player with the most cards in his hand without a copy of Lost in the Wilderness adds Lost in the Wild to his hand. (While in a player’s hand, Lost in the Wild gains: \"Cannot be discarded by player card effect. Forced: After you play a card, discard each card in your hand.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(26, 2, Artist.Borja_Pindado);
            addTreachery("Weighed Down", EncounterSet.LostInWilderland.Name)
                .WithText("When Revealed: Attach to the hero with the most attachments without Weighed Down attached. Then, exhaust attached hero. (Counts as a Condition attachment with the text: \"Forced: After attached hero readies, choose and discard an attachment from it. You cannot choose Weighed Down unless attached hero has no other non-objective attachments.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(27, 2, Artist.David_Keen);
            addObjective("Searching for a Way Out", EncounterSet.LostInMirkwood.Name)
                .WithText("Each objective-location, and each card guarding one, is immune to player card effects.\r\nForced: When progress would be placed on the main quest, if there are no objective-locations in play, discard an equal number of cards from the encounter deck instead. Then, put the topmost objective-location in the encounter discard pile into play.")
                .WithInfo(28, 1, Artist.Drazenka_Kimpel);
            addObjectiveLocation("Overgrown Path", EncounterSet.LostInMirkwood.Name, 4, true, 4)
                .WithTraits("Forest.")
                .WithKeywords("Guarded (location).")
                .WithText("Travel: Shuffle the encounter discard pile into the encounter deck. Each player discards the top card of the encounter deck and assigns X damage among characters he controls, where X is that card's Threat.\r\nForced: After the players travel here, advance to the next stage A, if able.")
                .WithInfo(29, 1, Artist.Rafal_Hrynkiewicz);
            addObjectiveLocation("Abandoned Village", EncounterSet.LostInMirkwood.Name, 4, true, 4)
                .WithTraits("Forest.")
                .WithKeywords("Guarded (location).")
                .WithText("Travel: Shuffle the encounter discard pile into the encounter deck. Each player discards the top card of the encounter deck. Add each enemy discarded this way to the staging area.\r\nForced: After the players travel here, advance to the next stage C, if able.")
                .WithInfo(30, 1, Artist.Mariusz_Gandzel);
            addObjectiveLocation("Bare Hilltop", EncounterSet.LostInMirkwood.Name, 4, true, 4)
                .WithTraits("Forest.")
                .WithKeywords("Guarded (enemy).")
                .WithText("Travel: Shuffle the encounter discard pile into the encounter deck. Each player discards the top card of the encounter deck. Add each location discarded this way to the staging area.\r\nForced: After the players travel here, advance to the next stage A, if able.")
                .WithInfo(31, 1, Artist.Niten);
            addObjectiveLocation("Forest Clearing", EncounterSet.LostInMirkwood.Name, 4, true, 4)
                .WithTraits("Forest.")
                .WithKeywords("Guarded (enemy).")
                .WithText("Travel: Shuffle the encounter discard pile into the encounter deck. Each player discards the top card of the encounter deck and raises his threat by X, where X is that card's Threat.\r\nForced: After the players travel here, advance to the next stage C, if able.")
                .WithInfo(32, 1, Artist.Niten);
            addLocation("Twilight Hall", EncounterSet.LostInMirkwood.Name, 2, 6)
                .WithTraits("Forest.", "Dark.")
                .WithText("Twilight Hall gets +2 Threat for each resource on it.\r\nForced: After a Forest location is explored, place 1 resource here.\r\nTravel: Raise each player's threat by 1 for each resource here. If there are no resources on Twilight Hall, the players cannot travel here.")
                .WithEasyModeQuantity(2)
                .WithInfo(33, 3, Artist.Katy_Grierson);
            addEnemy("Mirkwood Patrol", EncounterSet.LostInMirkwood.Name, 40, 4, 5, 3, 6)
                .WithTraits("Orc.")
                .WithText("Forced: At the end of the encounter phase, if Mirkwood Patrol is in the staging area with an unguarded objective-location, attach that objective-location to Mirkwood Patrol, guarding it.")
                .WithShadow("Shadow: The defender cannot ready this round.")
                .WithEasyModeQuantity(1)
                .WithInfo(34, 2, Artist.Matt_Stewart);
            addEnemy("Ravenous Spider", EncounterSet.LostInMirkwood.Name, 36, 3, 4, 3, 5)
                .WithTraits("Creature.", "Spider.")
                .WithText("Forced: After Ravenous Spider engages you, it makes an immediate attack.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(35, 2, Artist.Alvaro_Calvo_Escudero);
            addTreachery("Unseen Danger", EncounterSet.LostInMirkwood.Name)
                .WithText("When Revealed: Each player removes a character he controls from the quest and discards the top card of the encounter deck. If the discarded card's printed Threat is greater than the removed character's Willpower, discard that character.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack and +2 Defense if it is guarding a card.")
                .WithEasyModeQuantity(1)
                .WithInfo(36, 2, Artist.Joe_Wilson);
            addTreachery("Vastness of Mirkwood", EncounterSet.LostInMirkwood.Name)
                .WithText("When Revealed: Until the end of the phase, each non-objective location in the staging area gets +1 Threat (+2 Threat instead if it has at least 1 progress token on it). If the number of non-objective locations in the staging area is less than the number of players, Vastness of Mirkwood gains surge.")
                .WithInfo(37, 3, Artist.Katy_Grierson);
            addLocation("Accursed Forest", EncounterSet.DarkWoods.Name, 4, 4)
                .WithTraits("Forest.", "Dark.")
                .WithText("While Accursed Forest is in the staging area, \"when revealed\" effects cannot be canceled.\r\nTravel: Reveal the top card of the encounter deck.")
                .WithFlavor("There was a breath of air and a noise of wind, but it had a sad sound.\r\n-The Hobbit")
                .WithEasyModeQuantity(1)
                .WithInfo(38, 2, Artist.Leanna_Crossan);
            addLocation("Dark Black Woods", EncounterSet.DarkWoods.Name, 3, 3)
                .WithTraits("Forest.", "Dark.")
                .WithText("While Dark Black Woods is in the staging area, no more than 1 progress can be placed on each Forest location in the staging area each round.\r\nTravel: Each player discards the top card of the encounter deck. Add each enemy discarded this way to the staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(39, 3, Artist.Leanna_Crossan);
            addTreachery("Gathering Gloom", EncounterSet.GatheringGloom.Name)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player must choose: either raise your threat by 1 for each ally you control, or reveal an encounter card.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, discard an ally you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(40, 2, Artist.Borja_Pindado);
            addTreachery("Swarm of Bats", EncounterSet.GatheringGloom.Name)
                .WithText("When Revealed: Each player discards each resource from each of his hero's resource pools and raises his threat by 1 for each resource he discarded this way. If no resources were discarded this way, Swarm of Bats gains surge.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character has an attachment).")
                .WithEasyModeQuantity(2)
                .WithInfo(41, 3, Artist.Nicholas_Gregory);
            addEnemy("Fire-drake", EncounterSet.TheKingsQuest.Name, 35, 0, 7, 254, 17)
                .WithUnique()
                .WithTraits("Dragon.")
                .WithText("Cannot have non-Dragon attachments.\r\nX is 1 more than the number of players.\r\nForced: After the active location is explored, Fire-drake returns to the staging area and makes an immediate attack against each player in turn order.")
                .WithInfo(42, 1, Artist.Jokubas_Uoginitas);
            addLocation("Dragon Hoard", EncounterSet.TheKingsQuest.Name, 7, 7)
                .WithUnique()
                .WithTraits("Underground.", "Dark.", "Lair.")
                .WithText("Immune to player card effects.\r\nFire-drake cannot take damage.\r\nResponse: After Dragon Hoard becomes the active location, the first player chooses a player to attach an Artifact attachment from his hand to Dragon Hoard. That attachment gains the guarded (location) keyword. If that attachment has the printed guarded keyword, do not resolve it when the attachment enters play.")
                .WithInfo(43, 1, Artist.Nele_Diel);
            addLocation("Iron Hills Mine", EncounterSet.TheKingsQuest.Name, 4, 4)
                .WithTraits("Underground.")
                .WithText("While Iron Hills Mine is the active location, it gains: \"Response: When Iron Hills Mine is explored, each player may return 1 card from his discard pile to his hand.\"\r\nTravel: Each player discards the top 4 cards of his deck to travel here.")
                .WithEasyModeQuantity(1)
                .WithInfo(44, 2, Artist.Igor_Burlakov);
            addLocation("Contested Depths", EncounterSet.TheKingsQuest.Name, 1, 5)
                .WithTraits("Underground.")
                .WithText("Contested Depths gets +1 Threat for each location in the victory display.\r\nForced: After the players travel to Contested Depths, either raise each player's threat by 1 for each location in the victory display, or discard Contested Depths and replace it with the top card of the Caves deck.")
                .WithInfo(45, 3, Artist.Paolo_Puggioni);
            addLocation("Deep Chasm", EncounterSet.TheKingsQuest.Name, 2, 6)
                .WithTraits("Underground.", "Dark.")
                .WithKeywords("Deep.")
                .WithText("When faced with the option to travel, the players must travel to Deep Chasm if there is no active location.")
                .WithFlavor("The chasm was long and dark, and filled with the noise of wind and rushing water and echoing stone.\r\n-The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(46, 2, Artist.Leanna_Crossan);
            addTreachery("Denizen of the Deep", EncounterSet.TheKingsQuest.Name)
                .WithText("When Revealed: The highest Attack enemy in the staging area makes an immediate attack against the first player. If no attack is made this way, Denizen of the Deep gains surge.")
                .WithShadow("Shadow: Attacking enemy makes an additional attack against you after this one.")
                .WithEasyModeQuantity(1)
                .WithInfo(47, 2, Artist.Jon_Bosco);
            addTreachery("Afraid of the Dark", EncounterSet.AfraidOfTheDark.Name)
                .WithText("When Revealed: Attach to a questing hero and remove it from the quest. (Counts as a Condition attachment with the text: \"Limit 1 per hero. While the active location has the Dark trait, reduce attached hero's Willpower to 0 and treat its text box as if it were blank, except for Traits.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(48, 2, Artist.Borja_Pindado);
            addEnemy("Stone-troll", EncounterSet.FellBeasts.Name, 36, 3, 6, 3, 9)
                .WithTraits("Troll.")
                .WithText("Cannot have non-objective attachments.\r\nForced: After Stone-troll attacks and destroys a character you control, discard 1 card from your hand for each excess point of damage dealt.")
                .WithShadow("Shadow: Discard an attachment you control.")
                .WithEasyModeQuantity(1)
                .WithInfo(49, 2, Artist.Sebastian_Zakrzewski);
            addEnemy("Hobgoblin", EncounterSet.FellBeasts.Name, 38, 1, 1, 1, 5)
                .WithTraits("Orc.")
                .WithText("While Hobgoblin is guarding a card, it gets +X Threat, +X Attack, and +X Defense, where X is that card's cost.\r\nForced: After Hobgoblin enters play, the first player attaches the top card of his deck to Hobgoblin faceup as a guarded attachment. When Hobgoblin leaves play, return the card it was guarding to its owner’s hand.")
                .WithEasyModeQuantity(1)
                .WithInfo(50, 2, Artist.Martin_de_Diego_Sadaba);
            addEnemy("Werewolf", EncounterSet.WildCreatures.Name, 33, 3, 2, 1, 8)
                .WithTraits("Creature.")
                .WithText("Werewolf gets +1 Attack for each damage on it.\r\nForced: After Werewolf is dealt a shadow card with no shadow effect, deal 1 damage to it and the defending character.")
                .WithShadow("Shadow: Deal 1 damage to the defending character.")
                .WithEasyModeQuantity(1)
                .WithInfo(51, 2, Artist.Jon_Bosco);
            addEnemy("Giant Spider", EncounterSet.WildCreatures.Name, 28, 2, 3, 2, 3)
                .WithTraits("Creature.", "Spider.")
                .WithText("Forced: After Giant Spider attacks and damages a character, that character cannot ready until the end of the round.")
                .WithShadow("Shadow: Defending character cannot ready until the end of the round.")
                .WithInfo(52, 3, Artist.Rafal_Hrynkiewicz);
            addEnemy("Black Bats", EncounterSet.WildCreatures.Name, 18, 1, 2, 1, 2)
                .WithTraits("Creature.")
                .WithKeywords("Surge.")
                .WithText("While the active location has the Dark trait, Black Bats cannot take damage.\r\nShadow: If the active location has the Dark trait, attacking enemy cannot take damage this phase.")
                .WithEasyModeQuantity(2)
                .WithInfo(53, 3, Artist.Lukasz_Jaskolski);
            addLocation("Dark Tunnel", EncounterSet.DeepUnderground.Name, 3, 3)
                .WithTraits("Underground.", "Dark.")
                .WithKeywords("Deep.")
                .WithText("While Dark Tunnel is in the staging area, progress cannot be placed on Dark locations in the staging area.")
                .WithFlavor("The tunnel seemed to have no end. All he knew was that it was going down pretty steadily...\r\n-The Hobbit")
                .WithEasyModeQuantity(3)
                .WithInfo(54, 4, Artist.Leanna_Crossan);
            addLocation("Forked Passage", EncounterSet.DeepUnderground.Name, 2, 2)
                .WithTraits("Underground.", "Dark.")
                .WithKeywords("Deep.")
                .WithText("Response: When you travel to Forked Passage (before resolving the deep keyword), raise each player’s threat by 2 to look at the top 2 cards of the Caves deck. Put 1 on top of the Caves deck and put the other on the bottom. Then, add Forked Passage to the victory display.")
                .WithInfo(55, 2, Artist.Davis_Engel);
            addTreachery("Dark Places", EncounterSet.DeepUnderground.Name)
                .WithText("When Revealed: Add the total Threat of the active location to the total Threat in the staging area until the end of the phase. If there is no active location, discard cards from the top of the encounter deck until a location is discarded and add it to the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack.")
                .WithInfo(56, 3, Artist.Igor_Burlakov);
            addTreachery("Eyes in the Dark", EncounterSet.AfraidOfTheDark.Name)
                .WithKeywords("Doomed 1.")
                .WithText("When Revealed: Each player must choose: either raise your threat by 1 for each questing character you control, or discard a questing character you control.")
                .WithShadow("Shadow: If this attack is undefended, discard an ally you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(57, 3, Artist.Sam_Lamont);
            addTreachery("Dragon Breath", EncounterSet.DragonMight.Name)
                .WithTraits("Dragon.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to a Dragon enemy. (Counts as a Condition attachment with the text: \"Limit 1 per enemy. Forced: When attached enemy attacks you, deal 1 damage to each character you control. Then, discard Dragon Breath.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(58, 2, Artist.Matthew_Cowdery);
            addTreachery("Dragon Scales", EncounterSet.DragonMight.Name)
                .WithTraits("Dragon.")
                .WithKeywords("Surge.")
                .WithText("When Revealed: Attach to a Dragon enemy. (Counts as a Condition attachment with the text: \"Limit 1 per enemy. Forced: When attached enemy would take any amount of damage, cancel all of that damage. Then, discard Dragon Scales.\")")
                .WithEasyModeQuantity(1)
                .WithInfo(59, 2, Artist.Matthew_Cowdery);
            addLocation("Lost Armory", EncounterSet.LostCaves.Name, 2, 2)
                .WithTraits("Underground.")
                .WithText("Response: After Lost Armory becomes the active location, each player may search his deck for a Weapon or Armor attachment, add it to his hand, and shuffle his deck. Limit once per game for the group.")
                .WithFlavor("Behind him where the walls were nearest could dimly be seen coats of mail, helms and axes, swords and spears hanging...\r\n-The Hobbit")
                .WithVictoryPoints(1)
                .WithInfo(60, 1, Artist.Leanna_Crossan);
            addLocation("Ancient Treasury", EncounterSet.LostCaves.Name, 3, 3)
                .WithTraits("Underground.")
                .WithText("Response: After Ancient Treasury becomes the active location, each player may (choose one): reduce his threat by 3, draw 2 cards, or add 1 resource to a hero's resource pool. Limit once per game for the group.")
                .WithFlavor("...there in rows stood great jars and vessels filled with a wealth that could not be guessed.\r\n-The Hobbit")
                .WithVictoryPoints(1)
                .WithInfo(61, 1, Artist.Leanna_Crossan);
            addLocation("Frightful Den", EncounterSet.LostCaves.Name, 4, 4)
                .WithTraits("Underground.", "Dark.")
                .WithText("Forced: After Frightful Den becomes the active location, shuffle the encounter discard pile into the encounter deck and discard cards from the top until X enemies are discarded, where X is the number of players. Add each enemy discarded this way to the staging area.")
                .WithVictoryPoints(1)
                .WithInfo(62, 1, Artist.Jose_Vega);
            addLocation("Lightless Grotto", EncounterSet.LostCaves.Name, 5, 5)
                .WithTraits("Underground.", "Dark.")
                .WithText("Forced: After the players commit characters to the quest, discard cards from the encounter deck until a treachery is discarded. Resolve the ‘when revealed’ effect on that treachery.")
                .WithFlavor("He did not go much further, but sat down on the cold floor and gave himself up to complete miserableness...\r\n-The Hobbit")
                .WithVictoryPoints(1)
                .WithInfo(63, 1, Artist.Ivan_Dixon);
            addLocation("Crumbling Cavern", EncounterSet.LostCaves.Name, 6, 6)
                .WithTraits("Underground.", "Dark.")
                .WithText("Forced: After Crumbling Cavern becomes the active location, each player assigns X damage among characters he controls, where X is the number of characters he controls.")
                .WithFlavor("...he was slipping - beginning to fall down, down, goodness knows where to.\r\n-The Hobbit")
                .WithVictoryPoints(1)
                .WithInfo(64, 1, Artist.Jose_Vega);
            addLocation("Underground Lake", EncounterSet.LostCaves.Name, 254, 254)
                .WithTraits("Underground.", "Dark.")
                .WithText("X is the number of characters controlled by the player who controls the most characters.\r\nForced: After an ally enters player, exhaust it.")
                .WithFlavor("...without warning he trotted splash into water! Ugh! it was icy cold. That pulled him up sharp and short.\r\n-The Hobbit")
                .WithVictoryPoints(1)
                .WithInfo(65, 1, Artist.Nele_Diel);
            addQuest("Traveling North", EncounterSet.JourneyUpTheAnduin.Name, 1, 'A', 10)
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.HillsOfWilderland, EncounterSet.LostInWilderland, EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands)
                .WithText("Forced: After placing progress here from questing successfully, place 1 resource here.\r\nForced: At the beginning of the encounter phase, remove 1 resource from this stage. Then, add the top card of the Evil Creatures deck to the staging area.\r\nThis stage cannot be defeated while an enemy from the Evil Creatures deck in play.")
                .WithOppositeFlavor("While traveling north through the Vales of Anduin on your way to Dale, you are alarmed by the number of dangerous creatures that you encounter.")
                .WithOppositeText("Setup: Set Woodmen Village and The Old Ford aside, out of play. Create the Evil Creatures deck (see insert) and place it next to the quest deck. Shuffle the encounter deck and discard cards from the top until X locations are discarded, where X is the number of players. Add each discarded location to the staging area.")
                .WithInfo(66, 1, Artist.Stanislav_Dikolenko);
            addQuest("Woodmen Under Attack", EncounterSet.JourneyUpTheAnduin.Name, 2, 'A', 5)
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.HillsOfWilderland, EncounterSet.LostInWilderland, EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands)
                .WithFlavor("Dark, black smoke rises above the trees in the distance. As you draw nearer to the rising cloud, you hear the cry of Orc voices, the howling of Wargs, and the ring of steel. A small group of Woodmen fight desperately to defend their village from a vicious attack. You rush to their aid.")
                .WithText("When Revealed: The first player adds Woodman Village to the staging area. Each other player reveals an encounter card.")
                .WithOppositeText("No more than 1 progress can be placed on each location in the staging area each round.\r\nForced: After the players travel to a location, add the top card of the Evil Creatures deck to the staging area.\r\nThe players cannot defeat this stage unless the first player controls Haldan.")
                .WithInfo(67, 1, Artist.Alexander_Kozachenko);
            addQuest("The Passage of the Ford", EncounterSet.JourneyUpTheAnduin.Name, 3, 'A', 5)
                .WithIncludedEncounterSets(EncounterSet.GreyMountainGoblins, EncounterSet.HillsOfWilderland, EncounterSet.LostInWilderland, EncounterSet.JourneyAlongTheAnduin, EncounterSet.Wilderlands)
                .WithFlavor("Grateful for your help, one of the Woodmen offers to journey with you to The Old Ford. He wants to warn Grimbeorn of the growing danger, but when you reach the forst you find the Beornings already fighting to defend the passage of the river from dangerous creatures.")
                .WithText("When Revealed: The first player adds The Old Ford to the staging area. Each other player adds the top card of the Evil Creatures deck to the staging area.")
                .WithOppositeText("The players cannot travel toThe Old Ford unless there is at least 5 progress here.\r\nForced: At the beginning of the quest phase, add the top card of the Evil Creatures deck to the staging area.\r\nThis stage cannot be defeated while The Old Ford is in play. When The Old Ford is explored, the players win the game.")
                .WithInfo(68, 1, Artist.Carlos_Palma_Cruchaga);
            addLocation("Woodmen Village", EncounterSet.JourneyUpTheAnduin.Name, 4, 4)
                .WithUnique()
                .WithTraits("Riverland.")
                .WithText("Immune to player card effects.\r\nForced: When Woodmen Village is explored, add the top card of the Evil Creatures deck to the staging area. Then, flip over Woodmen Village and attach Haldan to the just-added enemy as a guarded objective.")
                .WithInfo(69, 1, Artist.Mariusz_Gandzel);
            addObjectiveAlly("Haldan", EncounterSet.JourneyUpTheAnduin.Name, 2, 3, 1, 4)
                .WithUnique()
                .WithTraits("Woodman.", "Scout.")
                .WithText("The first player gains control of Haldan while he is free of encounters.\r\nWhile there is an active location, Haldan does not exhaust to quest.\r\nIf Haldan leaves play, the players lose the game.")
                .WithInfo(70, 1, Artist.Alexander_Kozachenko);
            addQuest("Ambushed at Night", EncounterSet.LostInMirkwood.Name, 1, 'A', 255)
                .WithIncludedEncounterSets(EncounterSet.DarkWoods, EncounterSet.GatheringGloom, EncounterSet.PassageThroughMirkwood, EncounterSet.SpidersOfMirkwood, EncounterSet.DolGuldurOrcs)
                .WithFlavor("After several days of traveling through Mirkwood, you awaken suddenly in the night to see dozens of hungry eyes glaring at you from the darkness.")
                .WithText("Setup: Set the Spiders of Mirkwood and Dol Guldur Orcs encounter sets aside, out of play. The first player takes control of Haldan and adds Searching for a Way Out to the staging area. Each player adds 1 Forest Spider to the staging area. Shuffle the encounter deck.")
                .WithOppositeFlavor("There is a bitter fight not only to drive back the spiders but to avoid being separated in the pitch black. When the first light of dawn rises to reveal your surroundings, you see only endless trees and no sign of your path. You begin searching about for some type of landmark to point you in the right direction.")
                .WithOppositeText("Each player’s threat cannot be reduced by player card effect.\r\nForced: After an enemy engages a player, raise that player’s threat by 1.")
                .WithInfo(71, 1, Artist.Nikolas_Hagialas);
            addQuest("Spiders of Mirkwood", EncounterSet.LostInMirkwood.Name, 2, 'A', 255)
                .WithIncludedEncounterSets(EncounterSet.DarkWoods, EncounterSet.GatheringGloom, EncounterSet.PassageThroughMirkwood, EncounterSet.SpidersOfMirkwood, EncounterSet.DolGuldurOrcs)
                .WithFlavor("You've got a better idea of where you are, but you have unfortunately wandered too far north and into the territory of the giant spiders of Mirkwood.")
                .WithText("When Revealed: Shuffle the Spiders of Mirkwood encounter set into the encounter deck. Then, reveal 1 encounter card per player.")
                .WithOppositeFlavor("There is a bitter fight not only to drive back the spiders but to avoid being separated in the pitch black. When the first light of dawn rises to reveal your surroundings, you see only endless trees and no sign of your path. You begin searching about for some type of landmark to point you in the right direction.")
                .WithOppositeText("Each player’s threat cannot be reduced by player card effect.\r\nForced: After an enemy engages a player, raise that player’s threat by 1.")
                .WithInfo(72, 1, Artist.Nikolas_Hagialas);
            addQuest("Dol Guldur Orcs", EncounterSet.LostInMirkwood.Name, 2, 'C', 255)
                .WithIncludedEncounterSets(EncounterSet.DarkWoods, EncounterSet.GatheringGloom, EncounterSet.PassageThroughMirkwood, EncounterSet.SpidersOfMirkwood, EncounterSet.DolGuldurOrcs)
                .WithFlavor("You've got a better idea of where you are, but you have unfortunately wandered too far south and into the territory of the Orcs of Dol Guldur.")
                .WithText("When Revealed: Shuffle the Dol Guldur Orcs encounter set into the encounter deck. Then, reveal 1 encounter card per player.")
                .WithOppositeFlavor("You fight to keep the Orcs at bay as you continue to search for landmarks or a better view of the forest to find your way out.")
                .WithOppositeText("The first Orc enemy revealed each quest phase gains surge.\r\nForced: When an Orc enemy attacks and damages a character, that character’s controller chooses and discards 1 card from his hand.")
                .WithInfo(73, 1, Artist.Carlos_Palma_Cruchaga);
            addQuest("Carried Away", EncounterSet.LostInMirkwood.Name, 3, 'A', 255)
                .WithIncludedEncounterSets(EncounterSet.DarkWoods, EncounterSet.GatheringGloom, EncounterSet.PassageThroughMirkwood, EncounterSet.SpidersOfMirkwood, EncounterSet.DolGuldurOrcs)
                .WithFlavor("As night falls some of your companions are carried off by unseen foes. You follow the sound of their cries in order to rescue them.")
                .WithText("When Revealed: Each player chooses a hero he controls, discards each token and attachment from that hero, and places it in the staging area. Each player discards cards from the top of the encounter deck until an enemy is discarded and attaches that enemy to the hero he owns in the staging area, guarding it.")
                .WithOppositeText("Each enemy guarding a hero cannot take non-combat damage. Each guarded hero is in play but under no player's control.\r\nForced: When an enemy guarding a hero is defeated, return that hero to its owner’s control exhausted.\r\nWhen the players advance from this stage, discard each guarded hero.")
                .WithInfo(74, 1, Artist.Joel_Hustak);
            addQuest("Truly Lost", EncounterSet.LostInMirkwood.Name, 3, 'C', 255)
                .WithIncludedEncounterSets(EncounterSet.DarkWoods, EncounterSet.GatheringGloom, EncounterSet.PassageThroughMirkwood, EncounterSet.SpidersOfMirkwood, EncounterSet.DolGuldurOrcs)
                .WithFlavor("Exhaustion begins to take its toll as you stumble through the endless forest. Supplies grow sparse and you struggle to find anything that can help.")
                .WithText("When Revealed: Each player discards cards from the top of the encounter deck until he discards a non-objective lcoation and adds it to the staging area. Each player places his hand of cards facedown under a different location in the staging area.")
                .WithOppositeText("Each location gets +1 quest point for each facedown player card under it.\r\nForced: When a location with a facedown player card under it is explored, return each facedown player card under it to its owner’s hand.\r\nWhen the players advance from this stage, discard each facedown player card under a location.")
                .WithInfo(75, 1, Artist.Nikolas_Hagialas);
            addQuest("The Forest of Great Fear", EncounterSet.LostInMirkwood.Name, 4, 'A', 8)
                .WithIncludedEncounterSets(EncounterSet.DarkWoods, EncounterSet.GatheringGloom, EncounterSet.PassageThroughMirkwood, EncounterSet.SpidersOfMirkwood, EncounterSet.DolGuldurOrcs)
                .WithFlavor("Just when you think you've found the way out of the forest, you see an evil creature blocking your path. You dare not leave the trail after working so hard to find it, so you resolve to fight the beast and escape Mirkwood.")
                .WithText("When Revealed: Remove Searching for a Way Out from the game. Search the remaining set-aside encounter set for the enemy with the most hit points and add it to the staging area. That enemy is the “nemesis” until it leaves play.")
                .WithOppositeText("The nemesis gets +2 Threat, +2 Attack, +2 Defense and is immune to player card effects.\r\nForced: At the end of the round, return the nemesis to the staging area and it makes an attack against the first player.\r\nThis stage cannot be defeated while the nemesis is in play. The nemesis cannot take damage unless there is at least 8 progress on this stage. If the players defeat the nemesis, they win the game.")
                .WithInfo(76, 1, Artist.Martin_de_Diego_Sadaba);
            addQuest("Escape from Taur-nu-fuin", EncounterSet.LostInMirkwood.Name, 4, 'C', 16)
                .WithIncludedEncounterSets(EncounterSet.DarkWoods, EncounterSet.GatheringGloom, EncounterSet.PassageThroughMirkwood, EncounterSet.SpidersOfMirkwood, EncounterSet.DolGuldurOrcs)
                .WithFlavor("You can see light ahead from what must be the forest’s edge and it looks as if you will reach the other side, but then you hear the cry of enemies all around you. It seems that you will have to fight once more to escape from Mirkwood.")
                .WithText("When Revealed: Remove Searching for a Way Out from the game. Starting with the first player, each player discards cards from the top of the encounter deck until he discards an enemy and puts that enemy into play engaged with him.")
                .WithOppositeText("Forced: At the end of the round, raise each player’s threat by 1 for each enemy engaged with him.\r\nThis stage cannot be defeated while a player is engaged with an enemy. When this stage is defeated, the players win the game.")
                .WithInfo(77, 1, Artist.Katy_Grierson);
            addQuest("The Iron Hills", EncounterSet.TheKingsQuest.Name, 1, 'A', 0)
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.WildCreatures, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.DragonMight, EncounterSet.LostCaves)
                .WithFlavor("You have tracked the beast that attacked the village on the border of Brand’s realm to the mines beneath the Iron Hills. The Dwarves there have been driven from the lower depths by a new terror, and the mines have become a haunt for evil creatures.")
                .WithText("Setup: Build the Caves deck (see insert) and set it next to the quest deck. Set Fire-drake, Dragon Hoard, and the Dragon Might encounter sets aside, out of play. Shuffle the encounter deck. Each player discards cards from the top of the encounter deck until he discards an enemy or location and adds that card to the staging area.")
                .WithOppositeText("Forced: At the beginning of the quest phase, discard cards from the top of the encounter deck until a location is discarded. Either add that location to the staging area, or raise each player's threat by X, where X is that location's printed Threat.\r\nThis stage cannot be defeated unless there are 3 locations with victory points in the victory display.")
                .WithInfo(78, 1, Artist.Davis_Engel);
            addQuest("The Lower Depths", EncounterSet.TheKingsQuest.Name, 2, 'A', 255)
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.WildCreatures, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.DragonMight, EncounterSet.LostCaves)
                .WithFlavor("A bright flame splits the darkness, and your fears are confirmed: it was a dragon you tracked from the village. The fire-drake chased the Dwarves from their mines, and you must search out its lair somewhere in the lower depths.")
                .WithText("When Revealed: Place Dragon Hoard on the bottom of the Caves deck. Add Fire-drake to the staging area and shuffle the Dragon Might encounter set into the encounter deck.")
                .WithOppositeText("Fire-drake cannot leave the staging area or take damage.\r\nResponse: After placing progress here from questing successfully, remove 5 progress from this stage to look at the top 2 cards of the Caves deck. Put one on top of the Caves deck and put the other on the bottom.\r\nAfter The Dragon Hoard becomes the active location, advance to stage 3A.")
                .WithInfo(79, 1, Artist.Davis_Engel);
            addQuest("The Fire Worm", EncounterSet.TheKingsQuest.Name, 3, 'A', 255)
                .WithIncludedEncounterSets(EncounterSet.FellBeasts, EncounterSet.WildCreatures, EncounterSet.DeepUnderground, EncounterSet.AfraidOfTheDark, EncounterSet.DragonMight, EncounterSet.LostCaves)
                .WithFlavor("The cavern around you trembles as the dragon roars and spews fire from its mouth. For a moment, the terrifying form of the beast is lit by red-orange flame and it all becomes clear to you: the huge fire-drake must be responsible for the upheaval you’ve encountered in Wilderland. The Iron Hills and the realm of Dale will not be safe until the dragon is dead.")
                .WithText("When Revealed: Search the encounter deck and discard pile for a Dragon treachery and attach it to Fire-drake, if able. Shuffle the encounter deck.")
                .WithOppositeText("Ignore the Deep keyword.\r\nForced: After a player declares X attackers against Fire-drake, he must remove X progress tokens from the main quest or cancel the attack.\r\nThis stage cannot be defeated while Fire-drake is in play. If Fire-drake is defeated, the players win the game.")
                .WithInfo(80, 1, Artist.Jokubas_Uoginitas);
        }
    }
}