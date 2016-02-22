using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheGreyHavens : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Grey Havens";
            Abbreviation = "TGH";
            Number = 35;
            SetType = Models.SetType.Deluxe_Expansion;

            Cards.Add(Card.Hero("Círdan the Shipwright", "", Sphere.Spirit, 12, 4, 2, 2, 4)
                .WithNormalizedTitle("Cirdan the Shipwright")
                .WithTraits("Noldor.", "Noble.")
                .WithText("Draw 1 additional card at the beginning of the resource phase.\r\nForced: After drawing cards at the beginning of the resource phase, choose and discard 1 of those cards.")
                .WithFlavor("Very tall he was, and his beard was long, and he was grey and old, save that his eyes were keen as stars...\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Aleksander_Karcz));
            Cards.Add(Card.Hero("Galdor of the Havens", "", Sphere.Lore, 9, 2, 2, 1, 4)
                .WithTraits("Noldor.")
                .WithText("Response: After drawing your setup hand, instead of taking a mulligan, you may discard any number of cards from your hand. Then, draw that many cards.\r\nAction: If you have no cards in your hand, draw 6 cards. (Limit once per game.)")
                .WithFlavor("\"What power still remains lies with us...\"\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Ally("Mithlond Sea-watcher", "", Sphere.Tactics, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an ally, Mithlond Sea-watcher gets +2 Attack and gains ranged.")
                .WithFlavor("But it was an old tradition that away over there stood the Grey Havens, from which at times elven-ships set sail, never to return.\r\n-The Fellowship of the Ring")
                .WithInfo(3, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Event("Skyward Volley", "", Sphere.Tactics, 2)
                .WithText("As an additional cost to play Skyward Volley, exhaust a ranged character you control.\r\nCombat Action: Deal 2 damage to an enemy engaged with a player. Resolve that effect again for each copy of Skyward Volley currently in your discard pile (you may choose different targets).")
                .WithInfo(4, 3, Artist.Christina_Davis));
            Cards.Add(Card.Attachment("Grappling Hook", "", Sphere.Tactics, 1)
                .WithTraits("Item.")
                .WithText("Attach to a character.\r\nQuest Action: Discard Grappling Hook and exhaust attached character to commit attached character to the quest, using its Attack instead of its Willpower (or instead of its Defense if the current quest has the siege keyword).")
                .WithInfo(5, 3, Artist.Kara_Williams));
            Cards.Add(Card.Ally("Warden of the Havens", "", Sphere.Leadership, 2, 0, 1, 1, 3)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("While the top card of your discard pile is an attachment, Warden of the Havens gets +2 Defense and gains sentinel.")
                .WithFlavor("\"...and if he comes, assailing the White Towers and the Havens, hereafter the Elves may have no escape from the lengthening shadows of Middle-earth.\"\r\n-Galdor, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Dleoblack));
            Cards.Add(Card.Event("Anchor Watch", "", Sphere.Leadership, 2)
                .WithText("Response: After an enemy is declared as an attacker against you, declare an exhausted character you control as the defender. Resolve that effect again for each copy of Anchor Watch currently in your discard pile (all chosen characters are defending against this attack).")
                .WithInfo(7, 3, Artist.Adam_Schumpert));
            Cards.Add(Card.Attachment("Mariner's Compass", "", Sphere.Leadership, 1)
                .WithTraits("Item.")
                .WithText("Attach to a Leadership or a Scout character.\r\nResponse: At the beginning of the travel phase, exhaust Mariner's Compass and attached character to search the top 5 cards of the encounter deck for a location. Switch that location with a location in the staging area. Shuffle the encounter deck.")
                .WithInfo(8, 3, Artist.Lucas_Durham));
            Cards.Add(Card.Ally("Lindon Navigator", "", Sphere.Lore, 2, 2, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Scout.")
                .WithText("Lindon Navigator does not exhaust to commit to a quest, and can commit to quests while exhausted.\r\nForced: After resolving a quest to which Lindon Navigator was committed, either discard it from play or discard 1 card from your hand.")
                .WithInfo(9, 3, Artist.Tiziano_Baracchi));
            Cards.Add(Card.Event("The Evening Star", "", Sphere.Lore, 2)
                .WithText("Action: Place 2 progress on any location. Resolve that effect again for each copy of The Evening Star currently in your discard pile (you may choose new targets).")
                .WithFlavor("...for ever still a herald on\r\nar errand that should never rest\r\nto bear his shining lamp afar,\r\nthe Flammifer of Westernesse.\r\n-The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Katy_Grierson));
            Cards.Add(Card.Attachment("Explorer's Almanac", "", Sphere.Lore, 0)
                .WithGeneric()
                .WithTraits("Item.")
                .WithText("Attach to a location in the staging area.\r\nProgress from questing successfully may be placed on the attached location before it is placed on the current quest.")
                .WithInfo(11, 3, Artist.Ed_Mattinian));
            Cards.Add(Card.Ally("Sailor of Lune", "", Sphere.Spirit, 2, 1, 1, 0, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Scout.")
                .WithText("While the top card of your discard pile is an event, Sailor of Lune gets +1 Willpower and gains: \"Cannot be damaged while committed to the quest.\"")
                .WithFlavor("\"They are sailing, sailing, sailing over the Sea, they are going into the West and leaving us,\" said Sam, half chanting the words, shaking his head sadly and solemnly.\r\n-The Fellowship of the Ring")
                .WithInfo(12, 3, Artist.Owen_William_Weber));
            Cards.Add(Card.Event("Elwing's Flight", "", Sphere.Spirit, 2)
                .WithText("Quest Action: Ready a questing character and give that character +1 Willpower until the end of the phase. Resolve that effect again for each copy of Elwing's Flight currently in your discard pile (you may choose different targets).")
                .WithFlavor("There flying Elwing came to him\r\nand flame was in the darkness lit;\r\nmore bright than light of diamond\r\nthe fire upon her carcanet.\r\n-The Fellowship of the Ring")
                .WithInfo(13, 3, Artist.A_M_Sartor));
            Cards.Add(Card.Attachment("To the Sea, to the Sea!", "", Sphere.Spirit, 1)
                .WithUnique()
                .WithTraits("Song.")
                .WithText("Attach to a Noldor character.\r\nAction: Exhaust To the Sea, to the Sea! and discard X cards from your hand to reduce the cost of the next Noldor ally played this phase by X (to a minimum of 1).")
                .WithFlavor("To the Sea, to the Sea! The white gulls are crying,\r\nThe wind is blowing, and the white foam is flying.\r\n-The Return of the King")
                .WithInfo(14, 3, Artist.Tawny_Fritzinger));
            Cards.Add(Card.Attachment("Narya", "", Sphere.Neutral, 2)
                .WithUnique()
                .WithTraits("Ring.", "Artifact.")
                .WithText("Attach to Círdan the Shipwright or Gandalf.\r\nAttached character gains a Leadership resource icon.\r\nAction: Exhaust Narya and attached character to choose and ready up to 2 allies. Each of those allies gets +1 Attack and +1 Defense until the end of the phase.")
                .WithFlavor("\"For this is the Ring of Fire, and with it you may rekindle hearts in a world that grows chill.\"\r\n-Círdan, The Return of the King")
                .WithInfo(15, 3, Artist.Lucas_Durham));
            Cards.Add(Card.Quest("Departure from the Havens", "", 1, 1, "Voyage Across Belegaer", 8)
                .WithKeywords("Sailing.")
                .WithFlavor("The Dream-chaser and her fleet depart from the Grey Havens, in search of the island from Calphon's dreams. Only a week out from the coast, the black sails of Corsair can be seen in pursuit!")
                .WithText("Setup: Prepare the Corsair deck. Players prepare their fleet. Shuffle each stage 2 card in the quest deck so that their order is random, leaving stage 3 on the bottom. Search the encounter deck for 1 copy of Rolling Seas and 1 copy of Scouting Ship, and add them to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("While you are on-course, each Ship objective gets +2 Willpower.\r\nWhen this stage is defeated, if you are on course (Sunny), look at the top 2 stages of the quest deck and advance to one of your choice, placing the other on the bottom of the quest deck. Otherwise, advance to the top state of the quest deck.")
                .WithVictoryPoints(3)
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(16, 1, Artist.Matt_Stewart));
            Cards.Add(Card.Quest("Into the Storm", "", 1, 2, "Voyage Across Belegaer", 2)
                .WithFlavor("Calphon squints at dark storm clouds on the horizon. \"In my dream, the skies were dark and full of wrath... Perhaps the island lies within that squall?\"\r\nYou hesitate. Guiding your ship into a deadly storm is foolish, at best... But what if he’s right?")
                .WithText("When Revealed: Search the encounter deck and discard pile for 1 copy of Waterspout and add it to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("Forced: At the end of the quest phase, if you are off-course (Cloudy, Rainy, Stormy), each player must distribute 5 damage among characters he controls.\r\nWhen this stage is defeated, if you are on course (Sunny), look at the top 2 stages of the quest deck and advance to one of your choice, placing the other on the bottom of the quest deck. Otherwise, advance to the top stage of the quest deck.")
                .WithVictoryPoints(3)
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(17, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("Cursed Mists", "", 1, 2, "Voyage Across Belegaer", 6)
                .WithKeywords("Sailing.")
                .WithText("When Revealed: Search the encounter deck and discard pile for 1 copy of Fog Bank and add it to the staging area. Shuffle the encounter deck.")
                .WithFlavor("After days of aimless travel at sea, a dark mist settles along the ocean's surface, obscuring your visibility and frightening your ships’ crew. \"Wait,\" Calphon says, \"this happened in my dream, too... I think if we find a way through this mist, we shall be one step closer to the island.\"")
                .WithOppositeText("While you are off-course (Cloudy, Rainy, or Stormy), each non-Ship ally gets –2 Willpower.\r\nWhen this stage is defeated, if you are on-course (Sunny), look at the top 2 stages of the quest deck and advance to one of your choice, placing the other on the bottom of the quest deck. Otherwise, advance to the top stage of the quest deck.")
                .WithVictoryPoints(3)
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(18, 1, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Quest("Calphon's Divination", "", 1, 2, "Voyage Across Belegaer", 4)
                .WithKeywords("Sailing.")
                .WithText("When Revealed: Search the encounter deck and discard pile for 1 copy of Scouting Ship and add it to the staging area. Shuffle the encounter deck.")
                .WithFlavor("Calphon bursts into one of the heroes’ quarters in the middle of the night, sweating profusely and breathing heavily. “I saw it again!” he cries. “It was the same island as before, only the sun was rising behind it, bathing the sky in orange. It must be to the east!” You can change course to follow Calphon’s vision, but you risk being discovered by the Corsairs chasing you... ")
                .WithOppositeText("While you are off-course (Cloudy, Rainy, or Stormy), each Ship enemy gains Boarding 1.\r\nWhen this stage is defeated, if you are on-course (Sunny), look at the top 2 stages of the quest deck and advance to one of your choice, placing the other on the bottom of the quest deck. Otherwise, advance to the top stage of the quest deck.")
                .WithVictoryPoints(3)
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(19, 1, Artist.Juan_Carlos_Barquet));
            Cards.Add(Card.Quest("The Star's Guidance", "", 1, 2, "Voyage Across Belegaer", 4)
                .WithKeywords("Sailing.")
                .WithText("When Revealed: Search the encounter deck and discard pile for 1 copy of Starlit Sea and add it to the staging area. Shuffle the encounter deck.")
                .WithOppositeText("While you are off-course (Cloudy, Rainy, or Stormy), each Ocean location gets +1 Threat.\r\nWhen this stage is defeated, if you are on-course, look at the top 2 stages of the quest deck and advance to one of your choice, placing the other on the bottom of the quest deck. Otherwise, advance to the top stage of the quest deck.")
                .WithFlavor("Calphon recognizes a bright star in the night sky, pointing to it. \"There! That star! I remember that star from my vision. I believe we must follow that star if we are to reach the island.\" Calphon’s guidance has led you this far. But none of your maps or almanacs make any mention of this bright star...")
                .WithVictoryPoints(3)
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(20, 1, Artist.Nate_Abell));
            Cards.Add(Card.Quest("Corsair Pursuit", "", 1, 3, "Voyage Across Belegaer", 10)
                .WithKeywords("Sailing.")
                .WithText("When Revealed: Search the encounter deck or discard pile for the Ship enemy with the highest Threat and add it to the staging area (the 2 Ship enemies with the highest Threat instead if there are 3 or more players in the game). Shuffle the encounter deck.")
                .WithFlavor("Calphon insists you are very close to finding the island, but Corsairs still shadow your fleet. You must either fight them or outpace them before you can reach the island and weigh anchor.")
                .WithOppositeText("You cannot place progress on Corsair Pursuit unless you are on-course (Sunny).\r\nIf there are no Ship enemies in play, you have defeated your pursuers, and win the game.\r\nIf this stage has 10 or more progress on it, you have lost your pursuers, and win the game.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.StormyWeather, EncounterSet.UmbarFleet, EncounterSet.CorsairPirates, EncounterSet.TheDreamChasersFleet)
                .WithInfo(21, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.ShipEnemy("Scouting Ship", string.Empty, 35, 2, 5, 2, 7)
                .WithGeneric()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithText("Cannot have attachments. Scouting Ship gets -15 engagement cost while you are off course (Cloudy, Rainy, or Stormy).")
                .WithFlavor("All too well they could see for themselves the black sails.\r\n-The Return of the King")
                .WithInfo(22, 3, Artist.Michael_Rasmussen));
            Cards.Add(Card.Location("Starlit Sea", "", "Voyage Across Belegaer", 3, 2)
                .WithTraits("Ocean.")
                .WithText("While you are off-course (Cloudy, Rainy, or Stormy), Starlit Sea gains: \"Travel: Raise each player’s threat by 3.\"")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you are off-course).")
                .WithInfo(23, 2, Artist.Mateusz_Ozminski));
            Cards.Add(Card.Location("Fog Bank", "", "Voyage Across Belegaer", 2, 5)
                .WithTraits("Ocean.")
                .WithText("While Fog Bank is the active location, Ship enemies do not make engagement checks, cannot attack, and cannot be attacked.")
                .WithShadow("Shadow: If your heading is at the worst setting (Stormy), attacking enemy makes an additional attack after this one.")
                .WithInfo(24, 2, Artist.Alyn_Spiller));
            Cards.Add(Card.Quest("Explore the Island", "", 2, 1, "The Fate of Númenor", 20)
                .WithFlavor("You arrive on the island’s western beach, the edge of a dense jungle looming beyond. With no map to guide you and no idea of what to expect, you venture forward, deeper into the island... ")
                .WithText("Setup: Set Shrine to Morgoth aside, out of play. Prepare the Uncharted deck. Add 2 copies of Lost Island from the top of the Uncharted deck to the staging area (3 copies instead if there are 3 or 4 players in the game). The first player takes control of Calphon. Shuffle the encounter deck.")
                .WithOppositeText("Progress cannot be placed on Explore the Island except by quest effects.\r\nForced: After a location is explored, add progress to Explore the Island equal to that location’s printed quest points.\r\nForced: When an Uncharted location becomes the active location, add 1 copy of Lost Island from the top of the Uncharted deck to the staging area.")
                .WithIncludedEncounterSets(EncounterSet.DrownedDead, EncounterSet.RuinsOfNumenor)
                .WithInfo(25, 1, Artist.Jon_Bosco));
            Cards.Add(Card.Quest("A Fateful Discovery", "", 2, 2, "The Fate of Númenor", 255)
                .WithFlavor("Markings on Adûnaic suggest the existence of a grand shrine somewhere on the island. Perhaps there, you will find answers.")
                .WithText("When Revealed: Add 2 copies of Lost Island from the top of the Uncharted deck to the staging area. Add Shrine to Morgoth to the staging area, Lost Island side faceup. Remove all progress from each Uncharted location in the staging area and shuffle them so that the players do not know which one is which.")
                .WithOppositeFlavor("You search for the shrine, unsure of its exact location...")
                .WithOppositeText("Forced: After a location is explored, if it would be shuffled into the Uncharted deck, add it to the victory display instead.\r\nThe players cannot defeat this stage unless Shrine to Morgoth is in the victory display. When Shrine to Morgoth is added to the victory display, the players win the game.")
                .WithIncludedEncounterSets(EncounterSet.DrownedDead, EncounterSet.RuinsOfNumenor)
                .WithInfo(26, 1, Artist.Jon_Bosco));
            Cards.Add(Card.Location("Shrine to Morgoth", "", "The Fate of Númenor", 5, 8)
                .WithUnique()
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("While Shrine to Morgoth is the active location, players cannot draw cards or search their decks.\r\nForced: After Shrine to Morgoth is flipped over while active, exhaust each ally in play with printed cost 2 or less. Then, each player must search the encounter deck and discard pile for an Undead enemy and put it into play engaged with him. Shuffle the encounter deck.")
                .WithInfo(27, 1, Artist.Jokubas_Uoginitas));
            Cards.Add(Card.ObjectiveAlly("Calphon", "", "The Fate of Númenor", 1, 0, 1, 3)
                .WithUnique()
                .WithTraits("Gondor.", "Noble.")
                .WithText("The first player gains control of Calphon.\r\nAction: Exhaust Calphon to look at the bottom card of your deck. Then, you may switch that card with a card in your hand.\r\nIf Calphon leaves play, the players lose the game.")
                .WithInfo(28, 1, Artist.Ilich_Henriquez));
            Cards.Add(Card.Enemy("Servant of the Deceiver", "", "The Fate of Númenor", 35, 3, 3, 4, 3)
                .WithTraits("Undead.")
                .WithText("Forced: When Servant of the Deceiver engages you, look at the top card of your deck. If its printed cost is 2 or less, place it on the bottom of your deck and Servant of the Deceiver gets +2 Attack until the end of the round.")
                .WithEasyModeQuantity(2)
                .WithInfo(29, 3, Artist.Florian_Devos));
            Cards.Add(Card.Location("Lush Jungle", "", "The Fate of Númenor", 4, 4)
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Forest.")
                .WithText("While Lush Jungle is in the staging area, characters get –1 Attack and lose ranged.\r\nForced: After Lush Jungle is flipped over while active, return it to the staging area unless each player exhausts each ready hero he controls.")
                .WithInfo(30, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Forbidden Coast", "", "The Fate of Númenor", 1, 6)
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Uncharted.\r\nCannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Coastland.")
                .WithText("Forced: After Forbidden Coast is flipped over while active, each player may draw a card. Then, each player chooses a card from his hand and places it on the bottom of his deck.")
                .WithInfo(31, 2, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Location("Steep Plateau", "", "The Fate of Númenor", 1, 3)
                .WithTraits("Coastland.")
                .WithText("Response: After Steep Plateau is explored, peek at the facedown side of an Uncharted location in the staging area.")
                .WithShadow("Shadow: Discard the bottom card of the defending player’s deck. If that card’s printed cost is 2 or less, attacking enemy gets +2 Attack.")
                .WithInfo(32, 3, Artist.Florian_Devos));
            Cards.Add(Card.Treachery("Mysterious Fog", "", "The Fate of Númenor")
                .WithText("When Revealed: Either each player must exhaust a character he controls, or each Lost Island in the staging area gets +1 Threat until the end of the phase.")
                .WithShadow("Shadow: Discard the bottom card of your deck. If that card’s printed cost is 2 or less, exhaust a character you control.")
                .WithInfo(33, 2, Artist.Yoann_Boissonnet));
            Cards.Add(Card.Treachery("Lingering Malevolence", "", "The Fate of Númenor")
                .WithText("When Revealed: The first player discards the bottom card of his deck. Then, he discards each card in his hand with a printed cost higher than that of the discarded card.")
                .WithShadow("Shadow: Discard the bottom card of the defending player’s deck. If that card’s printed cost is 2 or less, attacking enemy gets +2 Attack.")
                .WithEasyModeQuantity(1)
                .WithInfo(34, 2, Artist.Preston_Stone));
            Cards.Add(Card.Treachery("Ruins of Ages Past", "", "The Fate of Númenor")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Add 1 copy of Lost Island from the top of the Uncharted deck to the staging area. Then, remove all progress from each Uncharted location in the staging area and shuffle them so that the players do not know which one is which.")
                .WithEasyModeQuantity(1)
                .WithInfo(35, 2, Artist.Alyn_Spiller));
            Cards.Add(Card.Quest("The Corsairs' Assault", "", 3, 1, "Raid on the Grey Havens", 18)
                .WithText("Setup: Set Captain Sahír and Na'asiyah aside, out of play. Add The Havens Burn, The Dream-chaser, and 1 copy of Sahír’s Ravager to the staging area. Shuffle the encounter deck and discard cards from the top of the encounter deck until X locations with the Aflame keyword are discarded, where X is the number of players in the game. Add each discarded Aflame location to the staging area. Then, shuffle the encounter discard pile back into the encounter deck.")
                .WithOppositeFlavor("Corsairs are attacking the Grey Havens and burning the Elven fleet. You must defend the Havens from these fierce raiders and save as many ships as you can!")
                .WithOppositeText("Forced: At the end of the combat phase, deal X damage to the Aflame location in play with the lowest Aflame value. X is the number of Corsair enemies in play.")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.TheStormcallerElite)
                .WithInfo(36, 1, Artist.Simon_Dominic));
            Cards.Add(Card.Quest("Sahír's Advance", "", 3, 2, "Raid on the Grey Havens", 255)
                .WithNormalizedTitle("Sahir's Advance")
                .WithFlavor("A menacing ship leads the raiders, its charismatic captain bellowing orders to the Corsairs: \"Kill the defenders!\" he shouts. \"Destroy their ships!\"")
                .WithText("When Revealed: Add Na’asiyah and Captain Sahír to the staging area, enemy side faceup. Each player reveals the top card of the encounter deck. Place resources on Na’asiyah and Captain Sahír equal to the amount of damage on The Dream-chaser. Add 1 resource to each other Raider enemy in play.")
                .WithOppositeText("Any time players would place progress on this quest, remove an equal amount of damage from locations in play instead. (Progress is placed on the active location before triggering this effect.)\r\nEach Raider enemy revealed by the encounter deck enters play with 1 resource on it.\r\nIf Captain Sahír is in the victory display and each location in play has no damage, the players win the game. ")
                .WithIncludedEncounterSets(EncounterSet.CorsairRaiders, EncounterSet.TheStormcallerElite)
                .WithInfo(37, 1, Artist.Sara_Winters));
            Cards.Add(Card.Objective("The Havens Burn", "", "Raid on the Grey Havens")
                .WithText("Forced: When a card is placed underneath The Havens Burn, reveal the top card of the encounter deck.\r\nIf there are X or more cards underneath The Havens Burn, the Corsairs have destroyed the Elven fleet and the players lose the game. X is 3 more than the number of players in the game.")
                .WithInfo(38, 1, Artist.Nate_Abell));
            Cards.Add(Card.Location("Dream-chaser", "", "Raid on the Grey Havens", 2, 255)
                .WithUnique()
                .WithSlugIncludesType()
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 12.")
                .WithText("Immune to player card effects.\r\nThe players cannot travel to the Dream-chaser.\r\nWhen the Dream-chaser is placed underneath The Havens Burn, the players lose the game.")
                .WithInfo(39, 1, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Enemy("Corsair Arsonist", "", "Raid on the Grey Havens", 28, 2, 2, 1, 3)
                .WithTraits("Corsair.")
                .WithText("When Revealed: Either deal 2 damage to an Aflame location in play, or search the encounter deck and discard pile for an Aflame location with the highest Aflame X value, and add it to the staging area.")
                .WithInfo(40, 3, Artist.Leanna_Teneycke));
            Cards.Add(Card.Enemy("Sahír's Ravager", "", "Raid on the Grey Havens", 36, 3, 4, 3, 5)
                .WithNormalizedTitle("Sahir's Ravager")
                .WithTraits("Corsair.", "Raider.")
                .WithText("Forced: After Sahír’s Ravager attacks, place 1 resource on it. Then, deal X damage to the Aflame location in play with the lowest Aflame value, where X is the number of resources on Sahír's Ravager.")
                .WithEasyModeQuantity(1)
                .WithInfo(41, 3, Artist.Sara_Winters));
            Cards.Add(Card.Location("Mithlond Harbor", "", "Raid on the Grey Havens", 1, 2)
                .WithTraits("Grey Havens.")
                .WithKeywords("Surge.")
                .WithText("While Mithlond Harbor is in the staging area, progress cannot be placed on locations in the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack for each damage token on the active location.")
                .WithEasyModeQuantity(1)
                .WithInfo(42, 2, Artist.Matt_Stewart));
            Cards.Add(Card.Location("Burning Piers", "", "Raid on the Grey Havens", 1, 3)
                .WithTraits("Grey Havens.")
                .WithKeywords("Aflame 5.")
                .WithText("Burning Piers gets +1 Threat for each damage on it.\r\nForced: When Burning Piers is placed underneath The Havens Burn, deal 3 damage to The Dream-chaser.")
                .WithShadow("Shadow: Add Burning Piers to the staging area.")
                .WithInfo(43, 2, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Location("Pillaged Ship", "", "Raid on the Grey Havens", 2, 4)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 5.")
                .WithText("When Revealed: Either deal 3 damage to Pillaged Ship, or add the topmost enemy in the encounter discard pile to the staging area.")
                .WithShadow("Shadow: If attacking enemy is a Raider, move all resources from defending character to attacking enemy.")
                .WithInfo(44, 2, Artist.Simon_Dominic));
            Cards.Add(Card.Location("White Ship", "", "Raid on the Grey Havens", 4, 6)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 4.")
                .WithText("Travel: Search the encounter deck and discard pile for a Corsair enemy and add it to the staging area. Shuffle the encounter deck.\r\nForced: When White Ship is placed underneath The Havens Burn, place 1 resource on each Raider enemy in play.")
                .WithEasyModeQuantity(1)
                .WithInfo(45, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Elven Wave-runner", "", "Raid on the Grey Havens", 3, 3)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 3.")
                .WithText("Response: After Elven Wave-runner is added to the victory display, each player draws 1 card.")
                .WithShadow("Shadow: If attacking enemy is a Raider, discard a card at random from your hand and place 1 resource on attacking enemy.")
                .WithVictoryPoints(3)
                .WithInfo(46, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Location("Elven Caravel", "", "Raid on the Grey Havens", 3, 5)
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Aflame 4.")
                .WithText("Travel: Each player must assign damage among characters he controls equal to the amount of damage on Elven Caravel.\r\nForced: When Elven Caravel is placed underneath The Havens Burn, deal 1 damage to each character in play.")
                .WithEasyModeQuantity(1)
                .WithInfo(47, 2, Artist.Nate_Abell));
            Cards.Add(Card.Treachery("Put to the Torch", "", "Raid on the Grey Havens")
                .WithText("When Revealed: Each player must either deal 3 damage to a character he controls, or to an Aflame location in play.")
                .WithShadow("Shadow: If the active location has the Aflame keyword, either deal it 3 damage or deal the defending character 1 damage.")
                .WithInfo(48, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.Treachery("The Fires Spread", "", "Raid on the Grey Havens")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Deal 1 damage to each Aflame location in play. If less than 3 total damage is dealt by this effect, The Fires Spread gains surge.")
                .WithShadow("Shadow: If this attack destroys a character, deal 1 damage to each Aflame location in play.")
                .WithInfo(49, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.Location("Calm Waters", "", "Vast Oceans", 1, 4)
                .WithTraits("Ocean.")
                .WithText("While Calm Waters is the active location, look at 2 additional cards from the top of the encounter deck during each Sailing test.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if attacking enemy is a Ship Enemy).")
                .WithInfo(50, 2, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Location("Rolling Seas", "", "Vast Oceans", 4, 3)
                .WithTraits("Ocean.")
                .WithText("Travel: Shift your heading off-course to travel here.\r\nShadow: If this attack deals damage to a Ship objective, shift your heading off-course.")
                .WithFlavor("The winds of wrath came driving him, and blindly in the foam he fled… —The Fellowship of the Ring")
                .WithEasyModeQuantity(1)
                .WithInfo(51, 3, Artist.Carlos_Palma_Cruchaga));
            Cards.Add(Card.Treachery("Thrown Off Course", "", "Vast Oceans")
                .WithText("When Revealed: Either remove all progress from the current quest and raise each player’s threat by 4, or shift your heading off-course.")
                .WithShadow("Shadow: If this attack destroys a character, shift your heading off-course.")
                .WithInfo(52, 2, Artist.Nicholas_Gregory));
            Cards.Add(Card.Location("Rough Waters", "", "Stormy Weather", 2, 3)
                .WithTraits("Ocean.")
                .WithText("While Rough Waters is in the staging area, cancel the first Sailing Success symbol found during each Sailing test.")
                .WithShadow("Shadow: If you are off-course (Cloudy, Rainy, or Stormy), attacking enemy gets +2 Attack.")
                .WithInfo(53, 2, Artist.Carlos_Palma_Cruchaga));
            Cards.Add(Card.Location("Waterspout", "", "Stormy Weather", 2, 4)
                .WithTraits("Ocean.")
                .WithText("While your heading is at the worst setting (Stormy), when faced with the option to travel, the players must travel to Waterspout, if able.\r\nForced: After traveling to Waterspout, deal 4 damage to each Ship objective.")
                .WithEasyModeQuantity(1)
                .WithInfo(54, 2, Artist.Jokubas_Uoginitas));
            Cards.Add(Card.Treachery("Sudden Storms", "", "Stormy Weather")
                .WithTraits("Weather.")
                .WithText("When Revealed: Either shift your heading off-course or deal 1 damage to each exhausted character.")
                .WithShadow("Shadow: Excess damage from this attack is dealt to a Ship objective you control.")
                .WithEasyModeQuantity(2)
                .WithInfo(55, 3, Artist.Simon_Dominic));
            Cards.Add(Card.Treachery("Winds of Wrath", "", "Stormy Weather")
                .WithTraits("Weather.")
                .WithText("When Revealed: If you are off-course, deal 1 damage to each character in play. If your heading is at the worst setting (Stormy), this effect cannot be canceled.")
                .WithShadow("Shadow: Either shift your heading off-course or treat this attack as undefended.")
                .WithEasyModeQuantity(2)
                .WithInfo(56, 3, Artist.Nate_Abell));
            Cards.Add(Card.ShipEnemy("Light Cruiser", "Umbar Fleet", 37, 4, 6, 5, 7)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithText("Cannot have attachments.\r\nEach Raider enemy revealed from the Corsair deck by Light Cruiser’s boarding keyword enters play with 1 resource on it.")
                .WithFlavor("And looking thither they cried in dismay; for black against the glittering stream they beheld a fleet borne up on the wind… —The Return of the King")
                .WithInfo(57, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.ShipEnemy("Corsair Warship", "Umbar Fleet", 44, 3, 8, 4, 9)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 3.")
                .WithText("Cannot have attachments.\r\nWhile Corsair Warship is in the staging area, it cannot be damaged and gains archery 4.")
                .WithFlavor("...ships of great draught with many oars, and with black sails bellying in the breeze. —The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(58, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.Treachery("Boarding Party", "", "Umbar Fleet")
                .WithText("When Revealed: Each player reveals the top card of the Corsair deck and puts it into play, engaged with him.")
                .WithShadow("Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if you control an exhausted Ship objective).")
                .WithEasyModeQuantity(1)
                .WithInfo(59, 2, Artist.Darek_Zabrocki));
            Cards.Add(Card.Enemy("Southron Sailor", "", "Corsair Pirates", 28, 0, 2, 1, 4)
                .WithTraits("Corsair.")
                .WithText("While Southron Sailor is engaged with you, each Ship enemy engaged with you contributes its Threat to the total Threat in the staging area.")
                .WithFlavor("\"There is a great fleet drawing near to the mouths of Anduin, manned by the corsairs of Umbar in the South.\" —Beregond, The Return of the King")
                .WithInfo(60, 2, Artist.Leanna_Teneycke));
            Cards.Add(Card.Enemy("Cunning Pirate", "", "Corsair Pirates", 36, 1, 2, 2, 4)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Cunning Pirate gets +1 Attack and +1 Defense for each resource on it.\r\nForced: When Cunning Pirate engages you, discard an attachment you control and place resources on Cunning Pirate equal to that attachment's printed cost.")
                .WithInfo(61, 3, Artist.Adam_Lane));
            Cards.Add(Card.Enemy("Vicious Marauder", "", "Corsair Pirates", 12, 2, 3, 3, 3)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Forced: When Vicious Marauder engages you, discard a random card from your hand and place resources on it equal to that card’s printed cost.\r\nForced: When Vicious Marauder attacks you, distribute damage among characters you control equal to the number of resources on it.")
                .WithInfo(62, 2, Artist.Nate_Abell));
            Cards.Add(Card.Enemy("Umbar Captain", "", "Corsair Pirates", 40, 4, 5, 3, 5)
                .WithTraits("Corsair.")
                .WithText("While you are engaged with Umbar Captain, characters you control cannot attack Ship enemies.")
                .WithFlavor("...the strength of the rebels in Umbar was a great peril to Gondor... —The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(63, 2, Artist.David_Kegg));
            Cards.Add(Card.Enemy("Umbar Raider", "", "Corsair Raiders", 24, 2, 3, 2, 4)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Umbar Raider gets +1 Attack for each resource on it.\r\nForced: After Umbar Raider attacks you, move 1 resource from one of your heroes’ resource pools to Umbar Raider.")
                .WithFlavor("\"And there men of Lamedon contested the fords with fell folk of Umbar and Harad who had sailed up the river.\" —Legolas, The Return of the King")
                .WithInfo(64, 3, Artist.David_Kegg));
            Cards.Add(Card.Enemy("Corsair Infiltrator", "", "Corsair Raiders", 16, 2, 3, 3, 2)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Forced: When Corsair Infiltrator attacks, deal it 1 additional shadow card for each resource on it.\r\nForced: After the engaged player collects resources at the beginning of the resource phase, that player moves 1 resource from one of his heroes' pools to Corsair Infiltrator.")
                .WithInfo(65, 2, Artist.Adam_Lane));
            Cards.Add(Card.Enemy("Raid Leader", "", "Corsair Raiders", 40, 3, 5, 1, 5)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Raid Leader gets +1 Defense for each resource on it.\r\nForced: When Raid Leader engages you, move 1 resource from each of your heroes' resource pools to Raid Leader.")
                .WithFlavor("\"The Corsairs are upon us! It is the last stroke of doom!\" —Men of Gondor, The Return of the King")
                .WithEasyModeQuantity(0)
                .WithInfo(66, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.Treachery("Battle-Hardened", "", "Corsair Raiders")
                .WithText("When Revealed: Place 1 resource on each Raider enemy in play. Each engaged non-Ship enemy makes an immediate attack. If there are no engaged non-Ship enemies, Battle-Hardened gains surge.")
                .WithShadow("Shadow: If the attacking enemy is a Raider, place 2 resources on it.")
                .WithEasyModeQuantity(0)
                .WithInfo(67, 2, Artist.Emile_Denis));
            Cards.Add(Card.Enemy("Drowned Dead", "", "Drowned Dead", 32, 2, 4, 3, 3)
                .WithTraits("Undead.")
                .WithText("Forced: When Drowned Dead attacks and destroys an ally by an attack, place that ally on the bottom of your deck.")
                .WithShadow("Shadow: If this attack destroys an ally, place that ally on the bottom of your deck.")
                .WithInfo(68, 3, Artist.Chris_Grun));
            Cards.Add(Card.Enemy("Soulless Cadaver", "", "Drowned Dead", 38, 3, 3, 2, 4)
                .WithTraits("Undead.")
                .WithText("While you are engaged with Soulless Cadaver, your deck cannot be searched.\r\nForced: When Soulless Cadaver engages you, place each card in your hand with printed cost 2 or less on the bottom of your deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(69, 2, Artist.Helge_C_Balzer));
            Cards.Add(Card.Enemy("Throngs of Unfaithful", "", "Drowned Dead", 26, 1, 2, 0, 4)
                .WithTraits("Undead.")
                .WithKeywords("Surge.")
                .WithText("Forced: When Throngs of Unfaithful is defeated, discard the bottom card of the engaged player's deck. If that card’s printed cost is 2 or less, return Throngs of the Unfaithful to the top of the encounter deck.")
                .WithEasyModeQuantity(1)
                .WithInfo(70, 2, Artist.Helge_C_Balzer));
            Cards.Add(Card.Treachery("Curse of the Downfallen", "", "Drowned Dead")
                .WithText("When Revealed: Deal 1 damage to each ally with printed cost 2 or less. Place each ally that is destroyed by this effect on the bottom of its owner's deck.")
                .WithShadow("Shadow: Discard the bottom card of your deck. If that card's printed cost is 2 or less, attacking enemy makes an additional attack after this one.")
                .WithEasyModeQuantity(0)
                .WithInfo(71, 2, Artist.Piya_Wannachaiwong));
            Cards.Add(Card.Location("Flooded Ruins", "", "Ruins of Númenor", 3, 5)
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Cannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("While Flooded Ruins is the active location, it contributes its Threat to the staging area.")
                .WithFlavor("Númenor was thrown down and swallowed in the sea... –The Return of the King")
                .WithInfo(72, 2, Artist.Juan_Carlos_Barquet));
            Cards.Add(Card.Location("Drowned Graves", "", "Ruins of Númenor", 2, 2)
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Cannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("Forced: After Drowned Graves is flipped to this side while active, discard the top X cards of the encounter deck. Each player adds an Undead enemy discarded from this effect to the staging area. X is 2 more than the number of players in the game.")
                .WithFlavor("...their years lessened as their fear of death grew, and their joy departed. –The Return of the King")
                .WithInfo(73, 2, Artist.Juan_Carlos_Barquet));
            Cards.Add(Card.Location("Cursed Temple", "", "Ruins of Númenor", 1, 3)
                .WithSecondImage("Lost-Island")
                .WithKeywords("Uncharted.")
                .WithOppositeText("Cannot have player card attachments.\r\nForced: After Lost Island becomes the active location, flip it over.\r\nAction: Remove 4 progress from Lost Island to look at its facedown side.")
                .WithTraits("Ruins.")
                .WithText("While Cursed Temple is the active location, characters with less than 2 Willpower do not ready during the refresh phase.")
                .WithFlavor("It was not long before he had bewitched the King and was master of his counsel... –The Return of the King")
                .WithInfo(74, 2, Artist.Davis_Engel));
            Cards.Add(Card.Treachery("Aimless Wandering", "", "Ruins of Númenor")
                .WithText("When Revealed: The players, as a group, must remove characters with a total of at least X Willpower from the quest. X is the number of Uncharted locations in the staging area. The first player may give Aimless Wandering doomed 2 to look at the facedown side of an Uncharted location in the staging area.")
                .WithInfo(75, 3, Artist.David_Ogilvie));
            Cards.Add(Card.Enemy("Captain Sahír", "", "The Stormcaller Elite", 4, 6, 6, 2, 5)
                .WithTypeBasedSlug()
                .WithUnique()
                .WithNormalizedTitle("Captain Sahir")
                .WithTraits("Corsair.", "Raider.")
                .WithText("Captain Sahír engages the first player.\r\nFor each point of damage Captain Sahír would take, discard 1 resource from him and cancel that damage.\r\nForced: After Captain Sahír attacks, place 2 resource tokens on him (4 instead if his attack destroyed a character).")
                .WithVictoryPoints(6)
                .WithInfo(76, 1, Artist.Sara_Winters));
            Cards.Add(Card.ObjectiveAlly("Captain Sahír", "", "The Stormcaller Elite", 0, 0, 2, 5)
                .WithTypeBasedSlug()
                .WithUnique()
                .WithNormalizedTitle("Captain Sahir")
                .WithTraits("Corsair.", "Raider.")
                .WithText("The first player gains control of Captain Sahír.\r\nCaptain Sahír gets +1 Willpower and +1 Attack for each resource on him (max +6).\r\nAction: Spend 1 resource from a hero you control to place 1 resource on Captain Sahír. (Limit once per round).\r\nIf Captain Sahír leaves play, the players lose.")
                .WithInfo(77, 1, Artist.Sara_Winters));
            Cards.Add(Card.Enemy("Na'asiyah", "", "The Stormcaller Elite", 8, 1, 2, 2, 4)
                .WithTypeBasedSlug()
                .WithUnique()
                .WithTraits("Corsair.", "Raider.")
                .WithText("Na’asiyah engages the last player.\r\nForced: When Na’asiyah engages you, discard each event in your hand. Add 1 resource to Na’asiyah for each event discarded in this way.\r\nForced: When Na’asiyah attacks or defends, she gets +1 Attack and +1 Defense for this attack for each resource on her. After this attack, discard 1 resource from her.")
                .WithInfo(78, 1, Artist.Ilich_Henriquez));
            Cards.Add(Card.ObjectiveAlly("Na'asiyah", "", "The Stormcaller Elite", 1, 2, 2, 4)
                .WithTypeBasedSlug()
                .WithUnique()
                .WithTraits("Corsair.", "Raider.")
                .WithText("The last player gains controls of Na'asiyah.\r\nAction: While Na'asiyah is attacking or defending, spend 1 resource from her to give her +2 Attack or +2 Defense for this attack.\r\nAction: Spend 1 resource from a hero you control to place 1 resource on Na'asiyah. (Limit once per round).\r\nIf Na'asiyah leaves play, the players lose.")
                .WithInfo(79, 1, Artist.Ilich_Henriquez));
            Cards.Add(Card.ShipObjective("Dream-chaser", "The Dream-chaser's Fleet", 5, 4, 4, 18)
                .WithSlugIncludesType()
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithText("Immune to player card effects.\r\nThe Dream-chaser can always be committed to sailing tests (even if you are not the first player), and counts as 2 characters when committed to a Sailing test.\r\nIf the Dream-chaser is destroyed, the players lose the game.")
                .WithInfo(80, 1, Artist.Nele_Klumpe));
            Cards.Add(Card.ShipObjective("Dawn Star", "The Dream-chaser's Fleet", 3, 3, 4, 16)
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithText("Immune to player card effects.\r\nRaise your starting threat by 3.\r\nDraw 1 additional card during the resource phase.\r\nIf the Dawn Star is destroyed, its controller is eliminated from the game.")
                .WithInfo(81, 1, Artist.Titus_Lunter));
            Cards.Add(Card.ShipObjective("Nárelenya", "The Dream-chaser's Fleet", 3, 3, 5, 15)
                .WithNormalizedTitle("Narelenya")
                .WithTraits("Grey Havens.", "Ship.")
                .WithKeywords("Sentinel.")
                .WithText("Immune to player card effects.\r\nReduce the cost of the first ally you play each round by 1.\r\nIf the Nárelenya is destroyed, its controller is eliminated from the game.")
                .WithInfo(82, 1, Artist.Nele_Klumpe));
            Cards.Add(Card.ShipObjective("Silver Wing", "The Dream-chaser's Fleet", 2, 4, 2, 14)
                .WithTraits("Gondor.", "Ship.")
                .WithKeywords("Sentinel.", "Ranged.")
                .WithText("Immune to player card effects.\r\nReduce your starting threat by 3.\r\nEach hero you control gets +1 Attack.\r\nIf the Silver Wing is destroyed, its controller is eliminated from the game.")
                .WithInfo(83, 1, Artist.Nele_Klumpe));
            Cards.Add(Card.Objective("Navigation", "", "")
                .WithText("Sunny, Cloudy, Rainy, Stormy")
                .WithInfo(84, 1, Artist.Unknown));
        }
    }
}