using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class WrathAndRuinProduct : Product
    {
        public WrathAndRuinProduct()
            : base("Wrath and Ruin", "MEC78", ImageType.Jpg, new DateTime(2019, 11, 12))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC78.pdf";

            AddCardSet(CardSet.WrathAndRuin);

            AddScenario(Scenario.WrathAndRuin);
        }
    }
}