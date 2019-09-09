using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheMountainOfFireProduct : Product
    {
        public TheMountainOfFireProduct()
            : base("The Mountain of Fire", "MEC62", ImageType.Jpg, new DateTime(2017, 10, 1))
        {
            AddCardSet(CardSet.TheMountainOfFire);

            AddScenario(new Scenarios.TheLordOfTheRings.TheTowerOfCirithUngolScenario());
            AddScenario(new Scenarios.TheLordOfTheRings.TheBlackGateOpensScenario());
            AddScenario(new Scenarios.TheLordOfTheRings.MountDoomScenario());
        }
    }
}