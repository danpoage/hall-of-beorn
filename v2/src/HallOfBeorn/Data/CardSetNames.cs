using System;
using System.Collections.Generic;

namespace HallOfBeorn.Data
{
    public static class CardSetNames
    {
        public static IReadOnlyList<string> All()
        {
            return new List<string>
            {
                CoreSet,
                TheHuntForGollum,
                ConflictAtTheCarrock,
                AJourneyToRhosgobel,
                TheHillsOfEmynMuil,
                TheDeadMarshes,
                ReturnToMirkwood,
                KhazadDum,
                TheRedhornGate,
                RoadToRivendell,
                TheWatcherInTheWater,
                TheLongDark,
                FoundationsOfStone,
                ShadowAndFlame,
                HeirsOfNumenor,
                TheStewardsFear,
                TheDruadanForest,
                EncounterAtAmonDin,
                AssaultOnOsgiliath,
                TheBloodOfGondor,
                TheMorgulVale,
                TheVoiceOfIsengard,
                TheDunlandTrap,
                TheThreeTials,
                TroubleInTharbad,
                TheNinInEilph,
                CelebrimborsSecret,
                TheAntleredCrown,
                TheLostRealm,
                TheWastesOfEriador,
                EscapeFromMountGram,
                AcrossTheEttenmoors,
                TheTreacheryOfRhudaur,
                TheBattleOfCarnDum,
                TheDreadRealm,
                TheGreyHavens,
                FlightOfTheStormcaller,
                TheThingInTheDepths,
                TempleOfTheDeceived,
                TheDrownedRuines,
                AStormOnCobasHaven,
                TheCityOfCorsairs,
                TheSandsOfHarad,
                TheMumakil,
                RaceAcrossHarad,
                BeneathTheSands,
                TheBlackSerpent,
                TheDungeonsOfCirithGurat,
                TheCrossingsOfPoros,
                TheWildsOfRhovanion,
                TheWitheredHeath,
                RoamAcrossRhovanion,
                FireInTheNight,
                TheGhostOfFramsburg,
                MountGundabad,
                TheFateOfWilderland,
                AShadowInTheEast,
                WrathAndRuin,
                WrathAndRuinPreorderPromotion,
                TheCityOfUlfast,
                TheCityOfUlfastPreorderPromotion,
                ChallengeOfTheWainriders,
                ChallengeOfTheWainridersPreorderPromotion,
                UnderTheAshMountains,
                UnderTheAshMountainsPreorderPromotion,
                TheLandOfSorrow,
                TheLandOfSorrowPreorderPromotion,
                TheFortressOfNurn,
                TheFortressOfNurnPreorderPromotion,
                TheHobbitOverHillAndUnderHill,
                TheHobbitOnTheDoorstep,
                TheBlackRiders,
                TheRoadDarkens,
                TheTreasonOfSaruman,
                TheLandOfShadow,
                TheFlameOfTheWest,
                TheMountainOfFire,
                TwoPlayerLimitedEditionStarter,
                TheMassingAtOsgiliath,
                TheBattleOfLakeTown,
                TheStoneOfErech,
                TheOldForest,
                FogOnTheBarrowDowns,
                TheRuinsOfBelegost,
                MurderAtThePrancingPony,
                TheSiegeOfAnnuminas,
                AttackOnDolGuldur,
                TheWizardsQuest,
                TheWoodlandRealm,
                TheMinesOfMoria,
                TheMinesOfMoriaPreorderPromotion,
                EscapeFromKhazadDum,
                EscapeFromKhazadDumPreorderPromotion,

                PassageThroughMirkwoodNightmare,
                JourneyAlongTheAnduinNightmare,
                EscapeFromDolGuldurNightmare,
                TheHuntForGollumNightmare,
                ConflictAtTheCarrockNightmare,
                AJourneyToRhosgobelNightmare,
                TheHillsOfTheEmynMuilNightmare,
                TheDeadMarshesNightmare,
                ReturnToMirkwoodNightmare,

                IntoThePitNightmare,
                TheSeventhLevelNightmare,
                FlightFromMoriaNightmare,
                TheRedhornGateNightmare,
                RoadToRivendellNightmare,
                TheWatcherInTheWaterNightmare,
                TheLongDarkNightmare,
                FoundationsOfStoneNightmare,
                ShadowAndFlameNightmare,

                PerilInPelargirNightmare,
                IntoIthilienNightmare,
                TheSiegeOfCairAndrosNightmare,
                TheStewardsFearNightmare,
                TheDruadanForestNightmare,
                EncounterAtAmonDinNightmare,
                AssaultOnOsgiliathNightmare,
                TheBloodOfGondorNightmare,
                TheMorgulValeNightmare,

                TheFordsOfIsenNightmare,
                ToCatchAnOrcNightmare,
                IntoFangornNightmare,
                TheDunlandTrapNightmare,
                TheThreeTialsNightmare,
                TroubleInTharbadNightmare,
                TheNinInEilphNightmare,
                CelebrimborsSecretNightmare,
                TheAntleredCrownNightmare,

                IntrudersInChetwoodNightmare,
                TheWeatherHillsNightmare,
                DeadmansDikeNightmare,
                TheWastesOfEriadorNightmare,
                EscapeFromMountGramNightmare,
                AcrossTheEttenmoorsNightmare,
                TheTreacheryOfRhudaurNightmare,
                TheBattleOfCarnDumNightmare,
                TheDreadRealmNightmare,

                VoyageAcrossBelegaerNightmare,
                TheFateOfNumenorNightmare,
                RaidOnTheGreyHavensNightmare,
                FlightOfTheStormcallerNightmare,
                TheThingInTheDepthsNightmare,
                TempleOfTheDeceivedNightmare,
                TheDrownedRuinesNightmare,
                AStormOnCobasHavenNightmare,
                TheCityOfCorsairsNightmare,

                WeMustAwayEreBreakOfDayNightmare,
                OverTheMistyMountainsGrimNightmare,
                DungeonsDeepAndCavernsDimNightmare,

                FliesAndSpidersNightmare,
                TheLonelyMountainNightmare,
                TheBattleOfFiveArmiesNightmare,
                
                AShadowOfThePastNightmare,
                AKnifeInTheDarkNightmare,
                FlightToTheFordNightmare,
                
                TheRingGoesSouthNightmare,
                JourneyInTheDarkNightmare,
                BreakingTheFellowshipNightmare,

                TheUrukHaiNightmare,
                HelmsDeepNightmare,
                TheRoadToIsengardNightmare,

                ThePassageOfTheMarshesNightmare,
                JourneyInTheDarkNightmare,
                ShelobLairNightmare,

                FirstAge,
                TrialUponTheMarches,
                AmongTheOutlaws,
            };
        }

