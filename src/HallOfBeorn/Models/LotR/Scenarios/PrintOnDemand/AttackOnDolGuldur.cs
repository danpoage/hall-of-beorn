using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Scenarios.PrintOnDemand
{
    public class AttackOnDolGuldur : Scenario
    {
        private const string setName = "Attack on Dol Guldur";

        public AttackOnDolGuldur()
        {
            Title = setName;
            AlternateTitle = "Assault on Dol Guldur";
            ProductName = setName;
            GroupName = "GenCon";
            Number = 8;

            //QuestCompanionUrl = "http://lotr-lcg-quest-companion.com/print-on-demand-quest-.html";

            AddEncounterSet(EncounterSet.AttackOnDolGuldur);

            AddQuestCardId("Assault-on-the-Golden-Wood-AoDG");
            AddQuestCardId("Crossing-the-Anduin-AoDG");
            AddQuestCardId("The-Siege-of-Dol-Guldur-AoDG");
            AddQuestCardId("The-Tower-of-Sorcery-C-AoDG");
            AddQuestCardId("Battle-Under-the-Trees-E-AoDG");
            AddQuestCardId("Dungeons-of-the-Necromancer-G-AoDG");
        }
    }
}