using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Deluxe
{
    public class TheLostRealmProduct : Product
    {
        public TheLostRealmProduct()
            : base("The Lost Realm", "MEC38", ImageType.Jpg, new DateTime(2015, 4, 3))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC38.pdf";
                //"https://images-cdn.fantasyflightgames.com/filer_public/88/d6/88d6e80d-e75d-468f-8484-76c56b15e895/mec38_insert_web.pdf";

            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1633440397&asins=1633440397&linkId=MRZSHYNQUJMLE3MP&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.TheLostRealm);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLostRealm.IntrudersInChetwoodScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLostRealm.TheWeatherHillsScenario());
            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.TheLostRealm.DeadmensDikeScenario());
        }
    }
}