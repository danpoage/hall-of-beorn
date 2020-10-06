using System;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class TheLandOfSorrowPreorderPromotionSet
        : CardSet
    {
        public const string setName = "The Land of Sorrow Preorder Promotion";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TLoSo-PRM";
            Number = 5;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Vengeance of Mordor";

            addHero("Gwaihir", 13, Sphere.Tactics, 2, 4, 3, 4)
                .WithTraits("Creature.", "Eagle.")
                .WithKeywords("Ranged.", "Sentinel.")
                .WithTextLine("Ranged. Sentinel.")
                .WithTextLine("Cannot have restricted attachments. Gwaihir does not ready during the refresh phase.")
                .WithTextLine("Response: After an Eagle ally enters or leaves play, ready Gwaihir. (Limit once per phase.)")
                .WithInfo(108, 1, Artist.Carlos_Palma_Cruchaga);
            addAttachment("Song of Healing", 0, Sphere.Lore, false)
                .WithTraits("Song.")
                .WithTextLine("Attach to a hero. Limit 1 per hero.")
                .WithTextLine("Action: Discard 1 card from your hand to heal 1 damage from attached hero. Any player may trigger this effect.")
                .WithFlavorLine("...behind him stood Galadriel, tall and white: a circlet of golden flowers was in her hair, and in her hand she held a hard, and she sang.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(112, 1, Artist.Magali_Villeneuve);
            addAlly("Eagle Emissary", 2, Sphere.Tactics, false, 2, 1, 0, 2)
                .WithTraits("Creature.", "Eagle.")
                .WithTextLine("Cannot have restricted attachments.")
                .WithTextLine("Forced: After ~Eagle Emissary quests successfully, pay 1 Tactics resource or discard it from play.")
                .WithFlavorLine("...and out of the East there came a great Eagle flying, and he bore tidings beyond hope from The Lords of the West...")
                .WithFlavorLine("-The Return of the King")
                .WithInfo(113, 1, Artist.Carlos_Palma_Cruchaga);
        }
    }
}
