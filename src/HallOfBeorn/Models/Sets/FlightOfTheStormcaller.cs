using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class FlightOfTheStormcaller : CardSet
    {
        private const string setName = "Flight of the Stormcaller";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "FotS";
            Number = 36;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Dream-chaser";

            Cards.Add(Card.Hero("Denethor", "", Sphere.Leadership, 8, 1, 1, 3, 3)
                .WithTraits("Gondor.", "Noble.", "Steward.")
                .WithText("Setup: Add 2 resources to Denethor's resource pool.\r\nAction: Move 1 resource from Denethor's resource pool to another Gondor hero's resource pool. (Limit once per round.)")
                .WithFlavor("\"...why should I sit here in my tower and think, and watch, and wait, spending even my sons? For I can still wield a brand.\"\r\n-The Return of the King")
                .WithInfo(1, 1, Artist.Joshua_Cairos));
            Cards.Add(Card.Attachment("Rod of the Steward", "", Sphere.Leadership, 0)
                .WithUnique()
                .WithTraits("Item.")
                .WithText("Attach to a Gondor hero.\r\nAction: Spend 2 resources from attached hero's resource pool to draw 1 card.")
                .WithFlavor("\"The last Steward of Gondor begs leave to surrender his office.\" And he held out a white rod.\r\n-The Return of the King")
                .WithInfo(2, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("In Service of the Steward", "", Sphere.Leadership, 1)
                .WithGeneric()
                .WithTraits("Title.")
                .WithText("Attach to a character.\r\nAttached character gains the Gondor trait.")
                .WithFlavor("But be it know that I have sworn him to my service...\r\n-The Return of the King")
                .WithInfo(3, 3, Artist.Jason_Cheeseman_Meyer));
            Cards.Add(Card.Ally("Azain Silverbeard", "", Sphere.Tactics, 3, 0, 3, 2, 2)
                .WithTraits("Dwarf.", "Warrior.")
                .WithText("Response: After Azain Silverbeard participates in an attack that destroys an enemy, spend 1 Tactics resource to deal 2 damage to another enemy that shares a Trait with the destroyed enemy. Any player may trigger this response.")
                .WithInfo(4, 3, Artist.Unknown));
            Cards.Add(Card.Event("Last Stand", "", Sphere.Tactics, 0)
                .WithText("Response: After a Warrior character is destroyed while defending against an enemy attack, deal damage to the attacking enemy equal to that character's printed Attack.")
                .WithFlavor("In a grave along under the shadow of the Hornburg lay Háma, captain of the King's guard. He fell before the Gate.\r\n-The Two Towers")
                .WithInfo(5, 3, Artist.Arden_Beckwith));
            Cards.Add(Card.Ally("Glorfindel", "", Sphere.Spirit, 5, 3, 3, 1, 4)
                .WithTraits("Noldor.", "Noble.", "Warrior.")
                .WithText("Glorfindel can be played from your discard pile.\r\nAction: Discard a card from your hand to ready Glorfindel. (Limit once per phase.)")
                .WithFlavor("\"Glorfindel is an Elf-lord of a house of princes.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("Tides of Fate", "", Sphere.Spirit, 0)
                .WithText("Response: When a shadow card increases an enemy's Attack by any amount, increase the defending character's Defense by 3 for that attack. Then, the players as a group may spend 2 Tactics resources to ready the defending character and give it +3 Attack for its next attack this phase.")
                .WithFlavor("...the tides of fate had turned against them and their doom was at hand.\r\n-The Return of the King")
                .WithInfo(7, 3, Artist.Sam_Lamont));
            Cards.Add(Card.Ally("Imladris Caregiver", "", Sphere.Lore, 2, 1, 0, 1, 2)
                .WithGeneric()
                .WithTraits("Noldor.", "Healer.")
                .WithText("Action: Discard a card from your hand to heal 1 damage on any characer. (Limit twice per round).")
                .WithFlavor("\"You are in Rivendell, and you need not worry about anything for the present.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(8, 3, Artist.Aleksander_Karcz));
            Cards.Add(Card.Event("Heed the Dream", "", Sphere.Lore, 1)
                .WithText("Action: Choose a player. That player searches the top 5 cards of his deck for a card, adds it to his hand, and shuffles his deck. Then, players as a group may spend 3 Leadership resources to have that player search his deck for another card, add it to his hand, and shuffle his deck.")
                .WithInfo(9, 3, Artist.Joshua_Cairos));
            Cards.Add(Card.Ally("Guardian of Rivendell", "", Sphere.Neutral, 3, 1, 2, 3, 3)
                .WithGeneric()
                .WithTraits("Noldor.", "Warrior.")
                .WithText("As an additional cost to play ~Guardian of Rivendell from your hand, you must discard 2 cards from your hand.")
                .WithFlavor("\"Indeed there is a power in Rivendell to withstand the might of Mordor, for a while.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(10, 3, Artist.Tawny_Fritzinger));
            Cards.Add(Card.Event("Vanish from Sight", "", Sphere.Neutral, 0)
                .WithText("Play only if you control 2 or fewer heroes.\r\nAction: Until the end of the phase, if your threat is higher than 20, treat your threat as if it is 20.")
                .WithFlavor("\"I see now little hope, if we do not soon vanish from sight for a while, and cover our trail.\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(11, 3, Artist.Nikolas_Hagialas));
            Cards.Add(Card.Quest("Swift Departure", "", 4, 1, setName, 8)
                .WithFlavor("Corsairs led by the treacherous Captain Sahír have stolen the black key you recovered in the ruins of Númenor. You must get it back!")
                .WithText("Setup: Prepare the Corsair deck. Players prepare their fleet. Prepare the Stormcaller’s area with a second quest deck consisting of only stages 2C, 3C, and 4C, as well as the Stormcaller (see insert). Search the encounter deck for 1 copy of Rolling Seas, and add it to the staging area (2 copies instead if there are 3 or more players in the game). Shuffle the encounter deck.")
                .WithKeywords("Sailing.")
                .WithOppositeText("Forced: At the end of the quest phase, if you are off-course (Cloudy, Rainy, or Stormy), move 2 progress from Swift Departure to the Stormcaller's quest stage.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(12, 1, Artist.Sara_Winters));
            Cards.Add(Card.Quest("Full Sail Ahead", "", 4, 2, setName, 12)
                .WithSuffix("AB")
                .WithFlavor("As you travel along the western coast of Middle-earth, Corsairs continue to harry your fleet in an attempt to slow your progress.")
                .WithText("When Revealed: Search the encounter deck and discard pile for 1 copy of Swift ~Raider and add it to the staging area. Shuffle the encounter deck.")
                .WithKeywords("Sailing.")
                .WithOppositeText("No more than 8 progress can be placed here each round. If you are off-course (Cloudy, Rainy, or Stormy), no more than 4 progress can be placed here each round instead.\r\nWhen you defeat this stage, if the Stormcaller is at stage 2, you have caught up to the Stormcaller and win the game. Otherwise, advance to the next stage.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(13, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("The Weather Turns Foul", "", 4, 3, setName, 18)
                .WithSuffix("AB")
                .WithFlavor("As your voyage continues, the skies darken and the rain becomes relentless. Storm clouds on the horizon flash with lightning, and unpredictable wind makes setting a course difficult.")
                .WithOppositeText("Forced: At the end of the staging step, if you are off-course (󲂒, 󲂓, or 󲂔), reveal an additional encounter card from the top of the encounter deck.\r\nWhen you defeat this stage, if the Stormcaller is still at stage 3, you have caught up to the Stormcaller and win the game. Otherwise, advance to the next stage.")
                .WithKeywords("Sailing.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(14, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("The Cape of Andrast", "", 4, 4, setName, 24)
                .WithSuffix("AB")
                .WithFlavor("You’ve pursued the Stormcaller all the way to the deadly Cape of Andrast, where terrible winds and sharp jetties threaten to tear apart your entire fleet.")
                .WithText("When Revealed: Discard cards from the top of the encounter deck until a Weather treachery is discarded. Resolve that card’s “when revealed” effect. That effect cannot be canceled.")
                .WithKeywords("Sailing.")
                .WithOppositeText("Forced: After a Weather treachery is revealed, deal 1 damage to each Ship objective and Ship enemy at this stage.\r\nIf you defeat this stage, you have caught up to the Stormcaller and win the game.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(15, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("Full Sail Ahead", "", 4, 2, setName, 12, 'C')
                .WithSuffix("CD")
                .WithFlavor("The Stormcaller is the pride of the Corsair fleet, swift as the wind and nigh-unsinkable. It won’t be an easy quarry to chase.")
                .WithOppositeText("If the players are off-course (Cloudy, Rainy, or Stormy), the Stormcaller gets +2 Threat.\r\nNo more than 4 damage may be placed on the Stormcaller each round.\r\nForced: At the end of the round, discard the top card of the encounter deck. the Stormcaller places progress on this stage equal to its Threat plus the Threat of the discarded card.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(16, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("The Weather Turns Foul", "", 4, 3, setName, 18, 'C')
                .WithSuffix("CD")
                .WithFlavor("Aided by other Corsair ships, the Stormcaller slips out of sight, heading into the dark clouds on the southern horizon.")
                .WithText("When Revealed: Search the encounter deck and discard pile for 1 copy of Sahír's Escort and add it to the Stormcaller's area. Shuffle the encounter deck.")
                .WithOppositeText("If the players are off-course (Cloudy, Rainy, or Stormy), the Stormcaller gets +2 Threat.\r\nNo more than 8 damage may be placed on the Stormcaller each round.\r\nForced: At the end of the round, discard the top card of the encounter deck. the Stormcaller places progress on this stage equal to its Threat plus the Threat of the discarded card.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(17, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.Quest("The Cape of Andrast", "", 4, 4, setName, 24, 'C')
                .WithSuffix("CD")
                .WithFlavor("The Stormcaller once again slips out of your grasp, rounding the Cape of Andrast to the south.")
                .WithOppositeText("Forced: At the end of the round, discard the top card of the encounter deck. the Stormcaller places progress on this stage equal to its Threat plus the Threat of the discarded card.\r\nIf the Stormcaller defeats this stage, Captain Sahír has gotten away with the key, and the players lose the game.")
                .WithIncludedEncounterSets(EncounterSet.VastOceans, EncounterSet.CorsairPirates, EncounterSet.StormyWeather, EncounterSet.TheDreamChasersFleet)
                .WithInfo(18, 1, Artist.Nicholas_Gregory));
            Cards.Add(Card.ShipEnemy("Stormcaller", setName, 50, 2, 6, 6, 18)
                .WithUnique()
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithText("Cannot have attachments.\r\nWhen the Stormcaller advances to the next quest stage, return it to the Stormcaller's area.\r\nIf the Stormcaller leaves play, the players win the game.")
                .WithInfo(19, 1, Artist.Davis_Engel));
            Cards.Add(Card.ShipEnemy("Sahír's Escort", setName, 46, 2, 4, 3, 6)
                .WithNormalizedTitle("Sahir's Escort")
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Boarding 1.")
                .WithText("Cannot have attachments.\r\nWhile Sahír's Escort is in the Stormcaller’s area, it contributes its Threat to the amount of progress the Stormcaller places on its quest stage each round.\r\nWhen Revealed: Add Sahír’s Escort to the Stormcaller’s area, instead of the players’ staging area.")
                .WithEasyModeQuantity(2)
                .WithInfo(20, 3, Artist.Mariusz_Gandzel));
            Cards.Add(Card.ShipEnemy("Swift Raider", setName, 38, 3, 5, 4, 8)
                .WithTraits("Cosair.", "Ship.")
                .WithKeywords("Boarding 2.")
                .WithText("Cannot have attachments.\r\nWhile Swift Raider is in the staging area, it gains: “Forced: After a player commits 4 or more characters to a Sailing test or to the quest, Swift Raider engages that player.”")
                .WithEasyModeQuantity(1)
                .WithInfo(21, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.ShipEnemy("Corsair Skiff", setName, 24, 1, 2, 2, 5)
                .WithTraits("Corsair.", "Ship.")
                .WithKeywords("Surge.")
                .WithText("Cannot have attachments.\r\nForced: When Corsair Skiff engages you from the staging area, either raise your threat by 3 or it gains Boarding 1.")
                .WithInfo(22, 2, Artist.Michael_Rasmussen));
            Cards.Add(Card.Enemy("Corsair Seafarer", "", setName, 26, 2, 2, 2, 3)
                .WithTraits("Corsair.", "Raider.")
                .WithText("Corsair Seafarer gets +1 Attack for each resource on it.\r\nForced: After the engaged player commits a hero to a Sailing test or to a quest, move 1 resource from that hero's resource pool to Corsair Seafarer.")
                .WithInfo(23, 2, Artist.Adam_Lane));
            Cards.Add(Card.Enemy("Serpent's Blade", "", setName, 10, 3, 3, 3, 4)
                .WithTraits("Corsair.")
                .WithText("Forced: When the Stormcaller advances to the next quest stage, Serpent's Blade makes an immediate attack against the engaged player.")
                .WithEasyModeQuantity(1)
                .WithInfo(24, 2, Artist.Lukasz_Jaskolski));
            Cards.Add(Card.Location("Jagged Reef", "", setName, 1, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithKeywords("Surge.")
                .WithText("Forced: At the beginning of the travel phase, if you are on-course (Sunny), place 2 progress on Jagged Reef. If you are off-course (Cloudy, Rainy, or Stormy), deal 2 damage to each Ship objective instead.")
                .WithInfo(25, 2, Artist.Trudi_Castle));
            Cards.Add(Card.Location("Hidden Cove", "", setName, 3, 3)
                .WithTraits("Coastland.", "Ocean.")
                .WithText("Travel: Move 2 progress from the main quest to the Stormcaller's quest stage.\r\nResponse: After Hidden Cove becomes the active location, heal 4 damage from each Ship objective.")
                .WithInfo(26, 2, Artist.Simon_Dominic));
            Cards.Add(Card.Location("Vast Coastland", "", setName, 6, 4)
                .WithTraits("Coastland.", "Ocean.")
                .WithText("When Revealed: Add Vast Coastland to the Stormcaller’s area.")
                .WithShadow("Shadow: Attacking enemy gets +2 Attack if you are at the same stage as The Stormcaller.")
                .WithEasyModeQuantity(1)
                .WithInfo(27, 2, Artist.Katy_Grierson));
            Cards.Add(Card.Treachery("Man Overboard!", "", setName)
                .WithText("When Revealed: Each player contributing at least 8 Willpower to the quest must discard a questing character. If your heading is at the worst setting (Stormy), this effect cannot be canceled.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack, where X is The Stormcaller's current quest stage.")
                .WithInfo(28, 2, Artist.Leanna_Teneycke));
            Cards.Add(Card.Treachery("Raging Squall", "", setName)
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Attach Raging Squall to the current quest. (Counts as a Condition attachment with the text: “Forced: After an ally is committed to the quest, deal 1 damage to that ally if you are off-course.”)")
                .WithEasyModeQuantity(1)
                .WithInfo(29, 2, Artist.Lukasz_Jaskolski));
        }
    }
}