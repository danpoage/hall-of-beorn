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
                "Gain +1 Attack and +1 Willpower when at 5 Health or less",
                null, 
                Artist.Magali_Villeneuve);
            addAlly("Erebor Record Keeper", false, DigitalSphere.Lore, 1, 2, 1, 2, 4, DigitalTrait.Dwarf,
                "Upkeep: Draw a card", 
                null,
                Artist.Unknown, DigitalRarity.Common);
            addEvent("Will of Steel", DigitalSphere.Spirit, 1, 1, null,
                "Apply a Hero's Attack as progress to an Objective",
                null,
                Artist.Unknown, DigitalRarity.Rare);
            addEvent("Khazad ai-menu!", DigitalSphere.Leadership, 2, 2, null,
                "Surge. Give a Dwarf +2 Attack this round; or +3 Attack this round if wounded",
                null,
                Artist.Unknown, DigitalRarity.Legendary);
            addEvent("Get the Orcs!", DigitalSphere.Tactics, 1, 3, null,
                "Deal 2 damage to every Orc",
                null, 
                Artist.Unknown, DigitalRarity.Uncommon);
        }
    }
}