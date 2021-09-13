using System;

namespace HallOfBeorn.Models.LotR.Products.GenCon
{
    public class TheMassingAtOsgiliathProduct : Product
    {
        public TheMassingAtOsgiliathProduct()
            : base("The Massing at Osgiliath GenCon 2011", "MEC15", ImageType.Jpg, new DateTime(2011, 9, 21))
        {
            AddCardSet(CardSet.TheMassingAtOsgiliath);

            AddScenario(Scenario.TheMassingAtOsgiliath);
        }
    }
}