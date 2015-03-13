using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class CoreSetProduct : Product
    {
        public CoreSetProduct()
            : base("Core Set", "MEC01", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/LOTR_LCG_Core_rules_eng_Lo-Res.pdf";

            CardSets.Add(CardSet.CoreSet);
        }
    }
}