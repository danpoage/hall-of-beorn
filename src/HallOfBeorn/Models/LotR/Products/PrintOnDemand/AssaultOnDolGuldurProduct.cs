using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PrintOnDemand
{
    public class AssaultOnDolGuldurProduct : Product
    {
        public AssaultOnDolGuldurProduct()
            : base("Assault on Dol Guldur", "OP050", ImageType.Jpg)
        {
            AddCardSet(CardSet.AssaultOnDolGuldur);
        }
    }
}