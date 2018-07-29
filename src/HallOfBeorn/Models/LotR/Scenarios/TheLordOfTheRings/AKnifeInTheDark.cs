namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class AKnifeInTheDark : Scenario
    {
        public AKnifeInTheDark()
        {
            Title = "A Knife in the Dark";
            ProductName = "The Black Riders";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 2;

            QuestCompanionSlug = "lotr-the-black-riders-quest-a-knife-in-the-dark";
            DifficultyRating = 6.7f;
            Votes = 50;

            AddTheLineUnbrokenLink("C2", "bC9AY0ilOmc");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2017/10/02/path-less-traveled-a-knife-in-the-dark/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/11/19/nightmare-review-a-knife-in-the-darknightmare-campaign-part-2/", "Nightmare " + Title);
            AddTheRoadLink(4, "https://theroadlotr.wordpress.com/a-knife-in-the-dark/");

            AddEncounterSet(EncounterSet.AKnifeInTheDark);
            AddEncounterSet(EncounterSet.AKnifeInTheDarkNightmare);
            AddEncounterSet(EncounterSet.Hunted);
            AddEncounterSet(EncounterSet.TheNazgul);
            AddEncounterSet(EncounterSet.TheRing);

            AddQuestCardId("Trouble-in-Bree-TBR");
            AddQuestCardId("Into-the-Wild-TBR");
            AddQuestCardId("The-Ringwraiths-Attack-TBR");

            ExcludeFromEasyMode("Black-Breath-TBR", 2);
            ExcludeFromEasyMode("Squint-Eyed-Southerner-TBR", 1);
            ExcludeFromEasyMode("Piercing-Cry-TBR", 2);
            ExcludeFromEasyMode("Pale-Blade-TBR", 2);
            ExcludeFromEasyMode("Power-In-Their-Terror-TBR", 2);
            ExcludeFromEasyMode("Rider-of-Mordor-TBR", 2);
            ExcludeFromEasyMode("Ringwraith-TBR", 2);

            ExcludeFromNightmareMode("Unwanted-Attention-TBR", 1);
            ExcludeFromNightmareMode("Weather-Hills-TBR", 3);
            ExcludeFromNightmareMode("Weathertop-TBR", 1);
            ExcludeFromNightmareMode("Pathless-Country-TBR", 3);
        }
    }
}