        public const string CoreSet = "Core Set";
        public const string TheHuntForGollum = "The Hunt for Gollum";
        public const string ConflictAtTheCarrock = "Conflict at the Carrock";
        public const string AJourneyToRhosgobel = "A Journey to Rhosgobel";
        public const string TheHillsOfEmynMuil = "The Hills of Emyn Muil";
        public const string TheDeadMarshes = "The Dead Marshes";
        public const string ReturnToMirkwood = "Return to Mirkwood";

        public const string KhazadDum = "Khazad-dûm";
        public const string TheRedhornGate = "The Redhorn Gate";
        public const string RoadToRivendell = "Road to Rivendell";
        public const string TheWatcherInTheWater = "The Watcher in the Water";
        public const string TheLongDark = "The Long Dark";
        public const string FoundationsOfStone = "Foundations of Stone";
        public const string ShadowAndFlame = "Shadow and Flame";

        public const string HeirsOfNumenor = "Heirs of Númenor";
        public const string TheStewardsFear = "The Steward's Fear";
        public const string TheDruadanForest = "The Drúadan Forest";
        public const string EncounterAtAmonDin = "Encounter at Amon Dîn";
        public const string AssaultOnOsgiliath = "Assault on Osgiliath";
        public const string TheBloodOfGondor = "The Blood of Gondor";
        public const string TheMorgulVale = "The Morgul Vale";

