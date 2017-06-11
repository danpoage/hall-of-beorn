using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.CoreSet
{
    public class PassageThroughMirkwoodNightmare : EncounterSet
    {
        private const string setName = "Passage Through Mirkwood Nightmare";

        public PassageThroughMirkwoodNightmare()
            : base(setName, setName)
        {
            includes(
                PassageThroughMirkwoodNightmareSetup,
                UngoliantsSpawn,
                UngoliantsBrood,
                ForestFlies,
                SpidersOfMirkwoodEnemy,
                TheSpidersWeb,
                Backtrack,
                AbandonedCamp,
                GladeOfTheSpawn
            );
        }

        public static LotRCard PassageThroughMirkwoodNightmareSetup = NightmareSetup(setName)
            .WithText("You are playing Nightmare mode.\r\nForced: During setup, each player reveals 1 card from the encounter deck and adds it to the staging area.")
            .WithOppositeText("Begin with the standard quest deck and encounter deck for the Passage Through Mirkwood scenario found in the LOTR LCG core set.\r\nRemove the following cards, in the specified quantities, from the standard encounter deck:\r\nUngoliant's Spawn x1\r\nBlack ~Forest Bats x1\r\n~Forest ~Spider x3\r\nDol Guldur Orcs x3\r\nOld ~Forest ~Road x1\r\n~Forest ~Gate x2\r\nMountains of ~Mirkwood x3\r\nCaught in a Web x2\r\nThen, shuffle the encounter cards in this Nightmare Deck into the remainder of the standard Passage Through Mirkwood encounter deck.\r\nFinally, flip this setup card over and place it next to the quest deck. Its effect remains active throughout the game, which is now ready to begin.")
            .WithNightmareExclusion(EncounterSets.CoreSet.SpidersOfMirkwood.UngoliantsSpawn, 1)
            .WithNightmareExclusion(EncounterSets.CoreSet.PassageThroughMirkwood.BlackForestBats, 1)
            .WithNightmareExclusion(EncounterSets.CoreSet.PassageThroughMirkwood.ForestSpider, 3)
            .WithNightmareExclusion(EncounterSets.CoreSet.DolGuldurOrcs.DolGuldurOrcsEnemy, 3)
            .WithNightmareExclusion(EncounterSets.CoreSet.PassageThroughMirkwood.OldForestRoad, 1)
            .WithNightmareExclusion(EncounterSets.CoreSet.PassageThroughMirkwood.ForestGate, 2)
            .WithNightmareExclusion(EncounterSets.CoreSet.SpidersOfMirkwood.MountainsOfMirkwood, 3)
            .WithNightmareExclusion(EncounterSets.CoreSet.SpidersOfMirkwood.CaughtInAWeb, 2)
            .WithInfo(1, 1, Artist.Stacey_Diana_Clark);
        public static LotRCard UngoliantsSpawn = Enemy(setName, "Ungoliant's Spawn", 32, 3, 5, 3, 9)
            .WithTraits("Creature.", "Spider.")
            .WithText("When Revealed: Until the end of the phase, each character currently committed to the quest gets -2 Willpower and is discarded if its Willpower is 0.")
            .WithShadow("Shadow: Raise defending player's threat by 5. (Raise defending player's threat by 10 instead if undefended.)")
            .WithInfo(2, 1, Artist.Christopher_Burdett);
        public static LotRCard UngoliantsBrood = Enemy(setName, "Ungoliant's Brood", 31, 2, 3, 2, 5)
            .WithTraits("Creature.", "Spider.")
            .WithText("Forced: After you engage Ungoliant's Brood, your cards cannot ready for the remainder of the round.")
            .WithShadow("Shadow: If this attack is undefended, exhaust all characters you control.")
            .WithInfo(3, 3, Artist.S_C_Watson);
        public static LotRCard ForestFlies = Enemy(setName, "Forest Flies", 27, 4, 1, 0, 3)
            .WithTraits("Creature.", "Insect.")
            .WithText("Forced: After you engage Forest Flies, deal 1 damage to each exhausted character you control.")
            .WithShadow("Shadow: If attacking enemy is an Insect, deal it 2 additional shadow cards.")
            .WithInfo(4, 3, Artist.Rafal_Hrynkiewicz);
        public static LotRCard SpidersOfMirkwoodEnemy = Enemy(setName, "Spiders of Mirkwood", 18, 3, 2, 2, 4)
            .WithTraits("Spider.")
            .WithText("While it is engaged with you, Spiders of Mirkwood gets +1 for each exhausted character you control.")
            .WithShadow("Shadow: Choose and exhaust 1 character you control. If this attack is undefended, also deal that character 2 damage.")
            .WithInfo(5, 2, Artist.Andrew_Ryan);
        public static LotRCard TheSpidersWeb = Treachery(setName, "The Spider's Web")
            .WithText("When Revealed: The player with the highest threat exhausts all heroes he controls. Then, attach this card to one of that player's heroes. (Counts as a Condition attachment with the text, \"Each time attached hero readies, deal it 1 damage.\")")
            .WithInfo(6, 3, Artist.Rafal_Hrynkiewicz);
        public static LotRCard Backtrack = Treachery(setName, "Backtrack!")
            .WithKeywords("Surge.")
            .WithText("When Revealed: The topmost enemy or location card in the encounter discard pile is returned to the staging area.")
            .WithShadow("Shadow: Deal and resolve the topmost Shadow effect in the encounter discard pile for this attack.")
            .WithInfo(7, 2, Artist.Magali_Villeneuve);
        public static LotRCard AbandonedCamp = Location(setName, "Abandoned Camp", 2, 2)
            .WithTraits("Mirkwood.")
            .WithText("Immune to player card effects.\r\nForced: After Abandoned Camp leaves play, each player must deal 2 damage to each exhausted character he controls.")
            .WithShadow("Shadow: If this attack is undefended, discard all attachment cards players control.")
            .WithInfo(8, 3, Artist.Dana_Li);
        public static LotRCard GladeOfTheSpawn = Location(setName, "Glade of the Spawn", 4, 4)
            .WithTraits("Mirkwood.")
            .WithText("While Glade of the Spawn is the active location, it gains: \"Forced: After a Spider enemy enters play, each player must choose and exhaust 1 character he controls.\"")
            .WithFlavor("...black even for that forest, like a patch of midnight that had never been cleared away.\r\n-The Hobbit")
            .WithInfo(9, 2, Artist.S_C_Watson);
    }
}