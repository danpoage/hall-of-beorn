using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheTreacheryOfRhudaurProduct : Product
    {
        public TheTreacheryOfRhudaurProduct()
            : base("Treachery of Rhudaur", "MEC42", ImageType.Jpg, new DateTime(2015, 9, 24))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC42.pdf";

            AddCardSet(CardSet.TheTreacheryOfRhudaur);

            AddScenario(new HallOfBeorn.Models.LotR.Scenarios.AngmarAwakened.TheTreacheryOfRhudaurScenario());
        }
    }
}