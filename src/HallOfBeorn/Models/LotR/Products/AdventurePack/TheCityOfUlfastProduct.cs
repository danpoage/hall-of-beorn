using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheCityOfUlfastProduct : Product
    {
        public TheCityOfUlfastProduct()
            : base("The City of Ulfast", "MEC79", ImageType.Jpg, new DateTime(2019, 12, 1))
        {
            AddCardSet(CardSet.TheCityOfUlfast);
        }
    }
}