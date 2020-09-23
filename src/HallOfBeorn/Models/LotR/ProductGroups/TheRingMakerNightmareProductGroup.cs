using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class TheRingMakerNightmareProductGroup
        : ProductGroup
    {
        public TheRingMakerNightmareProductGroup()
            : base("The Ring-maker Nightmare Decks")
        {
            AddMainProduct(Product.TheVoiceOfIsengardNightmare);
            AddChildProduct(Product.TheDunlandTrapNightmare);
            AddChildProduct(Product.TheThreeTrialsNightmare);
            AddChildProduct(Product.TroubleInTharbadNightmare);
            AddChildProduct(Product.TheNinInEilphNightmare);
            AddChildProduct(Product.CelebrimborsSecretNightmare);
            AddChildProduct(Product.TheAntleredCrownNightmare);
        }
    }
}