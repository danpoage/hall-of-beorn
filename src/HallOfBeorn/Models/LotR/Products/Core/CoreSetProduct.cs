﻿using System;

namespace HallOfBeorn.Models.LotR.Products.Core
{
    public class CoreSetProduct : Product
    {
        public CoreSetProduct()
            : base("Core Set", "MEC01", ImageType.Png, new DateTime(2011, 4, 20))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC01.pdf";
            EasyModeUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC01-EASY.pdf";
            LearnToPlayUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC01-LTP.pdf";

            BuyLink = "<iframe style='width:120px;height:240px;' marginwidth='0' marginheight='0' scrolling='no' frameborder='0' src='//ws-na.amazon-adsystem.com/widgets/q?ServiceVersion=20070822&OneJS=1&Operation=GetAdHtml&MarketPlace=US&source=ac&ref=qf_sp_asin_til&ad_type=product_link&tracking_id=halofbeocarse-20&marketplace=amazon&region=US&placement=1589949811&asins=1589949811&linkId=BV675SVRJOCZY6PG&show_border=true&link_opens_in_new_window=true'></iframe>";

            AddCardSet(CardSet.CoreSet);

            AddScenario(Scenario.PassageThroughMirkwood);
            AddScenario(Scenario.JourneyAlongTheAnduin);
            AddScenario(Scenario.EscapeFromDolGuldur);
        }
    }
}