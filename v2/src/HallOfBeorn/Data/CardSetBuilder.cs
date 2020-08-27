using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class CardSetBuilder
    {
        public CardSetBuilder(Product product)
        {
        }

        public CardSetBuilder(Product product, string name, string abbreviation, ushort number, SetType setType)
        {
            this.product = product;
            this.name = new Content(name);
            this.abbreviation = abbreviation;
            this.number = number;
            this.setType = setType;
        }

        private readonly Product product;
        private readonly Content name;
        private readonly string abbreviation;
        private readonly ushort number;
        private readonly SetType setType;
        private CardSet cardSet;
        private readonly List<CardBuilder> cardBuilders = new List<CardBuilder>();
        private readonly List<EncounterSet> encounterSets = new List<EncounterSet>();

        protected virtual void Initialize()
        {
        }

        private CardBuilder addCardBuilder()
        {
            var cardBuilder = new CardBuilder(cardSet);
            cardBuilders.Add(cardBuilder);
            return cardBuilder;
        }

        public CardBuilder addHero(
            string title, byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Hero(title, threatCost, sphere, willpower, attack, defense, hitPoints);
        }

        public CardBuilder addAlly(
            string title, byte resourceCost, Sphere sphere, bool isUnique, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var cardBuilder = new CardBuilder(cardSet);
            cardBuilders.Add(cardBuilder);

            return cardBuilder.Ally(title, sphere, resourceCost, willpower, attack, defense, hitPoints);
        }

        public CardSet ToCardSet()
        {
            var playerCards = new List<Card>();
            foreach (var cardBuilder in cardBuilders)
            {
                playerCards.Add(cardBuilder.ToCard());
            }
            var encounterSets = new List<EncounterSet>();

            cardSet = new CardSet(product, playerCards, encounterSets)
            {
                Name = name,
                Abbreviation = abbreviation,
                Number = number,
                SetType = setType,
            };
            return cardSet;
        }
    }
}
