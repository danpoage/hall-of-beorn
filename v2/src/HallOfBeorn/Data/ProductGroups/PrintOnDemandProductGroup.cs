using System;

using HallOfBeorn.Data.Pods;

namespace HallOfBeorn.Data.ProductGroups
{
    public static class PrintOnDemandProductGroup
    {
        public static ProductGroupBuilder Builder()
        {
            var builder = new ProductGroupBuilder(ProductGroupNames.GenConAndFellowship);

            builder.Product(TheMassingAtOsgiliathProduct.Builder());

            return builder;
        }
    }
}
