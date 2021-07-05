using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class ItalianTranslation
        : ITranslation
    {
        public Language Lang
        {
            get { return Language.IT; }
        }

        public Dictionary<string, string> CardTypeNames()
        {
            return new Dictionary<string,string>{
                { "Player", "Giocatore" },
                { "Hero", "Eroe" },
                { "Ally", "Alleato" },
                { "Character", "Personaggio" },
                { "Attachment", "Aggregato" },
                { "Event", "Evento" },
                { "Encounter", "Incontrare" },
                { "Enemy", "Nemico" },
                { "Location", "Luogo" },
                { "Treachery", "Perfidia" },
                { "Objective", "Obiettivo" },
                { "Quest", "Ricerca" },
            };
        }

        public Dictionary<string, string> Keywords()
        {
            return new Dictionary<string, string>
            {
                { "Ranged.", "Gittata." },
                { "Devoted.", "Devozione." },
                { "Doomed 1.", "Condanna 1." },
                { "Vast.", "Vasto." },
                { "Archery 2.", "Arciere 2." },
                { "Surge.", "Impeto." },
                { "Looter 3.", "Saccheggiare 3." },
                { "Looter 1.", "Saccheggiare 1." },
                { "Looter 2.", "Saccheggiare 2." },
                { "Archery X.", "Arciere X." },
                { "Looter 0.", "Saccheggiare 0." },
                { "Sentinel.", "Sentinella." },
                { "Archery 1.", "Arciere 1." },
                { "Guarded (enemy).", "Protetto (nemico)." },
                { "Restricted.", "Limitato." },
                { "Guarded (location).", "Protetto (luogo)." },
            };
        }

        public Dictionary<string, string> Titles()
        {
            return new Dictionary<string, string>
            {
                { "Defend the Beacon", "Difendere il Faro" },
                { "Deeping Bowman", "Arciere del Fossato" },
                { "Open the Gates", "Aprite i Cancelli" },
                { "Wealth of Adventure", "Il Valore delle Avventure" },
                { "Feast of Plenty", "Banchetto Generoso" },
                { "Deeping Defender", "Difensore del Fossato" },
                { "Morwen Steelsheen", "Morwen Bagliore d'Acciaio" },
                { "It Should Be Spared", "Dovremmo Risparmiarlo" },
                { "Spring the Trap", "Scatta la Trappola" },
                { "Squire of the Mark", "Scudiero del Mark" },
                { "Rammas Lookout", "Vedetta del Rammas" },
                { "Light-footed Steed", "Lesto Destriero" },
                { "Rammas Sentry", "Sentinella del Rammas" },
                { "Live Bait", "Un'Esca Viva" },
                { "Worthy of Remembrance", "Degno di Essere Ricordato" },
                { "Need Brooks No Delay", "Il Bisogno non Tollera Attesa" },
                { "Wild Country", "Zone Selvagge" },
                { "Endless Grasslands", "Praterie Senza Fine" },
                { "Windworn Villages", "Villaggi Sferzati dal Vento" },
                { "Humpbacked Downs", "Colli Tondeggianti" },
                { "Ride Through the Night", "Attraverso la Notte" },
                { "The Green Sea", "Il Mare Verde" },
                { "Cold from the Mountains", "Freddo dalle Montagne" },
                { "Exhausting Winds", "Venti Spossanti" },
                { "Tired and Hungry", "Stanchi ed Affamati" },
                { "Exposed to the Elements", "Esposti alle Intemperie" },
                { "Old Farmhouse", "Vecchia Fattoria" },
                { "Abandoned Mill", "Mulino Abbandonato" },
                { "Dunland Chieftain", "Capitano Dunlandiano" },
                { "Wild Ravager", "Devastatore Selvaggio" },
                { "Dunlending Berserker", "Berserker del Dunland" },
                { "Hillman Scout", "Esploratore delle Montagne" },
                { "Surprise Attack", "Attacco a Sorpresa" },
                { "A History of Strife", "Un Passato di Conflitti" },
                { "Recreant Rider", "Cavaliere Meschino" },
                { "Deadly Defector", "Disertore Funesto" },
                { "Orc Battalion", "Battaglione Orchesco" },
                { "Servant of the Eye", "Servitore dell'Occhio" },
                { "Black Land Scouts", "Esploratori della Terra Nera" },
                { "Orcish Horse-butcher", "Macellatore di Cavalli Orchesco" },
                { "Crimson Banner", "Stendardo Scarlatto" },
                { "White Mountain Reinforcements", "Rinforzi dai Monti Bianchi" },
                { "Brigand Ringleader", "Capobanda dei Briganti" },
                { "Plundered Goods", "Beni Trafugati" },
                { "Pillaging Swordsman", "Spadaccino Saccheggiatore" },
                { "Grasping Slaver", "Schiavista Avido" },
                { "Vengeful Bowman", "Arciere Vendicativo" },
                { "Sneaky Thief", "Ladro Furtivo" },
                { "Erelas Gates", "Porte di Erelas" },
                { "Crossroads", "Crocicchio" },
                { "Erelas Stables", "Stalle di Erelas" },
                { "Chaos in the Hills", "Caos nelle Colline" },
                { "Looted Weapons", "Armi Rubate" },
                { "Stockpile Barricade", "Barriera Rabberciata" },
                { "Erelas Beacon", "Faro di Erelas" },
                { "Host of Rohan", "Schiera di Rohan" },
                { "Enraged Dunlending", "Dunlandiano Furioso" },
                { "Bald Hill", "Collina Spoglia" },
                { "Wooden Barricade", "Barricata di Legno" },
                { "Rocky Slope", "Pendio Roccioso" },
                { "Surrounding Grassland", "Prateria Sconfinata" },
                { "Narrow Stair", "Scala Angusta" },
                { "From All Sides", "Da Tutti i Lati" },
                { "Another Wave", "Un'Altra Ondata" },
                { "Assault Upon Erelas", "Assalto ad Erelas" },
                { "Reclaim the Beacon", "Riconquistare il Faro" },
                { "Stolen Steeds", "Destrieri Rubati" },
                { "Flinthoof", "Zoccoselce" },
                { "Brightmane", "Folgocrino" },
                { "Saddle-slasher", "Squarcia-sella" },
                { "Rein-ripper", "Strappa-redini" },
                { "Bridle-biter", "Recidi-briglie" },
                { "Pommel-pouncer", "Balza-pomello" },
                { "Spoiled Pasture", "Pascolo Rovinato" },
                { "Horse Thieves' Hovel", "Stamberga dei Ladri di Cavalli" },
                { "Horse Lord's Lodge", "Loggia del Signore dei Cavalli" },
                { "Thirst for Horse Blood", "Sete di Sangue di Cavallo" },
                { "Overburdened", "Oberato" },
                { "The Last Alliance", "L'Ultima Alleanza" },
                { "Drive them Away", "Respingiamoli" },
                { "Ambush!", "Imboscata!" },
                { "Battle for the Hill", "Battaglia per la Collina" },
                { "Hold the Hilltop", "Tenere la Collina" },
                { "The Last Push", "L'Ultimo Sforzo" },
                { "Thieves and Coursers", "Predoni e Corsieri" },
                { "The King's Stallion", "Lo Stallone del Re" },
                { "The Sweeping Tide", "Un'Ondata Travolgente" },
            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string>
            {
                { "Warrior.", "Guerriero." },
                { "Noble.", "Nobile." },
                { "Skill.", "Abilità." },
                { "Servant.", "Servitore." },
                { "Scout.", "Esploratore." },
                { "Mount.", "Cavalcatura." },
                { "Trap.", "Trappola." },
                { "Plains.", "Pianure." },
                { "Village.", "Villaggio." },
                { "Weather.", "Clima." },
                { "Traitor.", "Traditore." },
                { "Orc.", "Orco." },
                { "Brigand.", "Brigante." },
                { "Gate.", "Cancello." },
                { "Road.", "Strada." },
                { "Hills.", "Colline." },
                { "Stair.", "Scala." },
                { "Camp.", "Campo." },
        };
    }

    }
}