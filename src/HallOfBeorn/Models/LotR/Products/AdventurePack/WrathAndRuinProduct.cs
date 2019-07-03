using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class WrathAndRuinProduct : Product
    {
        public WrathAndRuinProduct()
            : base("Wrath and Ruin", "MEC78", ImageType.Jpg, new DateTime(2019, 9, 1))
        {
            AddCardSet(CardSet.WrathAndRuin);
        }
    }
}