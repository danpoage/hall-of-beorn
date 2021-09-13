using System;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class HeirsOfNumenorProduct : Product
    {
        public HeirsOfNumenorProduct()
            : base("Heirs of Númenor", "MEC17", ImageType.Png, new DateTime(2012, 11, 26))
        {
            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1616614455&asins=1616614455&linkId=FXHYRGM3YUBQQFPP&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.HeirsOfNumenor);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC17.pdf";

            AddScenario(Scenario.PerilInPelargir);
            AddScenario(Scenario.IntoIthilien);
            AddScenario(Scenario.TheSiegeOfCairAndros);
        }
    }
}