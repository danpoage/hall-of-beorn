namespace HallOfBeorn.Models.LotR.Scenarios.HeirsOfNumenor
{
    public class IntoIthilien : Scenario
    {
        public IntoIthilien()
        {
            Title = "Into Ithilien";
            ProductName = "Heirs of Númenor";
            GroupName = "Heirs of Númenor";
            Number = 2;

            QuestCompanionSlug = "heirs-of-numenor-quest-into-ithilien";
            DifficultyRating = 7.7f;
            Votes = 84;

            AddTheHallOfBeornBlogLink("https://hallofbeorn.wordpress.com/2014/07/29/deck-out-of-ithilien/", "Deck: Out of Ithilien");

            AddEncounterSet(EncounterSet.BroodingForest);
            AddEncounterSet(EncounterSet.CreaturesOfTheForest);
            AddEncounterSet(EncounterSet.IntoIthilien);
            AddEncounterSet(EncounterSet.IntoIthilienNightmare);
            AddEncounterSet(EncounterSet.Southrons);

            AddQuestCardId("Ambush-in-Ithilien-HoN");
            AddQuestCardId("Southron-Counter-attack-HoN");
            AddQuestCardId("The-Hidden-Way-HoN");
            AddQuestCardId("Approaching-Cair-Andros-HoN");

            ExcludeFromEasyMode("Lost-Companion-HoN", 2);
            ExcludeFromEasyMode("Overgrown-Trail-HoN", 2);
            ExcludeFromEasyMode("Morgul-Spider-HoN", 2);
            ExcludeFromEasyMode("Watcher-in-the-Wood-HoN", 2);
            ExcludeFromEasyMode("Blocking-Wargs-HoN", 2);
            ExcludeFromEasyMode("Mumak-HoN", 1);
            ExcludeFromEasyMode("Southron-Support-HoN", 2);

            ExcludeFromNightmareMode("Overgrown-Trail-HoN", 1);
            ExcludeFromNightmareMode("Secluded-Glade-HoN", 3);
            ExcludeFromNightmareMode("Forest-Bat-HoN", 3);
            ExcludeFromNightmareMode("Watcher-in-the-Wood-HoN", 2);
            ExcludeFromNightmareMode("Blocking-Wargs-HoN", 1);
            ExcludeFromNightmareMode("Southron-Mercenaries-HoN", 3);
        }
    }
}
