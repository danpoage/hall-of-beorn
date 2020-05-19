using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public abstract class GameSegment
    {
        public Func<string, LotRCard> LookupCard { get; set; }
        public Func<string, CardSide, IEnumerable<Effect>> LookupEffects { get; set; }
        public Func<Trigger, List<Effect>> LookupEffectsByTrigger { get; set; }

        public bool IsPlayerActionWindow { get; set; }

        public abstract IEnumerable<Effect> Execute(Game game);
    }
}