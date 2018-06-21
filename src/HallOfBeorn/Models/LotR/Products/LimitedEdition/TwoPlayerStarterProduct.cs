using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.LimitedEdition
{
    public class TwoPlayerStarterProduct : Product
    {
        public TwoPlayerStarterProduct()
            : base("Limited Edition Two Player Starter", "MEC73", ImageType.Jpg)
        {
            AddCardSet(CardSet.TwoPlayerStarter);
        }
    }
}