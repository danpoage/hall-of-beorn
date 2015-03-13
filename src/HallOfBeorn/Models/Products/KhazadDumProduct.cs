using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class KhazadDumProduct : Product
    {
        public KhazadDumProduct()
            : base("Khazad-dûm", "MEC08", ImageType.Png)
        {
            RulesUrl = "http://www.fantasyflightgames.com/ffg_content/lotr-lcg/support/rulesheets/Khazad_d%C3%BBm_rules.pdf";

            CardSets.Add(CardSet.KhazadDum);
        }
    }
}