using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models
{
    public class EncounterSet
    {
        public string Set { get; set; }

        private string normalizedSet;
        public string NormalizedSet
        {
            get { return !string.IsNullOrEmpty(this.normalizedSet) ? this.normalizedSet : Set; }
            private set { this.normalizedSet = value; }
        }
        
        public string Name { get; set; }

        private static List<EncounterSet> all = new List<EncounterSet>();

        public static List<EncounterSet> All()
        {
            return all;
        }

        public static EncounterSet PassageThroughMirkwood = new EncounterSet { Name = "Passage Through Mirkwood", Set = "Core Set" };
        public static EncounterSet DolGuldurOrcs = new EncounterSet { Name = "Dol Guldur Orcs", Set = "Core Set" };
        public static EncounterSet SpidersOfMirkwood = new EncounterSet { Name = "Spiders of Mirkwood", Set = "Core Set" };
        public static EncounterSet JourneyDownTheAnduin = new EncounterSet { Name = "Journey Down the Anduin", Set = "Core Set"};
        public static EncounterSet SauronsReach = new EncounterSet { Name = "Sauron's Reach", Set = "Core Set" };
        public static EncounterSet Wilderlands = new EncounterSet { Name = "Wilderlands", Set = "Core Set" };
        public static EncounterSet EscapeFromDolGuldur = new EncounterSet { Name = "Escape From Dol Guldur", Set = "Core Set" };
        public static EncounterSet TheHuntForGollum = new EncounterSet { Name = "The Hunt for Gollum", Set = "The Hunt for Gollum" };
        public static EncounterSet ConflictAtTheCarrock = new EncounterSet { Name = "Conflict at the Carrock", Set = "Conflict at the Carrock" };
        public static EncounterSet AJourneyToRhosgobel = new EncounterSet { Name = "A Journey to Rhosgobel", Set = "A Journey to Rhosgobel" };
        public static EncounterSet TheHillsOfEmynMuil = new EncounterSet { Name = "The Hills of Emyn Muil", Set = "The Hills of Emyn Muil" };
        public static EncounterSet TheDeadMarshes = new EncounterSet { Name = "The Dead Marshes", Set = "The Dead Marshes" };
        public static EncounterSet ReturnToMirkwood = new EncounterSet { Name = "Return to Mirkwood", Set = "Return to Mirkwood" };
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
        public static EncounterSet EncounterAtAmonDin = new EncounterSet { Name = "Encounter at Amon-Dîn", Set = "Encounter at Amon-Dîn", NormalizedSet = "Encounter at Amon-Din", };
        public static EncounterSet AssaultOnOsgiliath = new EncounterSet { Name = "Assault on Osgiliath", Set = "Assault on Osgiliath" };
        public static EncounterSet TheBloodOfGondor = new EncounterSet { Name = "The Blood of Gondor", Set = "The Blood of Gondor" };
        public static EncounterSet TheMorgulVale = new EncounterSet { Name = "The Morgul Vale", Set = "The Morgul Vale" };
        public static EncounterSet TheFordsOfIsen = new EncounterSet { Name = "The Fords of Isen", Set = "Voice of Isengard" };
        public static EncounterSet DunlandWarriors = new EncounterSet { Name = "Dunland Warriors", Set = "Voice of Isengard" };
        public static EncounterSet DunlandRaiders = new EncounterSet { Name = "Dunland Raiders", Set = "Voice of Isengard" };
        public static EncounterSet ToCatchAnOrc = new EncounterSet { Name = "To Catch an Orc", Set = "Voice of Isengard" };
        public static EncounterSet MistyMountainOrcs = new EncounterSet { Name = "Misty Mountain Orcs", Set = "Voice of Isengard" };
        public static EncounterSet BrokenLands = new EncounterSet { Name = "Broken Lands", Set = "Voice of Isengard" };
        public static EncounterSet IntoFangorn = new EncounterSet { Name = "Into Fangorn", Set = "Voice of Isengard" };
        public static EncounterSet AncientForest = new EncounterSet { Name = "Ancient Forest", Set = "Voice of Isengard" };
        public static EncounterSet WearyTravelers = new EncounterSet { Name = "Weary Travelers", Set = "Voice of Isengard" };
        public static EncounterSet Iarion = new EncounterSet { Name = "Iârion", Set = "The Lost Realm" };
        public static EncounterSet EriadorWilds = new EncounterSet { Name = "Eriador Wilds", Set = "The Lost Realm" };
        public static EncounterSet AngmarOrcs = new EncounterSet { Name = "Angmar Orcs", Set = "The Lost Realm" };
        public static EncounterSet RuinsOfArnor = new EncounterSet { Name = "Ruins of Arnor", Set = "The Lost Realm" };
        public static EncounterSet TheWeatherHills = new EncounterSet { Name = "The Weather Hills", Set = "The Lost Realm" };
        public static EncounterSet FoulWeather = new EncounterSet { Name = "Foul Weather", Set = "The Lost Realm" };
        public static EncounterSet DarkSorcery = new EncounterSet { Name = "Dark Sorcery", Set = "The Lost Realm" };
        public static EncounterSet CursedDead = new EncounterSet { Name = "Cursed Dead", Set = "The Lost Realm" };

        public static EncounterSet WeMustAwayEreBreakOfDay = new EncounterSet { Name = "We Must Away Ere Break of Day", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet WesternLands = new EncounterSet { Name = "Western Lands", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet OverTheMistyMountainsGrim = new EncounterSet { Name = "Over the Misty Mountains Grim", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet TheGreatGoblin = new EncounterSet { Name = "The Great Goblin", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet MistyMountainGoblins = new EncounterSet { Name = "Misty Mountain Goblins", Set = "The Hobbit: Over Hill and Under Hill" };
        public static EncounterSet DungeonsDeepAndCavernsDim = new EncounterSet { Name = "Dungeons Deep and Caverns Dim", Set = "The Hobbit: Over Hill and Under Hill" };

        public static EncounterSet FliesAndSpiders = new EncounterSet { Name = "Flies and Spiders", Set = "The Hobbit: On the Doorstep" };
        public static EncounterSet Wilderland = new EncounterSet { Name = "Wilderland", Set = "The Hobbit: On the Doorstep" };
        public static EncounterSet TheLonelyMountain = new EncounterSet { Name = "The Lonely Mountain", Set = "The Hobbit: On the Doorstep" };
        public static EncounterSet TheBattleOfFiveArmies = new EncounterSet { Name = "The Battle of Five Armies", Set = "The Hobbit: On the Doorstep" };

        public static EncounterSet AShadowOfThePast = new EncounterSet { Name = "A Shadow of the Past", Set = "The Black Riders" };
        public static EncounterSet Hunted = new EncounterSet { Name = "Hunted", Set = "The Black Riders" };
        public static EncounterSet TheRing = new EncounterSet { Name = "The Ring", Set = "The Black Riders" };
        public static EncounterSet TheBlackRiders = new EncounterSet { Name = "The Black Riders", Set = "The Black Riders" };
        public static EncounterSet AKnifeInTheDark = new EncounterSet { Name = "A Knife in the Dark", Set = "The Black Riders" };
        public static EncounterSet TheNazgul = new EncounterSet { Name = "The Nazgûl", Set = "The Black Riders" };
        public static EncounterSet FlightToTheFord = new EncounterSet { Name = "Flight to the Ford", Set = "The Black Riders" };
        public static EncounterSet OrcsOfTheWhiteHand = new EncounterSet { Name = "Orcs of the White Hand", Set = "The Treason of Saruman" };
        public static EncounterSet SnagaOrcs = new EncounterSet { Name = "Snaga Orcs", Set = "The Treason of Saruman" };
        public static EncounterSet Gollum = new EncounterSet { Name = "Gollum", Set = "The Land of Shadow" };
        public static EncounterSet Nazgul = new EncounterSet { Name = "Nazgûl", Set = "The Land of Shadow" };
        public static EncounterSet Harad = new EncounterSet { Name = "Harad", Set = "The Land of Shadow" };
        public static EncounterSet TheGreatSpider = new EncounterSet { Name = "The Great Spider", Set = "The Land of Shadow" };

        public static EncounterSet TheMassingAtOsgiliath = new EncounterSet { Name = "The Massing at Osgiliath", Set = "The Massing at Osgiliath" };
        public static EncounterSet TheBattleOfLakeTown = new EncounterSet { Name = "The Battle of Lake-town", Set = "The Battle of Lake-town" };
        public static EncounterSet TheStoneOfErech = new EncounterSet { Name = "The Stone of Erech", Set = "The Stone of Erech" };

        public static EncounterSet PassageThroughMirkwoodNightmare = new EncounterSet { Name = "Passage Through Mirkwood Nightmare", Set = "Passage Through Mirkwood Nightmare" };
        public static EncounterSet JourneyAlongTheAnduinNightmare = new EncounterSet { Name = "Journey Along the Anduin Nightmare", Set = "Journey Along the Anduin Nightmare" };
        public static EncounterSet EscapeFromDolGuldurNightmare = new EncounterSet { Name = "Escape from Dol Guldur Nightmare", Set = "Escape from Dol Guldur Nightmare" };
        public static EncounterSet TheHuntForGollumNightmare = new EncounterSet { Name = "The Hunt for Gollum Nightmare", Set = "The Hunt for Gollum Nightmare" };
        public static EncounterSet ConflictAtTheCarrockNightmare = new EncounterSet { Name = "Conflict at the Carrock Nightmare", Set = "Conflict at the Carrock Nightmare" };
        public static EncounterSet AJourneyToRhosgobelNightmare = new EncounterSet { Name = "A Journey to Rhosgobel Nightmare", Set = "A Journey to Rhosgobel Nightmare" };
        public static EncounterSet TheHillsOfEmynMuilNightmare = new EncounterSet { Name = "The Hills of Emyn Muil Nightmare", Set = "The Hills of Emyn Muil Nightmare" };
        public static EncounterSet TheDeadMarshesNightmare = new EncounterSet { Name = "The Dead Marshes Nightmare", Set = "The Dead Marshes Nightmare" };
        public static EncounterSet ReturnToMirkwoodNightmare = new EncounterSet { Name = "Return to Mirkwood Nightmare", Set = "Return to Mirkwood Nightmare" };
        public static EncounterSet IntoThePitNightmare = new EncounterSet { Name = "Into the Pit Nightmare", Set = "Into the Pit Nightmare" };
        public static EncounterSet TheSeventhLevelNightmare = new EncounterSet { Name = "The Seventh Level Nightmare", Set = "The Seventh Level Nightmare" };
        public static EncounterSet FlightFromMoriaNightmare = new EncounterSet { Name = "Flight from Moria Nightmare", Set = "Flight from Moria Nightmare" };
        public static EncounterSet WeMustAwayEreBreakOfDayNightmare = new EncounterSet { Name = "We Must Away Ere Break of Day Nightmare", Set = "We Must Away Ere Break of Day Nightmare" };
        public static EncounterSet OverTheMistyMountainsGrimNightmare = new EncounterSet { Name = "Over the Misty Mountains Grim Nightmare", Set = "Over the Misty Mountains Grim Nightmare" };
        public static EncounterSet TheGreatGoblinNightmare = new EncounterSet { Name = "The Great Goblin Nightmare", Set = "Over the Misty Mountains Grim Nightmare" };
        public static EncounterSet DungeonsDeepAndCavernsDimNightmare = new EncounterSet { Name = "Dungeons Deep and Caverns Dim Nightmare", Set = "Dungeons Deep and Caverns Dim Nightmare" };
    }
}