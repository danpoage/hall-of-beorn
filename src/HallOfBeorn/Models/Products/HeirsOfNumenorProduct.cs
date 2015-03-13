using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class HeirsOfNumenorProduct : Product
    {
        public HeirsOfNumenorProduct()
            : base("Heirs of Númenor", "MEC17", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Heirs-of-Numenor_rules.pdf";

            CardSets.Add(CardSet.HeirsOfNumenor);
        }
    }
}