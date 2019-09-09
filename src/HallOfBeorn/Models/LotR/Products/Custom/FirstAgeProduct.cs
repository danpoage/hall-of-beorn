using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Custom
{
    public class FirstAgeProduct : Product
    {
        public FirstAgeProduct()
            : base("First Age", "FA01", ImageType.Jpg, new DateTime(2014, 6, 13))
        {
            AddCardSet(CardSet.FirstAge);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.FirstAge.HuntingOfTheWolfScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.FirstAge.TheIsleOfWerewolvesScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.FirstAge.TheSeatOfMorgothScenario());
        }
    }
}