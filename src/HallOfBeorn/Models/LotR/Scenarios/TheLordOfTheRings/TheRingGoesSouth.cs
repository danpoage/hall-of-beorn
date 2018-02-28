namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class TheRingGoesSouth : Scenario
    {
        public TheRingGoesSouth()
        {
            Title = "The Ring Goes South";
            ProductName = "The Road Darkens";
            GroupName = "The Lord of the Rings";
            Number = 4;

            QuestCompanionSlug = "lotr-the-road-darkens-quest-the-ring-goes-south";

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
