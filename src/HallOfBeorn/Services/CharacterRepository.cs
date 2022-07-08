using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;
using HallOfBeorn.Models.Characters;
using HallOfBeorn.Models.Characters.Groups;
using HallOfBeorn.Models.Characters.Places;
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

            initializeCharacters();
            initializeGroups();
            initializePlaces();
            initializeThings();
        }

        private readonly Dictionary<string, Character> all = new Dictionary<string, Character>();
        private readonly Dictionary<string, List<CharacterRelationship>> relationshipsBySubject = new Dictionary<string, List<CharacterRelationship>>();
        private readonly Dictionary<string, List<CharacterRelationship>> relationshipsByObject = new Dictionary<string, List<CharacterRelationship>>();

        private void add(Character character)
        {
            all.Add(character.Slug, character);
        }

        private void initializeCharacters()
        {
            add(new AnbornCharacter());
            add(new AngborTheFearlessCharacter());
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
            add(new BobCharacter());
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
            add(new DerufinCharacter());
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
            add(new GrimaCharacter());
            add(new GrimbeornTheOldCharacter());
            add(new GrimboldCharacter());
            add(new GuthlafCharacter());
            add(new GwaihirCharacter());
            add(new HalbaradCharacter());
            add(new HaldirOfLorienCharacter());
            add(new HalfastGamgeeCharacter());
            add(new HamaCharacter());
            add(new HarryGoatleafCharacter());
            add(new HerubrandCharacter());
            add(new HirgonCharacter());
            add(new HirluinTheFairCharacter());
            add(new IngoldCharacter());
            add(new IorethCharacter());            
            add(new KiliCharacter());
            add(new LandrovalCharacter());
            add(new LeaflockCharacter());
            add(new LegolasCharacter());
            add(new LilyCottonCharacter());
            add(new LindirCharacter());
            add(new LothirielCharacter());
            add(new MablungCharacter());
            add(new MeneldorCharacter());
            add(new MerryCharacter());
            add(new MorwenSteelsheenCharacter());
            add(new NobCharacter());
            add(new NoriCharacter());
            add(new OinCharacter());
            add(new OriCharacter());
            add(new OrophinCharacter());
            add(new PippinCharacter());
            add(new PrinceImrahilCharacter());
            add(new QuickbeamCharacter());
            add(new RadagastCharacter());
            add(new RobinSmallburrowCharacter());
            add(new RosieCottonCharacter());
            add(new RumilCharacter());
            add(new SamGamgeeCharacter());
            add(new SarumanCharacter());
            add(new SkinbarkCharacter());
            add(new ThengelCharacter());
            add(new TheodenCharacter());
            add(new TheodwynCharacter());
            add(new TheodredCharacter());
            add(new ThorinOakenshieldCharacter());
            add(new ThorinStonehelmCharacter());
            add(new TomBombadilCharacter());
            add(new TomCottonCharacter());
            add(new ThranduilCharacter());
            add(new TreebeardCharacter());
            add(new YoungTomCharacter());
        }

        private void initializeGroups()
        {
            add(new BeorningsGroup());
            add(new CouncilOfElrondGroup());
            add(new EaglesGroup());
            add(new EntsGroup());
            add(new FellowshipOfTheRingGroup());
            add(new GreyCompanyGroup());
            add(new IstariGroup());
            add(new RangersOfIthilienGroup());
            add(new ThorinsCompanyGroup());
            add(new ThreeHuntersGroup());
            add(new WhiteCouncilGroup());
        }

        private void initializePlaces()
        {
            add(new EyriePlace());
            add(new FangornPlace());
            add(new GondorPlace());
            add(new LorienPlace());
            add(new RivendellPlace());
            add(new RohanPlace());
            add(new ShirePlace());
        }

        private void initializeThings()
        {
            add(new Glamdring());
            add(new MithrilShirt());
            add(new OneRingThing());
            add(new Orcrist());
            add(new Sting());
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

        public bool IncludesCard(string name, string cardTitle, string cardSlug, Func<string, string, bool> linksToCard)
        {
            var character = Lookup(name);
            if (character == null)
            {
                return false;
            }

            if (character.IncludesCard(cardSlug))
            {
                return true;
            }

            if (character.IsRelatedTo(cardTitle))
            {
                return true;
            }

            return linksToCard(name, cardSlug);
        }
    }
}