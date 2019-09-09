using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class KhazadDumProduct : Product
    {
        public KhazadDumProduct()
            : base("Khazad-dûm", "MEC08", ImageType.Png, new DateTime(2011, 1, 6))
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Khazad_d%C3%BBm_rules.pdf";

            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1616612177&asins=1616612177&linkId=IH737GRNQHT3OERV&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.KhazadDum);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.KhazadDum.IntoThePitScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.KhazadDum.TheSeventhLevelScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.KhazadDum.FlightFromMoriaScenario());
        }
    }
}