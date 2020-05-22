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
        public Game()
        {
            Mode = GameMode.Normal;
        }

        public uint RoundNumber { get; set; }
        public Phase Phase { get; set; }

        public SetupStep SetupStep { get; set; }
        public FrameworkStep FrameworkStep { get; set; }
        public EffectType EffectType { get; set; }

        private byte GetQuantity(ScenarioCard card)
        {
            if (Mode == GameMode.Easy)
                return (byte)card.EasyQuantity;
            else if (Mode == GameMode.Nightmare)
                return (byte)card.NightmareQuantity;
            else return (byte)card.NormalQuantity;
        }

        public Scenario Scenario { get; set; }

        public GameMode Mode { get; set; }

        public List<Player> Players = new List<Player>();

        public List<CardInPlay> StagingArea = new List<CardInPlay>();
        public List<CardInPlay> ActiveLocations = new List<CardInPlay>();
        public List<CardOutOfPlay> VictoryDisplay = new List<CardOutOfPlay>();
        public List<CardOutOfPlay> RemovedFromGame = new List<CardOutOfPlay>();

        public Deck EncounterDeck { get; set; }
        public Deck SecondaryEncounterDeck { get; set; }

        public Deck QuestDeck { get; set; }
        public CardInPlay MainQuest { get; set; }

        public Deck SecondaryQuestDeck { get; set; }
        public CardInPlay MainSecondaryQuest { get; set; }

        public PendingEffects PendingEffects = new PendingEffects();

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

        public GameSegment CurrentSegment { get; set; }
        public List<GameSegment> Segments { get; set; }
        public Choice CurrentChoice { get; set; }
    }
}
