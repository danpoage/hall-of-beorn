using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public abstract class CardSet : INamed
    {
        protected CardSet()
        {
            Cards = new List<LotRCard>();

            Initialize();

            foreach (var card in Cards)
            {
                card.CardSet = this;
            }
        }

        private string normalizedName;

        protected abstract void Initialize();

        protected void addCard(LotRCard card)
        {
            this.Cards.Add(card);
        }

        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public string ShortSlug { get; protected set; }
        
        public string NormalizedName
        {
            get
            {
                return (!string.IsNullOrEmpty(normalizedName)) ?
                    normalizedName
                    : Name;
            }
            protected set
            {
                normalizedName = value;
            }
        }

        public string Abbreviation { get; protected set; }

        private string publicSlug;
        public string PublicSlug
        {
            get { return !string.IsNullOrEmpty(publicSlug) ? publicSlug : Abbreviation.ToLower(); }
            protected set { publicSlug = value; }
        }

        public string Cycle { get; protected set; }
        public int Number { get; protected set; }
        public SetType SetType { get; protected set; }
        public List<LotRCard> Cards { get; protected set; }
        public Product Product { get; set; }

        private readonly List<EncounterSet> encounterSets = new List<EncounterSet>();
        protected void addEncounterSets(params EncounterSet[] sets)
        {
            foreach (var encounterSet in sets) {

                foreach (var card in encounterSet.Cards()) {
                    if (card.CardSet == null) {
                        card.CardSet = this;
                    }
                }

                this.encounterSets.Add(encounterSet);
            }
        }
        public IEnumerable<EncounterSet> EncounterSets()
        {
            return encounterSets;
        }

        public string AlternateName { get; protected set; }

        public bool IsNightmare { get { return !string.IsNullOrEmpty(Name) && Name.EndsWith(" Nightmare"); } }

        public CardSet WithShortSlug(string shortSlug)
        {
            this.ShortSlug = shortSlug;
            return this;
        }

        private static List<CardSet> all = new List<CardSet>();

        private static void Add(CardSet cardSet)
        {
            //AddCardShortSlugs(cardSet);

            all.Add(cardSet);
        }

        static CardSet()
        {
            Add(CoreSet);
            Add(TheHuntForGollum);
            Add(ConflictAtTheCarrock);
            Add(AJourneyToRhosgobel);
            Add(TheHillsOfEmynMuil);
            Add(TheDeadMarshes);
            Add(ReturnToMirkwood);
        
            Add(KhazadDum);
            Add(TheRedhornGate);
            Add(RoadToRivendell);
            Add(TheWatcherInTheWater);
            Add(TheLongDark);
            Add(FoundationsOfStone);
            Add(ShadowAndFlame);

            Add(HeirsOfNumenor);
            Add(TheStewardsFear);
            Add(TheDruadanForest);
            Add(EncounterAtAmonDin);
            Add(AssaultOnOsgiliath);
            Add(TheBloodOfGondor);
            Add(TheMorgulVale);

            Add(TheVoiceOfIsengard);
            Add(TheDunlandTrap);
            Add(TheThreeTrials);
            Add(TroubleInTharbad);
            Add(TheNinInEilph);
            Add(CelebrimborsSecret);
            Add(TheAntleredCrown);

            Add(TheLostRealm);
            Add(TheWastesOfEriador);
            Add(EscapeFromMountGram);
            Add(AcrossTheEttenmoors);
            Add(TheTreacheryOfRhudaur);
            Add(TheBattleOfCarnDum);
            Add(TheDreadRealm);

            Add(TheGreyHavens);
            Add(FlightOfTheStormcaller);
            Add(TheThingInTheDepths);
            Add(TempleOfTheDeceived);
            Add(TheDrownedRuins);
            Add(AStormOnCobasHaven);
            Add(TheCityOfCorsairs);

            Add(TheSandsOfHarad);
            Add(TheMumakil);
            Add(RaceAcrossHarad);
            Add(BeneathTheSands);
            Add(TheBlackSerpent);
            Add(TheDungeonsOfCirithGurat);
            Add(TheCrossingsOfPoros);

            Add(TheHobbitOverHillAndUnderHill);
            Add(TheHobbitOnTheDoorstep);

            Add(TheBlackRiders);
            Add(TheRoadDarkens);
            Add(TheTreasonOfSaruman);
            Add(TheLandOfShadow);
            Add(TheFlameOfTheWest);
            Add(TheMountainOfFire);

            Add(TheMassingAtOsgiliath);
            Add(TheBattleOfLakeTown);
            Add(TheStoneOfErech);
            Add(TheRuinsOfBelegost);

            Add(TheOldForest);
            Add(FogOnTheBarrowDowns);
            Add(MurderAtThePrancingPony);
            Add(TheSiegeOfAnnuminas);

            Add(PassageThroughMirkwoodNightmare);
            Add(JourneyAlongTheAnduinNightmare);
            Add(EscapeFromDolGuldurNightmare);
            Add(TheHuntForGollumNightmare);
            Add(ConflictAtTheCarrockNightmare);
            Add(AJourneyToRhosgobelNightmare);
            Add(TheHillsOfEmynMuilNightmare);
            Add(TheDeadMarshesNightmare);
            Add(ReturnToMirkwoodNightmare);
            Add(IntoThePitNightmare);
            Add(TheSeventhLevelNightmare);
            Add(FlightFromMoriaNightmare);
            Add(TheRedhornGateNightmare);
            Add(RoadToRivendellNightmare);
            Add(TheWatcherInTheWaterNightmare);
            Add(TheLongDarkNightmare);
            Add(FoundationsOfStoneNightmare);
            Add(ShadowAndFlameNightmare);
            Add(PerilInPelargirNightmare);
            Add(IntoIthilienNightmare);
            Add(TheSiegeOfCairAndrosNightmare);
            Add(TheStewardsFearNightmare);
            Add(TheDruadanForestNightmare);
            Add(EncounterAtAmonDinNightmare);
            Add(AssaultOnOsgiliathNightmare);
            Add(TheBloodOfGondorNightmare);
            Add(TheMorgulValeNightmare);
            Add(TheFordsOfIsenNightmare);
            Add(ToCatchAnOrcNightmare);
            Add(IntoFangornNightmare);
            Add(TheDunlandTrapNightmare);
            Add(TheThreeTrialsNightmare);
            Add(TroubleInTharbadNightmare);
            Add(TheNinInEilphNightmare);
            Add(CelebrimborsSecretNightmare);
            Add(TheAntleredCrownNightmare);

            Add(IntrudersInChetwoodNightmare);
            Add(TheWeatherHillsNightmare);
            Add(DeadmensDikeNightmare);

            Add(TheWastesOfEriadorNightmare);
            Add(EscapeFromMountGramNightmare);
            Add(AcrossTheEttenmoorsNightmare);
            Add(TheTreacheryOfRhudaurNightmare);
            Add(TheBattleOfCarnDumNightmare);
            Add(TheDreadRealmNightmare);

            Add(WeMustAwayEreBreakOfDayNightmare);
            Add(OverTheMistyMountainsGrimNightmare);
            Add(DungeonsDeepAndCavernsDimNightmare);
            
            Add(FliesAndSpidersNightmare);
            Add(TheLonelyMountainNightmare);
            Add(TheBattleOfFiveArmiesNightmare);

            Add(AShadowOfThePastNightmare);
            Add(AKnifeInTheDarkNightmare);
            Add(FlightToTheFordNightmare);

            Add(TheRingGoesSouthNightmare);
            Add(JourneyInTheDarkNightmare);
            Add(BreakingOfTheFellowshipNightmare);

            Add(FirstAge);
            Add(TrialUponTheMarches);
            Add(AmongTheOutlaws);
        }

        public static List<CardSet> All()
        {
            return all;
        }

        #region Static Members
        public static CardSet CoreSet = new Sets.Core.CoreSet().WithShortSlug("a");
        public static CardSet TheHuntForGollum = new Sets.TheHuntforGollum().WithShortSlug("b");
        public static CardSet ConflictAtTheCarrock = new Sets.ConflictattheCarrock().WithShortSlug("c");
        public static CardSet AJourneyToRhosgobel = new Sets.AJourneytoRhosgobel().WithShortSlug("d");
        public static CardSet TheHillsOfEmynMuil = new Sets.TheHillsofEmynMuil().WithShortSlug("e");
        public static CardSet TheDeadMarshes = new Sets.TheDeadMarshes().WithShortSlug("f");
        public static CardSet ReturnToMirkwood = new Sets.ReturntoMirkwood().WithShortSlug("g");
        
        public static CardSet KhazadDum = new Sets.Khazaddum().WithShortSlug("h");
        public static CardSet TheRedhornGate = new Sets.TheRedhornGate().WithShortSlug("i");
        public static CardSet RoadToRivendell = new Sets.RoadtoRivendell().WithShortSlug("j");
        public static CardSet TheWatcherInTheWater = new Sets.TheWatcherintheWater().WithShortSlug("k");
        public static CardSet TheLongDark = new Sets.TheLongDark().WithShortSlug("l");
        public static CardSet FoundationsOfStone = new Sets.FoundationsofStone().WithShortSlug("m");
        public static CardSet ShadowAndFlame = new Sets.ShadowandFlame().WithShortSlug("n");

        public static CardSet HeirsOfNumenor = new Sets.HeirsofNumenor().WithShortSlug("o");
        public static CardSet TheStewardsFear = new Sets.TheStewardsFear().WithShortSlug("p");
        public static CardSet TheDruadanForest = new Sets.TheDruadanForest().WithShortSlug("q");
        public static CardSet EncounterAtAmonDin = new Sets.EncounteratAmonDin().WithShortSlug("r");
        public static CardSet AssaultOnOsgiliath = new Sets.AssaultonOsgiliath().WithShortSlug("s");
        public static CardSet TheBloodOfGondor = new Sets.TheBloodofGondor().WithShortSlug("t");
        public static CardSet TheMorgulVale = new Sets.TheMorgulVale().WithShortSlug("u");

        public static CardSet TheVoiceOfIsengard = new Sets.TheVoiceofIsengard().WithShortSlug("v");
        public static CardSet TheDunlandTrap = new Sets.TheDunlandTrap().WithShortSlug("w");
        public static CardSet TheThreeTrials = new Sets.TheThreeTrials().WithShortSlug("x");
        public static CardSet TroubleInTharbad = new Sets.TroubleInTharbad().WithShortSlug("y"); 
        public static CardSet TheNinInEilph = new Sets.TheNinInEilph().WithShortSlug("z");
        public static CardSet CelebrimborsSecret = new Sets.CelebrimborsSecret().WithShortSlug("A");
        public static CardSet TheAntleredCrown = new Sets.TheAntleredCrown().WithShortSlug("B");

        public static CardSet TheLostRealm = new Sets.TheLostRealm().WithShortSlug("C");
        public static CardSet TheWastesOfEriador = new Sets.TheWastesOfEriador().WithShortSlug("D");
        public static CardSet EscapeFromMountGram = new Sets.EscapeFromMountGram().WithShortSlug("E");
        public static CardSet AcrossTheEttenmoors = new Sets.AcrossTheEttenmoors().WithShortSlug("F");
        public static CardSet TheTreacheryOfRhudaur = new Sets.TheTreacheryOfRhudaur().WithShortSlug("G");
        public static CardSet TheBattleOfCarnDum = new Sets.TheBattleOfCarnDum().WithShortSlug("H");
        public static CardSet TheDreadRealm = new Sets.TheDreadRealm().WithShortSlug("I");

        public static CardSet TheGreyHavens = new Sets.TheGreyHavens().WithShortSlug("J");
        public static CardSet FlightOfTheStormcaller = new Sets.FlightOfTheStormcaller().WithShortSlug("K");
        public static CardSet TheThingInTheDepths = new Sets.TheThingInTheDepths().WithShortSlug("L");
        public static CardSet TempleOfTheDeceived = new Sets.TempleOfTheDeceived().WithShortSlug("M");
        public static CardSet TheDrownedRuins = new Sets.TheDrownedRuins().WithShortSlug("N");
        public static CardSet AStormOnCobasHaven = new Sets.AStormOnCobasHaven();
        public static CardSet TheCityOfCorsairs = new Sets.TheCityOfCorsairs();

        public static CardSet TheSandsOfHarad = new Sets.TheSandsOfHarad();
        public static CardSet TheMumakil = new Sets.TheMumakil();
        public static CardSet RaceAcrossHarad = new Sets.RaceAcrossHarad();
        public static CardSet BeneathTheSands = new Sets.BeneathTheSands();
        public static CardSet TheBlackSerpent = new Sets.TheBlackSerpent();
        public static CardSet TheDungeonsOfCirithGurat = new Sets.TheDungeonsOfCirithGurat();
        public static CardSet TheCrossingsOfPoros = new Sets.TheCrossingsOfPoros();

        public static CardSet TheHobbitOverHillAndUnderHill = new Sets.TheHobbitOverHillandUnderHill().WithShortSlug("Y");
        public static CardSet TheHobbitOnTheDoorstep = new Sets.TheHobbitOntheDoorstep().WithShortSlug("Z");

        public static CardSet TheBlackRiders = new Sets.TheBlackRiders().WithShortSlug("1");
        public static CardSet TheRoadDarkens = new Sets.TheRoadDarkens().WithShortSlug("2");
        public static CardSet TheTreasonOfSaruman = new Sets.TheTreasonOfSaruman().WithShortSlug("3");
        public static CardSet TheLandOfShadow = new Sets.TheLandOfShadow().WithShortSlug("4");
        public static CardSet TheFlameOfTheWest = new Sets.TheFlameOfTheWest().WithShortSlug("5");
        public static CardSet TheMountainOfFire = new Sets.TheMountainOfFire().WithShortSlug("6");

        public static CardSet TheMassingAtOsgiliath = new Sets.TheMassingatOsgiliath();
        public static CardSet TheBattleOfLakeTown = new Sets.TheBattleofLakeTown();
        public static CardSet TheStoneOfErech = new Sets.TheStoneofErech();
        public static CardSet TheRuinsOfBelegost = new Sets.TheRuinsOfBelegost().WithShortSlug("7");
        public static CardSet TheSiegeOfAnnuminas = new Sets.TheSiegeOfAnnuminas().WithShortSlug("8");

        public static CardSet PassageThroughMirkwoodNightmare = new Sets.PassageThroughMirkwoodNightmare();
        public static CardSet JourneyAlongTheAnduinNightmare = new Sets.JourneyAlongTheAnduinNightmare();
        public static CardSet EscapeFromDolGuldurNightmare = new Sets.EscapeFromDolGuldurNightmare();
        public static CardSet TheHuntForGollumNightmare = new Sets.TheHuntForGollumNightmare();
        public static CardSet ConflictAtTheCarrockNightmare = new Sets.ConflictAtTheCarrockNightmare();
        public static CardSet AJourneyToRhosgobelNightmare = new Sets.AJourneyToRhosgobelNightmare();
        public static CardSet TheHillsOfEmynMuilNightmare = new Sets.TheHillsOfEmynMuilNightmare();
        public static CardSet TheDeadMarshesNightmare = new Sets.TheDeadMarshesNightmare();
        public static CardSet ReturnToMirkwoodNightmare = new Sets.ReturnToMirkwoodNightmare();
        public static CardSet IntoThePitNightmare = new Sets.IntoThePitNightmare();
        public static CardSet TheSeventhLevelNightmare = new Sets.TheSeventhLevelNightmare();
        public static CardSet FlightFromMoriaNightmare = new Sets.FlightFromMoriaNightmare();
        public static CardSet TheRedhornGateNightmare = new Sets.TheRedhornGateNightmare();
        public static CardSet RoadToRivendellNightmare = new Sets.RoadToRivendellNightmare();
        public static CardSet TheWatcherInTheWaterNightmare = new Sets.TheWatcherInTheWaterNightmare();
        public static CardSet TheLongDarkNightmare = new Sets.TheLongDarkNightmare();
        public static CardSet FoundationsOfStoneNightmare = new Sets.FoundationsOfStoneNightmare();
        public static CardSet ShadowAndFlameNightmare = new Sets.ShadowAndFlameNightmare();
        public static CardSet PerilInPelargirNightmare = new Sets.PerilInPelargirNightmare();
        public static CardSet IntoIthilienNightmare = new Sets.IntoIthilienNightmare();
        public static CardSet TheSiegeOfCairAndrosNightmare = new Sets.TheSiegeOfCairAndrosNightmare();
        public static CardSet TheStewardsFearNightmare = new Sets.TheStewardsFearNightmare();
        public static CardSet TheDruadanForestNightmare = new Sets.TheDruadanForestNightmare();
        public static CardSet EncounterAtAmonDinNightmare = new Sets.EncounterAtAmonDinNightmare();
        public static CardSet AssaultOnOsgiliathNightmare = new Sets.AssaultOnOsgiliathNightmare();
        public static CardSet TheBloodOfGondorNightmare = new Sets.TheBloodOfGondorNightmare();
        public static CardSet TheMorgulValeNightmare = new Sets.TheMorgulValeNightmare();
        public static CardSet TheFordsOfIsenNightmare = new Sets.TheFordsOfIsenNightmare();
        public static CardSet ToCatchAnOrcNightmare = new Sets.ToCatchAnOrcNightmare();
        public static CardSet IntoFangornNightmare = new Sets.IntoFangornNightmare();
        public static CardSet TheDunlandTrapNightmare = new Sets.TheDunlandTrapNightmare();
        public static CardSet TheThreeTrialsNightmare = new Sets.TheThreeTrialsNightmare();
        public static CardSet TroubleInTharbadNightmare = new Sets.TroubleInTharbadNightmare();
        public static CardSet TheNinInEilphNightmare = new Sets.TheNinInEilphNightmare();
        public static CardSet CelebrimborsSecretNightmare = new Sets.CelebrimborsSecretNightmare();
        public static CardSet TheAntleredCrownNightmare = new Sets.TheAntleredCrownNightmare();

        public static CardSet IntrudersInChetwoodNightmare = new Sets.IntrudersInChetwoodNightmare();
        public static CardSet TheWeatherHillsNightmare = new Sets.TheWeatherHillsNightmare();
        public static CardSet DeadmensDikeNightmare = new Sets.DeadmensDikeNightmare();
        
        public static CardSet TheWastesOfEriadorNightmare = new Sets.TheWastesOfEriadorNightmare();
        public static CardSet EscapeFromMountGramNightmare = new Sets.EscapeFromMountGramNightmare();
        public static CardSet AcrossTheEttenmoorsNightmare = new Sets.AcrossTheEttenmoorsNightmare();
        public static CardSet TheTreacheryOfRhudaurNightmare = new Sets.TheTreacheryOfRhudaurNightmare();
        public static CardSet TheBattleOfCarnDumNightmare = new Sets.TheBattleOfCarnDumNightmare();
        public static CardSet TheDreadRealmNightmare = new Sets.TheDreadRealmNightmare();

        public static CardSet WeMustAwayEreBreakOfDayNightmare = new Sets.WeMustAwayEreBreakOfDayNightmare();
        public static CardSet OverTheMistyMountainsGrimNightmare = new Sets.OverTheMistyMountainsGrimNightmare();
        public static CardSet DungeonsDeepAndCavernsDimNightmare = new Sets.DungeonsDeepAndCavernsDimNightmare();
        public static CardSet FliesAndSpidersNightmare = new Sets.FliesAndSpidersNightmare();
        public static CardSet TheLonelyMountainNightmare = new Sets.TheLonelyMountainNightmare();
        public static CardSet TheBattleOfFiveArmiesNightmare = new Sets.TheBattleOfFiveArmiesNightmare();
        public static CardSet AShadowOfThePastNightmare = new Sets.AShadowOfThePastNightmare();
        public static CardSet AKnifeInTheDarkNightmare = new Sets.AKnifeInTheDarkNightmare();
        public static CardSet FlightToTheFordNightmare = new Sets.FlightToTheFordNightmare();
        public static CardSet TheRingGoesSouthNightmare = new Sets.TheRingGoesSouthNightmare();
        public static CardSet JourneyInTheDarkNightmare = new Sets.JourneyInTheDarkNightmare();
        public static CardSet BreakingOfTheFellowshipNightmare = new Sets.BreakingOfTheFellowshipNightmare();

        public static CardSet TheOldForest = new Sets.TheOldForest().WithShortSlug("8");
        public static CardSet FogOnTheBarrowDowns = new Sets.FogOnTheBarrowDowns().WithShortSlug("9");
        public static CardSet MurderAtThePrancingPony = new Sets.MurderAtThePrancingPony().WithShortSlug("0");

        public static CardSet FirstAge = new Sets.FirstAge();
        public static CardSet TrialUponTheMarches = new Sets.TrialUponTheMarches();
        public static CardSet AmongTheOutlaws = new Sets.AmongTheOutlaws();
        #endregion
    }
}