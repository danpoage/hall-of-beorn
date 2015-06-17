using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheDruadanForestProduct : Product
    {
        public TheDruadanForestProduct()
            : base("The Drúadan Forest", "MEC19", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/MEC19-the-druadan-forest-rulesheet.pdf";

            AddCardSet(CardSet.TheDruadanForest);
        }
    }
}