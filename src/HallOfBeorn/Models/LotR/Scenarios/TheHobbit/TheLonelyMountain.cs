namespace HallOfBeorn.Models.LotR.Scenarios.TheHobbit
{
    public class TheLonelyMountain : Scenario
    {
        public TheLonelyMountain()
        {
            Title = "The Lonely Mountain";
            ProductName = "The Hobbit: On the Doorstep";
            GroupName = "The Hobbit";
            IsSubGroup = true;
            Number = 5;

            QuestCompanionSlug = "the-hobbit-on-the-doorstep-quest-the-lonely-mountain";

            AddEncounterSet(EncounterSet.TheLonelyMountain);
            AddEncounterSet(EncounterSet.TheLonelyMountainNightmare);
            AddEncounterSet(EncounterSet.Wilderland);

            AddQuestCardId("A-Warm-Welcome-THOtD");
            AddQuestCardId("The-Burglar's-Turn-THOtD");
            AddQuestCardId("Inside-Information-THOtD");
            AddQuestCardId("Thieves-Fire-Murder-THOtD");

            ExcludeFromEasyMode("Dragon-Spell-THOtD", 2);
            ExcludeFromEasyMode("Great-Hall-THOtD", 3);
            ExcludeFromEasyMode("Pretending-to-Sleep-THOtD", 3);
            ExcludeFromEasyMode("Fighting-Among-Friends-THOtD", 2);
            ExcludeFromEasyMode("Weighed-Down-THOtD", 1);

            ExcludeFromNightmareMode("Belching-Fire-THOtD", 4);
            ExcludeFromNightmareMode("Secret-Entrance-THOtD", 2);
            ExcludeFromNightmareMode("Western-Slopes-THOtD", 3);
            ExcludeFromNightmareMode("Dark-Bats-THOtD", 3);
            ExcludeFromNightmareMode("Fighting-Among-Friends-THOtD", 2);
        }
    }
}
