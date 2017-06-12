using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.Core
{
    public class SpidersOfMirkwoodEncounterSet : CoreEncounterSet
    {
        private const string setName = "Spiders of Mirkwood";

        public SpidersOfMirkwoodEncounterSet()
            : base(setName)
        {
            includes(
                KingSpider,
                Hummerhorns,
                UngoliantsSpawn,
                GreatForestWeb,
                MountainsOfMirkwood,
                EyesOfTheForest,
                CaughtInAWeb
            );
        }

        public static LotRCard KingSpider = Enemy(setName, "King Spider", 20, 2, 3, 1, 3)
            .WithTraits("Creature.", "Spider.")
            .WithText("When Revealed: Each player must choose and exhaust 1 character he controls.")
            .WithShadow("Shadow: Defending player must choose and exhaust 1 character he controls. (2 characters instead if this attack is undefended.)")
            .WithInfo(74, 2, Artist.John_Wigley);
        public static LotRCard Hummerhorns = Enemy(setName, "Hummerhorns", 40, 1, 2, 0, 3)
            .WithTraits("Creature.", "Insect.")
            .WithText("Forced: After Hummerhorns engages you, deal 5 damage to a single hero you control.")
            .WithShadow("Shadow: Deal 1 damage to each character the defending player controls. (2 damage instead if this attack is undefended.)")
            .WithEasyModeQuantity(0)
            .WithInfo(75, 1, Artist.David_Lecossu);
        public static LotRCard UngoliantsSpawn = Enemy(setName, "Ungoliant's Spawn", 32, 3, 5, 2, 9)
            .WithTraits("Creature.", "Spider.")
            .WithText("When Revealed: Each character currently committed to a quest gets -1 Willpower until the end of the phase.")
            .WithShadow("Shadow: Raise defending player's threat by 4. (Raise defending player's threat by 8 instead if this attack is undefended.)")
            .WithInfo(76, 1, Artist.Andrew_Olson);
        public static LotRCard GreatForestWeb = Location(setName, "Great Forest Web", 2, 2)
            .WithTraits("Forest.")
            .WithText("Travel: Each player must exhaust 1 hero he controls to travel here.")
            .WithFlavor("As he drew nearer, he saw that it was made with spider-webs one behind and over and tangled with another.\r\n-The Hobbit")
            .WithInfo(77, 2, Artist.Jason_Ward);
        public static LotRCard MountainsOfMirkwood = Location(setName, "Mountains of Mirkwood", 2, 3)
            .WithTraits("Forest.", "Mountain.")
            .WithText("Travel: Reveal the top card of the encounter deck and add it to the staging area to travel here.Response: After Mountains of Mirkwood leaves play as an explored location, each player may search the top 5 cards of his deck for 1 card and add it to his hand. Shuffle the rest of the searched cards back into their owners' decks.")
            .WithInfo(78, 3, Artist.Ben_Zweifel);
        public static LotRCard EyesOfTheForest = Treachery(setName, "Eyes of the Forest")
            .WithText("When Revealed: Each player discards all event cards in his hand.")
            .WithFlavor("...he would see gleams in the darkness around them, and sometimes pairs of yellow or red or green eyes would stare at him from a little distance, and then slowly fade and disappear and slowly shine out again in another place.\r\n-The Hobbit")
            .WithEasyModeQuantity(0)
            .WithInfo(79, 1, Artist.Yoann_Boissonnet);
        public static LotRCard CaughtInAWeb = Treachery(setName, "Caught in a Web")
            .WithText("When Revealed: The player with the highest threat level attaches this card to one of his heroes. (Counts as a Condition attachment with the text: 'Attached hero does not ready during the refresh phase unless you pay 2 resources from that hero's pool.')")
            .WithEasyModeQuantity(0)
            .WithInfo(80, 2, Artist.Daryl_Mandryk);
    }
}