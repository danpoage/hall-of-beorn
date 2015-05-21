using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheNinInEilphProduct : Product
    {
        public TheNinInEilphProduct()
            : base("The Nîn-in-Eilph", "MEC29", ImageType.Png)
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/2d/5c/2d5ce50f-0364-4ece-a880-85a9f7d840a6/mec29-the-nin-in-eilph-rulesheet.pdf";

            CardSets.Add(CardSet.NinInEilph);
        }
    }
}