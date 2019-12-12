/* Generated CardSet class: Flight of the Stormcaller */

using System;

namespace HallOfBeorn.Models.LotR.Sets.DreamChaser
{
    public class FlightOfTheStormcallerSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Flight of the Stormcaller";
            Abbreviation = "FotS";
            Number = 36;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            addHero("Denethor", 8, Sphere.Leadership, 1, 1, 3, 3)
                .WithAlternateSlug("🍅")
                .WithTraits("Gondor.", "Noble.", "Steward.")
                .WithTextLine("Setup: Add 2 resources to Denethor's resource pool.")
                .WithTextLine("Action: Move 1 resource from Denethor's resource pool to another Gondor hero's resource pool. (Limit once per round.)")
                .WithFlavorLine("\"...why should I sit here in my tower and think, and watch, and wait, spending even my sons? For I can still wield a brand.\"")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(1, 1, Artist.Joshua_Cairos);
            addAttachment("Rod of the Steward", 0, Sphere.Leadership, true)
                .WithTraits("Item.")
                .WithTextLine("Attach to a Gondor hero.")
                .WithTextLine("Action: Spend 2 resources from attached hero's resource pool to draw 1 card.")
                .WithFlavorLine("\"The last Steward of Gondor begs leave to surrender his office.\" And he held out a white rod.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(2, 3, Artist.Drazenka_Kimpel);
            addAttachment("In Service of the Steward", 1, Sphere.Leadership, false)
                .WithTraits("Title.")
                .WithTextLine("Attach to a character.")
                .WithTextLine("Attached character gains the Gondor trait.")
                .WithFlavorLine("But be it know that I have sworn him to my service...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(3, 3, Artist.Jason_Cheeseman_Meyer);
            addAlly("Azain Silverbeard", 3, Sphere.Tactics, true, 0, 3, 2, 2)
                .WithTraits("Dwarf.", "Warrior.")
                .WithTextLine("Response: After Azain Silverbeard participates in an attack that destroys an enemy, spend 1 Tactics resource to deal 2 damage to another enemy that shares a Trait with the destroyed enemy. Any player may trigger this response.")
                .WithInfo(4, 3, Artist.Marius_Bota);
            addEvent("Last Stand", 0, Sphere.Tactics)
                .WithTextLine("Response: After a Warrior character is destroyed while defending against an enemy attack, deal damage to the attacking enemy equal to that character's printed Attack.")
                .WithFlavorLine("In a grave along under the shadow of the Hornburg lay Háma, captain of the King's guard. He fell before the Gate.")
                .WithFlavorLine("-The Two Towers")
                .WithInfo(5, 3, Artist.Arden_Beckwith);
            addAlly("Glorfindel", 5, Sphere.Spirit, true, 3, 3, 1, 4)
                .WithTraits("Noldor.", "Noble.", "Warrior.")
                .WithTextLine("Glorfindel can be played from your discard pile.")
                .WithTextLine("Action: Discard a card from your hand to ready Glorfindel. (Limit once per phase.)")
                .WithFlavorLine("\"Glorfindel is an Elf-lord of a house of princes.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Aleksander_Karcz);
            addEvent("Tides of Fate", 0, Sphere.Spirit)
                .WithTextLine("Response: When a shadow card increases an enemy's Attack by any amount, increase the defending character's Defense by 3 for that attack. Then, the players as a group may spend 2 Tactics resources to ready the defending character and give it +3 Attack for its next attack this phase.")
                .WithFlavorLine("...the tides of fate had turned against them and their doom was at hand.")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(7, 3, Artist.Sam_Lamont);
            addAlly("Imladris Caregiver", 2, Sphere.Lore, false, 1, 0, 1, 2)
                .WithTraits("Noldor.", "Healer.")
                .WithTextLine("Action: Discard a card from your hand to heal 1 damage on any character. (Limit twice per round).")
                .WithFlavorLine("\"You are in Rivendell, and you need not worry about anything for the present.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(8, 3, Artist.Aleksander_Karcz);
            addEvent("Heed the Dream", 1, Sphere.Lore)
                .WithTextLine("Action: Choose a player. That player searches the top 5 cards of his deck for a card, adds it to his hand, and shuffles his deck. Then, players as a group may spend 3 Leadership resources to have that player search his deck for another card, add it to his hand, and shuffle his deck.")
                .WithInfo(9, 3, Artist.Joshua_Cairos);
            addAlly("Guardian of Rivendell", 3, Sphere.Neutral, false, 1, 2, 3, 3)
                .WithTraits("Noldor.", "Warrior.")
                .WithTextLine("As an additional cost to play ~Guardian of Rivendell from your hand, you must discard 2 cards from your hand.")
                .WithFlavorLine("\"Indeed there is a power in Rivendell to withstand the might of Mordor, for a while.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Tawny_Fritzinger);
            addEvent("Vanish from Sight", 0, Sphere.Neutral)
                .WithTextLine("Play only if you control 2 or fewer heroes.")
                .WithTextLine("Action: Until the end of the phase, if your threat is higher than 20, treat your threat as if it is 20.")
                .WithFlavorLine("\"I see now little hope, if we do not soon vanish from sight for a while, and cover our trail.\"")
                .WithFlavorLine("-Gandalf, The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Nikolas_Hagialas);
            addQuest("Swift Departure", EncounterSet.FlightOfTheStormcaller, 1, 'A', 8)
                .WithKeywords("Sailing.")
                .WithTextLine("Setup: Prepare the Corsair deck. Players prepare their fleet. Prepare the Stormcaller’s area with a second quest deck consisting of only stages 2C, 3C, and 4C, as well as the Stormcaller (see insert). Search the encounter deck for 1 copy of Rolling Seas, and add it to the staging area (2 copies instead if there are 3 or more players in the game). Shuffle the encounter deck.")
                .WithFlavorLine("Corsairs led by the treacherous Captain Sahír have stolen the black key you recovered in the ruins of Númenor. You must get it back!")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("Forced: At the end of the quest phase, if you are off-course (Cloudy, Rainy, or Stormy), move 2 progress from Swift Departure to the Stormcaller's quest stage.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(12, 1, Artist.Sara_Winters);
            addQuest("Full Sail Ahead", EncounterSet.FlightOfTheStormcaller, 2, 'A', 12)
                .WithSlugSuffix("AB")
                .WithKeywords("Sailing.")
                .WithTextLine("When Revealed: Search the encounter deck and discard pile for 1 copy of Swift ~Raider and add it to the staging area. Shuffle the encounter deck.")
                .WithFlavorLine("As you travel along the western coast of Middle-earth, Corsairs continue to harry your fleet in an attempt to slow your progress.")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("No more than 8 progress can be placed here each round. If you are off-course (Cloudy, Rainy, or Stormy), no more than 4 progress can be placed here each round instead.")
                .WithOppositeTextLine("When you defeat this stage, if the Stormcaller is at stage 2, you have caught up to the Stormcaller and win the game. Otherwise, advance to the next stage.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(13, 1, Artist.Nicholas_Gregory);
            addQuest("The Weather Turns Foul", EncounterSet.FlightOfTheStormcaller, 3, 'A', 18)
                .WithSlugSuffix("AB")
                .WithKeywords("Sailing.")
                .WithFlavorLine("As your voyage continues, the skies darken and the rain becomes relentless. Storm clouds on the horizon flash with lightning, and unpredictable wind makes setting a course difficult.")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("Forced: At the end of the staging step, if you are off-course (??, ??, or ??), reveal an additional encounter card from the top of the encounter deck.")
                .WithOppositeTextLine("When you defeat this stage, if the Stormcaller is still at stage 3, you have caught up to the Stormcaller and win the game. Otherwise, advance to the next stage.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(14, 1, Artist.Nicholas_Gregory);
            addQuest("The Cape of Andrast", EncounterSet.FlightOfTheStormcaller, 4, 'A', 24)
                .WithSlugSuffix("AB")
                .WithKeywords("Sailing.")
                .WithTextLine("When Revealed: Discard cards from the top of the encounter deck until a Weather treachery is discarded. Resolve that card’s “when revealed” effect. That effect cannot be canceled.")
                .WithFlavorLine("You’ve pursued the Stormcaller all the way to the deadly Cape of Andrast, where terrible winds and sharp jetties threaten to tear apart your entire fleet.")
                .WithOppositeTextLine("Sailing.")
                .WithOppositeTextLine("Forced: After a Weather treachery is revealed, deal 1 damage to each Ship objective and Ship enemy at this stage.")
                .WithOppositeTextLine("If you defeat this stage, you have caught up to the Stormcaller and win the game.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(15, 1, Artist.Nicholas_Gregory);
            addQuest("Full Sail Ahead", EncounterSet.FlightOfTheStormcaller, 2, 'C', 12)
                .WithSlugSuffix("CD")
                .WithFlavorLine("The Stormcaller is the pride of the Corsair fleet, swift as the wind and nigh-unsinkable. It won’t be an easy quarry to chase.")
                .WithOppositeTextLine("If the players are off-course (Cloudy, Rainy, or Stormy), the Stormcaller gets +2 Threat.")
                .WithOppositeTextLine("No more than 4 damage may be placed on the Stormcaller each round.")
                .WithOppositeTextLine("Forced: At the end of the round, discard the top card of the encounter deck. the Stormcaller places progress on this stage equal to its Threat plus the Threat of the discarded card.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(16, 1, Artist.Nicholas_Gregory);
            addQuest("The Weather Turns Foul", EncounterSet.FlightOfTheStormcaller, 3, 'C', 18)
                .WithSlugSuffix("CD")
                .WithTextLine("When Revealed: Search the encounter deck and discard pile for 1 copy of Sahír's Escort and add it to the Stormcaller's area. Shuffle the encounter deck.")
                .WithFlavorLine("Aided by other Corsair ships, the Stormcaller slips out of sight, heading into the dark clouds on the southern horizon.")
                .WithOppositeTextLine("If the players are off-course (Cloudy, Rainy, or Stormy), the Stormcaller gets +2 Threat.")
                .WithOppositeTextLine("No more than 8 damage may be placed on the Stormcaller each round.")
                .WithOppositeTextLine("Forced: At the end of the round, discard the top card of the encounter deck. the Stormcaller places progress on this stage equal to its Threat plus the Threat of the discarded card.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(17, 1, Artist.Nicholas_Gregory);
            addQuest("The Cape of Andrast", EncounterSet.FlightOfTheStormcaller, 4, 'C', 24)
                .WithSlugSuffix("CD")
                .WithFlavorLine("The Stormcaller once again slips out of your grasp, rounding the Cape of Andrast to the south.")
                .WithOppositeTextLine("Forced: At the end of the round, discard the top card of the encounter deck. the Stormcaller places progress on this stage equal to its Threat plus the Threat of the discarded card.")
                .WithOppositeTextLine("If the Stormcaller defeats this stage, Captain Sahír has gotten away with the key, and the players lose the game.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(18, 1, Artist.Nicholas_Gregory);
            addShipEnemy("Stormcaller", EncounterSet.FlightOfTheStormcaller, 50, 2, 6, 6, 18)
                .WithUnique()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithTextLine("Boarding 2. Cannot have attachments.")
                .WithTextLine("When the Stormcaller advances to the next quest stage, return it to the Stormcaller's area.")
                .WithTextLine("If the Stormcaller leaves play, the players win the game.")
                .WithInfo(19, 1, Artist.Davis_Engel);
            addShipEnemy("Sahír's Escort", EncounterSet.FlightOfTheStormcaller, 46, 2, 4, 3, 6)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithTextLine("Boarding 1. Cannot have attachments.")
                .WithTextLine("While Sahír's Escort is in the Stormcaller’s area, it contributes its Threat to the amount of progress the Stormcaller places on its quest stage each round.")
                .WithTextLine("When Revealed: Add Sahír’s Escort to the Stormcaller’s area, instead of the players’ staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(20, 3, Artist.Mariusz_Gandzel);
            addShipEnemy("Swift Raider", EncounterSet.FlightOfTheStormcaller, 38, 3, 5, 4, 8)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithTextLine("Boarding 2. Cannot have attachments.")
                .WithTextLine("While Swift Raider is in the staging area, it gains: “Forced: After a player commits 4 or more characters to a Sailing test or to the quest, Swift Raider engages that player.”")
                .WithEasyModeQuantity(1)
                .WithInfo(21, 2, Artist.Michael_Rasmussen);
            addShipEnemy("Corsair Skiff", EncounterSet.FlightOfTheStormcaller, 24, 1, 2, 2, 5)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge. Cannot have attachments.")
                .WithTextLine("Forced: When Corsair Skiff engages you from the staging area, either raise your threat by 3 or it gains Boarding 1.")
                .WithInfo(22, 2, Artist.Michael_Rasmussen);
            addEnemy("Corsair Seafarer", EncounterSet.FlightOfTheStormcaller, 26, 2, 2, 2, 3)
                .WithTraits("Corsair.", "Raider.")
                .WithTextLine("Corsair Seafarer gets +1 Attack for each resource on it.")
                .WithTextLine("Forced: After the engaged player commits a hero to a Sailing test or to a quest, move 1 resource from that hero's resource pool to Corsair Seafarer.")
                .WithInfo(23, 2, Artist.Adam_Lane);
            addEnemy("Serpent's Blade", EncounterSet.FlightOfTheStormcaller, 10, 3, 3, 3, 4)
                .WithTraits("Corsair.")
                .WithTextLine("Forced: When the Stormcaller advances to the next quest stage, Serpent's Blade makes an immediate attack against the engaged player.")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 2, Artist.Lukasz_Jaskolski);
            addLocation("Jagged Reef", EncounterSet.FlightOfTheStormcaller, 1, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithKeywords("Surge.")
                .WithTextLine("Surge.")
                .WithTextLine("Forced: At the beginning of the travel phase, if you are on-course (Sunny), place 2 progress on Jagged Reef. If you are off-course (Cloudy, Rainy, or Stormy), deal 2 damage to each Ship objective instead.")
                .WithInfo(25, 2, Artist.Trudi_Castle);
            addLocation("Hidden Cove", EncounterSet.FlightOfTheStormcaller, 3, 3)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("Travel: Move 2 progress from the main quest to the Stormcaller's quest stage.")
                .WithTextLine("Response: After Hidden Cove becomes the active location, heal 4 damage from each Ship objective.")
                .WithInfo(26, 2, Artist.Simon_Dominic);
            addLocation("Vast Coastland", EncounterSet.FlightOfTheStormcaller, 6, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithTextLine("When Revealed: Add Vast Coastland to the Stormcaller’s area.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack if you are at the same stage as The Stormcaller.")
                .WithEasyModeQuantity(1)
                .WithInfo(27, 2, Artist.Katy_Grierson);
            addTreachery("Man Overboard!", EncounterSet.FlightOfTheStormcaller)
                .WithTextLine("When Revealed: Each player contributing at least 8 Willpower to the quest must discard a questing character. If your heading is at the worst setting (Stormy), this effect cannot be canceled.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is The Stormcaller's current quest stage.")
                .WithInfo(28, 2, Artist.Leanna_Teneycke);
            addTreachery("Raging Squall", EncounterSet.FlightOfTheStormcaller)
                .WithKeywords("Doomed 2.")
                .WithTextLine("Doomed 2.")
                .WithTextLine("When Revealed: Attach Raging Squall to the current quest. (Counts as a Condition attachment with the text: “Forced: After an ally is committed to the quest, deal 1 damage to that ally if you are off-course.”)")
                .WithEasyModeQuantity(1)
                .WithInfo(29, 2, Artist.Lukasz_Jaskolski);
        }
    }
}
