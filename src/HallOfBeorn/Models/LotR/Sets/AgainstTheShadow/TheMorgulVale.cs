using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.AgainstTheShadow
{
    public class TheMorgulVale : CardSet
    {
        private const string setName = "The Morgul Vale";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TMV";
            Number = 21;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Against the Shadow";

            Cards.Add(new LotRCard()
            {
                Id = "29d5feef-6165-4077-bb80-692526a8a924",
                CardType = CardType.Hero,
                IsUnique = true,
                Sphere = Models.LotR.Sphere.Tactics,
                Artist = Artist.Magali_Villeneuve,
                ThreatCost = 12,
                Willpower = 2,
                Attack = 3,
                Defense = 2,
                HitPoints = 4,
                Title = "Théoden",
                Text = "Each hero with a printed Tactics resource icon gets +1 Willpower.",
                FlavorText = "'To me! To me!' cried Théoden. 'Up Eorlingas! Fear no darkness!' -The Return of the King",
                Quantity = 1,
                CardNumber = 134
            }
            .WithTraits("Rohan.", "Noble.", "Warrior.")
            .WithKeywords("Sentinel."));
            Cards.Add(new LotRCard()
            {
                Id = "1f28f098-09d4-43fa-8fba-eae551a5d4fe",
                Sphere = Models.LotR.Sphere.Leadership,
                CardType = Models.LotR.CardType.Ally,
                ResourceCost = 2,
                Willpower = 1,
                Attack = 1,
                Defense = 0,
                HitPoints = 2,
                Traits = new List<string> { "Gondor." },
                Text = "Response: After Pelargir Ship Captain enters play, move 1 resource from the resource pool of a hero you control to another hero's resource pool.",
                Title = "Pelargir Ship Captain",
                Quantity = 3,
                CardNumber = 135,
                Artist = Artist.Jake_Murray
            });

            Cards.Add(new LotRCard()
            {
                Id = "2f0a3f18-c84f-4458-b6f7-2e6be9acee6b",
                Sphere = Models.LotR.Sphere.Leadership,
                CardType = Models.LotR.CardType.Attachment,
                ResourceCost = 2,
                IsUnique = true,
                Title = "Visionary Leadership",
                Traits = new List<string> { "Skill." },
                Text = "Attach to a Gondor hero.\r\nWhile attached hero has at least 1 resource in its resource pool, Gondor characters get +1 Willpower.",
                FlavorText = "\"...still the lords of Gondor have keener sight than lesser men...\" -Denethor, The Return of the King",
                Quantity = 3,
                CardNumber = 136,
                Artist = Artist.Milek_Jakubiec
            });

            Cards.Add(new LotRCard()
            {
                Id = "66d8e628-8ca8-4605-9017-aece027f054f",
                Sphere = Models.LotR.Sphere.Tactics,
                CardType = Models.LotR.CardType.Attachment,
                ResourceCost = 1,
                Title = "Spear of the Mark",
                Traits = new List<string> { "Item.", "Weapon." },
                Keywords = new List<string> { "Restricted." },
                Text = "Attach to a Rohan character.\r\nAttached character gets +1 Attack. (+2 Attack instead if attacking an enemy in the staging area).",
                FlavorText = "Right through the press drove Théoden Thengel's son, and his spear was shivered as he threw down thier chieftan. -The Return of the King",
                Quantity = 3,
                CardNumber = 137,
                Artist = Artist.Jon_Bosco
            });

            Cards.Add(new LotRCard()
            {
                Id = "80cdd2b5-60cf-4d47-afe7-505b79abcb1b",
                Sphere = Models.LotR.Sphere.Tactics,
                CardType = Models.LotR.CardType.Event,
                ResourceCost = 2,
                Title = "Forth Eorlingas!",
                Text = "Combat Action: Each Rohan hero can be declared as an attacker against enemies in the staging area this phase.",
                FlavorText = "\"Oaths ye have taken: now fulfill them all, to lord and land and league of friendship!\" -Théoden, The Return of the King",
                Quantity = 3,
                CardNumber = 138,
                Artist = Artist.Darek_Zabrocki
            });

            Cards.Add(new LotRCard()
            {
                Id = "90d300da-a557-44b1-a634-d54782ff5e48",
                Sphere = Models.LotR.Sphere.Spirit,
                CardType = Models.LotR.CardType.Attachment,
                ResourceCost = 1,
                Title = "Steed of the Mark",
                Traits = new List<string> { "Mount." },
                Text = "Attach to a Gondor or Rohan hero.\r\nResponse: after attached hero commits to a quest, spend 1 resource from attached hero's resource pool to ready attached hero.",
                FlavorText = "...fresh horses were always in readiness to bear his errand-riders to Rohan in the Noth... -The Return of the King",
                Quantity = 3,
                CardNumber = 139,
                Artist = Artist.Sandara_Tang
            });

            Cards.Add(new LotRCard()
            {
                Id = "b442354c-887d-403e-815b-a11f10a8760d",
                Sphere = Models.LotR.Sphere.Spirit,
                CardType = Models.LotR.CardType.Event,
                ResourceCost = 1,
                Title = "Lay of Nimrodel",
                Traits = new List<string> { "Song." },
                Text = "Action: Choose a Spirit hero. Until the end of the phase, that hero gets +1 Willpower for each resource in its resource pool.",
                FlavorText = "An Elven-maid there was of old.\r\nA shining star by day:\r\nHer mantle white was hemmed with hold,\r\nHer shoes of silver-grey.\r\n-The Fellowship of the Ring",
                Quantity = 3,
                CardNumber = 140,
                Artist = Artist.Magali_Villeneuve
            });

            Cards.Add(new LotRCard()
            {
                Id = "3eb1141f-bf1f-401e-a69d-e4df0af2a8ab",
                Sphere = Models.LotR.Sphere.Lore,
                CardType = Models.LotR.CardType.Ally,
                ResourceCost = 2,
                Title = "Ered Nimrais Prospector",
                Willpower = 1,
                Attack = 0,
                Defense = 1,
                HitPoints = 2,
                Traits = new List<string> { "Dwarf." },
                Text = "Response: After Ered Nimrais Prospector enters play, discard the top 3 cards of your deck. Then, choose and shuffle 1 card from your discard pile back into your deck.",
                Quantity = 3,
                CardNumber = 141,
                Artist = Artist.Jason_Ward
            });

            Cards.Add(new LotRCard()
            {
                Id = "63c6bd3a-5566-412d-9199-3929d2fc3cf2",
                Sphere = Models.LotR.Sphere.Lore,
                CardType = Models.LotR.CardType.Attachment,
                IsUnique = true,
                ResourceCost = 4,
                Title = "Scroll of Isildur",
                Traits = new List<string> { "Record." },
                Text = "Attach to a Lore hero.\r\nReduce the cost to play ~Scroll of Isildur by 1 for each hero you control with a printed Lore resource icon.\r\nAction: Discard ~Scroll of Isildur to play any Lore event card in your discard pile as if it were in your hand. Then, place that event on the bottom of your deck.",
                Quantity = 3,
                CardNumber = 142,
                Artist = Artist.Sara_Biddle
            });

            Cards.Add(new LotRCard()
            {
                Id = "6a871e9e-fa3e-4556-8730-09aed1a3ec40",
                Sphere = Models.LotR.Sphere.Neutral,
                CardType = Models.LotR.CardType.Event,
                ResourceCost = 0,
                Title = "Hidden Cache",
                Text = "Response: After Hidden Cache is discarded from your deck, add 2 resources to the resource pool of a hero you control.\r\nAction: Spend 1 resource to draw 1 card.",
                FlavorText = "...there was a good deal of food jumbled carlessly on shelves and on the ground, among an untidy litter of plunder...\r\n-The Hobbit",
                Quantity = 3,
                CardNumber = 143,
                Artist = Artist.Aurelien_Hubert
            });

            Cards.Add(new LotRCard()
            {
                Id = "30a319ff-6092-4d5f-9b94-2a9b4f44f9c1",
                StageNumber = 1,
                CardType = Models.LotR.CardType.Quest,
                Title = "The Rearguard",
                FlavorText = "Lord Alcaron and Faramir have been captured by forces from Minas Morgul. You pursue their captors eastward into the dreaded vale.",
                Text = "Set aside Lord Alcaron, ~Nazgûl of Minas ~Morgul, and The White ~Bridge. Add To the Tower, Murzag and 1 copy of ~Morgul Vale to the staging area.",
                OppositeFlavorText = "You are betrayed! Lord Alcaron has revealed himself as in league with the Enemy. A large Uruk, Murzag, has been left in charge of finishing you off while Faramir is rushed ahead to the Dead City.",
                OppositeText = "Murzag cannot leave play unless destroyed. If Murzag is defeated, advance to the next stage.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 144,
                Artist = Artist.Sidharth_Chatursedi,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MordorElite, EncounterSet.CreaturesOfTheForest }
            });

            Cards.Add(new LotRCard()
            {
                Id = "49aa4e88-3774-43f7-ab8d-05268ed3fb7e",
                StageNumber = 2,
                CardType = Models.LotR.CardType.Quest,
                Title = "The Betrayal",
                FlavorText = "You've defeated Murzag and his kin. There is no time for rest as you follow Faramir depper into the vale. Soon you find the traitor Alcaron blocking the road, a grimace of anger on his formerly handsome face. \"By the the thousand thorn-drakes of Morgai, you do temp my patience!\" he sneers.",
                Text = "When Revealed: Add Lord Alcaron to the staging area.",
                OppositeText = "Lord Alcaron cannot leave play unless destroyed. If Lord Alcaron is defeated, advance to the next stage.",
                OppositeFlavorText = "Alcaron utters an ancient word, and a ghastly shriek rises from Minas Morgul. Something cold and terrible has awoken. Something that is aware of your presence. A short distance ahread, the Uruk carrying Faramir pauses, intimidated by the carrion cry from the city. There may still be time. But first you must deal with the traitor...",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 145,
                Artist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MordorElite, EncounterSet.CreaturesOfTheForest }
            });
            Cards.Add(new LotRCard()
            {
                Id = "8b4dd0c5-3847-46f6-a69b-a4c7ee2b21c8",
                StageNumber = 3,
                CardType = Models.LotR.CardType.Quest,
                Title = "The Morgul Rider",
                FlavorText = "You've delivered justice to the traitor Alcaron. You rush forward to help Lord Faramir, who is still struggling with his captors. Then another shrill crwy emanates from the city. It pierces your ears and chills your heart. With a dull clangor; the gates of Minas Morgul open. Mounted on a great black horse, a Nazgûl rides forth to claim Sauron's prize.",
                Text = "When Revealed: Add ~Nazgûl of Minas ~Morgul and The White ~Bridge to the staging area.",
                OppositeText = "When Revealed: Reveal 1 card per player from the encounter deck and add it to the staging area.\r\n~Nazgûl of Minas ~Morgul cannot leave play unless destroyed.\r\nIf ~Nazgûl of Minas ~Morgul is defeated, the players have won the game.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 146,
                Artist = Artist.Magali_Villeneuve,
                IncludedEncounterSets = new List<EncounterSet> { EncounterSet.MordorElite, EncounterSet.CreaturesOfTheForest }
            });

            Cards.Add(new LotRCard()
            {
                Id = "a6dd52d0-375a-41ea-ae77-b0fd9bcb6629",
                CardType = CardType.Objective,
                Title = "To the Tower",
                Traits = new List<string> { "Captured." },
                Text = "To the Tower cannot leave the staging area.\r\nRemove Faramir from the game.\r\nIf 10 or more progress tokens are on To the Tower, the players have lost the game.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 147,
                Artist = Artist.Darek_Zabrocki
            });

            Cards.Add(new LotRCard()
            {
                Id = "aca1ee7f-ad29-4218-8dd5-f7f7a8e617fe",
                CardType = CardType.Enemy,
                Title = "Morgul Bodyguard",
                EngagementCost = 35,
                Threat = 1,
                Attack = 2,
                Defense = 2,
                HitPoints = 6,
                Traits = new List<string> { "Mordor." },
                Text = "Any damage that would be dealt to a Captain enemy is dealt to 1 Morgul Bodyguard instead.",
                Shadow = "Shadow: Attacking enemy engages the next player and makes an immediate attack, if able.",
                EncounterSet = setName,
                Quantity = 4,
                CardNumber = 148,
                Artist = Artist.Rafal_Hrynkiewicz
            });

            Cards.Add(new LotRCard()
            {
                Id = "c12057ee-64d0-419a-adb8-17632e3182b0",
                CardType = CardType.Enemy,
                Title = "Morgul Sorcerer",
                EngagementCost = 5,
                Threat = 1,
                Attack = 3,
                Defense = 1,
                HitPoints = 3,
                Traits = new List<string> { "Mordor." },
                Text = "Forced: After any number of progress tokens are placed on To the Tower, deal Morgul Sorcerer a shadow card.",
                Shadow = "Shadow: Defending player must place 1 progress token on To the Tower or treat this attack as undefended.",
                EncounterSet = setName,
                Quantity = 2,
                CardNumber = 149,
                Artist = Artist.Jim_Pavelec
            });

            Cards.Add(new LotRCard()
            {
                Id = "6987d363-bcba-4f34-97b1-d26f080c843e",
                CardType = CardType.Enemy,
                Title = "Morgul Tracker",
                EngagementCost = 40,
                Threat = 4,
                Attack = 1,
                Defense = 0,
                HitPoints = 3,
                Traits = new List<string> { "Orc.", "Mordor." },
                Text = "Forced: When Morgul Tracker is optionally engaged, place 1 progress token on To the Tower.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. If undefended, place 1 progress token on To the Tower as well.",
                EncounterSet = setName,
                Quantity = 3,
                CardNumber = 150,
                Artist = Artist.Yigit_Koroglu
            });

            Cards.Add(new LotRCard()
            {
                Id = "a305f78f-0d26-4a56-9d5b-7fb0210e6bd4",
                CardType = CardType.Enemy,
                IsUnique = true,
                Title = "Murzag",
                EngagementCost = 30,
                Threat = 2,
                Attack = 5,
                Defense = 2,
                HitPoints = 7,
                Traits = new List<string> { "Orc.", "Uruk.", "Captain." },
                Text = "Forced: After Murzag attacks, reveal the top card of the encounter deck. If that card is an enemy, put it into play engaged with the defending player.",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 151,
                Artist = Artist.Jim_Pavelec
            });

            Cards.Add(new LotRCard()
            {
                Id = "499195c5-389f-4a56-b67e-b6e5b8f2fb91",
                CardType = CardType.Enemy,
                IsUnique = true,
                Title = "Lord Alcaron",
                EngagementCost = 10,
                Threat = 3,
                Attack = 4,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Gondor.", "Traitor.", "Captain." },
                Text = "Forced: When Lord Alcaron attacks, place 1 progress token on To the Tower.\r\nForced: When Lord Alcaron is dealt a shadow card with no shadow effect, he makes an additional attack after this one (deal and resolve another shadow card).",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 152,
                Artist = Artist.Magali_Villeneuve
            });

            Cards.Add(new LotRCard()
            {
                Id = "3ef4f724-8f91-42d3-9ba2-5d731283c069",
                CardType = CardType.Enemy,
                IsUnique = true,
                Title = "Nazgûl of Minas Morgul",
                EngagementCost = 1,
                Threat = 4,
                Attack = 7,
                Defense = 4,
                HitPoints = 5,
                Traits = new List<string> { "Nazgûl.", "Captain." },
                Text = "Cannot have attachments.\r\nReduce any amount of damage dealt to Nazgûl of Minas Morgul to 1.",
                FlavorText = "\"Come not between the Nazgûl and his prey!\"\r\n-The Witch King, The Return of the King",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 153,
                Artist = Artist.Jake_Murray
            });

            Cards.Add(new LotRCard()
            {
                Id = "3e0e63ba-d11b-4c8a-aab6-047f19013ca7",
                CardType = CardType.Location,
                Title = "Morgul Road",
                Threat = 2,
                QuestPoints = 5,
                Traits = new List<string> { "Road." },
                Text = "Response: After Morgul Road leaves play as an explored location, the first player may remove 1 progress token from To the Tower or deal 1 damage to any enemy in play.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                EncounterSet = setName,
                Quantity = 3,
                CardNumber = 154,
                Artist = Artist.Trudi_Castle
            });

            Cards.Add(new LotRCard()
            {
                Title = "Morgul Vale",
                Id = "e176b4d7-2fae-4025-8a71-5c3bc843e2e1",
                
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 3,
                Traits = new List<string> { "Valley." },
                Text = "Forced: At the end of the round, each player returns 1 enemy engaged with him to the staging area.",
                Shadow = "Shadow: If this attack destroys a character, place 1 progress token on To the Tower.",
                EncounterSet = setName,
                Quantity = 3,
                CardNumber = 155,
                Artist = Artist.Jake_Murray
            });

            Cards.Add(new LotRCard()
            {
                Id = "95f2f7ac-5d85-43e5-930d-d866b00bef26",
                CardType = CardType.Location,
                Title = "The White Bridge",
                Threat = Card.VALUE_X,
                QuestPoints = Card.VALUE_X,
                Traits = new List<string> { "Bridge." },
                Text = "X is the number of progress tokens on To the Tower.",
                FlavorText = "So they came slowly to the white bridge.\r\n-The Two Towers",
                EncounterSet = setName,
                Quantity = 1,
                CardNumber = 156,
                Artist = Artist.Jake_Murray
            });

            Cards.Add(new LotRCard()
            {
                Id = "418e1e02-52fe-4aef-b543-3875837dd38a",
                CardType = CardType.Treachery,
                Title = "Impenetrable Fog",
                Text = "When Revealed: The first player either places 3 progress tokens on To the Tower or reveals X additional cards from the encounter deck and adds them to the staging area. X is the number of players in the game.",
                FlavorText = "The air above was heavy with fog, and a reek lay on the land about them.\r\n-The Two Towers",
                EncounterSet = setName,
                Quantity = 2,
                EasyModeQuantity = 0,
                CardNumber = 157,
                Artist = Artist.Oleg_Saakyan,
                HasErrata = true
            });

            Cards.Add(new LotRCard()
            {
                Id = "46c7bfd7-96b7-4fe4-a110-3464ba6c0023",
                CardType = CardType.Treachery,
                Title = "Sleepless Malice",
                Keywords = new List<string> { "Doomed 2." },
                Text = "When Revealed: Each player must discard 3 random cards from his hand or place 1 progress token on To the Tower.",
                Shadow = "Shadow: Return attacking enemy to the staging area after this attack.",
                EncounterSet = setName,
                Quantity = 2,
                CardNumber = 158,
                Artist = Artist.Jim_Pavelec
            });

            Cards.Add(new LotRCard()
            {
                Id = "08af0240-fb38-4a33-a1f0-af07fd496b42",
                CardType = CardType.Treachery,
                Title = "Terror Drives Them",
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Place 1 progress token on To the Tower.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each progress token on To the Tower.",
                EncounterSet = setName,
                Quantity = 3,
                CardNumber = 159,
                Artist = Artist.Darek_Zabrocki
            });

            Cards.Add(new LotRCard()
            {
                Id = "8ac2d3ea-7e6d-4e9e-9cc5-70b65b24b835",
                CardType = CardType.Treachery,
                Title = "The Dead City Looms",
                Text = "When Revealed: Raise each players' threat by the number of progress tokens on To the Tower. If there are no progress tokens on To the Tower, The Dead City Looms gains surge.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack for each progress token on To the Tower.",
                EncounterSet = setName,
                Quantity = 2,
                EasyModeQuantity = 1,
                CardNumber = 160,
                Artist = Artist.Igor_Kieryluk
            });
        }
    }
}