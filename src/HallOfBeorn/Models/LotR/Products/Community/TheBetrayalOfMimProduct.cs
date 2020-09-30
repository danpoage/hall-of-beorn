using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheBetrayalOfMimProduct
        : Product
    {
        public TheBetrayalOfMimProduct()
            : base("The Betrayal of Mîm", "FA04", ImageType.Jpg, new DateTime(2016, 9, 9))
        {
            AddCardSet(CardSet.TheBetrayalOfMim);
            AddScenario(new Scenarios.DoomMastered.TheBetrayalOfMimScenario());
        }
    }
}