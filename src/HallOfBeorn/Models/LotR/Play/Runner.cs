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

        private readonly List<GameSegment> setupSegments = new List<GameSegment>{
            new Setup.ShuffleDecks(),
            new Setup.PlaceHeroesAndSetInitialThreat(),
            new Setup.DetermineFirstPlayer(),
            new Setup.DrawSetupHand(),
            new Setup.SetupQuestCard(),
            new Setup.FollowScenarioSetupInstructions() };

        private readonly Dictionary<Phase, List<GameSegment>> phaseSegments = new Dictionary<Phase, List<GameSegment>>
        {
            { Phase.Resource, new List<GameSegment>() },
            { Phase.Planning, new List<GameSegment>() },
            { Phase.Quest, new List<GameSegment>() },
            { Phase.Travel, new List<GameSegment>() },
            { Phase.Encounter, new List<GameSegment>() },
            { Phase.Combat, new List<GameSegment>() },
            { Phase.Refresh, new List<GameSegment>() },
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

            effects.AddRange(game.PendingEffects.All.Where(ef => ef.Trigger == trigger));
            effects.AddRange(game.StagingArea.SelectMany(
                c => lookupEffects(c.Card.Slug, CardSide.Front).Where(ef => ef.Trigger == trigger)));
            
            return effects;
        }

        private bool ExecuteCancelEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.Cancel.PassiveEffects))
                return false;
            if (!ExecuteEffects(game.PendingEffects.Cancel.ForcedEffects))
                return false;
            if (!ExecuteEffects(game.PendingEffects.Cancel.ResponseEffects))
                return false;

            return true;
        }

        private bool ExecuteWhenEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.When.PassiveEffects))
                return false;
            if (!ExecuteEffects(game.PendingEffects.When.ForcedEffects))
                return false;
            if (!ExecuteEffects(game.PendingEffects.When.ResponseEffects))
                return false;

            return true;
        }

        private bool ExecuteAfterEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.After.PassiveEffects))
                return false;
            if (!ExecuteEffects(game.PendingEffects.After.ForcedEffects))
                return false;
            if (!ExecuteEffects(game.PendingEffects.After.ResponseEffects))
                return false;

            return true;
        }

        private bool ExecuteActionEffects()
        {
            //TODO: Check for multiples at the same priority so first player can choose
            if (!ExecuteEffects(game.PendingEffects.Player.ActionEffects))
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

            foreach (var result in effect.Results)
            {
                var message = result(game);
                game.Log(message);
            }

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
            } else
            {
                if (game.Phase > segment.Phase || game.FrameworkStep >= segment.FrameworkStep)
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

        private void Setup()
        {
            foreach (var segment in setupSegments)
            {
                if(!ExecuteSegment(segment))
                {
                    return;
                }
            }
        }

        private bool ResolveCurrentChoice()
        {
            if (game.CurrentChoice.IsCompleted(game, game.CurrentChoice))
            {
                if (game.CurrentChoice.ChoiceType == ChoiceType.Exclusive)
                {
                    if (game.CurrentChoice.IsAccepted(game, game.CurrentChoice))
                    {
                        if (!CheckAndExecuteEffect(game.CurrentChoice.Effect))
                        {
                            return false;
                        }
                    }
                } else if (game.CurrentChoice.ChoiceType == ChoiceType.Selection)
                {
                    if (!CheckAndExecuteEffect(game.CurrentChoice.Effect))
                    {
                        return false;
                    }
                }
            }

            game.CurrentChoice = null;
            game.PendingEffects.Remove(game.CurrentChoice.Effect.Id);
            return true;
        }

        public void Run()
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
                Setup();
                return;
            }

            var segments = phaseSegments[game.Phase];
            foreach (var segment in segments)
            {
                ExecuteSegment(segment);
            }
        }
    }
}
