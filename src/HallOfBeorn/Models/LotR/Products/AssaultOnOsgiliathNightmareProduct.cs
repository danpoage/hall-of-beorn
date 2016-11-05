using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class AssaultOnOsgiliathNightmareProduct : Product
    {
        public AssaultOnOsgiliathNightmareProduct()
            : base("Assault on Osgiliath Nightmare Deck", "MEN25", ImageType.Jpg, new DateTime(2015, 3, 19))
        {
            AddCardSet(CardSet.AssaultOnOsgiliathNightmare);
        }
    }
}