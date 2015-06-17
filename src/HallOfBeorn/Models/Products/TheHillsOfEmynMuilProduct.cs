using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHillsOfEmynMuilProduct : Product
    {
        public TheHillsOfEmynMuilProduct()
            : base("The Hills of Emyn Muil", "MEC05", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/The_Hills_of_Emyn_Muil_rulesheet.pdf";

            AddCardSet(CardSet.TheHillsOfEmynMuil);
        }
    }
}