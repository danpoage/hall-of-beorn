using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheWastesOfEriadorNightmareProduct : Product
    {
        public TheWastesOfEriadorNightmareProduct()
            : base("The Wastes of Eriador Nightmare", "MEN37", ImageType.Jpg, new DateTime(2016, 8, 15))
        {
            AddCardSet(CardSet.TheWastesOfEriadorNightmare);
        }
    }
}