using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheFortressOfNurnProduct
        : Product
    {
        public TheFortressOfNurnProduct()
            : base("The Fortress of Nurn", "MEC83", ImageType.Jpg, new DateTime(2020, 9, 30))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC83.pdf";

            AddCardSet(CardSet.TheFortressOfNurn);

            AddScenario(new Scenarios.VengeanceOfMordor.TheFortressOfNurnScenario());
        }
    }
}
