using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Planning
{
    public class SpecialPlayerActionWindow
        : GameSegment
    {
        public SpecialPlayerActionWindow()
            : base(Phase.Planning, FrameworkStep.Planning_Special_Player_Action_Window)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var effects = new List<Effect>();

            var activePlayer = game.ActivePlayer();

            var passChoice = new Choice(ChoiceType.Exclusive){
                Description = string.Format("Does {0} pass on their action opportunity?", activePlayer.Name),
                FrameworkStep = Play.FrameworkStep.Planning_Special_Player_Action_Window,
            };
            passChoice.Options.Add(new Option{ Description = "Yes, pass on the opportunity to play actions", IsAccept = true, Context = activePlayer.Name });
            passChoice.Options.Add(new Option{Description = "No, continue to play actions", IsDecline = true, Context = activePlayer.Name });

            var passEffect = Effect.Create
                (FrameworkStep.Planning_Special_Player_Action_Window, EffectTiming.When, Trigger.When_Player_Passes_in_Action_Window, "When player passes in Action Window")
                .WithChoice(passChoice)
                .Accept((gm) =>
                    {
                        var active = gm.ActivePlayer();
                        active.HasPassedOnActionOpportunity = true;

                        if (gm.Players.All(p => p.HasPassedOnActionOpportunity))
                        {
                            gm.FrameworkStep = Play.FrameworkStep.Planning_End;
                            return "All players have passed on their action opportunities";
                        } else {
                            var next = gm.MakeNextPlayerActive();
                            return string.Format("{0} passed on their action opportunity, {1} is now the active player",
                                active.Name, next.Name);
                        }
                    })
                .Decline((gm) =>
                    {
                        return gm.ActivePlayer().Name + " chooses to play more actions";
                    });

            effects.Add(passEffect);

            foreach (var player in game.Players)
            {
                var playChoice = new Choice(ChoiceType.Exclusive)
                {
                    Description = string.Format("{0}, which card do you want to play?", player.Name) 
                };

                //TODO: Only active player can play allies, attachments, and side quests

                var playEffect = Effect.Create(
                    FrameworkStep.Planning_Special_Player_Action_Window, EffectTiming.When, Trigger.When_Player_Takes_an_Action, "When player takes an action")
                    .WithChoice(playChoice)
                    .Accept((gm) =>
                        {
                            return "Play card X";
                        });

                //TODO: Only add effect is this player has cards they can play
                effects.Add(playEffect);
            }

            return effects;
        }
    }
}