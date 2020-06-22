using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class SetupQuestCard : GameSegment
    {
        public SetupQuestCard()
            : base(SetupStep.Setup_Quest_Cards)
        {
            AddPart(SetupStep.Setup_Quest_Cards, (gm) => SetupQuestCardPart(gm));
        }

        private ExecutionResult SetupQuestCardPart(Game game)
        {
            //TODO: Runner should perform this automatically
            game.PendingEffects.Clear();

            game.Log("Setup Quest Card for Scenario: " + game.Scenario.Title + " [" + game.Mode.ToString() + " Mode]");

            var effects = LookupEffects(game.MainQuest.Card.Slug, CardSide.Front);

            return ExecutionResult.Create(effects);
        }
    }
}