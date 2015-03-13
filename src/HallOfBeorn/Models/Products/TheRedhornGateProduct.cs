using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheRedhornGateProduct : Product
    {
        public TheRedhornGateProduct()
            : base("The Redhorn Gate", "MEC09", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/The-Redhorn-Gate-rulesheet.pdf";

            CardSets.Add(CardSet.TheRedhornGate);
        }
    }
}