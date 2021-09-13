using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDunlandTrapProduct : Product
    {
        public TheDunlandTrapProduct()
            : base("The Dunland Trap", "MEC26", ImageType.Png, new DateTime(2014, 6, 26))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC26.pdf";
            
            AddCardSet(CardSet.TheDunlandTrap);

            AddScenario(Scenario.TheDunlandTrap);
        }
    }
}