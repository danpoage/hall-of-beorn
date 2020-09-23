using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class DreamChaserNightmareProductGroup
        : ProductGroup
    {
        public DreamChaserNightmareProductGroup()
            : base("Dream-chaser Nightmare Decks")
        {
            AddMainProduct(Product.TheGreyHavensNightmare);
            AddChildProduct(Product.FlightOfTheStormcallerNightmare);
            AddChildProduct(Product.TheThingInTheDepthsNightmare);
            AddChildProduct(Product.TempleOfTheDeceivedNightmare);
            AddChildProduct(Product.TheDrownedRuinsNightmare);
            AddChildProduct(Product.AStormOnCobasHavenNightmare);
            AddChildProduct(Product.TheCityOfCorsairsNightmare);
        }
    }
}
