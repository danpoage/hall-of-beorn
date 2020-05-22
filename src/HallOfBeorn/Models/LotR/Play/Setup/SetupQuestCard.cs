using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class SetupQuestCard : GameSegment
    {
        public SetupQuestCard()
            : base(SetupStep.Setup_Quest_Cards, Phase.None, FrameworkStep.None)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            //TODO: Runner should perform this automatically
            game.PendingEffects.Clear();

            game.Log("Setup Quest Card for Scenario: " + game.Scenario.Title + " [" + game.Mode.ToString() + " Mode]");

            var effects = LookupEffects(game.MainQuest.Card.Slug, CardSide.Front);

            return effects;
        }
    }
}