namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheRingGoesSouthScenario : Scenario
    {
        public TheRingGoesSouthScenario()
        {
            Title = "The Ring Goes South";
            ProductName = "The Road Darkens";
            GroupName = "The Lord of the Rings";
            IsSubGroup = true;
            Number = 4;

            QuestCompanionSlug = "lotr-the-road-darkens-quest-the-ring-goes-south";
            DifficultyRating = 6.0f;
            Votes = 28;

            AddTheLineUnbrokenLink("C4", "QRYdChjLfvc");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2018/05/30/path-less-traveled-the-ring-goes-south-standalone/", "The Ring Goes South (Standalone)");
            AddPathLessTraveledLink("https://darklingdoor.wordpress.com/2018/06/05/path-less-traveled-the-ring-goes-south-campaign/", "The Ring Goes South (Campaign)");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/12/30/nightmare-review-the-ring-goes-southnightmare-campaign-part-4/", "Nightmare " + Title);
            AddTheRoadLink(7, "https://theroadlotr.wordpress.com/the-ring-goes-south/");
            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2018/06/24/the-ring-goes-south/");

            AddEncounterSet(EncounterSet.TheRingGoesSouth);
            AddEncounterSet(EncounterSet.TheRingGoesSouthNightmare);

            AddQuestCardId("The-Council-of-Elrond-RD");
            AddQuestCardId("The-Nine-Walkers-RD");
            AddQuestCardId("The-Hunt-is-Up-RD");
            AddQuestCardId("The-Gates-of-Moria-RD");

            ExcludeFromEasyMode("Bitter-Cold-RD", 1);
            ExcludeFromEasyMode("Eregion-RD", 1);
            ExcludeFromEasyMode("Hound-of-Sauron-RD", 2);
            ExcludeFromEasyMode("Redhorn-Foothills-RD", 1);
            ExcludeFromEasyMode("Regiments-of-Crows-RD", 1);
            ExcludeFromEasyMode("Storm-of-Howls-RD", 1);

            ExcludeFromNightmareMode("Crebain-from-Dunland-RD", 2);
            ExcludeFromNightmareMode("Howling-Warg-RD", 2);
            ExcludeFromNightmareMode("Tree-crowned-Hill-RD", 1);
            ExcludeFromNightmareMode("Hills-of-Hollin-RD", 3);
            ExcludeFromNightmareMode("Snowdrifts-RD", 2);
            ExcludeFromNightmareMode("Storm-of-Howls-RD", 1);
        }
    }
}
