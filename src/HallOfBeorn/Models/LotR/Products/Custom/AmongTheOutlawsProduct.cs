using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Custom
{
    public class AmongTheOutlawsProduct : Product
    {
        public AmongTheOutlawsProduct()
            : base("Among the Outlaws", "FA03", ImageType.Jpg)
        {
            AddCardSet(CardSet.AmongTheOutlaws);
        }
    }
}