using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models.LotR.Products;

namespace HallOfBeorn.Models.LotR
{
    public class Product
    {
        protected Product(string name, string code, ImageType imageType)
            : this(name, code, imageType, DateTime.Now)
        {
        }

        protected Product(string name, string code, ImageType imageType, DateTime firstReleased)
        {
            this.Name = name;
            this.Code = code;
            this.ImageType = imageType;
            this.FirstReleased = firstReleased;
        }

        private readonly List<CardSet> cardSets = new List<CardSet>();
        private readonly List<Scenario> scenarios = new List<Scenario>();

        protected void AddCardSet(CardSet cardSet)
        {
            cardSet.Product = this;
            cardSets.Add(cardSet);
        }

        protected void AddScenario(Scenario scenario)
        {
            if (!string.IsNullOrEmpty(RulesUrl))
            {
                scenario.RulesUrl = RulesUrl;
            }

            scenarios.Add(scenario);
        }

        public string Name { get; private set; }
        public string Code { get; private set; }
        public ImageType ImageType { get; private set; }
        public bool IsPremier { get; protected set; }
        public bool IsNewSubGroup { get; protected set; }
        public string RulesUrl { get; protected set; }
        public string BuyLink { get; protected set; }
        public DateTime FirstReleased { get; protected set; }

        public IEnumerable<CardSet> CardSets()
        {
            return cardSets;
        }

        public IEnumerable<Scenario> Scenarios()
        {
            return scenarios;
        }

        #region Static Members
        //The Core Set and Shadows of Mirkwood Cycle
        public static Product CoreSet = new CoreSetProduct();
        
        public static Product TheHuntForGollum = new TheHuntForGollumProduct();
        public static Product ConflictAtTheCarrock = new ConflictAtTheCarrockProduct();
        public static Product AJourneyToRhosgobel = new AJourneyToRhosgobelProduct();
        public static Product TheHillsOfEmynMuil = new TheHillsOfEmynMuilProduct();
        public static Product TheDeadMarshes = new TheDeadMarshesProduct();
        public static Product ReturnToMirkwood = new ReturnToMirkwoodProduct();
        
        //Khzad-dum and Dwarrowdelf Cycle
        public static Product KhazadDum = new KhazadDumProduct();

        public static Product TheRedhornGate = new TheRedhornGateProduct();
        public static Product RoadToRivendell = new RoadToRivendellProduct();
        public static Product TheWatcherInTheWater = new TheWatcherInTheWaterProduct();
        public static Product TheLongDark = new TheLongDarkProduct();
        public static Product FoundationsOfStone = new FoundationsOfStoneProduct();
        public static Product ShadowAndFlame = new ShadowAndFlameProduct();

        //Heirs of Numenor and Against the Shadow Cycle
        public static Product HeirsOfNumenor = new HeirsOfNumenorProduct();

        public static Product TheStewardsFear = new TheStewardsFearProduct();
        public static Product TheDruadanForest = new TheDruadanForestProduct();
        public static Product EncounterAtAmonDin = new EncounterAtAmonDinProduct();
        public static Product AssaultOnOsgiliath = new AssaultOnOsgiliathProduct();
        public static Product TheBloodOfGondor = new TheBloodOfGondorProduct();
        public static Product TheMorgulVale = new TheMorgulValeProduct();

        //The Voice of Isengard and The Ring-maker Cycle
        public static Product TheVoiceOfIsengard = new TheVoiceOfIsengardProduct();

        public static Product TheDunlandTrap = new TheDunlandTrapProduct();
        public static Product TheThreeTrials = new TheThreeTrialsProduct();
        public static Product TroubleInTharbad = new TroubleInTharbadProduct();
        public static Product TheNinInEilph = new TheNinInEilphProduct();
        public static Product CelebrimborsSecret = new CelebrimborsSecretProduct();
        public static Product TheAntleredCrown = new TheAntleredCrownProduct();

        //The Lost Realm and Angmar Awakened Cycle
        public static Product TheLostRealm = new TheLostRealmProduct();
        public static Product TheWastesOfEriador = new TheWastesOfEriadorProduct();
        public static Product EscapeFromMountGram = new EscapeFromMountGramProduct();
        public static Product AcrossTheEttenmoors = new AcrossTheEttenmoorsProduct();
        public static Product TheTreacheryOfRhudaur = new TheTreacheryOfRhudaurProduct();
        public static Product TheBattleOfCarnDum = new TheBattleOfCarnDumProduct();
        public static Product TheDreadRealm = new TheDreadRealmProduct();

        //The Grey Havens and Dream-chaser Cycle
        public static Product TheGreyHavens = new TheGreyHavensProduct();
        public static Product FlightOfTheStormcaller = new FlightOfTheStormcallerProduct();
        public static Product TheThingInTheDepths = new TheThingInTheDepthsProduct();
        public static Product TempleOfTheDeceived = new TempleOfTheDeceivedProduct();
        public static Product TheDrownedRuins = new TheDrownedRuinsProduct();
        public static Product AStormOnCobasHaven = new AStormOnCobasHavenProduct();
        public static Product TheCityOfCorsairs = new TheCityOfCorsairsProduct();

        //The Sands of Harad and Haradrim Cycle
        public static Product TheSandsOfHarad = new TheSandsOfHaradProduct();
        public static Product TheMumakil = new TheMumakilProduct();
        public static Product RaceAcrossHarad = new RaceAcrossHaradProduct();
        public static Product BeneathTheSands = new BeneathTheSandsProduct();
        public static Product TheBlackSerpent = new TheBlackSerpentProduct();

