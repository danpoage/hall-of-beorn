using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Sets
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

            addCard(LotRCard.Attachment("Followed", string.Empty, Sphere.Tactics, 1)
                .WithTraits("Condition.", "Trap.")
                .WithText("Play into your play area unattached.\r\nWhile unattached, attach to the next eligible enemy that engages you.\r\nWhile attached enemy is engaged with you, reduce the total Threat in the staging area by X, where X is attached enemy's printed Threat.")
                .WithInfo(138, 3, Artist.Unknown));
            addCard(LotRCard.Event("Flight to the Sea", string.Empty, Sphere.Spirit, 2)
                .WithText("Play only if you control a Noldor or Silvan hero.\r\nPlanning Action: Shuffle a set aside ~Wind from the ~Sea into the encounter deck. Then, remove Flight to the Sea from the game.")
                .WithFlavor("\"...they may pass to the Sea unhindered and leave the Middle-earth forever.\"\r\n-Haldir, The Two Towers")
                .WithInfo(140, 3, Artist.Alexander_Gustafson));
            addCard(LotRCard.Ally("Emyn Arnen Ranger", Sphere.Lore, 2, 0, 1, 1, 2)
                .WithTraits("Gondor.", "Ranger.")
                .WithText("Response: After Emyn Arnen ~Ranger commits to the quest, choose an enemy with a Trap attachment. Until the end of the phase, Emyn Arnen ~Ranger gets +X Willpower, where X is the chosen enemy's printed Threat.")
                .WithInfo(141, 3, Artist.Aleksander_Karcz));
            addCard(LotRCard.Event("Wind from the Sea", string.Empty, Sphere.Neutral, byte.MaxValue)
                .WithKeywords("Encounter.")
                .WithText("When Revealed: Ready each hero committed to the quest and remove Wind from the Sea from the game.")
                .WithShadow("Shadow: Ready the defending character.")
                .WithInfo(144, 3, Artist.Davis_Engel));
        }
    }
}