using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHuntForGollumProduct : Product
    {
        public TheHuntForGollumProduct()
            : base("The Hunt for Gollum", "MEC02", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-TheHuntForGollum.pdf";

            CardSets.Add(CardSet.TheHuntForGollum);
        }
    }
}