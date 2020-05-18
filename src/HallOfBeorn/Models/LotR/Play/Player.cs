using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Player
    {
        public Player(string name, Deck deck, IEnumerable<LotRCard> heroes)
        {
            Name = name;
            Deck = deck;

            foreach (var hero in heroes)
            {
                var heroCard = new CardInPlay(deck, hero);
                Heroes.Add(heroCard);
            }
        }

        public string Name { get; private set; }
        public Deck Deck { get; private set; }
        
        public readonly List<CardInHand> Hand = new List<CardInHand>();
        public readonly List<CardInPlay> Heroes = new List<CardInPlay>();

        public PlayerStatus PlayerStatus { get; set; }
        public SetupStep SetupStep { get; set; }
        public FrameworkStep FrameworkStep { get; set; }

        public bool IsFirstPlayer { get; set; }
        public bool IsActivePlayer { get; set; }
        public byte Threat { get; set; }
        public byte SetupHandSize { get; set; }
        public readonly List<CardInPlay> PlayArea = new List<CardInPlay>();
    }
}
