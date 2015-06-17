using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AssaultOnOsgiliathProduct : Product
    {
        public AssaultOnOsgiliathProduct()
            : base("Assault on Osgiliath", "MEC21", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-assault-on-osgiliath.pdf";

            AddCardSet(CardSet.AssaultOnOsgiliath);
        }
    }
}