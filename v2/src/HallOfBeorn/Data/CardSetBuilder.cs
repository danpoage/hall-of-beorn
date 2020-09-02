using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class CardSetBuilder
    {
        public CardSetBuilder(Product product, string name, string abbreviation, ushort number, SetType setType)
        {
            cardSet = new CardSet(product, name, abbreviation, number, setType, playerCards, encounterSets);
        }
        
        private readonly CardSet cardSet;
        private readonly List<Card> playerCards = new List<Card>();
        private readonly List<EncounterSet> encounterSets = new List<EncounterSet>();

        private readonly List<CardBuilder> playerCardBuilders = new List<CardBuilder>();
        private readonly List<EncounterSetBuilder> encounterSetBuilders = new List<EncounterSetBuilder>();

        private CardBuilder addCardBuilder()
        {
            var builder = new CardBuilder(cardSet);
            playerCardBuilders.Add(builder);
            return builder;
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
            var cardBuilder = addCardBuilder();
            return cardBuilder.Ally(title, sphere, resourceCost, willpower, attack, defense, hitPoints);
        }

        public CardBuilder addAttachment(
            string title, byte resourceCost, Sphere sphere, bool isUnique)
        {
            var cardBuilder = addCardBuilder();
            return isUnique
                ? cardBuilder.Attachment(title, sphere, resourceCost).WithUnique()
                : cardBuilder.Attachment(title, sphere, resourceCost);
        }

        public CardBuilder addEvent(
            string title, byte resourceCost, Sphere sphere)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Event(title, sphere, resourceCost);
        }

        public CardBuilder addPlayerSideQuest(
            string title, byte resourceCost, Sphere sphere, byte questPoints)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.PlayerSideQuest(title, sphere, resourceCost, questPoints);
        }

        public CardBuilder addContract(
            string title)
        {
            var cardBuilder = addCardBuilder();
            return cardBuilder.Contract(title);
        }

        public EncounterSetBuilder EncounterSet(string name)
        {
            var builder = new EncounterSetBuilder(cardSet, name);
            encounterSetBuilders.Add(builder);
            return builder;
        }
        
        public EncounterSetBuilder EncounterSet(string name, string alternateName)
        {
            var builder = new EncounterSetBuilder(cardSet, name, alternateName);
            encounterSetBuilders.Add(builder);
            return builder;
        }

        public CardSet ToCardSet()
        {
            playerCards.AddRange(
                playerCardBuilders.Select(builder => builder.ToCard()));

            encounterSets.AddRange(
                encounterSetBuilders.Select(builder => builder.ToEncounterSet()));
            
            return cardSet;
        }
    }
}