        public const string TheVoiceOfIsengard = "The Voice of Isengard";
        public const string TheDunlandTrap = "The Dunland Trap";
        public const string TheThreeTials = "The Three Trials";
        public const string TroubleInTharbad = "Trouble in Tharbad";
        public const string TheNinInEilph = "The Nîn-in-Eilph";
        public const string CelebrimborsSecret = "Celebrimbor's Secret";
        public const string TheAntleredCrown = "The Antlered Crown";

        public const string TheLostRealm = "The Lost Realm";
        public const string TheWastesOfEriador = "The Wastes of Eriador";
        public const string EscapeFromMountGram = "Escape from Mount Gram";
        public const string AcrossTheEttenmoors = "Across the Ettenmoors";
        public const string TheTreacheryOfRhudaur = "The Treachery of Rhudaur";
        public const string TheBattleOfCarnDum = "The Battle of Carn Dûm";
        public const string TheDreadRealm = "The Dread Realm";

        public const string TheGreyHavens = "The Grey Havens";
        public const string FlightOfTheStormcaller = "Flight of the Stormcaller";
        public const string TheThingInTheDepths = "The Thing in the Depths";
        public const string TempleOfTheDeceived = "Temple of the Deceived";
        public const string TheDrownedRuines = "The Drowned Ruins";
        public const string AStormOnCobasHaven = "A Storm on Cobas Haven";
        public const string TheCityOfCorsairs = "The City of Corsairs";

        public const string TheSandsOfHarad = "The Sands of Harad";
        public const string TheMumakil = "The Mûmakil";
        public const string RaceAcrossHarad = "Race Across Harad";
        public const string BeneathTheSands = "Beneath the Sands";
        public const string TheBlackSerpent = "The Black Serpent";
        public const string TheDungeonsOfCirithGurat = "The Dungeons of Cirith Gurat";
        public const string TheCrossingsOfPoros = "The Crossings of Poros";

        public const string TheWildsOfRhovanion = "The Wilds of Rhovanion";
        public const string TheWitheredHeath = "The Withered Heath";
        public const string RoamAcrossRhovanion = "Roam Across Rhovanion";
        public const string FireInTheNight = "Fire in the Night";
        public const string TheGhostOfFramsburg = "The Ghost of Framsburg";
        public const string MountGundabad = "Mount Gundabad";
        public const string TheFateOfWilderland = "The Fate of Wilderland";

        public const string AShadowInTheEast = "A Shadow in the East";
        public const string WrathAndRuin = "Wrath and Ruin";
        public const string WrathAndRuinPreorderPromotion = "Wrath and Ruin Preorder Promotion";
        public const string TheCityOfUlfast = "The City of Ulfast";
        public const string TheCityOfUlfastPreorderPromotion = "The City of Ulfast Preorder Promotion";
        public const string ChallengeOfTheWainriders = "Challenge of the Wainriders";
        public const string ChallengeOfTheWainridersPreorderPromotion = "Challenge of the Wainriders Preorder Promotion";
        public const string UnderTheAshMountains = "Under the Ash Mountains";
        public const string UnderTheAshMountainsPreorderPromotion = "Under the Ash Mountains Preorder Promotion";
        public const string TheLandOfSorrow = "The Land of Sorrow";
        public const string TheLandOfSorrowPreorderPromotion = "The Land of Sorrow Preorder Promotion";
        public const string TheFortressOfNurn = "The Fortress of Nurn";
        public const string TheFortressOfNurnPreorderPromotion = "The Fortress of Nurn Preorder Promotion";

        public const string TheHobbitOverHillAndUnderHill = "The Hobbit: Over Hill and Under Hill";
        public const string TheHobbitOnTheDoorstep = "The Hobbit: On the Doorstep";

        public const string TheBlackRiders = "The Black Riders";
        public const string TheRoadDarkens = "The Road Darkens";
        public const string TheTreasonOfSaruman = "The Treason of Saruman";
        public const string TheLandOfShadow = "The Land of Shadow";
        public const string TheFlameOfTheWest = "The Flame of the West";
        public const string TheMountainOfFire = "The Mountain of Fire";

