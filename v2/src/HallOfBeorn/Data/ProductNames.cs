using System;
using System.Collections.Generic;

namespace HallOfBeorn.Data
{
    public static class ProductNames
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

                PassageThroughMirkwoodNightmareDeck,
                JourneyAlongTheAnduinNightmareDeck,
                EscapeFromDolGuldurNightmareDeck,
                TheHuntForGollumNightmareDeck,
                ConflictAtTheCarrockNightmareDeck,
                AJourneyToRhosgobelNightmareDeck,
                TheHillsOfTheEmynMuilNightmareDeck,
                TheDeadMarshesNightmareDeck,
                ReturnToMirkwoodNightmareDeck,

                KhazadDumNightmareDecks,
                TheRedhornGateNightmareDeck,
                RoadToRivendellNightmareDeck,
                TheWatcherInTheWaterNightmareDeck,
                TheLongDarkNightmareDeck,
                FoundationsOfStoneNightmareDeck,
                ShadowAndFlameNightmareDeck,

                HeirsOfNumenorNightmareDecks,
                TheStewardsFearNightmareDeck,
                TheDruadanForestNightmareDeck,
                EncounterAtAmonDinNightmareDeck,
                AssaultOnOsgiliathNightmareDeck,
                TheBloodOfGondorNightmareDeck,
                TheMorgulValeNightmareDeck,

                TheVoiceOfIsengardNightmareDecks,
                TheDunlandTrapNightmareDeck,
                TheThreeTialsNightmareDeck,
                TroubleInTharbadNightmareDeck,
                TheNinInEilphNightmareDeck,
                CelebrimborsSecretNightmareDeck,
                TheAntleredCrownNightmareDeck,

                TheLostRealmNightmareDecks,
                TheWastesOfEriadorNightmareDeck,
                EscapeFromMountGramNightmareDeck,
                AcrossTheEttenmoorsNightmareDeck,
                TheTreacheryOfRhudaurNightmareDeck,
                TheBattleOfCarnDumNightmareDeck,
                TheDreadRealmNightmareDeck,

                TheGreyHavensNightmareDecks,
                FlightOfTheStormcallerNightmareDeck,
                TheThingInTheDepthsNightmareDeck,
                TempleOfTheDeceivedNightmareDeck,
                TheDrownedRuinesNightmareDeck,
                AStormOnCobasHavenNightmareDeck,
                TheCityOfCorsairsNightmareDeck,

                TheHobbitOverHillAndUnderHillNightmareDecks,
                TheHobbitOnTheDoorstepNightmareDecks,

                TheBlackRidersNightmareDecks,
                TheRoadDarkensNightmareDecks,
                TheTreasonOfSarumanNightmareDecks,
                TheLandOfShadowNightmareDecks,

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

        public const string PassageThroughMirkwoodNightmareDeck = "Passage Through Mirkwood Nightmare Deck";
        public const string JourneyAlongTheAnduinNightmareDeck = "Journey Along the AnduinNightmare Deck";
        public const string EscapeFromDolGuldurNightmareDeck = "Escape from Dol Guldur Nightmare Deck";
        public const string TheHuntForGollumNightmareDeck = "The Hunt for Gollum Nightmare Deck";
        public const string ConflictAtTheCarrockNightmareDeck = "Conflict at the Carrock Nightmare Deck";
        public const string AJourneyToRhosgobelNightmareDeck = "A Journey to Rhosgobel Nightmare Deck";
        public const string TheHillsOfTheEmynMuilNightmareDeck = "The Hills of Emyn Muil Nightmare Deck";
        public const string TheDeadMarshesNightmareDeck = "The Dead Marshes Nightmare Deck";
        public const string ReturnToMirkwoodNightmareDeck = "Return to Mirkwood Nightmare Deck";

        public const string KhazadDumNightmareDecks = "Khazad-dûm Nightmare Decks";
        public const string TheRedhornGateNightmareDeck = "The Redhorn Gate Nightmare Deck";
        public const string RoadToRivendellNightmareDeck = "Road to Rivendell Nightmare Deck";
        public const string TheWatcherInTheWaterNightmareDeck = "The Watcher in the Water Nightmare Deck";
        public const string TheLongDarkNightmareDeck = "The Long Dark Nightmare Deck";
        public const string FoundationsOfStoneNightmareDeck = "Foundations of Stone Nightmare Deck";
        public const string ShadowAndFlameNightmareDeck = "Shadow and Flame Nightmare Deck";

