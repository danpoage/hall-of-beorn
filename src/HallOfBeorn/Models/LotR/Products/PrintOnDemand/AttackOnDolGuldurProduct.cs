using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.PrintOnDemand
{
    public class AttackOnDolGuldurProduct : Product
    {
        public AttackOnDolGuldurProduct()
            : base("Attack on Dol Guldur", "OP050", ImageType.Jpg)
        {
            AddCardSet(CardSet.AttackOnDolGuldur);
        }
    }
}