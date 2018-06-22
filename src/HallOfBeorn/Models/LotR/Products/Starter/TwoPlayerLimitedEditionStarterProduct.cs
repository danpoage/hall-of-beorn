using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Starter
{
    public class TwoPlayerLimitedEditionStarterProduct : Product
    {
        public TwoPlayerLimitedEditionStarterProduct()
            : base("Two-Player Limited Edition Starter", "MEC73", ImageType.Jpg)
        {
            AddCardSet(CardSet.TwoPlayerLimitedEditionStarter);
        }
    }
}