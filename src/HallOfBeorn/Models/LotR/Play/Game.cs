using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Game
    {
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

        public List<GameEvent> EventLog = new List<GameEvent>();
    }
}
