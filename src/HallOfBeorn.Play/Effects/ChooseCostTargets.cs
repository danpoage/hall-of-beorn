using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play.Effects
{
    public class ChooseCostTargets
        : GamePart
    {
        public ChooseCostTargets(GameSegment segment, FrameworkStep step)
            : base(segment, step, null)
        {
        }

        public override ExecutionResult Execute(Game game)
        {
            if (game.BeingTriggered == null 
                || game.BeingTriggered.CostTargets.Count > 0)
            {
                return new ExecutionResult();
            }

            var targetEffect = Segment.LookupEffects(
                game.BeingTriggered.Card.Slug, game.BeingTriggered.ActiveSide)
                .FirstOrDefault(ef => ef.Trigger == Trigger.When_Determining_Cost_Targets);

            if (targetEffect != null)
            {
                var costTargets = targetEffect.GetCostTargets(game);
                if (costTargets != null)
                {
                    game.CurrentChoice = targetEffect.GetChoice(game);

                    return new ExecutionResult(targetEffect).Terminate(game.CurrentChoice.Description);
                }
            }

            return new ExecutionResult();
        }
    }
}