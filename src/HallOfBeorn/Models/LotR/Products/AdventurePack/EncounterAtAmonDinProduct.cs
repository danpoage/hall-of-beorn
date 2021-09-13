using System;

namespace HallOfBeorn.Models.LotR.Products.AdventurePack
{
    public class EncounterAtAmonDinProduct : Product
    {
        public EncounterAtAmonDinProduct()
            : base("Encounter at Amon Dîn", "MEC20", ImageType.Png, new DateTime(2013, 7, 5))
        {
            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/MEC20.pdf";
            
            AddCardSet(CardSet.EncounterAtAmonDin);

            AddScenario(Scenario.EncounterAtAmonDin);
        }
    }
}