using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheLordOfTheRingsSagaNightmareProductGroup
        : ProductGroup
    {
        public TheLordOfTheRingsSagaNightmareProductGroup()
            : base("The Lord of the Rings Saga Nightmare Decks")
        {
            AddChildProduct(Product.TheBlackRidersNightmare);
            AddChildProduct(Product.TheRoadDarkensNightmare);
            AddChildProduct(Product.TheTreasonOfSarumanNightmare);
            AddChildProduct(Product.TheLandOfShadowNightmare);
        }
    }
}