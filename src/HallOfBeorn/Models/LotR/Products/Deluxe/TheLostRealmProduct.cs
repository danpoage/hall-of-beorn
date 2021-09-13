using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheLostRealmProduct : Product
    {
        public TheLostRealmProduct()
            : base("The Lost Realm", "MEC38", ImageType.Jpg, new DateTime(2015, 4, 3))
        {
            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1633440397&asins=1633440397&linkId=MRZSHYNQUJMLE3MP&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.TheLostRealm);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC38.pdf";

            AddScenario(Scenario.IntrudersInChetwood);
            AddScenario(Scenario.TheWeatherHills);
            AddScenario(Scenario.DeadmensDike);
        }
    }
}