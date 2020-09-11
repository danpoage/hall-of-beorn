using HallOfBeorn.Data.Core;
using HallOfBeorn.Data.Cycles.ShadowsOfMirkwood;

namespace HallOfBeorn.Data.ProductGroups
{
    public static class CoreProductGroup
    {
        public static ProductGroupBuilder Builder()
        {
            var builder = new ProductGroupBuilder(ProductGroupNames.ShadowsOfMirkwoodCycle);

            builder.Product(CoreSetProduct.Builder());

            var cycle = builder.Cycle(CycleNames.ShadowsOfMirkwood);

            cycle.AdventurePack(TheHuntForGollumProduct.Builder());

            return builder;
        }
    }
}
