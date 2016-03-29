using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class EncounterSet
    {
        public EncounterSet()
        {
            AlternateName = string.Empty;
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
            get { return !string.IsNullOrEmpty(Name) && Name.EndsWith(" Nightmare"); }
        }

        private static List<EncounterSet> all = new List<EncounterSet>();

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

            //Gen Con and Fellowship Decks
            Add(TheMassingAtOsgiliath);
            Add(TheBattleOfLakeTown);
            Add(TheStoneOfErech);
            Add(TheOldForest);
            Add(FogOnTheBarrowDowns);
            Add(TheRuinsOfBelegost);
            Add(MurderAtThePrancingPony);
            Add(Investigation);

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
            Add(TheDruadanForestNightmare);
            Add(EncounterAtAmonDinNightmare);
            Add(AssaultOnOsgiliathNightmare);
            Add(TheBloodOfGondorNightmare);
            Add(TheMorgulValeNightmare);

            //The Voice of Isengard and Ring-maker Nightmare Decks
            Add(TheFordsOfIsenNightmare);
            Add(ToCatchAnOrcNightmare);
            Add(IntoFangornNightmare);

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

            //First Age
            Add(HuntingOfTheWolf);
            Add(TheIsleOfWerewolves);
            Add(TheSeatOfMorgoth);
            Add(TrialUponTheMarches);
            Add(AmongTheOutlaws);
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
        public static EncounterSet TheFordsOfIsen = new EncounterSet { Name = "The Fords of Isen", Set = "Voice of Isengard" };
        public static EncounterSet DunlandWarriors = new EncounterSet { Name = "Dunland Warriors", Set = "Voice of Isengard" };
        public static EncounterSet DunlandRaiders = new EncounterSet { Name = "Dunland Raiders", Set = "Voice of Isengard" };
        public static EncounterSet ToCatchAnOrc = new EncounterSet { Name = "To Catch an Orc", Set = "Voice of Isengard" };
        public static EncounterSet MistyMountainOrcs = new EncounterSet { Name = "Misty Mountain Orcs", Set = "Voice of Isengard" };
        public static EncounterSet BrokenLands = new EncounterSet { Name = "Broken Lands", Set = "Voice of Isengard" };
        public static EncounterSet IntoFangorn = new EncounterSet { Name = "Into Fangorn", Set = "Voice of Isengard" };
        public static EncounterSet AncientForest = new EncounterSet { Name = "Ancient Forest", Set = "Voice of Isengard" };
        public static EncounterSet WearyTravelers = new EncounterSet { Name = "Weary Travelers", Set = "Voice of Isengard" };
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

        //Gen Con and Fellowship Decks
        public static EncounterSet TheMassingAtOsgiliath = new EncounterSet { Name = "The Massing at Osgiliath", Set = "The Massing at Osgiliath" };
        public static EncounterSet TheBattleOfLakeTown = new EncounterSet { Name = "The Battle of Lake-town", Set = "The Battle of Lake-town" };
        public static EncounterSet TheStoneOfErech = new EncounterSet { Name = "The Stone of Erech", Set = "The Stone of Erech" };
        public static EncounterSet TheOldForest = new EncounterSet { Name = "The Old Forest", Set = "The Old Forest" };
        public static EncounterSet FogOnTheBarrowDowns = new EncounterSet { Name = "Fog on the Barrow-downs", Set = "Fog on the Barrow-downs" };
        public static EncounterSet TheRuinsOfBelegost = new EncounterSet { Name = "The Ruins of Belegost", Set = "The Ruins of Belegost" };
        public static EncounterSet MurderAtThePrancingPony = new EncounterSet { Name = "Murder at the Prancing Pony", Set = "Murder at the Prancing Pony" };
        public static EncounterSet Investigation = new EncounterSet { Name = "Investigation", Set = "Murder at the Prancing Pony" };

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

        //First Age
        public static EncounterSet HuntingOfTheWolf = new EncounterSet { Name = "Hunting of the Wolf", Set = "First Age" };
        public static EncounterSet TheIsleOfWerewolves = new EncounterSet { Name = "The Isle of Werewolves", Set = "First Age" };
        public static EncounterSet TheSeatOfMorgoth = new EncounterSet { Name = "The Seat of Morgoth", Set = "First Age" };
        public static EncounterSet TrialUponTheMarches = new EncounterSet { Name = "Trial Upon the Marches", Set = "Trial Upon the Marches" };
        public static EncounterSet AmongTheOutlaws = new EncounterSet { Name = "Among the Outlaws", Set = "Among the Outlaws" };
    }
}