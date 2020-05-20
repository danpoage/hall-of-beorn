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
                { "player", (game, input) => AddPlayer(game, input) }
        };

        private static void AddPlayer(Game game, List<string> input)
        {
            if (input.Count < 3)
            {
                Write("adds a player to the game");
                Write("usage: player {Name} {RingsDB_DeckId}");
                return;
            }

            var ringsDbDeck = ringsDbHelper.GetDeckList(input[2]);
            if (ringsDbDeck == null)
            {
                Write(string.Format("RingsDB Deck not found: {0}", input[2]));
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

            var deck = new Deck{ DeckId = input[2] };
            deck.Load(ringsDbDeck.slots, lookupRingsDbCard);

            var heroes = ringsDbDeck.heroes.Select(h => lookupRingsDbCard(h.Key));
            
            players.Add(new Player(input[0], deck, heroes));
            
            Write(
                string.Format("Added Player {0} Deck and Heroes: {1}", input[0], string.Join(", ", heroes.Select(h => h.Title))));
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
