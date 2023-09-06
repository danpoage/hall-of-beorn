using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public class Scenario
        : ILabeled
    {
        protected Scenario(bool hasNightmareMode)
        {
            this.hasNightmareMode = hasNightmareMode;

            RulesReferenceUrl =  
                "https://images-cdn.fantasyflightgames.com/filer_public/90/19/90191e4e-a341-4379-b398-5963b7a87ebf/mec01_online_only_rules_reference_for_website.pdf";
            RulesReferenceLabel = "Rules Reference 1.0";
        }

        protected Scenario()
            : this(false)
        {
        }

        private readonly bool hasNightmareMode;
        private ScenarioCard campaignCard;
        private readonly List<ScenarioQuestCard> questCards = new List<ScenarioQuestCard>();
        private readonly List<ScenarioCard> scenarioCards = new List<ScenarioCard>();

        private readonly Dictionary<string, EncounterSet> encounterSets = new Dictionary<string, EncounterSet>();
        private readonly Dictionary<string, byte> questCardIds = new Dictionary<string, byte>();
        private readonly Dictionary<string, byte> excludedEasyModeCards = new Dictionary<string, byte>();
        private readonly Dictionary<string, byte> excludedNightmareModeCards = new Dictionary<string, byte>();
        private readonly Dictionary<string, byte> excludedAllModeCards = new Dictionary<string, byte>();

        private readonly Dictionary<string, Tuple<byte, byte, byte>> cardCountMap = new Dictionary<string, Tuple<byte, byte, byte>>();

        private readonly Dictionary<string, Tuple<Link, HashSet<string>>> _playLinks = 
            new Dictionary<string, Tuple<Link, HashSet<string>>>();
        private readonly Dictionary<string, string> _relatedDecks = new Dictionary<string, string>();

        private const string DarklingDoorLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/Darkling-Door.png";
        private const string TheWhiteTowerLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/The-White-Tower.png";
        private const string TheHallOfBeornBlogLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/Hall-of-Beorn-Blog.jpg";
        private const string TheRoadLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/The-Road.jpg";
        private const string VisionOfThePalantirLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/Vision-of-the-Palantir.jpg";
        private const string WarriorsOfTheWestLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/Warriors-of-the-West.jpg";
        private const string TheBookOfElessarLogo = "https://s3.amazonaws.com/hallofbeorn-resources/Images/LotR/Partners/The-Book-of-Elessar.jpg";

        private void AddPlayLink(LinkType type, string url, string title)
        {
            AddPlayLink(type, url, title, string.Empty, null, null);
        }

        private void AddPlayLink(LinkType type, string url, string title, string thumbnailUrl)
        {
            AddPlayLink(type, url, title, thumbnailUrl, null, null);
        }

        private void AddPlayLink(LinkType type, string url, string title, string thumbnailUrl, int? height, int? width)
        {
            _playLinks.Add(
                url, new Tuple<Link, HashSet<string>>(
                    new Link(type, url, title, thumbnailUrl, height, width),
                    new HashSet<string>())
                );
        }

        protected void AddBeornsPathLink(string url)
        {
            AddPlayLink(LinkType.Hall_of_Beorn_Blog, url, Title, TheHallOfBeornBlogLogo);
        }

        protected void AddBeornsPathLink(string title, string videoId)
        {
            AddYouTubeLink(LinkType.Hall_of_Beorn_Blog, title, videoId);
        }

        protected void AddCardboardOfTheRingsLink(string url, string title, string thumbnailUrl)
        {
            AddPlayLink(LinkType.Cardboard_of_the_Rings, url, title, thumbnailUrl);
        }

        protected void AddLotRDeckTechLink(string title, string videoId)
        {
            AddYouTubeLink(LinkType.LotR_Deck_Tech, title, videoId);
        }

        protected void AddMrUnderhillLink(string title, string videoId)
        {
            AddYouTubeLink(LinkType.Mr_Underhill, title, videoId);
        }

        protected void AddPathLessTraveledLink(string url)
        {
            AddPlayLink(LinkType.Path_Less_Traveled, url, Title, DarklingDoorLogo);
        }

        protected void AddPathLessTraveledLink(string url, string title)
        {
            AddPlayLink(LinkType.Path_Less_Traveled, url, title, DarklingDoorLogo);
        }

        protected void AddProgressionSeriesLink(string episode, string videoId)
        {
            AddYouTubeLink(LinkType.The_Progression_Series, string.Format("{0}: {1}", episode, Title), videoId);
        }

        protected void AddTheGreyCompanyLink(string title, string videoId)
        {
            AddYouTubeLink(LinkType.The_Grey_Company, title, videoId);
        }

        protected void AddTheHallOfBeornBlogLink(string url, string title)
        {
            AddPlayLink(LinkType.Hall_of_Beorn_Blog, url, title, TheHallOfBeornBlogLogo);
        }

        protected void AddTheLineUnbrokenLink(string episode, string videoId)
        {
            AddYouTubeLink(LinkType.The_Line_Unbroken, string.Format("{0}: {1}", episode, Title), videoId);
        }

        protected void AddThematicNightmareLink(string url)
        {
            AddPlayLink(LinkType.Thematic_Nightmare, url, Title + " Nightmare", DarklingDoorLogo);
        }

        protected void AddThematicNightmareLink(string url, string title)
        {
            AddPlayLink(LinkType.Thematic_Nightmare, url, title, DarklingDoorLogo);
        }

        protected void AddTheRoadLink(ushort chapter, string url)
        {
            AddPlayLink(LinkType.The_Road, url, string.Format("Chapter {0}: {1}", chapter, Title), TheRoadLogo);
        }

        protected void AddTheWhiteTowerLink(string url, string title)
        {
            AddPlayLink(LinkType.The_White_Tower, url, title, TheWhiteTowerLogo);
        }

        protected void AddVisionOfThePalantirLink(string url)
        {
            AddPlayLink(LinkType.Vision_of_the_Palantir, url, Title, VisionOfThePalantirLogo);
        }

        protected void AddWanderingTookVideoLink(string title, string videoId)
        {
            AddYouTubeLink(LinkType.Wandering_Took, title, videoId);
        }

        protected void AddWarriorsOfTheWestLink(string url, string title)
        {
            AddPlayLink(LinkType.Warriors_of_the_West, url, title, WarriorsOfTheWestLogo);
        }

        protected void AddTheBookOfElessarLink(string url)
        {
            AddTheBookOfElessarLink(url, Title);
        }

        protected void AddTheBookOfElessarLink(string url, string title)
        {
            AddPlayLink(LinkType.The_Book_of_Elessar, url, title, TheBookOfElessarLogo);
        }

        protected void AddYouTubeLink(LinkType type, string title, string videoId)
        {
            var url = string.Format("https://www.youtube.com/watch?v={0}", videoId);
            var thumbnailUrl = string.Format("https://i.ytimg.com/vi/{0}/hqdefault.jpg", videoId);
            AddPlayLink(type, url, title, thumbnailUrl);
        }

        protected void AddEncounterSet(EncounterSet set)
        {
            encounterSets[set.Name] = set;
        }

        protected void AddQuestCardId(string slug)
        {
            questCardIds.Add(slug, 0);
        }

        protected void ExcludeFromEasyMode(string slug, byte numberExcluded)
        {
            excludedEasyModeCards[slug] = numberExcluded;
        }

        protected void ExcludeFromAllModes(string slug)
        {
            excludedAllModeCards[slug] = 0;
        }

        protected void ExcludeFromNightmareMode(string slug, byte numberExcluded)
        {
            excludedNightmareModeCards[slug] = numberExcluded;
        }

        protected void AddRelatedDeck(string deckId, string title, params string[] urls)
        {
            if (_relatedDecks.ContainsKey(deckId))
            {
                return;
            }

            _relatedDecks[deckId] = title;

            if (urls == null)
            {
                return;
            }

            foreach (var url in urls)
            {
                if (_playLinks.ContainsKey(url))
                {
                    _playLinks[url].Item2.Add(deckId);
                }
            }
        }

        public int Number { get; set; }
        public string GroupName { get; set; }
        public bool IsSubGroup { get; set; }
        public string Slug { 
            get { return Title.ToSlug(); }
        }
        public string Title { get; set; }
        public string ProductName { get; set; }
        public string RulesUrl { get; set; }
        public int RulesImageCount { get; set; }
        public string AlternateTitle { get; set; }

        public float DifficultyRating { get; set; }
        public byte Difficulty { get { return (byte)Math.Round(DifficultyRating, 0); } }
        public int Votes { get; set; }

        public string CardsLink { get; set; }

        public string QuestCompanionSlug { get; set; }
        public string QuestCompanionUrl
        {
            get
            {
                return !string.IsNullOrWhiteSpace(QuestCompanionSlug) ?
                    string.Format("http://www.lotr-lcg-quest-companion.gamersdungeon.net/#{0}", QuestCompanionSlug)
                    : string.Empty;
            }
        }

        public string RulesReferenceUrl { get; protected set; }
        public string RulesReferenceLabel { get; protected set; }

        public IEnumerable<Tuple<Link, HashSet<string>>> PlayLinks { get { return _playLinks.Values; } }
        public IEnumerable<string> RelatedDecks { get { return _relatedDecks.Keys; } }

        public bool HasFirstAgeApprovedList { get; set; }

        public ScenarioCard CampaignCard
        {
            get { return campaignCard; }
        }

        public IEnumerable<ScenarioQuestCard> QuestCards
        {
            get { return questCards.OrderBy(qc => qc.StageNumber).ThenBy(qc => qc.StageLetter).ToList(); }
        }

        public IEnumerable<ScenarioCard> ScenarioCards
        {
            get { return scenarioCards.OrderBy(sc => sc.EncounterSet).ThenBy(sc => sc.Title).ToList(); }
        }

        public void SetCampaignCard(LotRCard card)
        {
            campaignCard = new ScenarioCard(card);
        }

        public void AddQuestCard(LotRCard card)
        {
            questCards.Add(new ScenarioQuestCard(card, 1, 1, 1));
        }

        public void AddQuestCard(LotRCard card, byte easyQuantity, byte normalQuantity, byte nigtmareQuantity)
        {
            var sqc = new ScenarioQuestCard(card, easyQuantity, normalQuantity, nigtmareQuantity);
            questCards.Add(sqc);
        }

        public void AddScenarioCard(LotRCard card)
        {
            scenarioCards.Add(new ScenarioCard(card));
        }

        public bool IncludesEncounterSet(string encounterSet)
        {
            foreach (var questCard in questCards)
            {
                if (questCard.IncludedEncounterSets.Any(x => x.Name == encounterSet))
                    return true;
            }

            return false;
        }

        public string NightmareEncounterSet()
        {
            return hasNightmareMode ? string.Format("{0} Nightmare", Title) : string.Empty;
        }

        public IEnumerable<EncounterSet> EncounterSets()
        {
            return encounterSets.Values;
        }

        public IEnumerable<string> QuestCardIds()
        {
            return questCardIds.Keys;
        }

        public byte NormalModeCount(string slug, byte releaseQuantity)
        {
            if (excludedAllModeCards.ContainsKey(slug))
            {
                return 0;
            }

            return releaseQuantity;
        }

        public byte EasyModeCount(string slug, byte releaseQuantity)
        {
            if (excludedAllModeCards.ContainsKey(slug))
            {
                return 0;
            }

            if (excludedEasyModeCards.ContainsKey(slug))
            {
                return (byte)(releaseQuantity - excludedEasyModeCards[slug]);
            }

            return releaseQuantity;
        }

        public byte NightmareModeCount(string slug, byte releaseQuantity)
        {
            if (excludedAllModeCards.ContainsKey(slug))
            {
                return 0;
            }

            if (excludedNightmareModeCards.ContainsKey(slug))
            {
                return (byte)(releaseQuantity - excludedNightmareModeCards[slug]);
            }

            return releaseQuantity;
        }

        public void MapCardCount(string slug, byte easyCount, byte normalCount, byte nightmareCount)
        {
            if (cardCountMap.ContainsKey(slug))
            {
                return;
            }

            cardCountMap[slug] = new Tuple<byte, byte, byte>(easyCount, normalCount, nightmareCount);
        }

        public List<Tuple<LotRCard, byte, byte, byte>> CardsWithCounts(Func<string, LotRCard> cardLookup)
        {
            var cards = cardCountMap.Select(x => {
                return new Tuple<LotRCard, byte, byte, byte>(cardLookup(x.Key), x.Value.Item1, x.Value.Item2, x.Value.Item3);
            }).ToList();

            return cards;
        }

        public IEnumerable<string> Labels()
        {
            return encounterSets.Values
                .SelectMany(es => es.Labels()).Distinct();
        }

        public IEnumerable<string> StandardModeLabels()
        {
            return encounterSets.Values
                .Where(es => !es.IsNightmare).SelectMany(es => es.Labels()).Distinct();
        }

        public IEnumerable<string> NightmareModeLabels()
        {
            foreach (var encounterSet in encounterSets.Values)
            {
                foreach (var card in encounterSet.Cards())
                {
                    var nightmareQuantity = NightmareModeCount(card.Slug, card.Quantity);
                    if (nightmareQuantity > 0)
                    {
                        yield return card.NormalizedTitle;

                        if (card.Title != card.NormalizedTitle)
                        {
                            yield return card.Title;
                        }
                    }
                }
            }
        }

        #region Static Members
        public static Scenario PassageThroughMirkwood = new Scenarios.Core.PassageThroughMirkwoodScenario();
        public static Scenario JourneyAlongTheAnduin = new Scenarios.Core.JourneyAlongTheAnduinScenario();
        public static Scenario EscapeFromDolGuldur = new Scenarios.Core.EscapeFromDolGuldurScenario();
        public static Scenario TheHuntForGollum = new Scenarios.ShadowsOfMirkwood.TheHuntForGollumScenario();
        public static Scenario ConflictAtTheCarrock = new Scenarios.ShadowsOfMirkwood.ConflictAtTheCarrockScenario();
        public static Scenario AJourneyToRhosgobel = new Scenarios.ShadowsOfMirkwood.AJourneyToRhosgobelScenario();
        public static Scenario TheHillsOfEmynMuil = new Scenarios.ShadowsOfMirkwood.TheHillsOfEmynMuilScenario();
        public static Scenario TheDeadMarshes = new Scenarios.ShadowsOfMirkwood.TheDeadMarshesScenario();
        public static Scenario ReturnToMirkwood = new Scenarios.ShadowsOfMirkwood.ReturnToMirkwoodScenario();

        public static Scenario PassageThroughMirkwoodRevised = new Scenarios.Core.PassageThroughMirkwoodCampaignScenario();
        public static Scenario JourneyAlongTheAnduinRevised = new Scenarios.Core.JourneyAlongTheAnduinCampaignScenario();
        public static Scenario EscapeFromDolGuldurRevised = new Scenarios.Core.EscapeFromDolGuldurCampaignScenario();

        public static Scenario TheOath = new Scenarios.Starter.TheOathScenario();
        public static Scenario TheCavesOfNibinDum = new Scenarios.Starter.TheCavesOfNibinDumScenario();

        public static Scenario IntoThePit = new Scenarios.KhazadDum.IntoThePitScenario();
        public static Scenario TheSeventhLevel = new Scenarios.KhazadDum.TheSeventhLevelScenario();
        public static Scenario FlightFromMoria = new Scenarios.KhazadDum.FlightFromMoriaScenario();
        public static Scenario TheRedhornGate = new Scenarios.Dwarrowdelf.TheRedhornGateScenario();
        public static Scenario RoadToRivendell = new Scenarios.Dwarrowdelf.RoadToRivendellScenario();
        public static Scenario TheWatcherInTheWater = new Scenarios.Dwarrowdelf.TheWatcherInTheWaterScenario();
        public static Scenario TheLongDark = new Scenarios.Dwarrowdelf.TheLongDarkScenario();
        public static Scenario FoundationsOfStone = new Scenarios.Dwarrowdelf.FoundationsOfStoneScenario();
        public static Scenario ShadowAndFlame = new Scenarios.Dwarrowdelf.ShadowAndFlameScenario();

        public static Scenario PerilInPelargir = new Scenarios.HeirsOfNumenor.PerilInPelargirScenario();
        public static Scenario IntoIthilien = new Scenarios.HeirsOfNumenor.IntoIthilienScenario();
        public static Scenario TheSiegeOfCairAndros = new Scenarios.HeirsOfNumenor.TheSiegeOfCairAndrosScenario();
        public static Scenario TheStewardsFear = new Scenarios.AgainstTheShadow.TheStewardsFearScenario();
        public static Scenario TheDruadanForest = new Scenarios.AgainstTheShadow.TheDruadanForestScenario();
        public static Scenario EncounterAtAmonDin = new Scenarios.AgainstTheShadow.EncounterAtAmonDinScenario();
        public static Scenario AssaultOnOsgiliath = new Scenarios.AgainstTheShadow.AssaultOnOsgiliathScenario();
        public static Scenario TheBloodOfGondor = new Scenarios.AgainstTheShadow.TheBloodOfGondorScenario();
        public static Scenario TheMorgulVale = new Scenarios.AgainstTheShadow.TheMorgulValeScenario();

        public static Scenario TheFordsOfIsen = new Scenarios.TheVoiceOfIsengard.TheFordsOfIsenScenario();
        public static Scenario ToCatchAnOrc = new Scenarios.TheVoiceOfIsengard.ToCatchAnOrcScenario();
        public static Scenario IntoFangorn = new Scenarios.TheVoiceOfIsengard.IntoFangornScenario();
        public static Scenario TheDunlandTrap = new Scenarios.TheRingMaker.TheDunlandTrapScenario();
        public static Scenario TheThreeTrials = new Scenarios.TheRingMaker.TheThreeTrialsScenario();
        public static Scenario TroubleInTharbad = new Scenarios.TheRingMaker.TroubleInTharbadScenario();
        public static Scenario TheNinInEilph = new Scenarios.TheRingMaker.TheNinInEilphScenario();
        public static Scenario CelebrimborsSecret = new Scenarios.TheRingMaker.CelebrimborsSecretScenario();
        public static Scenario TheAntleredCrown = new Scenarios.TheRingMaker.TheAntleredCrownScenario();

        public static Scenario IntrudersInChetwood = new Scenarios.TheLostRealm.IntrudersInChetwoodScenario();
        public static Scenario TheWeatherHills = new Scenarios.TheLostRealm.TheWeatherHillsScenario();
        public static Scenario DeadmensDike = new Scenarios.TheLostRealm.DeadmensDikeScenario();
        public static Scenario TheWastesOfEriador = new Scenarios.AngmarAwakened.TheWastesOfEriadorScenario();
        public static Scenario EscapeFromMountGram = new Scenarios.AngmarAwakened.EscapeFromMountGramScenario();
        public static Scenario AcrossTheEttenmoors = new Scenarios.AngmarAwakened.AcrossTheEttenmoorsScenario();
        public static Scenario TheTreacheryOfRhudaur = new Scenarios.AngmarAwakened.TheTreacheryOfRhudaurScenario();
        public static Scenario TheBattleOfCarnDum = new Scenarios.AngmarAwakened.TheBattleOfCarnDumScenario();
        public static Scenario TheDreadRealm = new Scenarios.AngmarAwakened.TheDreadRealmScenario();

        public static Scenario VoyageAcrossBelegaer = new Scenarios.TheGreyHavens.VoyageAcrossBelegaerScenario();
        public static Scenario TheFateOfNumenor = new Scenarios.TheGreyHavens.TheFateOfNumenorScenario();
        public static Scenario RaidOnTheGreyHavens = new Scenarios.TheGreyHavens.RaidOnTheGreyHavensScenario();
        public static Scenario FlightOfTheStormcaller = new Scenarios.DreamChaser.FlightOfTheStormcallerScenario();
        public static Scenario TheThingInTheDepths = new Scenarios.DreamChaser.TheThingInTheDepthsScenario();
        public static Scenario TempleOfTheDeceived = new Scenarios.DreamChaser.TempleOfTheDeceivedScenario();
        public static Scenario TheDrownedRuins = new Scenarios.DreamChaser.TheDrownedRuinsScenario();
        public static Scenario AStormOnCobasHaven = new Scenarios.DreamChaser.AStormOnCobasHavenScenario();
        public static Scenario TheCityOfCorsairs = new Scenarios.DreamChaser.TheCityOfCorsairsScenario();

        public static Scenario EscapeFromUmbar = new Scenarios.TheSandsOfHarad.EscapeFromUmbarScenario();
        public static Scenario DesertCrossing = new Scenarios.TheSandsOfHarad.DesertCrossingScenario();
        public static Scenario TheLongArmOfMordor = new Scenarios.TheSandsOfHarad.TheLongArmOfMordorScenario();
        public static Scenario TheMumakil = new Scenarios.Haradrim.TheMumakilScenario();
        public static Scenario RaceAcrossHarad = new Scenarios.Haradrim.RaceAcrossHaradScenario();
        public static Scenario BeneathTheSands = new Scenarios.Haradrim.BeneathTheSandsScenario();
        public static Scenario TheBlackSerpent = new Scenarios.Haradrim.TheBlackSerpentScenario();
        public static Scenario TheDungeonsOfCirithGurat = new Scenarios.Haradrim.TheDungeonsOfCirithGuratScenario();
        public static Scenario TheCrossingsOfPoros = new Scenarios.Haradrim.TheCrossingsOfPorosScenario();

        public static Scenario JourneyUpTheAnduin = new Scenarios.TheWildsOfRhovanion.JourneyUpTheAnduinScenario();
        public static Scenario LostInMirkwood = new Scenarios.TheWildsOfRhovanion.LostInMirkwoodScenario();
        public static Scenario TheKingsQuest = new Scenarios.TheWildsOfRhovanion.TheKingsQuestScenario();
        public static Scenario TheWitheredHeath = new Scenarios.EredMithrin.TheWitheredHeathScenario();
        public static Scenario RoamAcrossRhovanion = new Scenarios.EredMithrin.RoamAcrossRhovanionScenario();
        public static Scenario FireInTheNight = new Scenarios.EredMithrin.FireInTheNightScenario();
        public static Scenario TheGhostOfFramsburg = new Scenarios.EredMithrin.TheGhostOfFramsburgScenario();
        public static Scenario MountGundabad = new Scenarios.EredMithrin.MountGundabadScenario();
        public static Scenario TheFateOfWilderland = new Scenarios.EredMithrin.TheFateOfWilderlandScenario();

        public static Scenario TheRiverRunning = new Scenarios.AShadowInTheEast.TheRiverRunningScenario();
        public static Scenario DangerInDorwinion = new Scenarios.AShadowInTheEast.DangerInDorwinionScenario();
        public static Scenario TempleOfDoom = new Scenarios.AShadowInTheEast.TheTempleOfDoomScenario();
        public static Scenario WrathAndRuin = new Scenarios.VengeanceOfMordor.WrathAndRuinScenario();
        public static Scenario TheCityOfUlfast = new Scenarios.VengeanceOfMordor.TheCityOfUlfastScenario();
        public static Scenario ChallengeOfTheWainriders = new Scenarios.VengeanceOfMordor.ChallengeOfTheWainridersScenario();
        public static Scenario UnderTheAshMountains = new Scenarios.VengeanceOfMordor.UnderTheAshMountainsScenario();
        public static Scenario TheLandOfSorrow = new Scenarios.VengeanceOfMordor.TheLandOfSorrowScenario();
        public static Scenario TheFortressOfNurn = new Scenarios.VengeanceOfMordor.TheFortressOfNurnScenario();

        public static Scenario WeMustAwayEreBreakOfDay = new Scenarios.TheHobbit.WeMustAwayEreBreakOfDayScenario();
        public static Scenario OverTheMistyMountainsGrim = new Scenarios.TheHobbit.OverTheMistyMountainsGrimScenario();
        public static Scenario DungeonsDeepAndCavernsDim = new Scenarios.TheHobbit.DungeonsDeepAndCavernsDimScenario();
        public static Scenario FliesAndSpiders = new Scenarios.TheHobbit.FliesAndSpidersScenario();
        public static Scenario TheLonelyMountain = new Scenarios.TheHobbit.TheLonelyMountainScenario();
        public static Scenario TheBattleOfFiveArmies = new Scenarios.TheHobbit.TheBattleOfFiveArmiesScenario();

        public static Scenario AShadowOfThePast = new Scenarios.TheLordOfTheRings.AShadowOfThePastScenario();
        public static Scenario AKnifeInTheDark = new Scenarios.TheLordOfTheRings.AKnifeInTheDarkScenario();
        public static Scenario FlightToTheFord = new Scenarios.TheLordOfTheRings.FlightToTheFordScenario();
        public static Scenario TheRingGoesSouth = new Scenarios.TheLordOfTheRings.TheRingGoesSouthScenario();
        public static Scenario JourneyInTheDark = new Scenarios.TheLordOfTheRings.JourneyInTheDarkScenario();
        public static Scenario BreakingOfTheFellowship = new Scenarios.TheLordOfTheRings.BreakingOfTheFellowshipScenario();
        public static Scenario TheUrukHai = new Scenarios.TheLordOfTheRings.TheUrukHaiScenario();
        public static Scenario HelmsDeep = new Scenarios.TheLordOfTheRings.HelmsDeepScenario();
        public static Scenario TheRoadToIsengard = new Scenarios.TheLordOfTheRings.TheRoadToIsengardScenario();
        public static Scenario ThePassageOfTheMarshes = new Scenarios.TheLordOfTheRings.ThePassageOfTheMarshesScenario();
        public static Scenario JourneyToTheCrossRoads = new Scenarios.TheLordOfTheRings.JourneyToTheCrossRoads();
        public static Scenario ShelobsLair = new Scenarios.TheLordOfTheRings.ShelobsLairScenario();
        public static Scenario ThePassingOfTheGreyCompany = new Scenarios.TheLordOfTheRings.ThePassingOfTheGreyCompanyScenario();
        public static Scenario TheSiegeOfGondor = new Scenarios.TheLordOfTheRings.TheSiegeOfGondorScenario();
        public static Scenario TheBattleOfThePelennorFields = new Scenarios.TheLordOfTheRings.TheBattleOfThePelennorFieldsScenario();
        public static Scenario TheTowerOfCirithUngol = new Scenarios.TheLordOfTheRings.TheTowerOfCirithUngolScenario();
        public static Scenario TheBlackGateOpens = new Scenarios.TheLordOfTheRings.TheBlackGateOpensScenario();
        public static Scenario MountDoom = new Scenarios.TheLordOfTheRings.MountDoomScenario();

        public static Scenario TheMassingAtOsgiliath = new Scenarios.PrintOnDemand.TheMassingAtOsgiliathScenario();
        public static Scenario TheBattleOfLakeTown = new Scenarios.PrintOnDemand.TheBattleOfLakeTownScenario();
        public static Scenario TheStoneOfErech = new Scenarios.PrintOnDemand.TheStoneOfErechScenario();
        public static Scenario TheOldForest = new Scenarios.PrintOnDemand.TheOldForestScenario();
        public static Scenario TheRuinsOfBelegost = new Scenarios.PrintOnDemand.TheRuinsOfBelegostScenario();
        public static Scenario FogOnTheBarrowDowns = new Scenarios.PrintOnDemand.FogOnTheBarrowDownsScenario();
        public static Scenario MurderAtThePrancingPony = new Scenarios.PrintOnDemand.MurderAtThePrancingPonyScenario();
        public static Scenario TheSiegeOfAnnuminas = new Scenarios.PrintOnDemand.TheSiegeOfAnnuminasScenario();
        public static Scenario AttackOnDolGuldur = new Scenarios.PrintOnDemand.AttackOnDolGuldurScenario();

        public static Scenario TheHuntForTheDreadnaught = new Scenarios.ScenarioPack.TheHuntForTheDreadnaughtScenario();
        public static Scenario TheOathCampaign = new Scenarios.ScenarioPack.TheOathCampaignScenario();
        public static Scenario TheCavesOfNibinDumCampaign = new Scenarios.ScenarioPack.TheCavesOfNibinDumCampaignScenario();

        public static Scenario HuntingOfTheWolf = new Scenarios.FirstAge.HuntingOfTheWolfScenario();
        public static Scenario TheIsleOfWerewolves = new Scenarios.FirstAge.TheIsleOfWerewolvesScenario();
        public static Scenario TheSeatOfMorgoth = new Scenarios.FirstAge.TheSeatOfMorgothScenario();
        public static Scenario TrialUponTheMarches = new Scenarios.DoomMastered.TrialUponTheMarchesScenario();
        public static Scenario AmongTheOutlaws = new Scenarios.DoomMastered.AmongTheOutlawsScenario();
        public static Scenario TheBetrayalOfMim = new Scenarios.DoomMastered.TheBetrayalOfMimScenario();
        public static Scenario TheFallOfNargothrond = new Scenarios.DoomMastered.TheFallOfNargothrondScenario();

        public static Scenario AmbushAtErelas = new Scenarios.ChildrenOfEorl.AmbushAtErelasScenario();
        public static Scenario TheBattleForTheBeacon = new Scenarios.ChildrenOfEorl.TheBattleForTheBeaconScenario();
        public static Scenario TheHorseLordsIre = new Scenarios.ChildrenOfEorl.TheHorseLordsIreScenario();
        public static Scenario TheAldburgPlot = new Scenarios.OathsOfTheRohirrim.TheAldburgPlotScenario();
        public static Scenario FireOnTheEastemnet = new Scenarios.OathsOfTheRohirrim.FireOnTheEastemnetScenario();
        public static Scenario TheGapOfRohan = new Scenarios.OathsOfTheRohirrim.TheGapOfRohanScenario();
        public static Scenario TheGlitteringCaves = new Scenarios.OathsOfTheRohirrim.TheGlitteringCavesScenario();
        public static Scenario MusteringOfTheRohirrim = new Scenarios.OathsOfTheRohirrim.MusteringOfTheRohirrimScenario();
        public static Scenario BloodInTheIsen = new Scenarios.OathsOfTheRohirrim.BloodInTheIsenScenario();
        public static Scenario TheScouringOfTheShire = new Scenarios.TheScouringOfTheShire.TheScouringOfTheShireScenario();
        public static Scenario TheNineAreAbroad = new Scenarios.TheNineAreAbroad.TheNineAreAbroadScenario();
        public static Scenario TheSiegeOfErebor = new Scenarios.TheSiegeOfErebor.TheSiegeOfEreborScenario();
        #endregion

    }
}