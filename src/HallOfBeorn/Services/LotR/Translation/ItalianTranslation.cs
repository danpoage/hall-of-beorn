﻿using System;
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
                { "Archery 1.", "Arciere 1." },
                { "Archery 2.", "Arciere 2." },
                { "Archery X.", "Arciere X." },

                { "Devoted.", "Devozione." },
                { "Doomed 1.", "Condanna 1." },

                { "Guarded (enemy).", "Protetto (nemico)." },
                { "Guarded (location).", "Protetto (luogo)." },
                
                { "Looter 0.", "Saccheggiare 0." },
                { "Looter 1.", "Saccheggiare 1." },
                { "Looter 2.", "Saccheggiare 2." },
                { "Looter 3.", "Saccheggiare 3." },
                
                { "Ranged.", "Gittata." },
                { "Restricted.", "Limitato." },

                { "Secrecy 1.", "Segretezza 1." },
                { "Sentinel.", "Sentinella." },
                { "Surge.", "Impeto." },

                { "Vast.", "Vasto." },
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
                
                { "A Case of Identity", "Un Caso di Identità" },
                { "A Fire Rises", "Scoppia un Incendio" },
                { "A Lesson in Caution", "Una Lezione di Prudenza" },
                { "Aldburg Malcontent", "Sovversivo di Aldburg" },
                { "Ambush!", "Imboscata!" },
                { "Battle for the Hill", "Battaglia per la Collina" },
                { "Bridle-biter", "Recidi-briglie" },
                { "Brigand Ringleader", "Capobanda dei Briganti" },
                { "Brightmane", "Folgocrino" },
                { "Buckland Shirriff", "Guardacontea della Terra di Buck" },
                { "Decrepit Hovel", "Baracca Decrepita" },
                { "Drive them Away", "Respingiamoli" },
                { "Dunlending Agents", "Agenti del Dunland" },
                { "Evil Under the Moon", "Il Male Sotto La Luna" },
                { "False Lead", "Falsa Pista" },
                { "Fatty Bolger", "Grassotto Bolgeri" },
                { "Fear! Fire! Foes!", "Paura! Fuoco! Nemici!" },
                { "Flinthoof", "Zoccoselce" },
                { "Garrison Barracks", "Caserma della Guarnigione" },
                { "Gathering Clues", "Raccogliere Indizi" },
                { "Great Mead Hall", "Grande Sala dei Banchetti" },
                { "Hold the Hilltop", "Tenere la Collina" },
                { "Horn-call of Buckland", "Richiamo del Corno di Buck" },
                { "Horse Lord's Lodge", "Loggia del Signore dei Cavalli" },
                { "Horse Thieves' Hovel", "Stamberga dei Ladri di Cavalli" },
                { "Letter from Dunland", "Lettera dal Dunland" },
                { "Misty Street", "Strada Nebbiosa" },
                { "Overburdened", "Oberato" },
                { "Pommel-pouncer", "Balza-pomello" },
                { "Prison Key", "Chiave della Prigione" },
                { "Raven Signet Ring", "Anello con Sigillo del Corvo" },
                { "Red Fletched Arrow", "Freccia con Impennatura Rossa" },
                { "Red Harvest", "Un Raccolto Rosso" },
                { "Rein-ripper", "Strappa-redini" },
                { "Rohirric Coins", "Monete dei Rohirrim" },
                { "Ruby Cloak-pin", "Spilla da Mantello Scarlatta" },
                { "Saddle-slasher", "Squarcia-sella" },
                { "Silver Dagger", "Pugnale d'Argento" },
                { "Spoiled Pasture", "Pascolo Rovinato" },
                { "Spreading Inferno", "Incendio Dilagante" },
                { "Sudden Ambush", "Imboscata Improvvisa" },
                { "Taken by the Night", "Preso dalla Notte" },
                { "The Armoury", "L'Armeria" },
                { "The Horse's Tail", "La Coda del Cavallo" },
                { "The King's Stallion", "Lo Stallone del Re" },
                { "The Last Alliance", "L'Ultima Alleanza" },
                { "The Last Push", "L'Ultimo Sforzo" },
                { "The Man with the Twisted Lip", "L'Uomo dal Labbro Spaccato" },
                { "The Prisoner in White", "Il Prigioniero in Bianco" },
                { "The Spy Master", "Il Capo delle Spie" },
                { "The Sweeping Tide", "Un'Ondata Travolgente" },
                { "The Uncertain Dawn", "Un'Alba Incerta" },
                { "The Whisperer", "Colei che Sussurra" },
                { "There and Back Again", "Andata e Ritorno" },
                { "Thieves and Coursers", "Predoni e Corsieri" },
                { "Thirst for Horse Blood", "Sete di Sangue di Cavallo" },
                { "Town Guard", "Guardia Cittadina" },
                { "Traitor's Confession", "Confessione del Traditore" },
                { "Weep No More!", "Freniamo il Pianto!" },
                { "Well-lit Hall", "Sala Illuminata" },
                { "Whisperer in the Darkness", "Colei che Sussurra nelle Tenebre" },
                { "Young Tom", "Giovane Tom" },
            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string>
            {
                { "Assassin.", "Assassino." },
                { "Brigand.", "Brigante." },
                { "Camp.", "Campo." },
                { "Clue.", "Indizio." },
                { "Creature.", "Creatura." },
                { "Garrison.", "Guarnigione." },
                { "Gate.", "Cancello." },
                { "Hills.", "Colline." },
                { "Inferno.", "Incendio." },
                { "Mount.", "Cavalcatura." },
                { "Noble.", "Nobile." },
                { "Orc.", "Orco." },
                { "Plains.", "Pianure." },
                { "Road.", "Strada." },
                { "Scout.", "Esploratore." },
                { "Servant.", "Servitore." },
                { "Shirriff.", "Guardacontea." },
                { "Skill.", "Abilità." },
                { "Spy.", "Spia." },
                { "Stair.", "Scala." },
                { "Suspicious.", "Sospetto." },
                { "Traitor.", "Traditore." },
                { "Trap.", "Trappola." },
                { "Village.", "Villaggio." },
                { "Warrior.", "Guerriero." },
                { "Weather.", "Clima." },
                { "Woodman.", "Guardaboschi." },
        };
    }

    }
}