using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class ScenarioQuestCard
    {
        public ScenarioQuestCard(Card quest)
        {
            _quest = quest;

            EasyModeQuantity = 1;
            NormalModeQuantity = 1;
            NightmareModeQuantity = 1;
        }

        Card _quest;

        public Card Quest { get { return _quest; } }
        public string Title { get { return _quest.Title; } }
        public string OppositeTitle { get { return _quest.OppositeTitle; } }
        public uint StageNumber { get { return _quest.StageNumber; } }
        public bool IsNightmare { get { return _quest.EncounterSet.EndsWith(" Nightmare"); } }
        public IEnumerable<EncounterSet> IncludedEncounterSets { get { return _quest.IncludedEncounterSets; } }
        public byte EasyModeQuantity { get; set; }
        public byte NormalModeQuantity { get; set; }
        public byte NightmareModeQuantity { get; set; }
    }
}