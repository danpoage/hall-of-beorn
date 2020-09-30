using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class AmongTheOutlawsProduct : Product
    {
        public AmongTheOutlawsProduct()
            : base("Among the Outlaws", "FA03", ImageType.Jpg, new DateTime(2015, 10, 1))
        {
            AddCardSet(CardSet.AmongTheOutlaws);
            AddScenario(new Scenarios.DoomMastered.AmongTheOutlawsScenario());
        }
    }
}