        public const string TwoPlayerLimitedEditionStarter = "Two-Player Limited Edition Starter";

        public const string TheMassingAtOsgiliath = "The Massing at Osgiliath";
        public const string TheBattleOfLakeTown = "The Battle of Lake-town";
        public const string TheStoneOfErech = "The Stone of Erech";
        public const string TheOldForest = "The Old Forest";
        public const string FogOnTheBarrowDowns = "Fog on the Barrow-downs";
        public const string TheRuinsOfBelegost = "The Ruins of Belegost";
        public const string MurderAtThePrancingPony = "Murder at the Prancing Pony";
        public const string TheSiegeOfAnnuminas = "The Siege of Annúminas";
        public const string AttackOnDolGuldur = "Attack on Dol Guldur";
        public const string TheWizardsQuest = "The Wizard's Quest";
        public const string TheWoodlandRealm = "The Woodland Realm";
        public const string TheMinesOfMoria = "The Mines of Moria";
        public const string TheMinesOfMoriaPreorderPromotion = "The Mines of Moria Preorder Promotion";
        public const string EscapeFromKhazadDum = "Escape from Khazad-dûm";
        public const string EscapeFromKhazadDumPreorderPromotion = "Escape from Khazad-dûm Preorder Promotion";

        public const string PassageThroughMirkwoodNightmare = "Passage Through Mirkwood Nightmare";
        public const string JourneyAlongTheAnduinNightmare = "Journey Along the AnduinNightmare";
        public const string EscapeFromDolGuldurNightmare = "Escape from Dol Guldur Nightmare";
        public const string TheHuntForGollumNightmare = "The Hunt for Gollum Nightmare";
        public const string ConflictAtTheCarrockNightmare = "Conflict at the Carrock Nightmare";
        public const string AJourneyToRhosgobelNightmare = "A Journey to Rhosgobel Nightmare";
        public const string TheHillsOfTheEmynMuilNightmare = "The Hills of Emyn Muil Nightmare";
        public const string TheDeadMarshesNightmare = "The Dead Marshes Nightmare";
        public const string ReturnToMirkwoodNightmare = "Return to Mirkwood Nightmare";

        public const string IntoThePitNightmare = "Into the Pit Nightmare";
        public const string TheSeventhLevelNightmare = "The Seventh Level Nightmare";
        public const string FlightFromMoriaNightmare = "Flight from Moria Nightmare Decks";
        public const string TheRedhornGateNightmare = "The Redhorn Gate Nightmare";
        public const string RoadToRivendellNightmare = "Road to Rivendell Nightmare";
        public const string TheWatcherInTheWaterNightmare = "The Watcher in the Water Nightmare";
        public const string TheLongDarkNightmare = "The Long Dark Nightmare";
        public const string FoundationsOfStoneNightmare = "Foundations of Stone Nightmare";
        public const string ShadowAndFlameNightmare = "Shadow and Flame Nightmare";

        public const string PerilInPelargirNightmare = "Peril in Pelargir Nightmare";
        public const string IntoIthilienNightmare = "Into Ithilien Nightmare";
        public const string TheSiegeOfCairAndrosNightmare = "The Siege of Cair Andros Nightmare";
        public const string TheStewardsFearNightmare = "The Steward's Fear Nightmare";
        public const string TheDruadanForestNightmare = "The Drúadan Forest Nightmare";
        public const string EncounterAtAmonDinNightmare = "Encounter at Amon Dîn Nightmare";
        public const string AssaultOnOsgiliathNightmare = "Assault on Osgiliath Nightmare";
        public const string TheBloodOfGondorNightmare = "The Blood of Gondor Nightmare";
        public const string TheMorgulValeNightmare = "The Morgul Vale Nightmare";

