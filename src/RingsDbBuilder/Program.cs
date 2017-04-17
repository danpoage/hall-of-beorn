using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using HallOfBeorn.Models.RingsDb;
using HallOfBeorn.Services.LotR;

namespace RingsDbBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RingsDB Popularity Ranker");

            var productRepo = new ProductRepository();
            var cardRepo = new CardRepository(productRepo);
            var lookupService = new RingsDbService(cardRepo);

            var heroTally = new Dictionary<string, int>();
            var cardTally = new Dictionary<string, int>();

            var unknownCards = new List<string>();

            using (var client = new System.Net.Http.HttpClient())
            {
                const int maxDeckId = 4969;
                RingsDbDeckList deck;
                var slug = string.Empty;
                var quantity = 0;
                //const int mainDeckMultiplier = 4;
                //const int sideboardMultiplier = 1;

                for (var i = 1; i <= maxDeckId; i++) {
                    var url = string.Format("http://ringsdb.com/api/public/decklist/{0}.json", i);
                    var response = client.GetAsync(url).Result;

                    System.Threading.Thread.Sleep(2000);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content;
                        string responseString = responseContent.ReadAsStringAsync().Result;

                        deck = null;
                        try {
                            deck = Newtonsoft.Json.JsonConvert.DeserializeObject<RingsDbDeckList>(responseString);
                        } catch (Exception ex) {
                            Console.WriteLine("ERROR: " + ex.Message);
                        }

                        if (deck == null) {
                            continue;
                        }

                        foreach (var heroId in deck.heroes.Keys)
                        {
                            slug = lookupService.GetSlug(heroId);
                            if (string.IsNullOrEmpty(slug)) {
                                unknownCards.Add(heroId);
                                //continue;
                            }

                            if (!heroTally.ContainsKey(heroId)) {
                                heroTally[heroId] = 0;
                            }

                            //Console.WriteLine(string.Format("  Hero {0} +1", slug));

                            heroTally[heroId] += 1;
                        }

                        foreach (var cardId in deck.slots.Keys)
                        {
                            slug = lookupService.GetSlug(cardId);
                            if (string.IsNullOrEmpty(slug)) {
                                unknownCards.Add(cardId);
                                //continue;
                            }

                            if (!cardTally.ContainsKey(cardId)) {
                                cardTally[cardId] = 0;
                            }

                            quantity = deck.slots[cardId];

                            //Console.WriteLine(string.Format("  Player Card {0} + {1}", slug, quantity));

                            cardTally[cardId] += quantity;
                        }

                        /*
                        foreach (var cardId in deck.sideslots.Keys)
                        {
                            if (!cardScores.ContainsKey(cardId)) {
                                cardScores[cardId] = 0;
                            }

                            cardScores[cardId] += sideboardMultiplier;
                        }*/
                    }
                }

                Console.WriteLine("DONE");
                //Console.WriteLine("Press ENTER to close this window");
                //Console.ReadLine();

                var minHeroTally = heroTally.Values.Min();
                var avgHeroTally = heroTally.Values.Average();
                var maxHeroTally = heroTally.Values.Max();
                var minCardTally = cardTally.Values.Min();
                var avgCardTally = cardTally.Values.Average();
                var maxCardTally = cardTally.Values.Max();
                
                var heroScores = new Dictionary<string, byte>();
                var cardScores = new Dictionary<string, byte>();

                var oldRange = 0;
                const int newMin = 1;
                const int newMax = 5;
                var newRange = 0;
                decimal newScore = 0;

                foreach (var tally in heroTally.Keys) {
                    oldRange = (maxHeroTally - minHeroTally);  
                    newRange = (newMax - newMin);
                    newScore = (((heroTally[tally] - minHeroTally) * newRange) / oldRange) + newMin;
                    heroScores[tally] = (byte)Math.Truncate(newScore); //new Tuple<decimal,int>(newScore, heroTally[tally]);

                    Console.WriteLine(string.Format("addPopularity(\"{0}\", {1});"));
                }

                foreach (var tally in cardTally.Keys) {
                    oldRange = (maxCardTally - minCardTally);  
                    newRange = (newMax - newMin);
                    newScore = (((cardTally[tally] - minCardTally) * newRange) / oldRange) + newMin;
                    cardScores[tally] = (byte)Math.Truncate(newScore); //new Tuple<decimal, int>(newScore, cardTally[tally]);

                    Console.WriteLine(string.Format("addPopularity(\"{0}\", {1});"));
                }

                //var x = heroScores;
                //var y = cardScores;
                //var z = unknownCards;
            }
        }
    }
}
