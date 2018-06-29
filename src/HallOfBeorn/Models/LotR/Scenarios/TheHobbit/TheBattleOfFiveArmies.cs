namespace HallOfBeorn.Models.LotR.Scenarios.TheHobbit
{
    public class TheBattleOfFiveArmies : Scenario
    {
        public TheBattleOfFiveArmies()
        {
            Title = "The Battle of Five Armies";
            ProductName = "The Hobbit: On the Doorstep";
            GroupName = "The Hobbit";
            IsSubGroup = true;
            Number = 6;

            QuestCompanionSlug = "the-hobbit-on-the-doorstep-quest-the-battle-of-five-armies";

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
