using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TroubleInTharbadProduct : Product
    {
        public TroubleInTharbadProduct()
            : base("Trouble in Tharbad", "MEC28", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/trouble-in-tharbad-rulesheet.pdf";

            AddCardSet(new Sets.TroubleInTharbad());
        }
    }
}