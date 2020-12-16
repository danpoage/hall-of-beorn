namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class OathsOfTheRohirrimProductGroup
        : ProductGroup
    {
        public OathsOfTheRohirrimProductGroup()
            : base("Oaths of the Rohirrim Cycle")
        {
            AddMainProduct(Product.ChildrenOfEorl);
        }
    }
}