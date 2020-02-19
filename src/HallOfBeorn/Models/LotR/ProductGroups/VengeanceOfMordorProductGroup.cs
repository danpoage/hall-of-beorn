using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class VengeanceOfMordorProductGroup : ProductGroup
    {
        public VengeanceOfMordorProductGroup()
            : base("Vengeance of Mordor Cycle")
        {
            MainProduct = Product.AShadowInTheEast;
            AddProduct(Product.WrathAndRuin);
            AddProduct(Product.TheCityOfUlfast);
            AddProduct(Product.TheWainridersChallenge);
            AddProduct(Product.UnderTheAshMountains);
            AddProduct(Product.TheLandOfSorrow);
        }
    }
}