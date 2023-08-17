using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.PrintOnDemand
{
    public class FogOnTheBarrowDowns : CardSet
    {
        protected override void Initialize()
        {
            Name = "Fog on the Barrow-downs";
            Abbreviation = "FotBD";
            Number = 3005;
            SetType = Models.SetType.FellowshipSaga_Deck;
            Cycle = "Fellowship";

            Cards.Add(new LotRCard()
            {
                Title = "Fog on the Barrow-downs Scenario Rules",
                Id = "BE094FA5-B976-4888-AB7A-D3E257E390C9",
                CardType = CardType.GenCon_Setup,
                Text = 
@"New Staging Rules

When playing Fog on the Barrow-downs, players reveal encounter cards individually in player order during the Staging step of the Quest phase. If an encounter card has an effect that uses the word 'you' then the encounter card is referring to the player who revealed the card. If the revealed card has the Surge keyword, the player who revealed it reveals an additional card. Encounter cards with the Doomed X keyword still affect each player.

Peril Keyword

When a player reveals an encounter card with the the Peril keyword, he must resolve that staging of that card on his own without conferring with ther other players. The other players cannot take any actions or trigger any responses during the resolution of that card's staging.",
                OppositeText =
@"Creating a Staging Area

When a player is instructed to create his own staging area, he sets aside an area in front of himself to serve as his own separate staging area. Players continue to resolve each phase of the game in turn order, starting with the first player, but the resolution of each phase occurs as if only the player or players that share any given staging area are present in the game.

Players cannot affect players or cards that do not share a common staging area. The players as a group still cannot have more than 1 copy of a unique card in play.

During the encounter phase, players only reveal 1 card per player that shares their staging area. Encounter card effects are limited to players and cards at that stage. Effects that reference 'each player' only affect each player at that staging area.",
                CardNumber = 0,
                Quantity = 1
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fog on the Barrow-downs Campaign Rules",
                Id = "E953D925-0DA7-4AA4-AE85-A98A8C1815DA",
                CardType = CardType.GenCon_Setup,
                Text =
@"Stage 3B - Lost in the Fog

Stage 3B (and its staging area) must remain in play until it is defeated. If there are no players at stage 3B, skip each phase at that stage.

Combining Staging Areas

When a player is instructed to combine staging areas with another staging area, each enemy and location card in that player's staging area is added to the other staging area. Enemies engaged with a player remain engaged with him.

Immune to Play Card Effects

Cards with the text 'Immune to player card effects' ignore the effects of all player cards. Additionally, cards that are immune to player card effects cannot be chosen as targets of player card effects.",
                OppositeText =
@"Campaign Mode

Fog on the Barrow-downs can be played as part of The Lord of the Rings campaign. It should be played before A Knife in the ~Dark, found in The Black Riders Saga Expansion. To play Fog on the Barrow-downs in campaign mode, follow the setup instructions found on page 2 of The Black Riders rules insert.

Campaign Mode Components

Fog on the Barrow-downs expansion includes 2 cards that can only be used when playing the scenario in campaign mode: one double-sided campaign card and one boon card. The description for each of these card types can be found on page 4 of The Black Riders rules insert.

The Lord of the ~Rings: The Black Riders Saga Expansion is required to play Fog on the Barrow-downs in campaign mode.",
                CardNumber = 0,
                Quantity = 1
            });
            addHero("Aragorn", 12, Sphere.Leadership, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Response: After Aragorn commits to a quest, spend 1 resource from his resource pool to ready him.")
                .WithYear(2014)
                .WithPromotion()
                .WithInfo(1, 1, Artist.Sebastian_Giacobino);
            Cards.Add(new LotRCard()
            {
                Title = "The House of Tom Bombadil",
                Id = "BACA2A71-4CE6-4003-B8D1-8279869DF137",
                CardType = CardType.Quest,
                StageNumber = 1,
                QuestPoints = 1,
                FlavorText = "After rescuing the hobbits from Old Man Willow, Tom Bombadil has invited Frodo and his friends to stay the night in his house. There they are greeted warmly by his wife, Goldberry, the River-daughter.",
                Text = "Setup: Set each copy of Great ~Barrow, Standing Stones, and Hollow Circle aside, out of play. Shuffle the encounter deck.",
                OppositeFlavorText = "\"Let us shit out the night!\" she said. \"For you are still afraid, perhaps, of mist and tree-shadows and deep water, and untame things. Fear nothing! For tonight you are under the roof of Tom Bombadil.\"\r\n-The Fellowship of the Ring",
                OppositeText = "Skip the quest phase.\r\nForced: At the end of the round, place 1 progress on this stage.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 1,
                CardNumber = 1,
                Artist = Artist.Emrah_Elmasli
            });
            Cards.Add(new LotRCard()
            {
                Title = "Across the Downs",
                Id = "E15090E3-CF35-4BF5-9B89-38D09CA8A9E0",
                CardType = Models.LotR.CardType.Quest,
                StageNumber = 2,
                Text = "When Revealed: Add Hollow Circle to the staging area. Each player reveals 1 encounter card.",
                OppositeText = "Forced: At the end of the refresh phase, raise each player's threat by 1.\r\nThe players cannot defeat this stage unless Hollow Circle is in the victory display.",
                QuestPoints = 14,
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 1,
                CardNumber = 2,
                Artist = Artist.Emrah_Elmasli

            });
            Cards.Add(new LotRCard()
            {
                Title = "Lost in the Fog",
                Id = "56D70012-B295-468A-9064-4E1C22BF9C9D",
                CardType = Models.LotR.CardType.Quest,
                StageNumber = 3,
                Text = "When Revealed: The first player adds Standing Stones to the staging area. Each other player reveals 1 encounter card. Shuffle the encounter discard pile and each copy of Great Barrows into the encounter deck.",
                OppositeText = 
@"Progress cannot be placed here while Great Barrow is in play.

Forced: After a player is eliminated (at any stage), raise the threat of each player at this stage by 10.

The players cannot defeat this stage unless each player in the game is at this stage and Standing Stones is in the victory display. If the players defeat this stage, they win the game.",
                QuestPoints = 16,
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 1,
                CardNumber = 3,
                Artist = Artist.Florian_Devos

            });
            Cards.Add(new LotRCard()
            {
                Title = "Trapped Inside a Barrow",
                Id = "E84070BC-F6B6-4ED3-8CAC-158CE4268696",
                CardType = Models.LotR.CardType.Quest,
                StageNumber = 4,
                Text = "When Revealed: End your quest phase (do not resolve the quest). Discard cards from the encounter deck until a Wight enemy is discarded. Add the discarded Wight enemy to the staging area. Discard all but X allies you control where X is the number of enemies engaged with you.",
                OppositeText = 
@"Forced: When a location is revealed at this stage, cancel its effects and discard it. Then, raise your threat by that card's Threat (including modifiers).

Forced: After this stage is defeated, advance to stage 3B at the beginning of the travel phase (combining staging areas with stage 3B) and place 1 progress on a Great Barrow at that stage.",
                QuestPoints = 9,
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 4,
                CardNumber = 4,
                Artist = Artist.Mark_Bulahao

            });
            Cards.Add(new LotRCard()
            {
                Title = "Hollow Circle",
                IsUnique = true,
                Id = "5FC12A2C-1F79-4EEB-BC43-8432797DCCBC",
                CardType = Models.LotR.CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Ruins.", "Downs." },
                Text = "Immune to player card effects.\r\nTravel: Each player searches the encounter deck and discard pile for a Wight enemy and puts it into play engaged with him. Shuffle the encounter deck.",
                FlavorText = "It was shapeless and yet significant: like a landmark, or a guarding finger, or more like a warning.\r\n-The Fellowship of the Ring",
                VictoryPoints = 3,
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 1,
                CardNumber = 5,
                Artist = Artist.Jose_Vega

            });
            Cards.Add(new LotRCard()
            {
                Title = "Standing Stones",
                IsUnique = true,
                Id = "80AA9A99-4DB0-403E-B013-557406F9C4AC",
                CardType = Models.LotR.CardType.Location,
                Threat = 4,
                QuestPoints = 4,
                Traits = new List<string> { "Ruins.", "Downs." },
                Text = "Immune to player card effects.\r\nTravel: The first player searches the encounter deck, discard pile and victory display the a Great Barrow and adds it to the staging area. Shuffle the encounter deck.",
                FlavorText = "He had passed between them almost before he was aware: and even as he did so darkness seemed to fall round him. -The Fellowship of the Ring",
                VictoryPoints = 3,
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 1,
                CardNumber = 6,
                Artist = Artist.Jose_Vega

            });
            Cards.Add(new LotRCard()
            {
                Title = "Great Barrow",
                Id = "20749647-0C3C-4BB8-ABD5-C9466452FC60",
                CardType = Models.LotR.CardType.Location,
                Threat = 1,
                QuestPoints = 1,
                Traits = new List<string> { "Ruins.", "Downs." },
                Keywords = new List<string> { "Peril." },
                Text = "Peril. Immune to player card effects. The player cannot travel hereo.\r\nForced: After Great Barrow enters the staging area, remove each character you control from the quest and create your own staging area. Then advance to a separate stage 4A by yourself.",
                VictoryPoints = 5,
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 5,
                EasyModeQuantity = 3,
                CardNumber = 7,
                Artist = Artist.Anthony_Devine
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ancient Barrow",
                Id = "DCECC2B9-7AAE-4E77-8268-07DD49FCFFF9",
                CardType = Models.LotR.CardType.Location,
                Threat = Card.VALUE_X,
                QuestPoints = 4,
                Traits = new List<string> { "Ruins.", "Downs." },
                Text = "X is 1 plus the number of facedown cards under this location.\r\nForced: After Ancient Barrow enters play, each player places an ally he controls facedown under this location. When Ancient Barrow leaves play as an explored location, return each ally under this location to its owner's hand.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 3,
                EasyModeQuantity = 2,
                CardNumber = 8,
                Artist = Artist.Ferdinand_Dumago_Ladera
            });
            Cards.Add(new LotRCard()
            {
                Title = "Stone Ring",
                Id = "3861F516-CB2D-407C-854D-3590572D69FC",
                CardType = Models.LotR.CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Ruins.", "Downs." },
                Text = "While Stone Ring is in the staging area, each Wight enemy engaged with a player gets +1 Attack and +1 Defense and applies the first sentence of its game text to each player at this stage as if it were engaged with him.",
                FlavorText = "Stone rings grinned out of the ground like broken teeth in the moonlight. -The Fellowship of the Ring",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 4,
                EasyModeQuantity = 3,
                CardNumber = 9,
                Artist = Artist.Ferdinand_Dumago_Ladera

            });
            Cards.Add(new LotRCard()
            {
                Title = "North Downs",
                Id = "A98F4E8A-B2DC-48BA-B0A1-FA7AA53A5597",
                CardType = Models.LotR.CardType.Location,
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Downs." },
                Text = "While North Downs is in the staging area, characters use their Willpower instead of their Defense when defending against Wight enemies.",
                Shadow = "Shadow: Attacking enemy gets +2 Attack. If this attack destroys a character, raise each player's threat by 2.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 4,
                CardNumber = 10,
                Artist = Artist.Emrah_Elmasli
            });
            Cards.Add(new LotRCard()
            {
                Title = "Barrow-wight",
                Id = "74D9131D-BED7-4E9A-B649-05D4344ED339",
                CardType = Models.LotR.CardType.Enemy,
                EngagementCost = 30,
                Threat = 3,
                Attack = 5,
                Defense = 1,
                HitPoints = 6,
                Traits = new List<string> { "Wight." },
                Text = "While Barrow-wight is engaged with a player, that player's threat cannot be reduced.\r\nForced: After Barrow-wight attacks and destroys a character, that character's controller raises his threat by 2.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 4,
                EasyModeQuantity = 3,
                CardNumber = 11,
                Artist = Artist.Anthony_Devine
            });
            Cards.Add(new LotRCard()
            {
                Title = "Cold-wight",
                Id = "BE22869A-14ED-45ED-90E1-AA0D3A19A1FF",
                CardType = Models.LotR.CardType.Enemy,
                EngagementCost = 35,
                Threat = 2,
                Attack = 4,
                Defense = 1,
                HitPoints = 5,
                Traits = new List<string> { "Wight." },
                Text = "While Cold-wight is engaged with a player, that player cannot draw cards from card effects.\r\nForced: After Cold-wight attacks and destroys a character, that character's controller discards a random card from his hand.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 3,
                CardNumber = 12,
                Artist = Artist.Anthony_Devine
            });
            Cards.Add(new LotRCard()
            {
                Title = "Dark-wight",
                Id = "6F3E5C9B-22B7-409A-B20C-578B49E419C7",
                CardType = Models.LotR.CardType.Enemy,
                EngagementCost = 40,
                Threat = 2,
                Attack = 3,
                Defense = 1,
                HitPoints = 7,
                Traits = new List<string> { "Wight." },
                Text = "While Dark-wight is engaged with a player, that player's heros cannot gain resources from card effects.\r\nForced: After Dark-wight attacks and destroys a character, that character's controller discards all resources from each hero he controls.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 3,
                CardNumber = 13,
                Artist = Artist.Anthony_Devine
            });
            Cards.Add(new LotRCard()
            {
                Title = "I'm Waiting for You!",
                Id = "044CBEF3-2DFF-4153-9D8E-170826EB1B50",
                CardType = Models.LotR.CardType.Treachery,
                Text = "When Revealed: Each Wight enemy engaged with a player makes an immediate attack. If no attacks were made this way, I'm Waiting for You! gains surge.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack (+3 Attack instead if the defending character is an ally).",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 14,
                Artist = Artist.Anthony_Devine
            });
            Cards.Add(new LotRCard()
            {
                Title = "Long Groping Arm",
                Id = "5CC082D1-028A-40B6-BA2B-551E8AC3AB34",
                CardType = Models.LotR.CardType.Treachery,
                Keywords = new List<string> { "Peril." },
                Text = "Peril.\r\nWhen Revealed: Until the end of the phase, each Wight enemy engaged with you contributes its Threat to the total Threat in the staging area. If no enemies are engaged with you, search the encounter deck and discard pile for a Wight enemy and put it into play engaged with you. Shuffle the encounter deck.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 3,
                CardNumber = 15,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new LotRCard()
            {
                Title = "Chill Fog",
                Id = "38E841B2-29E8-496C-93A9-13C96031FC2E",
                CardType = Models.LotR.CardType.Treachery,
                Text = "When Revealed: Discard all resources in play. Each player raises his threat by 1 for each resource he discarded this way. If no resources were discarded this way, Chill Fog gains surge.",
                Shadow = "Shadow: Raise your threat by 1 for each damage dealt by this attack.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 2,
                CardNumber = 16,
                Artist = Artist.Anthony_Feliciano
            });
            Cards.Add(new LotRCard()
            {
                Title = "Frozen by Fear",
                Id = "35971087-EE5B-4075-AE12-4B730AA873EB",
                CardType = Models.LotR.CardType.Treachery,
                Keywords = new List<string> { "Surge.", "Doomed 1." },
                Text = "Surge. Doomed 1.\r\nWhen Revealed: Until the end of the round, players cannot trigger Action or Response effects.",
                Shadow = "Shadow: Until the end of the round, attacking enemy cannot take damage.",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 3,
                EasyModeQuantity = 2,
                CardNumber = 17,
                Artist = Artist.Rafal_Hrynkiewicz
            });
            Cards.Add(new LotRCard()
            {
                Title = "Dreadful Song",
                Id = "A625C893-4B7B-4765-9E2B-FE403DD5548B",
                CardType = Models.LotR.CardType.Treachery,
                Traits = new List<string> { "Enchantment." },
                Keywords = new List<string> { "Peril." },
                Text = "Peril.\r\nWhen Revealed: Attach to a questing hero you control. Counts as a Condition attachment with the text: \"Limit 1 per hero. Attached hero's Willpower is 0. Forced: At the end of the round, raise your threat by 1 for each Wight enemy engaged with you.\"",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 18,
                Artist = Artist.Florian_Devos
            });
            Cards.Add(new LotRCard()
            {
                Title = "Tom Bombadil",
                IsUnique = true,
                Id = "A611EE75-F6C3-4BC6-97E2-B897F6A36DAC",
                CardType = Models.LotR.CardType.Objective_Ally,
                Willpower = 3,
                Attack = 3,
                Defense = 3,
                HitPoints = 6,
                Traits = new List<string> { "Legend." },
                Text = "When Revealed: Choose a player. That player gains control of Tom Bombadil, ready and committed to the quest. At the end of the round, discard Tom Bombadil. Then shuffle the encounter discard pile into the encounter deck. This effect cannot be canceled.",
                FlavorText = "\"Tom Bom, Jolly Tom, Tom Bombadillo!\" -Tom Bombadil, The Fellowship of the Ring",
                EncounterSet = "Fog on the Barrow-downs",
                Quantity = 1,
                CardNumber = 19,
                Artist = Artist.Romana_Kendelic
            });
            Cards.Add(new LotRCard()
            {
                Title = "Fog on the Barrow-downs",
                OppositeTitle = "The Lord of the Rings Part 1.2",
                Id = "ACC07870-CD7F-4B88-A8A5-6C1FBFF6A55D",
                CardType = CardType.Campaign,
                Text = "You are playing Campaign Mode.\r\nSetup: While any player is at stage 4B, the first player cannot lose control of the first player token.",
                FlavorText = "Even in the Shire the rumour of the Barrow-wights of the Barrow-downs beyond the Forest had been heard. But it was not a tale than any hobbit liked to listen to, even by a comfortable fireside far away. -The Fellowship of the Ring",
                OppositeText = "Resolution: The players have earned the Ho! Tom Bombadil! boon card.",
                OppositeFlavorText = "At last they set off. They led their ponies down the hill; and then mounting they trotted quickly along the valley. They looked back and saw the top of the old mound on the hill, and from it the sunlight on the gold went up like a yellow flame. Then they turned a shoulder of the Downs and it was hidden from view.\r\n-The Fellowship of the Ring",
                EncounterSet = "Fog on the Barrow-downs",
                CardNumber = 20,
                Quantity = 1,
                Artist = Artist.Emrah_Elmasli
            }.WithSlugSuffix("Campaign"));
            addEvent("Ho! Tom Bombadil!", 0, Sphere.Neutral)
                .WithBoon()
                .WithTraits("Song.")
                .WithTextLine("Setup: The first player adds this card to his hand.")
                .WithTextLine("Response: Add this card to the victory display and remove it from the campaign pool to cancel the \"when revealed\" effects of an encounter card just revealed from the encounter deck.")
                .WithFlavorLine("By fire, sun and moon, harken now and hear us!")
                .WithFlavorLine("Come, Tom Bombadil, for our need is near us!")
                .WithFlavorLine("-Frodo, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(21, 1, Artist.Romana_Kendelic);
        }
    }
}