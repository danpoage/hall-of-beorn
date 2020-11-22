using System;

namespace RingsDbBuilder
{
    public class Program
    {
        private const string title = "RingsDB Helper v1.1.0 (2020-05-21)";

        public static void Main(string[] args)
        {
            Console.WriteLine(title);

            var helper = new RingsDbHelper();
            var options = new Options(args) { Verbose = false };
            var cardLinkBuilder = new CardLinkBuilder(options);
            var popularityBuilder = new PopularityBuilder(options);
            var deckCardBuilder = new DeckCardBuilder(options);

            deckCardBuilder.Init();

            var strategy = new Strategy(options, helper, 
                cardLinkBuilder, popularityBuilder, deckCardBuilder);

            for (var deckId = options.MinimumDeckId; deckId <= options.MaximumDeckId; deckId++)
            {
                var info = new DeckInfo(options, deckId);
                strategy.Execute(info);
            }

            cardLinkBuilder.PrintLinks();
            popularityBuilder.PrintHeroPopularity();
            popularityBuilder.PrintContractPopularity();
            popularityBuilder.PrintCardPopularity();
        }
    }
}
