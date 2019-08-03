using System;
using System.Collections.Generic;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.Characters;
using HallOfBeorn.Models.Characters.Groups;
using HallOfBeorn.Models.Characters.Things;

namespace HallOfBeorn.Services
{
    public class CharacterRepository : ICharacterRepository
    {
        public CharacterRepository()
        {
            Action<string, RelationshipType, string> addRel = (subName, type, objName) =>
            {
                relationship(subName, type, objName);
            };

            add(new AnbornCharacter());
            add(new AragornCharacter());
            add(new ArwenUndomielCharacter());
            add(new BalinCharacter());
            add(new BardSonOfBrandCharacter());
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
            add(new FolcoBoffinCharacter());
            add(new ForlongCharacter());
            add(new FrodoBagginsCharacter());
            add(new GafferGamgeeCharacter());
            add(new GaladrielCharacter());
            add(new GaldorOfTheHavensCharacter());
            add(new GalionCharacter());
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
            add(new IstariGroup());
            add(new KiliCharacter());
            add(new LandrovalCharacter());
            add(new LeaflockCharacter());
            add(new LegolasCharacter());
            add(new LindirCharacter());
            add(new LorienGroup());
            add(new MablungCharacter());
            add(new MeneldorCharacter());
            add(new MerryCharacter());
            add(new MithrilShirt());
            add(new NoriCharacter());
            add(new OinCharacter());
            add(new OriCharacter());
            add(new OrophinCharacter());
            add(new PippinCharacter());
            add(new PrinceImrahilCharacter());
            add(new QuickbeamCharacter());
            add(new RadagastCharacter());
            add(new RangersOfIthilienGroup());
            add(new RivendellGroup());
            add(new RobinSmallburrowCharacter());
            add(new RohanGroup());
            add(new RosieCottonCharacter());
            add(new RumilCharacter());
            add(new SamGamgeeCharacter());
            add(new SarumanCharacter());
            add(new SkinbarkCharacter());
            add(new Sting());
            add(new TheBeorningsGroup());
            add(new TheCouncilOfElrondGroup());
            add(new TheEaglesGroup());
            add(new TheEntsGroup());
            add(new TheFellowshipOfTheRingGroup());
            add(new TheGreyCompanyGroup());
            add(new TheodenCharacter());
            add(new TheOneRingThing());
            add(new TheShirePlace());
            add(new TheWhiteCouncilGroup());
            add(new TheodredCharacter());
            add(new ThorinOakenshieldCharacter());
            add(new ThorinStonehelmCharacter());
            add(new ThorinsCompanyGroup());
            add(new TomBombadilCharacter());
            add(new TomCottonCharacter());
            add(new ThranduilCharacter());
            add(new TreebeardCharacter());
        }

        private readonly Dictionary<string, Character> all = new Dictionary<string, Character>();
        private readonly Dictionary<string, List<CharacterRelationship>> relationshipsBySubject = new Dictionary<string, List<CharacterRelationship>>();
        private readonly Dictionary<string, List<CharacterRelationship>> relationshipsByObject = new Dictionary<string, List<CharacterRelationship>>();

        private void add(Character character)
        {
            all.Add(character.Slug, character);
        }

        private void relationship(string subjectName, RelationshipType type, string objectName)
        {
            var rel = new CharacterRelationship(subjectName, type, objectName);

            if (!relationshipsBySubject.ContainsKey(rel.SubjectSlug)) {
                relationshipsBySubject[rel.SubjectSlug] = new List<CharacterRelationship>();
            }
            relationshipsBySubject[rel.SubjectSlug].Add(rel);

            if (!relationshipsByObject.ContainsKey(rel.ObjectSlug)) {
                relationshipsByObject[rel.ObjectSlug] = new List<CharacterRelationship>();
            }
            relationshipsByObject[rel.ObjectSlug].Add(rel);
        }

        public bool Exists(string name)
        {
            var slug = name.Slugify();

            return all.ContainsKey(slug);
        }

        public Character Lookup(string name)
        {
            var slug = name.Slugify();

            return Exists(slug) ?
                all[slug]
                : null;
        }

        /*
        public IEnumerable<Character> WithSlug(string slug)
        {
            foreach (var c in all.Values) {
                foreach (var cardSlug in c.Cards) {
                    yield return c;
                }
            }
        }*/

        public IEnumerable<Character> All()
        {
            return all.Values;
        }
    }
}