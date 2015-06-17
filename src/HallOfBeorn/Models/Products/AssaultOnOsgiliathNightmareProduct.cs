using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class AssaultOnOsgiliathNightmareProduct : Product
    {
        public AssaultOnOsgiliathNightmareProduct()
            : base("Assault on Osgiliath Nightmare Deck", "MEN25", ImageType.Jpg)
        {
            AddCardSet(CardSet.AssaultOnOsgiliathNightmare);
        }
    }
}