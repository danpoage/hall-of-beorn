using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheAntleredCrownProduct : Product
    {
        public TheAntleredCrownProduct()
            : base("The Antlered Crown", "MEC31", ImageType.Jpg)
        {
            CardSets.Add(CardSet.TheAntleredCrown);
        }
    }
}