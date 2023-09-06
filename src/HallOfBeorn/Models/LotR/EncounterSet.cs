using System;
using System.Collections.Generic;
using System.Linq;

namespace HallOfBeorn.Models.LotR
{
    public class EncounterSet
        : ILabeled
    {
        public EncounterSet()
        {
            AlternateName = string.Empty;
        }

        private readonly List<LotRCard> cards = new List<LotRCard>();
        
        public IEnumerable<LotRCard> Cards()
        {
            return cards;
        }

        protected virtual void init()
        {
        }

        protected void includes(params LotRCard[] cards)
        {
            if (cards == null)
                return;

            foreach (var card in cards)
                addCard(card);
        }

        protected void addCard(LotRCard card)
        {
            if (card == null || cards.Any(c => c.Slug == card.Slug))
                return;

            cards.Add(card);
        }

        protected static LotRCard Quest(string encounterSet, string title, uint stageNumber, char stageLetter, byte? questPoints)
        {
            return LotRCard.Quest(title, stageNumber, encounterSet, questPoints, stageLetter);
        }

        protected static LotRCard Enemy(string encounterSet, string title, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            return LotRCard.Enemy(title, string.Empty, encounterSet, engagementCost, threat, attack, defense, hitPoints);
        }

        protected static LotRCard Location(string encounterSet, string title, byte? threat, byte? questPoints)
        {
            return LotRCard.Location(title, string.Empty, encounterSet, threat, questPoints);
        }

        protected static LotRCard Treachery(string encounterSet, string title)
        {
            return LotRCard.Treachery(title, string.Empty, encounterSet);
        }

        protected static LotRCard Objective(string encounterSet, string title)
        {
            return LotRCard.Objective(title, string.Empty, encounterSet);
        }
        
        protected static LotRCard ObjectiveHero(string encounterSet, string title, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return LotRCard.ObjectiveHero(title, encounterSet, willpower, attack, defense, hitPoints);
        }

        protected static LotRCard ObjectiveAlly(string encounterSet, string title, byte willpower, byte attack, byte defense, byte hitPoints)
        {
            return LotRCard.ObjectiveAlly(title, string.Empty, encounterSet, willpower, attack, defense, hitPoints);
        }

        protected static LotRCard ObjectiveLocation(string encounterSet, string title, byte questPoints)
        {
            return LotRCard.ObjectiveLocation(title, encounterSet, questPoints);
        }

        protected static LotRCard SideQuest(string encounterSet, string title, byte? questPoints)
        {
            return LotRCard.EncounterSideQuest(title, string.Empty, encounterSet, questPoints);
        }

        protected static LotRCard NightmareSetup(string encounterSet)
        {
            return LotRCard.NightmareSetup(encounterSet, encounterSet);
        }

        public string Set { get; set; }

        private string normalizedSet;
        public string NormalizedSet
        {
            get { return !string.IsNullOrEmpty(this.normalizedSet) ? this.normalizedSet : Set; }
            private set { this.normalizedSet = value; }
        }
        
        public string Name { get; set; }
        public string AlternateName { get; set; }
        
        public bool IsNightmare
        {
            get
            {
                var specialNightmareSets = new HashSet<string>
                {
                    EncounterSet.QuietTheSpirits.Name,
                    EncounterSet.SiftThroughTheDebris.Name,
                    EncounterSet.DecipherAncientTexts.Name
                };
                
                return !string.IsNullOrEmpty(Name) && 
                    (Name.EndsWith(" Nightmare") || specialNightmareSets.Contains(Name));
            }
        }

        public LotRCard Quest(string title, uint stageNumber, char stageLetter, byte? questPoints)
        {
            var quest = LotRCard.Quest(title, stageNumber, Name, questPoints);
            addCard(quest);
            return quest;
        }

        public LotRCard Enemy(string title, bool isUnique, byte? engagementCost, byte? threat, byte? attack, byte? defense, byte? hitPoints)
        {
            var enemy = LotRCard.Enemy(title, string.Empty, Name, engagementCost, threat, attack, defense, hitPoints);
            enemy.IsUnique = isUnique;
            addCard(enemy);
            return enemy;
        }

        public LotRCard Location(string title, bool isUnique, byte? threat, byte? questPoints)
        {
            var location = LotRCard.Location(title, string.Empty, Name, threat, questPoints);
            location.IsUnique = isUnique;
            addCard(location);
            return location;
        }

        public LotRCard Treachery(string title)
        {
            var treachery = LotRCard.Treachery(title, string.Empty, Name);
            addCard(treachery);
            return treachery;
        }

        public LotRCard Objective(string title, bool isUnique)
        {
            var objective = LotRCard.Objective(title, string.Empty, Name);
            objective.IsUnique = isUnique;
            addCard(objective);
            return objective;
        }

        public LotRCard ObjectiveAlly(string title, bool isUnique, byte? willpower, byte? attack, byte? defense, byte? hitPoints)
        {
            var objAlly = LotRCard.ObjectiveAlly(title, string.Empty, Name, willpower, attack, defense, hitPoints);
            addCard(objAlly);
            return objAlly;
        }

        public LotRCard ObjectiveHero(string title, byte? willpower, byte? attack, byte? defense, byte? hitPoints)
        {
            var objHero = LotRCard.ObjectiveHero(title, Name, willpower, attack, defense, hitPoints);
            addCard(objHero);
            return objHero;
        }

        public LotRCard ObjectiveLocation(string title, bool isUnique, byte? questPoints)
        {
            var objLocation = LotRCard.ObjectiveLocation(title, Name, questPoints);
            objLocation.IsUnique = isUnique;
            addCard(objLocation);
            return objLocation;
        }

        public LotRCard EncounterSideQuest(string title, byte? questPoints)
        {
            var sideQuest = LotRCard.EncounterSideQuest(title, string.Empty, Name, questPoints);
            addCard(sideQuest);
            return sideQuest;
        }

        public LotRCard Campaign(string title, string oppositeTitle)
        {
            var campaign = LotRCard.Campaign(title, Name, oppositeTitle);
            addCard(campaign);
            return campaign;
        }

        public LotRCard NightmareSetup()
        {
            var setup = LotRCard.NightmareSetup(Name, Name);
            addCard(setup);
            return setup;
        }

        public LotRCard GenConSetup(string title)
        {
            var setup = LotRCard.GenConSetup(title, Name);
            addCard(setup);
            return setup;
        }

        public IEnumerable<string> Labels()
        {
            var cardSet = HallOfBeorn.Services.LotR.ProductRepository.Instance.CardSets().FirstOrDefault(cs => cs.Name == Set);
            return cardSet != null 
                ? cardSet.Cards.Where(card => card.EncounterSet == Name).Select(card => card.NormalizedTitle)
                : Enumerable.Empty<string>();
        }

        static EncounterSet()
        {
            //Core Set and Shadows of Mirkwood
            Add(PassageThroughMirkwood);
            Add(DolGuldurOrcs);
            Add(SpidersOfMirkwood);
            Add(JourneyAlongTheAnduin);
            Add(SauronsReach);
            Add(Wilderlands);
            Add(EscapeFromDolGuldur);
            Add(TheHuntForGollum);
            Add(ConflictAtTheCarrock);
            Add(AJourneyToRhosgobel);
            Add(TheHillsOfEmynMuil);
            Add(TheDeadMarshes);
            Add(ReturnToMirkwood);

            //Revised Core Set
            Add(PassageThroughMirkwoodCampaign);
            Add(DolGuldurOrcsCampaign);
            Add(SpidersOfMirkwoodCampaign);
            Add(JourneyAlongTheAnduinCampaign);
            Add(SauronsReachCampaign);
            Add(WilderlandsCampaign);
            Add(EscapeFromDolGuldurCampaign);

            //Khazad-dum and Dwarrowdelf
            Add(IntoThePit);
            Add(TwistsAndTurns);
            Add(HazardsOfThePit);
            Add(GoblinsOfTheDeep);
            Add(TheSeventhLevel);
            Add(PlunderingGoblins);
            Add(FlightFromMoria);
            Add(DeepsOfMoria);
            Add(MistyMountains);
            Add(TheRedhornGate);
            Add(RoadToRivendell);
            Add(TheWatcherInTheWater);
            Add(TheLongDark);
            Add(FoundationsOfStone);
            Add(ShadowAndFlame);

            //Heirs of Numenor and Against the Shadow
            Add(PerilInPelargir);
            Add(StreetsOfGondor);
            Add(Brigands);
            Add(IntoIthilien);
            Add(BroodingForest);
            Add(CreaturesOfTheForest);
            Add(Southrons);
            Add(TheSiegeOfCairAndros);
            Add(RavagingOrcs);
            Add(MordorElite);
            Add(TheStewardsFear);
            Add(TheDruadanForest);
            Add(EncounterAtAmonDin);
            Add(AssaultOnOsgiliath);
            Add(TheBloodOfGondor);
            Add(TheMorgulVale);

            //The Voice of Isengard and The Ring-maker
            Add(TheFordsOfIsen);
            Add(DunlandWarriors);
            Add(DunlandRaiders);
            Add(ToCatchAnOrc);
            Add(MistyMountainOrcs);
            Add(BrokenLands);
            Add(IntoFangorn);
            Add(AncientForest);
            Add(WearyTravelers);
            Add(TheDunlandTrap);
            Add(TheThreeTrials);
            Add(TroubleInTharbad);
            Add(TheNinInEilph);
            Add(CelebrimborsSecret);
            Add(TheAntleredCrown);

            //The Lost Realm and Angmar Awakened
            Add(IntrudersInChetwood);
            Add(Iarion);
            Add(EriadorWilds);
            Add(AngmarOrcs);
            Add(RuinsOfArnor);
            Add(TheWeatherHills);
            Add(FoulWeather);
            Add(DarkSorcery);
            Add(DeadmensDike);
            Add(CursedDead);
            Add(TheWastesOfEriador);
            Add(EscapeFromMountGram);
            Add(AcrossTheEttenmoors);
            Add(TheTreacheryOfRhudaur);
            Add(TheBattleOfCarnDum);
            Add(TheDreadRealm);
            //Campaign
            Add(IntrudersInChetwoodCampaign);
            Add(IarionCampaign);
            Add(EriadorWildsCampaign);
            Add(AngmarOrcsCampaign);
            Add(RuinsOfArnorCampaign);
            Add(TheWeatherHillsCampaign);
            Add(FoulWeatherCampaign);
            Add(DarkSorceryCampaign);
            Add(DeadmensDikeCampaign);
            Add(CursedDeadCampaign);
            Add(TheWastesOfEriadorCampaign);
            Add(EscapeFromMountGramCampaign);
            Add(AcrossTheEttenmoorsCampaign);
            Add(TheTreacheryOfRhudaurCampaign);
            Add(TheBattleOfCarnDumCampaign);
            Add(TheDreadRealmCampaign);

            //The Grey Havens and Dream-chaser
            Add(CorsairPirates);
            Add(CorsairRaiders);
            Add(DrownedDead);
            Add(RaidOnTheGreyHavens);
            Add(StormyWeather);
            Add(TheDreamChasersFleet);
            Add(TheFateOfNumenor);
            Add(RuinsOfNumenor);
            Add(TheStormcallerElite);
            Add(UmbarFleet);
            Add(VastOceans);
            Add(VoyageAcrossBelegaer);
            Add(FlightOfTheStormcaller);
            Add(TheThingInTheDepths);
            Add(TheStormcaller);
            Add(TempleOfTheDeceived);
            Add(TheDrownedRuins);
            Add(AStormOnCobasHaven);
            Add(TheCityOfCorsairs);
            Add(TheDreamChasersFleetCampaign);

            //The Sands of Harad and Haradrim
            Add(EscapeFromUmbar);
            Add(TheLongArmOfMordor);
            Add(MordorOrcs);
            Add(DesertCrossing);
            Add(DesertCreatures);
            Add(JungleForest);
            Add(HaradSoldiers);
            Add(HaradTerritory);
            Add(DesertSands);
            Add(TheMumakil);
            Add(RaceAcrossHarad);
            Add(BeneathTheSands);
            Add(TheBlackSerpent);
            Add(TheDungeonsOfCirithGurat);
            Add(TheCrossingsOfPoros);
            Add(MountainsOfShadow);

            //The Wilds of Rhovanion and Ered Mithrin
            Add(LostInMirkwood);
            Add(JourneyUpTheAnduin);
            Add(TheKingsQuest);
            Add(LostInWilderland);
            Add(FellBeasts);
            Add(HillsOfWilderland);
            Add(GreyMountainGoblins);
            Add(GatheringGloom);
            Add(DragonMight);
            Add(DeepUnderground);
            Add(WildCreatures);
            Add(LostCaves);
            Add(AfraidOfTheDark);
            Add(DarkWoods);

            //Ered Mithrin APs
            Add(TheWitheredHeath);
            Add(RoamAcrossRhovanion);
            Add(FireInTheNight);
            Add(TheGhostOfFramsburg);
            Add(MountGundabad);
            Add(TheFateOfWilderland);

            //A Shadow in the East
            Add(TheRiverRunning);
            Add(RidersOfRhun);
            Add(EasterlingRaiders);
            Add(RollingPlains);
            Add(DangerInDorwinion);
            Add(ServantsOfSauron);
            Add(CityOfRhun);
            Add(UnderGuard);
            Add(TheTempleOfDoom);
            Add(UlchorsGuard);
            Add(TwistedTunnels);
            Add(ThePowerOfMordor);
            Add(GollumAndSmeagol);

            //Vengeance of Mordor APs
            Add(WrathAndRuin);
            Add(TheCityOfUlfast);
            Add(ChallengeOfTheWainriders);
            Add(UnderTheAshMountains);
            Add(TheLandOfSorrow);

            //Two Player Starter
            Add(TheOath);
            Add(TheGoblins);
            Add(TheCavesOfNibinDum);

            //The Hobbit: Over Hill and Under Hill
            Add(WeMustAwayEreBreakOfDay);
            Add(WesternLands);
            Add(OverTheMistyMountainsGrim);
            Add(TheGreatGoblin);
            Add(MistyMountainGoblins);
            Add(DungeonsDeepAndCavernsDim);

            //The Hobbit: On the Doorstep
            Add(FliesAndSpiders);
            Add(Wilderland);
            Add(TheLonelyMountain);
            Add(TheBattleOfFiveArmies);

            //The Lord of the Rings: The Black Riders
            Add(AShadowOfThePast);
            Add(Hunted);
            Add(TheRing);
            Add(TheBlackRiders);
            Add(AKnifeInTheDark);
            Add(TheNazgul);
            Add(FlightToTheFord);

            //The Lord of the Rings: The Road Darkens
            Add(TheRingGoesSouth);
            Add(JourneyInTheDark);
            Add(BreakingOfTheFellowship);

            //The Lord of the Rings: The Treason of Saruman
            Add(TheUrukHai);
            Add(OrcsOfTheWhiteHand);
            Add(SnagaOrcs);
            Add(HelmsDeep);
            Add(TheRoadToIsengard);

            //The Lord of the Rings: The Land of Shadow
            Add(ThePassageOfTheMarshes);
            Add(Gollum);
            Add(MorgulNazgul);
            Add(JourneyToTheCrossRoads);
            Add(MenOfHarad);
            Add(ShelobsLair);
            Add(TheGreatSpider);

            //The Lord of the Rings: The Flame of the West
            Add(ThePassingOfTheGreyCompany);
            Add(TheSiegeOfGondor);
            Add(TheBattleOfThePelennorFields);

            //The Lord of the Rings: The Mountain of Fire
            Add(TheTowerOfCirithUngol);
            Add(OrcsOfMordor);
            Add(DeepShadows);
            Add(TheBlackGateOpens);
            Add(MountDoom);

            //Gen Con and Fellowship Decks
            Add(TheMassingAtOsgiliath);
            Add(TheBattleOfLakeTown);
            Add(TheStoneOfErech);
            Add(TheOldForest);
            Add(FogOnTheBarrowDowns);
            Add(TheRuinsOfBelegost);
            Add(MurderAtThePrancingPony);
            Add(Investigation);
            Add(TheSiegeOfAnnuminas);
            Add(AttackOnDolGuldur);
            Add(TheWizardsQuest);
            Add(TheWoodlandRealm);
            Add(TheMinesOfMoria);
            Add(EscapeFromKhazadDum);

            Add(TheHuntForTheDreadnaught);
            Add(TheOathCampaign);
            Add(TheGoblinsCampaign);
            Add(TheCavesOfNibinDumCampaign);

            //Core Set and Shadows of Mirkwood Nightmare Decks
            Add(PassageThroughMirkwoodNightmare);
            Add(JourneyAlongTheAnduinNightmare);
            Add(EscapeFromDolGuldurNightmare);
            Add(TheHuntForGollumNightmare);
            Add(ConflictAtTheCarrockNightmare);
            Add(AJourneyToRhosgobelNightmare);
            Add(TheHillsOfEmynMuilNightmare);
            Add(TheDeadMarshesNightmare);
            Add(ReturnToMirkwoodNightmare);
        
            //Khazad-dum and Dwarrowdelf Nightmare Decks
            Add(IntoThePitNightmare);
            Add(TheSeventhLevelNightmare);
            Add(FlightFromMoriaNightmare);
            Add(TheRedhornGateNightmare);
            Add(RoadToRivendellNightmare);
            Add(TheWatcherInTheWaterNightmare);
            Add(TheLongDarkNightmare);
            Add(FoundationsOfStoneNightmare);
            Add(ShadowAndFlameNightmare);

            //Heirs of Numenor and Against the Shadow Nightmare Decks
            Add(PerilInPelargirNightmare);
            Add(IntoIthilienNightmare);
            Add(TheSiegeOfCairAndrosNightmare);
            Add(TheStewardsFearNightmare);
            Add(BrigandsNightmare);
            Add(TheDruadanForestNightmare);
            Add(EncounterAtAmonDinNightmare);
            Add(AssaultOnOsgiliathNightmare);
            Add(TheBloodOfGondorNightmare);
            Add(TheMorgulValeNightmare);

            //The Voice of Isengard and Ring-maker Nightmare Decks
            Add(TheFordsOfIsenNightmare);
            Add(ToCatchAnOrcNightmare);
            Add(IntoFangornNightmare);
            Add(TheDunlandTrapNightmare);
            Add(TheThreeTrialsNightmare);
            Add(TroubleInTharbadNightmare);
            Add(TheNinInEilphNightmare);
            Add(CelebrimborsSecretNightmare);
            Add(TheAntleredCrownNightmare);

            //The Lost Realm and Angmar Awakened Nightmare Decks
            Add(IntrudersInChetwoodNightmare);
            Add(TheWeatherHillsNightmare);
            Add(DeadmensDikeNightmare);
            Add(TheWastesOfEriadorNightmare);
            Add(EscapeFromMountGramNightmare);
            Add(AngmarOrcsNightmare);
            Add(AcrossTheEttenmoorsNightmare);
            Add(TheTreacheryOfRhudaurNightmare);
            Add(SiftThroughTheDebris);
            Add(DecipherAncientTexts);
            Add(QuietTheSpirits);
            Add(TheBattleOfCarnDumNightmare);
            Add(TheDreadRealmNightmare);

            //The Grey Havens and Dream-chaser Nightmare Decks
            Add(VoyageAcrossBelegaerNightmare);
            Add(TheFateOfNumenorNightmare);
            Add(RaidOnTheGreyHavensNightmare);
            Add(FlightOfTheStormcallerNightmare);
            Add(TheThingInTheDepthsNightmare);
            Add(TheStormcallerNightmare);
            Add(CorsairRaidersNightmare);
            Add(TempleOfTheDeceivedNightmare);
            Add(TheDrownedRuinsNightmare);
            Add(AStormOnCobasHavenNightmare);
            Add(TheCityOfCorsairsNightmare);
            Add(CoastOfUmbarNightmare);

            //The Hobbit: Over Hill and Under Hill Nightmare Decks
            Add(WeMustAwayEreBreakOfDayNightmare);
            Add(OverTheMistyMountainsGrimNightmare);
            Add(TheGreatGoblinNightmare);
            Add(DungeonsDeepAndCavernsDimNightmare);
        
            //The Hobbit: On the Doorstep Nightmare Decks
            Add(FliesAndSpidersNightmare);
            Add(TheLonelyMountainNightmare);
            Add(TheBattleOfFiveArmiesNightmare);
        
            //The Lord of the Rings: The Black Riders Nightmare Decks
            Add(AShadowOfThePastNightmare);
            Add(AKnifeInTheDarkNightmare);
            Add(FlightToTheFordNightmare);

            //The Lord of the Rings: The Road Darkens Nightmare Decks
            Add(TheRingGoesSouthNightmare);
            Add(JourneyInTheDarkNightmare);
            Add(BreakingOfTheFellowshipNightmare);

            //The Lord of the Rings: The Treason of Saruman Nightmare Decks
            Add(TheUrukHaiNightmare);
            Add(HelmsDeepNightmare);
            Add(TheRoadToIsengardNightmare);

            //The Lord of the Rings: The Land of Shadow Nightmare Decks
            Add(ThePassageOfTheMarshesNightmare);
            Add(JourneyToTheCrossRoadsNightmare);
            Add(ShelobsLairNightmare);

            //First Age and Doom Mastered
            Add(HuntingOfTheWolf);
            Add(TheIsleOfWerewolves);
            Add(TheSeatOfMorgoth);
            Add(TrialUponTheMarches);
            Add(AmongTheOutlaws);
            Add(TheBetrayalOfMim);
            Add(TheFallOfNargothrond);

            //A Long-extended Party
            Add(AmbushAtErelas);
            Add(RohanWeather);
            Add(RohanEncampment);
            Add(TheBattleForTheBeacon);
            Add(DunlendingWarriors);
            Add(FaithlessRohirrim);
            Add(TheHorseLordsIre);
            Add(OrcHost);
            Add(RohanLands);

            //Oaths of the Rohirrim
            Add(TheAldburgPlot);
            Add(FireOnTheEastemnet);
            Add(TheGapOfRohan);
            Add(TheGlitteringCaves);
            Add(SearchForTheHorn);
            Add(ExploringTheCaves);
            Add(MusteringOfTheRohirrim);
            Add(BloodInTheIsen);

            //Stand Alon ALEP Scenarios
            Add(TheScouringOfTheShire);
            Add(TheNineAreAbroad);
            Add(Region);
            Add(TheSiegeOfErebor);
        }

        private static List<EncounterSet> all = new List<EncounterSet>();

        public static EncounterSet Lookup(string name)
        {
            return all.FirstOrDefault(es => es.Name == name);
        }

        private static void Add(EncounterSet set)
        {
            all.Add(set);
        }

        public static List<EncounterSet> All()
        {
            return all;
        }

        //Core Set and Shadows of Mirkwood
        public static EncounterSet PassageThroughMirkwood = new EncounterSet { Name = "Passage Through Mirkwood", Set = "Core Set" };
        public static EncounterSet DolGuldurOrcs = new EncounterSet { Name = "Dol Guldur Orcs", Set = "Core Set" };
        public static EncounterSet SpidersOfMirkwood = new EncounterSet { Name = "Spiders of Mirkwood", Set = "Core Set" };
        public static EncounterSet JourneyAlongTheAnduin = new EncounterSet { Name = "Journey Along the Anduin", Set = "Core Set"};
        public static EncounterSet SauronsReach = new EncounterSet { Name = "Sauron's Reach", Set = "Core Set" };
        public static EncounterSet Wilderlands = new EncounterSet { Name = "Wilderlands", Set = "Core Set" };
        public static EncounterSet EscapeFromDolGuldur = new EncounterSet { Name = "Escape from Dol Guldur", Set = "Core Set" };
        public static EncounterSet TheHuntForGollum = new EncounterSet { Name = "The Hunt for Gollum", Set = "The Hunt for Gollum" };
        public static EncounterSet ConflictAtTheCarrock = new EncounterSet { Name = "Conflict at the Carrock", Set = "Conflict at the Carrock" };
        public static EncounterSet AJourneyToRhosgobel = new EncounterSet { Name = "A Journey to Rhosgobel", Set = "A Journey to Rhosgobel" };
        public static EncounterSet TheHillsOfEmynMuil = new EncounterSet { Name = "The Hills of Emyn Muil", Set = "The Hills of Emyn Muil" };
        public static EncounterSet TheDeadMarshes = new EncounterSet { Name = "The Dead Marshes", Set = "The Dead Marshes" };
        public static EncounterSet ReturnToMirkwood = new EncounterSet { Name = "Return to Mirkwood", Set = "Return to Mirkwood" };
        
        //Revised Core Set
        public static EncounterSet PassageThroughMirkwoodCampaign = new EncounterSet { Name = "Passage Through Mirkwood (Campaign)", Set = "Revised Core Set" };
        public static EncounterSet DolGuldurOrcsCampaign = new EncounterSet { Name = "Dol Guldur Orcs (Campaign)", Set = "Revised Core Set" };
        public static EncounterSet SpidersOfMirkwoodCampaign = new EncounterSet { Name = "Spiders of Mirkwood (Campaign)", Set = "Revised Core Set" };
        public static EncounterSet JourneyAlongTheAnduinCampaign = new EncounterSet { Name = "Journey Along the Anduin (Campaign)", Set = "Revised Core Set"};
        public static EncounterSet SauronsReachCampaign = new EncounterSet { Name = "Sauron's Reach (Campaign)", Set = "Revised Core Set" };
        public static EncounterSet WilderlandsCampaign = new EncounterSet { Name = "Wilderlands (Campaign)", Set = "Revised Core Set" };
        public static EncounterSet EscapeFromDolGuldurCampaign = new EncounterSet { Name = "Escape from Dol Guldur (Campaign)", Set = "Revised Core Set" };

        //Khazad-dum and Dwarrowdelf
        public static EncounterSet IntoThePit = new EncounterSet { Name = "Into the Pit", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet TwistsAndTurns = new EncounterSet { Name = "Twists and Turns", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet HazardsOfThePit = new EncounterSet { Name = "Hazards of the Pit", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet GoblinsOfTheDeep = new EncounterSet { Name = "Goblins of the Deep", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet TheSeventhLevel = new EncounterSet { Name = "The Seventh Level", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet PlunderingGoblins = new EncounterSet { Name = "Plundering Goblins", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet FlightFromMoria = new EncounterSet { Name = "Flight from Moria", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet DeepsOfMoria = new EncounterSet { Name = "Deeps of Moria", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet MistyMountains = new EncounterSet { Name = "Misty Mountains", Set = "Khazad-dûm", NormalizedSet = "Khazad-dum" };
        public static EncounterSet TheRedhornGate = new EncounterSet { Name = "The Redhorn Gate", Set = "The Redhorn Gate" };
        public static EncounterSet RoadToRivendell = new EncounterSet { Name = "Road to Rivendell", Set = "Road to Rivendell" };
        public static EncounterSet TheWatcherInTheWater = new EncounterSet { Name = "The Watcher in the Water", Set = "The Watcher in the Water" };
        public static EncounterSet TheLongDark = new EncounterSet { Name = "The Long Dark", Set = "The Long Dark" };
        public static EncounterSet FoundationsOfStone = new EncounterSet { Name = "Foundations of Stone", Set = "Foundations of Stone" };
        public static EncounterSet ShadowAndFlame = new EncounterSet { Name = "Shadow and Flame", Set = "Shadow and Flame" };
        
        //Heirs of Numenor and Against the Shadow
        public static EncounterSet PerilInPelargir = new EncounterSet { Name = "Peril in Pelargir", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet StreetsOfGondor = new EncounterSet { Name = "Streets of Gondor", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet Brigands = new EncounterSet { Name = "Brigands", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet IntoIthilien = new EncounterSet { Name = "Into Ithilien", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet BroodingForest = new EncounterSet { Name = "Brooding Forest", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet CreaturesOfTheForest = new EncounterSet { Name = "Creatures of the Forest", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet Southrons = new EncounterSet { Name = "Southrons", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet TheSiegeOfCairAndros = new EncounterSet { Name = "The Siege of Cair Andros", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet RavagingOrcs = new EncounterSet { Name = "Ravaging Orcs", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet MordorElite = new EncounterSet { Name = "Mordor Elite", Set = "Heirs of Númenor", NormalizedSet = "Heirs of Numenor" };
        public static EncounterSet TheStewardsFear = new EncounterSet { Name = "The Steward's Fear", Set = "The Steward's Fear" };
        public static EncounterSet TheDruadanForest = new EncounterSet { Name = "The Drúadan Forest", Set = "The Drúadan Forest", NormalizedSet = "The Druadan Forest" };
        public static EncounterSet EncounterAtAmonDin = new EncounterSet { Name = "Encounter at Amon Dîn", Set = "Encounter at Amon Dîn", NormalizedSet = "Encounter at Amon Din", };
        public static EncounterSet AssaultOnOsgiliath = new EncounterSet { Name = "Assault on Osgiliath", Set = "Assault on Osgiliath" };
        public static EncounterSet TheBloodOfGondor = new EncounterSet { Name = "The Blood of Gondor", Set = "The Blood of Gondor" };
        public static EncounterSet TheMorgulVale = new EncounterSet { Name = "The Morgul Vale", Set = "The Morgul Vale" };
        
        //The Voice of Isengard and The Ring-maker
        public static EncounterSet TheFordsOfIsen = new EncounterSet { Name = "The Fords of Isen", Set = "The Voice of Isengard" };
        public static EncounterSet DunlandWarriors = new EncounterSet { Name = "Dunland Warriors", Set = "The Voice of Isengard" };
        public static EncounterSet DunlandRaiders = new EncounterSet { Name = "Dunland Raiders", Set = "The Voice of Isengard" };
        public static EncounterSet ToCatchAnOrc = new EncounterSet { Name = "To Catch an Orc", Set = "The Voice of Isengard" };
        public static EncounterSet MistyMountainOrcs = new EncounterSet { Name = "Misty Mountain Orcs", Set = "The Voice of Isengard" };
        public static EncounterSet BrokenLands = new EncounterSet { Name = "Broken Lands", Set = "The Voice of Isengard" };
        public static EncounterSet IntoFangorn = new EncounterSet { Name = "Into Fangorn", Set = "The Voice of Isengard" };
        public static EncounterSet AncientForest = new EncounterSet { Name = "Ancient Forest", Set = "The Voice of Isengard" };
        public static EncounterSet WearyTravelers = new EncounterSet { Name = "Weary Travelers", Set = "The Voice of Isengard" };
        public static EncounterSet TheDunlandTrap = new EncounterSet { Name = "The Dunland Trap", Set = "The Dunland Trap" };
        public static EncounterSet TheThreeTrials = new EncounterSet { Name = "The Three Trials", Set = "The Three Trials" };
        public static EncounterSet TroubleInTharbad = new EncounterSet { Name = "Trouble in Tharbad", Set = "Trouble in Tharbad" };
        public static EncounterSet TheNinInEilph = new EncounterSet { Name = "The Nîn-in-Eilph", Set = "The Nîn-in-Eilph", NormalizedSet = "The Nin-in-Eilph" };
        public static EncounterSet CelebrimborsSecret = new EncounterSet { Name = "Celebrimbor's Secret", Set = "Celebrimbor's Secret" };
        public static EncounterSet TheAntleredCrown = new EncounterSet { Name = "The Antlered Crown", Set = "The Antlered Crown" };

        //The Lost Realm and Angmar Awakened
        public static EncounterSet IntrudersInChetwood = new EncounterSet { Name = "Intruders in Chetwood", Set = "The Lost Realm" };
        public static EncounterSet Iarion = new EncounterSet { Name = "Iârion", Set = "The Lost Realm" };
        public static EncounterSet EriadorWilds = new EncounterSet { Name = "Eriador Wilds", Set = "The Lost Realm" };
        public static EncounterSet AngmarOrcs = new EncounterSet { Name = "Angmar Orcs", Set = "The Lost Realm" };
        public static EncounterSet RuinsOfArnor = new EncounterSet { Name = "Ruins of Arnor", Set = "The Lost Realm" };
        public static EncounterSet TheWeatherHills = new EncounterSet { Name = "The Weather Hills", Set = "The Lost Realm" };
        public static EncounterSet FoulWeather = new EncounterSet { Name = "Foul Weather", Set = "The Lost Realm" };
        public static EncounterSet DarkSorcery = new EncounterSet { Name = "Dark Sorcery", Set = "The Lost Realm" };
        public static EncounterSet DeadmensDike = new EncounterSet { Name = "Deadmen's Dike", Set = "The Lost Realm" };
        public static EncounterSet CursedDead = new EncounterSet { Name = "Cursed Dead", Set = "The Lost Realm" };
        public static EncounterSet TheWastesOfEriador = new EncounterSet { Name = "The Wastes of Eriador", Set = "The Wastes of Eriador" };
        public static EncounterSet EscapeFromMountGram = new EncounterSet { Name = "Escape from Mount Gram", Set = "Escape from Mount Gram" };
        public static EncounterSet AcrossTheEttenmoors = new EncounterSet { Name = "Across the Ettenmoors", Set = "Across the Ettenmoors" };
        public static EncounterSet TheTreacheryOfRhudaur = new EncounterSet { Name = "The Treachery of Rhudaur", Set = "The Treachery of Rhudaur" };
        public static EncounterSet TheBattleOfCarnDum = new EncounterSet { Name = "The Battle of Carn Dûm", Set = "The Battle of Carn Dûm", NormalizedSet = "The Battle of Carn Dum" };
        public static EncounterSet TheDreadRealm = new EncounterSet { Name = "The Dread Realm", Set = "The Dread Realm" };
        //Campaign
        public static EncounterSet IntrudersInChetwoodCampaign = new EncounterSet { Name = "Intruders in Chetwood Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet IarionCampaign = new EncounterSet { Name = "Iârion Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet EriadorWildsCampaign = new EncounterSet { Name = "Eriador Wilds Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet AngmarOrcsCampaign = new EncounterSet { Name = "Angmar Orcs Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet RuinsOfArnorCampaign = new EncounterSet { Name = "Ruins of Arnor Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet TheWeatherHillsCampaign = new EncounterSet { Name = "The Weather Hills Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet FoulWeatherCampaign = new EncounterSet { Name = "Foul Weather Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet DarkSorceryCampaign = new EncounterSet { Name = "Dark Sorcery Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet DeadmensDikeCampaign = new EncounterSet { Name = "Deadmen's Dike Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet CursedDeadCampaign = new EncounterSet { Name = "Cursed Dead Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet TheWastesOfEriadorCampaign = new EncounterSet { Name = "The Wastes of Eriador Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet EscapeFromMountGramCampaign = new EncounterSet { Name = "Escape from Mount Gram Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet AcrossTheEttenmoorsCampaign = new EncounterSet { Name = "Across the Ettenmoors Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet TheTreacheryOfRhudaurCampaign = new EncounterSet { Name = "The Treachery of Rhudaur Campaign", Set = "Angmar Awakened Campaign Expansion" };
        public static EncounterSet TheBattleOfCarnDumCampaign = new EncounterSet { Name = "The Battle of Carn Dûm Campaign", Set = "Angmar Awakened Campaign Expansion"};
        public static EncounterSet TheDreadRealmCampaign = new EncounterSet { Name = "The Dread Realm Campaign", Set = "Angmar Awakened Campaign Expansion" };
        

        //The Grey Havens and Dream-chaser
        public static EncounterSet CorsairPirates = new EncounterSet { Name = "Corsair Pirates", Set = "The Grey Havens" };
        public static EncounterSet CorsairRaiders = new EncounterSet { Name = "Corsair Raiders", Set = "The Grey Havens" };
        public static EncounterSet DrownedDead = new EncounterSet { Name = "Drowned Dead", Set = "The Grey Havens" };
        public static EncounterSet RaidOnTheGreyHavens = new EncounterSet { Name = "Raid on the Grey Havens", Set = "The Grey Havens" };
        public static EncounterSet StormyWeather = new EncounterSet { Name = "Stormy Weather", Set = "The Grey Havens" };
        public static EncounterSet TheDreamChasersFleet = new EncounterSet { Name = "The Dream-chaser's Fleet", Set = "The Grey Havens" };
        public static EncounterSet TheFateOfNumenor = new EncounterSet { Name = "The Fate of Númenor", Set = "The Grey Havens" };
        public static EncounterSet RuinsOfNumenor = new EncounterSet { Name = "Ruins of Númenor", Set = "The Grey Havens" };
        public static EncounterSet TheStormcallerElite = new EncounterSet { Name = "The Stormcaller Elite", Set = "The Grey Havens" };
        public static EncounterSet UmbarFleet = new EncounterSet { Name = "Umbar Fleet", Set = "The Grey Havens" };
        public static EncounterSet VastOceans = new EncounterSet { Name = "Vast Oceans", Set = "The Grey Havens" };
        public static EncounterSet VoyageAcrossBelegaer = new EncounterSet { Name = "Voyage Across Belegaer", Set = "The Grey Havens" };
        public static EncounterSet FlightOfTheStormcaller = new EncounterSet { Name = "Flight of the Stormcaller", Set = "Flight of the Stormcaller" };
        public static EncounterSet TheThingInTheDepths = new EncounterSet { Name = "The Thing in the Depths", Set = "The Thing in the Depths" };
        public static EncounterSet TheStormcaller = new EncounterSet { Name = "The Stormcaller", Set = "The Thing in the Depths" };
        public static EncounterSet TempleOfTheDeceived = new EncounterSet { Name = "Temple of the Deceived", Set = "Temple of the Deceived" };
        public static EncounterSet TheDrownedRuins = new EncounterSet { Name = "The Drowned Ruins", Set = "The Drowned Ruins" };
        public static EncounterSet AStormOnCobasHaven = new EncounterSet { Name = "A Storm on Cobas Haven", Set = "A Storm on Cobas Haven" };
        public static EncounterSet TheCityOfCorsairs = new EncounterSet { Name = "The City of Corsairs", Set = "The City of Corsairs" };
        public static EncounterSet CoastOfUmbar = new EncounterSet { Name = "Coast of Umbar", Set = "The City of Corsairs" };
        public static EncounterSet TheDreamChasersFleetCampaign = new EncounterSet { Name = "The Dream-chaser's Fleet Campaign", Set = "Dream-chaser Campaign Expansion" };
        public static EncounterSet VoyageAcrossBelegaerCampaign = new EncounterSet { Name = "Voyage Across Belegaer Campaign", Set = "Dream-chaser Campaign Expansion" };

        //The Sands of Harad and Haradrim
        public static EncounterSet EscapeFromUmbar = new EncounterSet { Name = "Escape from Umbar", Set = "The Sands of Harad" };
        public static EncounterSet TheLongArmOfMordor = new EncounterSet { Name = "The Long Arm of Mordor", Set = "The Sands of Harad" };
        public static EncounterSet MordorOrcs = new EncounterSet { Name = "Mordor Orcs", Set = "The Sands of Harad" };
        public static EncounterSet DesertCrossing = new EncounterSet { Name = "Desert Crossing", Set = "The Sands of Harad" };
        public static EncounterSet DesertCreatures = new EncounterSet { Name = "Desert Creatures", Set = "The Sands of Harad" };
        public static EncounterSet HaradSoldiers = new EncounterSet { Name = "Harad Soldiers", Set = "The Sands of Harad" };
        public static EncounterSet HaradTerritory = new EncounterSet { Name = "Harad Territory", Set = "The Sands of Harad" };
        public static EncounterSet JungleForest = new EncounterSet { Name = "Jungle Forest", Set = "The Sands of Harad" };
        public static EncounterSet DesertSands = new EncounterSet { Name = "Desert Sands", Set = "The Sands of Harad" };
        public static EncounterSet TheMumakil = new EncounterSet { Name = "The Mûmakil", Set = "The Mûmakil" };
        public static EncounterSet RaceAcrossHarad = new EncounterSet { Name = "Race Across Harad", Set = "Race Across Harad" };
        public static EncounterSet BeneathTheSands = new EncounterSet { Name = "Beneath the Sands", Set = "Beneath the Sands" };
        public static EncounterSet TheBlackSerpent = new EncounterSet { Name = "The Black Serpent", Set = "The Black Serpent" };
        public static EncounterSet TheDungeonsOfCirithGurat = new EncounterSet { Name = "The Dungeons of Cirith Gurat", Set = "The Dungeons of Cirith Gurat" };
        public static EncounterSet TheCrossingsOfPoros = new EncounterSet { Name = "The Crossings of Poros", Set = "The Crossings of Poros" };
        public static EncounterSet MountainsOfShadow = new EncounterSet { Name = "Mountains of Shadow", Set = "The Crossings of Poros" };

        //The Wilds of Rhovanion and Ered Mithrin
        private const string setNameWilds = "The Wilds of Rhovanion";
        public static EncounterSet LostInMirkwood = new EncounterSet { Name = "Lost in Mirkwood", Set = setNameWilds };
        public static EncounterSet JourneyUpTheAnduin = new EncounterSet { Name = "Journey up the Anduin", Set = setNameWilds };
        public static EncounterSet TheKingsQuest = new EncounterSet { Name = "The King's Quest", Set = setNameWilds };
        public static EncounterSet LostInWilderland = new EncounterSet { Name = "Lost in Wilderland", Set = setNameWilds };
        public static EncounterSet FellBeasts = new EncounterSet { Name = "Fell Beasts", Set = setNameWilds };
        public static EncounterSet HillsOfWilderland = new EncounterSet { Name = "Hills of Wilderland", Set = setNameWilds };
        public static EncounterSet GreyMountainGoblins = new EncounterSet { Name = "Grey Mountain Goblins", Set = setNameWilds };
        public static EncounterSet GatheringGloom = new EncounterSet { Name = "Gathering Gloom", Set = setNameWilds };
        public static EncounterSet DragonMight = new EncounterSet { Name = "Dragon Might", Set = setNameWilds };
        public static EncounterSet DeepUnderground = new EncounterSet { Name = "Deep Underground", Set = setNameWilds };
        public static EncounterSet WildCreatures = new EncounterSet { Name = "Wild Creatures", Set = setNameWilds };
        public static EncounterSet LostCaves = new EncounterSet { Name = "Lost Caves", Set = setNameWilds };
        public static EncounterSet AfraidOfTheDark = new EncounterSet { Name = "Afraid of the Dark", Set = setNameWilds };
        public static EncounterSet DarkWoods = new EncounterSet { Name = "Dark Woods", Set = setNameWilds };
        public static EncounterSet TheWitheredHeath = new EncounterSet { Name = "The Withered Heath", Set = "The Withered Heath" };
        public static EncounterSet RoamAcrossRhovanion = new EncounterSet { Name = "Roam Across Rhovanion", Set = "Roam Across Rhovanion" };
        public static EncounterSet FireInTheNight = new EncounterSet { Name = "Fire in the Night", Set = "Fire in the Night" };
        public static EncounterSet TheGhostOfFramsburg = new EncounterSet { Name = "The Ghost of Framsburg", Set = "The Ghost of Framsburg" };
        public static EncounterSet MountGundabad = new EncounterSet { Name = "Mount Gundabad", Set = "Mount Gundabad" };
        public static EncounterSet TheFateOfWilderland = new EncounterSet { Name = "The Fate of Wilderland", Set = "The Fate of Wilderland" };

        //A Shadow in the East and Vengeance of Mordor
        public static EncounterSet TheRiverRunning = new EncounterSet { Name = "The River Running", Set = "A Shadow in the East" };
        public static EncounterSet RidersOfRhun = new EncounterSet { Name = "Riders of Rhûn", Set = "A Shadow in the East" };
        public static EncounterSet EasterlingRaiders = new EncounterSet { Name = "Easterling Raiders", Set = "A Shadow in the East" };
        public static EncounterSet RollingPlains = new EncounterSet { Name = "Rolling Plains", Set = "A Shadow in the East" };
        public static EncounterSet DangerInDorwinion = new EncounterSet { Name = "Danger in Dorwinion", Set = "A Shadow in the East" };
        public static EncounterSet ServantsOfSauron = new EncounterSet { Name = "Servants of Sauron", Set = "A Shadow in the East" };
        public static EncounterSet CityOfRhun = new EncounterSet { Name = "City of Rhûn", Set = "A Shadow in the East" };
        public static EncounterSet UnderGuard = new EncounterSet { Name = "Under Guard", Set = "A Shadow in the East" };
        public static EncounterSet TheTempleOfDoom = new EncounterSet { Name = "The Temple of Doom", Set = "A Shadow in the East" };
        public static EncounterSet UlchorsGuard = new EncounterSet { Name = "Ulchor's Guard", Set = "A Shadow in the East" };
        public static EncounterSet TwistedTunnels = new EncounterSet { Name = "Twisted Tunnels", Set = "A Shadow in the East" };
        public static EncounterSet ThePowerOfMordor = new EncounterSet { Name = "The Power of Mordor", Set = "A Shadow in the East" };
        public static EncounterSet GollumAndSmeagol = new EncounterSet { Name = "Gollum and Smeagol", Set = "A Shadow in the East" }; 

        //Vengeance of Mordor
        public static EncounterSet WrathAndRuin = new EncounterSet { Name = "Wrath and Ruin", Set = "Wrath and Ruin" };
        public static EncounterSet TheCityOfUlfast = new EncounterSet { Name = "The City of Ulfast", Set = "The City of Ulfast" };
        public static EncounterSet ChallengeOfTheWainriders = new EncounterSet { Name = "Challenge of the Wainriders", Set = "Challenge of the Wainriders" };
        public static EncounterSet UnderTheAshMountains = new EncounterSet { Name = "Under the Ash Mountains", Set = "Under the Ash Mountains" };
        public static EncounterSet TheLandOfSorrow = new EncounterSet { Name = "The Land of Sorrow", Set = "The Land of Sorrow" };
        public static EncounterSet TheFortressOfNurn = new EncounterSet { Name = "The Fortress of Nurn", Set = "The Fortress of Nurn" };

        //Two Player Starter
        public static EncounterSet TheOath = new EncounterSet { Name = "The Oath", Set = "Two-Player Limited Edition Starter" };
        public static EncounterSet TheGoblins = new EncounterSet { Name = "The Goblins", Set = "Two-Player Limited Edition Starter" };
        public static EncounterSet TheCavesOfNibinDum = new EncounterSet { Name = "The Caves of Nibin-Dûm", Set = "Two-Player Limited Edition Starter" };

        //The Hobbit: Over Hill and Under Hill
        public static EncounterSet WeMustAwayEreBreakOfDay = new EncounterSet { Name = "We Must Away, Ere Break of Day", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet WesternLands = new EncounterSet { Name = "Western Lands", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet OverTheMistyMountainsGrim = new EncounterSet { Name = "Over the Misty Mountains Grim", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet TheGreatGoblin = new EncounterSet { Name = "The Great Goblin", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet MistyMountainGoblins = new EncounterSet { Name = "Misty Mountain Goblins", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet DungeonsDeepAndCavernsDim = new EncounterSet { Name = "Dungeons Deep and Caverns Dim", Set = "The Hobbit: Over Hill and Under Hill" };

        //The Hobbit: On the Doorstep
        public static EncounterSet FliesAndSpiders = new EncounterSet { Name = "Flies and Spiders", Set = "The Hobbit: On the Doorstep" };
        public static EncounterSet Wilderland = new EncounterSet { Name = "Wilderland", Set = "The Hobbit: On the Doorstep" };
        public static EncounterSet TheLonelyMountain = new EncounterSet { Name = "The Lonely Mountain", Set = "The Hobbit: On the Doorstep" };
        public static EncounterSet TheBattleOfFiveArmies = new EncounterSet { Name = "The Battle of Five Armies", Set = "The Hobbit: On the Doorstep" };

        //The Lord of the Rings: The Black Riders
        public static EncounterSet AShadowOfThePast = new EncounterSet { Name = "A Shadow of the Past", Set = "The Black Riders" };
        public static EncounterSet Hunted = new EncounterSet { Name = "Hunted", Set = "The Black Riders" };
        public static EncounterSet TheRing = new EncounterSet { Name = "The Ring", Set = "The Black Riders" };
        public static EncounterSet TheBlackRiders = new EncounterSet { Name = "The Black Riders", Set = "The Black Riders" };
        public static EncounterSet AKnifeInTheDark = new EncounterSet { Name = "A Knife in the Dark", Set = "The Black Riders" };
        public static EncounterSet TheNazgul = new EncounterSet { Name = "The Nazgûl", Set = "The Black Riders" };
        public static EncounterSet FlightToTheFord = new EncounterSet { Name = "Flight to the Ford", Set = "The Black Riders" };

        //The Lord of the Rings: The Road Darkens
        public static EncounterSet TheRingGoesSouth = new EncounterSet { Name = "The Ring Goes South", Set = "The Road Darkens" };
        public static EncounterSet JourneyInTheDark = new EncounterSet { Name = "Journey in the Dark", Set = "The Road Darkens" };
        public static EncounterSet BreakingOfTheFellowship = new EncounterSet { Name = "Breaking of the Fellowship", Set = "The Road Darkens" };

        //The Lord of the Rings: The Treason of Saruman
        public static EncounterSet TheUrukHai = new EncounterSet { Name = "The Uruk-hai", Set = "The Treason of Saruman" };
        public static EncounterSet OrcsOfTheWhiteHand = new EncounterSet { Name = "Orcs of the White Hand", Set = "The Treason of Saruman" };
        public static EncounterSet SnagaOrcs = new EncounterSet { Name = "Snaga Orcs", Set = "The Treason of Saruman" };
        public static EncounterSet HelmsDeep = new EncounterSet { Name = "Helm's Deep", Set = "The Treason of Saruman" };
        public static EncounterSet TheRoadToIsengard = new EncounterSet { Name = "The Road to Isengard", Set = "The Treason of Saruman" };

        //The Lord of the Rings: The Land of Shadow
        public static EncounterSet ThePassageOfTheMarshes = new EncounterSet { Name = "The Passage of the Marshes", Set = "The Land of Shadow" };
        public static EncounterSet Gollum = new EncounterSet { Name = "Gollum", Set = "The Land of Shadow" };
        public static EncounterSet MorgulNazgul = new EncounterSet { Name = "Morgul Nazgûl", Set = "The Land of Shadow" };
        public static EncounterSet JourneyToTheCrossRoads = new EncounterSet { Name = "Journey to the Cross-roads", Set = "The Land of Shadow" };
        public static EncounterSet MenOfHarad = new EncounterSet { Name = "Men of Harad", Set = "The Land of Shadow" };
        public static EncounterSet ShelobsLair = new EncounterSet { Name = "Shelob's Lair", Set = "The Land of Shadow" };
        public static EncounterSet TheGreatSpider = new EncounterSet { Name = "The Great Spider", Set = "The Land of Shadow" };

        //The Lord of the Rings: The Flame of the West
        public static EncounterSet ThePassingOfTheGreyCompany = new EncounterSet { Name = "The Passing of the Grey Company", Set = "The Flame of the West" };
        public static EncounterSet TheSiegeOfGondor = new EncounterSet { Name = "The Siege of Gondor", Set = "The Flame of the West" };
        public static EncounterSet TheBattleOfThePelennorFields = new EncounterSet { Name = "The Battle of the Pelennor Fields", Set = "The Flame of the West" };

        //The Lord of the Rings: The Mountain of Fire
        public static EncounterSet TheTowerOfCirithUngol = new EncounterSet { Name = "The Tower of Cirith Ungol", Set = "The Mountain of Fire" };
        public static EncounterSet OrcsOfMordor = new EncounterSet { Name = "Orcs of Mordor", Set = "The Mountain of Fire" };
        public static EncounterSet DeepShadows = new EncounterSet { Name = "Deep Shadows", Set = "The Mountain of Fire" };
        public static EncounterSet TheBlackGateOpens = new EncounterSet { Name = "The Black Gate Opens", Set = "The Mountain of Fire" };
        public static EncounterSet MountDoom = new EncounterSet { Name = "Mount Doom", Set = "The Mountain of Fire" };
        public static EncounterSet MountainOfFireEpicMultiplayer = new EncounterSet { Name = "Mountain of Fire Epic Multiplayer", Set = "The Mountain of Fire" };

        //Gen Con and Fellowship Decks
        public static EncounterSet TheMassingAtOsgiliath = new EncounterSet { Name = "The Massing at Osgiliath", Set = "The Massing at Osgiliath" };
        public static EncounterSet TheBattleOfLakeTown = new EncounterSet { Name = "The Battle of Lake-town", Set = "The Battle of Lake-town" };
        public static EncounterSet TheStoneOfErech = new EncounterSet { Name = "The Stone of Erech", Set = "The Stone of Erech" };
        public static EncounterSet TheOldForest = new EncounterSet { Name = "The Old Forest", Set = "The Old Forest" };
        public static EncounterSet FogOnTheBarrowDowns = new EncounterSet { Name = "Fog on the Barrow-downs", Set = "Fog on the Barrow-downs" };
        public static EncounterSet TheRuinsOfBelegost = new EncounterSet { Name = "The Ruins of Belegost", Set = "The Ruins of Belegost" };
        public static EncounterSet MurderAtThePrancingPony = new EncounterSet { Name = "Murder at the Prancing Pony", Set = "Murder at the Prancing Pony" };
        public static EncounterSet Investigation = new EncounterSet { Name = "Investigation", Set = "Murder at the Prancing Pony" };
        public static EncounterSet TheSiegeOfAnnuminas = new EncounterSet { Name = "The Siege of Annúminas", Set = "The Siege of Annúminas" };
        public static EncounterSet AttackOnDolGuldur = new EncounterSet { Name = "Attack on Dol Guldur", Set = "Attack on Dol Guldur", AlternateName = "Assault on Dol Guldur" };
        public static EncounterSet TheWizardsQuest = new EncounterSet { Name = "The Wizard's Quest", Set = "The Wizard's Quest" };
        public static EncounterSet TheWoodlandRealm = new EncounterSet { Name = "The Woodland Realm", Set = "The Woodland Realm" };
        public static EncounterSet TheMinesOfMoria = new EncounterSet { Name = "The Mines of Moria", Set = "The Mines of Moria" };
        public static EncounterSet EscapeFromKhazadDum = new EncounterSet { Name = "Escape from Khazad-dûm", Set = "Escape from Khazad-dûm" };

        //Scenario Decks
        public static EncounterSet TheHuntForTheDreadnaught = new EncounterSet { Name = "The Hunt for the Dreadnaught", Set = "The Hunt for the Dreadnaught" };
        public static EncounterSet TheOathCampaign = new EncounterSet { Name = "The Oath (Campaign)", Set = "The Dark of Mirkwood" };
        public static EncounterSet TheGoblinsCampaign = new EncounterSet { Name = "The Goblins (Campaign)", Set = "The Dark of Mirkwood" };
        public static EncounterSet TheCavesOfNibinDumCampaign = new EncounterSet { Name = "The Caves of Nibin-Dûm (Campaign)", Set = "The Dark of Mirkwood" };

        //Core Set and Shadows of Mirkwood Nightmare Decks
        public static EncounterSet PassageThroughMirkwoodNightmare = new EncounterSet { Name = "Passage Through Mirkwood Nightmare", Set = "Passage Through Mirkwood Nightmare" };
        public static EncounterSet JourneyAlongTheAnduinNightmare = new EncounterSet { Name = "Journey Along the Anduin Nightmare", Set = "Journey Along the Anduin Nightmare" };
        public static EncounterSet EscapeFromDolGuldurNightmare = new EncounterSet { Name = "Escape from Dol Guldur Nightmare", Set = "Escape from Dol Guldur Nightmare" };
        public static EncounterSet TheHuntForGollumNightmare = new EncounterSet { Name = "The Hunt for Gollum Nightmare", Set = "The Hunt for Gollum Nightmare" };
        public static EncounterSet ConflictAtTheCarrockNightmare = new EncounterSet { Name = "Conflict at the Carrock Nightmare", Set = "Conflict at the Carrock Nightmare" };
        public static EncounterSet AJourneyToRhosgobelNightmare = new EncounterSet { Name = "A Journey to Rhosgobel Nightmare", Set = "A Journey to Rhosgobel Nightmare" };
        public static EncounterSet TheHillsOfEmynMuilNightmare = new EncounterSet { Name = "The Hills of Emyn Muil Nightmare", Set = "The Hills of Emyn Muil Nightmare" };
        public static EncounterSet TheDeadMarshesNightmare = new EncounterSet { Name = "The Dead Marshes Nightmare", Set = "The Dead Marshes Nightmare" };
        public static EncounterSet ReturnToMirkwoodNightmare = new EncounterSet { Name = "Return to Mirkwood Nightmare", Set = "Return to Mirkwood Nightmare" };
        
        //Khazad-dum and Dwarrowdelf Nightmare Decks
        public static EncounterSet IntoThePitNightmare = new EncounterSet { Name = "Into the Pit Nightmare", Set = "Into the Pit Nightmare" };
        public static EncounterSet TheSeventhLevelNightmare = new EncounterSet { Name = "The Seventh Level Nightmare", Set = "The Seventh Level Nightmare" };
        public static EncounterSet FlightFromMoriaNightmare = new EncounterSet { Name = "Flight from Moria Nightmare", Set = "Flight from Moria Nightmare" };
        public static EncounterSet TheRedhornGateNightmare = new EncounterSet { Name = "The Redhorn Gate Nightmare", Set = "The Redhorn Gate Nightmare" };
        public static EncounterSet RoadToRivendellNightmare = new EncounterSet { Name = "Road to Rivendell Nightmare", Set = "Road to Rivendell Nightmare" };
        public static EncounterSet TheWatcherInTheWaterNightmare = new EncounterSet { Name = "The Watcher in the Water Nightmare", Set = "The Watcher in the Water Nightmare" };
        public static EncounterSet TheLongDarkNightmare = new EncounterSet { Name = "The Long Dark Nightmare", Set = "The Long Dark Nightmare" };
        public static EncounterSet FoundationsOfStoneNightmare = new EncounterSet { Name = "Foundations of Stone Nightmare", Set = "Foundations of Stone Nightmare" };
        public static EncounterSet GoblinsOfTheDeepNightmare = new EncounterSet { Name = "Goblins of the Deep Nightmare", Set = "Foundations of Stone Nightmare" };
        public static EncounterSet ShadowAndFlameNightmare = new EncounterSet { Name = "Shadow and Flame Nightmare", Set = "Shadow and Flame Nightmare" };

        //Heirs of Numenor and Against the Shadow Nightmare Decks
        public static EncounterSet PerilInPelargirNightmare = new EncounterSet { Name = "Peril in Pelargir Nightmare", Set = "Peril in Pelargir Nightmare" };
        public static EncounterSet IntoIthilienNightmare = new EncounterSet { Name = "Into Ithilien Nightmare", Set = "Into Ithilien Nightmare" };
        public static EncounterSet TheSiegeOfCairAndrosNightmare = new EncounterSet { Name = "The Siege of Cair Andros Nightmare", Set = "The Siege of Cair Andros Nightmare" };
        public static EncounterSet TheStewardsFearNightmare = new EncounterSet { Name = "The Steward's Fear Nightmare", Set = "The Steward's Fear Nightmare" };
        public static EncounterSet BrigandsNightmare = new EncounterSet { Name = "Brigands Nightmare", Set = "The Steward's Fear Nightmare" };
        public static EncounterSet TheDruadanForestNightmare = new EncounterSet { Name = "The Drúadan Forest Nightmare", Set = "The Drúadan Forest Nightmare", NormalizedSet = "The Druadan Forest Nightmare" };
        public static EncounterSet EncounterAtAmonDinNightmare = new EncounterSet { Name = "Encounter at Amon Dîn Nightmare", Set = "Encounter at Amon Dîn Nightmare", NormalizedSet = "Encounter at Amon Din Nightmare", };
        public static EncounterSet AssaultOnOsgiliathNightmare = new EncounterSet { Name = "Assault on Osgiliath Nightmare", Set = "Assault on Osgiliath Nightmare" };
        public static EncounterSet TheBloodOfGondorNightmare = new EncounterSet { Name = "The Blood of Gondor Nightmare", Set = "The Blood of Gondor Nightmare" };
        public static EncounterSet TheMorgulValeNightmare = new EncounterSet { Name = "The Morgul Vale Nightmare", Set = "The Morgul Vale Nightmare" };

        //The Voice of Isengard and Ring-maker Nightmare Decks
        public static EncounterSet TheFordsOfIsenNightmare = new EncounterSet { Name = "The Fords of Isen Nightmare", Set = "The Fords of Isen Nightmare" };
        public static EncounterSet ToCatchAnOrcNightmare = new EncounterSet { Name = "To Catch an Orc Nightmare", Set = "To Catch an Orc Nightmare" };
        public static EncounterSet IntoFangornNightmare = new EncounterSet { Name = "Into Fangorn Nightmare", Set = "Into Fangorn Nightmare" };
        public static EncounterSet TheDunlandTrapNightmare = new EncounterSet { Name = "The Dunland Trap Nightmare", Set = "The Dunland Trap Nightmare" };
        public static EncounterSet TheThreeTrialsNightmare = new EncounterSet { Name = "The Three Trials Nightmare", Set = "The Three Trials Nightmare" };
        public static EncounterSet TroubleInTharbadNightmare = new EncounterSet { Name = "Trouble in Tharbad Nightmare", Set = "Trouble in Tharbad Nightmare" };
        public static EncounterSet TheNinInEilphNightmare = new EncounterSet { Name = "The Nîn-in-Eilph Nightmare", Set = "The Nîn-in-Eilph Nightmare", NormalizedSet = "The Nin-in-Eilph Nightmare" };
        public static EncounterSet CelebrimborsSecretNightmare = new EncounterSet { Name = "Celebrimbor's Secret Nightmare", Set = "Celebrimbor's Secret Nightmare" };
        public static EncounterSet TheAntleredCrownNightmare = new EncounterSet { Name = "The Antlered Crown Nightmare", Set = "The Antlered Crown Nightmare" };

        //The Lost Realm and Angmar Awakened Nightmare Decks
        public static EncounterSet IntrudersInChetwoodNightmare = new EncounterSet { Name = "Intruders in Chetwood Nightmare", Set = "Intruders in Chetwood Nightmare" };
        public static EncounterSet TheWeatherHillsNightmare = new EncounterSet { Name = "The Weather Hills Nightmare", Set = "The Weather Hills Nightmare" };
        public static EncounterSet DeadmensDikeNightmare = new EncounterSet { Name = "Deadmen's Dike Nightmare", Set = "Deadmen's Dike Nightmare" };
        public static EncounterSet TheWastesOfEriadorNightmare = new EncounterSet { Name = "The Wastes of Eriador Nightmare", Set = "The Wastes of Eriador Nightmare" };
        public static EncounterSet EscapeFromMountGramNightmare = new EncounterSet { Name = "Escape from Mount Gram Nightmare", Set = "Escape from Mount Gram Nightmare" };
        public static EncounterSet AngmarOrcsNightmare = new EncounterSet { Name = "Angmar Orcs Nightmare", Set = "Escape from Mount Gram Nightmare" };
        public static EncounterSet AcrossTheEttenmoorsNightmare = new EncounterSet { Name = "Across the Ettenmoors Nightmare", Set = "Across the Ettenmoors Nightmare" };
        public static EncounterSet TheTreacheryOfRhudaurNightmare = new EncounterSet { Name = "The Treachery of Rhudaur Nightmare", Set = "The Treachery of Rhudaur Nightmare" };
        public static EncounterSet DecipherAncientTexts = new EncounterSet { Name = "Decipher Ancient Texts", Set = "The Treachery of Rhudaur" };
        public static EncounterSet SiftThroughTheDebris = new EncounterSet { Name = "Sift through the Debris", Set = "The Treachery of Rhudaur" };
        public static EncounterSet QuietTheSpirits = new EncounterSet { Name = "Quiet the Spirits", Set = "The Treachery of Rhudaur" };
        public static EncounterSet TheBattleOfCarnDumNightmare = new EncounterSet { Name = "The Battle of Carn Dûm Nightmare", Set = "The Battle of Carn Dûm Nightmare" };
        public static EncounterSet TheDreadRealmNightmare = new EncounterSet { Name = "The Dread Realm Nightmare", Set = "The Dread Realm Nightmare" };

        //The Grey Havens and Dream-chaser Nightmare Decks
        public static EncounterSet VoyageAcrossBelegaerNightmare = new EncounterSet { Name = "Voyage Across Belegaer Nightmare", Set = "Voyage Across Belegaer Nightmare" };
        public static EncounterSet TheFateOfNumenorNightmare = new EncounterSet { Name = "The Fate of Númenor Nightmare", Set = "The Fate of Númenor Nightmare" };
        public static EncounterSet RaidOnTheGreyHavensNightmare = new EncounterSet { Name = "Raid on the Grey Havens Nightmare", Set = "Raid on the Grey Havens Nightmare" };
        public static EncounterSet FlightOfTheStormcallerNightmare = new EncounterSet { Name = "Flight of the Stormcaller Nightmare", Set = "Flight of the Stormcaller Nightmare" };
        public static EncounterSet TheThingInTheDepthsNightmare = new EncounterSet { Name = "The Thing in the Depths Nightmare", Set = "The Thing in the Depths Nightmare" };
        public static EncounterSet TheStormcallerNightmare = new EncounterSet { Name = "The Stormcaller Nightmare", Set = "The Thing in the Depths Nightmare" };
        public static EncounterSet CorsairRaidersNightmare = new EncounterSet { Name = "Corsair Raiders Nightmare", Set = "The Thing in the Depths Nightmare" };
        public static EncounterSet TempleOfTheDeceivedNightmare = new EncounterSet { Name = "Temple of the Deceived Nightmare", Set = "Temple of the Deceived Nightmare" };
        public static EncounterSet TheDrownedRuinsNightmare = new EncounterSet { Name = "The Drowned Ruins Nightmare", Set = "The Drowned Ruins Nightmare" };
        public static EncounterSet AStormOnCobasHavenNightmare = new EncounterSet { Name = "A Storm on Cobas Haven Nightmare", Set = "A Storm on Cobas Haven Nightmare" };
        public static EncounterSet TheCityOfCorsairsNightmare = new EncounterSet { Name = "The City of Corsairs Nightmare", Set = "The City of Corsairs Nightmare" };
        public static EncounterSet CoastOfUmbarNightmare = new EncounterSet { Name = "Coast of Umbar Nightmare", Set = "The City of Corsairs Nightmare" };

        //The Hobbit: Over Hill and Under Hill Nightmare Decks
        public static EncounterSet WeMustAwayEreBreakOfDayNightmare = new EncounterSet { Name = "We Must Away, Ere Break of Day Nightmare", Set = "We Must Away, Ere Break of Day Nightmare" };
        public static EncounterSet OverTheMistyMountainsGrimNightmare = new EncounterSet { Name = "Over the Misty Mountains Grim Nightmare", Set = "Over the Misty Mountains Grim Nightmare" };
        public static EncounterSet TheGreatGoblinNightmare = new EncounterSet { Name = "The Great Goblin Nightmare", Set = "Over the Misty Mountains Grim Nightmare" };
        public static EncounterSet DungeonsDeepAndCavernsDimNightmare = new EncounterSet { Name = "Dungeons Deep and Caverns Dim Nightmare", Set = "Dungeons Deep and Caverns Dim Nightmare" };
        
        //The Hobbit: On the Doorstep Nightmare Decks
        public static EncounterSet FliesAndSpidersNightmare = new EncounterSet { Name = "Flies and Spiders Nightmare", Set = "Flies and Spiders Nightmare" };
        public static EncounterSet TheLonelyMountainNightmare = new EncounterSet { Name = "The Lonely Mountain Nightmare", Set = "The Lonely Mountain Nightmare" };
        public static EncounterSet TheBattleOfFiveArmiesNightmare = new EncounterSet { Name = "The Battle of Five Armies Nightmare", Set = "The Battle of Five Armies Nightmare" };
        
        //The Lord of the Rings: The Black Riders Nightmare Decks
        public static EncounterSet AShadowOfThePastNightmare = new EncounterSet { Name = "A Shadow of the Past Nightmare", Set = "A Shadow of the Past Nightmare" };
        public static EncounterSet AKnifeInTheDarkNightmare = new EncounterSet { Name = "A Knife in the Dark Nightmare", Set = "A Knife in the Dark Nightmare" };
        public static EncounterSet FlightToTheFordNightmare = new EncounterSet { Name = "Flight to the Ford Nightmare", Set = "Flight to the Ford Nightmare" };

        //The Lord of the Rings: The Road Darkens Nightmare Decks
        public static EncounterSet TheRingGoesSouthNightmare = new EncounterSet { Name = "The Ring Goes South Nightmare", Set = "The Ring Goes South Nightmare" };
        public static EncounterSet JourneyInTheDarkNightmare = new EncounterSet { Name = "Journey in the Dark Nightmare", Set = "Journey in the Dark Nightmare" };
        public static EncounterSet BreakingOfTheFellowshipNightmare = new EncounterSet { Name = "Breaking of the Fellowship Nightmare", Set = "Breaking of the Fellowship Nightmare" };

        //The Lord of the Rings: The Treason of Saruman Nightmare Decks
        public static EncounterSet TheUrukHaiNightmare = new EncounterSet { Name = "The Uruk-hai Nightmare", Set = "The Uruk-hai Nightmare" };
        public static EncounterSet HelmsDeepNightmare = new EncounterSet { Name = "Helm's Deep Nightmare", Set = "Helm's Deep Nightmare" };
        public static EncounterSet TheRoadToIsengardNightmare = new EncounterSet { Name = "The Road to Isengard Nightmare", Set = "The Road to Isengard Nightmare" };

        //The Lord of the Rings: The Land of Shadow Nightmare Decks
        public static EncounterSet ThePassageOfTheMarshesNightmare = new EncounterSet { Name = "The Passage of the Marshes Nightmare", Set = "The Passage of the Marshes Nightmare" };
        public static EncounterSet JourneyToTheCrossRoadsNightmare = new EncounterSet { Name = "Journey to the Cross-roads Nightmare", Set = "Journey to the Cross-roads Nightmare" };
        public static EncounterSet ShelobsLairNightmare = new EncounterSet { Name = "Shelob's Lair Nightmare", Set = "Shelob's Lair Nightmare" };

        //First Age and Doom Mastered
        public static EncounterSet HuntingOfTheWolf = new EncounterSet { Name = "Hunting of the Wolf", Set = "First Age" };
        public static EncounterSet TheIsleOfWerewolves = new EncounterSet { Name = "The Isle of Werewolves", Set = "First Age" };
        public static EncounterSet TheSeatOfMorgoth = new EncounterSet { Name = "The Seat of Morgoth", Set = "First Age" };
        public static EncounterSet TrialUponTheMarches = new EncounterSet { Name = "Trial Upon the Marches", Set = "Trial Upon the Marches" };
        public static EncounterSet AmongTheOutlaws = new EncounterSet { Name = "Among the Outlaws", Set = "Among the Outlaws" };
        public static EncounterSet TheBetrayalOfMim = new EncounterSet { Name = "The Betrayal of Mîm", Set = "The Betrayal of Mîm" };
        public static EncounterSet TheFallOfNargothrond = new EncounterSet { Name = "The Fall of Nargothrond", Set = "The Fall of Nargothrond" };

        //ALeP Children of Eorl
        public static EncounterSet AmbushAtErelas = new EncounterSet { Name = "Ambush at Erelas", Set = "Children of Eorl" };
        public static EncounterSet RohanWeather = new EncounterSet { Name = "Rohan Weather", Set = "Children of Eorl" };
        public static EncounterSet RohanEncampment = new EncounterSet { Name = "Rohan Encampment", Set = "Children of Eorl" };
        public static EncounterSet TheBattleForTheBeacon = new EncounterSet { Name = "The Battle for the Beacon", Set = "Children of Eorl" };
        public static EncounterSet DunlendingWarriors = new EncounterSet { Name = "Dunlending Warriors", Set = "Children of Eorl" };
        public static EncounterSet FaithlessRohirrim = new EncounterSet { Name = "Faithless Rohirrim", Set = "Children of Eorl" };
        public static EncounterSet TheHorseLordsIre = new EncounterSet { Name = "The Horse Lord's Ire", Set = "Children of Eorl" };
        public static EncounterSet OrcHost = new EncounterSet { Name = "Orc-host", Set = "Children of Eorl" };
        public static EncounterSet RohanLands = new EncounterSet { Name = "Rohan Lands", Set = "Children of Eorl" };

        public static EncounterSet TheAldburgPlot = new EncounterSet { Name = "The Aldburg Plot", Set = "The Aldburg Plot" };
        public static EncounterSet FireOnTheEastemnet = new EncounterSet { Name = "Fire on the Eastemnet", Set = "Fire on the Eastemnet" };
        public static EncounterSet TheGapOfRohan = new EncounterSet { Name = "The Gap of Rohan", Set = "The Gap of Rohan" };
        public static EncounterSet TheGlitteringCaves = new EncounterSet { Name = "The Glittering Caves", Set = "The Glittering Caves" };
        public static EncounterSet SearchForTheHorn = new EncounterSet { Name = "Search for the Horn", Set = "The Glittering Caves" };
        public static EncounterSet ExploringTheCaves = new EncounterSet { Name = "Exploring the Caves", Set = "The Glittering Caves" };
        public static EncounterSet MusteringOfTheRohirrim = new EncounterSet { Name = "Mustering of the Rohirrim", Set = "Mustering of the Rohirrim" };
        public static EncounterSet BloodInTheIsen = new EncounterSet { Name = "Blood in the Isen", Set = "Blood in the Isen" };

        public static EncounterSet TheScouringOfTheShire = new EncounterSet { Name = "The Scouring of the Shire", Set = "The Scouring of the Shire" };
        public static EncounterSet TheNineAreAbroad = new EncounterSet { Name = "The Nine are Abroad", Set = "The Nine are Abroad" };
        public static EncounterSet Region = new EncounterSet { Name = "Region", Set = "The Nine are Abroad" };

        public static EncounterSet TheSiegeOfErebor = new EncounterSet { Name = "The Siege of Erebor", Set = "The Siege of Erebor" };
    }
}