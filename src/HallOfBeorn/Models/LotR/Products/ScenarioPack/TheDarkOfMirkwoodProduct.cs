using System;

namespace HallOfBeorn.Models.LotR.Products.ScenarioPack
{
    public class TheDarkOfMirkwoodProduct
        : Product
    {
        public TheDarkOfMirkwoodProduct()
            : base("The Dark of Mirkwood", "MEC102", ImageType.Png, new DateTime(2021, 12, 1))
        {
            AddCardSet(CardSet.TheDarkOfMirkwood);

            AddScenario(Scenario.TheOathCampaign);
            AddScenario(Scenario.TheCavesOfNibinDumCampaign);
        }
    }
}