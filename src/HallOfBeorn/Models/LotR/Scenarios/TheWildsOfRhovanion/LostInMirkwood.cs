using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.TheWildsOfRhovanion
{
    public class LostInMirkwood : Scenario
    {
        public LostInMirkwood()
        {
            Title = "Lost in Mirkwood";
            ProductName = "The Wilds of Rhovanion";
            GroupName = "The Wilds of Rhovanion";
            Number = 2;
 
            RulesImageCount = 7;

            AddPlayLink(LinkType.Warriors_of_the_West, "https://warriorsofthewestblog.wordpress.com/2018/07/11/turn-by-turn-report-lost-in-mirkwood/", "Turn by Turn - Lost in Mirkwood");

            AddEncounterSet(EncounterSet.DarkWoods);
            AddEncounterSet(EncounterSet.GatheringGloom);
            AddEncounterSet(EncounterSet.PassageThroughMirkwood);
            AddEncounterSet(EncounterSet.SpidersOfMirkwood);
            AddEncounterSet(EncounterSet.DolGuldurOrcs);
            AddEncounterSet(EncounterSet.LostInMirkwood);

            AddQuestCardId("Ambushed-at-Night-TWoR");
            AddQuestCardId("Spiders-of-Mirkwood-TWoR");
            AddQuestCardId("Dol-Guldur-Orcs-C-TWoR");
            AddQuestCardId("Carried-Away-TWoR");
            AddQuestCardId("Truly-Lost-C-TWoR");
            AddQuestCardId("The-Forest-of-Great-Fear-TWoR");
            AddQuestCardId("Escape-from-Taur-nu-fuin-C-TWoR");
            
            ExcludeFromEasyMode("Accursed-Forest-TWoR", 1);
            ExcludeFromEasyMode("Dark-Black-Woods-TWoR", 1);
            ExcludeFromEasyMode("Gathering-Gloom-TWoR", 1);
            ExcludeFromEasyMode("Swarm-of-Bats-TWoR", 1);
            ExcludeFromEasyMode("Twilight-Hall-TWoR", 1);
            ExcludeFromEasyMode("Mirkwood-Patrol-TWoR", 1);
            ExcludeFromEasyMode("Ravenous-Spider-TWoR", 1);
            ExcludeFromEasyMode("Unseen-Danger-TWoR", 1);

            //Spiders of Mirkwood (Core)
            ExcludeFromEasyMode("Hummerhorns-Core", 1);
            ExcludeFromEasyMode("Eyes-of-the-Forest-Core", 1);
            ExcludeFromEasyMode("Caught-in-a-Web-Core", 2);

            //Dol Guldur Orcs (Core)
            ExcludeFromEasyMode("Chieftan-Ufthak-Core", 1);
            ExcludeFromEasyMode("Dol-Guldur-Beastmaster-Core", 1);
            ExcludeFromEasyMode("The-Necromancer's-Reach-Core", 2);
            ExcludeFromEasyMode("Necromancer's-Pass-Core", 2);
        }
    }
}