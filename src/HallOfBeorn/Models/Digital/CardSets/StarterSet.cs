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

        protected override void Initialize()
        {
            addHero("Aragorn", DigitalSphere.Leadership, 11, 2, 2, 11, DigitalCardTrait.Dunadan, "Spend 1 Resource to ready Aragorn and gain a Surge Action");
            addHero("Arwen", DigitalSphere.Lore, 9, 1, 3, 9, DigitalCardTrait.Noldor, "Upkeep: Restore 1 Health to a Character");
            addHero("Gimli", DigitalSphere.Tactics, 10, 2, 1, 12, DigitalCardTrait.Dwarf, "Gain +1 Attack this round after the first time a Character is damaged in the round");
            addHero("Tom Took", DigitalSphere.Spirit, 8, 1, 2, 8, DigitalCardTrait.Hobbit, "Exhaust Tom Took to cancel damage from the next Enemy attack this round");
        }
    }
}