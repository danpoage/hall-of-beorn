using System;

namespace HallOfBeorn.Models.LotR.Scenarios.AShadowInTheEast
{
    public class TheTempleOfDoomScenario : AShadowInTheEastScenario
    {
        private const string name = "The Temple of Doom";

        public TheTempleOfDoomScenario()
        {
            Title = name;
            ProductName = "A Shadow in the East";
            GroupName = "A Shadow in the East";
            Number = 3;

            RulesImageCount = 10;

            QuestCompanionSlug = "a-shadow-in-the-east-deluxe-expansion-quest-the-temple-of-doom";
            DifficultyRating = 8.2f;
            Votes = 12;

            AddVisionOfThePalantirLink("https://visionofthepalantir.com/2020/11/19/the-temple-of-doom/");

            AddEncounterSet(EncounterSet.TheTempleOfDoom);
            AddEncounterSet(EncounterSet.UlchorsGuard);
            AddEncounterSet(EncounterSet.TwistedTunnels);
            AddEncounterSet(EncounterSet.EasterlingRaiders);
            AddEncounterSet(EncounterSet.ThePowerOfMordor);

            AddQuestCardId("The-Forgotten-Temple-ASitE");
            AddQuestCardId("The-Legacy-of-Mordor-ASitE");
            AddQuestCardId("Memory-of-the-Dark-Years-ASitE");
            AddQuestCardId("Shrine-to-Sauron-ASitE");
            AddQuestCardId("The-Lord-of-Middle-earth-ASitE");

            ExcludeTheTempleOfDoomFromEasyMode();
            ExcludeUlchorsGuardFromEasyMode();
            ExcludeTwistedTunnelsFromEasyMode();
            ExcludeEasterlingRaidersFromEasyMode();
        }
    }
}
