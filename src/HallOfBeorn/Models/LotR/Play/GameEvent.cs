using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public enum GameEventType
    {
        CharactersCommittedToQuest,
        CharactersDeclaredAsAttackers,
        CharactersDeclaredAsDefenders,
        CharactersEnteredPlay,
        CharactersLeftPlay,

        EnemyInitatesAttack,
        LocationIsExplored,

        PlayersQuestSuccessfully,
        PlayersQuestUnsuccessfully,
        PlayersTravelToLocation,

        PlayerEngagesEnemy,
    }

    public class GameEvent
    {
        public uint Number { get; set; }
        public GameEventType EventType { get; set; }
        public string Description { get; set; }
        public Trigger Trigger { get; set; }
        public List<Player> Players = new List<Player>();
        public List<CardInDeck> CardsInDeck = new List<CardInDeck>();
        public List<CardInDiscard> CardsInDiscard = new List<CardInDiscard>();
        public List<CardInHand> CardsInHand = new List<CardInHand>();
        public List<CardInPlay> CardsInPlay = new List<CardInPlay>();
        public List<CardOutOfPlay> CardsInVictory = new List<CardOutOfPlay>();
        public List<CardOutOfPlay> CardsRemovedFromGame = new List<CardOutOfPlay>();
        public List<CardOutOfPlay> CardsEnteringPlay = new List<CardOutOfPlay>();
        public List<CardInPlay> CardsLeavingPlay = new List<CardInPlay>();

        public List<CardInPlay> Attackers = new List<CardInPlay>();
        public List<CardInPlay> Defenders = new List<CardInPlay>();

        public GameEvent Next { get; set; }
    }
}
