using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public abstract class CardSet
    {
        protected CardSet()
        {
            Cards = new List<Card>();

            Initialize();

            foreach (var card in Cards)
            {
                card.CardSet = this;
            }
        }

        private string normalizedName;

        protected abstract void Initialize();

        public string Id { get; protected set; }
        public string Name { get; protected set; }
        
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
        public List<Card> Cards { get; protected set; }
        public Product Product { get; set; }

        public string AlternateName { get; protected set; }

        public bool IsNightmare { get { return !string.IsNullOrEmpty(Name) && Name.EndsWith(" Nightmare"); } }

        private static List<CardSet> all = new List<CardSet>();

        private static void Add(CardSet cardSet)
        {
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
            Add(NinInEilph);
            Add(CelebrimborsSecret);
            Add(TheAntleredCrown);

            Add(TheHobbitOverHillAndUnderHill);
            Add(TheHobbitOnTheDoorstep);

            Add(TheBlackRiders);
            Add(TheRoadDarkens);
            Add(TheTreasonOfSaruman);
            Add(TheLandOfShadow);

            Add(TheMassingAtOsgiliath);
            Add(TheBattleOfLakeTown);
            Add(TheStoneOfErech);
            Add(TheRuinsOfBelegost);

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
            Add(WeMustAwayEreBreakOfDayNightmare);
            Add(OverTheMistyMountainsGrimNightmare);
            Add(DungeonsDeepAndCavernsDimNightmare);
            Add(AShadowOfThePastNightmare);
            Add(AKnifeInTheDarkNightmare);
            Add(FlightToTheFordNightmare);

            Add(TheRedhornGateNightmare);
            Add(RoadToRivendellNightmare);
            Add(TheWatcherInTheWaterNightmare);
            Add(TheLongDarkNightmare);
            Add(FoundationsOfStoneNightmare);
            Add(ShadowAndFlameNightmare);

            Add(FogOnTheBarrowDowns);

            Add(PerilInPelargirNightmare);
            Add(IntoIthilienNightmare);
            Add(TheSiegeOfCairAndrosNightmare);

            Add(FliesAndSpidersNightmare);
            Add(TheLonelyMountainNightmare);
            Add(TheBattleOfFiveArmiesNightmare);

            Add(TheStewardsFearNightmare);
            Add(TheDruadanForestNightmare);
            Add(EncounterAtAmonDinNightmare);
            Add(AssaultOnOsgiliathNightmare);
            Add(TheBloodOfGondorNightmare);
            Add(TheMorgulValeNightmare);

            Add(TheFordsOfIsenNightmare);
            Add(ToCatchAnOrcNightmare);
            Add(IntoFangornNightmare);

            Add(TheLostRealm);
            Add(TheWastesOfEriador);
            Add(EscapeFromMountGram);
            Add(AcrossTheEttenmoors);
            Add(TheTreacheryOfRhudaur);

            Add(FirstAge);
        }

        public static List<CardSet> All()
        {
            return all;
        }

        #region Static Members
        public static CardSet CoreSet = new Sets.CoreSet();
        public static CardSet TheHuntForGollum = new Sets.TheHuntforGollum();
        public static CardSet ConflictAtTheCarrock = new Sets.ConflictattheCarrock();
        public static CardSet AJourneyToRhosgobel = new Sets.AJourneytoRhosgobel();
        public static CardSet TheHillsOfEmynMuil = new Sets.TheHillsofEmynMuil();
        public static CardSet TheDeadMarshes = new Sets.TheDeadMarshes();
        public static CardSet ReturnToMirkwood = new Sets.ReturntoMirkwood();
        
        public static CardSet KhazadDum = new Sets.Khazaddum();
        public static CardSet TheRedhornGate = new Sets.TheRedhornGate();
        public static CardSet RoadToRivendell = new Sets.RoadtoRivendell();
        public static CardSet TheWatcherInTheWater = new Sets.TheWatcherintheWater();
        public static CardSet TheLongDark = new Sets.TheLongDark();
        public static CardSet FoundationsOfStone = new Sets.FoundationsofStone();
        public static CardSet ShadowAndFlame = new Sets.ShadowandFlame();

        public static CardSet HeirsOfNumenor = new Sets.HeirsofNumenor();
        public static CardSet TheStewardsFear = new Sets.TheStewardsFear();
        public static CardSet TheDruadanForest = new Sets.TheDruadanForest();
        public static CardSet EncounterAtAmonDin = new Sets.EncounteratAmonDin();
        public static CardSet AssaultOnOsgiliath = new Sets.AssaultonOsgiliath();
        public static CardSet TheBloodOfGondor = new Sets.TheBloodofGondor();
        public static CardSet TheMorgulVale = new Sets.TheMorgulVale();

        public static CardSet TheVoiceOfIsengard = new Sets.TheVoiceofIsengard();
        public static CardSet TheDunlandTrap = new Sets.TheDunlandTrap();
        public static CardSet TheThreeTrials = new Sets.TheThreeTrials();
        public static CardSet NinInEilph = new Sets.TheNinInEilph();
        public static CardSet CelebrimborsSecret = new Sets.CelebrimborsSecret();
        public static CardSet TheAntleredCrown = new Sets.TheAntleredCrown();

        public static CardSet TheHobbitOverHillAndUnderHill = new Sets.TheHobbitOverHillandUnderHill();
        public static CardSet TheHobbitOnTheDoorstep = new Sets.TheHobbitOntheDoorstep();

        public static CardSet TheBlackRiders = new Sets.TheBlackRiders();
        public static CardSet TheRoadDarkens = new Sets.TheRoadDarkens();
        public static CardSet TheTreasonOfSaruman = new Sets.TheTreasonOfSaruman();
        public static CardSet TheLandOfShadow = new Sets.TheLandOfShadow();

        public static CardSet TheMassingAtOsgiliath = new Sets.TheMassingatOsgiliath();
        public static CardSet TheBattleOfLakeTown = new Sets.TheBattleofLakeTown();
        public static CardSet TheStoneOfErech = new Sets.TheStoneofErech();
        public static CardSet TheRuinsOfBelegost = new Sets.TheRuinsOfBelegost();

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
        public static CardSet WeMustAwayEreBreakOfDayNightmare = new Sets.WeMustAwayEreBreakOfDayNightmare();
        public static CardSet OverTheMistyMountainsGrimNightmare = new Sets.OverTheMistyMountainsGrimNightmare();
        public static CardSet DungeonsDeepAndCavernsDimNightmare = new Sets.DungeonsDeepAndCavernsDimNightmare();
        public static CardSet AShadowOfThePastNightmare = new Sets.AShadowOfThePastNightmare();
        public static CardSet AKnifeInTheDarkNightmare = new Sets.AKnifeInTheDarkNightmare();
        public static CardSet FlightToTheFordNightmare = new Sets.FlightToTheFordNightmare();

        public static CardSet TheRedhornGateNightmare = new Sets.TheRedhornGateNightmare();
        public static CardSet RoadToRivendellNightmare = new Sets.RoadToRivendellNightmare();
        public static CardSet TheWatcherInTheWaterNightmare = new Sets.TheWatcherInTheWaterNightmare();
        public static CardSet TheLongDarkNightmare = new Sets.TheLongDarkNightmare();
        public static CardSet FoundationsOfStoneNightmare = new Sets.FoundationsOfStoneNightmare();
        public static CardSet ShadowAndFlameNightmare = new Sets.ShadowAndFlameNightmare();

        public static CardSet FogOnTheBarrowDowns = new Sets.FogOnTheBarrowDowns();

        public static CardSet PerilInPelargirNightmare = new Sets.PerilInPelargirNightmare();
        public static CardSet IntoIthilienNightmare = new Sets.IntoIthilienNightmare();
        public static CardSet TheSiegeOfCairAndrosNightmare = new Sets.TheSiegeOfCairAndrosNightmare();

        public static CardSet FliesAndSpidersNightmare = new Sets.FliesAndSpidersNightmare();
        public static CardSet TheLonelyMountainNightmare = new Sets.TheLonelyMountainNightmare();
        public static CardSet TheBattleOfFiveArmiesNightmare = new Sets.TheBattleOfFiveArmiesNightmare();

        public static CardSet TheStewardsFearNightmare = new Sets.TheStewardsFearNightmare();
        public static CardSet TheDruadanForestNightmare = new Sets.TheDruadanForestNightmare();
        public static CardSet EncounterAtAmonDinNightmare = new Sets.EncounterAtAmonDinNightmare();
        public static CardSet AssaultOnOsgiliathNightmare = new Sets.AssaultOnOsgiliathNightmare();
        public static CardSet TheBloodOfGondorNightmare = new Sets.TheBloodOfGondorNightmare();
        public static CardSet TheMorgulValeNightmare = new Sets.TheMorgulValeNightmare();

        public static CardSet TheFordsOfIsenNightmare = new Sets.TheFordsOfIsenNightmare();
        public static CardSet ToCatchAnOrcNightmare = new Sets.ToCatchAnOrcNightmare();
        public static CardSet IntoFangornNightmare = new Sets.IntoFangornNightmare();

        public static CardSet TheLostRealm = new Sets.TheLostRealm();
        public static CardSet TheWastesOfEriador = new Sets.TheWastesOfEriador();
        public static CardSet EscapeFromMountGram = new Sets.EscapeFromMountGram();
        public static CardSet AcrossTheEttenmoors = new Sets.AcrossTheEttenmoors();
        public static CardSet TheTreacheryOfRhudaur = new Sets.TheTreacheryOfRhudaur();

        public static CardSet FirstAge = new Sets.FirstAge();
        #endregion
    }
}