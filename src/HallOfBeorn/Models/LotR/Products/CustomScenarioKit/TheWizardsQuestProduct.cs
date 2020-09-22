using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Products.CustomScenarioKit
{
    public class TheWizardsQuestProduct : Product
    {
        public TheWizardsQuestProduct()
            : base("The Wizard's Quest", "MEC75", ImageType.Jpg, new DateTime(2018, 8, 2))
        {
            AddCardSet(CardSet.TheWizardsQuest);
        }
    }
}