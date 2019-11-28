using System;

namespace HallOfBeorn.Models.LotR.Products.Nightmare
{
    public class AStormOnCobasHavenNightmareProduct : Product
    {
        public AStormOnCobasHavenNightmareProduct()
            : base("A Storm on Cobas Haven Nightmare", "MEN49", ImageType.Jpg, new DateTime(2018, 3, 3))
        {
            AddCardSet(CardSet.AStormOnCobasHavenNightmare);
        }
    }
}