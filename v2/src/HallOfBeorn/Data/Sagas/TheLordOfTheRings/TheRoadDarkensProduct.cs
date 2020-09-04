using System;
using System.Collections.Generic;
using System.Text;

namespace HallOfBeorn.Data.Sagas.TheLordOfTheRings
{
    public static class TheRoadDarkensProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.TheRoadDarkens, ProductCodes.TheRoadDarkens, new DateTime(2014, 10, 3));

            return builder;
        }
    }
}
