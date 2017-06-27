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

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.FirstAge.HuntingOfTheWolf());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.FirstAge.TheIsleOfWerewolves());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.FirstAge.TheSeatOfMorgoth());
        }
    }
}