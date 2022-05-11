using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheBlackRidersProduct : Product
    {
        public TheBlackRidersProduct()
            : base("The Black Riders", "MEC32", ImageType.Png, new DateTime(2013, 9, 13))
        {
            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=161661708X&asins=161661708X&linkId=3P5A5IZ3NFTJMWG2&show_border=true&link_opens_in_new_window=true'></iframe>";
            
            AddCardSet(CardSet.TheBlackRiders);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC32.pdf";
            HasCampaignMode = true;

            AddScenario(Scenario.AShadowOfThePast);
            AddScenario(Scenario.AKnifeInTheDark);
            AddScenario(Scenario.FlightToTheFord);
        }
    }
}