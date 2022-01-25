using System;

namespace HallOfBeorn.Models.LotR.Scenarios.DreamChaser
{
    public class AStormOnCobasHavenScenario : DreamChaserScenarioScenario
    {
        public AStormOnCobasHavenScenario()
        {
            Title = "A Storm on Cobas Haven";
            ProductName = "A Storm on Cobas Haven";
            GroupName = "Dream-chaser";
            Number = 5;

            QuestCompanionSlug = "the-dream-chaser-quest-a-storm-on-cobas-haven";
            DifficultyRating = 7.8f;
            Votes = 12;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2019/07/09/a-storm-on-cobas-haven/");

            AddEncounterSet(EncounterSet.AStormOnCobasHaven);
            AddEncounterSet(EncounterSet.CorsairRaiders);
            AddEncounterSet(EncounterSet.CorsairPirates);
            AddEncounterSet(EncounterSet.UmbarFleet);
            AddEncounterSet(EncounterSet.VoyageAcrossBelegaer);
            AddEncounterSet(EncounterSet.TheDreamChasersFleet);
            AddEncounterSet(EncounterSet.AStormOnCobasHavenNightmare);

            AddQuestCardId("Outmaneuver-the-Enemy-ASoCH");
            AddQuestCardId("Battle-in-the-Bay-ASoCH");
            AddQuestCardId("Break-Through-the-Fleet-ASoCH");

            ExcludeCorsairRaidersFromEasyMode();
            ExcludeCorsairPiratesFromEasyMode();
            ExcludeUmbarFleetFromEasyMode();

            ExcludeFromEasyMode("Siege-Ship-ASoCH", 1);
            ExcludeFromEasyMode("Heavy-Cruiser-ASoCH", 1);
            ExcludeFromEasyMode("Coast-of-Anfalas-ASoCH", 2);
            ExcludeFromEasyMode("Taking-on-Water-ASoCH", 1);

            ExcludeFromNightmareMode("Belfalas-Islet-ASoCH", 2);
            ExcludeFromNightmareMode("Cobas-Haven-ASoCH", 2);
            ExcludeFromNightmareMode("Fog-Bank-TGH", 2);
            ExcludeFromNightmareMode("Corsair-Skirmisher-ASoCH", 2);
            ExcludeFromNightmareMode("Ramming-Speed-ASoCH", 1);
            ExcludeFromNightmareMode("Corsair-Infiltrator-TGH", 2);
            ExcludeFromNightmareMode("Cunning-Pirate-TGH", 1);
            ExcludeFromNightmareMode("Umbar-Raider-TGH", 1);
        }
    }
}