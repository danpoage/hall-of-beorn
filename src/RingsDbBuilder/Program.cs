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
            Console.WriteLine("RingsDB Popularity Ranker v1.0.3 (2018-04-17)");

            var productRepo = new ProductRepository();
            var cardRepo = new CardRepository(productRepo);
            var lookupService = new RingsDbService(cardRepo);

            var heroTally = new Dictionary<string, int>();
            var cardTally = new Dictionary<string, int>();
            var createdTally = new Dictionary<string, int>();

            var unknownCards = new List<string>();

            using (var client = new System.Net.Http.HttpClient())
            {
                const int startDeckId = 2969;
                const int maxDeckId = 8496;
                RingsDbDeckList deck;
                var slug = string.Empty;
                var quantity = 0;
                var created = string.Empty;
                //const int mainDeckMultiplier = 4;
                //const int sideboardMultiplier = 1;

                for (var i = startDeckId; i <= maxDeckId; i++) {
                    Console.WriteLine(string.Format("Deck: {0}", i));
                    var url = string.Format("http://ringsdb.com/api/public/decklist/{0}.json", i);
                    var response = client.GetAsync(url).Result;

                    System.Threading.Thread.Sleep(1000);

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

                        if (!string.IsNullOrWhiteSpace(deck.date_creation) && deck.date_creation.Length >= 10)
                        {
                            created = deck.date_creation.Substring(0, 10);
                            if (!createdTally.ContainsKey(created)) {
                                createdTally[created] = 0;
                            }
                            
                            createdTally[created] += 1;
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

                //var minHeroTally = heroTally.Values.Min();
                //var avgHeroTally = heroTally.Values.Average();
                //var maxHeroTally = heroTally.Values.Max();
                //var minCardTally = cardTally.Values.Min();
                //var avgCardTally = cardTally.Values.Average();
                //var maxCardTally = cardTally.Values.Max();
                
                //var heroScores = new Dictionary<string, byte>();
                //var cardScores = new Dictionary<string, byte>();

                //var oldRange = 0;
                //const int newMin = 1;
                //const int newMax = 5;
                //var newRange = 0;
                //decimal newScore = 0;

                foreach (var tally in heroTally.Keys.OrderByDescending(x => heroTally[x])) {
                    //oldRange = (maxHeroTally - minHeroTally);  
                    //newRange = (newMax - newMin);
                    //newScore = (((heroTally[tally] - minHeroTally) * newRange) / oldRange) + newMin;
                    //heroScores[tally] = (byte)Math.Truncate(newScore); 
                    
                    Console.WriteLine(string.Format("addPopularity(\"{0}\", {1});", tally, heroTally[tally]));
                }

                foreach (var tally in cardTally.Keys.OrderByDescending(x => cardTally[x])) {
                    //oldRange = (maxCardTally - minCardTally);  
                    //newRange = (newMax - newMin);
                    //newScore = (((cardTally[tally] - minCardTally) * newRange) / oldRange) + newMin;
                    //cardScores[tally] = (byte)Math.Truncate(newScore); 
                    
                    Console.WriteLine(string.Format("addPopularity(\"{0}\", {1});", tally, cardTally[tally]));
                }

                foreach (var date in createdTally.Keys.OrderBy(x => x)) {
                    Console.WriteLine(string.Format("DATE: {0} COUNT: {1}", date, createdTally[date]));
                }

                //var x = heroScores;
                //var y = cardScores;
                //var z = unknownCards;
            }
        }
    }
}
