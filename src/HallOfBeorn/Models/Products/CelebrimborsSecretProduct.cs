using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class CelebrimborsSecretProduct : Product
    {
        public CelebrimborsSecretProduct()
            : base("Celebrimbor's Secret", "MEC30", ImageType.Png)
        {
            CardSets.Add(CardSet.CelebrimborsSecret);
        }
    }
}