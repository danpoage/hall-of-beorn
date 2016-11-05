namespace HallOfBeorn.Models.LotR.Scenarios
{
    public class TheBattleOfFiveArmies : Scenario
    {
        public TheBattleOfFiveArmies()
        {
            Title = "The Battle of Five Armies";
            ProductName = "The Hobbit: On the Doorstep";
            GroupName = "The Hobbit";
            Number = 6;

            QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/the-hobbit-on-the-doorstep-quest-the-battle-of-five-armies.html";

            AddEncounterSet(EncounterSet.TheBattleOfFiveArmies);
            AddEncounterSet(EncounterSet.TheBattleOfFiveArmiesNightmare);
            AddEncounterSet(EncounterSet.Wilderland);

            AddQuestCardId("The-Gathering-of-the-Clouds-THOtD");
            AddQuestCardId("The-Eastern-Spur-THOtD");
            AddQuestCardId("Battle-in-the-Dale-THOtD");
            AddQuestCardId("The-Defense-of-Ravenhill-THOtD");
            AddQuestCardId("The-Clouds-Burst-THOtD");

            ExcludeFromEasyMode("Goblins-are-Upon-You-THOtD", 2);
            ExcludeFromEasyMode("Hatred-Rekindled-THOtD", 1);
            ExcludeFromEasyMode("Northern-Slopes-THOtD", 1);
            ExcludeFromEasyMode("Ravenous-Warg-THOtD", 2);
            ExcludeFromEasyMode("Vanguard-of-Bolg-THOtD", 1);
            ExcludeFromEasyMode("Fighting-Among-Friends-THOtD", 2);
            ExcludeFromEasyMode("Weighed-Down-THOtD", 1);

        }
    }
}
