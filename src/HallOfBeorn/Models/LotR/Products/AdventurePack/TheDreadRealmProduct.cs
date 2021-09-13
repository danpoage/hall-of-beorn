using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDreadRealmProduct : Product
    {
        public TheDreadRealmProduct()
            : base("The Dread Realm", "MEC44", ImageType.Jpg, new DateTime(2015, 12, 17))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC44.pdf";

            AddCardSet(CardSet.TheDreadRealm);

            AddScenario(Scenario.TheDreadRealm);
        }
    }
}
