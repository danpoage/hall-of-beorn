using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheBattleOfThePelennorFields : Scenario
    {
        public TheBattleOfThePelennorFields()
        {
            Title = "The Battle of the Pelennor Fields";
            ProductName = "The Flame of the West";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 15;

            RulesUrl = "https://images-cdn.fantasyflightgames.com/filer_public/e8/5c/e85c8012-6840-432b-bd81-ac7792aa6281/mec54_rulesheet.pdf";
            QuestCompanionSlug = "lotr-the-flame-of-the-west-saga-expansion-quest-the-battle-of-the-pelennor-fields";
            DifficultyRating = 7.9f;
            Votes = 11;

            AddEncounterSet(EncounterSet.TheBattleOfThePelennorFields);

            AddQuestCardId("The-Garrison-of-Gondor-TFotW");
            AddQuestCardId("Retreat-from-Osgiliath-TFotW");
            AddQuestCardId("The-White-City-Besieged-TFotW");
            AddQuestCardId("Rohan-has-Come-TFotW");
            AddQuestCardId("Fighting-in-the-Fields-TFotW");

            ExcludeFromEasyMode("Fire-filled-Trench-TFotW", 1);
            ExcludeFromEasyMode("Siege-Tower-TFotW", 1);
            ExcludeFromEasyMode("The-Black-Serpent-TFotW", 1);
            ExcludeFromEasyMode("War-Mumak-TFotW", 1);
            ExcludeFromEasyMode("Morgul-Captain-TFotW", 1);
            ExcludeFromEasyMode("Mordor-Orc-TFotW", 1);
            ExcludeFromEasyMode("The-Rammas-is-Breached-TFotW", 1);
            ExcludeFromEasyMode("Fell-Beast-TFotW", 1);
            ExcludeFromEasyMode("Black-Dart-TFotW", 1);
            ExcludeFromEasyMode("Shadow-of-Mordor-TFotW", 1);
        }
    }
}