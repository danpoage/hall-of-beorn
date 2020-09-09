using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models
{
    public class Scenario
        : INamed
    {
        public Scenario(byte number, EncounterSet mainEncounterSet, List<EncounterSet> includedEncounterSets)
        {
            Number = number;
            Name = new Content(mainEncounterSet.Name.Text);
            MainEncounterSet = mainEncounterSet;
            this.includedEncounterSets = includedEncounterSets;

            nightmareSetup = includedEncounterSets.SelectMany(es => es.Cards)
                .Where(card => card.CardType == CardType.Nightmare_Setup)
                .FirstOrDefault();

            foreach (var card in mainEncounterSet.Cards)
            {
                AddCard(card);
            }

            foreach (var card in includedEncounterSets.SelectMany(es => es.Cards))
            {
                AddCard(card);
            }
        }
        
        private readonly List<EncounterSet> includedEncounterSets = new List<EncounterSet>();
        private readonly List<ScenarioCard> quests = new List<ScenarioCard>();
        private readonly List<ScenarioCard> cards = new List<ScenarioCard>();
        private readonly Card nightmareSetup;

        private void AddCard(Card card)
        {
            if (card.CardType == CardType.Quest)
            {
                quests.Add(new ScenarioCard(card, nightmareSetup));
            }
            else
            {
                cards.Add(new ScenarioCard(card, nightmareSetup));
            }
        }

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
