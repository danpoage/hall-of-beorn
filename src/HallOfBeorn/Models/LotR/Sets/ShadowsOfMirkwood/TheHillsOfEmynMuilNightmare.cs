using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.ShadowsOfMirkwood
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

            Cards.Add(new LotRCard()
            {
                Title = "The Hills of Emyn Muil Nightmare",
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
                CardNumber = 1,
                Artist = Artist.Alyn_Spiller
            });
            addEnemy("Tunneling Nameless Thing", EncounterSet.TheHillsOfEmynMuilNightmare.Name, 50, 4, 6, 4, 10)
                .WithTraits("Nameless.")
                .WithText("Forced: After the players travel to a location, Tunneling Nameless Thing engages the first player.\r\n\r\nIf there is no active location, return Tunneling Nameless Thing to the staging area.")
                .WithTemplate("<p class='main-text'><b>Forced:</b> After the players travel to a location, {self} engages the first player.</p><p class='main-text'>If there is no active location, return {self} to the staging area.</p>")
                .WithInfo(2, 3, Artist.Sandara_Tang);
            addEnemy("Orc Interceptor", EncounterSet.TheHillsOfEmynMuilNightmare.Name, 39, 2, 2, 3, 5)
                .WithTraits("Mordor.", "Orc.")
                .WithText("Orc Interceptor gets +1 Threat and +1 Attack for each resource token on it.\r\nForced: After a location leaves play as an explored location, place a resource token on Orc Interceptor.")
                .WithTemplate("<p class='main-text'>{self} gets +1 {Threat} and +1 {Attack} for each resource token on it.</p><p class='main-text'><b>Forced:</b> After a location leaves play as an explored location, place a resource token on {self}.</p>")
                .WithInfo(3, 2, Artist.Mariusz_Gandzel);
            Cards.Add(new LotRCard()
            {
                Title = "Brambles and Thorns",
                
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
                CardNumber = 4,
                Artist = Artist.Trudi_Castle
            });
            Cards.Add(new LotRCard()
            {
                Title = "Sarn Gebir Rapids",
                
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
                CardNumber = 5,
                Artist = Artist.Jose_Vega
            });
            Cards.Add(new LotRCard()
            {
                Title = "A Hurrying Darkness",
                
                Id = "DAD2B933-76D5-4D3B-BC1B-8C46625647FA",
                CardType = CardType.Treachery,
                Traits = new List<string> { "Hazard." },
                Text = "When Revealed: Each player must either increase his threat by 5, or reveal an additional encounter card from the encounter deck and add it to the staging area.",
                Shadow = "Shadow: Attacking enemy gets +X Attack. X is the Threat of the active location.",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                CardNumber = 6,
                Artist = Artist.Michael_Rasmussen
            });
            addTreachery("Blast of Savage Wind", EncounterSet.TheHillsOfEmynMuilNightmare.Name)
                .WithTraits("Hazard.")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Remove all progress from each Emyn Muil location in play. Each Emyn Muil location gets +2 Threat until the end of the round.")
                .WithShadow("Shadow: Remove all progress from each Emyn Muil location in play.")
                .WithTemplate("<p class='main-text'>{keyword:Doomed 2.}</p><p class='main-text'><b>When Revealed:</b> Remove all progress from each {trait:Emyn Muil.@Emyn Muil} location in play. Each {trait:Emyn Muil.@Emyn Muil} location gets +2 {Threat} until the end of the round.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Remove all progress from each {trait:Emyn Muil.@Emyn Muil} location in play.</p>")
                .WithInfo(7, 3, Artist.Christina_Davis);
            Cards.Add(new LotRCard()
            {
                Title = "Hazardous Terrain",
                
                Id = "EDD8BE69-BF39-40FD-8064-AE0366EB188A",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge.", "Doomed 2." },
                Text = "When Revealed: Shuffle all Hazard cards from the encounter discard pile back into the encounter deck.",
                Shadow = "Shadow: Shuffle all Hazard cards from the encounter discard pile back into the encounter deck. Then, deal another shadow card for this attack.",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                CardNumber = 8,
                Artist = Artist.Alexandre_Dainche
            });
            Cards.Add(new LotRCard()
            {
                Title = "Retraced Steps",
                
                Id = "04528490-54F8-4414-9969-80F0DA6A907A",
                CardType = CardType.Treachery,
                Keywords = new List<string> { "Surge." },
                Text = "When Revealed: Discard a random Emyn Muil location from the victory display.",
                FlavorText = "...they had climbed and laboured among the barren slopes and stones of Emyn Muil, sometimes retracing their steps because they could find no way forward... -The Two Towers",
                EncounterSet = "The Hills of Emyn Muil Nightmare",
                Quantity = 2,
                CardNumber = 9,
                Artist = Artist.Jake_Murray
            });
        }
    }
}