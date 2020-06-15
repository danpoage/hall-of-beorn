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
            AddProduct(Product.ChallengeOfTheWainriders);
            AddProduct(Product.UnderTheAshMountains);
            AddProduct(Product.TheLandOfSorrow);
            AddProduct(Product.TheFortressOfNurn);
            AddProduct(Product.WrathAndRuinPreorderPromotion);
            AddProduct(Product.TheCityOfUlfastPreorderPromotion);
            AddProduct(Product.ChallengeOfTheWainridersPreorderPromotion);
            AddProduct(Product.UnderTheAshMountainsPreorderPromotion);
        }
    }
}
