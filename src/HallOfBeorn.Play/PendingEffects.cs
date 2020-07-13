using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Play
{
    public class EffectMap
    {
        private readonly Dictionary<EffectType, Dictionary<string, Effect>> map = new Dictionary<EffectType, Dictionary<string, Effect>>
        {
            { EffectType.Passive, new Dictionary<string, Effect>() },
            { EffectType.Forced, new Dictionary<string, Effect>() },
            { EffectType.Response, new Dictionary<string, Effect>() },
            { EffectType.Action, new Dictionary<string, Effect>() },
        };
        
        public IEnumerable<Effect> Passive { get { return map[EffectType.Passive].Values; } }
        public IEnumerable<Effect> Forced { get { return map[EffectType.Forced].Values; } }
        public IEnumerable<Effect> Response { get { return map[EffectType.Response].Values; } }
        public IEnumerable<Effect> Action { get { return map[EffectType.Action].Values; } }

        public void Clear()
        {
            foreach (var typeKey in map.Keys)
            {
                map[typeKey].Clear();
            }
        }

        public void Remove(string id)
        {
            foreach (var typeKey in map.Keys)
            {
                if (map[typeKey].ContainsKey(id))
                    map[typeKey].Remove(id);
            }
        }

        public void Add(Effect effect)
        {
            if (!map[effect.Type].ContainsKey(effect.Id))
                map[effect.Type].Add(effect.Id, effect);
        }

        public void Load(IEnumerable<Effect> effects)
        {
            foreach (var effect in effects)
                Add(effect);
        }
    }

    public class PendingEffects
    {
        private readonly Dictionary<string, Effect> all = new Dictionary<string, Effect>();

        private Dictionary<EffectTiming, EffectMap> map = new Dictionary<EffectTiming, EffectMap>{
            { EffectTiming.After, new EffectMap() },
            { EffectTiming.Cancel, new EffectMap() },
            { EffectTiming.Player, new EffectMap() },
            { EffectTiming.When, new EffectMap() },
        };

        public EffectMap After { get { return map[EffectTiming.After]; } }
        public EffectMap Cancel { get { return map[EffectTiming.Cancel]; } }
        public EffectMap Player { get { return map[EffectTiming.Player]; } }
        public EffectMap When { get { return map[EffectTiming.When]; } }

        public void Clear()
        {
            all.Clear();
            foreach (var timingKey in map.Keys)
            {
                map[timingKey].Clear();
            }
        }

        public void Clear(IEnumerable<string> ids)
        {
            foreach (var id in ids)
            {
                Remove(id);
            }
        }

        public void ClearAttackEffects()
        {
            var ids = all.Where(ef => ef.Value.Duration == EffectDuration.Attack).Select(ef => ef.Key);
            Clear(ids);
        }

        public void ClearPhaseEffects()
        {
            var ids = all.Where(ef => ef.Value.Duration == EffectDuration.Phase).Select(ef => ef.Key);
            Clear(ids);
        }

        public void ClearRoundEffects()
        {
            var ids = all.Where(ef => ef.Value.Duration == EffectDuration.Round).Select(ef => ef.Key);
            Clear(ids);
        }

        public void Load(IEnumerable<Effect> effects)
        {
            foreach (var effect in effects)
            {
                Add(effect);
                map[effect.Timing].Add(effect);
            }
        }

        public void Add(Effect effect)
        {
            if (!all.ContainsKey(effect.Id))
                all.Add(effect.Id, effect);
        }

        public void Remove(string id)
        {
            if (!all.ContainsKey(id))
            {
                return;
            }

            var timing = all[id].Timing;
            all.Remove(id);
            map[timing].Remove(id);
        }

        public Effect Get(string id)
        {
            return all.ContainsKey(id)
                ? all[id]
                : null;
        }

        public IEnumerable<Effect> Find(Func<Effect, bool> predicate)
        {
            return all.Values.Where(predicate);
        }
    }
}
