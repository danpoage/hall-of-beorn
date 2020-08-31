using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class EncounterSetBuilder
    {
        public EncounterSetBuilder(CardSet cardSet, string name)
        {
            this.cardSet = cardSet;
            encounterSet = new EncounterSet(cardSet, name, cards);
        }

        private readonly CardSet cardSet;
        private readonly EncounterSet encounterSet;
        private readonly List<Card> cards = new List<Card>();

        private readonly List<CardBuilder> cardBuilders = new List<CardBuilder>();

        private CardBuilder addCardBuilder()
        {
            var cardBuilder = new CardBuilder(cardSet, encounterSet);
            cardBuilders.Add(cardBuilder);
            return cardBuilder;
        }

        public CardBuilder addObjective(string title)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Objective(title);
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

        public CardBuilder addObjectiveLocation(string title, byte? questPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.ObjectiveLocation(title, questPoints);
        }

        public CardBuilder addEnemy(string title, byte? engagementCost, byte threat, byte? attack, byte? defense, byte? hitPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Enemy(title, engagementCost, threat, attack, defense, hitPoints);
        }

        public CardBuilder addLocation(string title, byte? threat, byte? questPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Location(title, threat, questPoints);
        }

        public CardBuilder addTreachery(string title)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Treachery(title);
        }

        public CardBuilder addEncounterSideQuest(string title, byte? questPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.EncounterSideQuest(title, questPoints);
        }

        public CardBuilder addQuest(string title, byte stageNumber, byte? oppositeStageNumber, char stageLetter, byte? questPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Quest(title, stageNumber, oppositeStageNumber, stageLetter, questPoints);
        }

        public EncounterSet ToEncounterSet()
        {
            cards.AddRange(cardBuilders.Select(
                builder => builder.ToCard()));
            
            return encounterSet;
        }
    }
}
