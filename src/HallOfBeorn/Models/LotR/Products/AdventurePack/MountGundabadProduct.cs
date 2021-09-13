using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class MountGundabadProduct : Product
    {
        public MountGundabadProduct()
            : base("Mount Gundabad", "MEC70", ImageType.Png, new DateTime(2019, 2, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC70.pdf";

            AddCardSet(CardSet.MountGundabad);

            AddScenario(Scenario.MountGundabad);
        }
    }
}