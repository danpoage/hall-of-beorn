using System;

namespace HallOfBeorn.Models.LotR.Products.Fellowship
{
    public class FogOnTheBarrowDownsProduct : Product
    {
        public FogOnTheBarrowDownsProduct()
            : base("Fog on the Barrow-downs", "MEC36", ImageType.Jpg, new DateTime(2015, 1, 15))
        {
            AddCardSet(CardSet.FogOnTheBarrowDowns);

            AddScenario(Scenario.FogOnTheBarrowDowns);
        }
    }
}