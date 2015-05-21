using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheAntleredCrownProduct : Product
    {
        public TheAntleredCrownProduct()
            : base("The Antlered Crown", "MEC31", ImageType.Jpg)
        {
            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/a9/19/a91988d8-41a3-4653-9b3e-c2a970c1b2a8/mec31-the-antlered-crown-rulesheet.pdf";

            CardSets.Add(CardSet.TheAntleredCrown);
        }
    }
}