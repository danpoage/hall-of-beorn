using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.CardSets
{
    public class LegolasPack : DigitalCardSet
    {
        public LegolasPack()
            : base("Legolas Pack", "LG")
        {
        }

        protected override void Initialize()
        {
            addHero("Legolas", DigitalSphere.Tactics, 9, 2, 1, 9, DigitalTrait.Silvan,
                "Ranged. Upkeep: Deal 1 damage",
                "<p><a href='/Digital/Search?Keyword=Ranged' target='_blank'><b>Ranged.</b></a> <b>Upkeep:</b></a> Deal 1 damage</p>",
                Artist.Magali_Villeneuve);
            addAlly("Silvan Tracker", false, DigitalSphere.Lore, 1, 1, 1, 1, 3, DigitalTrait.Silvan,
                "Arrival: Give a Character Stealth this round",
                "<p><a href='/Digital/Search?Keyword=Arrival' target='_blank'><b>Arrival:</b></a> Give a Character <a href='/Digital/Search?Keyword=Stealth' target='_blank'><b>Stealth</b></a>", 
                Artist.Magali_Villeneuve, DigitalRarity.Common);
            addAttachment("Bow of the Galadhrim", false, DigitalSphere.Tactics, 2, 1, AttachmentSlot.Weapon,
                "Gain +1 Attack and Ranged.", 
                "<p>Gain +1 ⚔️ and <a href='/Digital/Search?Keyword=Ranged' target='_blank'><b>Ranged.</b></a></p>",
                Artist.Unknown, DigitalRarity.Legendary);
            addEvent("Quicker than Sight", DigitalSphere.Spirit, 1, 1, DigitalTrait.Preparation,
                "Discard the next Attachment that Sauron plays",
                "<p>Discard the next <b>Attachment</b> that Sauron plays</p>",
                Artist.Unknown, DigitalRarity.Uncommon);
            addEvent("The Tree People", DigitalSphere.Leadership, 1, 1, null,
                "Return a Silvan Ally to your hand to play a random Silvan Ally",
                "<p>Return a <a href='/Digital/Search?CardType=Ally&Trait=Silvan' target='_blank'><b>Silvan</b> Ally</a> to your hand to play a random <b>Silvan</b> Ally</p>",
                Artist.Unknown, DigitalRarity.Rare);
        }
    }
}