namespace HallOfBeorn.Models.LotR.Scenarios.TheRingMaker
{
    public class TheAntleredCrown : Scenario
    {
        public TheAntleredCrown()
        {
            Title = "The Antlered Crown";
            ProductName = "The Antlered Crown";
            GroupName = "The Ring-maker";
            Number = 6;

            QuestCompanionSlug = "the-ring-maker-quest-the-antlered-crown";
            DifficultyRating = 6.9f;
            Votes = 17;

            AddEncounterSet(EncounterSet.DunlandRaiders);
            AddEncounterSet(EncounterSet.DunlandWarriors);
            AddEncounterSet(EncounterSet.TheAntleredCrown);

            AddQuestCardId("Battle-for-Dunland-TAC");
            AddQuestCardId("The-Raven-Clan-TAC");
            AddQuestCardId("The-Last-Stage-TAC");

            ExcludeFromEasyMode("Dunland-Raider-VoI", 2);
            ExcludeFromEasyMode("Old-Hatreds-VoI", 1);
            ExcludeFromEasyMode("Dunland-Chieftain-VoI", 2);
            ExcludeFromEasyMode("Wild-Men-of-Dunland-VoI", 1);
            ExcludeFromEasyMode("Fierce-Folk-TAC", 1);
            ExcludeFromEasyMode("Raising-the-Cry-TAC", 1);
            ExcludeFromEasyMode("Raven-Skirmisher-TAC", 1);
            ExcludeFromEasyMode("Raven-War-camp-TAC", 2);
            ExcludeFromEasyMode("Raven-Warrior-TAC", 1);

        }
    }
}
