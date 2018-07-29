using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.Haradrim
{
    public class TheDungeonsOfCirithGuratScenario : Scenarios.TheSandsOfHarad.TheSandsOfHaradScenario
    {
        private const string name = "The Dungeons of Cirith Gurat";

        public TheDungeonsOfCirithGuratScenario()
        {
            Title = name;
            ProductName = name;
            GroupName = "Haradrim";
            Number = 5;

            RulesUrl = string.Empty;
            QuestCompanionSlug = "haradrim-cycle-quest-the-dungeons-of-cirith-gurat";
            DifficultyRating = 6.7f;
            Votes = 3;

            AddMrUnderhillLink(Title + " - Old Dogs, New Tricks", "UbMH3nJtlgM");
            AddWanderingTookVideoLink("Twitch Recast: " + Title, "OuL4VCNeb40");

            AddEncounterSet(EncounterSet.TheDungeonsOfCirithGurat);
            AddEncounterSet(EncounterSet.MordorOrcs);
            AddEncounterSet(EncounterSet.HaradTerritory);
            
            AddQuestCardId("Rescue-the-Prisoners-DoCG");
            AddQuestCardId("Sneak-Past-the-Guards-DoCG");
            AddQuestCardId("Fight-Your-Way-Out-DoCG");
            
            ExcludeFromEasyMode("Jailer-of-Cirith-Gurat-DoCG", 1);
            ExcludeFromEasyMode("Dungeon-Warg-DoCG", 1);
            ExcludeFromEasyMode("Dungeon-Cell-DoCG", 1);
            ExcludeFromEasyMode("Taken-Prisoner-DoCG", 1);

            excludeHaradTerritory();
            excludeMordorOrcs();
        }
    }
}