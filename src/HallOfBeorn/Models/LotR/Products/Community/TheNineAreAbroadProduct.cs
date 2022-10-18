using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheNineAreAbroadProduct
        : Product
    {
        public TheNineAreAbroadProduct()
            : base("The Nine are Abroad", "ALEP09", ImageType.Png, new DateTime(2022, 10, 18))
        {
            AddCardSet(CardSet.TheNineAreAbroad);
            AddScenario(Scenario.TheNineAreAbroad);
        }
    }
}