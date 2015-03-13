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

            CardSets.Add(CardSet.TheVoiceOfIsengard);
        }
    }
}