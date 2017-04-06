using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
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

            addCard(LotRCard.Hero("Thurindir", string.Empty, Sphere.Lore, 8, 2, 2, 0, 4)
                .WithTraits("Dúnedain.", "Ranger.")
                .WithText("Thurindir gets +1 Willpower for each side quest in the victory display.\r\nSetup: Search your deck for a side quest and add it to your hand. Shuffle your deck.")
                .WithFlavor("\"He is one of the wandering folk - Rangers we call them.\"\r\n-Barliman Butterbur, The Fellowship of the Ring")
                .WithInfo(28, 1, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Ally("Kahliel's Tribesman", Sphere.Leadership, 2, 1, 1, 1, 2)
                .WithTraits("Harad.")
                .WithText("Action: Exhaust Kahliel’s Tribesman to choose another Harad character. That character gets +1 Willpower, +1 Attack, and +1 Defense until the end of the phase.")
                .WithFlavor("But the Haradrim, being now driven to the brink, turned at bay, and they were fierce in despair...\r\n-The Return of the King")
                .WithInfo(29, 3, Artist.Ryan_Valle));
            addCard(LotRCard.Attachment("Steed of the North", string.Empty, Sphere.Leadership, 1)
                .WithTraits("Mount.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dúnedain or Ranger hero.\r\nResponse: After you engage an enemy, exhaust Steed of the North to ready attached hero.")
                .WithFlavor("Their horses were strong and of proud bearing, but rough-haired...\r\n-The Return of the King")
                .WithInfo(30, 3, Artist.Alvaro_Calvo_Escudero));
            addCard(LotRCard.Attachment("Mighty Warrior", string.Empty, Sphere.Tactics, 1)
                .WithTraits("Skill.")
                .WithText("Attach to a hero. Limit 1 per hero.\r\nAttached hero gains the Warrior trait.\r\nResponse: After you play Mighty Warrior from your hand, draw a card.")
                .WithFlavor("Gimli hewed the legs from another that had sprung up on Balin’s tomb.\r\n-The Fellowship of the Ring")
                .WithInfo(31, 3, Artist.Marius_Bota));
            addCard(LotRCard.Event("Proud Hunters", string.Empty, Sphere.Tactics, 0)
                .WithText("Play only if you control a unique character with the Noble trait and another unique character with the Ranger trait.\r\nResponse: After a hero you control participates in an attack that destroys an enemy, add X resources to that hero’s pool. X is the just destroyed enemy’s printed Threat.")
                .WithInfo(32, 3, Artist.Rafal_Hrynkiewicz));
            addCard(LotRCard.Ally("Dúnedain Pathfinder", Sphere.Spirit, 0, 2, 1, 0, 2)
                .WithTraits("Dúnedain.", "Scout.")
                .WithText("Forced: After this ally enters play, search the top 5 cards of the encounter deck for a non-unique location and add it to the staging area. If no location enters play by this effect, discard Dúnedain Pathfinder. Shuffle the encounter deck.")
                .WithInfo(33, 3, Artist.Michele_Frigo));
            addCard(LotRCard.Event("Backtrack", string.Empty, Sphere.Spirit, 1)
                .WithText("Play only if the main quest has no keywords.\r\nAction: Remove X progress from the main quest to place X progress on a location in the staging area.")
                .WithFlavor("\"Well,\" said Boromir, \"when heads are at a loss bodies must serve...\"\r\n-The Fellowship of the Ring")
                .WithInfo(34, 3, Artist.John_Pacer));
            addCard(LotRCard.Ally("Eryn Galen Settler", Sphere.Lore, 2, 1, 2, 0, 2)
                .WithTraits("Woodman.")
                .WithText("Response: When the active location leaves play as an explored location, discard Eryn Galen Settler to discard a location in the staging with the same title as the just explored location.")
                .WithInfo(35, 3, Artist.Michele_Frigo));
            addCard(LotRCard.PlayerSideQuest("Explore Secret Ways", string.Empty, Sphere.Lore, 1, 6)
                .WithText("Limit 1 copy of Explore Secret Ways in the victory display.\r\nWhile Explore Secret Ways is in the victory display, each location in the staging area with the same title as the active location does not contribute its Threat to the total Threat in the staging area.")
                .WithFlavor("\"I myself dared to pass the doors of the Necromancer in Dul Guldur, and secretly explored his ways...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithVictoryPoints(1)
                .WithInfo(36, 3, Artist.Andreia_Ugrai));
            addCard(LotRCard.Ally("Steward of Orthanc", Sphere.Neutral, 3, 2, 0, 0, 2)
                .WithTraits("Isengard.")
                .WithText("Response: When you play an event, give it Doomed 1 to draw a card. You cannot trigger this ability if you have already triggered the ability of a Steward of Orthanc this round.")
                .WithFlavor("\"...the power of Orthanc cannot be lightly thrown aside...\"\r\n-Saruman, The Two Towers")
                .WithInfo(37, 3, Artist.Aleksander_Karcz));
        }
    }
}