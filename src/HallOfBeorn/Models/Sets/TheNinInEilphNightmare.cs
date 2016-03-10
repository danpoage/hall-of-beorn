using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class TheNinInEilphNightmare : CardSet
    {
        private const string setName = "The Nîn-in-Eilph Nightmare";

        protected override void Initialize()
        {
            Name = setName;
            NormalizedName = "The Nin-in-Eilph Nightmare";
            Abbreviation = "NiEN";
            SetType = Models.SetType.Nightmare_Expansion;
            Cycle = "NIGHTMARE";
            Number = 2071;

            Cards.Add(Card.NightmareSetup(setName, setName)
                .WithText("You are playing Nightmare mode.\r\nForced: When the players advance to stage 2A, add Ancient Marsh-dweller to the staging area (from out of play or engaged with a player).")
                .WithFlavor("There was a deep silence, only scraped on its surfaces by the faint quiver of empty seed plumes, and broken grass-blades trembling in small air-movements that they could not feel. -The Two Towers")
                .WithOppositeText("")
                .WithInfo(1, 1, Artist.Claudio_Pozas));
        }
    }
}