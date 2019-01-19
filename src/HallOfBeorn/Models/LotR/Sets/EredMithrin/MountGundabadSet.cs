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
                .WithText("Response: After Bilbo Baggins commits to the quest, choose an enemy in the staging area. Until the end of the phase, Bilbo Baggins gets +X Willpower where X is that enemy's Threat. If the players quest successfully, deal 1 damage to that enemy (2 damage instead if it is guarding a card).")
                .WithInfo(112, 1, Artist.Tropa_Entertainment);

            addAlly("Gaffer Gamgee", 2, Sphere.Lore, true, 1, 1, 0, 1)
                .WithTraits("Hobbit.")
                .WithText("Combat Action: Return Gaffer Gamgee to your hand to choose an enemy with engagement cost higher than your threat. Until the end of the round, that enemy cannot attack you.")
                .WithFlavor("\"Why? Why's none of my business, or yours.\"\r\n-The Fellowship of the Ring")
                .WithInfo(115, 3, Artist.Romana_Kendelic);

            addAttachment("Sting", 0, Sphere.Tactics, true)
                .WithTraits("Artifact.", "Item.", "Weapon.")
                .WithKeywords("Guarded (enemy).", "Restricted.")
                .WithText("Attach to a Hobbit hero.\r\nAttached hero gets +1 Willpower, +1 Attack, and +1 Defense.\r\nResponse: After attached hero is declared as an attacker or defender against an enemy, deal 1 damage to that enemy.")
                .WithInfo(117, 3, Artist.Tropa_Entertainment);

            addEvent("The Shirefolk", 0, Sphere.Neutral)
                .WithText("Play only if each of your heroes is a Hobbit.\r\nAction: Reduce your threat by 4.")
                .WithFlavor("\"If more of us valued food and cheer and song above hoarded gold, it would be a merrier world.\"\r\n-Thorin Oakenshield, The Hobbit")
                .WithInfo(121, 3, Artist.Carmen_Cianelli);
        }
    }
}