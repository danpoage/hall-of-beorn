using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Play;
using HallOfBeorn.Play.Repositories;
using HallOfBeorn.Services.LotR;
using HallOfBeorn.Services.LotR.Categories;
using HallOfBeorn.Services.LotR.RingsDb;
using HallOfBeorn.Services.LotR.Scenarios;

namespace HallOfBeorn.Client
{
    public class Program
    {
        public static int Main(string[] args)
        {
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

                    if ((command != "choice" || input.Count > 1)
                        && game.CurrentChoice != null)
                    {
                        ShowChoice(game, new List<string>());
                    }
                }
                else
                {
                    Write("Unrecognized command: {0}", command);
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
        private static ScenarioService scenarioService = new ScenarioService(
            new PlayerCategoryService(cardRepository),
            new EncounterCategoryService(cardRepository),
            new QuestCategoryService(cardRepository),
            new RingsDbService(cardRepository), 
            productRepository, cardRepository);

        private static Func<string, LotRCard> lookupCard = (slug) => cardRepository.FindBySlug(slug);
        private static Func<string, CardSide, IEnumerable<Effect>> lookupEffects = (slug, side) => effectRepository.GetEffects(slug, side);

        private static readonly Game game = new Game();
        private static readonly Runner runner = new Runner(game, (s) => Write(s), lookupCard, lookupEffects);

        private static readonly Dictionary<string, Action<Game, List<string>>> handlers 
            = new Dictionary<string,Action<Game, List<string>>>(StringComparer.OrdinalIgnoreCase){
                { "choice", (g, input) => ShowChoice(g, input) },
                { "deck", (g, input) => AddDeck(g, input) },
                { "exit", (g, input) => run = false },
                { "round", (g, input) => ShowRoundInfo(g, input) }, 
                { "log", (g, input) => ShowLog(g, input) },
                { "player", (g, input) => PlayerInfo(g, input) },
                { "quest", (g, input) => AddQuest(g, input) },
                { "staging", (g, input) => ShowStagingArea(g, input) },
                { "play", (g, input) => Play(g, input) },
        };

        private static void ShowChoice(Game game, List<string> input)
        {
            if (game.CurrentChoice == null)
            {
                Write("None");
                return;
            }

            if (input.Count > 1)
            {
                foreach (var value in input.Skip(1))
                {
                    var index = 0;
                    if (!int.TryParse(value, out index)
                        || index < 1 || index > game.CurrentChoice.Options.Count)
                    {
                        Write("{0} is not a valid option for this choice", value);
                    }
                    else
                    {
                        game.CurrentChoice.Options[index - 1].IsChosen = true;
                    }
                }

                var selectedCount = game.CurrentChoice.Options.Where(opt => opt.IsChosen).Count();
                if (game.CurrentChoice.MaxOptionsChosen == selectedCount)
                {
                    runner.Play();
                    return;
                }
            }

            var options = new Dictionary<string, string>();
            for (var i=0;i<game.CurrentChoice.Options.Count;i++)
            {
                var selected = game.CurrentChoice.Options[i].IsChosen ? " [X]" : " [ ]";
                options.Add((i + 1).ToString(), game.CurrentChoice.Options[i].Description + selected);
            }

            Write(game.CurrentChoice.Description, options);
        }

        private static void ShowLog(Game game, List<string> input)
        {
            var log = new Dictionary<string, string>();
            for (var i=0;i<game.GameEvents.Count;i++)
            {
                log.Add((i + 1).ToString(), game.GameEvents[i].Description);
            }

            Write("Game Log", log);
        }

        public static void ShowRoundInfo(Game game, List<string> input)
        {
            var info = new Dictionary<string, string>
            {
                { "Round Number", game.RoundNumber.ToString() },
                { "Current Phase", game.Phase.ToString() },
                { "Framework Step", game.FrameworkStep.ToString() },
            };

            Write("Round", info);
        }

        public static void ShowStagingArea(Game game, List<string> input)
        {
            var log = new Dictionary<string, string>();
            for(var i=0;i<game.StagingArea.Count;i++)
            {
                var card = game.StagingArea[i].Card;
                //TODO: Display type-specific info, e.g. hit points, damage, progress, etc.
                log.Add((i + 1).ToString(), card.NormalizedTitle + " [" + card.CardType + "]");
            }
            Write("Staging Area", log);
        }

        private static void Play(Game game, List<string> input)
        {
            if (game.Players.Count == 0)
            {
                Write("Cannot start game: no decks or players  added");
                return;
            }
            if (game.Scenario == null)
            {
                Write("Cannot start game: no scenario selected");
                return;
            }

            runner.Play();
        }

        private static void AddDeck(Game game, List<string> input)
        {
            if (input.Count < 2)
            {
                Write("adds a deck (and player) to the game\r\nusage: deck [DeckId] {PlayerName}");
                return;
            }

            var deckId = input[1];
            var playerName = input.Count > 2
                ? string.Join(" ", input.Skip(2))
                : "Player " + (game.Players.Count + 1);

            var ringsDbDeck = ringsDbHelper.GetDeckList(deckId);
            if (ringsDbDeck == null)
            {
                Write("Deck not found: {0}", deckId);
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

            var deck = new Deck(ringsDbDeck.name.Replace("’", "'")){ 
                RingsDbDeckId = deckId, 
                Description = ringsDbDeck.description_md 
            };
            var starters = deck.Load(ringsDbDeck.slots, lookupRingsDbCard);

            var heroes = starters.Where(st => st.CardType == CardType.Hero);
            var contract = starters.FirstOrDefault(st => st.CardType == CardType.Contract);
            
            var player = new Player(playerName, deck, heroes, contract);
            game.Players.Add(player);

            var deckName = deck.Name;
            var contractName = contract != null ? contract.Title : "None";
            var heroNames = string.Join(", ", heroes.Select(h => h.NormalizedTitle));

            Write("Success", new Dictionary<string, string> {
                { "Player", playerName },
                { "Deck", deckName },
                { "Heroes", heroNames },
                { "Contract", contractName }
            });
        }

        private static void AddQuest(Game game, List<string> input)
        {
            if (input.Count < 2)
            {
                Write("selects a quest for the game\r\nusage: quest [QuestName]");
                return;
            }

            var name = string.Join(" ", input).Substring(6).Trim();
            var slug = name.Replace(" ", "-");

            var scenario = scenarioService.GetScenario(slug);
            if (scenario == null)
            {
                Write("Quest not found: {0}", name);
                return;
            }

            game.Scenario = scenario;
            Write("Success", new Dictionary<string, string> {
                { "Quest", scenario.Title},
                { "Product", scenario.ProductName }
            });
        }

        private static void PlayerInfo(Game game, List<string> input)
        {
            if (input.Count < 2)
            {
                var playerNames = game.Players.Count > 0
                    ? string.Join(", ", game.Players.Select(p => p.Name))
                    : "[None]";
                Write("Players: " + playerNames);
                return;
            }
            var name = string.Join(" ", input.Skip(1));
            var player = game.Players.FirstOrDefault(p => p.Name == name);
            if (player == null)
            {
                Write("Player not found: {0}", name);
                return;
            }

            var heroList = player.Heroes.Select(h => 
                string.Format("{0}: {1} resource, {2} damage", h.Card.NormalizedTitle, h.ResourceTokens, h.DamageTokens));

            var contractName = player.Contract != null 
                ? player.Contract.Card.NormalizedTitle 
                : "None";

            var handList = player.Hand.Count > 1
                ? string.Join(", ", player.Hand.Select(c => c.Name))
                : "[Empty]";

            var playArea = player.PlayArea.Where(pa => pa.Card.CardType != CardType.Hero).ToList();
            var playAreaList = playArea.Count > 0
                ? string.Join(", ", playArea.Select(pa => pa.Name + " [" + pa.Card.CardType + "]"))
                : "[Empty]";

            var status = new Dictionary<string, string>{
                { "Active", player.IsActivePlayer.ToString() },
                { "First", player.IsFirstPlayer.ToString() },
                { "Deck", player.Deck.Name },
                { "Contract", contractName },
                { "Threat", player.Threat.ToString() },
                { "Hand", handList },
                { "Heroes", string.Empty },
            };

            foreach (var hero in player.Heroes)
            {
                status.Add(hero.Card.NormalizedTitle, string.Format("{0} resource(s), {1} damage", hero.ResourceTokens, hero.DamageTokens));
            }

            status.Add("Play Area", playAreaList);

            Write(name, status);
        }

        private static void Prompt()
        {
            Console.WriteLine();
            Console.Write(">: ");
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
        }
        
        private static void Write(string format, params string[] args)
        {
            Console.WriteLine(format, args);
        }

        public static void Write(string header, Dictionary<string, string> map)
        {
            Console.WriteLine();
            Console.WriteLine(header);
            if (map.Count > 0)
            {
                var  length = map.Keys.Max(k => k.Length);
                foreach (var key in map.Keys)
                {
                    Write("{0,-" + length + "}: {1}", key, map[key]);
                }
            }
        }
    }
}
