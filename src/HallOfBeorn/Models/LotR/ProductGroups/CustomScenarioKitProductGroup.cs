using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class CustomScenarioKitProductGroup
        : ProductGroup
    {
        public CustomScenarioKitProductGroup()
            : base("Custom Scenario Kits")
        {
            AddProduct(Product.TheWizardsQuest);
            AddProduct(Product.TheWoodlandRealm);
            AddProduct(Product.TheMinesOfMoria);
            AddProduct(Product.TheMinesOfMoriaPreorderPromotion);
            AddProduct(Product.EscapeFromKhazadDum);
            AddProduct(Product.EscapeFromKhazadDumPreorderPromotion);
        }
    }
}
