using System;
using System.Collections.Generic;
using System.Text;

using HallOfBeorn.Models;

namespace HallOfBeorn.Data
{
    public class CardBuilder
    {
        public CardBuilder(CardSet cardSet)
        {
            this.cardSet = cardSet;
        }

        private readonly CardSet cardSet;
        private readonly Card card = new Card();

        public CardBuilder Hero(string title, byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Hero;
            card.Quantity = 1;
            card.Stats.SetHeroStats(threatCost, sphere, willpower, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder Ally(string title, Sphere sphere, byte resourceCost, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Ally;
            card.Quantity = 3;
            card.Stats.SetAllyStats(resourceCost, sphere, willpower, attack, defense, hitPoints);
            return this;
        }

        public CardBuilder Attachment(string title, Sphere sphere, byte resourceCost)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Ally;
            card.Quantity = 3;
            card.Stats.SetCostAndSphere(resourceCost, sphere);
            return this;
        }

        public CardBuilder Event(string title, Sphere sphere, byte resourceCost)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Event;
            card.Quantity = 3;
            card.Stats.SetCostAndSphere(resourceCost, sphere);
            return this;
        }

        public CardBuilder PlayerSideQuest(string title, Sphere sphere, byte resourceCost, byte questPoints)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Player_Side_Quest;
            card.Quantity = 3;
            card.Stats.SetCostAndSphere(resourceCost, sphere);
            card.Stats.SetQuestPoints(questPoints);
            return this;
        }

        public CardBuilder Contract(string title)
        {
            card.Title = new Content(title);
            card.CardType = CardType.Contract;
            card.Quantity = 1;
            return this;
        }

        public CardBuilder WithThumbnail()
        {
            //NOTE: This can be removed
            return this;
        }

        public CardBuilder WithYear(ushort year)
        {
            return this;
        }

        public CardBuilder WithTraits(params string[] traits)
        {
            foreach (var trait in traits)
            {
                card.Traits.Add(new Content(trait));
            }
            return this;
        }

        public CardBuilder WithKeywords(params string[] keywords)
        {
            foreach (var keyword in keywords)
            {
                card.Keywords.Add(new Content(keyword));
            }
            return this;
        }

        public CardBuilder WithTextLine(string text)
        {
            if (!card.Front.TextBox.ContainsKey(TextType.Text))
            {
                card.Front.TextBox[TextType.Text] = new Content(text);
            }
            else
            {
                card.Front.TextBox[TextType.Text] =
                    card.Front.TextBox[TextType.Text].AppendLine(text);
            }

            return this;
        }

        public CardBuilder WithInfo(byte number, byte quantity, Artist artist)
        {
            card.Number = number;
            card.Quantity = quantity;
            card.Front.Artists.Add(artist);
            return this;
        }

        public Card ToCard()
        {
            return card;
        }
    }
}
