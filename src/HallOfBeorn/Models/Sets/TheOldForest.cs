using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheOldForest : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Old Forest";
            Abbreviation = "TOF";
            Number = 3004;
            SetType = Models.SetType.GenConSaga_Expansion;
            Cycle = "GenCon";

            Cards.Add(new Card()
            {
                Title = "The Old Forest Introduction",
                Id = "1C97EC47-0AF3-4038-9FE1-FC308E965487",
                CardType = CardType.GenCon_Setup,
                HasSecondImage = true,
                OppositeText = 
@"~Escape the agents of ~Mordor searching for you in the ~Shire by braving a trip through the strange woods on its border in The Old ~Forest, a scenario designed for The Lord of the ~Rings : The Card Game special event at Gen Con 2014! This scenario can be played as a stand-alone adventure or as part of your Lord of the ~Rings campaign. To play The Old ~Forest in campaign mode, see page 4/4 of this expansion.

Expansion Symbol

The cards in The Old ~Forest scenario can be identified by this symbol before each card's collector number.",
                OppositeFlavorText = "\"But you won't have any luck in the Old Forest,\" objected Fedegar, \"No one ever had luck there. You'll get lost.\"\r\n-The Fellowship of the Ring",
                Number = 0,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael
            });
            Cards.Add(new Card()
            {
                Title = "The Old Forest Scenario Rules",
                Id = "D54CFC5A-86CD-4CDD-BB8F-91FEE2D19171",
                CardType = CardType.GenCon_Setup,
                HasSecondImage = true,
                Text =
@"New Staging Rules

When playing The Old ~Forest, players reveal encounter cards individually in player order during the Staging step of the Quest phase. If an encounter card has and effect that uses the word 'you' then the encounter card is referring to the player who revealed the card. If the revealed card has the Surge keyword, the player who revealed it reveals an additional card card. Encounter cards with the Doomed X keyword still affect each player.

Peril Keyword

When a player reveals an encounter card with the Peril keyword, he must resolve the staging of that card on his own without conferring with the other players. The other players cannot take any actions or trigger any responses during the resolution of that card's staging.
",
                OppositeText = 
@"Stage 2 Quest Cards

When Stage 2B instructs the players to advance to a different random stage 2A, the first player shuffles each stage 2 (except for the one currently in play) together and chooses one of them at random. Then, he replaced the current stage 2 with the chosen one. The previous stage 2 is placed back in the quest deck with the other unused stage 2 cards. Discard any progress or attachments that were on the previous stage 2.

Immune to Player Card Effects

Cards with the text 'Immune to player card effects' ignore the effects of all player cards. Additionally, cards that are immune to player card effects cannot be chosen as targets of player card effects.

Indestructible

An enemy with the indestructible keyword cannot be destroyed by damage, even when it has damage on it equal to its hit points.",
                Number = 0,
                Quantity = 1,
                Artist = Artist.Unknown
            });
            Cards.Add(new Card()
            {
                Title = "The Old Forest Campaign Rules",
                Id = "13A4D055-9C6B-4ADF-A3D5-2EAEBC309B97",
                CardType = CardType.GenCon_Setup,
                Text = 
@"The Old ~Forest can be played as part of The Lord of the ~Rings campaign. It should be played after A ~Shadow of the Past, found in The Black Riders Saga Expansion. To play The Old ~Forest in campaign mode, follow the setup instructions found on page 2 of The Black Riders rules insert.

Campaign Mode Components

The Old ~Forest expansion includes 2 cards that can only be used when playing the scenario in campaign mode: one double-sided campaign card and one boon card. The description for each of these card types can be found on page 4 of The Black Riders rules insert.

The Lord of the ~Rings : The Black Riders Saga Expansion is required to play The Old ~Forest in campaign mode.",
                Number = 0,
                Quantity = 1,
                Artist = Artist.Unknown
            });
            Cards.Add(new Card()
            {
                ImageType = Models.ImageType.Jpg,
                Title = "Aragorn",
                Id = "638BAEF3-2B18-431F-9855-B61A6CD283EA",
                CardType = CardType.Hero,
                Sphere = Sphere.Leadership,
                ThreatCost = 12,
                IsUnique = true,
                Attack = 3,
                Defense = 2,
                Willpower = 2,
                HitPoints = 5,
                Traits = new List<string>() { "Dúnedain.", "Noble.", "Ranger." },
                NormalizedTraits = new List<string> { "Dunedain." },
                Text = "Response: After Aragorn commits to a quest, spend 1 resource from his resource pool to ready him.",
                HtmlTemplate = "<p>{keyword:Sentinel.}</p><p><b>Response:</b> After {self} commits to a quest, spend 1 resource from his resource pool to ready him.</p>",
                Keywords = new List<string>() { "Sentinel." },
                Quantity = 1,
                Year = 2014,
                Artist = Artist.Sebastian_Giacobino,
                Number = 1
            });
            Cards.Add(new Card()
            {
                Title = "Farewell to the Shire",
                Id = "1351C3CA-4CC0-445E-BF8F-7FBE21E3F407",
                CardType = Models.CardType.Quest,
                HasSecondImage = true,
                ScenarioNumber = 4,
                StageNumber = 1,
                QuestPoints = 0,
                Text = 
@"Setup: Set Old Man Willow and Withywindle aside, out of play. Each player searches the encounter deck and adds 1 different location to the staging area. Shuffle the encounter deck.",
                FlavorText = "After being pursued through the Shire by mysterious riders in black, Frodo and his friends decide that the safest way for them to continue their journey to Rivendell is to travel through the Old Forest.",
                OppositeText = "When Revealed: Each player draws 1 card. Advance to a random stage 2A.",
                OppositeFlavorText = "\"You have left the Shire, and are now outside, and on the edge of the Old Forest.\" -Merry, The Fellowship of the Ring",
                EncounterSet = "The Old Forest",
                Number = 1,
                Quantity = 1,
                Artist = Artist.Brian_Valenzuela
            });
            Cards.Add(new Card()
            {
                Title = "The Living Forest",
                Id = "F63FC7D8-D1BD-46FD-8E3C-8DB75003E524",
                OppositeTitle = "Dark Bad Place",
                SlugIncludesOppositeTitle = true,
                CardType = CardType.Quest,
                HasSecondImage = true,
                ScenarioNumber = 4,
                StageNumber = 2,
                QuestPoints = null,
                Text = 
@"When Revealed: If the number of locations in the staging area is less than the number of players in the game, search the encounter deck and discard pile for a location and add it to the staging area. Shuffle the encounter deck.",
                FlavorText = "\"Everything in it is very much more alive, more aware of what is going on, so to speak, than things are in the Shire. And the trees do not like strangers.\"\r\n-Merry, The Fellowship of the Ring",
                OppositeText = 
@"Forced: At the beginning of the planning phase, each player must exhaust a hero he controls.

Forced: After placing progress as a result of questing successfully, if there are X or more total victory points on locations in the victory display, advance to stage 3A. Otherwise, advance to a different random stage 2A. X is the number of players in the game times 5.",
                EncounterSet = "The Old Forest",
                Number = 2,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael,
                SecondArtist = Artist.Nathalia_Gomes
            });
            Cards.Add(new Card()
            {
                Title = "The Living Forest",
                Id = "CA2C0050-2E27-49BE-B539-880551CE3983",
                OppositeTitle = "Choked with Brambles",
                SlugIncludesOppositeTitle = true,
                CardType = CardType.Quest,
                HasSecondImage = true,
                StageNumber = 2,
                QuestPoints = null,
                Text =
@"When Revealed: If the number of locations in the staging area is less than the number of players in the game, search the encounter deck and discard pile for a location and add it to the staging area. Shuffle the encounter deck.",
                FlavorText = "\"Everything in it is very much more alive, more aware of what is going on, so to speak, than things are in the Shire. And the trees do not like strangers.\"\r\n-Merry, The Fellowship of the Ring",
                OppositeText =
@"Forced: At the beginning of the ropund, remove all progress from each location in play.

Forced: After placing progress as a result of questing successfully, if there are X or more total victory points on locations in the victory display, advance to stage 3A. Otherwise, advance to a different random stage 2A. X is the number of players in the game times 5.",
                EncounterSet = "The Old Forest",
                Number = 3,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael,
                SecondArtist = Artist.Silver_Saaremael
            });
            Cards.Add(new Card()
            {
                Title = "The Living Forest",
                Id = "2C31C1F5-2AA5-46A7-8641-767A6D8B16E6",
                OppositeTitle = "Shifting Trees",
                SlugIncludesOppositeTitle = true,
                CardType = CardType.Quest,
                HasSecondImage = true,
                StageNumber = 2,
                QuestPoints = null,
                Text =
@"When Revealed: If the number of locations in the staging area is less than the number of players in the game, search the encounter deck and discard pile for a location and add it to the staging area. Shuffle the encounter deck.",
                FlavorText = "\"Everything in it is very much more alive, more aware of what is going on, so to speak, than things are in the Shire. And the trees do not like strangers.\"\r\n-Merry, The Fellowship of the Ring",
                OppositeText =
@"Forced: At the end of the round, discard a random location from the victory display.

Forced: After placing progress as a result of questing successfully, if there are X or more total victory points on locations in the victory display, advance to stage 3A. Otherwise, advance to a different random stage 2A. X is the number of players in the game times 5.",
                EncounterSet = "The Old Forest",
                Number = 4,
                Quantity = 1,
                Artist = Artist.Jose_Vega,
                SecondArtist = Artist.Nathalia_Gomes
            });
            Cards.Add(new Card()
            {
                Title = "The Living Forest",
                Id = "64FFA0F3-FDF4-4694-B20E-DC079F6DD958",
                OppositeTitle = "Closing in Around Them",
                SlugIncludesOppositeTitle = true,
                CardType = CardType.Quest,
                HasSecondImage = true,
                StageNumber = 2,
                QuestPoints = null,
                Text =
@"When Revealed: If the number of locations in the staging area is less than the number of players in the game, search the encounter deck and discard pile for a location and add it to the staging area. Shuffle the encounter deck.",
                FlavorText = "\"Everything in it is very much more alive, more aware of what is going on, so to speak, than things are in the Shire. And the trees do not like strangers.\"\r\n-Merry, The Fellowship of the Ring",
                OppositeText =
@"Forced: The first player reveals 1 additional encounter card during the quest phase.

Forced: After placing progress as a result of questing successfully, if there are X or more total victory points on locations in the victory display, advance to stage 3A. Otherwise, advance to a different random stage 2A. X is the number of players in the game times 5.",
                EncounterSet = "The Old Forest",
                Number = 5,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael,
                SecondArtist = Artist.Joel_Hustak
            });
            Cards.Add(new Card()
            {
                Title = "The Wicked Willow",
                Id = "A4F9F2CD-4D9A-46FB-A247-B97FE669CAF8",
                CardType = CardType.Quest,
                HasSecondImage = true,
                StageNumber = 3,
                QuestPoints = 18,
                Text =
@"When Revealed: Add Old Man Willow and Withywindle to the staging area. Reveal X encounter cards where X is the number of players in the game minus 1.",
                FlavorText = "He lifted his heavy eyes and saw leaning over him a huge willow-tree, old and hoary. Enormous it looked, its sprawling branches going up like reaching arms with many long-fingered hands... -The Fellowship of the Ring",
                OppositeFlavorText = "\"I don't like this great big tree. I don't trust it. Hark at it singing about sleep now!\" -Sam, The Fellowship of the Ring",
                OppositeText = 
@"Old Man Willow cannot leave the staging area but is considered to be engaged with each player and attacks each player in turn order during the combat phase (deal and resolve a shadow card for each attack).

If the players defeat this stage, they win the game.",
                EncounterSet = "The Old Forest",
                Number = 6,
                Quantity = 1,
                Artist = Artist.Ignacio_Bazan_Lazcano
            });
            Cards.Add(new Card()
            {
                Title = "Old Man Willow",
                Id = "985C2E66-3A70-41E7-8126-B10A5C3E94AA",
                IsUnique = true,
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 3,
                Attack = 5,
                Defense = 4,
                HitPoints = 12,
                Traits = new List<string> { "Tree." },
                Keywords = new List<string> { "Indestructible." },
                Text = "Immune to player card effects.\r\nForced: When Old Man Willow attacks, discard a random location from the victory display. The defending player raises his threat by X, where X is that location's victory point value.",
                EncounterSet = "The Old Forest",
                Number = 7,
                Quantity = 1,
                Artist = Artist.Silver_Saaremael
            });
            Cards.Add(new Card()
            {
                Title = "Long Trailer",
                Id = "4D16EECF-4F3B-4C7A-BA37-5BF58CC105EE",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 2,
                Attack = 4,
                Defense = 2,
                HitPoints = 6,
                Traits = new List<string> { "Tree." },
                Text = "While Long Trailer is in the staging area it gains: \"Forced: After the active location leaves play as an explored location, Long Trailer makes an immediate attack against the first player.\"",
                FlavorText = "\"Occasionally the most unfriendly ones may drop a branch, or stick a root out, or grasp at you with a long trailer.\" -Merry, The Fellowship of the Ring",
                EncounterSet = "The Old Forest",
                Number = 8,
                Quantity = 4,
                EasyModeQuantity = 2,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Grasping Root",
                Id = "C546E328-111E-4F79-8A5E-D2C0B1394A37",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 3,
                Attack = 3,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Tree." },
                Text = "Forced: After Grasping Root engages a player, that player must assign X damage among characters he controls. X is the number of locations in the victory display.",
                FlavorText = "...a great tree-root seemed to be over him and holding him down... -The Fellowship of the Ring",
                EncounterSet = "The Old Forest",
                Number = 9,
                Quantity = 4,
                Artist = Artist.Guillaume_Ducos
            });
            Cards.Add(new Card()
            {
                Title = "Army of Flies",
                Id = "E5B64CB4-2BAD-4309-B2B4-CEFF4DFD4904",
                CardType = CardType.Enemy,
                EngagementCost = 20,
                Threat = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Creature.", "Insect." },
                Keywords = new List<string> { "Surge." },
                Text = "Forced: After Army of Flies engages a player, that player discards a non-objective attachment he controls.",
                Shadow = "Shadow: Defending player discards a non-objective attachment he controls.",
                EncounterSet = "The Old Forest",
                Number = 10,
                Quantity = 3,
                Artist = Artist.Victor_Garcia
            });
            Cards.Add(new Card()
            {
                Title = "Withywindle",
                Id = "6CEB45D9-8E7C-4492-BC11-221E2C8F88B0",
                IsUnique = true,
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 5,
                Traits = new List<string> { "Forest.", "River." },
                Text =
@"Immune to player card effects.

The player cannot win the game while Withywindle is in play.

While Withywindle is the active location, the first player reveals 1 additional encounter card during the quest phase.",
                FlavorText = "\"The Withywindle valley is said to be the queerest part of the whole wood...\" -Merry, The Fellowship of the Ring",
                VictoryPoints = 3,
                EncounterSet = "The Old Forest",
                Number = 11,
                Quantity = 1,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new Card()
            {
                Title = "Misleading Path",
                Id = "4FF38187-FBEF-497C-B2CB-2C47E8F83C56",
                CardType = CardType.Location,
                Threat = 1,
                QuestPoints = 2,
                Traits = new List<string> { "Forest." },
                Keywords = new List<string> { "Surge." },
                Text = "When faced with the option to travel, the players must travel to Misleading Path if there is no active location.",
                Shadow = "Shadow: Defending player discards each ally card in his hand.",
                EncounterSet = "The Old Forest",
                Number = 12,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Katy_Grierson
            });
            Cards.Add(new Card()
            {
                Title = "Deep Gulley",
                Id = "0A8958A4-2C59-4FE4-8AD1-6FCFC1C342FC",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 4,
                Traits = new List<string> { "Forest." },
                Text = "While Deep Gulley is in the staging area, it gains : \"Forced: After a player optionally engages an enemy, that player raises his threat by X, where X is the engaged enemy's Attack.\"",
                FlavorText = "Each time they clambered out, the trees seemed deeper and darker... -The Fellowship of the Ring",
                VictoryPoints = 2,
                EncounterSet = "The Old Forest",
                Number = 13,
                Quantity = 4,
                Artist = Artist.Silver_Saaremael
            });
            Cards.Add(new Card()
            {
                Title = "Strange Woods",
                Id = "B16D2C3D-BCA7-4E59-BEB2-0B879FB3984E",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Forest." },
                Text = "While Strange Woods is in the staging area, characters cannot be healed.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If this attack destroys a character, raise each player's threat by 2.",
                VictoryPoints = 1,
                EncounterSet = "The Old Forest",
                Number = 14,
                Quantity = 3,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "Wall of Trees",
                Id = "D343B3AE-F70D-49F9-9FE1-A378F27DB30D",
                CardType = CardType.Location,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = 4,
                Traits = new List<string> { "Forest." },
                Text = "X equals the number of players in the game.\r\nWhile Wall of Trees is in the staging area, progress must be placed on Wall of Trees before it can be placed on the current quest.",
                FlavorText = "The trees drew close again on either side, and they could no longer see far ahead. -The Fellowship of the Ring",
                IsVariableVictoryPoints = true,
                EncounterSet = "The Old Forest",
                Number = 15,
                Quantity = 4,
                Artist = Artist.Silver_Saaremael
            });
            Cards.Add(new Card()
            {
                Title = "Oppressive Forest",
                Id = "8E6132EA-72D8-4D1D-AAA5-7F76B4BEEA4C",
                CardType = CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Forest." },
                Text = "While Oppressive Forest is in the staging area, each player cannot play more than 1 card each round.",
                Shadow = "Shadow: If there are no locations in the staging area, add this location to the staging area.",
                VictoryPoints = 2,
                EncounterSet = "The Old Forest",
                Number = 16,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Joel_Hustak
            });
            Cards.Add(new Card()
            {
                Title = "Swaying Without Wind",
                Id = "84A22DEC-A9D1-4CA4-80EA-9AAC0F0F4167",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Peril." },
                Text = "When Revealed: Choose a location in the victory display and return it to the staging area. If no location was returned to the staging area this way, Swaying Without Wind gains surge.",
                FlavorText = "\"...the branches swayed and groped without any wind.\"\r\n-Merry, The Fellowship of the Ring",
                EncounterSet = "The Old Forest",
                Number = 17,
                Quantity = 2,
                Artist = Artist.Jake_Bullock
            });
            Cards.Add(new Card()
            {
                Title = "Falling Branches",
                Id = "60FC80BA-E90C-4C5D-B721-0702D56497C3",
                CardType = CardType.Treachery,
                Text = "When Revealed: Each player removes a character he controls from the quest and deals 2 damage to that character (3 damage instead if that character is an ally).",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+2 Attack instead if the defending character is an ally.)",
                EncounterSet = "The Old Forest",
                Number = 18,
                Quantity = 3,
                EasyModeQuantity = 1,
                Artist = Artist.Victor_Garcia
            });
            Cards.Add(new Card()
            {
                Title = "Song of Sleep",
                Id = "BB2564F1-132E-4F86-A6AC-E6557DE938F1",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Enchantment." },
                Keywords = new List<string> { "Peril." },
                Text = "When Revealed: Remove a questing hero you control from the quest and attach Song of Sleep to that hero. Counts as a Condition attachment with the text: \"Limit 1 per hero. Treat attached hero's printed text box as if it were blank (except for Traits). Attached hero cannot ready.\"",
                EncounterSet = "The Old Forest",
                Number = 19,
                Quantity = 2,
                EasyModeQuantity = 1,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new Card()
            {
                Title = "Lost and Witless",
                Id = "8C62902E-50A5-4001-B32A-2023359B36F8",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Discard all progress from each location in the staging area. If there is a non-unique active location, randomly choose a location in the staging area and switch it with the active location.",
                FlavorText = "But Frodo, without any clear idea of why he did so, our what he hoped for, ran along the path crying help! help! help! -The Fellowship of the Ring",
                EncounterSet = "The Old Forest",
                Number = 20,
                Quantity = 2,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new Card()
            {
                Title = "Ending and Failing",
                Id = "82422B43-911D-4E5F-9AA3-9A509BAD418C",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Doomed 2." },
                Text = "When Revealed: At the end of the phase, raise each player's threat by X where X is the number of enemies in the staging area.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                EncounterSet = "The Old Forest",
                Number = 21,
                Quantity = 2,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new Card()
            {
                Title = "Tom Bombadil",
                Id = "F7082AC6-0FBA-4D00-8943-B2B6CEE32530",
                IsUnique = true,
                CardType = CardType.Objective_Ally,
                Willpower = 3,
                Attack = 3,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Legend." },
                Text = "When Revealed: Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, discard Tom Bombadil. Then Shuffle the encounter discard pile into the encounter deck. This effect cannot be canceled.",
                FlavorText = "\"Tom Bom, jolly Tom, Tom Bombadillo!\"\r\n-Tom Bombadil, The Fellowship of the Ring",
                EncounterSet = "The Old Forest",
                Number = 22,
                Quantity = 1,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new Card()
            {
                Title = "The Old Forest",
                OppositeTitle = "The Lord of the Rings Part 1.1",
                SlugIncludesType = true,
                Id = "17EC1E54-1D21-49FF-9B10-2E44AB8AA993",
                CardType = CardType.Campaign,
                Text = 
@"You are playing Campaign Mode.

Setup: The first player attaches Old Bogey-stories to a hero in play.",
                FlavorText = "It was not called the Old Forest without reason, for it was indeed ancient, a survivor of vast forgotten woods; and in it there lived yet, ageing no quicker than the hills, the fathers of the fathers of trees, remembering times when they were lords. The countless years had filled them with pride and rooted wisdom, and with malice. -The Fellowship of the Ring",
                OppositeText = "Resolution: If there are at least 12 damage tokens on Old Man Willow, the players have earned the Old Bogey-Stories boon card.",
                OppositeFlavorText = "Tom Bombadil burst out laughing, \"Well, my little fellows!\" said he, stooping so that he peered into their faces. \"You shall come home with me! The table is all laden with yellow cream, honeycomb, and white bread and butter. Goldberry is waiting. Time enough for questions around the supper table. You follow after me as quick as you are able!\" With that he picked up his lilies, and then with a beckoning wave of his hand went hopping and dancing along the path eastward, still singing loudly and nonsensically.\r\n-The Fellowship of the Ring",
                EncounterSet = "The Old Forest",
                Number = 23,
                Quantity = 1,
                Artist = Artist.Brian_Valenzuela
            });
            Cards.Add(new Card()
            {
                Title = "Old Bogey-stories",
                Id = "85658147-E88C-469A-AD77-BE903B1A826F",
                Sphere = Models.Sphere.Neutral,
                CardType = CardType.Attachment,
                CardSubtype = Models.CardSubtype.Boon,
                ResourceCost = 0,
                Traits = new List<string> { "Tale." },
                Text = 
@"Setup: The first player attaches Old Bogey-stories to a hero in play.

Action: Add Old Bogey-stories to the victory display to shuffle your hand of at least 6 cards into your deck. Then, draw 6 cards.",
                FlavorText = "\"If you mean the old bogey-stories Fatty's nurses used to tell him, about goblins and wolves and things of that sort, I should say no.\" -Merry, The Fellowship of the Ring",
                VictoryPoints = 1,
                Number = 24,
                Quantity = 1,
                Artist = Artist.Brian_Valenzuela
            });
        }
    }
}