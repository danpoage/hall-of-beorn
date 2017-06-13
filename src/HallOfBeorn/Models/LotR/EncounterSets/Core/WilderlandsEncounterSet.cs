using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.Core
{
    public class WilderlandsEncounterSet : CoreEncounterSet
    {
        private const string setName = "Wilderlands";

        public WilderlandsEncounterSet()
            : base(setName)
        {
            includes(
                WolfRider,
                HillTroll,
                GoblinSniper,
                MarshAdder,
                Wargs,
                Despair,
                TheBrownLands,
                TheEastBight
            );
        }

        public static LotRCard WolfRider = Enemy(setName, "Wolf Rider", 10, 1, 2, 0, 2)
            .WithTraits("Goblin.", "Orc.")
            .WithKeywords("Surge.")
            .WithShadow("Shadow: Wolf Rider attacks the defending player. That player may declare 1 character as a defender. Deal Wolf Rider its own Shadow card. After combat, return Wolf Rider to the top of the encounter deck.")
            .WithInfo(81, 1, Artist.Alexandru_Sabo);
        public static LotRCard HillTroll = Enemy(setName, "Hill Troll", 30, 1, 6, 3, 9)
            .WithTraits("Troll.")
            .WithText("Excess combat damage dealt by Hill Troll (damage that is dealt beyond the remaining hit points of the character damaged by its attack) must be assigned as an increase to your threat.")
            .WithFlavor("\"Mutton yesterday, mutton today, and blimey, if it don't look like mutton again tomorrow.\"\r\n-Troll, The Hobbit")
            .WithVictoryPoints(4)
            .WithEasyModeQuantity(1)
            .WithInfo(82, 2, Artist.Florian_Stitz);
        public static LotRCard GoblinSniper = Enemy(setName, "Goblin Sniper", 48, 2, 2, 0, 2)
            .WithTraits("Goblin.", "Orc.")
            .WithText("During the encounter phase, players cannot optionally engage Goblin Sniper if there are other enemies in the staging area.Forced: If Goblin Sniper is in the staging area at the end of the combat phase, each player deals 1 point of damage to 1 character he controls.")
            .WithInfo(83, 2, Artist.Alexandr_Shaldin);
        public static LotRCard MarshAdder = Enemy(setName, "Marsh Adder", 40, 3, 4, 1, 7)
            .WithTraits("Creature.")
            .WithText("Forced: Each time Marsh Adder attacks you, raise your threat by 1.")
            .WithFlavor("Under the boughs of Mirkwood there was deadly strife of Elves and Men and fell beasts.\r\n-The Fellowship of the Ring")
            .WithVictoryPoints(3)
            .WithEasyModeQuantity(0)
            .WithInfo(84, 1, Artist.Sandara_Tang);
        public static LotRCard Wargs = Enemy(setName, "Wargs", 20, 2, 3, 1, 3)
            .WithTraits("Creature.")
            .WithText("Forced: If Wargs is dealt a shadow card with no effect, return Wargs to the staging area after it attacks.")
            .WithShadow("Shadow: attacking enemy gets +1 Attack. (+2 Attack instead if this attack is undefended.)")
            .WithInfo(85, 2, Artist.Ryan_Barger);
        public static LotRCard Despair = Treachery(setName, "Despair")
            .WithText("When Revealed: Remove 4 progress tokens from the current quest card. (If there are fewer than 4 progress tokens on the quest, remove all progress tokens from that quest.)")
            .WithShadow("Shadow: Defending character does not count its Defense.")
            .WithEasyModeQuantity(0)
            .WithInfo(86, 2, Artist.Marc_Scheff);
        public static LotRCard TheBrownLands = Location(setName, "The Brown Lands", 5, 1)
            .WithTraits("Wasteland.")
            .WithText("Forced: After the players travel to The Brown Lands, place 1 progress token on it.")
            .WithFlavor("They had come to the Brown Lands that lay, vast and desolate, between Southern Mirkwood and the hills of the Emyn Muil. What pestilence or war or evil deed of the Enemy had so blasted all that region even Aragorn could not tell.\r\n-The Fellowship of the Ring")
            .WithInfo(87, 2, Artist.Ben_Zweifel);
        public static LotRCard TheEastBight = Location(setName, "The East Bight", 1, 6)
            .WithTraits("Wasteland.")
            .WithText("When faced with the option to travel, the players must travel to The East Bight if there is no active location.")
            .WithFlavor("\"...to the east the lands are waste, and full of Sauron's creatures...\"\r\n-Haldir, The Fellowship of the Ring")
            .WithInfo(88, 2, Artist.Santiago_Villa);
    }
}