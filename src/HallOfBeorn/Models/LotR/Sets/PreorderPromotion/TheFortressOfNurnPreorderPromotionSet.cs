using System;

namespace HallOfBeorn.Models.LotR.Sets.PreorderPromotion
{
    public class TheFortressOfNurnPreorderPromotionSet
        : CardSet
    {
        public const string setName = "The Fortress of Nurn Preorder Promotion";

        protected override void Initialize()
        {
            Name = setName;
            Abbreviation = "TFoN-PRM";
            Number = 6;
            SetType = Models.SetType.Preorder_Promotion;
            Cycle = "Vengeance of Mordor";

            addHero("Aragorn", 12, Sphere.Spirit, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Ranger.", "Scout.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("Action: Exhaust Aragorn to choose a location in the staging area. Until the end of the phase, that location gets -X Threat, where X is Aragorn's Willpower. If this effect reduces the location's Threat to 0, place 1 progress on it. (Limit once per round.)")
                .WithInfo(137, 1, Artist.Aleksander_Karcz);
            addAlly("Misty Mountain Journeyman", 1, Sphere.Spirit, false, 2, 0, 0, 1)
                .WithTraits("Dúnedain.", "Scout.")
                .WithTextLine("You cannot play Misty Mountain Journeyman from your hand unless you are engaged with an enemy.")
                .WithFlavorLine("Rangers passed at times beyond the hills, but they were few and did not stay.")
                .WithFlavorLine("-The Fellowship of the Ring")
                .WithInfo(144, 1, Artist.Aleksander_Karcz);
            addAttachment("Thorongil", 3, Sphere.Neutral, true)
                .WithTraits("Title.")
                .WithTextLine("Attach to a non-Fellowship, non-Baggins hero you control.")
                .WithTextLine("Response: After you attach Thorongil to a hero, search your collection for a different non-Fellowship, non-Baggins version of that hero and attach it to Thorongil. While Thorongil is in play, attached hero gains the game text and resource icon of the attached hero card. If Thorongil leaves play, remove the hero card attached to it from the game.")
                .WithInfo(146, 1, Artist.Chris_Grun);
        }
    }
}
