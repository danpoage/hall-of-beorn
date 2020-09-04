using System;
using System.Collections.Generic;
using System.Text;

using HallOfBeorn.Data.Sagas.TheLordOfTheRings;

namespace HallOfBeorn.Data.ProductGroups
{
    public static class TheLordOfTheRingsProductGroup
    {
        public static ProductGroupBuilder Builder()
        {
            var builder = new ProductGroupBuilder(ProductGroupNames.TheLordOfTheRingsSaga);

            builder.Product(TheBlackRidersProduct.Builder());
            builder.Product(TheRoadDarkensProduct.Builder());

            return builder;
        }
    }
}
