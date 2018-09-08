using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.CardSets
{
    public class EowynPack : DigitalCardSet
    {
        public EowynPack()
            : base("Éowyn Pack", "EW")
        {
        }

        protected override void Initialize()
        {
            addHero("Éowyn", DigitalSphere.Spirit, 9, 2, 1, 8, DigitalTrait.Rohan,
                "Gain +2 Willpower this round after the first time a Character is damaged in the round",
                null,
                Artist.Magali_Villeneuve);
            addAlly("Escort from Edoras", false, DigitalSphere.Leadership, 1, 1, 1, 1, 2, DigitalTrait.Rohan,
                "Revenge: Ready a Character",
                null,
                Artist.Unknown, DigitalRarity.Common);
            addAttachment("Shield of Rohan", false, DigitalSphere.Tactics, 1, 2, AttachmentSlot.Armor,
                "Gain +2 Health",
                null,
                Artist.Unknown, DigitalRarity.Uncommon);
            addEvent("Sterner than Steel", DigitalSphere.Spirit, 2, 3, null,
                "Every Character in play gains +1 Willpower",
                null,
                Artist.Unknown, DigitalRarity.Legendary);
            addEvent("Houses of Healing", DigitalSphere.Lore, 1, 5, null,
                "Select a Hero in your discard pile. That Hero returns to play exhausted",
                null,
                Artist.Unknown, DigitalRarity.Rare);
        }
    }
}