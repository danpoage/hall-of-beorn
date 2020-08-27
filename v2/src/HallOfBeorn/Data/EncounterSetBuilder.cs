using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class EncounterSetBuilder
    {
        public EncounterSetBuilder(CardSet cardSet, string name)
        {
            this.cardSet = cardSet;
            encounterSet = new EncounterSet(cardSet, name);
        }

        private readonly CardSet cardSet;
        private readonly EncounterSet encounterSet;
        private readonly List<CardBuilder> cardBuilders = new List<CardBuilder>();

        private CardBuilder addCardBuilder()
        {
            var cardBuilder = new CardBuilder(cardSet, encounterSet);
            cardBuilders.Add(cardBuilder);
            return cardBuilder;
        }

        public CardBuilder addObjectiveHero(string title, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.ObjectiveHero(title, willpower, attack, defense, hitPoints);
        }

        public CardBuilder addObjectiveAlly(string title, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.ObjectiveAlly(title, willpower, attack, defense, hitPoints);
        }

        public EncounterSet ToEncounterSet()
        {
            foreach (var builder in cardBuilders)
            {
                encounterSet.Cards.Add(builder.ToCard());
            }

            return encounterSet;
        }
    }
}
