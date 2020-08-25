using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class CardSetBuilder
    {
        public CardSetBuilder()
        {
        }

        public CardSetBuilder(string name, string abbreviation, ushort number, SetType setType)
        {
            cardSet.Name = new Content(name);
            cardSet.Abbreviation = abbreviation;
            cardSet.Number = number;
            cardSet.SetType = setType;
        }

        private readonly CardSet cardSet = new CardSet();
        private readonly List<CardBuilder> cardBuilders = new List<CardBuilder>();
        
        protected virtual void Initialize()
        {
        }

        public CardBuilder addHero(
            string title, byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var cardBuilder = new CardBuilder(cardSet);
            cardBuilders.Add(cardBuilder);

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
            foreach (var cardBuilder in cardBuilders)
            {
                cardSet.Cards.Add(cardBuilder.ToCard());
            }
            return cardSet;
        }
    }
}