        public const string HeirsOfNumenorNightmareDecks = "Heirs of Númenor Nightmare Decks";
        public const string TheStewardsFearNightmareDeck = "The Steward's Fear Nightmare Deck";
        public const string TheDruadanForestNightmareDeck = "The Drúadan Forest Nightmare Deck";
        public const string EncounterAtAmonDinNightmareDeck = "Encounter at Amon Dîn Nightmare Deck";
        public const string AssaultOnOsgiliathNightmareDeck = "Assault on Osgiliath Nightmare Deck";
        public const string TheBloodOfGondorNightmareDeck = "The Blood of Gondor Nightmare Deck";
        public const string TheMorgulValeNightmareDeck = "The Morgul Vale Nightmare Deck";

        public const string TheVoiceOfIsengardNightmareDecks = "The Voice of Isengard Nightmare Decks";
        public const string TheDunlandTrapNightmareDeck = "The Dunland Trap Nightmare Deck";
        public const string TheThreeTialsNightmareDeck = "The Three Trials Nightmare Deck";
        public const string TroubleInTharbadNightmareDeck = "Trouble in Tharbad Nightmare Deck";
        public const string TheNinInEilphNightmareDeck = "The Nîn-in-Eilph Nightmare Deck";
        public const string CelebrimborsSecretNightmareDeck = "Celebrimbor's Secret Nightmare Deck";
        public const string TheAntleredCrownNightmareDeck = "The Antlered Crown Nightmare Deck";

        public const string TheLostRealmNightmareDecks = "The Lost Realm Nightmare Decks";
        public const string TheWastesOfEriadorNightmareDeck = "The Wastes of Eriador Nightmare Deck";
        public const string EscapeFromMountGramNightmareDeck = "Escape from Mount Gram Nightmare Deck";
        public const string AcrossTheEttenmoorsNightmareDeck = "Across the Ettenmoors Nightmare Deck";
        public const string TheTreacheryOfRhudaurNightmareDeck = "The Treachery of Rhudaur Nightmare Deck";
        public const string TheBattleOfCarnDumNightmareDeck = "The Battle of Carn Dûm Nightmare Deck";
        public const string TheDreadRealmNightmareDeck = "The Dread Realm Nightmare Deck";

        public const string TheGreyHavensNightmareDecks = "The Grey Havens Nightmare Decks";
        public const string FlightOfTheStormcallerNightmareDeck = "Flight of the Stormcaller Nightmare Deck";
        public const string TheThingInTheDepthsNightmareDeck = "The Thing in the Depths Nightmare Deck";
        public const string TempleOfTheDeceivedNightmareDeck = "Temple of the Deceived Nightmare Deck";
        public const string TheDrownedRuinesNightmareDeck = "The Drowned Ruins Nightmare Deck";
        public const string AStormOnCobasHavenNightmareDeck = "A Storm on Cobas Haven Nightmare Deck";
        public const string TheCityOfCorsairsNightmareDeck = "The City of Corsairs Nightmare Deck";

        public const string TheHobbitOverHillAndUnderHillNightmareDecks = "The Hobbit: Over Hill and Under Hill Nightmare Decks";
        public const string TheHobbitOnTheDoorstepNightmareDecks = "The Hobbit: On the Doorstep Nightmare Decks";

        public const string TheBlackRidersNightmareDecks = "The Black Riders Nightmare Decks";
        public const string TheRoadDarkensNightmareDecks = "The Road Darkens Nightmare Decks";
        public const string TheTreasonOfSarumanNightmareDecks = "The Treason of Saruman Nightmare Decks";
        public const string TheLandOfShadowNightmareDecks = "The Land of Shadow Nightmare Decks";

        public const string FirstAge = "First Age";
        public const string TrialUponTheMarches = "Trial Upon the Marches";
        public const string AmongTheOutlaws = "Among the Outlaws";
    }
}
