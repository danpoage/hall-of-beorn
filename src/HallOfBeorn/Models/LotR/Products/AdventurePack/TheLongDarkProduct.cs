using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheLongDarkProduct : Product
    {
        public TheLongDarkProduct()
            : base("The Long Dark", "MEC12", ImageType.Png, new DateTime(2012, 5, 16))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC12.pdf";
            
            AddCardSet(CardSet.TheLongDark);

            AddScenario(Scenario.TheLongDark);
        }
    }
}