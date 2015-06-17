using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class FoundationsOfStoneProduct : Product
    {
        public FoundationsOfStoneProduct()
            : base("Foundations of Stone", "MEC13", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Foundations_of_Stone_rulesheet.pdf";

            AddCardSet(CardSet.FoundationsOfStone);
        }
    }
}