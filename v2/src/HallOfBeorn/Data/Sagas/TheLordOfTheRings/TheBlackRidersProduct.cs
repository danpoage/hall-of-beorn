using System;
using System.Collections.Generic;
using System.Text;

namespace HallOfBeorn.Data.Sagas.TheLordOfTheRings
{
    public static class TheBlackRidersProduct
    {
        public static ProductBuilder Builder()
        {
            var builder = new ProductBuilder(ProductNames.TheBlackRiders, ProductCodes.TheBlackRiders, new DateTime(2013, 9, 13));

            return builder;
        }
    }
}
