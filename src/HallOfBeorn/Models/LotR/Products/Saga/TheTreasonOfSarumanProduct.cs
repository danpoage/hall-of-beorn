using System;

namespace HallOfBeorn.Models.LotR.Products.Saga
{
    public class TheTreasonOfSarumanProduct : Product
    {
        public TheTreasonOfSarumanProduct()
            : base("The Treason of Saruman", "MEC45", ImageType.Jpg, new DateTime(2015, 4, 23))
        {
            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=163344029X&asins=163344029X&linkId=747YBN6H6J56QBIX&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.TheTreasonOfSaruman);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC45.pdf";

            AddScenario(Scenario.TheUrukHai);
            AddScenario(Scenario.HelmsDeep);
            AddScenario(Scenario.TheRoadToIsengard);
        }
    }
}