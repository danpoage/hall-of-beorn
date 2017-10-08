using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheLordOfTheRings
{
    public class MountDoom : Scenario
    {
        public MountDoom()
        {
            Title = "Mount Doom";
            ProductName = "The Mountain of Fire";
            GroupName = "The Lord of the Rings";
            Number = 18;

            //QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/.html";

            AddEncounterSet(EncounterSet.MountDoom);
            AddEncounterSet(EncounterSet.DeepShadows);
            AddEncounterSet(EncounterSet.MountainOfFireEpicMultiplayer);

            AddQuestCardId("The-Land-of-Mordor-TMoF");
            AddQuestCardId("The-Road-to-Isenmouthe-TMoF");
            AddQuestCardId("The-Last-Gasp-TMoF");
            AddQuestCardId("The-Crack-of-Doom-TMoF");

            //Mount Doom
            ExcludeFromEasyMode("Orc-hold-TMoF", 1);
            ExcludeFromEasyMode("Mordor-Road-TMoF", 1);
            ExcludeFromEasyMode("Brake-of-Thorns-TMoF", 1);
            ExcludeFromEasyMode("Ringwraith-of-Sauron-TMoF", 1);
            ExcludeFromEasyMode("Orc-Captain-TMoF", 1);
            ExcludeFromEasyMode("Little-Snuffler-TMoF", 2);
            ExcludeFromEasyMode("'Wicked-Master'-TMoF", 1);
            ExcludeFromEasyMode("The-Lidless-Eye-TMoF", 1);
            ExcludeFromEasyMode("Foul-Fumes-TMoF", 1);
            ExcludeFromEasyMode("Heavy-and-Tired-TMoF", 1);

            //Deep Shadows
            ExcludeFromEasyMode("Drawn-to-the-Ring-TMoF", 1);
            ExcludeFromEasyMode("Deep-Shadows-TMoF", 1);
        }
    }
}