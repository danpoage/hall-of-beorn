using System;
using System.Collections.Generic;
using System.Text;
using HallOfBeorn.Models;

namespace HallOfBeorn.Data.CardSets.Core
{
    public static class CoreSet
    {
        public static CardSetBuilder Create(Product product)
        {
            var builder = new CardSetBuilder(product, "Core Set", "Core", 1, SetType.Core);

            builder.addHero("Aragorn", 12, Sphere.Leadership, 2, 3, 2, 5)
                .WithTraits("Dúnedain.", "Noble.", "Ranger.")
                .WithKeywords("Sentinel.")
                .WithTextLine("Sentinel.")
                .WithTextLine("");

            return builder;
        }
    }
}
