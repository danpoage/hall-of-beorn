using System;

namespace HallOfBeorn.Models.LotR.Products.ScenarioPack
{
    public class TheDarkOfMirkwoodProduct
        : Product
    {
        public TheDarkOfMirkwoodProduct()
            : base("The Dark of Mirkwood", "MEC102", ImageType.Png, new DateTime(2021, 12, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC102.pdf";
            PrintAndPlayFile = "dark_of_mirkwood_campaign_cards.pdf";
            HasCampaignMode = true;

            AddCardSet(CardSet.TheDarkOfMirkwood);

            AddScenario(Scenario.TheOathCampaign);
            AddScenario(Scenario.TheCavesOfNibinDumCampaign);
        }
    }
}