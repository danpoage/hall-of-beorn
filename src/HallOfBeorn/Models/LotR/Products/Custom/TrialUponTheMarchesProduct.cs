using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Custom
{
    public class TrialUponTheMarchesProduct : Product
    {
        public TrialUponTheMarchesProduct()
            : base("Trial Upon the Marches", "FA02", ImageType.Jpg)
        {
            AddCardSet(CardSet.TrialUponTheMarches);
        }
    }
}