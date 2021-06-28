using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services
{
    public class CardRepository<TRepo, TGroup, TProduct, TCardSet, TCard> : ICardRepository<TCard>
        where TRepo: IProductRepository<TGroup, TProduct, TCardSet, TCard>
        where TGroup: IProductGroup<TProduct, TCardSet, TCard>
        where TProduct: IProduct<TProduct, TCardSet, TCard>
        where TCardSet: ICardSet<TProduct, TCard>
        where TCard: ICard
    {
        public CardRepository(TRepo productRepository)
        {
            foreach (var product in productRepository.Products())
            {
                foreach (var cardSet in product.CardSets)
                {
                    //Player cards (and quest/encounter cards for old-style sets)
                    foreach (var card in cardSet.Cards)
                    {
                        AddCard(card);
                    }
                }
            }
        }

        private readonly List<TCard> cards = new List<TCard>();
        private readonly Dictionary<string, TCard> cardsBySlug = new Dictionary<string, TCard>();

        protected void AddCard(TCard card)
        {
            var slug = card.Slug.ToLower();

            if (cardsBySlug.ContainsKey(slug))
                return;

            cards.Add(card);
            cardsBySlug.Add(slug, card);
        }

        private IEnumerable<LotRCard> FindCardByTypeSuffix(string slug, string suffix)
        {
            Func<LotRCard, bool> predicate = null;

            switch (suffix)
            {
                case "xally":
                    predicate = (card) => card.CardType == CardType.Ally;
                    break;
                case "xhero":
                    predicate = (card) => card.CardType == CardType.Hero;
                    break;
                case "xleadership":
                    predicate = (card) => card.Sphere == Sphere.Leadership;
                    break;
                case "xleadershiphero":
                    predicate = (card) => card.Sphere == Sphere.Leadership && card.CardType == CardType.Hero;
                    break;
                case "xleadershipally":
                    predicate = (card) => card.Sphere == Sphere.Leadership && card.CardType == CardType.Ally;
                    break;
                case "xlore":
                    predicate = (card) => card.Sphere == Sphere.Lore;
                    break;
                case "xlorehero":
                    predicate = (card) => card.Sphere == Sphere.Lore && card.CardType == CardType.Hero;
                    break;
                case "xloreally":
                    predicate = (card) => card.Sphere == Sphere.Lore && card.CardType == CardType.Ally;
                    break;
                case "xneutral":
                    predicate = (card) => card.Sphere == Sphere.Neutral;
                    break;
                case "xneutralhero":
                    predicate = (card) => card.Sphere == Sphere.Neutral && card.CardType == CardType.Hero;
                    break;
                case "xneutralally":
                    predicate = (card) => card.Sphere == Sphere.Neutral && card.CardType == CardType.Ally;
                    break;
                case "xspirit":
                    predicate = (card) => card.Sphere == Sphere.Spirit;
                    break;
                case "xspirithero":
                    predicate = (card) => card.Sphere == Sphere.Spirit && card.CardType == CardType.Hero;
                    break;
                case "xspiritally":
                    predicate = (card) => card.Sphere == Sphere.Spirit && card.CardType == CardType.Ally;
                    break;
                case "xtactics":
                    predicate = (card) => card.Sphere == Sphere.Tactics;
                    break;
                case "xtacticshero":
                    predicate = (card) => card.Sphere == Sphere.Tactics && card.CardType == CardType.Hero;
                    break;
                case "xtacticsally":
                    predicate = (card) => card.Sphere == Sphere.Tactics && card.CardType == CardType.Ally;
                    break;
                default:
                    break;
            }

            return predicate != null
                ? LotRCards().Where(c => c.Slug.ToLower().StartsWith(slug) 
                    && c.CardSetName != "Two-Player Limited Edition Starter"
                    && predicate(c))
                : Enumerable.Empty<LotRCard>();
        }

        protected virtual IEnumerable<TCard> FindPartialMatches(string normalizedSlug)
        {
            var tokens = normalizedSlug.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            if (typeof(TCard) == typeof(LotRCard) &&
                tokens.Length > 0 && tokens[tokens.Length-1].StartsWith("x"))
            {
                var slugArray = new string[tokens.Length-1];
                Array.Copy(tokens, slugArray, tokens.Length-1);
                var slug = string.Join("-", slugArray);
                var suffix = tokens[tokens.Length-1];
                return FindCardByTypeSuffix(slug, suffix)
                    .Cast<TCard>();
            }

            return Cards().Where(card => (card.Slug.ToLower().StartsWith(normalizedSlug) 
                || card.AlternateSlug.ToLowerSafe().Contains(normalizedSlug))
                && card.CardSetName != "Two-Player Limited Edition Starter")
                .ToList();
        }

        public IEnumerable<TCard> Cards(Language? lang, Action<TCard, Language> translate)
        {
            if (lang.GetValueOrDefault(Language.EN) == Language.EN)
            {
                return cards;
            }

            foreach (var card in cards)
            {
                translate(card, lang.Value);
            }
            return cards;
        }

        public IEnumerable<TCard> Cards()
        {
            return cards;
        }

        public IEnumerable<LotRCard> LotRCards()
        {
            return cards.Cast<LotRCard>();
        }

        public TCard FindBySlug(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return default(TCard);

            var normalizedSlug = slug.ToLowerSafe();

            if (cardsBySlug.ContainsKey(normalizedSlug))
                return cardsBySlug[normalizedSlug];

            var partials = FindPartialMatches(normalizedSlug);
            if (partials.Count() == 1)
                return partials.First();

            return default(TCard);
        }
    }
}