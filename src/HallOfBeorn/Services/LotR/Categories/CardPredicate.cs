using System;
using System.Collections.Generic;
using System.Linq;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Categories
{
    public class CardPredicate<T>
    {
        public CardPredicate(T category)
        {
            this.category = category;
        }

        private readonly T category;
        private readonly List<Func<LotRCard, bool>> predicates = new List<Func<LotRCard, bool>>();
        private readonly List<Func<LotRCard, bool>> exclusions = new List<Func<LotRCard, bool>>();

        public T Category { get { return category; } }

        public CardPredicate<T> Or(Func<LotRCard,bool> predicate)
        {
            predicates.Add(predicate);
            return this;
        }

        public CardPredicate<T> Not(Func<LotRCard, bool> predicate)
        {
            exclusions.Add(predicate);
            return this;
        }

        public CardPredicate<T> Titles(params string[] titles)
        {
            return Or(card => titles.Any(title => card.NormalizedTitle.ContainsLower(title)));
        }

        public CardPredicate<T> Hero(string title)
        {
            return Or(card => card.CardType == CardType.Hero
                && card.NormalizedTitle.ContainsLower(title));
        }

        public CardPredicate<T> Hero(string title, Sphere sphere)
        {
            return Or(card => card.CardType == CardType.Hero
                && card.NormalizedTitle.ContainsLower(title) && card.Sphere == sphere);
        }

        public CardPredicate<T> Ally(string title)
        {
            return Or(card => card.CardType == CardType.Ally
                && card.NormalizedTitle.ContainsLower(title));
        }

        public CardPredicate<T> Ally(string title, Sphere sphere)
        {
            return Or(card => card.CardType == CardType.Ally
                && card.NormalizedTitle.ContainsLower(title) && card.Sphere == sphere);
        }

        public CardPredicate<T> Trait(string trait)
        {
            return Or(card => 
                card.NormalizedTraits.Any(cardTrait => cardTrait == trait));
        }

        public CardPredicate<T> TraitAndAnyText(string trait, params string[] tokens)
        {
            return Or(card => 
                card.NormalizedTraits.Any(cardTrait => cardTrait == trait)
                && tokens.Any(token => card.Text.ContainsLower(token)));
        }

        public CardPredicate<T> AllTraits(params string[] traits)
        {
            return Or(card => 
                traits.All(t => card.NormalizedTraits.Any(nt => nt == t)));
        }

        public CardPredicate<T> AllText(params string[] tokens)
        {
            return Or(card =>
                tokens.All(token => card.Text.ContainsLower(token)));
        }

        public CardPredicate<T> AnyText(params string[] tokens)
        {
            return Or(card =>
                tokens.Any(token => card.Text.ContainsLower(token)));
        }

        public CardPredicate<T> NotAnyText(params string[] tokens)
        {
            return Or(card =>
                !tokens.Any(token => card.Text.ContainsLower(token)));
        }

        public bool Eval(LotRCard card)
        {
            if (exclusions.Any(ex => ex(card)))
            {
                return false;
            }

            return predicates.Any(f => f(card));
        }
    }
}