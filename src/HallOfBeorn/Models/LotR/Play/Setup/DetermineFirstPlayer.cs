using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Setup
{
    public class DetermineFirstPlayer
        : GameSegment
    {
        public DetermineFirstPlayer()
            : base(SetupStep.Setup_Determine_First_Player)
        {
            AddPart(SetupStep.Setup_Determine_First_Player, (gm) => FirstPlayerPart(gm));
        }

        private static ExecutionResult FirstPlayerPart(Game game)
        {
            var firstPlayerEffect = new Effect("Determine the First Player"){ 
                Timing = EffectTiming.When,
                Type = EffectType.Passive,
                Trigger = Trigger.Setup_Determine_First_Player,
                Criteria = (gm) => true,
                GetChoice = (gm) => null };

            if (game.Players.Count == 1)
            {
                firstPlayerEffect.AcceptResults.Add((gm) =>
                {
                    var first = gm.Players.FirstOrDefault();
                    first.IsFirstPlayer = true;
                    return string.Format("Select {0} as First Player", first.Name);
                });
            } else {
                firstPlayerEffect.GetChoice = (gm) => 
                    {
                        var choice  = new Choice(ChoiceType.Exclusive){ 
                            SetupStep = SetupStep.Setup_Determine_First_Player, 
                            MaxOptionsChosen = 1 
                        };

                        foreach (var player in gm.Players)
                        {
                            choice.Options.Add(new Option { 
                                Description = string.Format("Select {0} as First Player", player.Name),
                                Value = player.Name
                            });
                        }
                        return choice;
                    };

                firstPlayerEffect.AcceptResults.Add((gm) =>
                {
                    var first = gm.Players.FirstOrDefault(p => p.Name ==
                        gm.CurrentChoice.Options.FirstOrDefault(opt => opt.IsChosen).Value);
                    first.IsFirstPlayer = true;
                    return string.Format("Select {0} as First Player", first.Name);
                });

                
            }

            return ExecutionResult.Create(firstPlayerEffect);
        }
    }
}