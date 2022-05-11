using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheHobbitOverHillAndUnderHillProduct : Product
    {
        public TheHobbitOverHillAndUnderHillProduct()
            : base("The Hobbit: Over Hill and Under Hill", "MEC16", ImageType.Png, new DateTime(2012, 8, 17))
        {
            AddCardSet(CardSet.TheHobbitOverHillAndUnderHill);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC16.pdf";
            HasCampaignMode = true;

            AddScenario(Scenario.WeMustAwayEreBreakOfDay);
            AddScenario(Scenario.OverTheMistyMountainsGrim);
            AddScenario(Scenario.DungeonsDeepAndCavernsDim);
        }
    }
}