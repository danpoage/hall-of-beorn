using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheHillsOfEmynMuilNightmareProduct : Product
    {
        public TheHillsOfEmynMuilNightmareProduct()
            : base("The Hills of Emyn Muil Nightmare Deck", "MEN07", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheHillsOfEmynMuilNightmare);
        }
    }
}