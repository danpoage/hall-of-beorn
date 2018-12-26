using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingsDbBuilder
{
    public class PopularityBuilder
    {
        public PopularityBuilder(Options options)
        {
            _options = options;
        }

        private readonly Options _options;
        private readonly Dictionary<string, int> _heroTally = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _cardTally = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _createdTally = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _unknownCards = new Dictionary<string, int>();

        private const string addHeroFormat = "            addHeroPopularity(\"{0}\", {1});";
        private const string addCardFormat = "            addCardPopularity(\"{0}\", {1});";

        public void TallyCreateDate(string createDate)
        {
            if (string.IsNullOrEmpty(createDate) || createDate.Length < 10)
                return;

            var key = createDate.Substring(0, 10);
            if (!_createdTally.ContainsKey(key)) {
                _createdTally[key] = 0;
            }
            
            _createdTally[key] += 1;
        }

        public void TallyUnknownCard(string cardId)
        {
            if (!_unknownCards.ContainsKey(cardId))
            {
                _unknownCards[cardId] = 0;
            }
            
            _unknownCards[cardId] += 1;
        }

        public void TallyHeroCard(string cardId)
        {
            if (!_heroTally.ContainsKey(cardId))
            {
                _heroTally[cardId] = 0;
            }
            
            //Console.WriteLine(string.Format("  Hero {0} +1", slug));

            _heroTally[cardId] += 1;
        }

        public void TallyPlayerCard(string cardId, int quantity)
        {
            if (!_cardTally.ContainsKey(cardId))
            {
                _cardTally[cardId] = 0;
            }

            //Console.WriteLine(string.Format("  Player Card {0} + {1}", slug, quantity));

            _cardTally[cardId] += quantity;
        }

        public void PrintHeroPopularity()
        {
            Console.WriteLine();
            Console.WriteLine("HERO POPULARITY");

            foreach (var tally in _heroTally.Keys.OrderByDescending(x => _heroTally[x]))
            {
                Console.WriteLine(string.Format(addHeroFormat, tally, _heroTally[tally]));
            }
        }

        public void PrintCardPopularity()
        {
            Console.WriteLine();
            Console.WriteLine("CARD POPULARITY");

            foreach (var tally in _cardTally.Keys.OrderByDescending(x => _cardTally[x]))
            {
                Console.WriteLine(string.Format(addCardFormat, tally, _cardTally[tally]));
            }
        }
    }
}
