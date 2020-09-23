using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class DwarrowdelfNightmareProductGroup : ProductGroup
    {
        public DwarrowdelfNightmareProductGroup()
            : base("Dwarrowdelf Nightmare Decks")
        {
            AddMainProduct(Product.KhazadDumNightmare);
            AddChildProduct(Product.TheRedhornGateNightmare);
            AddChildProduct(Product.RoadToRivendellNightmare);
            AddChildProduct(Product.TheWatcherInTheWaterNightmare);
            AddChildProduct(Product.TheLongDarkNightmare);
            AddChildProduct(Product.FoundationsOfStoneNightmare);
            AddChildProduct(Product.ShadowAndFlameNightmare);
        }
    }
}
