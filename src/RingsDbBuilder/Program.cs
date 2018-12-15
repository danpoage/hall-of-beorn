using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using HallOfBeorn.Models.RingsDb;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.RingsDb;

namespace RingsDbBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RingsDB Popularity Ranker v1.0.6 (2018-12-15)");

            var productRepo = new ProductRepository();
            var cardRepo = new LotRCardRepository(productRepo);
            var lookupService = new RingsDbService(cardRepo);

            var heroTally = new Dictionary<string, int>();
            var cardTally = new Dictionary<string, int>();
            var createdTally = new Dictionary<string, int>();
            var unknownCards = new List<string>();

            var linkMap = new Dictionary<string, Dictionary<string, int>>();
            var deckMap = new Dictionary<string, int>();
            var ignoreMap = getIgnoreMap();

            using (var client = new System.Net.Http.HttpClient())
            {
                const int startDeckId = 2969;
                const int maxDeckId = 10601;
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

                    if (!response.IsSuccessStatusCode)
                        continue;
                    
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    deck = null;
                    try {
                        deck = Newtonsoft.Json.JsonConvert.DeserializeObject<RingsDbDeckList>(responseString);
                    } catch (Exception ex) {
                        Console.WriteLine("ERROR FOR DECK # " + i + ": " + ex.Message);
                    }

                    if (deck == null) {
                        continue;
                    }

                    deckMap.Clear();

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

                        if (!deckMap.ContainsKey(heroId))
                            deckMap.Add(heroId, 1);
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

                        if (!deckMap.ContainsKey(cardId))
                            deckMap.Add(cardId, quantity);

                        //Console.WriteLine(string.Format("  Player Card {0} + {1}", slug, quantity));

                        cardTally[cardId] += quantity;
                    }

                    foreach (var parentId in deckMap.Keys)
                    {
                        if (!linkMap.ContainsKey(parentId))
                            linkMap.Add(parentId, new Dictionary<string, int>());

                        foreach (var childId in deckMap.Keys)
                        {
                            //A card cannot link to itself
                            if (childId == parentId)
                                continue;

                            //Ignore five star children (otherwise they end up linked to everything)
                            if (ignoreMap.ContainsKey(childId))
                                continue;

                            if (!linkMap[parentId].ContainsKey(childId))
                                linkMap[parentId].Add(childId, deckMap[childId]);
                            else
                                linkMap[parentId][childId] = linkMap[parentId][childId] + deckMap[childId];
                        }
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

                Console.WriteLine("LINKS");

                foreach (var parentId in linkMap.Keys)
                {
                    var topChildren = linkMap[parentId].OrderByDescending(kvp => kvp.Value).Take(10);
                    foreach (var child in topChildren)
                    {
                        Console.WriteLine(string.Format("            addCardLink(\"{0}\", \"{1}\", {2});", parentId, child.Key, child.Value));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("POPULARITY");
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
                    
                    Console.WriteLine(string.Format("            addHeroPopularity(\"{0}\", {1});", tally, heroTally[tally]));
                }

                foreach (var tally in cardTally.Keys.OrderByDescending(x => cardTally[x])) {
                    //oldRange = (maxCardTally - minCardTally);  
                    //newRange = (newMax - newMin);
                    //newScore = (((cardTally[tally] - minCardTally) * newRange) / oldRange) + newMin;
                    //cardScores[tally] = (byte)Math.Truncate(newScore); 
                    
                    Console.WriteLine(string.Format("            addCardPopularity(\"{0}\", {1});", tally, cardTally[tally]));
                }

                foreach (var date in createdTally.Keys.OrderBy(x => x)) {
                    //Console.WriteLine(string.Format("DATE: {0} COUNT: {1}", date, createdTally[date]));
                }

                //var x = heroScores;
                //var y = cardScores;
                //var z = unknownCards;
            }
        }

        private static Dictionary<string, int> getIgnoreMap()
        {
            var map = new Dictionary<string, int>();
            map.Add("01073", 8864);
            map.Add("01050", 8490);
            map.Add("01026", 6592);
            map.Add("01023", 5794);
            map.Add("01057", 5563);
            map.Add("01034", 5392);
            map.Add("04108", 4875);
            map.Add("04059", 4143);
            map.Add("01046", 3859);
            map.Add("04083", 3838);
            map.Add("01048", 3618);
            map.Add("04107", 3400);
            map.Add("01045", 3176);
            map.Add("01016", 2614);
            map.Add("02056", 2479);
            map.Add("10145", 2407);
            map.Add("01014", 2392);
            map.Add("04058", 2390);
            map.Add("06005", 2374);
            map.Add("01029", 2261);
            map.Add("05018", 2212);
            map.Add("02033", 2121);
            map.Add("02026", 2103);
            map.Add("01059", 2064);
            map.Add("06006", 2059);
            map.Add("01062", 1944);
            map.Add("05007", 1938);
            map.Add("131015", 1929);
            map.Add("08117", 1923);
            map.Add("01027", 1896);
            map.Add("01069", 1864);
            map.Add("04062", 1851);
            map.Add("04134", 1840);
            map.Add("01053", 1837);
            map.Add("01070", 1808);
            map.Add("01061", 1775);
            map.Add("01060", 1774);
            map.Add("02098", 1768);
            map.Add("01028", 1717);
            map.Add("02121", 1660);
            map.Add("01035", 1653);
            map.Add("141014", 1628);
            map.Add("131014", 1606);
            map.Add("07012", 1599);
            map.Add("02004", 1554);
            map.Add("02002", 1493);
            map.Add("08146", 1490);
            map.Add("01024", 1437);
            map.Add("02103", 1428);
            map.Add("05003", 1401);
            map.Add("01013", 1397);
            map.Add("04031", 1369);
            map.Add("12009", 1347);
            map.Add("01040", 1336);
            map.Add("03009", 1318);
            map.Add("01039", 1311);
            map.Add("01051", 1305);
            map.Add("01058", 1303);
            map.Add("10004", 1287);
            map.Add("04106", 1260);
            map.Add("12059", 1257);
            map.Add("01049", 1237);
            map.Add("04129", 1220);
            map.Add("02055", 1217);
            map.Add("01072", 1196);
            map.Add("04110", 1190);
            map.Add("01066", 1189);
            map.Add("07007", 1185);
            map.Add("01044", 1166);
            map.Add("01042", 1162);
            map.Add("143006", 1160);
            map.Add("05017", 1149);
            map.Add("06010", 1140);
            map.Add("10061", 1115);
            map.Add("08119", 1098);
            map.Add("02034", 1097);
            map.Add("02119", 1078);
            map.Add("143005", 1054);
            map.Add("08121", 1051);
            map.Add("02077", 1037);
            map.Add("09012", 1035);
            map.Add("131011", 1032);
            map.Add("03011", 1021);
            map.Add("04137", 1013);
            map.Add("09004", 1010);
            map.Add("08087", 995);
            map.Add("02003", 991);
            map.Add("12006", 982);
            map.Add("07008", 970);
            map.Add("10031", 963);
            map.Add("04055", 955);
            map.Add("01007", 943);
            map.Add("11015", 937);
            map.Add("02081", 934);
            map.Add("08064", 929);
            map.Add("02079", 925);
            map.Add("02006", 896);
            map.Add("01055", 854);
            map.Add("142003", 851);
            map.Add("01031", 837);
            map.Add("06004", 837);
            map.Add("01063", 831);
            map.Add("06008", 828);
            map.Add("10090", 827);
            map.Add("142008", 827);
            map.Add("12034", 818);
            map.Add("07006", 804);
            return map;
        }
    }
}
