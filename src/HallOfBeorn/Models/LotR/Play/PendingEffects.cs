using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR.Play
{
    public class WhenEffects
    {
        public List<Effect> PassiveEffects = new List<Effect>();
        public List<Effect> ForcedEffects = new List<Effect>();
        public List<Effect> ResponseEffects = new List<Effect>();

        public void Clear()
        {
            PassiveEffects.Clear();
            ForcedEffects.Clear();
            ResponseEffects.Clear();
        }

        public void Remove(Guid id)
        {
            //TODO: Implement this with dictionaries
        }

        public void Load(IEnumerable<Effect> effects)
        {
            //TODO: Implement this with dictionaries
        }
    }

    public class AfterEffects
    {
        public List<Effect> PassiveEffects = new List<Effect>();
        public List<Effect> ForcedEffects = new List<Effect>();
        public List<Effect> ResponseEffects = new List<Effect>();

        public void Clear()
        {
            PassiveEffects.Clear();
            ForcedEffects.Clear();
            ResponseEffects.Clear();
        }

        public void Remove(Guid id)
        {
            //TODO: Implement this with dictionaries
        }

        public void Load(IEnumerable<Effect> effects)
        {
            //TODO: Implement this with dictionaries
        }
    }

    public class CancelEffects
    {
        public List<Effect> PassiveEffects = new List<Effect>();
        public List<Effect> ForcedEffects = new List<Effect>();
        public List<Effect> ResponseEffects = new List<Effect>();

        public void Clear()
        {
            PassiveEffects.Clear();
            ForcedEffects.Clear();
            ResponseEffects.Clear();
        }

        public void Remove(Guid id)
        {
            //TODO: Implement this with dictionaries
        }

        public void Load(IEnumerable<Effect> effects)
        {
            //TODO: Implement this with dictionaries
        }
    }

    public class PlayerEffects
    {
        public List<Effect> ActionEffects = new List<Effect>();

        public void Clear()
        {
            ActionEffects.Clear();
        }

        public void Remove(Guid id)
        {
            //TODO: Implement this with dictionaries
        }

        public void Load(IEnumerable<Effect> effects)
        {
            //TODO: Implement this with dictionaries
        }
    }

    public class PendingEffects
    {
        public IEnumerable<Effect> All { get; set; }

        public WhenEffects When = new WhenEffects();
        public AfterEffects After = new AfterEffects();
        public CancelEffects Cancel = new CancelEffects();
        public PlayerEffects Player = new PlayerEffects();
 
        public void Clear()
        {
            When.Clear();
            After.Clear();
            Cancel.Clear();
            Player.Clear();
        }

        public void Load(IEnumerable<Effect> effects)
        {
            //TODO: Use dictionary key lookup to avoid duplicates
            All = effects;
            var cancelEffects = effects.Where(ef => ef.Timing == EffectTiming.Cancel);
            var whenEffects = effects.Where(ef => ef.Timing == EffectTiming.When);
            var afterEffects = effects.Where(ef => ef.Timing == EffectTiming.After);
            var playerEffects = effects.Where(ef => ef.Timing == EffectTiming.None);
        }

        public void Remove(Guid id)
        {
        }
    }
}
