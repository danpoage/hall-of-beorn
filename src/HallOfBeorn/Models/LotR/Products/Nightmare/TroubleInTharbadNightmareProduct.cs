using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class TroubleInTharbadNightmareProduct : Product
    {
        public TroubleInTharbadNightmareProduct()
            : base("Trouble in Tharbad Nightmare Deck", "MEN31", ImageType.Jpg, new DateTime(2015, 10, 29))
        {
            AddCardSet(CardSet.TroubleInTharbadNightmare);
        }
    }
}