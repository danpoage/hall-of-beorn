using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products
{
    public class TheTreacheryOfRhudaurProduct : Product
    {
        public TheTreacheryOfRhudaurProduct()
            : base("Treachery of Rhudaur", "MEC42", ImageType.Jpg, new DateTime(2015, 9, 24))
        {
            AddCardSet(CardSet.TheTreacheryOfRhudaur);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened.TheTreacheryOfRhudaur());
        }
    }
}