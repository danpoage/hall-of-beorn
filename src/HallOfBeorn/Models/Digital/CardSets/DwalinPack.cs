using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.CardSets
{
    public class DwalinPack : DigitalCardSet
    {
        public DwalinPack()
            : base("Dwalin Pack", "DW")
        {
        }

        protected override void Initialize()
        {
            addHero("Dwalin", DigitalSphere.Leadership, 10,	2, 1, 10, DigitalTrait.Dwarf, 
                "Gain +1 Attack and +1 Willpower when at 5 health or less",
                "<p>Gain +1 ⚔️ and +1 ♢ when at 5 ❤ or less</p>", 
                Artist.Magali_Villeneuve);
            addAlly("Erebor Record Keeper", false, DigitalSphere.Lore, 1, 2, 1, 2, 4, DigitalTrait.Dwarf,
                "Upkeep: Draw a card", 
                "<p><a href='/Digital/Search?Keyword=Upkeep' target='_blank'><b>Upkeep:</b></a> Draw a card</p>",
                Artist.Unknown, DigitalRarity.Common);
            addEvent("Will of Steel", DigitalSphere.Spirit, 1, 1, null,
                "Apply a Hero's Attack as progress to an Objective",
                "<p>Apply a Hero's ⚔️ to an Objective</p>",
                Artist.Unknown, DigitalRarity.Rare);
            addEvent("Khazad ai-menu!", DigitalSphere.Leadership, 2, 2, null,
                "Surge. Give a Dwarf +2 Attack this round; or +3 Attack this round if wounded",
                "<p><a href='/Digital/Search?Keyword=Surge' target='_blank'><b>Surge.</b></a> Give a <a href='/Digital/Search?Trait=Dwarf' target='_blank'><b>Dwarf</b></a> +2 ⚔️ this round; or +3 ⚔️ this round if wounded</p>",
                Artist.Unknown, DigitalRarity.Legendary);
            addEvent("Get the Orcs!", DigitalSphere.Tactics, 1, 3, null,
                "Deal 2 damage to every Orc",
                "<p>Deal 2 damage to every <b>Orc</b></p>", 
                Artist.Unknown, DigitalRarity.Uncommon);
        }
    }
}