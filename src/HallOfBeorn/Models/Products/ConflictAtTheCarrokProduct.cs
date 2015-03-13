using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class ConflictAtTheCarrokProduct : Product
    {
        public ConflictAtTheCarrokProduct()
            : base("Conflict at the Carrock", "MEC03", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-ConflictAtTheCarrock.pdf";

            CardSets.Add(CardSet.ConflictAtTheCarrock);
        }
    }
}