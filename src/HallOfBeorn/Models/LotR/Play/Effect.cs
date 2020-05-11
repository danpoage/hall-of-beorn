using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR.Play
{
    public class Effect
    {
        public EffectSource Source { get; set; }
        public EffectType Type { get; set; }
        public EffectTiming Timing { get; set; }
        FrameworkStep Step  { get; set; }
        public Func<Game, bool> Criteria { get; set; }
        //public Func Cost //TOOD: How to describe a cost functionally
        public List<Action<Game>> Effects = new List<Action<Game>>();

        public List<Action<Game>> UndoEffects = new List<Action<Game>>();
    }
}