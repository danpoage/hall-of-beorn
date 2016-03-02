using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class AmongTheOutlaws: CardSet
    {
        protected override void Initialize()
        {
            Name = "Among the Outlaws";
            Abbreviation = "AtO";
            Number = 9003;
            SetType = Models.SetType.CUSTOM;
            Cycle = "Doom Mastered";

            Cards.Add(Card.Hero("Bór the Faithful", "", Sphere.Spirit, 6, 2, 1, 1, 3)
                .WithNormalizedTitle("Bor the Faithful")
                .WithTraits("Easterling.")
                .WithText("Action: Discard 1 Corruption for Bór the Faithful to ready him. He gets +2 Attack and +1 Willpower until the end of the round. (Limit once per round.)")
                .WithFlavor("...and they followed Maedhros and Maglor, and cheated the hope of Morgoth, and were faithful.\r\n-The Silmarillion")
                .WithInfo(253, 1, Artist.Chris_Quilliams));
            Cards.Add(Card.Ally("Brethil Hound", "", Sphere.Spirit, 3, 1, 2, 1, 2)
                .WithGeneric()
                .WithTraits("Hound.", "House of Haleth.")
                .WithText("Response: After Brethil Hound participates in an attack that destroys an enemy, choose a player. That player reduces his threat by 1. (Limit once per phase.)")
                .WithInfo(254, 3, Artist.K_LeCrone));
            Cards.Add(Card.Ally("Algund", "", Sphere.Mastery, 0, 2, 1, 1, 3)
                .WithUnique()
                .WithTraits("Gaurwaith.")
                .WithKeywords("Ransom 3.")
                .WithText("Response: When the discard pile is shuffled back into the encounter deck, deal X Corruption to Algund to choose X cards in the discard pile. These cards are not shuffled back into the encounter deck.")
                .WithFlavor("...and others also came from that land: old Algund, the oldest of the fellowship, who had fled from the Nirnaeth...\r\n-The Children of Húrin")
                .WithInfo(255, 3, Artist.J_Lantta));
            Cards.Add(Card.Ally("Fostered Son", "", Sphere.Leadership, 1, 1, 0, 0, 1)
                .WithGeneric()
                .WithTraits("Edain.", "Noble.")
                .WithText("Action: Discard Fostered Son to reduce the cost of the next unique Edain character you play this phase by 2.")
                .WithFlavor("Thus it was that the sons of Galdor were fostered in Brethil by Haldir their uncle, according to the custom of Men in that time...\r\n-The Silmarillion")
                .WithInfo(256, 3, Artist.Andrew_Ryan));
            Cards.Add(Card.Ally("Elder of the Realm", "", Sphere.Lore, 3, 2, 1, 1, 2)
                .WithGeneric()
                .WithTraits("Teleri.")
                .WithText("Response: After a treachery is revealed, discard a card from hand (spend 1 Lore to discard the top card of your deck instead). If the first letter of the treachery card's title matches that of the discarded card, cancel the \"when revealed\" effects of the revealed card. (Limit once per game.)")
                .WithInfo(256, 3, Artist.Unknown));
            Cards.Add(Card.Ally("Wolf-man", "", Sphere.Mastery, 0, 0, 3, 1, 2)
                .WithGeneric()
                .WithTraits("Gaurwaith.")
                .WithKeywords("Ransom 4.")
                .WithText("Action: Exhaust Wolf-man to immediately declare him as an attacker (and resolve his attack) against an engaged enemy with one hit point remaining.")
                .WithInfo(257, 3, Artist.Lane));
            Cards.Add(Card.Attachment("Neithan", "", Sphere.Mastery, 1)
                .WithUnique()
                .WithTraits("Name.")
                .WithText("Attach to Túrin Turambar. Limit 1 Name in play.\r\nResource on Neithan can be discard to satisfy the ransom keyword.\r\nResponse: When an enemy with the ransom keyword is defeated, add 2 resources to Neithan.")
                .WithInfo(258, 3, Artist.Thomas_Scholes));
            Cards.Add(Card.Attachment("Forge of Belegost", "", Sphere.Lore, 1)
                .WithUnique()
                .WithTraits("Item.", "Forge.")
                .WithText("Attach to a Dwarf character.\r\nAction: Exhaust Forge of Belegost and attached character to heal X damage on a character. X is the number of Item attachments on that character.")
                .WithFlavor("...yet in the tempering of steel alone of all crafts the Dwarves were never outmatched even by the Noldor...\r\n-The Silmarillion")
                .WithInfo(259, 3, Artist.Unknown));
            Cards.Add(Card.Attachment("Angrist", "", Sphere.Leadership, 1)
                .WithUnique()
                .WithTraits("Item.", "Weapon.")
                .WithText("Attach to a hero with the House of House of Bëor trait. Restricted.\r\nAttached hero gets +1 Attack.\r\nAction: Exhaust Angrist and the attached hero to choose a facedown enemy. Turn that enemy faceup and deal 4 damage to it.")
                .WithFlavor("...and from the iron claws that held it he cut a Silmaril.\r\n-The Silmarillion")
                .WithInfo(260, 3, Artist.Vadim));
            Cards.Add(Card.Event("Song of Parting", "", Sphere.Leadership, 1)
                .WithTraits("Song.")
                .WithText("Response: After an encounter card with at least 3 Threat is revealed from the encounter deck, choose and ready a character. That character gets +2 Willpower, +2 Attack, and +2 Defense until the end of the round.")
                .WithFlavor("...for he believed that he must now say farewell to both love and light.\r\n-The Silmarillion")
                .WithInfo(261, 3, Artist.Kip_Rasmussen));
            Cards.Add(Card.Event("None Shall Break", "", Sphere.Mastery, 2)
                .WithText("Action: Ready each character with an Oath attached. (Lower the cost of None Shall Break by 2 if each character that readies takes 1 Corruption.)")
                .WithFlavor("For so sworn, good or evil, an oath may not be broken, and it shall pursue oathkeeper and oathbreaker to the world's end.\r\n-The Silmarillion")
                .WithInfo(262, 3, Artist.Jenny_Dolfen));
        }
    }
}