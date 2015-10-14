using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheTreacheryOfRhudaurProduct : Product
    {
        public TheTreacheryOfRhudaurProduct()
            : base("Treachery of Rhudaur", "MEC42", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheTreacheryOfRhudaur);

            AddScenario(new HallOfBeorn.Models.Scenarios.TheTreacheryOfRhudaur());
        }
    }
}