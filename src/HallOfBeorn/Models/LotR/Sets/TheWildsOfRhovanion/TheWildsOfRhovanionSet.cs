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

            addHero("Brand son of Bain", 10, Sphere.Leadership, 2, 3, 2, 3)
                .WithTraits("Dale.", "Noble.")
                .WithText("Each Dale character you control with a player attachment gets +1 Willpower.\r\nResponse: After you play an attachment on a Dale character without an attachment, draw a card.")
                .WithFlavor("\"He is a strong king, and his realm now reaches south and east of Esgaroth.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(1, 1, Artist.Antonio_Jose_Manzanedo);
            addCard(LotRCard.Hero("Bard son of Brand", string.Empty, Sphere.Spirit, 9, 2, 2, 2, 3)
                .WithTraits("Dale.", "Noble.")
                .WithText("While playing an Item attachment, Bard son of Brand is considered to have the printed Leadership, Lore, and Tactics icons.\r\nResponse: When a character leaves play, return each attachment attached to that character to its owners hand. (Limit once per phase.)")
                .WithInfo(2, 1, Artist.Antonio_Jose_Manzanedo));

            addCard(LotRCard.Ally("Long Lake Trader", Sphere.Lore, 2, 1, 1, 0, 2)
                .WithTraits("Dale.")
                .WithText("Action: Exhaust Long Lake Trader to move an Item attachment from a character you control to another eligible character.")
                .WithFlavor("\"Nowhere are there any men so friendly to us as the Men of Dale.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Unknown));

            addAttachment("King of Dale", 2, Sphere.Spirit, true)
                .WithTraits("Title.")
                .WithText("Attach to a Dale or Esgaroth hero.\r\nPlanning Action: Exhaust King of Dale to reduce the cost of the next Dale ally you play this phase by 1 for each different player attachment on attached hero. That ally does not require a resource match.")
                .WithFlavor("Then Bard II, Brand's son, became King of Dale..\r\n-The Return of the King")
                .WithInfo(8, 3, Artist.Antonio_Jose_Manzanedo);
            addAttachment("Bow of Yew", 0, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dale or Warrior character.\r\nResponse: After attack character is declaed as an attacker, exhaust Bow of Yew to deal 1 damage to the defending enemy.")
                .WithFlavor("\"They would shoot at us with their great bows of yew...\"\r\n-The Lord of the Eagles, The Hobbit")
                .WithInfo(9, 3, Artist.Sara_Biddle);

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