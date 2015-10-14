using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class FirstAgeProduct : Product
    {
        public FirstAgeProduct()
            : base("First Age", "FA01", ImageType.Jpg)
        {
            AddCardSet(CardSet.FirstAge);

            AddScenario(new HallOfBeorn.Models.Scenarios.HuntingOfTheWolf());
            AddScenario(new HallOfBeorn.Models.Scenarios.TheIsleOfWerewolves());
            AddScenario(new HallOfBeorn.Models.Scenarios.TheSeatOfMorgoth());
        }
    }
}