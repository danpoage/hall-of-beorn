using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class TheDeadMarshesNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Dead Marshes Nightmare";
            Abbreviation = "TDMN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2007;

            Cards.Add(new LotRCard()
            {
                Title = "The Dead Marshes Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "B4BE3175-F193-464F-A6CE-79C9AA55DB44",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing Nightmare mode.

Players cannot reduce their threat.

Setup: Search the encounter deck for The Mere of Dead Faces, and add it to the stage area. Then, shuffle the encounter deck.

Forced: After ~Gollum is placed in the discard pile, shuffle him into the encounter deck.",
                FlavorText = "\"They lie in all the pools, pale faces, deep deep under the dark water.\" -Frodo, The Two Towers",
                OppositeText =
@"Begin with the standard quest deck and encounter deck for The Dead Marshes scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x A Wisp of Pale Sheen
1x Through the Mist
2x Great Marsh Worm
4x Fens and Mires
3x Eastern Crows
2x Pursued by ~Shadow
2x Treacherous Fog
1x Wolf Rider
2x Hill ~Troll
2x ~Goblin Sniper
2x Wargs
2x Despair
2x The Brown Lands
2x The East Bight

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The Dead Marshes encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Diego_Gisbert_Llorens
            });
            Cards.Add(new LotRCard()
            {
                Title = "The Mere of Dead Faces",
                ImageType = Models.ImageType.Jpg,
                IsUnique = true,
                Id = "1F4F1442-91FE-4DE6-9093-C127F238B7E9",
                CardType = CardType.Location,
                Threat = 0,
                IsVariableThreat = true,
                QuestPoints = null,
                Traits = new List<string> { "Dead Marshes." },
                Text = 
@"X is the number of resource tokens here. Cannot leave the staging area.

If Gollum is not in play, any resource tokens that would be placed on Gollum are placed here instead.

Forced: After Gollum enters play, place 2 resource tokens on Gollum, then move all resource tokens from The Mere of Dead Faces to Gollum.",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 1,
                Number = 2,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new LotRCard()
            {
                Title = "Stagnant Quagmire",
                ImageType = Models.ImageType.Jpg,
                Id = "58E63798-5F44-487B-9EF8-D4F08417E6B6",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Dead Marshes." },
                Text = 
@"While Stagnant Quagmire is in play, it adds its Escape value to all escape tests.
                
Escape: 2",
                Shadow = "Shadow: Perform an escape test, dealing 1 card the encounter deck. If this test is failed, discard the defending character.",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 3,
                Number = 3,
                Artist = Artist.Alexandr_Shaldin
            });
            Cards.Add(new LotRCard()
            {
                Title = "Things in the Pools",
                ImageType = ImageType.Jpg,
                Id = "AE951388-A055-431B-B801-3D50379BFB9D",
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 3,
                Attack = 4,
                Defense = 2,
                HitPoints = 8,
                Traits = new List<string> { "Undead." },
                Text = "Forced: After a character commit to an escape test, deal 1 damage to that character.",
                Shadow = "Shadow: Attacking enemy gets +1 Attack. (+2 Attack instead if attacking enemy is Undead.)",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 3,
                Number = 4,
                Artist = Artist.Gabriel_Verdon
            });
            Cards.Add(new LotRCard()
            {
                Title = "Marsh-wight",
                ImageType = ImageType.Jpg,
                Id = "640021E3-0FCE-4BC8-89B8-D822FE3238C3",
                CardType = CardType.Enemy,
                EngagementCost = 40,
                Threat = 4,
                Attack = 3,
                Defense = 2,
                HitPoints = 5,
                Traits = new List<string> { "Undead.", "Wight." },
                Text = "Forced: After Marsh-wight engages a player, that player makes an escape test, dealing 3 cards from the encounter deck. If this test is failed, place 2 resources on Gollum and Marsh-wigth makes an immediate attack.",
                FlavorText = "\"But all foul, all rotting, all dead. A fell light is in them.\" -Frodo, The Two Towers",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Yan_Wen_Tang
            });
            Cards.Add(new LotRCard()
            {
                Title = "Lost Soul of Lórien",
                ImageType = ImageType.Jpg,
                Id = "8441AF00-6E28-4540-81CD-0FAF945F5C12",
                CardType = CardType.Enemy,
                EngagementCost = 30,
                Threat = 1,
                Attack = 5,
                Defense = 2,
                HitPoints = 3,
                Traits = new List<string> { "Spirit.", "Undead." },
                Text = "Forced: After Lost Soul of Lórien is destroyed, attach it to a hero with 1 or more Willpower, if able. (Counts as a Condition attachment with the text: \"Limit 1 per hero. Attached hero's Willpower is reduced to 0.\")",
                FlavorText = "\"Many faces proud and fair, and weeds in their silver hair.\" -Frodo, The Two Towers",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 3,
                Number = 6,
                Artist = Artist.Yan_Wen_Tang
            });
            Cards.Add(new LotRCard()
            {
                Title = "Ill-fated Guard",
                ImageType = ImageType.Jpg,
                Id = "E8D8546C-53AB-4828-BEFD-10CB544C976F",
                CardType = CardType.Enemy,
                EngagementCost = 18,
                Threat = 2,
                Attack = 2,
                Defense = 3,
                HitPoints = 7,
                Traits = new List<string> { "Spirit.", "Undead." },
                Text = "While Ill-fated Guard is engaged with a player, that player cannot commit more than 1 character to each escape test.",
                Shadow = "Shadow: Discard all attachments from each character you control with 3 or more Willpower.",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Mariana_Vieira
            });
            Cards.Add(new LotRCard()
            {
                Title = "Candles of Corpses",
                ImageType = ImageType.Jpg,
                Id = "424E66B5-9A58-4AEE-A26E-8A305F26BA52",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Escape." },
                Text = 
@"When Revealed: Each player makes an escape test, dealing 1 card from the encounter deck. Each player who fails this test must either discard a hero from play or raise his threat by 5.

Escape: 5",
                FlavorText = "\"You should not look in when the candles are lit.\" -Gollum, The Two Towers",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 1,
                Number = 8,
                Artist = Artist.Adam_Lane
            });
            Cards.Add(new LotRCard()
            {
                Title = "Swarming Mosquitos",
                ImageType = ImageType.Jpg,
                Id = "C719042A-4C59-4866-B0D6-46620CDFE1B3",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Escape." },
                Text = 
@"When Revealed: The first player makes an escape test counting Defense intead of Willpower, dealing 2 cards from the encounter deck. If this test is failed, place 1 resource token on Gollum and deal 1 damage to each character in play.

Escape: 3",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 2,
                Number = 9,
                Artist = Artist.Owen_William_Weber
            });
            Cards.Add(new LotRCard()
            {
                Title = "Devilry of the Dark Land",
                ImageType = ImageType.Jpg,
                Id = "12702037-6E7C-4A8C-AC38-9EB25DB09553",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Corruption." },
                Text = 
@"When Revealed: Return the top X Undead enemies in the encounter discard pile to the staging area, where X is the number of players. If no enemies were returned to the staging area as a result of this effect, Devilry of the Dark Land gains surge.
                
Escape: 10",
                FlavorText = "'But that is an age and more ago,' said Sam. 'The Dead can't be really there!' -The Two Towers",
                EncounterSet = "The Dead Marshes Nightmare",
                Quantity = 1,
                Number = 10,
                Artist = Artist.Jose_Vega
            });
        }
    }
}