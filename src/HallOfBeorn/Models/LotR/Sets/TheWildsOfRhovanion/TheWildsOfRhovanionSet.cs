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
            addAlly("Redwater Sentry", 3, Sphere.Leadership, false, 0, 1, 2, 3)
                .WithTraits("Dale.", "Warrior.")
                .WithText("Reduce the cost to play Armor attachments on Redwater Sentry by 1.\r\nRedward Sentry gets +1 Defense and gains sentinel while it has an Armor attachment.")
                .WithInfo(3, 3, Artist.JB_Casacop);
            addAlly("North Realm Lookout", 2, Sphere.Spirit, false, 1, 1, 1, 2)
                .WithTraits("Dale.", "Scout.")
                .WithText("North Realm Lookout gets +1 Willpower and does not exhaust to quest while it has an Item attachment.")
                .WithFlavor("There were people on the look-out on the banks.\r\n-The Hobbit")
                .WithInfo(4, 3, Artist.JB_Casacop);
            addAlly("Warrior of Dale", 3, Sphere.Tactics, false, 0, 2, 1, 3)
                .WithTraits("Dale.", "Warrior.")
                .WithText("Reduce the cost to play Weapon attachments on ~Warrior of ~Dale by 1.\r\n~Warrior of ~Dale gets +1 Attack and gains ranged while it has a Weapon attachment.")
                .WithInfo(5, 3, Artist.Aleksander_Karcz);
            addCard(LotRCard.Ally("Long Lake Trader", Sphere.Lore, 2, 1, 1, 0, 2)
                .WithTraits("Dale.")
                .WithText("Action: Exhaust Long Lake Trader to move an Item attachment from a character you control to another eligible character.")
                .WithFlavor("\"Nowhere are there any men so friendly to us as the Men of Dale.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(6, 3, Artist.Torbjorn_Kallstrom));
            addAttachment("Hauberk of Mail", 1, Sphere.Leadership, false)
                .WithTraits("Item.", "Armor.")
                .WithText("Attach to a Dale or Warrior character. Limit 1 per character.\r\nAttached character gets +1 Defense (and +1 hit point if attached character has the sentinel keyword).")
                .WithFlavor("Each one of his folk was clad in hauberk of steel mail that hung to his knees...\r\n-The Hobbit")
                .WithInfo(7, 3, Artist.Sara_Biddle);
            addAttachment("King of Dale", 2, Sphere.Spirit, true)
                .WithTraits("Title.")
                .WithText("Attach to a Dale or Esgaroth hero.\r\nPlanning Action: Exhaust King of ~Dale to reduce the cost of the next Dale ally you play this phase by 1 for each different player attachment on attached hero. That ally does not require a resource match.")
                .WithFlavor("Then Bard II, Brand's son, became King of Dale..\r\n-The Return of the King")
                .WithInfo(8, 3, Artist.Antonio_Jose_Manzanedo);
            addAttachment("Bow of Yew", 0, Sphere.Tactics, false)
                .WithTraits("Item.", "Weapon.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dale or Warrior character.\r\nResponse: After attack character is declaed as an attacker, exhaust Bow of Yew to deal 1 damage to the defending enemy.")
                .WithFlavor("\"They would shoot at us with their great bows of yew...\"\r\n-The Lord of the Eagles, The Hobbit")
                .WithInfo(9, 3, Artist.Sara_Biddle);
            addAttachment("Map of Rhovanion", 1, Sphere.Lore, false)
                .WithTraits("Item.")
                .WithText("Attach to a Dale or Scout character. Limit 1 per character.\r\nResponse: After attached character commits to the quest, place 1 progress on the active location.")
                .WithFlavor("\"You are come to the very edge of the Wild...\"\r\n-Gandalf, The Hobbit")
                .WithInfo(10, 3, Artist.Yoann_Boissonnet);
            addCard(LotRCard.Attachment("Necklace of Girion", string.Empty, Sphere.Neutral, 1)
                .WithUnique()
                .WithTraits("Artifact.", "Item.")
                .WithKeywords("Guarded (enemy or location).")
                .WithText("Attach to a hero.\r\nAttached hero gets +2 Willpower and collects an additional resource during the resource phase.")
                .WithFlavor("...the necklace of Girion, Lord of Dale, made of five hundred emeralds green as grass, which he gave for the arming of his eldest son...\r\n-The Hobbit")
                .WithInfo(11, 3, Artist.Drazenka_Kimpel));
            addCard(LotRCard.Event("Traffic from Dale", string.Empty, Sphere.Leadership, 1)
                .WithText("Planning Action: Choose a Dale hero you control. Add 1 resource to its pool for each character you control with a player attachment. You can only play 1 copy of Traffic from ~Dale each round.")
                .WithFlavor("The talk was all of the trade that came and went on the waterways and the growth of the traffic on the river...\r\nThe Hobbit")
                .WithInfo(12, 3, Artist.Torbjorn_Kallstrom));
            addEvent("To Arms!", 0, Sphere.Spirit)
                .WithText("Action: Choose an ally with a player attachment. Ready that ally.")
                .WithFlavor("...the grim-voiced fellow ran hotfoot to the Master. \"The dragon is coming or I am a fool!\" he cried. \"Cut the bridges! To arms! To arms!\"\r\n-The Hobbit")
                .WithInfo(13, 3, Artist.Aleksander_Karcz);
            addEvent("Valour of the North", 0, Sphere.Tactics)
                .WithText("Response: After a character is declared as an attacker or defender against an enemy with an attachment, that character gets +3 Attack and +3 Defense until the end of this attack.")
                .WithFlavor("\"Dwarf-mail may be good, but they will soon be hard put to it.\"\r\n-Bard the Bowman, The Hobbit")
                .WithInfo(14, 3, Artist.Ivan_Dixon);
            addEvent("Bartering", 0, Sphere.Lore)
                .WithText("Planning Action: Choose a ready player attachment on a character you control. Return that attachment to its owner's hand to reduce the cost of the next attachment played this phase by X, where X is the chosen attachment's cost.")
                .WithInfo(15, 3, Artist.Torbjorn_Kallstrom);
        }
    }
}