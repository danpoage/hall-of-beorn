using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class PolishTranslation
        : ITranslation
    {
        public Language Lang
        {
            get { return Language.PL; }
        }

        public Dictionary<string, string> CardTypeNames()
        {
            return new Dictionary<string,string>{
                { "Player", "Gracz" },
                { "Hero", "Bohater" },
                { "Ally", "Sprzymierzenieć" },
                { "Character", "Postać" },
                { "Attachment", "Dodatek" },
                { "Event", "Wydarzenie" },
                { "Encounter", "Spotkanie" },
                { "Enemy", "Wróg" },
                { "Location", "Obszar" },
                { "Treachery", "Podstęp" },
                { "Objective", "Cel" },
                { "Quest", "Zadanie" },
            };
        }

        public Dictionary<string, string> Keywords()
        {
            return new Dictionary<string, string>
            {
                { "Ranged.", "Dystans." },
                { "Devoted.", "Oddany." },
                { "Doomed 1.", "Zguba 1." },
                { "Vast.", "Rozległy." },
                { "Archery 2.", "Łucznictwo 2." },
                { "Surge.", "Mroczna fala." },
                { "Looter 3.", "Złupienie 3." },
                { "Looter 1.", "Złupienie 1." },
                { "Looter 2.", "Złupienie 2." },
                { "Archery X.", "Łucznictwo X." },
                { "Looter 0.", "Złupienie 0." },
                { "Sentinel.", "Wartownik." },
                { "Archery 1.", "Łucznictwo 1." },
                { "Guarded (enemy).", "Strzeżony (wróg)." },
                { "Restricted.", "Ograniczenie." },
                { "Guarded (location).", "Strzeżony (obszar)." },
            };
        }

        public Dictionary<string, string> Titles()
        {
            return new Dictionary<string, string>
            {
                { "Deeping Bowman", "Helmowy Łucznik" },
                { "Open the Gates", "Otworzyć Bramę" },
                { "Wealth of Adventure", "Bogactwo Przygody" },
                { "Feast of Plenty", "Święto Obfitości" },
                { "Deeping Defender", "Helmowy Obrońca" },
                { "Morwen Steelsheen", "Morwena Kwiat ze Stali" },
                { "It Should Be Spared", "Należy go Oszczędzić" },
                { "Spring the Trap", "Uruchomić Pułapkę" },
                { "Squire of the Mark", "Giermek Marchii" },
                { "Rammas Lookout", "Czujka Rammasu" },
                { "Théodwyn", "Théodwyna" },
                { "Light-footed Steed", "Chyży Rumak" },
                { "Rammas Sentry", "Strażnik Rammasu" },
                { "Live Bait", "Żywa Przynęta" },
                { "Worthy of Remembrance", "Godny Pamięci" },
                { "Need Brooks No Delay", "Lepiej późno niż nigdy" },
                { "Wild Country", "Dziki Kraj" },
                { "Endless Grasslands", "Bezkresne Pastwiska" },
                { "Windworn Villages", "Wichrowe Wioski" },
                { "Humpbacked Downs", "Garbate Wzgórza" },
                { "Ride Through the Night", "Nocna Przejażdżka" },
                { "The Green Sea", "Zielone Morze" },
                { "Cold from the Mountains", "Chłód z Gór" },
                { "Exhausting Winds", "Wyczerpujące Wiatry" },
                { "Tired and Hungry", "Zmęczony i Głodny" },
                { "Exposed to the Elements", "Wystawiony na Żywioły" },
                { "Old Farmhouse", "Stara Farma" },
                { "Abandoned Mill", "Opuszczony Młyn" },
                { "Dunland Chieftain", "Dunlandzki Wódz" },
                { "Wild Ravager", "Dziki Grabieżca" },
                { "Dunlending Berserker", "Dunlandzki Berserker" },
                { "Hillman Scout", "Zwiadowca ze Wzgórz" },
                { "Surprise Attack", "Niespodziewany Atak" },
                { "A History of Strife", "Historia Wojny" },
                { "Recreant Rider", "Zdradliwy Jeździec" },
                { "Deadly Defector", "Zabójczy Dezerter" },
                { "Orc Battalion", "Zastęp Orków" },
                { "Servant of the Eye", "Sługa Oka" },
                { "Black Land Scouts", "Zwiadowcy Czarnych Ziem" },
                { "Orcish Horse-butcher", "Orkowy Rzeźnik Koni" },
                { "Crimson Banner", "Szkarłatny Sztandar" },
                { "White Mountain Reinforcements", "Posiłki z Gór Białych" },
                { "Brigand Ringleader", "Herszt Rozbójników" },
                { "Plundered Goods", "Splądrowane Dobra" },
                { "Pillaging Swordsman", "Szermierz Grabieżca" },
                { "Grasping Slaver", "Łowca Niewolników" },
                { "Vengeful Bowman", "Mściwy Łucznik" },
                { "Sneaky Thief", "Podstępny Złodziej" },
                { "Erelas Gates", "Bramy Erelas" },
                { "Crossroads", "Rozdroża" },
                { "Erelas Stables", "Stajnie Erelas" },
                { "Chaos in the Hills", "Chaos Wśród Wzgórz" },
                { "Looted Weapons", "Zrabowana Broń" },
                { "Stockpile Barricade", "Wstrzymanie Zapasów" },
                { "Erelas Beacon", "Wzgórze Sygnałowe Erelas" },
                { "Host of Rohan", "Zastęp Rohanu" },
                { "Enraged Dunlending", "Wściekły Dunlending" },
                { "Bald Hill", "Łyse Wzgórze" },
                { "Wooden Barricade", "Drewniana Barykada" },
                { "Rocky Slope", "Skaliste Zbocze" },
                { "Surrounding Grassland", "Okoliczne Pastwiska" },
                { "Narrow Stair", "Wąskie Schody" },
                { "From All Sides", "Ze Wszystkich Stron" },
                { "Another Wave", "Kolejna Fala" },
                { "Assault Upon Erelas", "Atak na Erelas" },
                { "Reclaim the Beacon", "Odzyskać Wzgórze Sygnałowe" },
                { "Defend the Beacon", "Obronić Wzgórze Sygnałowe" },
                { "Stolen Steeds", "Skradzione Rumaki" },
                { "Flinthoof", "Krzemyk" },
                { "Brightmane", "Jasnogrzywy" },
                { "Saddle-slasher", "Siepacz Siodeł" },
                { "Rein-ripper", "Rozpruwacz Cugli" },
                { "Bridle-biter", "Kąsacz Uzd" },
                { "Pommel-pouncer", "Wysadzacz Jeźdźców" },
                { "Spoiled Pasture", "Opuszczone Pastwisko" },
                { "Horse Thieves' Hovel", "Nora Koniokradów" },
                { "Horse Lord's Lodge", "Kwatera Władcy Koni" },
                { "Thirst for Horse Blood", "Pragnienie Końskiej Krwi" },
                { "Overburdened", "Przeciążony" },
                { "The Last Alliance", "Ostatni Sojusz" },
                { "Drive them Away", "Pozbądźmy się ich" },
                { "Ambush!", "Zasadzka!" },
                { "Battle for the Hill", "Bitwa o Wzgórze Sygnałowe" },
                { "Hold the Hilltop", "Utrzymać wzgórze!" },
                { "The Last Push", "Ostatnie natarcie" },
                { "Thieves and Coursers", "Koniokradzi" },
                { "The King's Stallion", "Królewskie rumaki" },
                { "The Sweeping Tide", "Nadciągające niebezpieczeństwo" },
            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string>
            {
                { "Warrior.", "Wojownik." },
                { "Ranger.", "Strażnik." },
                { "Noble.", "Szlachcic." },
                { "Skill.", "Umiejętność." },
                { "Servant.", "Sługa." },
                { "Scout.", "Zwiadowca." },
                { "Mount.", "Wierzchowiec." },
                { "Trap.", "Pułapka." },
                { "Plains.", "Równiny." },
                { "Village.", "Wioska." },
                { "Weather.", "Pogoda." },
                { "Traitor.", "Zdrajca." },
                { "Orc.", "Ork." },
                { "Brigand.", "Rozbójnik." },
                { "Gate.", "Brama." },
                { "Road.", "Droga." },
                { "Hills.", "Wzgórza." },
                { "Stair.", "Schody." },
                { "Camp.", "Obóz." },
            };
        }
    }
}