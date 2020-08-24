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
            currentNumber = cardSet.FirstCardNumber;
        }

        private readonly CardSet cardSet;
        private readonly Card card = new Card();
        private ushort currentNumber;

        public CardBuilder Hero(string title, byte threatCost, Sphere sphere, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            card.Title = title;
            card.CardType = CardType.Hero;
            card.Number = currentNumber;
            card.Quantity = 1;
            card.Stats.Add(new Stat(StatType.Sphere, (byte)sphere));
            card.Stats.Add(new Stat(StatType.Threat_Cost, threatCost));
            card.Stats.Add(new Stat(StatType.Willpower, willpower));
            card.Stats.Add(new Stat(StatType.Attack, attack));
            card.Stats.Add(new Stat(StatType.Defense, defense));
            card.Stats.Add(new Stat(StatType.Hit_Points, hitPoints));

            return this;
        }

        public CardBuilder WithThumbnail()
        {
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
                var parsed = trait.ParseTrait(Language.EN);
                if (parsed == null)
                {
                    continue;
                }
                card.Traits.Add(parsed.Value);
            }
            return this;
        }

        public CardBuilder WithKeywords(params string[] keywords)
        {
            foreach (var keyword in keywords)
            {
                var parsed = keyword.ParseKeyword(Language.EN);
                if (parsed == null)
                {
                    continue;
                }
                card.Keywords.Add(parsed.Value);
            }
            return this;
        }

        public CardBuilder WithTextLine(string text)
        {
            var lang = Language.EN;

            if (!card.Text.ContainsKey(lang))
            {
                card.Text[lang] = text;
            }
            else
            {
                card.Text[lang] += Environment.NewLine + text;
            }

            return this;
        }

        public Card ToCard()
        {
            return card;
        }
    }
}