        public const string TheFordsOfIsenNightmare = "The Fords of Isen Nightmare";
        public const string ToCatchAnOrcNightmare = "To Catch an Orc Nightmare";
        public const string IntoFangornNightmare = "Into Fangorn Nightmare";
        public const string TheDunlandTrapNightmare = "The Dunland Trap Nightmare";
        public const string TheThreeTialsNightmare = "The Three Trials Nightmare";
        public const string TroubleInTharbadNightmare = "Trouble in Tharbad Nightmare";
        public const string TheNinInEilphNightmare = "The Nîn-in-Eilph Nightmare";
        public const string CelebrimborsSecretNightmare = "Celebrimbor's Secret Nightmare";
        public const string TheAntleredCrownNightmare = "The Antlered Crown Nightmare";

        public const string IntrudersInChetwoodNightmare = "Intruders in Chetwood Nightmare";
        public const string TheWeatherHillsNightmare = "The Weater Hills Nightmare";
        public const string DeadmansDikeNightmare = "Deadman's Dike Nightmare";
        public const string TheWastesOfEriadorNightmare = "The Wastes of Eriador Nightmare";
        public const string EscapeFromMountGramNightmare = "Escape from Mount Gram Nightmare";
        public const string AcrossTheEttenmoorsNightmare = "Across the Ettenmoors Nightmare";
        public const string TheTreacheryOfRhudaurNightmare = "The Treachery of Rhudaur Nightmare";
        public const string TheBattleOfCarnDumNightmare = "The Battle of Carn Dûm Nightmare";
        public const string TheDreadRealmNightmare = "The Dread Realm Nightmare";

        public const string VoyageAcrossBelegaerNightmare = "Voyage Across Belegaer Nightmare";
        public const string TheFateOfNumenorNightmare = "The Fate of Númenor Nightmare";
        public const string RaidOnTheGreyHavensNightmare = "Raid on the Grey Havens Nightmare";
        public const string FlightOfTheStormcallerNightmare = "Flight of the Stormcaller Nightmare";
        public const string TheThingInTheDepthsNightmare = "The Thing in the Depths Nightmare";
        public const string TempleOfTheDeceivedNightmare = "Temple of the Deceived Nightmare";
        public const string TheDrownedRuinesNightmare = "The Drowned Ruins Nightmare";
        public const string AStormOnCobasHavenNightmare = "A Storm on Cobas Haven Nightmare";
        public const string TheCityOfCorsairsNightmare = "The City of Corsairs Nightmare";

        public const string WeMustAwayEreBreakOfDayNightmare = "We Must Away Ere Break of Day Nightmare";
        public const string OverTheMistyMountainsGrimNightmare = "Over the Misty Mountains Grim Nightmare";
        public const string DungeonsDeepAndCavernsDimNightmare = "Dungeons Deep and Caverns Dim Nightmare";
        public const string FliesAndSpidersNightmare = "Flies and Spiders Nightmare";
        public const string TheLonelyMountainNightmare = "The Lonely Mountain Nightmare";
        public const string TheBattleOfFiveArmiesNightmare = "The Battle of Five Armies Nightmare";
        
        public const string AShadowOfThePastNightmare = "A Shadow of the Past Nightmare";
        public const string AKnifeInTheDarkNightmare = "A Knife in the Dark Nightmare";
        public const string FlightToTheFordNightmare = "Flight to the Ford Nightmare";

        public const string TheRingGoesSouthNightmare = "The Ring Goes South Nightmare";
        public const string JourneyInTheDarkNightmare = "Journey in the Dark Nightmare";
        public const string BreakingTheFellowshipNightmare = "Breaking the Fellowship Nightmare";

        public const string TheUrukHaiNightmare = "The Uruk-hai Nightmare";
        public const string HelmsDeepNightmare = "Helm's Deep Nightmare";
        public const string TheRoadToIsengardNightmare = "The Road to Isengard Nightmare";

        public const string ThePassageOfTheMarshesNightmare = "The Passage of the Marshes Nightmare";
        public const string JourneyToTheCrossRoadsNightmare = "Journey to the Cross-roads Nightmare";
        public const string ShelobLairNightmare = "Shelob's Lair Nightmare";

        public const string FirstAge = "First Age";
        public const string TrialUponTheMarches = "Trial Upon the Marches";
        public const string AmongTheOutlaws = "Among the Outlaws";
    }
}
