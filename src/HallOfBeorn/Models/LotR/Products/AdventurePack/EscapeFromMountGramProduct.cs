using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class EscapeFromMountGramProduct : Product
    {
        public EscapeFromMountGramProduct()
            : base("Escape from Mount Gram", "MEC40", ImageType.Jpg, new DateTime(2015, 7, 30))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC40.pdf";
            
            AddCardSet(CardSet.EscapeFromMountGram);

            AddScenario(Scenario.EscapeFromMountGram);
        }
    }
}