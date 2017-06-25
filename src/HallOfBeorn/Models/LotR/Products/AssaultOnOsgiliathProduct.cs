using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class AssaultOnOsgiliathProduct : Product
    {
        public AssaultOnOsgiliathProduct()
            : base("Assault on Osgiliath", "MEC21", ImageType.Png, new DateTime(2013, 8, 9))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/rulesheet-assault-on-osgiliath.pdf";

            AddCardSet(CardSet.AssaultOnOsgiliath);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow.AssaultOnOsgiliath());
        }
    }
}