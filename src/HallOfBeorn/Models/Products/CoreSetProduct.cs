using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class CoreSetProduct : Product
    {
        public CoreSetProduct()
            : base("Core Set", "MEC01", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/LOTR_LCG_Core_rules_eng_Lo-Res.pdf";

            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1589949811&asins=1589949811&linkId=BV675SVRJOCZY6PG&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.CoreSet);
        }
    }
}