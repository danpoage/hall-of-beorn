using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class VengeanceOfMordorProductGroup : ProductGroup
    {
        public VengeanceOfMordorProductGroup()
            : base("Vengeance of Mordor Cycle")
        {
            AddMainProduct(Product.AShadowInTheEast);
            AddChildProduct(Product.WrathAndRuin);
            AddChildProduct(Product.TheCityOfUlfast);
            AddChildProduct(Product.ChallengeOfTheWainriders);
            AddChildProduct(Product.UnderTheAshMountains);
            AddChildProduct(Product.TheLandOfSorrow);
            AddChildProduct(Product.TheFortressOfNurn);
            AddChildProduct(Product.WrathAndRuinPreorderPromotion);
            AddChildProduct(Product.TheCityOfUlfastPreorderPromotion);
            AddChildProduct(Product.ChallengeOfTheWainridersPreorderPromotion);
            AddChildProduct(Product.UnderTheAshMountainsPreorderPromotion);
            AddChildProduct(Product.TheLandOfSorrowPreorderPromotion);
            AddChildProduct(Product.TheFortressOfNurnPreorderPromotion);
        }
    }
}
