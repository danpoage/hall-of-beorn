using System;

namespace HallOfBeorn.Models.LotR.Products.Community
{
    public class TheScouringOfTheShireProduct
        : Product
    {
        public TheScouringOfTheShireProduct()
            : base("The Scouring of the Shire", "ALEP08", ImageType.Png, new DateTime(2021, 8, 16))
        {
            AddCardSet(CardSet.TheScouringOfTheShire);
            AddScenario(Scenario.TheScouringOfTheShire);

            RulesUrl = "https://hallofbeorn-resources.s3.amazonaws.com/Images/LotR/Rules/ALEP08.pdf";
        }
    }
}