using System;
using System.Collections.Generic;

namespace HallOfBeorn.Models
{
    public class Scenario
        : INamed
    {
        public Scenario(byte number, EncounterSet mainEncounterSet, IEnumerable<EncounterSet> includedEncounterSets)
        {
            Number = number;
            Name = new Content(mainEncounterSet.Name.Text);
            MainEncounterSet = mainEncounterSet;
        }
        
        private readonly List<EncounterSet> includedEncounterSets = new List<EncounterSet>();
        private readonly List<ScenarioCard> quests = new List<ScenarioCard>();
        private readonly List<ScenarioCard> cards = new List<ScenarioCard>();

        //public INamed CardSet => cardSet;
        //public INamed NightmareCardSet => nightmareCardSet;
        public Content Name { get; }
        public ushort Number { get; }
        public EncounterSet MainEncounterSet { get; }
        public IReadOnlyList<EncounterSet> IncludedEncounterSets => includedEncounterSets;
        public IReadOnlyList<ScenarioCard> Quests => quests;
        public IReadOnlyList<ScenarioCard> Cards => cards;
    }
}
