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
            add(new BeregondCharacter());
            add(new BifurCharacter());
            add(new BilboBagginsCharacter());
            add(new BoromirCharacter());
            add(new BrandSonOfBainCharacter());
            add(new CelebornCharacter());
            add(new DainIronfootCharacter());
            add(new DenethorCharacter());
            add(new DunhereCharacter());
            add(new DwalinCharacter());
            add(new ElladanCharacter());
            add(new ElrohirCharacter());
            add(new ElrondCharacter());
            add(new EomerCharacter());
            add(new EowynCharacter());
            add(new FaramirCharacter());
            add(new FastredCharacter());
            add(new FrodoBagginsCharacter());
            add(new GaladrielCharacter());
            add(new GandalfCharacter());
            add(new GimliCharacter());
            add(new GloinCharacter());
            add(new GlorfindelCharacter());
            add(new GondorGroup());
            add(new GrimaCharacter());
            add(new HaldirOfLorienCharacter());
            add(new HamaCharacter());
            add(new HirgonCharacter());
            add(new HirluinTheFairCharacter());
            add(new LegolasCharacter());
            add(new MablungCharacter());
            add(new MerryCharacter());
            add(new PippinCharacter());
            add(new PrinceImrahilCharacter());
            add(new QuickbeamCharacter());
            add(new RangersOfIthilienGroup());
            add(new SamGamgeeCharacter());
            add(new TheEntsGroup());
            add(new TheFellowshipOfTheRingGroup());
            add(new TheodenCharacter());
            add(new TheRohirrimGroup());
            add(new TheWhiteCouncilGroup());
            add(new TheodredCharacter());
            add(new ThorinsCompanyGroup());
            add(new TreebeardCharacter());
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