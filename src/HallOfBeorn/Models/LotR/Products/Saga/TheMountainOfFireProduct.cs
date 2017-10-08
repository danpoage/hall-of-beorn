using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheMountainOfFireProduct : Product
    {
        public TheMountainOfFireProduct()
            : base("The Mountain of Fire", "MEC62", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheMountainOfFire);

            AddScenario(new Scenarios.TheLordOfTheRings.TheTowerOfCirithUngol());
            AddScenario(new Scenarios.TheLordOfTheRings.TheBlackGateOpens());
            AddScenario(new Scenarios.TheLordOfTheRings.MountDoom());
        }
    }
}