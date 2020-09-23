using System;

namespace HallOfBeorn.Models.LotR.ProductGroups
{
    public class AngmarAwakenedNightmareProductGroup
        : ProductGroup
    {
        public AngmarAwakenedNightmareProductGroup()
            : base("Angmar Awakened Nightmare Decks")
        {
            AddMainProduct(Product.TheLostRealmNightmare);
            AddChildProduct(Product.TheWastesOfEriadorNightmare);
            AddChildProduct(Product.EscapeFromMountGramNightmare);
            AddChildProduct(Product.AcrossTheEttenmoorsNightmare);
            AddChildProduct(Product.TheTreacheryOfRhudaurNightmare);
            AddChildProduct(Product.TheBattleOfCarnDumNightmare);
            AddChildProduct(Product.TheDreadRealmNightmare);
        }
    }
}
