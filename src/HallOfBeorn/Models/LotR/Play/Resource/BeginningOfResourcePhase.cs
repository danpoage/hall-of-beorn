using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play.Resource
{
    public class BeginningOfResourcePhase
        : GameSegment
    {
        public BeginningOfResourcePhase()
            : base(Phase.Resource, FrameworkStep.Resource_Begin)
        {
            AddPart(Play.FrameworkStep.Resource_Begin, 
                Effect.Create(FrameworkStep.Resource_Begin, EffectTiming.When, Trigger.When_Phase_Begins, "Beginning of resource phase")
                .Accept((gm) =>
                {
                    return "Beginning of resource phase";
                })
            );
        }
    }
}
