using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
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