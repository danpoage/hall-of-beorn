using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TroubleInTharbadProduct : Product
    {
        public TroubleInTharbadProduct()
            : base("Trouble in Tharbad", "MEC28", ImageType.Png, new DateTime(2014, 8, 21))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC28.pdf";
            
            AddCardSet(CardSet.TroubleInTharbad);

            AddScenario(Scenario.TroubleInTharbad);
        }
    }
}