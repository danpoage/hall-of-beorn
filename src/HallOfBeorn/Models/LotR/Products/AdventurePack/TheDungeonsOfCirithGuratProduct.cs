using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDungeonsOfCirithGuratProduct : Product
    {
        public TheDungeonsOfCirithGuratProduct()
            : base("The Dungeons of Cirith Gurat", "MEC60", ImageType.Png, new DateTime(2018, 1, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC60.pdf";

            AddCardSet(CardSet.TheDungeonsOfCirithGurat);

            AddScenario(Scenario.TheDungeonsOfCirithGurat);
        }
    }
}