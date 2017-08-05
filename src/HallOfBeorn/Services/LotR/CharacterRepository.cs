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
            add(new AnbornCharacter());
            add(new AragornCharacter());
            add(new ArwenUndomielCharacter());
            add(new BalinCharacter());
            add(new BardTheBowmanCharacter());
            add(new BarlimanButterburCharacter());
            add(new BeechboneCharacter());
            add(new BeornCharacter());
            add(new BeregondCharacter());
            add(new BifurCharacter());
            add(new BilboBagginsCharacter());
            add(new BillThePonyCharacter());
            add(new BofurCharacter());
            add(new BomburCharacter());
            add(new BoromirCharacter());
            add(new BrandSonOfBainCharacter());
            add(new CelebornCharacter());
            add(new CelebrianCharacter());
            add(new CeorlCharacter());
            add(new CirdanTheShipwrightCharacter());
            add(new DainIronfootCharacter());
            add(new DamrodCharacter());
            add(new DenethorCharacter());
            add(new DeorwineCharacter());
            add(new DoriCharacter());
            add(new DunhereCharacter());
            add(new DwalinCharacter());
            add(new ElfhelmCharacter());
            add(new ElladanCharacter());
            add(new ElrohirCharacter());
            add(new ElrondCharacter());
            add(new EomerCharacter());
            add(new EomundCharacter());
            add(new EothainCharacter());
            add(new EowynCharacter());
            add(new ErestorCharacter());
            add(new ErkenbrandCharacter());
            add(new FaramirCharacter());
            add(new FarmerMaggotCharacter());
            add(new FastredCharacter());
            add(new FattyBolgerCharacter());
            add(new FiliCharacter());
            add(new ForlongCharacter());
            add(new FrodoBagginsCharacter());
            add(new GaladrielCharacter());
            add(new GaldorOfTheHavensCharacter());
            add(new GamlingCharacter());
            add(new GandalfCharacter());
            add(new GhanBuriGhanCharacter());
            add(new GildorInglorionCharacter());
            add(new GimliCharacter());
            add(new GleowineCharacter());
            add(new GloinCharacter());
            add(new GlorfindelCharacter());
            add(new GollumCharacter());
            add(new GondorGroup());
            add(new GrimaCharacter());
            add(new GrimbeornTheOldCharacter());
            add(new GrimboldCharacter());
            add(new GuthlafCharacter());
            add(new GwaihirCharacter());
            add(new HalbaradCharacter());
            add(new HaldirOfLorienCharacter());
            add(new HalfastGamgeeCharacter());
            add(new HamaCharacter());
            add(new HirgonCharacter());
            add(new HirluinTheFairCharacter());
            add(new IngoldCharacter());
            add(new IorethCharacter());
            add(new KiliCharacter());
            add(new LandrovalCharacter());
            add(new LegolasCharacter());
            add(new LindirCharacter());
            add(new MablungCharacter());
            add(new MerryCharacter());
            add(new NoriCharacter());
            add(new OinCharacter());
            add(new OriCharacter());
            add(new OrophinCharacter());
            add(new PippinCharacter());
            add(new PrinceImrahilCharacter());
            add(new QuickbeamCharacter());
            add(new RadagastCharacter());
            add(new RangersOfIthilienGroup());
            add(new RobinSmallburrowCharacter());
            add(new RumilCharacter());
            add(new SamGamgeeCharacter());
            add(new SarumanCharacter());
            add(new SkinbarkCharacter());
            add(new TheCouncilOfElrondGroup());
            add(new TheEntsGroup());
            add(new TheFellowshipOfTheRingGroup());
            add(new TheodenCharacter());
            add(new TheRohirrimGroup());
            add(new TheWhiteCouncilGroup());
            add(new TheodredCharacter());
            add(new ThorinOakenshieldCharacter());
            add(new ThorinsCompanyGroup());
            add(new TomBombadilCharacter());
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