using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class GermanTranslation
        : ITranslation
    {
        public Language Lang
        {
            get { return Language.DE; }
        }

        public Dictionary<string, string> CardTypeNames()
        {
            return new Dictionary<string, string> {
                { "Player", "Spieler" },
                { "Hero", "Held" },
                { "Ally", "Verbündeter" },
                { "Character", "Charakter" },
                { "Attachment", "Verstärkung" },
                { "Event", "Ereignis" },
                { "Encounter", "Begegnung" },
                { "Enemy", "Gegner" },
                { "Location", "Ort" },
                { "Treachery", "Verrat" },
                { "Objective", "Ziel" },
                { "Quest", "Suche" },
            };
        }

        public Dictionary<string, string> Keywords()
        {
            return new Dictionary<string, string> {
                { "Ranged.", "Fernkampf." },
                { "Devoted.", "Treu." },
                { "Doomed 1.", "Verflucht 1." },
                { "Vast.", "Weitläufig." },
                { "Archery 2.", "Bogenschießen 2." },
                { "Surge.", "Nachrüsten." },
                { "Looter 3.", "Erbeuten 3." },
                { "Looter 1.", "Erbeuten 1." },
                { "Looter 2.", "Erbeuten 2." },
                { "Archery X.", "Bogenschießen X." },
                { "Looter 0.", "Erbeuten 0." },
                { "Sentinel.", "Schildwache." },
                { "Archery 1.", "Bogenschießen 1." },
                { "Guarded (enemy).", "Bewacht (Gegner)." },
                { "Restricted.", "Eingeschränkt." },
                { "Guarded (location).", "Bewacht (Ort)." },

            };
        }

        public Dictionary<string, string> Titles()
        {
            return new Dictionary<string, string> {
                { "Guard of the Citadel", "Wächter der Veste" },

                { "Defend the Beacon", "Verteidigt das Leuchtfeuer" },
                { "Deeping Bowman", "Bogenschütze der Klamm" },
                { "Open the Gates", "Öffnet die Tore" },
                { "Wealth of Adventure", "Erfahrung durch Abenteuer" },
                { "Feast of Plenty", "Fest der Fülle" },
                { "Deeping Defender", "Verteidiger der Klamm" },
                { "Morwen Steelsheen", "Morwen Stahlglanz" },
                { "It Should Be Spared", "Es sollte verschont bleiben" },
                { "Spring the Trap", "Die Falle schnappt zu" },
                { "Squire of the Mark", "Knappe der Mark" },
                { "Rammas Lookout", "Wachposten der Rammas" },
                { "Light-footed Steed", "Leichtfüssiges Streitross" },
                { "Rammas Sentry", "Wächter der Rammas" },
                { "Live Bait", "Lebendiger Köder" },
                { "Worthy of Remembrance", "Der Erinnerung würdig" },
                { "Need Brooks No Delay", "Not duldet keinen Aufschub" },
                { "Wild Country", "Wildes Land" },
                { "Endless Grasslands", "Endlose Grasländer" },
                { "Windworn Villages", "Windgepeitschte Dörfer" },
                { "Humpbacked Downs", "Buckliges Hügelland" },
                { "Ride Through the Night", "Reitet durch die Nacht" },
                { "The Green Sea", "Das Grüne Meer" },
                { "Cold from the Mountains", "Kälte aus den Bergen" },
                { "Exhausting Winds", "Erschöpfende Winde" },
                { "Tired and Hungry", "Müde und Hungrig" },
                { "Exposed to the Elements", "Den Elementen ausgesetzt" },
                { "Old Farmhouse", "Altes Bauernhaus" },
                { "Abandoned Mill", "Verlassene Mühle" },
                { "Dunland Chieftain", "Häuptling aus Dunland" },
                { "Wild Ravager", "Wilder Verwüster" },
                { "Dunlending Berserker", "Dunländer-Berserker" },
                { "Hillman Scout", "Späher der Hügelmenschen" },
                { "Surprise Attack", "Überraschungsangriff" },
                { "A History of Strife", "Eine Geschichte des Streits" },
                { "Recreant Rider", "Feiger Reiter" },
                { "Deadly Defector", "Tödlicher Überläufer" },
                { "Orc Battalion", "Ork-Bataillon" },
                { "Servant of the Eye", "Diener des Auges" },
                { "Black Land Scouts", "Kundschafter der Schwarzen Lande" },
                { "Orcish Horse-butcher", "Orkischer Pferdeschlächter" },
                { "Crimson Banner", "Purpurrotes Banner" },
                { "White Mountain Reinforcements", "Verstärkungen vom Weissen Berg" },
                { "Brigand Ringleader", "Rädelsführer der Gesetzlosen" },
                { "Plundered Goods", "Geplünderte Waren" },
                { "Pillaging Swordsman", "Plündernder Schwertkämpfer" },
                { "Grasping Slaver", "Habgieriger Sklavenhändler" },
                { "Vengeful Bowman", "Rachsüchtiger Bogenschütze" },
                { "Sneaky Thief", "Hinterhältiger Dieb" },
                { "Erelas Gates", "Tore von Erelas" },
                { "Crossroads", "Kreuzung" },
                { "Erelas Stables", "Stallungen von Erelas" },
                { "Chaos in the Hills", "Chaos in den Hügeln" },
                { "Looted Weapons", "Geplünderte Waffen" },
                { "Stockpile Barricade", "Improvisierte Barrikade" },
                { "Erelas Beacon", "Leuchtfeuer von Erelas" },
                { "Host of Rohan", "Heer aus Rohan" },
                { "Enraged Dunlending", "Wütender Dunländer" },
                { "Bald Hill", "Kahler Hügel" },
                { "Wooden Barricade", "Hölzerne Barrikade" },
                { "Rocky Slope", "Felsiger Abhang" },
                { "Surrounding Grassland", "Umliegendes Grasland" },
                { "Narrow Stair", "Schmale Treppe" },
                { "From All Sides", "Von allen Seiten" },
                { "Another Wave", "Eine weitere Welle" },
                { "Assault Upon Erelas", "Angriff auf Erelas" },
                { "Reclaim the Beacon", "Das Leuchtfeuer zurückgewinnen" },
                { "Stolen Steeds", "Gestohlene Rosse" },
                { "Flinthoof", "Feuersteinhuf" },
                { "Brightmane", "Leuchtmähne" },
                { "Saddle-slasher", "Sattelschlitzer" },
                { "Rein-ripper", "Zügelreisser" },
                { "Bridle-biter", "Zaumbeisser" },
                { "Pommel-pouncer", "Knaufstürzer" },
                { "Spoiled Pasture", "Verdorbene Weide" },
                { "Horse Thieves' Hovel", "Absteige der Pferdediebe" },
                { "Horse Lord's Lodge", "Loge der Pferdeherren" },
                { "Thirst for Horse Blood", "Durst nach Pferdeblut" },
                { "Overburdened", "Überlastet" },
                { "The Last Alliance", "Das Letzte Bündnis" },
                { "Drive them Away", "Treibt sie Fort" },
                { "Ambush!", "Hinterhalt!" },
                { "Battle for the Hill", "Kampf um den Hügel" },
                { "Hold the Hilltop", "Haltet den Hügel" },
                { "The Last Push", "Der letzte Vorstoss" },
                { "Thieves and Coursers", "Diebe und Rennpferde" },
                { "The King's Stallion", "Des Königs Hengst" },
                { "The Sweeping Tide", "Die Reissende Flut" },
            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string> {
                { "Beorning.", "Beorninger." },
                
                { "Warrior.", "Krieger." },
                { "Ranger.", "Waldläufer." },
                { "Noble.", "Adlig." },
                { "Skill.", "Fertigkeit." },
                { "Servant.", "Diener." },
                { "Scout.", "Späher." },
                { "Mount.", "Reittier." },
                { "Trap.", "Falle." },
                { "Plains.", "Ebene." },
                { "Village.", "Dorf." },
                { "Weather.", "Wetter." },
                { "Traitor.", "Verräter." },
                { "Orc.", "Ork." },
                { "Brigand.", "Gesetzloser." },
                { "Gate.", "Tor." },
                { "Road.", "Straße." },
                { "Hills.", "Hügel." },
                { "Stair.", "Treppe." },
                { "Camp.", "Lager." },

            };
        }
    }
}