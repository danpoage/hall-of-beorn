using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheHillsOfEmynMuilNightmare : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Hills of Emyn Muil Nightmare";
            Abbreviation = "THoEMN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2006;

            Cards.Add(new Card()
            {
                Title = "The Hills of Emyn Muil Nightmare",
                HasSecondImage = true,
                ImageType = Models.ImageType.Jpg,
                Id = "EB6E672D-7D48-4A52-A6C8-69ACDFE99AB3",
                CardType = CardType.Nightmare_Setup,
                Text =
@"You are playing in Nightmare mode.

No more than 1 progress can be placed on each location in the staging area each round.",
                FlavorText = "Over them was a lane of pale-blue sky, around them the dark overshadowed River, and before them black, shutting out the sun, the hills of Emyn Muil, in which no opening could be seen. -The Fellowship of the Ring",

                OppositeText =
@"Begin with the standard quest deck and encounter deck for The ~Hills of Emyn Muil scenario.

Remove the following cards, in the specified quantities, from the standard encounter deck:

1x The East Wall of ~Rohan
1x The North ~Stair
2x The Shores of Nen Hithoel
4x The ~Highlands
2x Slick Footing
2x Impassable Chasm
2x Dol Guldur Orcs
1x Chieftan Ufthak
2x Dol Guldur Beastmaster
2x The Necromancer's Reach
2x Necromancer's Pass
2x Enchanted ~Stream
3x Evil Storm
2x Pursued by ~Shadow

Then, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard The ~Hills of Emyn Muil encounter deck.

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.",

                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 1,
                Number = 1,
                Artist = Artist.Alyn_Spiller
            });
            Cards.Add(new Card()
            {
                Title = "Tunneling Nameless Thing",
                ImageType = ImageType.Jpg,
                Id = "B7A0F4CE-99FE-4DC8-8406-6ED68C1C1A0E",
                CardType = CardType.Enemy,
                EngagementCost = 50,
                Threat = 4,
                Attack = 6,
                Defense = 4,
                HitPoints = 10,
                Traits = new List<string> { "Nameless." },
                Text = "Forced: After the players travel to a location, Tunneling Nameless Thing engages the first player.\r\n\r\nIf there is no active location, return Tunneling Nameless Thing to the staging area.",
                Shadow = "Shadow:",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 3,
                Number = 2,
                Artist = Artist.Sandara_Tang
            });
            Cards.Add(new Card()
            {
                Title = "Orc Interceptor",
                ImageType = ImageType.Jpg,
                Id = "EF5B610D-F818-4430-8448-C91480D86BEA",
                CardType = CardType.Enemy,
                EngagementCost = 39,
                Threat = 2,
                Attack = 2,
                Defense = 3,
                HitPoints = 5,
                Traits = new List<string> { "Mordor.", "Orc." },
                Text = "Orc Interceptor gets +1 Threat and +1 Attack for each resource token on it.\r\n\r\nForced: After a location leaves play as an explored location, place a resource token on Orc Interceptor.",
                Shadow = "Shadow:",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                Number = 3,
                Artist = Artist.Mariusz_Gandzel
            });
            Cards.Add(new Card()
            {
                Title = "Brambles and Thorns",
                ImageType = ImageType.Jpg,
                Id = "123704FC-D51C-41EE-9F1C-B5E54FB021A2",
                CardType = CardType.Location,
                Threat = 3,
                QuestPoints = 5,
                Traits = new List<string> { "Emyn Muil." },
                Text = "Forced: After a character commits to the quest, deal 1 damage to that character if it has not been dealt damage by another copy of Brambles and Thorns this round.",
                FlavorText = "..and on both shores there were steep slopes buried in deep brakes of thorn and sloe, tangled with brambles and creepers. -The Fellowship of the Ring",
                VictoryPoints = 3,
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 3,
                Number = 4,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new Card()
            {
                Title = "Sarn Gebir Rapids",
                ImageType = ImageType.Jpg,
                Id = "F27C0523-F014-423D-AD41-BECF34388F34",
                CardType = CardType.Location,
                Threat = 5,
                QuestPoints = 5,
                Traits = new List<string> { "Emyn Muil." },
                Text = "While Sarn Gebir Rapids is the active location, the \"when revealed\" effects of Hazard cards cannot be canceled.",
                FlavorText = "\"What a horrible place! Just let me get out of this boat, and I'll never wet my toes in a puddle again, let alone a river!\" -Sam Gamgee, The Fellowship of the Ring",
                VictoryPoints = 2,
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                Number = 5,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new Card()
            {
                Title = "A Hurrying Darkness",
                ImageType = ImageType.Jpg,
                Id = "DAD2B933-76D5-4D3B-BC1B-8C46625647FA",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Hazard." },
                Text = "When Revealed: Each player must either increase his threat by 5, or reveal an additional encounter card from the encounter deck and add it to the staging area.",
                Shadow = "Shadow: Attacking enemy gets +X Attack. X is the Threat of the active location.",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                Number = 6,
                Artist = Artist.Michael_Rasmussen
            });
            Cards.Add(new Card()
            {
                Title = "Blast of Savage Wind",
                ImageType = ImageType.Jpg,
                Id = "12FB8290-3BEC-44E4-A3D0-62B5C55FCBE1",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Hazard." },
                Keywords = new List<string> { "Doomed 2." },
                Text = "When Revealed: Remove all progress from each Emyn Muil location in play. Each Emyn Muil location gets +2 Threat until the end of the round.",
                Shadow = "Shadow: Remove all progress from each Emyn Muil location in play.",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 3,
                Number = 7,
                Artist = Artist.Christina_Davis
            });
            Cards.Add(new Card()
            {
                Title = "Hazardous Terrain",
                ImageType = ImageType.Jpg,
                Id = "EDD8BE69-BF39-40FD-8064-AE0366EB188A",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge.", "Doomed 2." },
                Text = "When Revealed: Shuffle all Hazard cards from the encounter discard pile back into the encounter deck.",
                Shadow = "Shadow: Shuffle all Hazard cards from the encounter discard pile back into the encounter deck. Then, deal another shadow card for this attack.",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                Number = 8,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new Card()
            {
                Title = "Retraced Steps",
                ImageType = ImageType.Jpg,
                Id = "04528490-54F8-4414-9969-80F0DA6A907A",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Discard a random Emyn Muil location from the victory display.",
                FlavorText = "...they had climbed and laboured among the barren slopes and stones of Emyn Muil, sometimes retracing their steps because they could find no way forward... -The Two Towers",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                Number = 9,
                Artist = Artist.Jake_Murray
            });
        }
    }
}