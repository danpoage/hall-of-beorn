using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.CardSets
{
    public class LegolasSet : DigitalCardSet
    {
        public LegolasSet()
            : base("Legolas Pack", "LP")
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
                "<a href='/Digital/Search?Keyword=Arrival' target='_blank'><b>Arrival:</b></a> Give a Character <a href='/Digital/Search?Keyword=Stealth' target='_blank'><b>Stealth</b></a>", Artist.Magali_Villeneuve);
        }
    }
}