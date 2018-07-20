namespace HallOfBeorn.Models.LotR.Scenarios.ShadowsOfMirkwood
{
    public class AJourneyToRhosgobel : Scenario
    {
        public AJourneyToRhosgobel()
        {
            Title = "A Journey to Rhosgobel";
            ProductName = "A Journey to Rhosgobel";
            GroupName = "Shadows of Mirkwood";
            Number = 3;

            QuestCompanionSlug = "shadows-of-mirkwood-quest-a-journey-to-rhosgobel";

            DifficultyRating = 6.1f;
            Votes = 84;

            AddProgressionSeriesLink("6", "dLJeHba9PFg");
            AddTheLineUnbrokenLink("6", "nMyk9ujtN14");
            AddBeornsPathLink("https://hallofbeorn.wordpress.com/2013/07/28/beorns-path-part-10-a-journey-to-rhosgobel/");

            AddEncounterSet(EncounterSet.AJourneyToRhosgobel);
            AddEncounterSet(EncounterSet.AJourneyToRhosgobelNightmare);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);

            AddQuestCardId("The-Wounded-Eagle-AJtR");
            AddQuestCardId("Radagast's-Request-AJtR");
            AddQuestCardId("Return-to-Rhosgobel-AJtR");

            ExcludeFromEasyMode("Exhaustion-AJtR", 3);
            ExcludeFromEasyMode("Festering-Wounds-AJtR", 1);
            ExcludeFromEasyMode("Swarming-Insects-AJtR", 3);
            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Caught-in-a-Web-Core", 2);
            ExcludeFromEasyMode("Eyes-of-the-Forest-Core", 1);
            ExcludeFromEasyMode("Hummerhorns-Core", 1);

            ExcludeFromNightmareMode("Exhaustion-AJtR", 1);
            ExcludeFromNightmareMode("Festering-Wounds-AJtR", 1);
            ExcludeFromNightmareMode("Forest-Grove-AJtR", 4);
            ExcludeFromNightmareMode("Swarming-Insects-AJtR", 2);
            ExcludeFromNightmareMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromNightmareMode("Dol-Guldur-Beastmaster-Core", 2);
            ExcludeFromNightmareMode("Driven-by-Shadow-Core", 1);
            ExcludeFromNightmareMode("Enchanted-Stream-Core", 2);
            ExcludeFromNightmareMode("Necromancer's-Pass-Core", 2);
            ExcludeFromNightmareMode("The-Necromancer's-Reach-Core", 1);
            ExcludeFromNightmareMode("Mountains-of-Mirkwood-Core", 3);
        }
    }
}
