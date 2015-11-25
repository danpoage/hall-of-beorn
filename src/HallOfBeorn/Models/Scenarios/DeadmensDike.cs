namespace HallOfBeorn.Models.Scenarios
{
    public class DeadmensDike : Scenario
    {
        public DeadmensDike()
        {
            Title = "Deadmen's Dike";
            ProductName = "The Lost Realm";
            GroupName = "The Lost Realm";
            Number = 3;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-lost-realm-quest-deadmens-dike.html";

            AddEncounterSet(EncounterSet.CursedDead);
            AddEncounterSet(EncounterSet.DarkSorcery);
            AddEncounterSet(EncounterSet.DeadmensDike);
            AddEncounterSet(EncounterSet.Iarion);

            AddQuestCardId("The-Shades-of-Angmar-TLR");
            AddQuestCardId("A-Fell-Wraith-TLR");

            ExcludeFromEasyMode("Cursed-Dead-TLR", 1);
            ExcludeFromEasyMode("Dead-Lord-TLR", 1);
            ExcludeFromEasyMode("Restless-Evil-TLR", 1);
            ExcludeFromEasyMode("Dark-Sorcery-TLR", 1);
            ExcludeFromEasyMode("Heavy-Curse-TLR", 2);
            ExcludeFromEasyMode("Terror-of-the-North-TLR", 1);
            ExcludeFromEasyMode("Broken-Battlements-TLR", 1);
            ExcludeFromEasyMode("Deadmen's-Gate-TLR", 1);
            ExcludeFromEasyMode("Haunted-Keep-TLR", 1);
            ExcludeFromEasyMode("Thaurdir's-Damned-TLR", 2);
            ExcludeFromEasyMode("Unnatural-Fog-TLR", 1);

        }
    }
}
