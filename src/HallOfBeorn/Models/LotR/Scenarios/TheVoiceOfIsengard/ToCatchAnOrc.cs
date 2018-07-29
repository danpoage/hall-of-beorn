namespace HallOfBeorn.Models.LotR.Scenarios.TheVoiceOfIsengard
{
    public class ToCatchAnOrc : Scenario
    {
        public ToCatchAnOrc()
        {
            Title = "To Catch an Orc";
            ProductName = "The Voice of Isengard";
            GroupName = "The Voice of Isengard";
            Number = 2;

            QuestCompanionSlug = "voice-of-isengard-quest-to-catch-an-orc";
            DifficultyRating = 7.0f;
            Votes = 50;

            AddTheLineUnbrokenLink("35", "dzcwT6noaZs");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2018/03/06/nightmare-to-catch-an-orc/");

            AddEncounterSet(EncounterSet.BrokenLands);
            AddEncounterSet(EncounterSet.MistyMountainOrcs);
            AddEncounterSet(EncounterSet.ToCatchAnOrc);
            AddEncounterSet(EncounterSet.ToCatchAnOrcNightmare);

            AddQuestCardId("Orders-from-Orthanc-VoI");
            AddQuestCardId("Searching-for-Mugash-VoI");
            AddQuestCardId("The-Wizard's-Prize-VoI");

            ExcludeFromEasyMode("Take-Cover-VoI", 1);
            ExcludeFromEasyMode("Orc-Hound-VoI", 1);
            ExcludeFromEasyMode("Orc-Hunter-VoI", 2);
            ExcludeFromEasyMode("Orc-Territory-VoI", 2);

            ExcludeFromNightmareMode("Prowling-Wolf-VoI", 3);
            ExcludeFromNightmareMode("Orc-Hunter-VoI", 1);
            ExcludeFromNightmareMode("Orc-Hunting-Party-VoI", 2);
            ExcludeFromNightmareMode("Orc-Skirmisher-VoI", 1);
            ExcludeFromNightmareMode("Methedras-VoI", 2);
            ExcludeFromNightmareMode("Methedras-Orc-VoI", 1);
            ExcludeFromNightmareMode("Orc-Cave-VoI", 1);
        }
    }
}
