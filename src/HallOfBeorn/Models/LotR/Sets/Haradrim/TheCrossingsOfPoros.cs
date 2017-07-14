using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets.Haradrim
{
    public class TheCrossingsOfPoros : CardSet
    {
        private const string setName = "The Crossings of Poros";

        protected override void Initialize()
        {
            Name = "The Crossings of Poros";
            Abbreviation = "CoP";
            Number = 48;
            SetType = Models.SetType.Adventure_Pack;
            Cycle = "Haradrim";

            addCard(LotRCard.Hero("Quickbeam", string.Empty, Sphere.Tactics, 12, 2, 4, 1, 5)
                .WithText("Cannot have restricted attachments.\r\nAction: Deal 2 damage to Quickbeam to ready him. (Limit once per phase.)")
                .WithFlavor("\"...he can move like a wind when he is roused.\"\r\n-Pippin, The Two Towers")
                .WithInfo(135, 1, Artist.Guillaume_Ducos));
            addCard(LotRCard.Ally("Halfast Gamgee", Sphere.Leadership, 3, 2, 1, 0, 2)
                .WithUnique()
                .WithTraits("Hobbit.")
                .WithText("Reduce the cost to play Halfast Gamgee by 1 for each side quest in the victory display.\r\nResponse: After Halfast Gamgee enters play, add 1 resource to a hero's resource pool.")
                .WithFlavor("\"He works for Mr. Boffin at Overhill and goes up to the Northfarthing for the hunting.\"\r\n-Sam Gamgee, The Fellowship of the Ring")
                .WithInfo(136, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Event("Bulwark of the West", string.Empty, Sphere.Leadership, 0)
                .WithText("Action: Discard an ally you control to choose and discard a Condition attachment.")
                .WithFlavor("\"By our valour the wildfolk of the East are still restrained, and the terror of Morgul kept at bay; and thus alone are peace and freedom maintained in the lads behind us...\r\n-Boromir, The Fellowship of the Ring")
                .WithInfo(137, 3, Artist.Stanislav_Dikolenko));
            addCard(LotRCard.Ally("Beorning Guardian", Sphere.Tactics, 3, 0, 3, 1, 3)
                .WithTraits("Beorning.")
                .WithText("Response: After ~Beorning ~Guardian participates in an attack that destroys an enemy, discard ~Beorning ~Guardian to place X progress on a location, where X is the destroyed enemy's printed Threat.")
                .WithFlavor("\"...if it were not for the Beornings, the passage from Dale to Rivendell would long ago have become impossible.\"\r\n-Glóin, The Fellowship of the Ring")
                .WithInfo(138, 3, Artist.Marius_Bota));
            addCard(LotRCard.Attachment("Followed", string.Empty, Sphere.Tactics, 1)
                .WithTraits("Condition.", "Trap.")
                .WithText("Play into your play area unattached.\r\nWhile unattached, attach to the next eligible enemy that engages you.\r\nWhile attached enemy is engaged with you, reduce the total Threat in the staging area by X, where X is attached enemy's printed Threat.")
                .WithInfo(139, 3, Artist.Unknown));
            addCard(LotRCard.Event("Flight to the Sea", string.Empty, Sphere.Spirit, 2)
                .WithText("Play only if you control a Noldor or Silvan hero.\r\nPlanning Action: Shuffle a set aside ~Wind from the ~Sea into the encounter deck. Then, remove Flight to the Sea from the game.")
                .WithFlavor("\"...they may pass to the Sea unhindered and leave the Middle-earth forever.\"\r\n-Haldir, The Two Towers")
                .WithInfo(140, 3, Artist.Alexander_Gustafson));
            addCard(LotRCard.Ally("Emyn Arnen Ranger", Sphere.Lore, 2, 0, 1, 1, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After Emyn Arnen ~Ranger commits to the quest, choose an enemy with a Trap attachment. Until the end of the phase, Emyn Arnen ~Ranger gets +X Willpower, where X is the chosen enemy's printed Threat.")
                .WithInfo(141, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Event("The Dam Bursts", string.Empty, Sphere.Lore, 2)
                .WithText("Play only if you control a unique character with the Ent trait and another unique character with the Hobbit trait.\r\nAction: Ready each damaged Ent character you control.")
                .WithInfo(142, 3, Artist.DinoDrawing));
            addCard(LotRCard.Attachment("Magic Ring", string.Empty, Sphere.Neutral, 2)
                .WithTraits("Artificat.", "Item.", "Ring.")
                .WithText("Attach to a hero. Limit 1 per hero and 1 per deck.\r\nAction: Exhaust Magic Ring and raise your threat by 1 to (choose 1): heal 1 damage from attached hero, add 1 resource to attached hero's pool, or ready attached hero.")
                .WithFlavor("\"In Eregion long ago many Elven-rings were made, magic rings as you call them, and they were, of course, of various kinds...\"\r\n-Gandalf, The Fellowship of the Ring")
                .WithInfo(143, 3, Artist.Lucas_Durham));
            addCard(LotRCard.Event("Wind from the Sea", string.Empty, Sphere.Neutral, byte.MaxValue)
                .WithKeywords("Encounter.")
                .WithText("When Revealed: Ready each hero committed to the quest and remove Wind from the Sea from the game.")
                .WithShadow("Shadow: Ready the defending character.")
                .WithInfo(144, 3, Artist.Davis_Engel));
        }
    }
}