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
                { "Archery 1.", "Bogenschießen 1." },
                { "Archery 2.", "Bogenschießen 2." },
                { "Archery X.", "Bogenschießen X." },
                
                { "Devoted.", "Treu." },
                
                { "Doomed 1.", "Verflucht 1." },
                
                { "Guarded (enemy).", "Bewacht (Gegner)." },
                { "Guarded (location).", "Bewacht (Ort)." },
                
                { "Looter 0.", "Erbeuten 0." },
                { "Looter 1.", "Erbeuten 1." },
                { "Looter 2.", "Erbeuten 2." },
                { "Looter 3.", "Erbeuten 3." },
                
                { "Ranged.", "Fernkampf." },
                { "Restricted.", "Eingeschränkt." },
                { "Secrecy 1.", "Heimlichkeit 1." },
                { "Sentinel.", "Schildwache." },
                { "Surge.", "Nachrüsten." },
                { "Vast.", "Weitläufig." },
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

                { "Fatty Bolger", "Dick Bolger" },
                { "Lily Cotton", "Lily Hüttinger" },
                { "A Lesson in Caution", "Eine Lektion in Vorsicht" },
                { "There and Back Again", "Hin und wieder zurück" },
                { "Buckland Shirriff", "Landbüttel von Bockland" },
                { "Weep No More!", "Weint nicht mehr!" },
                { "Fear! Fire! Foes!", "Gefahr! Feuer! Feinde!" },
                { "Horn-call of Buckland", "Hornruf von Bockland" },
                { "Young Tom", "Junger Tom" },
                { "Red Harvest", "Rote Ernte" },
                { "The Prisoner in White", "Der Gefangene in Weiss" },
                { "The Man with the Twisted Lip", "Der Mann mit der entstellten Lippe" },
                { "A Fire Rises", "Ein Feuer bricht aus" },
                { "A Case of Identity", "Eine Frage der Identität" },
                { "Whisperer in the Darkness", "Flüsterin in der Dunkelheit" },
                { "Spreading Inferno", "Sich ausbreitende Feuersbrunst" },
                { "The Whisperer", "Die Flüsterin" },
                { "The Spy Master", "Der Meister der Spione" },
                { "Garrison Barracks", "Garnisonskaserne" },
                { "The Horse's Tail", "Zum Pferdeschwanz" },
                { "The Armoury", "Die Rüstkammer" },
                { "Great Mead Hall", "Grosse Met-Halle" },
                { "Town Guard", "Stadtwache" },
                { "Dunlending Agents", "Spione aus Dunland" },
                { "Aldburg Malcontent", "Unzufriedener aus Aldburg" },
                { "Misty Street", "Neblige Strasse" },
                { "Well-lit Hall", "Gut beleuchtete Halle" },
                { "Decrepit Hovel", "Heruntergekommene Hütte" },
                { "Taken by the Night", "Von der Nacht genommen" },
                { "False Lead", "Falsche Fährte" },
                { "Sudden Ambush", "Plötzlicher Hinterhalt" },
                { "Evil Under the Moon", "Böses unter dem Mond" },
                { "Gathering Clues", "Hinweise sammeln" },
                { "The Uncertain Dawn", "Eine ungewisse Dämmerung" },
                { "Ossian", "Geständnis eines Verräters" },

                //{ "Spreading Inferno", "Sich ausbreitende Feuersbrunst" },
                { "Ruby Cloak-pin", "Weinrote Fibel" },
                { "Silver Dagger", "Silberdolch" },
                { "Prison Key", "Gefängnisschlüssel" },
                { "Traitor's Confession", "Geständnis eines Verräters" },
                { "Raven Signet Ring", "Rabensiegelring" },
                { "Rohirric Coins", "Münzen der Rohirrim" },
                { "Red Fletched Arrow", "Rotgefiederter Pfeil" },
                { "Letter from Dunland", "Brief aus Dunland" },
            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string> {
                { "Assassin.", "Attentäter." },
                { "Beorning.", "Beorninger." },
                { "Brigand.", "Gesetzloser." },
                { "Camp.", "Lager." },
                { "Clue.", "Hinweis." },
                { "Creature.", "Kreatur." },
                { "Garrison.", "Garnison." },
                { "Gate.", "Tor." },
                { "Hills.", "Hügel." },
                { "Inferno.", "Feuersbrunst." },
                
                { "Mount.", "Reittier." },
                { "Noble.", "Adlig." },
                { "Orc.", "Ork." },
                { "Plains.", "Ebene." },
                { "Ranger.", "Waldläufer." },
                { "Road.", "Straße." },
                
                { "Scout.", "Späher." },
                { "Servant.", "Diener." },
                { "Shirriff.", "Landbüttel." },
                { "Skill.", "Fertigkeit." },
                { "Spy.", "Spion." },
                { "Stair.", "Treppe." },
                { "Suspicious.", "Verdächtig." },

                { "Traitor.", "Verräter." },
                { "Trap.", "Falle." },
                
                { "Village.", "Dorf." },
                { "Warrior.", "Krieger." },
                { "Weather.", "Wetter." },
                { "Woodman.", "Waldmensch." },
            };
        }
    }
}