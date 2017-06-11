using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.CoreSet
{
    public class PassageThroughMirkwood : CoreSetEncounterSet
    {
        private const string setName = "Passage Through Mirkwood";

        public PassageThroughMirkwood()
            : base(setName)
        {
            includes(
                ForestSpider,
                EastBightPatrol,
                BlackForestBats,
                OldForestRoad,
                ForestGate,
                FliesAndSpiders1,
                AForkInTheRoad2,
                AChosenPath_DontLeaveThePath3,
                AChosenPath_BeornsPath3
             );
            
        }

        public static LotRCard ForestSpider = Enemy(setName, "Forest Spider", 25, 2, 2, 1, 4)
                .WithTraits("Creature.", "Spider.")
                .WithText("Forced: After Forest Spider engages a player, it gets +1 Attack until the end of the round.")
                .WithShadow("Shadow: Defending player must choose and discard 1 attachment he controls.")
                .WithInfo(96, 4, Artist.Marco_Caradonna);
        public static LotRCard EastBightPatrol = Enemy(setName, "East Bight Patrol", 5, 3, 3, 1, 2)
                .WithTraits("Goblin.", "Orc.")
                .WithShadow("Shadow: attacking enemy gets +1 Attack. (If this attack is undefended, also raise your threat by 3.)")
                .WithInfo(97, 1, Artist.Nikolay_Stoyanov);
        public static LotRCard BlackForestBats = Enemy(setName, "Black Forest Bats", 15, 1, 1, 0, 2)
                .WithTraits("Creature.")
                .WithText("When Revealed: Each player must choose 1 character currently committed to a quest, and remove that character from the quest. (The chosen character does not ready.)")
                .WithFlavor("They could not stand that, nor the huge bats, black as a top-hat, either...\r\n-The Hobbit")
                .WithInfo(98, 1, Artist.David_Lecossu);
        public static LotRCard OldForestRoad = Location(setName, "Old Forest Road", 1, 3)
                .WithTraits("Forest.")
                .WithText("Response: After you travel to Old Forest Road, the first player may choose and ready 1 character he controls.")
                .WithFlavor("...Beorn had warned them that that way was now often used by the goblins, while the forest-road itself, he had heard, was overgrown and disused on the eastern end and led to impassable marshes where the path had long been lost.\r\n-The Hobbit")
                .WithInfo(99, 2, Artist.Ben_Zweifel);
        public static LotRCard ForestGate = Location(setName, "Forest Gate", 2, 4)
                .WithTraits("Forest.")
                .WithText("Response: After you travel to Forest Gate, the first player may draw 2 cards.")
                .WithFlavor("The path itself was narrow and wound in and out among the trunks. Soon the light in the gate was like a little bright hole far behind, and the quiet was so deep that their feet seemed to thump along while the trees leaned over them and listened.\r\n-The Hobbit")
                .WithInfo(100, 2, Artist.Ben_Zweifel);
        public static LotRCard FliesAndSpiders1 = Quest(setName, "Flies and Spiders", 1, 'A', 8)
                .WithText("Setup: Search the encounter deck for 1 copy of the ~Forest ~Spider and 1 copy of the Old ~Forest ~Road, and add them to the staging area. Then, shuffle the encounter deck.")
                .WithFlavor("You are traveling through Mirkwood forest, carrying an urgent message from King Thanduil to the Lady Galadriel of Lorien. As you move along the dark trail, the spiders gather around you...")
                .WithOppositeFlavor("The nastiest things they saw were the cobwebs; dark dense cobwebs, with threads extradionairly thick, often stretched from tree to tree, or tangled in the lower branches on either side of them. There were none stretched across the path, but whether because some magic kept it clear, or for what other reasons they could not guess.\r\n-The Hobbit")
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood)
                .WithInfo(119, 1, Artist.Ben_Zweifel);
        public static LotRCard AForkInTheRoad2 = Quest(setName, "A Fork in the Road", 2, 'A', 2)
                .WithFlavor("As you move through Mirkwood, hounded by spiders, the forest path forks before you...")
                .WithOppositeText("Forced: When you defeat this stage, proceed to one of the 2 \"A Chosen ~Path\" stages, at random.")
                .WithOppositeFlavor("Unsure of what lies ahead but spurred by the urgency of your message, you choose a path and proceed...")
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood)
                .WithInfo(120, 1, Artist.Ben_Zweifel);
        public static LotRCard AChosenPath_DontLeaveThePath3 = Quest(setName, "A Chosen Path", 3, 'A', 0)
                .WithSuffix("Don't Leave the Path")
                .WithFlavor("The trail winds into one of the darkest, most tangled parts of the forest...\r\n\r\nYou sense that foul, dark presence is hunting you, and you move quickly in an attempt to avoid its evil.")
                .WithOppositeText("When Revealed: Each player must search the encounter deck and discard pile for 1 Spider card of his choice, and add it to the staging area.\r\nThe players must find and defeat Ungoliant's Spawn to win this game.")
                .WithOppositeFlavor("The shadows grow darker, and you realize that a foul presence is aiming to draw you from the path. You must defeat it to pass this way.")
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood)
                .WithInfo(121, 1, Artist.Yoann_Boissonnet).WithBackArtist(Artist.Ben_Zweifel);
        public static LotRCard AChosenPath_BeornsPath3 = Quest(setName, "A Chosen Path", 3, 'A', 10)
                .WithSuffix("Beorn's Path")
                .WithFlavor("The trail winds into one of the darkest, most tangled parts of the forest...\r\n\r\nYou sense that foul, dark presence is hunting you, and you move quickly in an attempt to avoid its evil.")
                .WithOppositeText("Players cannot defeat this stage while Ungoliant's Spawn is in play. If players defeat this stage, they have won the game.")
                .WithOppositeFlavor("You attempt to follow a secret, hidden trail to avoid the enemy...")
                .WithIncludedEncounterSets(EncounterSet.DolGuldurOrcs, EncounterSet.SpidersOfMirkwood)
                .WithInfo(122, 2, Artist.Yoann_Boissonnet).WithBackArtist(Artist.David_Lecossu);
    }
}