using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.CardSets
{
    public class FaramirPack : DigitalCardSet
    {
        public FaramirPack()
            : base("Faramir Pack", "FR")
        {
        }

        protected override void Initialize()
        {
            addHero("Faramir", DigitalSphere.Lore, 11, 2, 1, 10, DigitalTrait.Gondor,
                "Ranged. Vanquish: Draw 1 card",
                null,
                Artist.Magali_Villeneuve);
            addAlly("Mablung", true, DigitalSphere.Lore, 2, 3, 2, 1, 5, DigitalTrait.Gondor,
                "Ranged. Arrival: Exhaust a non unique Enemy",
                null, 
                Artist.Sebastian_Giacobino, DigitalRarity.Legendary);
            addAttachment("Ranger Spear", false, DigitalSphere.Tactics, 1, 3, AttachmentSlot.Weapon,
                "Gain +1 Attack and Block.",
                null,
                Artist.Unknown, DigitalRarity.Uncommon);
            addAttachment("Gondorian Shield", false, DigitalSphere.Leadership, 1, 3, AttachmentSlot.Armor,
                "Gain +2 Health and Block",
                null,
                Artist.Unknown, DigitalRarity.Rare);
            addEvent("Well-prepared", DigitalSphere.Spirit, 1, 1, DigitalTrait.Preparation,
                "Cancel the next Event that Sauron plays",
                null,
                Artist.Unknown, DigitalRarity.Rare);
        }
    }
}