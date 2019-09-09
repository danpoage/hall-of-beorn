namespace HallOfBeorn.Models.LotR.Scenarios.AgainstTheShadow
{
    public class EncounterAtAmonDinScenario : Scenario
    {
        public EncounterAtAmonDinScenario()
        {
            Title = "Encounter at Amon Dîn";
            ProductName = "Encounter at Amon Dîn";
            GroupName = "Against the Shadow";
            Number = 3;

            QuestCompanionSlug = "against-the-shadow-quest-encounter-at-amon-din";
            DifficultyRating = 3.0f;
            Votes = 63;

            AddTheLineUnbrokenLink("30", "FBZvfJTkh7s");
            AddMrUnderhillLink(Title + " Normal + Nightmare - Two Players", "apkxfJOyeb0");
            AddMrUnderhillLink(Title + " Nightmare Mode - Two Players", "LC5Q-mLU6GI");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/10/18/nightmare-encounter-at-amon-din/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/04/11/encounter-at-amon-din/");

            AddEncounterSet(EncounterSet.EncounterAtAmonDin);
            AddEncounterSet(EncounterSet.EncounterAtAmonDinNightmare);
            AddEncounterSet(EncounterSet.RavagingOrcs);

            AddQuestCardId("Savagery-of-the-Orcs-EaAD");
            AddQuestCardId("Protect-the-Villagers-EaAD");

            ExcludeFromEasyMode("Burnt-Homestead-EaAD", 2);
            ExcludeFromEasyMode("Craven-Eagle-EaAD", 2);
            ExcludeFromEasyMode("Orc-Rabble-HoN", 3);

            ExcludeFromNightmareMode("Burning-Farmhouse-EaAD", 2);
            ExcludeFromNightmareMode("Craven-Eagle-EaAD", 2);
            ExcludeFromNightmareMode("Gondorian-Hamlet-EaAD", 2);
            ExcludeFromNightmareMode("Marauding-Orc-EaAD", 1);
            ExcludeFromNightmareMode("Orc-Ravager-EaAD", 3);
            ExcludeFromNightmareMode("Panicked-EaAD", 2);
            ExcludeFromNightmareMode("Trapped-Inside-EaAD", 2);
            ExcludeFromNightmareMode("Orc-Rabble-HoN", 1);
            ExcludeFromNightmareMode("Scourge-of-Mordor-HoN", 2);
        }
    }
}
