using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class ScenarioQuestCard
    {
        public ScenarioQuestCard(LotRCard quest, 
            byte easyModeQuantity, byte normalModeQuantity, byte nightmareModeQuantity)
        {
            _quest = quest;

            EasyModeQuantity = easyModeQuantity;
            NormalModeQuantity = normalModeQuantity;
            NightmareModeQuantity = nightmareModeQuantity;
        }

        LotRCard _quest;

        public LotRCard Quest { get { return _quest; } }
        public string Title { get { return _quest.Title; } }
        public string Slug { get { return _quest.Slug; } }
        public string OppositeTitle { get { return _quest.OppositeTitle; } }
        public uint StageNumber { get { return _quest.StageNumber; } }
        public char StageLetter { get { return _quest.StageLetter; } }
        public bool IsNightmare { get { return _quest.EncounterSet.EndsWith(" Nightmare"); } }
        public IEnumerable<EncounterSet> IncludedEncounterSets { get { return _quest.IncludedEncounterSets; } }
        public byte EasyModeQuantity { get; private set; }
        public byte NormalModeQuantity { get; private set; }
        public byte NightmareModeQuantity { get; private set; }
    }
}