using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Runner
    {
        public Runner(Game game,             
            Func<string, LotRCard> lookupCard,
            Func<string, CardSide, IEnumerable<Effect>> lookupEffects)
        {
            this.game = game;
            this.lookupCard = lookupCard;
            this.lookupEffects = lookupEffects;
        }

        private readonly Game game;
        private readonly Func<string, LotRCard> lookupCard;
        private readonly Func<string, CardSide, IEnumerable<Effect>> lookupEffects;

        private readonly List<GameSegment> SetupSegments = new List<GameSegment>
        {
            new Setup.DrawSetupHand(),
            new Setup.SetupQuestCard(),
        };

        private readonly List<GameSegment> ResourcePhaseSegments = new List<GameSegment>
        {
        };

        private readonly List<GameSegment> PlanningPhaseSegements = new List<GameSegment>
        {
        };

        private void SetCurrentSegment<TSegment>()
            where TSegment: GameSegment, new()
        {
            var segment = new TSegment();
            segment.LookupCard = lookupCard;
            segment.LookupEffects = lookupEffects;
            segment.FindEffectsByTrigger = (trigger) => FindEffects(trigger);

            game.PendingEffects.Clear();
            game.CurrentSegment = segment;
            game.PendingEffects.AddRange(segment.Execute(game));
        }

        private IEnumerable<Effect> GetEffectsByTrigger(string slug, CardSide side, Trigger trigger)
        {
            return lookupEffects(slug, side).Where(ef => ef.Trigger == trigger);
        }

        private Dictionary<EffectType, List<Effect>> FindEffects(Trigger trigger)
        {
            var results = new Dictionary<EffectType, List<Effect>>{
                { EffectType.Passive, new List<Effect>() },
                { EffectType.Forced, new List<Effect>() },
                { EffectType.Response, new List<Effect>() }
            };

            foreach (var effect in game.ConstantEffects.Where(ef => ef.Trigger == trigger))
            {
                results[effect.Type].Add(effect);
            }
            
            foreach (var effect in game.EndOfPhaseEffects.Where(ef => ef.Trigger == trigger))
            {
                results[effect.Type].Add(effect);
            }

            foreach (var effect in game.EndOfRoundEffects.Where(ef => ef.Trigger == trigger))
            {
                results[effect.Type].Add(effect);
            }

            foreach (var card in game.StagingArea)
            {
                //TODO: Change lookupEffect to use the active side of each card
                foreach (var effect in 
                    lookupEffects(card.Card.Slug, CardSide.Front).Where(ef => ef.Trigger == trigger))
                {
                    results[effect.Type].Add(effect);
                }
            }

            foreach (var player in game.Players)
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

        public void SelectOptions(IEnumerable<Option> options)
        {
            game.CurrentChoice.SelectOptions(game, options);
        }

        private void ExecuteAutomaticEffects(IEnumerable<Effect> effects)
        {
            foreach (var effect in effects)
            {
                if (effect.Criteria(game) && effect.GetChoice(game) == null)
                {
                    foreach (var result in effect.Results)
                        result(game);
                }
            }
        }

        private void AddPlayer(string name, Deck deck, IEnumerable<LotRCard> heroes)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Player " + game.Players.Count + 1;
            }

            var player = new Player(name, deck, heroes);
            game.Players.Add(player);
            game.Log(string.Format("Add Player {0}", name));

            game.Log(string.Format("Add Deck: {0}", deck.Name ?? deck.DeckId));

            game.Log(string.Format("Add Heroes: {0}", 
                string.Join(", ", heroes.Select(h => h.Title + "[" + h.Sphere.ToString() + "]").ToArray())));
        }

        private void ShuffleDecks()
        {
            foreach (var player in game.Players)
            {
                player.IsActivePlayer = true;
                player.Deck.Shuffle();
                game.Log(string.Format("Player {0} Shuffles their Deck", player.Name));
            }
        }

        private void PlaceHerosAndSetInitialThreat()
        {
            foreach (var player in game.Players)
            {
                var placeHeroEffects = player.Heroes.SelectMany(h => 
                    GetEffectsByTrigger(
                        h.Card.Slug, CardSide.Front, Trigger.Setup_Place_Hero));

                var determineThreatEffects = player.Heroes.SelectMany(h => 
                    GetEffectsByTrigger(
                        h.Card.Slug, CardSide.Front, Trigger.Setup_Determine_Hero_Starting_Threat));

                player.IsActivePlayer = true;

                game.Log(string.Format("Player {0} Places Heres and Set Initial Threat", player.Name));

                foreach (var hero in player.Heroes)
                {
                    var placeHero = new GameEvent { Description = "Place Hero" +  hero.Card.Title };
                    placeHero.CardsInPlay.Add(hero);
                    ExecuteAutomaticEffects(placeHeroEffects);
                    game.Log(placeHero);
                    player.PlayArea.Add(hero);

                    var determineThreat = new GameEvent{Description = "Determine Starting Threat for Hero " + hero.Card.Title};
                    determineThreat.CardsInPlay.Add(hero);
                    ExecuteAutomaticEffects(determineThreatEffects);
                    game.Log(determineThreat);
                    player.Threat += hero.Card.ThreatCost.Value;
                }

                game.Log(string.Format("Player {0} Initial Threat Set to {1}", player.Name, player.Threat));
            }
        }

        private void DetermineFirstPlayer()
        {
            var first = game.Players.First();
            first.IsFirstPlayer = true;
            game.Log(string.Format("Player {0} is the First Player", first.Name));

            //TODO: Allow Players to choose first player in multiplayer games
        }

        private void ResolveEffects(Dictionary<EffectType, List<Effect>> effects)
        {
            foreach (var effect in effects[EffectType.Passive])
            {
                if (effect.Criteria(game) && effect.GetChoice(game) == null)
                {
                    effect.Resolve(game);
                }
            }

            foreach (var effect in effects[EffectType.Forced])
            {
                if (effect.Criteria(game) && effect.GetChoice(game) == null)
                {
                    effect.Resolve(game);
                }
            }

            foreach (var effect in effects[EffectType.Response])
            {
                if (effect.Criteria(game) && effect.GetChoice(game) == null)
                {
                    effect.Resolve(game);
                }
            }
        }

        private void DrawSetupHand()
        {
            
        }

        public void SetupGame(
            IEnumerable<Player> players, Scenario scenario, GameMode mode)
        {
            game.Log("Begin Setup");

            ShuffleDecks();

            PlaceHerosAndSetInitialThreat();

            game.Log("Create Virtual Token Bank (the Bear likes playing with tokens)");

            DetermineFirstPlayer();

            //TODO: Chain these
            SetCurrentSegment<Setup.DrawSetupHand>();

            //TODO: These need to be chained
            SetCurrentSegment<Setup.SetupQuestCard>();
            //SetupQuestCard(scenario, mode);
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

        public void Run()
        {
            //TODO: Check current status of the game and each player, then advance to the next choice
        }
    }
}