using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using HallOfBeorn.Models.RingsDb;
//using HallOfBeorn.Services.LotR;
//using HallOfBeorn.Services.LotR.RingsDb;

namespace RingsDbBuilder
{
    public class Program
    {
        private const string title = "RingsDB Popularity Ranker v1.0.8 (2018-12-26)";

        public static void Main(string[] args)
        {
            Console.WriteLine(title);

            var helper = new RingsDbHelper();
            var options = new Options();
            var cardLinkBuilder = new CardLinkBuilder(options);
            var popularityBuilder = new PopularityBuilder(options);

            for (var deckId = options.MinimumDeckId; deckId <= options.MaximumDeckId; deckId++)
            {
                var info = new DeckInfo(options, deckId);
                var strategy = new Strategy(options, helper, cardLinkBuilder, popularityBuilder);
                strategy.Execute(info);
            }

            cardLinkBuilder.PrintLinks();
            popularityBuilder.PrintHeroPopularity();
            popularityBuilder.PrintCardPopularity();
        }
    }
}
