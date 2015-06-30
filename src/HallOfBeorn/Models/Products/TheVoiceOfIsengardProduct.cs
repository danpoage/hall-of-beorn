using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheVoiceOfIsengardProduct : Product
    {
        public TheVoiceOfIsengardProduct()
            : base("The Voice of Isengard", "MEC25", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/the-voice-of-isengard-rulesheet.pdf";

            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1616617950&asins=1616617950&linkId=MPUHDVSIDNYAHFYN&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.TheVoiceOfIsengard);
        }
    }
}