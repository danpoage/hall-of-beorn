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
                "<p>Gain +2 ♢ this round after the first time a <b>Character</b> is damaged in the round</p>",
                Artist.Magali_Villeneuve);
            addAlly("Escort from Edoras", false, DigitalSphere.Leadership, 1, 1, 1, 1, 2, DigitalTrait.Rohan,
                "Revenge: Ready a Character",
                "<p><a href='/Digital/Search?Keyword=Revenge' target='_blank'><b>Revenge:</b></a> Ready a Character</p>",
                Artist.Unknown, DigitalRarity.Common);
            addAttachment("Shield of Rohan", false, DigitalSphere.Tactics, 1, 2, AttachmentSlot.Armor,
                "Gain +2 Health",
                "<p>Gain +2 ❤</p>",
                Artist.Unknown, DigitalRarity.Uncommon);
            addEvent("Sterner than Steel", DigitalSphere.Spirit, 2, 3, null,
                "Every Character in play gains +1 Willpower",
                "<p>Every Character in play gains +1 ♢</p>",
                Artist.Unknown, DigitalRarity.Legendary);
            addEvent("Houses of Healing", DigitalSphere.Lore, 1, 5, null,
                "Select a Hero in your discard pile. That Hero returns to play exhausted",
                "<p>Select a <a href='/Digital/Search?CardType=Hero' target='_blank'><b>Hero</b></a> in your discard pile. That <b>Hero</b> returns to play exhausted</p>",
                Artist.Unknown, DigitalRarity.Rare);
        }
    }
}