using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Runner
    {
        public Runner(Game game,
            Action<string> onLog,
            Func<string, LotRCard> lookupCard,
            Func<string, CardSide, IEnumerable<Effect>> lookupEffects)
        {
            this.game = game;
            game.OnLog = onLog;

            this.lookupCard = lookupCard;
            this.lookupEffects = lookupEffects;
        }

        private readonly Game game;
        private readonly Func<string, LotRCard> lookupCard;
        private readonly Func<string, CardSide, IEnumerable<Effect>> lookupEffects;

        private readonly List<GameSegment> setupSegments = new List<GameSegment>{
            new Setup.BeginningOfSetup(),
            new Setup.ShuffleDecks(),
            new Setup.PlaceHeroesAndSetInitialThreat(),
            new Setup.DetermineFirstPlayer(),
            new Setup.DrawSetupHand(),
            new Setup.SetupQuestCard(),
            new Setup.FollowScenarioSetupInstructions(),
            new Setup.EndOfSetup(),
        };

        private readonly Dictionary<Phase, List<GameSegment>> phaseSegments = new Dictionary<Phase, List<GameSegment>>
        {
            { Phase.Resource, new List<GameSegment>{
                new Resource.BeginningOfRound(),
                new Resource.BeginningOfResourcePhase(),
                new Resource.EndOfResourcePhase(),
            } },
            { Phase.Planning, new List<GameSegment>{
                new Planning.PlanningPhaseBegins(),
                new Planning.SpecialPlayerActionWindow(),
                new Planning.PlanningPhaseEnds(),
            } },
            { Phase.Quest, new List<GameSegment>{
                new Quest.BeginningOfQuestPhase(),
                new Quest.CommitCharacters(),
                new Quest.EndOfQuestPhase(),
            } },
            { Phase.Travel, new List<GameSegment>{
                new Travel.BeginningOfTravelPhase(),
                new Travel.EndOfTravelPhase(),
            } },
            { Phase.Encounter, new List<GameSegment>{
                new Encounter.BeginningOfEncounterPhase(),
                new Encounter.EndOfEncounterPhase(),
            } },
            { Phase.Combat, new List<GameSegment>{
                new Combat.BeginningOfCombatPhase(),
                new Combat.EndOfCombatPhase(),
            } },
            { Phase.Refresh, new List<GameSegment>{
                new Refresh.BeginningOfRefreshPhase(),
                new Refresh.EndOfRefreshPhase(),
                new Refresh.EndOfRound(),
            } },
        };

        private void SetCurrentSegment(GameSegment segment)
        {
            segment.LookupCard = lookupCard;
            segment.LookupEffects = lookupEffects;
            segment.LookupEffectsByTrigger = (trigger) => LookupEffectsByTrigger(trigger);

            game.CurrentSegment = segment;
            game.SetupStep = segment.SetupStep;
            game.Phase = segment.Phase;
            game.FrameworkStep = segment.FrameworkStep;

            game.PendingEffects.Clear();
            game.CurrentChoice = null;

            var effects = segment.Execute(game);

            game.PendingEffects.Load(effects);
        }

        private IEnumerable<Effect> GetEffectsByTrigger(string slug, CardSide side, Trigger trigger)
        {
            return lookupEffects(slug, side).Where(ef => ef.Trigger == trigger);
        }

        private List<Effect> LookupEffectsByTrigger(Trigger trigger)
        {
            var effects = new List<Effect>();

            effects.AddRange(game.PendingEffects.Find(ef => ef.Trigger == trigger));
            effects.AddRange(game.StagingArea.SelectMany(
                c => lookupEffects(c.Card.Slug, CardSide.Front).Where(ef => ef.Trigger == trigger)));
            
            return effects;
        }

        private bool ExecuteCancelEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.Cancel.Passive))
                return false;
            if (!ExecuteEffects(game.PendingEffects.Cancel.Forced))
                return false;
            if (!ExecuteEffects(game.PendingEffects.Cancel.Response))
                return false;

            return true;
        }

        private bool ExecuteWhenEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.When.Passive))
                return false;
            if (!ExecuteEffects(game.PendingEffects.When.Forced))
                return false;
            if (!ExecuteEffects(game.PendingEffects.When.Response))
                return false;

            return true;
        }

        private bool ExecuteAfterEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.After.Passive))
                return false;
            if (!ExecuteEffects(game.PendingEffects.After.Forced))
                return false;
            if (!ExecuteEffects(game.PendingEffects.After.Response))
                return false;

            return true;
        }

        private bool ExecuteActionEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.Player.Action))
                return false;

            return true;
        }

        private bool ExecuteEffects(IEnumerable<Effect> effects)
        {
            foreach (var effect in effects)
            {
                if (!CheckAndExecuteEffect(effect))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckAndExecuteEffect(Effect effect)
        {
            if (!effect.Criteria(game))
            {
                return true;
            }

            var choice = effect.GetChoice != null
            ? effect.GetChoice(game)
            : null;

            if (choice != null)
            {
                choice.Effect = effect;
                game.CurrentChoice = choice;
                return false;
            }

            ResolveResults(effect.AcceptResults);

            return true;
        }

        private bool ExecuteSegment(GameSegment segment)
        {
            if (game.Phase == Phase.None && game.RoundNumber == 0)
            {
                if (game.SetupStep >= segment.SetupStep)
                {
                    return true;
                }
            }
            else
            {
                if (game.Phase > segment.Phase || game.FrameworkStep > segment.FrameworkStep)
                {
                    return true;
                }
            }

            SetCurrentSegment(segment);

            var priorities = new List<Func<bool>>{
                () => ExecuteCancelEffects(),
                () => ExecuteWhenEffects(),
                () => ExecuteAfterEffects(),
                () => ExecuteActionEffects(),
            };

            foreach (var priority in priorities)
            {
                if (!priority())
                {
                    //An effect at this priority requires a choice, exit
                    return false;
                }
            }

            return true;
        }

        private bool Setup()
        {
            foreach (var segment in setupSegments)
            {
                if(!ExecuteSegment(segment))
                {
                    return false;
                }
            }
            return true;
        }

        private void ResolveResults(IEnumerable<Func<Game, string>> results)
        {
            foreach (var result in results)
            {
                var message = result(game);
                game.Log(message);
            }
        }

        private bool ResolveCurrentChoice()
        {
            if (game.CurrentChoice.IsCompleted(game, game.CurrentChoice.Options))
            {
                if (game.CurrentChoice.ChoiceType == ChoiceType.Exclusive)
                {
                    if (game.CurrentChoice.IsAccepted(game, game.CurrentChoice.Options))
                    {
                        ResolveResults(game.CurrentChoice.Effect.AcceptResults);
                    }
                    else
                    {
                        ResolveResults(game.CurrentChoice.Effect.DeclineResults);
                    }
                }
                else if (game.CurrentChoice.ChoiceType == ChoiceType.Selection)
                {
                    if (game.CurrentChoice.IsAccepted(game, game.CurrentChoice.Options))
                    {
                        ResolveResults(game.CurrentChoice.Effect.AcceptResults);
                    }
                }
            }

            game.PendingEffects.Remove(game.CurrentChoice.Effect.Id);
            game.CurrentChoice = null;
            
            return true;
        }

        public void Round()
        {
            var run = true;
            while (run)
            {
                var currentPhase = game.Phase;
                var segments = phaseSegments[game.Phase];
                foreach (var segment in segments)
                {
                    run = ExecuteSegment(segment);
                    if (!run)
                    {
                        return;
                    }
                }
            }
        }

        public void Play()
        {
            if (game.CurrentChoice != null)
            {
                if (!ResolveCurrentChoice())
                {
                    return;
                }
            }

            if (game.Phase == Phase.None && game.RoundNumber == 0)
            {
                if (!Setup())
                {
                    return;
                }
            }

            Round();
        }
    }
}
