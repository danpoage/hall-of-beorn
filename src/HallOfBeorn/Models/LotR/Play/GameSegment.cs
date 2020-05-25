using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public abstract class GameSegment
    {
        protected GameSegment(SetupStep setupStep)
        {
            SetupStep = setupStep;
            Phase = Play.Phase.None;
            FrameworkStep = Play.FrameworkStep.None;
        }

        protected GameSegment(Phase phase, FrameworkStep frameworkStep)
        {
            SetupStep = Play.SetupStep.None;
            Phase = phase;
            FrameworkStep = frameworkStep;
        }

        public Func<string, LotRCard> LookupCard { get; set; }
        public Func<string, CardSide, IEnumerable<Effect>> LookupEffects { get; set; }
        public Func<Trigger, List<Effect>> LookupEffectsByTrigger { get; set; }

        public bool IsPlayerActionWindow { get; set; }

        public SetupStep SetupStep { get; private set; }
        public Phase Phase { get; private set; }
        public FrameworkStep FrameworkStep { get; private set; }

        public abstract IEnumerable<Effect> Execute(Game game);
    }
}
