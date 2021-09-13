using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheVoiceOfIsengardProduct : Product
    {
        public TheVoiceOfIsengardProduct()
            : base("The Voice of Isengard", "MEC25", ImageType.Png, new DateTime(2014, 2, 21))
        {
            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1616617950&asins=1616617950&linkId=MPUHDVSIDNYAHFYN&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.TheVoiceOfIsengard);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC25.pdf";

            AddScenario(Scenario.TheFordsOfIsen);
            AddScenario(Scenario.ToCatchAnOrc);
            AddScenario(Scenario.IntoFangorn);
        }
    }
}