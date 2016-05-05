using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TempleOfTheDeceived : Product
    {
        public TempleOfTheDeceived()
            : base("Temple of the Deceived", "MEC50", ImageType.Jpg)
        {
            AddCardSet(CardSet.TempleOfTheDeceived);
        }
    }
}