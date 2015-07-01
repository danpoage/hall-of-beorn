using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheWastesOfEriadorProduct : Product
    {
        public TheWastesOfEriadorProduct()
            : base("The Wastes of Eriador", "MEC39", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheWastesOfEriador);
        }
    }
}