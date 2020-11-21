using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn.Models.RingsDb;

namespace RingsDbBuilder
{
    public class DeckAnalyzer
    {
        public DeckAnalyzer(RingsDbHelper helper, 
            CardLinkBuilder cardLinkBuilder, PopularityBuilder popularityBuilder, DeckCardBuilder deckCardBuilder)
        {
            _helper = helper;
            _cardLinkBuilder = cardLinkBuilder;
            _popularityBuilder = popularityBuilder;
            _deckCardBuilder = deckCardBuilder;
        }

        private readonly RingsDbHelper _helper;
        private readonly CardLinkBuilder _cardLinkBuilder;
        private readonly PopularityBuilder _popularityBuilder;
        private readonly DeckCardBuilder _deckCardBuilder;

        private string SetId(string cardId)
        {
            return cardId.Length == 5
                ? cardId.Substring(0, 2)
                : cardId.Substring(0, 3);
        }

        private byte DeckWeight(RingsDbDeckList deck)
        {
            byte minChron = 1;
            byte maxChron = 1;

            foreach (var heroId in deck.heroes.Keys)
            {
                var heroSetId = SetId(heroId);
                var heroChron = SetChron(heroSetId);
                if (heroChron > maxChron)
                {
                    maxChron = heroChron;
                }
            }

            foreach (var cardId in deck.slots.Keys)
            {
                var cardSetId = SetId(cardId);
                var cardChron = SetChron(cardSetId);
                if (cardChron > maxChron)
                {
                    maxChron = cardChron;
                }
            }

            return Convert.ToByte((maxChron - minChron) + 1);
        }

        private byte SetChron(string setId)
        {
            byte chron = 1;
            switch (setId)
            {
                //1 3 5 7 9  11 16 18 21
                //2 4 6 8 10 12 17 19 22
                //The Hobbit
                case "131":
                case "132":
                    return 23;
                //The Lord of the Rings
                case "141":
                case "142":
                case "143":
                    return 24;
                case "144":
                case "145":
                case "146":
                    return 25;
                default:
                    return byte.TryParse(setId, out chron)
                        ? chron
                        : (byte)1;
            }
        }

        public bool Execute(DeckInfo info)
        {
            var deck = info.Deck;
            if (deck == null)
                return false;

            var deckId = deck.id.ToString();

            _cardLinkBuilder.ClearMap();
            _popularityBuilder.TallyCreateDate(deck.date_creation);

            var weight = DeckWeight(info.Deck);

            foreach (var heroId in deck.heroes.Keys)
            {
                var slug = _helper.GetSlug(heroId);
                if (string.IsNullOrEmpty(slug))
                {
                    _popularityBuilder.TallyUnknownCard(heroId);
                }

                _popularityBuilder.TallyHeroCard(heroId, weight);
                _cardLinkBuilder.MapCard(heroId, 1);
            }

            foreach (var cardId in deck.slots.Keys)
            {
                var slug = _helper.GetSlug(cardId);
                if (string.IsNullOrEmpty(slug))
                {
                    _popularityBuilder.TallyUnknownCard(cardId);
                }

                var quantity = deck.slots[cardId];
                
                _popularityBuilder.TallyPlayerCard(cardId, quantity, weight);
                _cardLinkBuilder.MapCard(cardId, quantity);
            }

            _cardLinkBuilder.GenerateLinks();
            _deckCardBuilder.AddDeckCards(deck);

            return true;
        }
    }
}
