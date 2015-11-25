namespace HallOfBeorn.Models.Scenarios
{
    public class JourneyAlongTheAnduin : Scenario
    {
        public JourneyAlongTheAnduin()
        {
            Title = "Journey Along the Anduin";
            AlternateTitle = "Journey Down the Anduin";
            ProductName = "Core Set";
            GroupName = "Core Set";
            Number = 2;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/core-set-quest-journey-down-the-anduin.html";

            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduin);
            AddEncounterSet(EncounterSet.JourneyAlongTheAnduinNightmare);
            AddEncounterSet(EncounterSet.SauronsReach);
            AddEncounterSet(EncounterSet.Wilderlands);

            AddQuestCardId("To-the-River-Core");
            AddQuestCardId("Anduin-Passage-Core");
            AddQuestCardId("Ambush-on-the-Shore-Core");

            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Gladden-Fields-Core", 2);
            ExcludeFromEasyMode("Massing-at-Night-Core", 1);
            ExcludeFromEasyMode("Eastern-Crows-Core", 2);
            ExcludeFromEasyMode("Evil-Storm-Core", 1);
            ExcludeFromEasyMode("Despair-Core", 2);
            ExcludeFromEasyMode("Hill-Troll-Core", 1);
            ExcludeFromEasyMode("Marsh-Adder-Core", 1);

        }
    }
}
