using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Play
{
    public enum GameMode
    {
        Easy,
        Normal,
        Nightmare,
    }

    public enum CardSide
    {
        Front,
        Back
    }

    public class Game
    {
        public Game(
            Func<string, LotRCard> lookupCard,
            Func<string, CardSide, IEnumerable<Effect>> lookupEffects)
        {
            this.lookupCard = lookupCard;
            this.lookupEffects = lookupEffects;
        }

        private readonly Func<string, LotRCard> lookupCard;
        private readonly Func<string, CardSide, IEnumerable<Effect>> lookupEffects;

        private IEnumerable<Effect> GetEffectsByTrigger(string slug, CardSide side, Trigger trigger)
        {
            return lookupEffects(slug, side).Where(ef => ef.Trigger == trigger);
        }

        public uint RoundNumber { get; set; }
        public Phase Phase { get; set; }
        public FrameworkStep FrameworkStep { get; set; }

        public Scenario Scenario { get; set; }

        public List<Player> Players = new List<Player>();

        public List<CardInPlay> StagingArea = new List<CardInPlay>();
        public List<CardInPlay> ActiveLocations = new List<CardInPlay>();
        public List<CardOutOfPlay> VictoryDisplay = new List<CardOutOfPlay>();
        public List<CardOutOfPlay> RemovedFromGame = new List<CardOutOfPlay>();

        public Deck EncounterDeck { get; set; }
        public Deck SecondaryEncounterDeck { get; set; }

        public Deck QuestDeck { get; set; }
        public LotRCard MainQuest { get; set; }

        public Deck SecondaryQuestDeck { get; set; }
        public LotRCard MainSecondaryQuest { get; set; }

        private Dictionary<EffectType, List<Effect>> FindEffects(Trigger trigger)
        {
            var results = new Dictionary<EffectType, List<Effect>>{
                { EffectType.Passive, new List<Effect>() },
                { EffectType.Forced, new List<Effect>() },
                { EffectType.Response, new List<Effect>() }
            };

            foreach (var effect in ConstantEffects.Where(ef => ef.Trigger == trigger))
            {
                results[effect.Type].Add(effect);
            }
            
            foreach (var effect in EndOfPhaseEffects.Where(ef => ef.Trigger == trigger))
            {
                results[effect.Type].Add(effect);
            }

            foreach (var effect in EndOfRoundEffects.Where(ef => ef.Trigger == trigger))
            {
                results[effect.Type].Add(effect);
            }

            foreach (var card in StagingArea)
            {
                //TODO: Change lookupEffect to use the active side of each card
                foreach (var effect in 
                    lookupEffects(card.Card.Slug, CardSide.Front).Where(ef => ef.Trigger == trigger))
                {
                    results[effect.Type].Add(effect);
                }
            }

            foreach (var player in Players)
            {
                foreach (var card in player.PlayArea)
                {
                    //TODO: Change lookupEffect to use the active side of each card
                    foreach (var effect in 
                        lookupEffects(card.Card.Slug, CardSide.Front).Where(ef => ef.Trigger == trigger))
                    {
                        results[effect.Type].Add(effect);
                    }
                }
            }

            return results;
        }

        public List<Effect> ConstantEffects = new List<Effect>();
        public List<Effect> EndOfPhaseEffects = new List<Effect>();
        public List<Effect> EndOfRoundEffects = new List<Effect>();

        private uint eventCount = 0;
        private void Log(string description)
        {
            Log(new GameEvent { Description = description });
        }
        public void Log(GameEvent entry)
        {
            eventCount++;
            entry.Number = eventCount;
            GameEvents.Add(entry);
        }
        public List<GameEvent> GameEvents = new List<GameEvent>();

        public Choice CurrentChoice { get; set; }
        
        public void SelectOptions(IEnumerable<Option> options)
        {
            CurrentChoice.SelectOptions(this, options);
        }

        public void ExecuteAutomaticEffects(IEnumerable<Effect> effects)
        {
            foreach (var effect in effects)
            {
                if (effect.Criteria(this) && effect.GetChoice(this) == null)
                {
                    foreach (var result in effect.Results)
                        result(this);
                }
            }
        }

        public void AddScenario(Scenario scenario, GameMode mode)
        {
            Scenario = scenario;

            Func<ScenarioQuestCard, int> getQuestCardQuantity = (qc) => {
                if (mode == GameMode.Easy) return qc.EasyModeQuantity;
                else if (mode == GameMode.Nightmare) return qc.NightmareModeQuantity;
                else return qc.NormalModeQuantity;
            };

            Func<ScenarioCard, int> getEncounterCardQuantity = (sc) => {
                if (mode == GameMode.Easy) return sc.EasyQuantity;
                else if (mode == GameMode.Nightmare) return sc.NightmareQuantity;
                else return sc.NormalQuantity;
            };

            QuestDeck = new Deck { Name = scenario.Title + " Quest Deck" };
            QuestDeck.Load(scenario.QuestCards.Select(qc => 
                new Tuple<LotRCard, byte>(lookupCard(qc.Slug), (byte)getQuestCardQuantity(qc)))
            );

            EncounterDeck = new Deck { Name = scenario.Title + " Encounter Deck" };
            EncounterDeck.Load(scenario.ScenarioCards.Select(qc => 
                new Tuple<LotRCard, byte>(lookupCard(qc.Slug), (byte)getEncounterCardQuantity(qc)))
            );

            Log("Add Scenario: " + scenario.Title + " [" + mode.ToString() + " Mode]");
        }

        public void AddPlayer(string name, Deck deck, IEnumerable<LotRCard> heroes)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Player " + Players.Count + 1;
            }

            var player = new Player(name, deck, heroes);
            Players.Add(player);
            Log(string.Format("Add Player {0}", name));

            Log(string.Format("Add Deck: {0}", deck.Name ?? deck.DeckId));

            Log(string.Format("Add Heroes: {0}", 
                string.Join(", ", heroes.Select(h => h.Title + "[" + h.Sphere.ToString() + "]").ToArray())));
        }

        private void ShuffleDecks()
        {
            foreach (var player in Players)
            {
                player.IsActivePlayer = true;
                player.Deck.Shuffle();
                Log(string.Format("Player {0} Shuffles their Deck", player.Name));
            }
        }

        private void PlaceHerosAndSetInitialThreat()
        {
            foreach (var player in Players)
            {
                var placeHeroEffects = player.Heroes.SelectMany(h => 
                    GetEffectsByTrigger(
                        h.Card.Slug, CardSide.Front, Trigger.Setup_Place_Hero));

                var determineThreatEffects = player.Heroes.SelectMany(h => 
                    GetEffectsByTrigger(
                        h.Card.Slug, CardSide.Front, Trigger.Setup_Determine_Hero_Starting_Threat));

                player.IsActivePlayer = true;

                Log(string.Format("Player {0} Places Heres and Set Initial Threat", player.Name));

                foreach (var hero in player.Heroes)
                {
                    var placeHero = new GameEvent { Description = "Place Hero" +  hero.Card.Title };
                    placeHero.CardsInPlay.Add(hero);
                    ExecuteAutomaticEffects(placeHeroEffects);
                    Log(placeHero);
                    player.PlayArea.Add(hero);

                    var determineThreat = new GameEvent{Description = "Determine Starting Threat for Hero " + hero.Card.Title};
                    determineThreat.CardsInPlay.Add(hero);
                    ExecuteAutomaticEffects(determineThreatEffects);
                    Log(determineThreat);
                    player.Threat += hero.Card.ThreatCost.Value;
                }

                Log(string.Format("Player {0} Initial Threat Set to {1}", player.Name, player.Threat));
            }
        }

        public void DetermineFirstPlayer()
        {
            var first = Players.First();
            first.IsFirstPlayer = true;
            Log(string.Format("Player {0} is the First Player", first.Name));

            //TODO: Allow Players to choose first player in multiplayer games
        }

        private void ResolveEffects(Dictionary<EffectType, List<Effect>> effects)
        {
            foreach (var effect in effects[EffectType.Passive])
            {
                if (effect.Criteria(this) && effect.GetChoice(this) == null)
                {
                    effect.Resolve(this);
                }
            }

            foreach (var effect in effects[EffectType.Forced])
            {
                if (effect.Criteria(this) && effect.GetChoice(this) == null)
                {
                    effect.Resolve(this);
                }
            }

            foreach (var effect in effects[EffectType.Response])
            {
                if (effect.Criteria(this) && effect.GetChoice(this) == null)
                {
                    effect.Resolve(this);
                }
            }
        }

        public void DrawSetupHand()
        {
            var effects = FindEffects(Trigger.Setup_Determine_Starting_Hand_Size);

            foreach (var player in Players)
            {
                player.IsActivePlayer = true;

                ResolveEffects(effects);

                var hand = player.Deck.Draw(player.SetupHandSize);
                player.Hand.AddRange(hand);
                Log(string.Format("Player {0} Draws {1} Cards in their Setup Hand", player.Name, player.SetupHandSize));
            }
        }

        public void SetupGame(IEnumerable<Player> players)
        {
            Log("Begin Setup");

            ShuffleDecks();

            PlaceHerosAndSetInitialThreat();

            Log("Create Virtual Token Bank (the Bear likes playing with tokens)");

            DetermineFirstPlayer();

            DrawSetupHand();

            //Setup_Begin,
            //Setup_Shuffle_Decks,
            //Setup_Place_Heroes_And_Set_Initial_Threat_Levels,
            //Setup_Create_Token_Bank,
            //Setup_Determine_First_Player,
            //Setup_Draw_Setup_Hand,
            //Setup_Quest_Cards,
            //Setup_Follow_Scenario_Setup_Instructions,
            //Setup_End,
        }

        public void SetupScenario()
        {
            if (Scenario == null || QuestDeck == null)
            {
                Log(new GameEvent{ Description = "Scenario and Quest Deck not defined" });
                return;
            }

            Log("Setup Scenario: " + Scenario.Title);

            var firstQuest = QuestDeck.Cards.FirstOrDefault();

            var effects = lookupEffects(firstQuest.Card.Slug, CardSide.Front);

            foreach (var effect in effects)
            {
                //TODO: Create a game event and resolve it
            }
        }

        public void Run()
        {
        }
    }
}
