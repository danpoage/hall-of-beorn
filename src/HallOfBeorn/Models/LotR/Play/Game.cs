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
        public uint RoundNumber { get; set; }
        public Phase Phase { get; set; }

        public SetupStep SetupStep { get; set; }
        public FrameworkStep FrameworkStep { get; set; }
        public EffectType EffectType { get; set; }

        public Scenario Scenario { get; set; }
        public GameMode Mode { get; set; }

        public List<Player> Players = new List<Player>();

        public List<CardInPlay> StagingArea = new List<CardInPlay>();
        public List<CardInPlay> ActiveLocations = new List<CardInPlay>();
        public List<CardOutOfPlay> VictoryDisplay = new List<CardOutOfPlay>();
        public List<CardOutOfPlay> RemovedFromGame = new List<CardOutOfPlay>();

        public Deck EncounterDeck { get; set; }
        public Deck SecondaryEncounterDeck { get; set; }

        public Deck PrimaryQuestDeck { get; set; }
        public LotRCard MainPrimaryQuest { get; set; }

        public Deck SecondaryQuestDeck { get; set; }
        public LotRCard MainSecondaryQuest { get; set; }

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
        public GameSegment NextSegement { get; set; }
        public Choice CurrentChoice { get; set; }
    }
}
