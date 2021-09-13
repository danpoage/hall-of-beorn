using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class TheDeadMarshesProduct : Product
    {
        public TheDeadMarshesProduct()
            : base("The Dead Marshes", "MEC06", ImageType.Png, new DateTime(2011, 11, 2))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC06.pdf";
            
            AddCardSet(CardSet.TheDeadMarshes);

            AddScenario(Scenario.TheDeadMarshes);
        }
    }
}