using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.EredMithrin
{
    public class MountGundabadSet : CardSet
    {
        private const string setName = "Mount Gundabad";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "MG";
            Number = 54;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Ered Mithrin";

            IsSpoiler = true;

            addHero("Bilbo Baggins", 9, Sphere.Tactics, 1, 1, 2, 2)
                .WithTraits("Hobbit.", "Burglar.")
                .WithText("Response: After Bilbo ~Baggins commits to the quest, choose an enemy in the staging area. Until the end of the phase, Bilbo ~Baggins gets +X Willpower where X is that enemy's Threat. If the players quest successfully, deal 1 damage to that enemy (2 damage instead if it is guarding a card).")
                .WithInfo(112, 1, Artist.Tropa_Entertainment);
            addAlly("Greenwood Defender", 3, Sphere.Leadership, false, 0, 0, 2, 3)
                .WithTraits("Silvan.", "Warrior.")
                .WithText("Response: After Greenwood Defender enters play, it does not exhaust to defend until the end of the round.")
                .WithFlavor("...after the coming of Men they took ever more and more to the gloaming and the dusk.\r\n-The Hobbit")
                .WithInfo(113, 3, Artist.Unknown);
            addEvent("Elf Guide", 0, Sphere.Leadership)
                .WithText("Action: Return a Silvan ally you control to your hand to choose a hero. Add 1 resource to that hero's pool.")
                .WithFlavor("...soon Haldir turned aside into the trees and halted on the bank of the river under their shadows.\r\n-The Fellowship of the Ring")
                .WithInfo(114, 3, Artist.John_Howe);
            addAlly("Gaffer Gamgee", 2, Sphere.Lore, true, 1, 1, 0, 1)
                .WithTraits("Hobbit.")
                .WithText("Combat Action: Return Gaffer Gamgee to your hand to choose an enemy with engagement cost higher than your threat. Until the end of the round, that enemy cannot attack you.")
                .WithFlavor("\"Why? Why's none of my business, or yours.\"\r\n-The Fellowship of the Ring")
                .WithInfo(115, 3, Artist.Romana_Kendelic);
            addEvent("Drinking Song", 0, Sphere.Lore)
                .WithTraits("Song.")
                .WithText("Action: Count the number of cards in your hand and shuffle your hand into your deck. Then, draw an equal number of cards. Draw 1 additional card if you control a unique Hobbit character.")
                .WithFlavor("Ho! Ho! Ho! to the bottle I go\r\nTo heal my heart and drown my woe.\r\n-The Fellowship of the Ring")
                .WithInfo(116, 3, Artist.Romana_Kendelic);
            addAttachment("Sting", 0, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy).", "Restricted.")
                .WithText("Attach to a Hobbit hero.\r\nAttached hero gets +1 Willpower, +1 Attack, and +1 Defense.\r\nResponse: After attached hero is declared as an attacker or defender against an enemy, deal 1 damage to that enemy.")
                .WithInfo(117, 3, Artist.Tropa_Entertainment);
            addAttachment("Round Shield", 0, Sphere.Tactics, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a character.\r\nResponse: After a shadow effect is triggered during combat, exhaust Round Shield to give attached character +2 Defense for this attack.")
                .WithInfo(118, 3, Artist.Sara_Biddle);
            addAlly("Erebor Toymaker", 3, Sphere.Spirit, false, 2, 0, 0, 2)
                .WithTraits("Dwarf.", "Craftsman.")
                .WithText("Response: After you play Erebor Toymaker from your hand, reduce the cost of the next attachment played this phase by 2.")
                .WithFlavor("There were toys the like of which they had never seen before, all beautiful and some obviously magical.\r\n-The Fellowship of the Ring")
                .WithInfo(119, 3, Artist.Ryan_Valle);
            addAttachment("Armor of Erebor", 2, Sphere.Spirit, false)
                .WithTraits("Item.", "Armor.")
                .WithKeywords("Restricted.")
                .WithText("Attach to a Dale or Dwarf character.\r\nAttached character gets +1 Defense and gains sentinel.")
                .WithFlavor("\"We make good armour and keen swords, but we cannot again make mail or blade to match those that were made before the dragon came.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(120, 3, Artist.Alexander_Kozachenko);
            addEvent("The Shirefolk", 0, Sphere.Neutral)
                .WithText("Play only if each of your heroes is a Hobbit.\r\nAction: Reduce your threat by 4.")
                .WithFlavor("\"If more of us valued food and cheer and song above hoarded gold, it would be a merrier world.\"\r\n-Thorin Oakenshield, The Hobbit")
                .WithInfo(121, 3, Artist.Carmen_Cianelli);
        }
    }
}