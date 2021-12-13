using System;

namespace HallOfBeorn.Models.LotR.Products.StarterDeck
{
    public class RidersOfRohanProduct
        : Product
    {
        public RidersOfRohanProduct()
            : base("Riders of Rohan", "MEC106", ImageType.Png, new DateTime(2022, 1, 28))
        {
            AddCardSet(CardSet.RidersOfRohan);
        }
    }
}