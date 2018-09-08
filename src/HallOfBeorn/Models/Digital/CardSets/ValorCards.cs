using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.CardSets
{
    public class ValorCards : DigitalCardSet
    {
        public ValorCards()
            : base("Valor Cards", "Valor")
        {
        }

        protected override void Initialize()
        {
            addAlly("Tom Bombadil", true, DigitalSphere.None, 0, 5, 3, 3, 4, DigitalTrait.Legend,
                "Fleeting. Arrival: Defeat a non-unique Enemy", 
                null, 
                Artist.Unknown, DigitalRarity.Legendary);
            addAlly("Trollshaw Scout", false, DigitalSphere.Lore, 1, 3, 2, 2, 5, DigitalTrait.Noldor,
                "Revenge: Exhaust a random Enemy",
                null, 
                Artist.Unknown, DigitalRarity.Common);
            addAlly("Zigil Miner", false, DigitalSphere.Leadership, 1, 1, 1, 1, 3, DigitalTrait.Dwarf,
                "Exhaust Zigil Miner to gain +1 Resource",
                null, 
                Artist.Unknown, DigitalRarity.Common);
            addAlly("Galadriel's Handmaiden", false, DigitalSphere.Spirit, 1, 1, 0, 2, 2, DigitalTrait.Silvan,
                "Arrival: Lose 1 Threat", 
                null,
                Artist.Unknown, DigitalRarity.Common);
            addAlly("Ghan-buri-Ghan", true, DigitalSphere.Lore, 1, 2, 1, 0,	5, DigitalTrait.Wose,
                "Stealth. Gain +1 Willpower for each Objective in play",
                null, 
                Artist.Unknown, DigitalRarity.Rare);
            addAlly("Erkenbrand", true, DigitalSphere.Leadership, 1, 4,	2, 0, 6, DigitalTrait.Rohan,
                "Block. Guard",
                null, 
                Artist.Unknown, DigitalRarity.Rare);
            addAlly("Westfold Outrider", false, DigitalSphere.Tactics, 1, 2, 2, 0, 3, DigitalTrait.Rohan,
                "Arrival: Deal 2 damage to an unwounded Enemy",
                null, 
                Artist.Unknown, DigitalRarity.Common);
            addAlly("Barliman Butterbur", true, DigitalSphere.Spirit, 1, 2, 1, 1, 5, DigitalTrait.Bree,
                "Spend 1 Resource and exhaust Barliman Butterbur to draw a card",
                null,
                Artist.Unknown, DigitalRarity.Rare);
            addAlly("Beorn", true, DigitalSphere.Tactics, 1, 5, 2, 1, 6, DigitalTrait.Beorning, 
                "Cannot equip Attachments. Gain +1 Attack for each point below maximum Health",
                null,
                Artist.Tiziano_Baracchi, DigitalRarity.Rare);

            addAttachment("Star Brooch", false, DigitalSphere.Spirit, 1, 2, AttachmentSlot.Special,
                "Gain Stalwart",
                null, 
                Artist.Unknown, DigitalRarity.Uncommon);
            addAttachment("Raiment of War", false, DigitalSphere.Tactics, 1, 4, AttachmentSlot.Armor,
                "Gain +1 Attack, +2 Health, and Block",
                null,
                 Artist.Unknown, DigitalRarity.Uncommon);
            addAttachment("Unexpected Courage", false, DigitalSphere.Spirit, 1, 1, AttachmentSlot.Special,
                "Once per round, ready after defeating an Enemy or resolving an Objective",
                "<p>Once per round, ready after defeating an Enemy or resolving an Objective.</p>",
                Artist.Unknown, DigitalRarity.Common);
            addAttachment("Forest Snare", false, DigitalSphere.Lore, 1, 3, AttachmentSlot.Special, 
                "Exhaust a non-unique enemy. That enemy does not ready during upkeep",
                null,
                Artist.Unknown, DigitalRarity.Uncommon);
            addAttachment("Ranger's Blade", false, DigitalSphere.Leadership, 1, 1, AttachmentSlot.Weapon,
                "Gain +1 Attack", 
                null,
                Artist.Unknown, DigitalRarity.Uncommon);

            addEvent("Borne Aloft", DigitalSphere.Spirit, 1, 1, DigitalTrait.Preparation, 
                "The next Ally from your deck that is defeated returns to your hand instead",
                null, 
                Artist.Unknown, DigitalRarity.Common);
            addEvent("Quick Strike", DigitalSphere.Tactics, 2, 2, null, 
                "Deal damage to an Enemy equal to the selected Character's Attack",
                null, 
                Artist.Unknown, DigitalRarity.Uncommon);
            addEvent("A Friend in Need", DigitalSphere.Spirit, 2, 1, DigitalTrait.Preparation,
                "Cancel damage from the next Enemy attack", 
                null,
                Artist.Unknown, DigitalRarity.Uncommon);
            addEvent("Rain of Arrows", DigitalSphere.Tactics, 1, 2, null, 
                "Deal 1 damage to every Enemy", 
                null, 
                Artist.Unknown, DigitalRarity.Common);
            addEvent("Reinforcements", DigitalSphere.Leadership, 2, 2, null,
                "Play a random non-unique Ally from your deck", 
                null, 
                Artist.Unknown, DigitalRarity.Uncommon);
            addEvent("Sudden Riposte", DigitalSphere.Lore, 2, 1, null, "Exhaust an Enemy", null, 
                Artist.Unknown, DigitalRarity.Uncommon);
        }
    }
}