using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class CustomScenarioKitProductGroup
        : ProductGroup
    {
        public CustomScenarioKitProductGroup()
            : base("Custom Scenario Kits")
        {
            AddChildProduct(Product.TheWizardsQuest);
            AddChildProduct(Product.TheWoodlandRealm);
            AddChildProduct(Product.TheMinesOfMoria);
            AddChildProduct(Product.TheMinesOfMoriaPreorderPromotion);
            AddChildProduct(Product.EscapeFromKhazadDum);
            AddChildProduct(Product.EscapeFromKhazadDumPreorderPromotion);
        }
    }
}
