﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Player
    {
        public Player(
            string name, Deck deck, IEnumerable<LotRCard> heroes, LotRCard contract)
        {
            Name = name;
            Deck = deck;
            SetupHandSize = 6;

            foreach (var hero in heroes)
            {
                var heroCard = new CardInPlay(deck, hero);
                Heroes.Add(heroCard);
            }

            if (contract != null)
            {
                var contractCard = new CardInPlay(deck, contract);
                Contract = contractCard;
                PlayArea.Add(contractCard);
            }
        }

        public string Name { get; private set; }
        public Deck Deck { get; private set; }
        
        public readonly List<CardInHand> Hand = new List<CardInHand>();
        public readonly List<CardInPlay> Heroes = new List<CardInPlay>();
        public readonly CardInPlay Contract;

        public PlayerStatus PlayerStatus { get; set; }
        public SetupStep SetupStep { get; set; }
        public FrameworkStep FrameworkStep { get; set; }

        public bool IsFirstPlayer { get; set; }
        public bool IsActivePlayer { get; set; }

        //Planning Phase
        public CardInHand CardToPlay { get; set; }
        public bool HasKeptActionOpportunity { get; set; }
        public bool HasPassedOnActionOpportunity { get; set; }
        
        public byte Threat { get; set; }
        public byte SetupHandSize { get; set; }

        public bool HasKeptSetupHand { get; set; }
        public bool HasTakenMulligan { get; set; }

        public readonly List<CardInPlay> PlayArea = new List<CardInPlay>();

        public IEnumerable<Effect> GetEffectsByTrigger(
            Func<string, CardSide, IEnumerable<Effect>> lookupEffects, Trigger trigger)
        {
            var effects = new List<Effect>();

            effects.AddRange(Hand.SelectMany(
                    c => lookupEffects(c.Card.Slug, CardSide.Front)));

            effects.AddRange(PlayArea.SelectMany(
                c => lookupEffects(c.Card.Slug, CardSide.Front)));

            return effects;
        }
    }
}
