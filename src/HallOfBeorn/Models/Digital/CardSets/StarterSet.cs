using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Digital.CardSets
{
    public class StarterSet : DigitalCardSet
    {
        public StarterSet()
            : base("Starter", "Starter")
        {
        }

/*
Hero	Sphere	Threat	Attack	Willpower	Health	Traits	Effect	Source
Legolas	Tactics	9	2	1	9	Silvan	Ranged. Upkeep: Deal 1 damage	Legolas Pack
Eowyn	Spirit	9	2	1	8	Rohan	Gain +2 Willpower this round after the first time a Character is damage in the round.	Eowyn Pack
Faramir	Lore	11	2	1	10	Gondor	Ranged. Vanquish: Draw 1 card	Faramir Pack
Dwalin	Leadership	10	2	1	10	Dwarf	Gain +1 Attack and +1 Willpower when at 5 health or less	Dwalin Pack
 */

//Other expansions
/*
Erebor Record Keeper	Lore	1	2	1	2	4	Dwarf	Upkeep: Draw a card	Dwalin Pack	Common
Erkenbrand	Leadership	1	4	2	0	6	Rohan	Block. Guard	Valor	Rare
Galadriel's Handmaiden	Spirit	1	1	0	2	2	Silvan	Arrival: Lose 1 Threat	Valor	Common
Tom Bombadil	Neutral	0	5	3	3	4	Legend	Fleeting. Arrival: Defeat a non unique Enemy	Valor	Legendary
Trollshaw Scout	Lore	1	3	2	2	5	Noldor	Revenge: Exhaust a random Enemy	Valor	Common
Zigil Miner	Leadership	1	1	1	1	3	Dwarf	Exhaust Zigil Miner to gain +1 Resource	Valor	Common
Westfold Outrider	Tactics	1	2	2	0	3	Rohan	Arrival: Deal 2 damage to an unwounded Enemy	Valor	Common
Escort from Edoras	Leadership	1	1	1	1	2	Rohan	Revenge: Ready a Character	Eowyn Pack	Common
Barliman Butterbur	Spirit	1	2	1	1	5	Bree	Spend 1 Resource and exhaust Barliman Butterbur to draw a card	Valor	Rare
Silvan Tracker	Lore	1	1	1	1	3	Silvan	Arrival: Give a Character Stealth this round	Legolas Pack	Common
Mablung	Lore	2	4	2	1	5	Gondor	Ranged. Arrival: Exhaust a non unique Enemy	Faramir Pack	Legendary
Beorn	Tactics	1	5	2	1	6	Beorning	Cannot equip Attachments. Gain +1 Attack for each point below maximum Health	Valor	Rare
Ghan-buri-Ghan	Lore	1	3	1	0	5	Wose	Stealth. Gain +1 Willpower for each Objective in play	Valor	Rare
*/

//Attachments
/*
*/

        protected override void Initialize()
        {
            addHero("Aragorn", DigitalSphere.Leadership, 11, 2, 2, 11, DigitalTrait.Dunadan, 
                "Power: Spend 1 Resource to ready Aragorn and gain a Surge Action", 
                "<p><a href='/Digital/Search?Keyword=Power' target='_blank'><b>Power:</b></a> Spend 1 ◯ to ready Aragorn and gain a <a href='/Digital/Search?Keyword=Surge' target='_blank'><b>Surge</b></a> Action</p>",
                Artist.John_Stanko);
            addHero("Arwen", DigitalSphere.Lore, 9, 1, 3, 9, DigitalTrait.Noldor, 
                "Upkeep: Restore 1 Health to a Character",
                "<p><a href='/Digital/Search?Keyword=Upkeep' target='_blank'><b>Upkeep:</b></a> Restore 1 ❤ to a Character</p>", 
                Artist.Magali_Villeneuve);
            addHero("Gimli", DigitalSphere.Tactics, 10, 2, 1, 12, DigitalTrait.Dwarf, 
                "Gain +1 Attack this round after the first time a Character is damaged in the round",
                "<p>Gain +1 ⚔️ this round after the first time a Character is damaged in the round</p>", 
                Artist.Tony_Foti);
            addHero("Tom Took", DigitalSphere.Spirit, 8, 1, 2, 8, DigitalTrait.Hobbit, 
                "Exhaust Tom Took to cancel damage from the next Enemy attack this round",
                "<p>Exhaust Tom Took to cancel damage from the next Enemy attack this round</p>", 
                Artist.Unknown);
            addAlly("Gandalf", true, DigitalSphere.None, 0, 5, 4, 4, 5, DigitalTrait.Istar, 
                "Fleeting. Arrival (choose): Draw 3 Cards, lose 3 Threat, or deal 3 Damage", 
                "<p><a href='/Digital/Search?Keyword=Fleeting' target='_blank'><b>Fleeting.</b></a> <a href='/Digital/Search?Keyword=Arrival' target='_blank'><b>Arrival (choose):</b></a> Draw 3 Cards, lose 3 Threat, or deal 3 Damage</p>",
                Artist.Unknown);
            addAlly("Erebor Watchman", false, DigitalSphere.Leadership, 1, 1, 1, 0, 4, DigitalTrait.Dwarf,
                "Block", "<p><a href='/Digital/Search?Keyword=Block' target='_blank'><b>Block</b></a></p>", Artist.Unknown);
            addAlly("Rhovanion Outrider", false, DigitalSphere.Spirit, 1, 2, 1, 2, 5, DigitalTrait.Dale,
                "Gain +1 Willpower this round when engaging an Objective that is at full Quest value",
                "<p>Gain +1 ♢ this round when engaging an Objective that is at full Quest value</p>",
                Artist.Unknown);
            addAlly("Ithilien Lookout", false, DigitalSphere.Lore, 1, 2, 2, 2, 4, DigitalTrait.Gondor,
                string.Empty, string.Empty, Artist.Unknown);
            addAlly("Veteran Axehand", false, DigitalSphere.Tactics, 1, 2, 2, 1, 6, DigitalTrait.Dwarf,
                string.Empty, string.Empty, Artist.Unknown);
            addAlly("Guard of the Citadel", false, DigitalSphere.Leadership, 1, 1, 1, 0, 4, DigitalTrait.Gondor,
                "Guard", "<p><a href='/Digital/Search?Keyword=Guard' target='_blank'><b>Guard</b></a></p>", Artist.Unknown);
            addAlly("Wandering Took", false, DigitalSphere.Spirit, 1, 1, 1, 1, 3, DigitalTrait.Hobbit,
                "Arrival: Sauron loses 1 Resource",
                "<p><a href='/Digital/Search?Keyword=Arrival' target='_blank'><b>Arrival:</b></a> Sauron loses 1 ◯</p>", Artist.Unknown);
            addAlly("Longbeard Mapmaker", false, DigitalSphere.Lore, 1, 1, 1, 1, 4, DigitalTrait.Dwarf,
                "Power: Spend 1 Resource to gain +1 Willpower this round",
                "<p><a href='/Digital/Search?Keyword=Power' target='_blank'><b>Power:</b></a> Spend 1 ◯ to gain +1 ♢ this round</p>", Artist.Unknown);
            addAlly("Imladris Caregiver", false, DigitalSphere.Lore, 1, 2, 0, 2, 4, DigitalTrait.Noldor,
                "Arrival: Restore 2 Health to a Character",
                "<p><a href='/Digital/Search?Keyword=Arrival' target='_blank'><b>Arrival:</b></a> Restore 2 ❤ to a Character</p>", Artist.Unknown);
            addAlly("Rohirrim Lancer", false, DigitalSphere.Leadership, 1, 2, 2, 1, 4, DigitalTrait.Rohan,
                "Ranged", "<p><a href='/Digital/Search?Keyword=Ranged' target='_blank'><b>Ranged</b></a></p>", Artist.Unknown);
            addAlly("Woodland Courier", false, DigitalSphere.Spirit, 1, 2, 0, 2, 4, DigitalTrait.Silvan,
                "Arrival: Apply 1 progress",
                "<p><a href='/Digital/Search?Keyword=Arrival' target='_blank'><b>Arrival:</b></a> Apply 1 progress</p>", Artist.Unknown);
            addAlly("Warden of Annúminas", false, DigitalSphere.Leadership, 1, 3, 2, 1, 5, DigitalTrait.Dunadan,
                "Surge", "<p><a href='/Digital/Search?Keyword=Surge' target='_blank'><b>Surge</b></a></p>", Artist.Unknown);
            addAlly("Galadhon Archer", false, DigitalSphere.Tactics, 1, 1, 1, 0, 2, DigitalTrait.Silvan,
                "Ranged. Arrival: Deal 1 Damage", 
                "<p><a href='/Digital/Search?Keyword=Ranged' target='_blank'><b>Ranged.</b></a> <a href='/Digital/Search?Keyword=Arrival' target='_blank'><b>Arrival:</b></a> Deal 1 Damage </p>", Artist.Unknown);
            addAlly("Man of Dale", false, DigitalSphere.Tactics, 1, 2, 1, 1, 4, DigitalTrait.Dale,
                "Ranged", "<p><a href='/Digital/Search?Keyword=Ranged' target='_blank'><b>Ranged.</b></a></p>", Artist.Unknown);

        }
    }
}