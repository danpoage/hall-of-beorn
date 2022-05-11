using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheRoadDarkensProduct : Product
    {
        public TheRoadDarkensProduct()
            : base("The Road Darkens", "MEC34", ImageType.Png, new DateTime(2014, 10, 3))
        {
            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=161661885X&asins=161661885X&linkId=MUVU2T2UHL7FOB34&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.TheRoadDarkens);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC34.pdf";
            HasCampaignMode = true;

            AddScenario(Scenario.TheRingGoesSouth);
            AddScenario(Scenario.JourneyInTheDark);
            AddScenario(Scenario.BreakingOfTheFellowship);
        }
    }
}