using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class HeirsOfNumenorNightmareProduct : Product
    {
        public HeirsOfNumenorNightmareProduct()
            : base("Heirs of Númenor Nightmare Decks", "MEN21", ImageType.Jpg, new DateTime(2014, 10, 31))
        {
            IsPremier = true;
            IsNewSubGroup = true;
            AddCardSet(CardSet.PerilInPelargirNightmare);
            AddCardSet(CardSet.IntoIthilienNightmare);
            AddCardSet(CardSet.TheSiegeOfCairAndrosNightmare);
        }
    }
}