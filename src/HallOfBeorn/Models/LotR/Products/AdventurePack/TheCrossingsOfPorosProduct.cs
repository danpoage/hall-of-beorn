using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheCrossingsOfPorosProduct : Product
    {
        public TheCrossingsOfPorosProduct()
            : base("The Crossings of Poros", "MEC61", ImageType.Png, new DateTime(2018, 2, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC61.pdf";
            
            AddCardSet(CardSet.TheCrossingsOfPoros);

            AddScenario(Scenario.TheCrossingsOfPoros);
        }
    }
}