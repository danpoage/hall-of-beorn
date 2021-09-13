using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class FireInTheNightProduct : Product
    {
        public FireInTheNightProduct()
            : base("Fire in the Night", "MEC68", ImageType.Jpg, new DateTime(2018, 12, 11))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC68.pdf";

            AddCardSet(CardSet.FireInTheNight);

            AddScenario(Scenario.FireInTheNight);
        }
    }
}