using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class AssaultOnOsgiliathProduct : Product
    {
        public AssaultOnOsgiliathProduct()
            : base("Assault on Osgiliath", "MEC21", ImageType.Png, new DateTime(2013, 8, 9))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC21.pdf";

            AddCardSet(CardSet.AssaultOnOsgiliath);

            AddScenario(Scenario.AssaultOnOsgiliath);
        }
    }
}