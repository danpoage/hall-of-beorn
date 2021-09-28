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
        private readonly Dictionary<string, int> _contractTally = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _createdTally = new Dictionary<string, int>();
        private readonly Dictionary<string, int> _unknownCards = new Dictionary<string, int>();

        private const string addHeroFormat     = "            addHeroPopularity(\"{0}\", {1});";
        private const string addCardFormat     = "            addCardPopularity(\"{0}\", {1});";
        private const string addContractFormat = "            addContractPopularity(\"{0}\", {1});";

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

        public void TallyHeroCard(string cardId, byte weight)
        {
            if (!_heroTally.ContainsKey(cardId))
            {
                _heroTally[cardId] = 0;
            }
            
            //Console.WriteLine(string.Format("  Hero {0} +1", slug));

            _heroTally[cardId] += 1 * weight;
        }

        private HashSet<string> contractIds = new HashSet<string>
        {
            "21074", //Fellowship
            "22024", //Burglar's Turn
            "22049", //Forth, the Three Hunters
            "22074", //Grey Wanderer
            "22091", //Council of the Wise
            "22134", //Messenger of the King
            "22147", //Bond of Friendship
            "300085", //The Last Alliance,
            "500042", //Into the West
        };

        public void TallyPlayerCard(string cardId, int quantity, byte weight)
        {
            if (contractIds.Contains(cardId))
            {
                TallyContractCard(cardId, quantity, weight);
                return;
            }

            if (!_cardTally.ContainsKey(cardId))
            {
                _cardTally[cardId] = 0;
            }

            var baseline = 10;
            if (quantity > 1)
                baseline += 5;
            if (quantity > 2)
                baseline += 2;

            var score = baseline * weight;
            //Console.WriteLine(string.Format("  Player Card {0} + {1}", slug, quantity));

            _cardTally[cardId] += score;
        }

        public void TallyContractCard(string cardId, int quantity, byte weight)
        {
            if (!_contractTally.ContainsKey(cardId))
            {
                _contractTally[cardId] = 0;
            }

            //Console.WriteLine(string.Format("  Player Card {0} + {1}", slug, quantity));

            _contractTally[cardId] += quantity * weight;
        }


        public void PrintHeroPopularity()
        {
            Console.WriteLine();
            Console.WriteLine("        private void initializeHeroPopularity()");
            Console.WriteLine("        {");

            foreach (var tally in _heroTally.Keys.OrderByDescending(x => _heroTally[x]))
            {
                Console.WriteLine(string.Format(addHeroFormat, tally, _heroTally[tally]));
            }

            Console.WriteLine("        }");
        }

        public void PrintCardPopularity()
        {
            Console.WriteLine();
            Console.WriteLine("        private void initializeCardPopularity()");
            Console.WriteLine("        {");

            foreach (var tally in _cardTally.Keys.OrderByDescending(x => _cardTally[x]))
            {
                Console.WriteLine(string.Format(addCardFormat, tally, _cardTally[tally]));
            }

            Console.WriteLine("        }");
        }

        public void PrintContractPopularity()
        {
            Console.WriteLine();
            Console.WriteLine("        private void initializeContractPopularity()");
            Console.WriteLine("        {");

            foreach (var tally in _contractTally.Keys.OrderByDescending(x => _contractTally[x]))
            {
                Console.WriteLine(string.Format(addContractFormat, tally, _contractTally[tally]));
            }

            Console.WriteLine("        }");
        }
    }
}
