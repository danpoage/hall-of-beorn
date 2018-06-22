using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Starter
{
    public class TwoPlayerLimitedEditionStarterSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "Two-Player Limited Edition Starter";
            AlternateName = "Two-Player Starter";
            Abbreviation = "TPLES";
            Number = 201;
            SetType = Models.SetType.Limited_Edition;

            addHero("Gildor Inglorion", 9, Sphere.Leadership, 3, 2, 1, 3)
                .WithTraits("Noldor.", "Noble.")
                .WithText("Action: Pay 1 resource from Gildor Inglorion's resource pool to choose a player to draw 1 card (Limit once per round.)")
                .WithFlavor("\"Gildor Inglorion of the House of Finrod. We are Exiles, and most of our kindred have long ago departed...\r\n-The Fellowship of the Ring")
                .WithInfo(2, 1, Artist.Jason_Jenicke);
            addHero("Thorin Stonehelm", 9, Sphere.Tactics, 1, 3, 1, 4)
                .WithTraits("Dwarf.", "Noble.", "Warrior.")
                .WithText("Response: After Thorin Stonehelm is declared as an attacker, discard the top card of your deck to deal 1 damage to an enemy engaged with you.")
                .WithFlavor("Thorin III Stonehelm, Dain's son, became King under the mountain.\r\n-The Return of the King")
                .WithInfo(36, 1, Artist.Rafal_Hrynkiewicz);
        }
    }
}