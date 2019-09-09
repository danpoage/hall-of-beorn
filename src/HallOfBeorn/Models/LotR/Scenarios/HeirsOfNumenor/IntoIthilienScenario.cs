namespace HallOfBeorn.Models.LotR.Scenarios.HeirsOfNumenor
{
    public class IntoIthilienScenario : Scenario
    {
        public IntoIthilienScenario()
        {
            Title = "Into Ithilien";
            ProductName = "Heirs of Númenor";
            GroupName = "Heirs of Númenor";
            Number = 2;

            QuestCompanionSlug = "heirs-of-numenor-quest-into-ithilien";
            DifficultyRating = 7.7f;
            Votes = 84;

            AddTheLineUnbrokenLink("23", "p2dLH2EnwK4");
            AddTheLineUnbrokenLink("23.5", "1EWPWryuE28");
            AddTheLineUnbrokenLink("N26", "Kw5ehMrnL4w");
            AddMrUnderhillLink(Title + " Nightmare Mode", "I35rcEDKKsQ");
            AddMrUnderhillLink("How to Beat " + Title, "sav1QR_x0xw");
            AddLotRDeckTechLink("Out of the Wild vs Into Ithilien", "DaCTHoWegsI");
            AddTheHallOfBeornBlogLink("https://hallofbeorn.wordpress.com/2014/07/29/deck-out-of-ithilien/", "Deck: Out of Ithilien");
            AddTheHallOfBeornBlogLink("https://hallofbeorn.wordpress.com/2014/11/17/breaking-news-giant-bear-dominates-in-battle-none-surprised/", "Nightmare Into Ithilien - Deck: Beorn the Arrow-eater");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2017/08/04/nightmare-into-ithilien/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.wordpress.com/2018/03/18/into-ithilien/");

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
