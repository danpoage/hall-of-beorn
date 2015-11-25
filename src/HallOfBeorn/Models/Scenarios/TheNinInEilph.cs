namespace HallOfBeorn.Models.Scenarios
{
    public class TheNinInEilph : Scenario
    {
        public TheNinInEilph()
        {
            Title = "The Nîn-in-Eilph";
            ProductName = "The Nîn-in-Eilph";
            GroupName = "The Ring-maker";
            Number = 0;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-ring-maker-quest-the-nin-in-eilph.html";

            AddEncounterSet(EncounterSet.TheNinInEilph);
            AddEncounterSet(EncounterSet.WearyTravelers);

            AddQuestCardId("Fleeing-from-Tharbad-NiE");
            AddQuestCardId("Through-the-Marsh-No-End-in-Sight-NiE");
            AddQuestCardId("Through-the-Marsh-A-Weary-Passage-NiE");
            AddQuestCardId("Through-the-Marsh-A-Forgotten-Land-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-Impassable-Marshland-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-A-Treacherous-Swamp-NiE");
            AddQuestCardId("Lost-in-the-Swanfleet-Creatures-of-a-Forgotten-Age-NiE");
            AddQuestCardId("Out-of-the-Swamp-NiE");

            ExcludeFromEasyMode("Fen-of-Reeds-NiE", 1);
            ExcludeFromEasyMode("Giant-Swamp-Adder-NiE", 1);
            ExcludeFromEasyMode("Remnants-of-Elder-Days-NiE", 1);
            ExcludeFromEasyMode("Shifting-Marshland-NiE", 1);
            ExcludeFromEasyMode("In-Need-of-Rest-VoI", 1);
            ExcludeFromEasyMode("Low-on-Provisions-VoI", 1);

        }
    }
}
