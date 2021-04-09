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
        public Strategy(Options options, RingsDbHelper helper, 
            CardLinkBuilder cardLinkBuilder, PopularityBuilder popularityBuilder, DeckCardBuilder deckCardBuilder)
        {
            _options = options;
            _analyzer = new DeckAnalyzer(helper, cardLinkBuilder, popularityBuilder, deckCardBuilder);

            _steps.Add((info) => { return new DownloadJson(_options).Execute(info); });
            _steps.Add((info) => { return new DeckWriter(_options).Execute(info); });
            _steps.Add((info) => { return new ReadFileJson(_options).Execute(info); });
            _steps.Add((info) => { return new DeckReader(_options).Execute(info); });
            _steps.Add((info) => { return _analyzer.Execute(info); });
        }

        private readonly Options _options;
        private readonly DeckAnalyzer _analyzer;
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
