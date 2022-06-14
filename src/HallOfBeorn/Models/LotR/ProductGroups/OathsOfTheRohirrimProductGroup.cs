namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class OathsOfTheRohirrimProductGroup
        : ProductGroup
    {
        public OathsOfTheRohirrimProductGroup()
            : base("Oaths of the Rohirrim Cycle")
        {
            AddMainProduct(Product.ChildrenOfEorl);

            AddChildProduct(Product.TheAldburgPlot);
            AddChildProduct(Product.FireOnTheEastemnet);
            AddChildProduct(Product.TheGapOfRohan);
            AddChildProduct(Product.TheGlitteringCaves);
            AddChildProduct(Product.MusteringOfTheRohirrim);
        }
    }
}