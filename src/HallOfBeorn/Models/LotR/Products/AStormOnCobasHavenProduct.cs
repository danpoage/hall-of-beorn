using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class AStormOnCobasHavenProduct : Product
    {
        public AStormOnCobasHavenProduct()
            : base("A Storm on Cobas Haven", "MEC52", ImageType.Jpg)
        {
            AddCardSet(CardSet.AStormOnCobasHaven);
        }
    }
}