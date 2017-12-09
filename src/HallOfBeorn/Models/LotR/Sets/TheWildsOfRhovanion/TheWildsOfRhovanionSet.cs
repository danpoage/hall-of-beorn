using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.TheWildsOfRhovanion
{
    public class TheWildsOfRhovanionSet : CardSet
    {
        protected override void Initialize()
        {
            Name = "The Wilds of Rhovanion";
            Abbreviation = "TWoR";
            Number = 49;
            SetType = Models.SetType.Deluxe_Expansion;

            addCard(LotRCard.Hero("Bard son of Brand", string.Empty, Sphere.Spirit, 9, 2, 2, 2, 3)
                .WithTraits("Dale.", "Noble.")
                .WithText("While playing an Item attachment, Bard son of Brand is considered to have the printed Leadership, Lore, and Tactics icons.\r\nResponse: When a character leaves play, return each attachment attached to that character to its owners hand. (Limit once per phase.)")
                .WithInfo(2, 1, Artist.Unknown));

            addCard(LotRCard.Ally("Long Lake Trader", Sphere.Lore, 2, 1, 1, 0, 2)
                .WithTraits("Dale.")
                .WithText("Action: Exhaust Long Lake Trader to move an Item attachment from a character you control to another eligible character.")
                .WithFlavor("\"Nowhere are there any men so friendly to us as the Men of Dale.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Unknown));

            addCard(LotRCard.Attachment("Necklace of Girion", string.Empty, Sphere.Neutral, 1)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Guarded (enemy or location).")
                .WithText("Attach to a hero.\r\nAttached hero gets +2 Willpower and collects an additional resource during the resource phase.")
                .WithFlavor("...the necklace of Girion, Lord of Dale, made of five hundred emeralds green as grass, which he gave for the arming of his eldest son...\r\n-The Hobbit")
                .WithInfo(11, 3, Artist.Drazenka_Kimpel));
            addCard(LotRCard.Event("Traffic from Dale", string.Empty, Sphere.Leadership, 1)
                .WithText("Planning Action: Choose a Dale hero you control. Add 1 resource to its pool for each character you control with a player attachment. You can only play 1 copy of Traffic from Dale each round.")
                .WithFlavor("The talk was all of the trade that came and went on the waterways and the growth of the traffic on the river...\r\nThe Hobbit")
                .WithInfo(12, 3, Artist.Unknown));
        }
    }
}