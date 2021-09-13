using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class AcrossTheEttenmoorsProduct : Product
    {
        public AcrossTheEttenmoorsProduct()
            : base("Across the Ettenmoors", "MEC41", ImageType.Jpg, new DateTime(2015, 9, 3))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC41.pdf";

            AddCardSet(CardSet.AcrossTheEttenmoors);

            AddScenario(Scenario.AcrossTheEttenmoors);
        }
    }
}