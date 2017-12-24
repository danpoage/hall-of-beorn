using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TheGreyHavensNightmareProduct : Product
    {
        public TheGreyHavensNightmareProduct()
            : base("The Grey Havens Nightmare", "MEN44", ImageType.Jpg)
        {
            IsPremier = true;
            IsNewSubGroup = true;
            AddCardSet(CardSet.VoyageAcrossBelegaerNightmare);
            AddCardSet(CardSet.TheFateOfNumenorNightmare);
            AddCardSet(CardSet.RaidOnTheGreyHavensNightmare);
        }
    }
}