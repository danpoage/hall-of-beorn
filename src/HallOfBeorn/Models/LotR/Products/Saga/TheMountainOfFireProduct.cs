using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheMountainOfFireProduct : Product
    {
        public TheMountainOfFireProduct()
            : base("The Mountain of Fire", "MEC62", ImageType.Jpg, new DateTime(2017, 10, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC62.pdf";

            AddCardSet(CardSet.TheMountainOfFire);

            AddScenario(new Scenarios.TheLordOfTheRings.TheTowerOfCirithUngolScenario());
            AddScenario(new Scenarios.TheLordOfTheRings.TheBlackGateOpensScenario());
            AddScenario(new Scenarios.TheLordOfTheRings.MountDoomScenario());
        }
    }
}