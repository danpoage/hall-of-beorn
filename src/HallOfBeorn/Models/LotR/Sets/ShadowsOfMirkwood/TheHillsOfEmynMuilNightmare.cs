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

            addNightmareSetup(EncounterSet.TheHillsOfEmynMuilNightmare.Name)
                .WithText("You are playing in Nightmare mode.\r\nNo more than 1 progress can be placed on each location in the staging area each round.")
                .WithFlavor("Over them was a lane of pale-blue sky, around them the dark overshadowed River, and before them black, shutting out the sun, the hills of Emyn Muil, in which no opening could be seen.\r\n-The Fellowship of the Ring")
                .WithOppositeText(
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

Finally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
                .WithInfo(1, 1, Artist.Alyn_Spiller);
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
            addLocation("Brambles and Thorns", EncounterSet.TheHillsOfEmynMuilNightmare.Name, 3, 5)
                .WithTraits("Emyn Muil.")
                .WithText("Forced: After a character commits to the quest, deal 1 damage to that character if it has not been dealt damage by another copy of Brambles and Thorns this round.")
                .WithFlavor("..and on both shores there were steep slopes buried in deep brakes of thorn and sloe, tangled with brambles and creepers. -The Fellowship of the Ring")
                .WithVictoryPoints(3)
                .WithInfo(4, 3, Artist.Trudi_Castle);
            addLocation("Sarn Gebir Rapids", EncounterSet.TheHillsOfEmynMuilNightmare.Name, 5, 5)
                .WithTraits("Emyn Muil.")
                .WithText("While Sarn Gebir Rapids is the active location, the \"when revealed\" effects of Hazard cards cannot be canceled.")
                .WithFlavor("\"What a horrible place! Just let me get out of this boat, and I'll never wet my toes in a puddle again, let alone a river!\"\r\n-Sam Gamgee, The Fellowship of the Ring")
                .WithVictoryPoints(2)
                .WithInfo(5, 2, Artist.Jose_Vega);
            addTreachery("A Hurrying Darkness", EncounterSet.TheHillsOfEmynMuilNightmare.Name)
                .WithTraits("Hazard.")
                .WithText("When Revealed: Each player must either increase his threat by 5, or reveal an additional encounter card from the encounter deck and add it to the staging area.")
                .WithShadow("Shadow: Attacking enemy gets +X Attack. X is the Threat of the active location.")
                .WithInfo(6, 2, Artist.Michael_Rasmussen);
            addTreachery("Blast of Savage Wind", EncounterSet.TheHillsOfEmynMuilNightmare.Name)
                .WithTraits("Hazard.")
                .WithKeywords("Doomed 2.")
                .WithText("When Revealed: Remove all progress from each Emyn Muil location in play. Each Emyn Muil location gets +2 Threat until the end of the round.")
                .WithShadow("Shadow: Remove all progress from each Emyn Muil location in play.")
                .WithTemplate("<p class='main-text'>{keyword:Doomed 2.}</p><p class='main-text'><b>When Revealed:</b> Remove all progress from each {trait:Emyn Muil.@Emyn Muil} location in play. Each {trait:Emyn Muil.@Emyn Muil} location gets +2 {Threat} until the end of the round.</p>{shadow}<p class='shadow-text'><b>Shadow:</b> Remove all progress from each {trait:Emyn Muil.@Emyn Muil} location in play.</p>")
                .WithInfo(7, 3, Artist.Christina_Davis);
            addTreachery("Hazardous Terrain", EncounterSet.TheHillsOfEmynMuilNightmare.Name)
                .WithKeywords("Surge.", "Doomed 2.")
                .WithText("When Revealed: Shuffle all Hazard cards from the encounter discard pile back into the encounter deck.")
                .WithShadow("Shadow: Shuffle all Hazard cards from the encounter discard pile back into the encounter deck. Then, deal another shadow card for this attack.")
                .WithInfo(8, 2, Artist.Alexandre_Dainche);
            addTreachery("Retraced Steps", EncounterSet.TheHillsOfEmynMuilNightmare.Name)
                .WithKeywords("Surge.")
                .WithText("When Revealed: Discard a random Emyn Muil location from the victory display.")
                .WithFlavor("...they had climbed and laboured among the barren slopes and stones of Emyn Muil, sometimes retracing their steps because they could find no way forward...\r\n-The Two Towers")
                .WithInfo(9, 2, Artist.Jake_Murray);
        }
    }
}