using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Play;
using HallOfBeorn.Models.LotR.Play.Repositories;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.RingsDb;

namespace HallOfBeorn.Client
{
    public class Program
    {
        public static int Main(string[] args)
        {
            

            var game = new Game();

            var runner = new Runner(game, lookupCard, lookupEffects);

            Console.OutputEncoding = Encoding.UTF8;
            Write(header);

            while (run)
            {
                Prompt();

                var input = Read();

                var command = input[0];
                if (handlers.ContainsKey(command))
                {
                    handlers[command](game, input);
                }
                else
                {
                    Write(string.Format("Unrecognized command: {0}", command));
                }
            }

            return 0;
        }

        private const string header = "Hall of Beorn Client 0.1";
        private static bool run = true;
        private static ProductRepository productRepository = new ProductRepository();
        private static LotRCardRepository cardRepository = new LotRCardRepository(productRepository);
        private static EffectRepository effectRepository = new EffectRepository(cardRepository);
        private static RingsDbHelper ringsDbHelper = new RingsDbHelper();

        private static Func<string, LotRCard> lookupCard = (slug) => cardRepository.FindBySlug(slug);
        private static Func<string, CardSide, IEnumerable<Effect>> lookupEffects = (slug, side) => effectRepository.GetEffects(slug, side);

        private static readonly List<Player> players = new List<Player>();

        private static readonly Dictionary<string, Action<Game, List<string>>> handlers 
            = new Dictionary<string,Action<Game, List<string>>>(StringComparer.OrdinalIgnoreCase){
                { "exit", (game, input) => run = false },
                { "add", (game, input) => AddPlayer(game, input) },
                { "quest", (game, input) => AddQuest(game, input) },
        };

        private static void AddPlayer(Game game, List<string> input)
        {
            if (input.Count < 3)
            {
                Write("adds a player to the game\r\nusage: add {PlayerName} {DeckId}");
                return;
            }

            var ringsDbDeck = ringsDbHelper.GetDeckList(input[2]);
            if (ringsDbDeck == null)
            {
                Write(string.Format("RingsDB deck not found: {0}", input[2]));
                return;
            }

            Func<string, IEnumerable<CardSet>> lookupSets = (name) =>
             {
                 var matches = new List<CardSet>();
                 foreach (var product in productRepository.Products())
                 {
                     foreach (var cardSet in product.CardSets)
                     {
                         if (cardSet.Name == name || cardSet.Cycle == name)
                         {
                             matches.Add(cardSet);
                         }
                     }
                 }
                 return matches;
             };
            Func<string, LotRCard> lookupRingsDbCard = (id) => ringsDbHelper.GetCard(id, lookupSets);

            var deck = new Deck{ 
                DeckId = input[2], 
                Name = ringsDbDeck.name.Replace("’", "'"), 
                Description = ringsDbDeck.description_md 
            };
            var starters = deck.Load(ringsDbDeck.slots, lookupRingsDbCard);

            var heroes = starters.Where(st => st.CardType == CardType.Hero);
            var contract = starters.FirstOrDefault(st => st.CardType == CardType.Contract);
            
            players.Add(new Player(input[0], deck, heroes, contract));
            
            var playerName = input[1];
            var deckName = deck.Name;
            var contractName = contract != null ? contract.Title : "None";
            var heroNames = string.Join(", ", heroes.Select(h => h.NormalizedTitle));

            Write(string.Format("\r\nPlayer:   {0}\r\nDeck:     {1}\r\nHeroes:   {2}\r\nContract: {3}", 
                playerName, deckName, heroNames, contractName));
        }

        private static void AddQuest(Game game, List<string> input)
        {
            if (input.Count < 2)
            {
                Write("selects a quest for the game\r\nusage: quest {name}");
                return;
            }

            var name = string.Join(" ", input).Substring(6).Trim();
            var scenario = productRepository.Products().SelectMany(p => p.Scenarios())
                .FirstOrDefault(sc => sc.Title == name || sc.AlternateTitle == name || sc.Slug == name);
            if (scenario == null)
            {
                Write(string.Format("Quest not found: {0}", name));
                return;
            }

            game.Scenario = scenario;
            Write(string.Format("Quest:   {0}\r\nProduct: {1}", scenario.Title, scenario.ProductName));
        }

        private static void Prompt()
        {
            Console.Write("HoB: ");
        }

        private static List<string> Read()
        {
            var input = Console.ReadLine();

            return (string.IsNullOrWhiteSpace(input))
                ? new List<string> { string.Empty }
                : input.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private static void Write(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
