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

            _steps.Add((info) => { return new DownloadJson(_options).Execute(info); });
            _steps.Add((info) => { return new DeckWriter(_options).Execute(info); });
            _steps.Add((info) => { return new ReadFileJson(_options).Execute(info); });
            _steps.Add((info) => { return new DeckReader().Execute(info); });
            _steps.Add((info) => { return new DeckAnalyzer(_helper, _cardLinkBuilder, _popularityBuilder).Execute(info); });
        }

        private readonly Options _options;
        private readonly RingsDbHelper _helper;
        private readonly CardLinkBuilder _cardLinkBuilder;
        private readonly PopularityBuilder _popularityBuilder;

        private readonly List<Func<DeckInfo, bool>> _steps = new List<Func<DeckInfo, bool>>();

        private const string errorFormat = "Error executing deck stategy for Deck ID {0}: {1}";

        public void Execute(DeckInfo info)
        {
            try
            {
                foreach (var step in _steps)
                {
                    var success = step(info);

                    if (!success)
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format(errorFormat, info.DeckId, ex.Message));
            }
        }
    }
}
