using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class ChildrenOfEorlProduct
        : Product
    {
        public ChildrenOfEorlProduct()
            : base("Children of Eorl", "ALEP01", ImageType.Png, new DateTime(2021, 3, 22))
        {
            AddCardSet(CardSet.ChildrenOfEorl);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP01.pdf";

            AddScenario(Scenario.AmbushAtErelas);
            AddScenario(Scenario.TheBattleForTheBeacon);
            AddScenario(Scenario.TheHorseLordsIre);
        }
    }
}