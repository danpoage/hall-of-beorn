using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class GermanTranslation
        : TranslationBase
    {
        public GermanTranslation()
            : base(Language.DE)
        {
        }

        protected override Dictionary<string, string> AddCardTypeNames()
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
                { "Campaign", "Kampagne" },
                { "Cave", "Höhle" },
            };
        }

        protected override Dictionary<string, string> AddKeywords()
        {
            return new Dictionary<string, string> {
                { "Archery 1.", "Bogenschießen 1." },
                { "Archery 2.", "Bogenschießen 2." },
                { "Archery X.", "Bogenschießen X." },
                
                { "Devoted.", "Treu." },
                
                { "Doomed 1.", "Verflucht 1." },
                
                { "Guarded (enemy).", "Bewacht (Gegner)." },
                { "Guarded (location).", "Bewacht (Ort)." },
                
                { "Immune to player card effects.", "Immun gegen Spielerkarteneffekte." },
                { "Indestructible.", "Unzerstörbar." },
                
                { "Looter 0.", "Erbeuten 0." },
                { "Looter 1.", "Erbeuten 1." },
                { "Looter 2.", "Erbeuten 2." },
                { "Looter 3.", "Erbeuten 3." },
                
                { "Peril.", "Wagnis." },

                { "Ranged.", "Fernkampf." },
                { "Restricted.", "Eingeschränkt." },
                { "Secrecy 1.", "Heimlichkeit 1." },
                { "Sentinel.", "Schildwache." },

                { "Steeds 1 Per Player.", "Pferde 1 Per Player." },
                { "Steeds 1.", "Pferde 1." },
                { "Steeds 2.", "Pferde 2." },
                { "Steeds 3.", "Pferde 3." },
                { "Steeds 4.", "Pferde 4." },
                { "Surge.", "Nachrüsten." },

                { "Time 7.", "Zeit 7." },

                { "Vast.", "Weitläufig." },
            };
        }

        protected override Dictionary<string, string> AddTitles()
        {
            var all = new Dictionary<string, string>();

            SafeMap(all, new Dictionary<string, string> {
                { "Children of Eorl", "Nachfahren von Eorl" },
            });

            //Scenarios
            SafeMap(all, new Dictionary<string, string> {
                { "Ambush at Erelas", "Hinterhalt am Erelas" },
                { "The Battle for the Beacon", "Der Kampf um das Leuchtfeuer" },
                { "The Horse Lord's Ire", "Der Zorn der Pferdeherren" },
                { "The Aldburg Plot", "3" },
                { "Fire on the Eastemnet", "4" },
                { "The Gap of Rohan", "5" },
                { "The Glittering Caves", "6" },
                { "Mustering of the Rohirrim", "7" },
                { "Blood in the Isen", "8" },
                { "The Scouring of the Shire", "9" },
                { "The Nine are Abroad", "10" },
            });

            //Core Set
            SafeMap(all, new Dictionary<string, string> {
                { "Guard of the Citadel", "Wächter der Veste" },
            });

            //Children of Eorl
            SafeMap(all, new Dictionary<string, string> {
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
                { "The Sweeping Tide", "Die Reissende Flut" }
            });

            //The Aldburg Plot
            SafeMap(all, new Dictionary<string,string> {
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
                { "Ruby Cloak-pin", "Weinrote Fibel" },
                { "Silver Dagger", "Silberdolch" },
                { "Prison Key", "Gefängnisschlüssel" },
                { "Traitor's Confession", "Geständnis eines Verräters" },
                { "Raven Signet Ring", "Rabensiegelring" },
                { "Rohirric Coins", "Münzen der Rohirrim" },
                { "Red Fletched Arrow", "Rotgefiederter Pfeil" },
                { "Letter from Dunland", "Brief aus Dunland" }
            });

            //Fire on the Eastemnet
            SafeMap(all, new Dictionary<string,string> {
                { "Box of Earth", "Kästchen mit Erde" },
                { "Breath of Arda", "Atem von Arda" },
                { "Captured Steeds", "Gefangene Pferde" },
                { "Chieftain of the Skies", "Häuptling der Lüfte" },
                { "Cracking Horse Whip", "Knallende Pferdepeitsche" },
                { "Eastemnet Pasture", "Weide im Ostemnet" },
                { "Entwash Crossings", "Überquerung des Entwasser" },
                { "Exhausted Pursuit", "Erschöpfende Verfolgung" },
                { "Expanded Search", "Ausgeweitete Suche" },
                { "Golden Crown", "Goldene Krone" },
                { "Grip", "Greif" },
                { "Guided by Fate", "Vom Schicksal geleitet" },
                { "Hidden Orc Camp", "Verstecktes Orklager" },
                { "Hidden Roosts", "Geheime Horste" },
                { "Messenger of Manwë", "Manwes Bote" },
                { "Open Meadows", "Weite Wiesen" },
                { "Orc Lookout", "Ork-Wachposten" },
                { "Orcish Wrangler", "Ork-Streiter" },
                { "Panicked Horses", "Verschreckte Pferde" },
                { "Pillaged Stables", "Geplünderte Ställe" },
                { "Poachers in the Night", "Pferdediebe in der Nacht" },
                { "Relentless Forces", "Unbarmherzige Streitkräfte" },
                { "Roving Herbmaster", "Wandernde Kräutermeisterin" },
                { "Shores of Anduin", "Ufer des Anduin" },
                { "To the River!", "Zum Fluss!" },
                { "Veteran Eagle", "Adlerveteran" },
                { "White Mountain Beastmaster", "Bestienmeister des Weissen Gebirges" },
                { "Wild Steeds", "Freie Pferde" }
            });

            //The Gap of Rohan
            SafeMap(all, new Dictionary<string,string> {
                { "A Dangerous Pursuit", "Eine gefährliche Verfolgung" },
                { "A Stout Heart", "Sehr beherzt" },
                { "Archet Alekeeper", "Schankwirt aus Archet" },
                { "Barliman Butterbur", "Gerstenmann Butterblume" },
                { "Biting Winds", "Beissende Winde" },
                { "Bob", "Hinz" },
                { "Bree Pony", "Pony aus Bree" },
                { "Bree-land Protector", "Beschützerin des Breelandes" },
                { "Dunlending Rearguard", "Nachhut der Dunländer" },
                { "Exposed Ridge", "Ungeschützer Höhenzug" },
                { "Frantic Dunlending", "Verzweifelter Dunländer" },
                { "Frozen Lake", "Gefrorener See" },
                { "Frozen Solid", "Festgefroren" },
                { "Gálmód’s Escort", "Gálmóds Eskorte" },
                { "Gift of Foresight", "Gabe der Voraussicht" },
                { "Giving Chase", "Auf der Jagd" },
                { "Half-pint", "Ein kleines Bier" },
                { "Harry Goatleaf", "Heinrich Geissblatt" },
                { "Nob", "Kunz" },
                { "Pint", "Ein grosses Bier" },
                { "Recapture the Traitor", "Fangt den Verräter" },
                { "Scheming Staddler", "Gewiefte Sattlerin" },
                { "Seasoned Forager", "Erfahrener Wildbeuter" },
                { "Slippery Hill", "Rutschiger Hügel" },
                { "Snow Squall", "Schneeschauer" },
                { "Snowbank", "Schneewehe" },
                { "Stumble in the Snow", "Stolpern im Schnee" },
                { "Unnatural Cold", "Unnatürliche Kälte" },
                { "White Wall", "Weisse Wand" }
            });

            //The Glittering Caves
            SafeMap(all, new Dictionary<string,string> {
                { "Alluring Paths", "Verlockende Pfade" },
                { "Cave Opening", "Höhlenöffnung" },
                //{ "Crossroads", "Kreuzung" },
                { "Dark Pit", "Dunkle Grube" },
                { "Dead End", "Sackgasse" },
                { "Echoes in the Deep", "Echos in den Tiefen" },
                { "Forgotten Shade", "Vergessener Schatten" },
                { "Fork", "Gabelung" },
                { "Guard the Entrance!", "Bewacht den Eingang!" },
                { "Guarded Hall", "Bewachte Halle" },
                { "Harlond Lookout", "Wachposten von Harlond" },
                { "Helm's Horn", "Helms Horn" },
                { "Jewelled Cavern", "Juwelenniesche" },
                { "Killing With Fear", "Vor Angst sterben" },
                { "Lay of the Nauglamír", "Lied vom Nauglamír" },
                { "Legacy of Gondolin", "Vermächtnis von Gondolin" },
                { "Locked Door", "Verschlossene Tür" },
                { "Lurking Ghûl", "Lauernder Ghul" },
                { "Onward Into Battle", "Vorn in der Schlacht" },
                { "Radiant Caverns", "Leuchtende Höhlen" },
                { "Relic of Nargothrond", "Überbleibsel aus Nargothrond" },
                { "Salvaged Supplies", "Geborgene Vorräte" },
                { "Search the Caves", "Durchsucht die Höhlen" },
                { "Secret Passage", "Geheimer Durchgang" },
                { "Small Stream", "Kleiner Bach" },
                { "Stairwell", "Treppe" },
                { "The Horn's Discovery", "Die Entdeckung des Horns" },
                { "Twisting Paths", "Verschlungene Pfade" },
                { "Vast Cave", "Weite Höhle" },
                { "Wandering Spirit", "Wanderner Geist" },
                { "Wonders of Aglarond", "Wunder von Aglarond" }
            });

            //Mustering of the Rohirrim
            SafeMap(all, new Dictionary<string,string> {
                { "Aldburg Provocateur", "Herausforderer von Aldburg" },
                { "Assassin at Edoras", "Attentäter in Edoras" },
                { "Beorn's Welcome", "Beorns Begrüssung" },
                { "Beorning Pony", "Pony der Beorninger" },
                { "Bitter Betrayal", "Bitterer Verrat" },
                { "Coup", "Staatsstreich" },
                { "Curuwyn The Whisperer", "Curuwyn die Flüsterin" },
                { "Cutthroat's Strike", "Hieb des Mörders" },
                { "Deeping-stream", "Klammbach" },
                { "Descendants of Beorn", "Beorns Nachfahren" },
                { "Devoted Determination", "Ergebene Entschlossenheit" },
                { "Felberen Scion of Freca", "Felberen, Sprössling des Freca" },
                { "Halls of Ealdwulf", "Ealdwulfs Hallen" },
                { "Host of Rohan", "Heer aus Rohan" },
                { "Hunting Dogs", "Jagdhunde" },
                { "Lie of the Land", "Die Lage des Landes" },
                { "Massing at the Isen", "Versammlung am Isen" },
                { "Oaths of the Rohirrim", "Eide der Rohirrim" },
                { "Orator's Hall", "Rednersaal" },
                { "Orc-host Remnant", "Überbleibsel des Orkheeres" },
                { "Pernicious Plotter", "Verderbter Verschwörer" },
                { "Plains of Strife", "Ebene der Zwietracht" },
                { "Raven Clan Sharpshooter", "Scharfschütze des Raben-Stamms" },
                { "Raven Clan Warchief", "Kriegshäuptling des Raben-Stamms" },
                { "Road to Ruin", "Weg zur Vernichtung" },
                { "Scattered to the Winds", "In alle Winde zerstreut" },
                { "Seeking Support", "Auf der Suche nach Hilfe" },
                { "Smeóhbrand Rogue of Orthanc", "Smeóhbrand, Schurke vom Orthanc" },
                { "Sniveling Courtier", "Herumschnüffelnder Höfling" },
                { "Spiteful Hunter", "Gehässiger Jäger" },
                { "Subdued", "Überwältigt" },
                { "The Far Bank", "Das Ferne Ufer" },
                { "Traitor's Redoubt", "Kasematte des Verräters" },
                { "Winter in Westemnet", "Winter im Westemnet" },
                { "Without My Hat", "Ohne Hut" },
                { "Woodmen's Outpost", "Aussenposten der Waldmenschen" }
            });

            //Blood in the Isen
            SafeMap(all, new Dictionary<string, string> {
                { "A Fair Exchange", "Ein gerechter Tausch" },
                { "Chaos and Confusion", "Unordnung und Verwirrung" },
                { "Chieftain of the North", "Häuptling des Nordens" },
                { "Contested Battleground", "Umkämpftes Schlachtfeld" },
                { "Coordinated Assault", "Geplanter Überfall" },
                { "Crossing the Fords", "Überquerung der Furten" },
                { "Defensive Outcrop", "Leicht zu haltender Vorsprung" },
                { "Dunland Axe-hand", "Axtkrieger aus Dunland" },
                { "Fleet-footed Dunlending", "Leichtfüssiger Dunländer" },
                { "Grey Companion", "Grauer Gefährte" },
                { "Hasty Pursuit", "Eilige Verfolgung" },
                { "Heavy Losses", "Schwere Verluste" },
                { "Narrow Crossing", "Schmaler Übergang" },
                { "North-South Road", "Nord-Süd-Strasse" },
                { "Open Rebellion", "Offener Aufstand" },
                { "Rohan Renegade", "Abtrünniger aus Rohan" },
                { "Spurned Hillman", "Verschmähter Hügelmensch" },
                { "The Battle is Joined", "Der Kampf beginnt" },
                { "The Flight of Ealdwulf", "Ealdwulfs Flucht" },
                { "The Renewer", "Der Erneuerer" },
                { "West Bank", "Westufer" },
            });

            //The Scouring of the Shire
            SafeMap(all, new Dictionary<string,string> {
                { "Against the Rules", "Gegen die Regeln" },
                { "Ambush Sharkey's Men", "Lauert Scharrers Leuten auf" },
                { "Awake! Fire, Foes! Awake!", "Erwacht! Feuer, Feinde! Erwacht!" },
                { "Brandywine Gate", "Brandywein-Tor" },
                { "Brick Building", "Ziegelgebäude" },
                { "Bright Mail", "Strahlende Rüstung" },
                { "Curse Upon the Shire", "Fluch über das Auenland" },
                { "East Road", "Oststrasse" },
                { "Escorted “Prisoners”", "Eskortierte “Gefangene”" },
                { "Feather-capped Shirriff", "Landbüttel mit Federmütze" },
                { "Find the Gaffer", "Findet den Ohm" },
                { "Frodo Baggins", "Frodo Beutlin" },
                { "Gang of Ruffians", "Bande von Strolchen" },
                { "Gríma's Choice", "Grímas Wahl" },
                { "Heightened Stature", "Hoch gewachsen" },
                { "Hidden Blade", "Versteckte Klinge" },
                { "Highway Robber", "Strassenräuber" },
                { "Hobbiton Road", "Hobbinger Strasse" },
                { "Into the West", "In den Westen" },
                { "Many Partings", "Viele Abschiede" },
                { "Muster the Tooks", "Versammelt die Tuks" },
                { "Once Beloved Place", "Einst geliebte Behausung" },
                { "One Ill Turn", "Eine üble Wendung" },
                { "Raise the Shire", "Das Auenland zum Widerstand aufrufen" },
                { "Rouse the Cottons", "Rüttelt die Hüttingers auf" },
                { "Roused Hobbits", "Aufgerüttelte Hobbits" },
                { "Scatha's Horn", "Scathas Horn" },
                { "Set up Barriers", "Stellt Strassensperren auf" },
                { "Sharkey's Men", "Scharrers Leute" },
                { "Shirriff House", "Landbüttelhaus" },
                { "Star-like Gem", "Sternengleicher Edelstein" },
                { "Take Him, Lads!", "Greift ihn, Jungs!" },
                { "The Battle of Bywater", "Die Schlacht von Wasserau" },
                { "The Lockholes", "Das Loch" },
                { "The Scouring of the Shire", "Die Befreiung des Auenlandes" },
                { "The Very Last Stroke", "Der Allerletzte Schlag" },
                { "Thieving Ruffian", "Diebischer Strolch" },
                { "Three-Farthing Stone", "Drei-Viertel-Stein" },
                { "To the Road Again, Worm!", "Auf die Strasse, Schlange!" },
                { "Voice of Saruman", "Sarumans Stimme" },
                { "Watch the East Road", "Bewacht die Oststrasse" },
                { "Wooden Shed", "Hölzerner Schuppen" }
            });

            SafeMap(all, new Dictionary<string, string> {
                { "Anfalas Pillager", "Plünderer aus Anfalas" },
                { "At the End of All Things", "Am Ende aller Dinge" },
                { "Barrow-wight", "Grabunhold" },
                { "Birds of Ill Omen", "Unheilverheissende Vögel" },
                { "Charter the Dream-chaser", "Leiht euch die Traumjäger" },
                { "Chief of the Nine", "Herr der Neun" },
                { "Dúnedain Tracker", "Fährtenleser der Dúnedain" },
                { "Dunlending Warband", "Kriegstruppe der Dunländer" },
                { "Gladden Fields", "Schwertelfelder" },
                { "Icebay of Forochel", "Eisbucht von Forochel" },
                { "Johnny Goblin-fingers", "Heini Orkfinger" },
                { "Late for Tea", "Zu spät zum Tee" },
                { "Lost in Goblin Town", "Verlaufen in Orkstadt" },
                { "Mirkwood", "Düsterwald" },
                { "Morgul Scout", "Morgul-Späher" },
                { "Nameless Fear", "Namenloses Grauen" },
                { "Old North-South Road", "Alte Nord-Süd-Strasse" },
                { "Old Púkel Land", "Altes Púkelland" },
                { "Paths of the Dead", "Pfade der Toten" },
                { "Pursuing Wargs", "Verfolgende Warge" },
                { "Roaming Easterling", "Wandernde Ostlinge" },
                { "Search for the Nine", "Suche nach den Neun" },
                { "Shadows of Terror", "Schatten des Schreckens" },
                { "Shores of Belegaer", "Ufer des Belegaer" },
                { "South Downs Troll", "Troll aus den Südhöhen" },
                { "The Anduin River", "Der Fluss Anduin" },
                { "The Blue Mountains", "Die Blauen Berge" },
                { "The Carrock", "Der Carrock" },
                { "The Eighth Rider", "Der achte Reiter" },
                { "The Fifth Rider", "Der fünfte Reiter" },
                { "The First Rider", "Der erste Reiter" },
                { "The Fourth Rider", "Der vierte Reiter" },
                { "The Nine are Abroad", "Die Neun sind unterwegs" },
                { "The Ninth Rider", "Der neunte Reiter" },
                { "The Outlands", "Die Aussenlehen" },
                { "The Second Rider", "Der zweite Reiter" },
                { "The Seventh Rider", "Der siebente Reiter" },
                { "The Sixth Rider", "Der sechste Reiter" },
                { "The Third Rider", "Der dritte Reiter" },
                { "To Mordor We Will Send Them", "Nach Mordor wollen wir sie schicken" },
            });

            return all;
        }

        protected override Dictionary<string, string> AddTraits()
        {
            return new Dictionary<string, string> {
                { "Abroad.", "Unterwegs." },
                { "Armor.", "Rüstung." },
                { "Artifact.", "Gegenstand." },
                { "Assassin.", "Attentäter." },
                
                { "Battleground.", "Schlachtfeld." },
                { "Beorning.", "Beorninger." },
                { "Black Speech.", "Schwarze Sprache." },
                { "Boar Clan.", "Eber-Stamm." },
                { "Boon.", "Gunst." },
                { "Brigand.", "Gesetzloser." },
                { "Camp.", "Lager." },
                { "Clue.", "Hinweis." },
                { "Coastland.", "Küste." },
                { "Condition.", "Zustand." },
                { "Corsair.", "Korsar." },
                { "Creature.", "Kreatur." },

                { "Dale.", "Thal." },
                { "Doom.", "Verhängnis." },
                { "Dúnedain.", "Waldläufer." },
                { "Dwarf.", "Zwerg." },

                { "Eagle.", "Adler." },
                { "Easterling.", "Ostling." },
                { "Epic.", "Episch." },
                
                { "Fords.", "Furten." },
                { "Fortification.", "Befestigung." },
                { "Found.", "Gefunden." },
                
                { "Garrison.", "Garnison." },
                { "Gate.", "Tor." },
                { "Gift.", "Geschenk." },

                { "Healer.", "Heiler." },
                { "Hideout.", "Versteck." },
                { "Hill.", "Hügel." },
                { "Hills.", "Hügel." },

                { "Inferno.", "Feuersbrunst." },
                { "Isengard.", "Isengart." },
                { "Item.", "Artefakt." },
                
                { "Lake.", "See." },

                { "Marshland.", "Marschland." },
                { "Massing.", "Versammlung." },
                { "Mount.", "Reittier." },
                { "Mountain.", "Berg." },
                { "Mustering.", "Heerschau." },

                { "Noble.", "Adlig." },

                { "Ocean.", "Ozean." },
                { "Orc.", "Ork." },
                { "Outlands.", "Außenlehen." },

                { "Plains.", "Ebene." },

                { "Raider.", "Räuber." },
                { "Ranger.", "Waldläufer." },
                { "Raven Clan.", "Raben-Stamm." },
                { "River.", "Fluss." },
                { "Riverland.", "Flussland." },
                { "Road.", "Straße." },
                { "Ruffian.", "Strolch." },
                
                { "Scout.", "Späher." },
                { "Servant.", "Diener." },
                { "Sharkey.", "Scharrer." },
                { "Shire.", "Auenland." },
                { "Shirriff.", "Landbüttel." },
                { "Silvan.", "Waldelb." },
                { "Skill.", "Fertigkeit." },
                { "Snow.", "Schnee." },
                { "Song.", "Lied." },
                { "Spirit.", "Geist." },
                { "Spy.", "Spion." },
                { "Stair.", "Treppe." },
                { "Stalking.", "Lauernd." },
                { "Stream.", "Bach." },
                { "Summoned.", "Gerufen." },
                { "Suspicious.", "Verdächtig." },

                { "Title.", "Titel." },
                { "Traitor.", "Verräter." },
                { "Trap.", "Falle." },
                
                { "Undead.", "Untot." },
                { "Underground.", "Unterirdisch." },

                { "Village.", "Dorf." },

                { "Warrior.", "Krieger." },
                { "Wight.", "Unhold." },
                { "Weapon.", "Waffe." },
                { "Weather.", "Wetter." },
                { "Wolf Clan.", "Wolf-Stamm." },
                { "Woodman.", "Waldmensch." },
                { "Wose.", "Wasa." },
                { "Wraith.", "Böser Geist." },
            };
        }
    }
}