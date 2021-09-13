using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheHillsOfEmynMuilProduct : Product
    {
        public TheHillsOfEmynMuilProduct()
            : base("The Hills of Emyn Muil", "MEC05", ImageType.Png, new DateTime(2011, 9, 30))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC05.pdf";
            
            AddCardSet(CardSet.TheHillsOfEmynMuil);

            AddScenario(Scenario.TheHillsOfEmynMuil);
        }
    }
}