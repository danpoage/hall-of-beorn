using System;
using System.Collections.Generic;
using System.Text;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class CardSetBuilder
    {
        public CardSetBuilder(string name, string abbreviation, ushort number, SetType setType)
        {
            cardSet.Name = name;
            cardSet.Abbreviation = abbreviation;
            cardSet.Number = number;
            cardSet.SetType = setType;
        }
        private readonly CardSet cardSet = new CardSet();
        private readonly List<CardBuilder> cardBuilders = new List<CardBuilder>();
        
        public CardBuilder addHero(
            string title, byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var cardBuilder = new CardBuilder(cardSet);
            cardBuilders.Add(cardBuilder);

            return cardBuilder;
        }
    }
}
