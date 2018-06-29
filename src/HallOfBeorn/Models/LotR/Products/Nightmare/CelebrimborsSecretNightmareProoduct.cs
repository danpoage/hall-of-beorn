using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class CelebrimborsSecretNightmareProoduct : Product
    {
        public CelebrimborsSecretNightmareProoduct()
            : base("Celebrimbor's Secret Nightmare", "MEN33", ImageType.Jpg, new DateTime(2016, 3, 15))
        {
            AddCardSet(CardSet.CelebrimborsSecretNightmare);
        }
    }
}