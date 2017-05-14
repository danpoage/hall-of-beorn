using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheWastesOfEriadorNightmareProduct : Product
    {
        public TheWastesOfEriadorNightmareProduct()
            : base("The Wastes of Eriador Nightmare", "MEN38", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheWastesOfEriadorNightmare);
        }
    }
}