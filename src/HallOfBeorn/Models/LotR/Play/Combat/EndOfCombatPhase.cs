using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Combat
{
    public class EndOfCombatPhase
        : GameSegment
    {
        public EndOfCombatPhase()
            : base(Phase.Combat, FrameworkStep.Combat_End_Discard_All_Shadow_Cards)
        {
        }

        public override IEnumerable<Effect> Execute(Game game)
        {
            var endOfPhaseEffect = Effect.Create(
                SetupStep.None, EffectTiming.After, Trigger.After_End_of_Phase, "End of combat phase discard all shadow cards")
                .WithCriteria((gm) => true)
                .Accept((gm) =>
                {
                    foreach (var staged in gm.StagingArea.Where(st => st.ShadowCards.Count > 0))
                    {
                        gm.EncounterDeck.Discard(staged.ShadowCards);
                        staged.ShadowCards.Clear();
                    }
                    foreach (var player in gm.Players)
                    {
                        foreach (var enemy in player.PlayArea.Where(ip => ip.ShadowCards.Count > 0))
                        {
                            gm.EncounterDeck.Discard(enemy.ShadowCards);
                            enemy.ShadowCards.Clear();
                        }
                    }
                    return "Discard all shadow cards";
                })
                .Accept((gm) =>
                {
                    gm.Phase = Play.Phase.Refresh;
                    gm.FrameworkStep = Play.FrameworkStep.None;
                    return "End of combat phase";
                });

            return new List<Effect> { endOfPhaseEffect };
        }
    }
}
