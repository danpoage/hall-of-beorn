using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
{
    public class AmongTheOutlaws: CardSet
    {
        private const string setName = "Among the Outlaws";

        protected override void Initialize()
        {
            Name = "Among the Outlaws";
            Abbreviation = "AtO";
            Number = 9003;
            SetType = Models.SetType.CUSTOM;
            Cycle = "Doom Mastered";

            Cards.Add(LotRCard.Scenario("Among the Outlaws", 2, setName, "Doom Mastered")
                .WithText("Dilemma Deck\r\nThe 9 objective cards with the Dilemma trait are set aside into a separate deck at the start of the game and shuffled. When players quest unsuccessfully, the top card of the dilemma deck is revealed. Each dilemma card gives the player two options. Carrying out the first option helps the Gaurwaith while carrying out the second option, which adds the card to the victory display, helps the woodmen.\r\nCorruption and Objective Allies\r\nObjective allies are immune to corruption and corruption cannot be placed on objective allies for any reason.")
                .WithOppositeText("Ransom\r\nWhen a character with the Ransom keyword enters play, the player who controls it may discard a number of resources from the resource pools of heroes they control equal to the Ransom value. If they choose not to satisfy this requirement, then that player card loses the \"ally\" card type and gains the \"enemy\" card type, immediately engaging the player who played it. Its threat is equal to its willpower and its engagement cost is 0. If this enemy is defeated, remove all damage from it and return it its owner's control as an ally.\r\nRelentless\r\nAn enemy with the Relentless keyword cannot have its attack canceled or be prevented from attacking by player card effects. It can still be targeted by other effects which do no specifically prevent attacks.")
                .WithInfo(0, 1, Artist.Arman_Akopian));

            Cards.Add(LotRCard.Enemy("Androg", "", setName, 0, 1, 3, 2, 5)
                .WithSlugIncludesType()
                .WithUnique()
                .WithTraits("Gaurwaith.")
                .WithKeywords("Relentless.")
                .WithText("Androg gets +1 Attack for each hero you control with at least 1 Corruption.")
                .WithFlavor("\"The hardest of heart was one named Androg...\"\r\n-The Children of Húrin")
                .WithVictoryPoints(1)
                .WithInfo(232, 1, Artist.Denman_Rooke));

            Cards.Add(LotRCard.Hero("Bór the Faithful", "", Sphere.Spirit, 6, 2, 1, 1, 3)
                .WithTraits("Easterling.")
                .WithText("Action: Discard 1 Corruption for Bór the Faithful to ready him. He gets +2 Attack and +1 Willpower until the end of the round. (Limit once per round.)")
                .WithFlavor("...and they followed Maedhros and Maglor, and cheated the hope of Morgoth, and were faithful.\r\n-The Silmarillion")
                .WithInfo(253, 1, Artist.Chris_Quilliams));
            addCard(LotRCard.Ally("Brethil Hound", Sphere.Spirit, 3, 1, 2, 1, 2)
                .WithTraits("Hound.", "House of Haleth.")
                .WithText("Response: After Brethil Hound participates in an attack that destroys an enemy, choose a player. That player reduces his threat by 1. (Limit once per phase.)")
                .WithInfo(254, 3, Artist.K_LeCrone));
            Cards.Add(LotRCard.Ally("Algund", Sphere.Mastery, 0, 2, 1, 1, 3)
                .WithUnique()
                .WithTraits("Gaurwaith.")
                .WithKeywords("Ransom 3.")
                .WithText("Response: When the discard pile is shuffled back into the encounter deck, deal X Corruption to Algund to choose X cards in the discard pile. These cards are not shuffled back into the encounter deck.")
                .WithFlavor("...and others also came from that land: old Algund, the oldest of the fellowship, who had fled from the Nirnaeth...\r\n-The Children of Húrin")
                .WithInfo(255, 3, Artist.J_Lantta));
            Cards.Add(LotRCard.Ally("Fostered Son", Sphere.Leadership, 1, 1, 0, 0, 1)
                .WithTraits("Edain.", "Noble.")
                .WithText("Action: Discard Fostered Son to reduce the cost of the next unique Edain character you play this phase by 2.")
                .WithFlavor("Thus it was that the sons of Galdor were fostered in Brethil by Haldir their uncle, according to the custom of Men in that time...\r\n-The Silmarillion")
                .WithInfo(256, 3, Artist.Andrew_Ryan));
            Cards.Add(LotRCard.Ally("Elder of the Realm", Sphere.Lore, 3, 2, 1, 1, 2)
                .WithTraits("Teleri.")
                .WithText("Response: After a treachery is revealed, discard a card from hand (spend 1 Lore to discard the top card of your deck instead). If the first letter of the treachery card's title matches that of the discarded card, cancel the \"when revealed\" effects of the revealed card. (Limit once per game.)")
                .WithInfo(256, 3, Artist.Unknown));
            Cards.Add(LotRCard.Ally("Wolf-man",  Sphere.Mastery, 0, 0, 3, 1, 2)
                .WithTraits("Gaurwaith.")
                .WithKeywords("Ransom 4.")
                .WithText("Action: Exhaust Wolf-man to immediately declare him as an attacker (and resolve his attack) against an engaged enemy with one hit point remaining.")
                .WithInfo(257, 3, Artist.Lane));
            Cards.Add(LotRCard.Attachment("Neithan", "", Sphere.Mastery, 1)
                .WithUnique()
                .WithTraits("Name.")
                .WithText("Attach to Túrin Turambar. Limit 1 Name in play.\r\nResource on Neithan can be discard to satisfy the ransom keyword.\r\nResponse: When an enemy with the ransom keyword is defeated, add 2 resources to Neithan.")
                .WithInfo(258, 3, Artist.Thomas_Scholes));
            Cards.Add(LotRCard.Attachment("Forge of Belegost", "", Sphere.Lore, 1)
                .WithUnique()
                .WithTraits("Item.", "Forge.")
                .WithText("Attach to a Dwarf character.\r\nAction: Exhaust Forge of Belegost and attached character to heal X damage on a character. X is the number of Item attachments on that character.")
                .WithFlavor("...yet in the tempering of steel alone of all crafts the Dwarves were never outmatched even by the Noldor...\r\n-The Silmarillion")
                .WithInfo(259, 3, Artist.Unknown));
            Cards.Add(LotRCard.Attachment("Angrist", "", Sphere.Leadership, 1)
                .WithUnique()
                .WithTraits("Item.", "Weapon.")
                .WithText("Attach to a hero with the House of House of Bëor trait. Restricted.\r\nAttached hero gets +1 Attack.\r\nAction: Exhaust Angrist and the attached hero to choose a facedown enemy. Turn that enemy faceup and deal 4 damage to it.")
                .WithFlavor("...and from the iron claws that held it he cut a Silmaril.\r\n-The Silmarillion")
                .WithInfo(260, 3, Artist.Vadim));
            Cards.Add(LotRCard.Event("Song of Parting", "", Sphere.Leadership, 1)
                .WithTraits("Song.")
                .WithText("Response: After an encounter card with at least 3 Threat is revealed from the encounter deck, choose and ready a character. That character gets +2 Willpower, +2 Attack, and +2 Defense until the end of the round.")
                .WithFlavor("...for he believed that he must now say farewell to both love and light.\r\n-The Silmarillion")
                .WithInfo(261, 3, Artist.Kip_Rasmussen));
            Cards.Add(LotRCard.Event("None Shall Break", "", Sphere.Mastery, 2)
                .WithText("Action: Ready each character with an Oath attached. (Lower the cost of None Shall Break by 2 if each character that readies takes 1 Corruption.)")
                .WithFlavor("For so sworn, good or evil, an oath may not be broken, and it shall pursue oathkeeper and oathbreaker to the world's end.\r\n-The Silmarillion")
                .WithInfo(262, 3, Artist.Jenny_Dolfen));
        }
    }
}