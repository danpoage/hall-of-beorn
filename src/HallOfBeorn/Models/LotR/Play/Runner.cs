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

        private readonly Dictionary<Phase, List<GameSegment>> phaseSegments = new Dictionary<Phase, List<GameSegment>>
        {
            { Phase.None, new List<GameSegment>{
                new Setup.ShufflePlayerDecks(),
                new Setup.PlaceHeroesAndSetInitialThreat(),
                new Setup.DetermineFirstPlayer(),
                new Setup.DrawSetupHand(),
                new Setup.SetupQuestCard(),
                new Setup.FollowScenarioSetupInstructions() } },
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
            game.PendingEffects.Clear();
            game.PendingEffects.Load(segment.Execute(game));
            game.CurrentChoice = null;
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

            var choice = effect.GetChoice(game);
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

        public void Initialize(
            IEnumerable<Player> players, Scenario scenario, GameMode mode)
        {
            game.Players.Clear();
            game.Players.AddRange(players);

            game.Scenario = scenario;
            game.Mode = mode;
        }

        public void Run()
        {
            if (game.CurrentChoice != null)
            {
                if (!game.CurrentChoice.IsFulfilled(game)
                    || !CheckAndExecuteEffect(game.CurrentChoice.Effect))
                {
                    return;
                }

                game.CurrentChoice = null;
                game.PendingEffects.Remove(game.CurrentChoice.Effect.Id);
            }

            foreach (var segment in phaseSegments[game.Phase])
            {
                SetCurrentSegment(segment);

                var effects = segment.Execute(game);
                game.PendingEffects.Load(effects);

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
                        return;
                    }
                }
            }
        }
    }
}
