using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.LotR.Characters;

namespace HallOfBeorn.Services.LotR
{
    public class CharacterRepository
    {
        public CharacterRepository()
        {
            add(new AragornCharacter());
            add(new ArwenUndomielCharacter());
            add(new BilboBagginsCharacter());
            add(new BoromirCharacter());
            add(new ElladanCharacter());
            add(new ElrohirCharacter());
            add(new ElrondCharacter());
            add(new FrodoBagginsCharacter());
            add(new GandalfCharacter());
            add(new GimliCharacter());
            add(new LegolasCharacter());
            add(new SamGamgeeCharacter());
            add(new TheFellowshipOfTheRingCharacter());
        }

        private readonly Dictionary<string, Character> all = new Dictionary<string, Character>();

        private void add(Character character)
        {
            all.Add(character.NormalizedName.ToUrlSafeString(), character);
        }

        public bool Exists(string name)
        {
            return all.ContainsKey(name);
        }

        public Character Lookup(string name)
        {
            return Exists(name) ?
                all[name]
                : null;
        }

        public IEnumerable<Character> WithSlug(string slug)
        {
            foreach (var c in all.Values) {
                foreach (var cardSlug in c.Cards) {
                    yield return c;
                }
            }
        }

        public IEnumerable<Character> All()
        {
            return all.Values;
        }
    }
}