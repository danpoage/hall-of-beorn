using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Play
{
    public enum GameMode
    {
        Easy,
        Normal,
        Nightmare,
    }

    public enum CardSide
    {
        Front,
        Back
    }

    public class Game
    {
        public Game(
            Func<string, LotRCard> lookupCard,
            Func<string, CardSide, IEnumerable<Effect>> lookupEffects)
        {
            this.lookupCard = lookupCard;
            this.lookupEffects = lookupEffects;
        }

        private readonly Func<string, LotRCard> lookupCard;
        private readonly Func<string, CardSide, IEnumerable<Effect>> lookupEffects;

        public uint RoundNumber { get; set; }
        public Phase Phase { get; set; }
        public FrameworkStep FrameworkStep { get; set; }

        public Scenario Scenario { get; set; }

        public List<Player> Players = new List<Player>();

        public List<CardInPlay> StagingArea = new List<CardInPlay>();
        public List<CardInPlay> ActiveLocations = new List<CardInPlay>();
        public List<CardOutOfPlay> VictoryDisplay = new List<CardOutOfPlay>();
        public List<CardOutOfPlay> RemovedFromGame = new List<CardOutOfPlay>();

        public Deck EncounterDeck { get; set; }
        public Deck SecondaryEncounterDeck { get; set; }

        public Deck QuestDeck { get; set; }
        public LotRCard MainQuest { get; set; }

        public Deck SecondaryQuestDeck { get; set; }
        public LotRCard MainSecondaryQuest { get; set; }

        public void AddEffect(Effect effect)
        {
            Log("Add effect: " + effect.ToString());
            //TODO: Figure out where to add each effect
        }

        public List<Effect> ConstantEffects = new List<Effect>();
        public List<Effect> EndOfPhaseEffects = new List<Effect>();
        public List<Effect> EndOfRoundEffects = new List<Effect>();

        private uint eventCount = 0;
        public void Log(string description)
        {
            Log(new GameEvent { Description = description });
        }
        public void Log(GameEvent entry)
        {
            eventCount++;
            entry.Number = eventCount;
            GameEvents.Add(entry);
        }
        public List<GameEvent> GameEvents = new List<GameEvent>();

        public Choice CurrentChoice { get; set; }
        
        public void SelectOptions(IEnumerable<Option> options)
        {
            CurrentChoice.SelectOptions(this, options);
        }

        public void ExecuteEffect(Effect effect)
        {

        }

        public void AddScenario(Scenario scenario, GameMode mode)
        {
            Scenario = scenario;

            Func<ScenarioQuestCard, int> getQuestCardQuantity = (qc) => {
                if (mode == GameMode.Easy) return qc.EasyModeQuantity;
                else if (mode == GameMode.Nightmare) return qc.NightmareModeQuantity;
                else return qc.NormalModeQuantity;
            };

            Func<ScenarioCard, int> getEncounterCardQuantity = (sc) => {
                if (mode == GameMode.Easy) return sc.EasyQuantity;
                else if (mode == GameMode.Nightmare) return sc.NightmareQuantity;
                else return sc.NormalQuantity;
            };

            QuestDeck = new Deck { Name = scenario.Title + " Quest Deck" };
            QuestDeck.Load(scenario.QuestCards.Select(qc => 
                new Tuple<LotRCard, byte>(lookupCard(qc.Slug), (byte)getQuestCardQuantity(qc)))
            );

            EncounterDeck = new Deck { Name = scenario.Title + " Encounter Deck" };
            EncounterDeck.Load(scenario.ScenarioCards.Select(qc => 
                new Tuple<LotRCard, byte>(lookupCard(qc.Slug), (byte)getEncounterCardQuantity(qc)))
            );

            Log("Add Scenario: " + scenario.Title + " [" + mode.ToString() + " Mode]");
        }

        public void AddPlayerDeck(Deck deck)
        {
            Players.Add(new Player { Deck = deck });
            Log(string.Format("Add Player Deck {0}", deck.Name ?? deck.DeckId));
        }

        public void SetupScenario()
        {
            if (Scenario == null || QuestDeck == null)
            {
                Log(new GameEvent{ Description = "Scenario and Quest Deck not defined" });
                return;
            }

            Log("Setup Scenario: " + Scenario.Title);

            var firstQuest = QuestDeck.Cards.FirstOrDefault();

            var effects = lookupEffects(firstQuest.Card.Slug, CardSide.Front);

            foreach (var effect in effects)
            {
                AddEffect(effect);
            }
        }

        public void Run()
        {
        }
    }
}
