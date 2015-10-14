namespace HallOfBeorn.Models.Scenarios
{
    public class TroubleInTharbad : Scenario
    {
        public TroubleInTharbad()
        {
            Title = "Trouble in Tharbad";
            ProductName = "Trouble in Tharbad";
            GroupName = "The Ring-maker";
            Number = 0;

            AddEncounterSet(EncounterSet.MistyMountainOrcs);
            AddEncounterSet(EncounterSet.TroubleInTharbad);

            AddQuestCardId("Double-Dealings-TiT");
            AddQuestCardId("Escape-from-Tharbad-TiT");

            ExcludeFromEasyMode("Orc-Hound-VoI", 1);
            ExcludeFromEasyMode("Orc-Hunter-VoI", 2);
            ExcludeFromEasyMode("Bellach's-Marauder-TiT", 1);
            ExcludeFromEasyMode("Conspicuous-Lot-TiT", 1);
            ExcludeFromEasyMode("Get-That-Dwarf-TiT", 1);
            ExcludeFromEasyMode("Ruins-of-the-Second-Age-TiT", 1);
            ExcludeFromEasyMode("Seedy-Inn-TiT", 1);

        }
    }
}