        //The Hobbit Saga
        public static Product TheHobbitOverHillAndUnderHill = new TheHobbitOverHillAndUnderHillProduct();
        public static Product TheHobbitOnTheDoorstep = new TheHobbitOnTheDoorstepProduct();

        //The Lord of the Rings Saga
        public static Product TheBlackRiders = new TheBlackRidersProduct();
        public static Product TheRoadDarkens = new TheRoadDarkensProduct();
        public static Product TheTreasonOfSaruman = new TheTreasonOfSarumanProduct();
        public static Product TheLandOfShadow = new TheLandOfShadowProduct();
        public static Product TheFlameOfTheWest = new TheFlameOfTheWestProduct();

        //GenCon and Fellowship Event Decks
        public static Product TheMassingAtOsgiliath = new TheMassingAtOsgiliathProduct();
        public static Product TheBattleOfLakeTown = new TheBattleOfLakeTownProduct();
        public static Product TheStoneOfErech = new TheStoneOfErechProduct();
        public static Product TheOldForest = new TheOldForestProduct();
        public static Product FogOnTheBarrowDowns = new FogOnTheBarrowDownsProduct();
        public static Product TheRuinsOfBelegost = new TheRuinsOfBelegostProduct();
        public static Product MurderAtThePrancingPony = new MurderAtThePrancingPonyProduct();
        public static Product TheSiegeOfAnnuminas = new TheSiegeOfAnnuminasProduct();

        //Nightmare Decks
        public static Product PassageThroughMirkwoodNightmare = new PassageThroughMirkwoodNightmareProduct();
        public static Product JourneyAlongTheAnduinNightmare = new JourneyAlongTheAnduinNightmareProduct();
        public static Product EscapeFromDolGuldurNightmare = new EscapeFromDolGuldurNightmareProduct();

        public static Product TheHuntForGollumNightmare = new TheHuntForGollumNightmareProduct();
        public static Product ConflictAtTheCarrockNightmare = new ConflictAtTheCarrockNightmareProduct();
        public static Product AJourneyToRhosgobelNightmare = new AJourneyToRhosgobelNightmareProduct();
        public static Product TheHillsOfEmynMuilNightmare = new TheHillsOfEmynMuilNightmareProduct();
        public static Product TheDeadMarshesNightmare = new TheDeadMarshesNightmareProduct();
        public static Product ReturnToMirkwoodNightmare = new ReturnToMirkwoodNightmareProduct();

        public static Product KhazadDumNightmare = new KhazadDumNightmareProduct();

        public static Product TheRedhornGateNightmare = new TheRedhornGateNightmareProduct();
        public static Product RoadToRivendellNightmare = new RoadToRivendellNightmareProduct();
        public static Product TheWatcherInTheWaterNightmare = new TheWatcherInTheWaterNightmareProduct();
        public static Product TheLongDarkNightmare = new TheLongDarkNightmareProduct();
        public static Product FoundationsOfStoneNightmare = new FoundationsOfStoneNightmareProduct();
        public static Product ShadowAndFlameNightmare = new ShadowAndFlameNightmareProduct();

        public static Product HeirsOfNumenorNightmare = new HeirsOfNumenorNightmareProduct();

        public static Product TheStewardsFearNightmare = new TheStewardsFearNightmareProduct();
        public static Product TheDruadanForestNightmare = new TheDruadanForestNightmareProduct();
        public static Product EncounterAtAmonDinNightmare = new EncounterAtAmonDinNightmareProduct();
        public static Product AssaultOnOsgiliathNightmare = new AssaultOnOsgiliathNightmareProduct();
        public static Product TheBloodOfGondorNightmare = new TheBloodOfGondorNightmareProduct();
        public static Product TheMorgulValeNightmare = new TheMorgulValeNightmareProduct();

        public static Product TheVoiceOfIsengardNightmare = new TheVoiceOfIsengardNightmareProduct();
        public static Product TheDunlandTrapNightmare = new TheDunlandTrapNightmareProduct();
        public static Product TheThreeTrialsNightmare = new TheThreeTrialsNightmareProduct();
        public static Product TroubleInTharbadNightmare = new TroubleInTharbadNightmareProduct();
        public static Product TheNinInEilphNightmare = new TheNinInEilphNightmareProduct();
        public static Product CelebrimborsSecretNightmare = new CelebrimborsSecretNightmareProoduct();
        public static Product TheAntleredCrownNightmare = new TheAntleredCrownNightmareProduct();

        public static Product TheHobbitOverHillAndUnderHillNightmare = new TheHobbitOverHillAndUnderHillNightmareProduct();
        public static Product TheHobbitOnTheDoorstepNightmare = new TheHobbitOnTheDoorstepNightmareProduct();

        public static Product TheBlackRidersNightmare = new TheBlackRidersNightmareProduct();
        public static Product TheRoadDarkensNightmare = new TheRoadDarkensNightmareProduct();

        //Custom Expansions
        public static Product FirstAge = new FirstAgeProduct();
        public static Product TrialUponTheMarches = new TrialUponTheMarchesProduct();
        public static Product AmongTheOutlaws = new AmongTheOutlawsProduct();

        #endregion
    }
}