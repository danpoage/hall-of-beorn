using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class AStormOnCobasHavenProduct : Product
    {
        public AStormOnCobasHavenProduct()
            : base("A Storm on Cobas Haven", "MEC52", ImageType.Jpg, new DateTime(2016, 9, 15))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC52.pdf";

            AddCardSet(CardSet.AStormOnCobasHaven);

            AddScenario(Scenario.AStormOnCobasHaven);
        }
    }
}