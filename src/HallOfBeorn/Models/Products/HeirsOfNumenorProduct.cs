using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class HeirsOfNumenorProduct : Product
    {
        public HeirsOfNumenorProduct()
            : base("Heirs of Númenor", "MEC17", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Heirs-of-Numenor_rules.pdf";

            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1616614455&asins=1616614455&linkId=FXHYRGM3YUBQQFPP&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.HeirsOfNumenor);
        }
    }
}