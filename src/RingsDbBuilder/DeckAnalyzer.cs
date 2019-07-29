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

        public bool Execute(DeckInfo info)
        {
            var deck = info.Deck;
            if (deck == null)
                return false;

            var deckId = deck.id.ToString();

            _cardLinkBuilder.ClearMap();
            _popularityBuilder.TallyCreateDate(deck.date_creation);

            foreach (var heroId in deck.heroes.Keys)
            {
                var slug = _helper.GetSlug(heroId);
                if (string.IsNullOrEmpty(slug))
                {
                    _popularityBuilder.TallyUnknownCard(heroId);
                }

                _popularityBuilder.TallyHeroCard(heroId);
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
                    
                _popularityBuilder.TallyPlayerCard(cardId, quantity);
                _cardLinkBuilder.MapCard(cardId, quantity);
            }

            _cardLinkBuilder.GenerateLinks();
            _deckCardBuilder.AddDeckCards(deck);

            return true;
        }
    }
}
