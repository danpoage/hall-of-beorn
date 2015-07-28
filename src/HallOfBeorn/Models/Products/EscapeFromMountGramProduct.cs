using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class EscapeFromMountGramProduct : Product
    {
        public EscapeFromMountGramProduct()
            : base("Escape from Mount Gram", "MEC40", ImageType.Jpg)
        {
            AddCardSet(CardSet.EscapeFromMountGram);
        }
    }
}