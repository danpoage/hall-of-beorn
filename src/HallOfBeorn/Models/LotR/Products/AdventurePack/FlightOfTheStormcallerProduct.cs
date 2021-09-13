using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class FlightOfTheStormcallerProduct : Product
    {
        public FlightOfTheStormcallerProduct()
            : base("Flight of the Stormcaller", "MEC48", ImageType.Jpg, new DateTime(2016, 5, 1))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC48.pdf";
            
            AddCardSet(CardSet.FlightOfTheStormcaller);

            AddScenario(Scenario.FlightOfTheStormcaller);
        }
    }
}