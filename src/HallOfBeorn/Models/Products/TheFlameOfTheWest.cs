using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheFlameOfTheWest : Product
    {
        public TheFlameOfTheWest()
            : base("The Flame of the West", "MEC54", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheFlameOfTheWest);

            AddScenario(new HallOfBeorn.Models.Scenarios.ThePassingOfTheGreyCompany());
        }
    }
}