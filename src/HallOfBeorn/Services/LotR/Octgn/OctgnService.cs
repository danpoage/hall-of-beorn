using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Octgn
{
    public class OctgnService : IOctgnService
    {
        public OctgnService(ProductRepository productRepository, ICardRepository<LotRCard> cardRepository)
        {
            this.productRepository = productRepository;
            this.cardRepository = cardRepository;
            init();
        }

        private readonly ProductRepository productRepository;
        private readonly ICardRepository<LotRCard> cardRepository;

        private readonly Dictionary<string, string> setNamesByGuid = new Dictionary<string,string>();
        private readonly Dictionary<string, string> setGuidsByName = new Dictionary<string, string>();
        private readonly Dictionary<string, string> cardSlugsByGuid = new Dictionary<string, string>();
        private readonly Dictionary<string, string> cardGuidsBySlug = new Dictionary<string, string>();
        
        private void init()
        {
            addSet(new Sets.Core.CoreSet());
            addSet(new Sets.ShadowsOfMirkwood.AJourneyToRhosgobelSet());
            addSet(new Sets.ShadowsOfMirkwood.ConflictAtTheCarrockSet());
            addSet(new Sets.ShadowsOfMirkwood.ReturnToMirkwoodSet());
            addSet(new Sets.ShadowsOfMirkwood.TheDeadMarshesSet());
            addSet(new Sets.ShadowsOfMirkwood.TheHillsOfEmynMuilSet());
            addSet(new Sets.ShadowsOfMirkwood.TheHuntForGollumSet());
            addSet(new Sets.KhazadDum.KhazadDumSet());
            addSet(new Sets.Dwarrowdelf.FoundationsOfStoneSet());
            addSet(new Sets.Dwarrowdelf.RoadToRivendellSet());
            addSet(new Sets.Dwarrowdelf.ShadowAndFlameSet());
            addSet(new Sets.Dwarrowdelf.TheLongDarkSet());
            addSet(new Sets.Dwarrowdelf.TheRedhornGateSet());
            addSet(new Sets.Dwarrowdelf.TheWatcherInTheWaterSet());
            addSet(new Sets.HeirsOfNumenor.HeirsOfNumenorSet());
            addSet(new Sets.AgainstTheShadow.AssaultOnOsgiliathSet());
            addSet(new Sets.AgainstTheShadow.EncounterAtAmonDinSet());
            addSet(new Sets.AgainstTheShadow.TheBloodOfGondorSet());
            addSet(new Sets.AgainstTheShadow.TheDruadanForestSet());
            addSet(new Sets.AgainstTheShadow.TheMorgulValeSet());
            addSet(new Sets.AgainstTheShadow.TheStewardsFearSet());
            addSet(new Sets.TheVoiceOfIsengard.TheVoiceOfIsengardSet());
            addSet(new Sets.TheRingMaker.CelebrimborsSecretSet());
            addSet(new Sets.TheRingMaker.TheAntleredCrownSet());
            addSet(new Sets.TheRingMaker.TheDunlandTrapSet());
            addSet(new Sets.TheRingMaker.TheNinInEilphSet());
            addSet(new Sets.TheRingMaker.TheThreeTrialsSet());
            addSet(new Sets.TheRingMaker.TroubleInTharbadSet());
            addSet(new Sets.TheLostRealm.TheLostRealmSet());
            addSet(new Sets.AngmarAwakened.AcrossTheEttenmoorsSet());
            addSet(new Sets.AngmarAwakened.EscapeFromMountGramSet());
            addSet(new Sets.AngmarAwakened.TheBattleOfCarnDumSet());
            addSet(new Sets.AngmarAwakened.TheDreadRealmSet());
            addSet(new Sets.AngmarAwakened.TheTreacheryOfRhudaurSet());
            addSet(new Sets.AngmarAwakened.TheWastesOfEriadorSet());
            addSet(new Sets.TheGreyHavens.TheGreyHavensSet());
            addSet(new Sets.DreamChaser.AStormOnCobasHavenSet());
            addSet(new Sets.DreamChaser.FlightOfTheStormcallerSet());
            addSet(new Sets.DreamChaser.TempleOfTheDeceivedSet());
            addSet(new Sets.DreamChaser.TheCityOfCorsairsSet());
            addSet(new Sets.DreamChaser.TheDrownedRuinsSet());
            addSet(new Sets.DreamChaser.TheThingInTheDepthsSet());
            addSet(new Sets.TheSandsOfHarad.TheSandsOfHaradSet());
            addSet(new Sets.Haradrim.BeneathTheSandsSet());
            addSet(new Sets.Haradrim.TheBlackSerpentSet());
            addSet(new Sets.Haradrim.TheCrossingsOfPorosSet());
            addSet(new Sets.Haradrim.TheDungeonsOfCirithGuratSet());
            addSet(new Sets.Haradrim.TheMumakilSet());
            addSet(new Sets.Haradrim.TheRaceAcrossHaradSet());
            addSet(new Sets.TheWildsOfRhovanion.TheWildsOfRhovanionSet());
            addSet(new Sets.EredMithrin.FireInTheNightSet());
            addSet(new Sets.EredMithrin.MountGundabadSet());
            addSet(new Sets.EredMithrin.RoamAcrossRhovanionSet());
            addSet(new Sets.EredMithrin.TheFateOfWilderlandSet());
            addSet(new Sets.EredMithrin.TheGhostOfFramsburgSet());
            addSet(new Sets.EredMithrin.TheWitheredHeathSet());
            addSet(new Sets.AShadowInTheEast.AShadowInTheEastSet());
            addSet(new Sets.VengeanceOfMordor.ChallengeOfTheWainridersSet());
            addSet(new Sets.VengeanceOfMordor.TheCityOfUlfastSet());
            addSet(new Sets.VengeanceOfMordor.WrathAndRuinSet());

            addSet(new Sets.TheHobbit.TheHobbitOnTheDoorstepSet());
            addSet(new Sets.TheHobbit.TheHobbitOverHillAndUnderHillSet());

            addSet(new Sets.TheLordOfTheRings.TheBlackRidersSet());
            addSet(new Sets.TheLordOfTheRings.TheFlameOfTheWestSet());
            addSet(new Sets.TheLordOfTheRings.TheLandOfShadowSet());
            addSet(new Sets.TheLordOfTheRings.TheMountainOfFireSet());
            addSet(new Sets.TheLordOfTheRings.TheRoadDarkensSet());
            addSet(new Sets.TheLordOfTheRings.TheTreasonOfSarumanSet());

            addSet(new Sets.Starter.TwoPlayerLimitedEditionStarterSet());
        }

        private void addSet(OctgnSet octgnSet)
        {
            setNamesByGuid[octgnSet.Id] = octgnSet.Name;
            setGuidsByName[octgnSet.Name] = octgnSet.Id;

            foreach (var card in octgnSet.CardsById)
            {
                addCard(octgnSet.Name, card.Key, card.Value);
            }
        }

        private void addCard(string setName, string cardGuid, string cardTitle)
        {
            var cardSet = productRepository
                .CardSets()
                .FirstOrDefault(cs => cs.Name == setName || cs.NormalizedName == setName);

            if (cardSet != null)
            {
                var cardSlug = string.Format("{0}-{1}", cardTitle.NormalizeCaseSensitiveString().ToUrlSafeString(), cardSet.Abbreviation);

                cardSlugsByGuid[cardGuid] = cardSlug;
                cardGuidsBySlug[cardSlug] = cardGuid;
            }
        }

        public string GetCardOctgnGuid(string slug)
        {
            return cardGuidsBySlug.ContainsKey(slug) ? cardGuidsBySlug[slug] : string.Empty;
        }

        public string GetCardSlug(string octgnGuid)
        {
            return cardSlugsByGuid.ContainsKey(octgnGuid) ? cardSlugsByGuid[octgnGuid] : string.Empty;
        }

        public string GetSetOctgnGuid(string setName)
        {
            return setGuidsByName.ContainsKey(setName) ? setGuidsByName[setName] : string.Empty;
        }

        public string GetSetName(string octgnGuid)
        {
            return setNamesByGuid.ContainsKey(octgnGuid) ? setNamesByGuid[octgnGuid] : string.Empty;
        }
    }
}