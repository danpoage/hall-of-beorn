using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.EncounterSets.CoreSet
{
    public class DolGuldurOrcs : CoreSetEncounterSet
    {
        private const string setName = "Dol Guldur Orcs";

        public DolGuldurOrcs()
            : base(setName)
        {
            includes(
                DolGuldurOrcsEnemy,
                ChieftanUfthak,
                DolGuldurBeastmaster,
                DrivenByShadow,
                TheNecromancersReach,
                NecromancersPass,
                EnchantedStream
            );
        }

        public static LotRCard DolGuldurOrcsEnemy = Enemy(setName, "Dol Guldur Orcs", 10, 2, 2, 0, 3)
            .WithSuffix("Enemy")
            .WithTraits("Dol Guldur.", "Orc.")
            .WithText("When Revealed: The first player chooses 1 character currently committed to a quest. Deal 2 damage to that character.")
            .WithSuffix("Shadow: attacking enemy gets +1 Attack. (+3 Attack instead if this attack is undefended.)")
            .WithInfo(89, 3, Artist.Anna_Christenson);
        public static LotRCard ChieftanUfthak = Enemy(setName, "Chieftan Ufthak", 35, 2, 3, 3, 6)
            .WithTraits("Dol Guldur.", "Orc.")
            .WithText("Chieftain Ufthak get +2 Attack for each resource token on him.\r\nForced: After Chieftain Ufthak attacks, place 1 resource token on him.")
            .WithEasyModeQuantity(0)
            .WithInfo(90, 1, Artist.Mathias_Kollros);
        public static LotRCard DolGuldurBeastmaster = Enemy(setName, "Dol Guldur Beastmaster", 35, 2, 3, 1, 5)
            .WithTraits("Dol Guldur.", "Orc.")
            .WithText("Forced: When Dol Guldur Beastmaster attacks, deal it 1 additional shadow card.")
            .WithErrata()
            .WithEasyModeQuantity(1)
            .WithInfo(91, 2, Artist.David_Lecossu);
        public static LotRCard DrivenByShadow = Treachery(setName, "Driven by Shadow")
            .WithText("When Revealed: Each enemy and each location currently in the staging area gets +1 Threat until the end of the phase. If there are no cards in the staging area, Driven by Shadow gains surge.")
            .WithShadow("Shadow: Choose and discard 1 attachment from the defending character. (If this attack is undefended, discard all attachments you control.)")
            .WithInfo(92, 1, Artist.Alexandru_Sabo);
        public static LotRCard TheNecromancersReach = Treachery(setName, "The Necromancer's Reach")
            .WithText("When Revealed: Deal 1 damage to each exhausted character.")
            .WithFlavor("There was an eye in the Dark Tower that did not sleep. He knew that it had become aware of his gaze. A fierce eager will was there.\r\n-The Fellowship of the Ring")
            .WithEasyModeQuantity(1)
            .WithInfo(93, 3, Artist.Anna_Christenson);
        public static LotRCard NecromancersPass = Location(setName, "Necromancer's Pass", 3, 2)
            .WithTraits("Stronghold.", "Dol Guldur.")
            .WithText("Travel: The first player must discard 2 cards from his hand at random to travel here.")
            .WithFlavor("\"It is clad in a forest of dark fir, where the trees strive one against another and their branches rot and wither. In the midst upon a stony height stands Dol Guldur, where long the hidden Enemy had his dwelling.\"\r\n-Haldir, The Fellowship of the Ring")
            .WithInfo(94, 2, Artist.Daryl_Mandryk);
        public static LotRCard EnchantedStream = Location(setName, "Enchanted Stream", 2, 2)
            .WithTraits("Forest.")
            .WithText("While Enchanted Stream is the active location, players cannot draw cards.")
            .WithFlavor("\"There is one stream, I know, black and strong which crosses the path. That you should neither drink of, nor bathe in; for I have heard that it carries enchantment and a great drowsiness and forgetfulness.\"\r\n-Beorn, The Hobbit")
            .WithInfo(95, 2, Artist.Ben_Zweifel);
    }
}