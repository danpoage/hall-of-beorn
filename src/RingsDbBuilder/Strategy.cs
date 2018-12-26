using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingsDbBuilder
{
    public class Strategy
    {
        public Strategy(Options options, RingsDbHelper helper, CardLinkBuilder cardLinkBuilder, PopularityBuilder popularityBuilder)
        {
            _options = options;
            _helper = helper;
            _cardLinkBuilder = cardLinkBuilder;
            _popularityBuilder = popularityBuilder;
        }

        private readonly Options _options;
        private readonly RingsDbHelper _helper;
        private readonly CardLinkBuilder _cardLinkBuilder;
        private readonly PopularityBuilder _popularityBuilder;
        
        private const string errorFormat = "Error executing deck stategy for Deck ID {0}: {1}";

        public void Execute(int deckId)
        {
            try
            {
                var path = _options.GetFilePath(deckId);
                var json = string.Empty;
                var exists = File.Exists(path);

                //Console.WriteLine(string.Format("JSON file {0} exists? {1}", path, exists));

                if (exists)
                {
                    json = new ReadFileJson(_options).GetDeckString(deckId);
                }
                else
                {
                    json = new DownloadJson(_options).GetDeckString(deckId);
                    new DeckWriter(_options).WriteDeckFile(deckId, json);
                }

                var deck = new DeckReader().ReadDeck(deckId, json);

                if (deck == null)
                    return;

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
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, deckId, ex.Message));
            }
        }
    }
}
