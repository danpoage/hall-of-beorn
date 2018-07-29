namespace HallOfBeorn.Models.LotR.Scenarios.TheRingMaker
{
    public class TheDunlandTrap : Scenario
    {
        public TheDunlandTrap()
        {
            Title = "The Dunland Trap";
            ProductName = "The Dunland Trap";
            GroupName = "The Ring-maker";
            Number = 1;

            QuestCompanionSlug = "the-ring-maker-quest-the-dunland-trap";
            DifficultyRating = 7.5f;
            Votes = 42;

            AddTheGreyCompanyLink("https://www.youtube.com/watch?v=HtZcKbz47cY", Title, "https://i.ytimg.com/vi/HtZcKbz47cY/hqdefault.jpg");
            AddTheLineUnbrokenLink("37 part 1", "OcL2vnzviIo");
            AddTheLineUnbrokenLink("37 parts 2 and 3", "-cpEbISzWdM");
            AddMrUnderhillLink(Title + " - Two Players", "ozV8st3pqfY");
            AddMrUnderhillLink(Title + " Nightmare Mode - Two Players", "fo2vWh0Ku8w");
            AddThematicNightmareLink("https://darklingdoor.wordpress.com/2018/03/27/nightmare-the-dunland-trap/");
            AddWarriorsOfTheWestLink("https://warriorsofthewestblog.wordpress.com/2016/10/08/warriors-of-the-west-the-dunland-trap/", Title);

            AddEncounterSet(EncounterSet.DunlandWarriors);
            AddEncounterSet(EncounterSet.TheDunlandTrap);
            AddEncounterSet(EncounterSet.WearyTravelers);
            AddEncounterSet(EncounterSet.TheDunlandTrapNightmare);

            AddQuestCardId("The-Road-to-Tharbad-TDT");
            AddQuestCardId("A-Well-Laid-Trap-TDT");
            AddQuestCardId("No-Way-Out-TDT");

            ExcludeFromEasyMode("Dunland-Chieftain-VoI", 2);
            ExcludeFromEasyMode("Wild-Men-of-Dunland-VoI", 1);
            ExcludeFromEasyMode("Boar-Clan-Stalker-TDT", 1);
            ExcludeFromEasyMode("Hills-of-Dunland-TDT", 2);
            ExcludeFromEasyMode("Hithaeglir-Foothills-TDT", 1);
            ExcludeFromEasyMode("In-Need-of-Rest-VoI", 1);
            ExcludeFromEasyMode("Low-on-Provisions-VoI", 1);

            ExcludeFromNightmareMode("Boar-Clan-Warrior-TDT", 4);
            ExcludeFromNightmareMode("Hithaeglir-Stream-TDT", 4);
            ExcludeFromNightmareMode("Plains-of-Enedwaith-TDT", 3);
            ExcludeFromNightmareMode("Dunlending-Ambush-TDT", 1);
            ExcludeFromNightmareMode("Frenzied-Attack-TDT", 1);
            ExcludeFromNightmareMode("Low-on-Provisions-VoI", 1);
        }
    }
}
