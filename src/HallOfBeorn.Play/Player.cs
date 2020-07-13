using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Play
{
    public class Player
        : Target
    {
        public Player(
            string name, Deck deck, IEnumerable<LotRCard> heroes, LotRCard contract)
            : base(name)
        {
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

        public uint GetAvailableResources(Sphere sphere)
        {
            uint count = 0;

            foreach (var hero in Heroes)
            {
                if (hero.HasSphere(sphere))
                {
                    count += hero.ResourceTokens;
                }
            }

            return count;
        }

        public Dictionary<Sphere, uint> GetResourceMap()
        {
            var resources = new Dictionary<Sphere, uint> {
                    { Sphere.Neutral, 0},
                    { Sphere.Leadership, 0},
                    { Sphere.Tactics, 0 },
                    { Sphere.Spirit, 0 },
                    { Sphere.Lore, 0 },
                    { Sphere.Baggins, 0 },
                    { Sphere.Fellowship, 0 },
                    { Sphere.Mastery, 0 }
                };

            var spheres = new HashSet<Sphere>
            {
                Sphere.Neutral, Sphere.Leadership, Sphere.Tactics, Sphere.Spirit, Sphere.Lore,
                Sphere.Baggins, Sphere.Fellowship, Sphere.Mastery
            };

            foreach (var hero in Heroes)
            {
                foreach (var sphere in spheres)
                {
                    if (hero.HasSphere(sphere))
                    {
                        resources[sphere] += hero.ResourceTokens;
                    }
                }
            }

            return resources;
        }
    }
}
