using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheRuinsOfBelegostProduct : Product
    {
        public TheRuinsOfBelegostProduct()
            : base("The Ruins of Belegost", "OP014", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheRuinsOfBelegost);
        }
    }
}