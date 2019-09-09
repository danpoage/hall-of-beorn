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
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/ec/70/ec70c2ad-107d-4685-8292-92f6a9c5251b/mec52_rules.pdf";

            AddCardSet(CardSet.AStormOnCobasHaven);

            AddScenario(new Scenarios.DreamChaser.AStormOnCobasHavenScenario());
        }
    }
}