using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheBlackRidersProduct : Product
    {
        public TheBlackRidersProduct()
            : base("The Black Riders", "MEC32", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/the-black-riders-rulesheet.pdf";

            AddCardSet(CardSet.TheBlackRiders);
        }
    }
}