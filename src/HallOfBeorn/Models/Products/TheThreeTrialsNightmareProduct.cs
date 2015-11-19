using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheThreeTrialsNightmareProduct : Product
    {
        public TheThreeTrialsNightmareProduct()
            : base("The Three Trials Nightmare Deck", "MEN30", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheThreeTrialsNightmare);
        }
    }
}