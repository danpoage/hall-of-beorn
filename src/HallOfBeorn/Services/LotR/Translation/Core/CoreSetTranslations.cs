using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Services.LotR.Translation.Core
{
    public class CoreSetTranslations
    {
        public Phrase Aragorn =
            Phrase.Text(Gender.Male).Action.After.Self.CommitsToQuest.SpendResourcesFromOwnResourcePool(1).ToReadySelf;

        public Phrase Theodred =
            Phrase.Text(Gender.Male).Response.After.Self.CommitsToQuest.ChooseAHero.CommitedToThatQuest.AddResourceToThatHeroesResourcePool(1);

        public Phrase Gloin =
            Phrase.Text(Gender.Male).Response.After.Self.TakesDamage.AddResourcesToOwnResourcePool(1).ForEach.DamageSelfSuffered;
    }
}