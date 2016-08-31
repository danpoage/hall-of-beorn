using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Sets
{
    public class RaceAcrossHarad : CardSet
    {
        protected override void Initialize()
        {
            Name = "Race Across Harad";
            Abbreviation = "RaH";
            Number = 44;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            Cards.Add(Card.Hero("Thurindir", string.Empty, Sphere.Lore, 8, 2, 2, 0, 4)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Thurindir gets +1 Willpower for each side quest in the victory display.\r\nSetup: Search your deck for a side quest and add it to your hand. Shuffle your deck.")
                .WithFlavor("\"He is one of the wandering folk - Rangers we call them.\"\r\n-Barliman Butterbur, The Fellowship of the Ring")
                .WithInfo(28, 1, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.Attachment("Steed of the North", string.Empty, Sphere.Leadership, 1)
                .WithGeneric()
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dúnedain or Ranger hero.\r\nResponse: After you engage an enemy, exhaust Steed of the North to ready attached hero.")
                .WithFlavor("Their horses were strong and of proud bearing, but rough-haired...\r\n-The Return of the King")
                .WithInfo(30, 3, Artist.Alvaro_Calvo_Escudero));
            Cards.Add(Card.PlayerSideQuest("Explore Secret Ways", string.Empty, Sphere.Lore, 1, 6)
                .WithText("Limit 1 copy of Explore Secret Ways in the victory display.\r\nWhile Explore Secret Ways is in the victory display, each location in the staging area with the same title as the active location does not contribute its Threat to the total Threat in the staging area.")
                .WithFlavor("\"I myself dares to pass the doors of the Necromancer in Dul Guldur, and secretly explored his ways...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(36, 3, Artist.Andreia_Ugrai));
        }
    }
}