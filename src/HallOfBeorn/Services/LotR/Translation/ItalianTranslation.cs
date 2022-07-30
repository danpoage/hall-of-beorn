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
                
                { "Indestructible.", "Indistruttibile." },

                { "Looter 0.", "Saccheggiare 0." },
                { "Looter 1.", "Saccheggiare 1." },
                { "Looter 2.", "Saccheggiare 2." },
                { "Looter 3.", "Saccheggiare 3." },
                
                { "Peril.", "Pericolo." },

                { "Ranged.", "Gittata." },
                { "Restricted.", "Limitato." },

                { "Secrecy 1.", "Segretezza 1." },
                { "Sentinel.", "Sentinella." },
                { "Steeds 1 Per Player.", "Destrieri 1 Per Player." },
                { "Steeds 1.", "Destrieri 1." },
                { "Steeds 2.", "Destrieri 2." },
                { "Steeds 3.", "Destrieri 3." },
                { "Steeds 4.", "Destrieri 4." },
                { "Surge.", "Impeto." },

                { "Time 7.", "Tempo 7." },

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

                //Fire on the Eastemnet
                { "Box of Earth", "Scatola di Terra" },
                { "Breath of Arda", "Respiro di Arda" },
                { "Captured Steeds", "Destrieri Catturati" },
                { "Chieftain of the Skies", "Capitano dei Cieli" },
                { "Cracking Horse Whip", "Frusta Schioccante" },
                { "Eastemnet Pasture", "Pascoli dell'Estemnet" },
                { "Entwash Crossings", "Guadi dell'Entalluvio" },
                { "Exhausted Pursuit", "Inseguimento Sfiancante" },
                { "Expanded Search", "Ricerca a Tappeto" },
                { "Fang", "Zanna" },
                { "Golden Crown", "Corona Dorata" },
                { "Grip", "Morso" },
                { "Guided by Fate", "Guidato dal Fato" },
                { "Hidden Orc Camp", "Campo Nascosto degli Orchi" },
                { "Hidden Roosts", "Nidi Nascosti" },
                { "Messenger of Manwë", "Messaggero di Manwë" },
                { "Open Meadows", "Praterie Aperte" },
                { "Orc Lookout", "Sentinella Orchesca" },
                { "Orcish Wrangler", "Mandriano Orchesco" },
                { "Panicked Horses", "Cavalli Terrorizzati" },
                { "Pillaged Stables", "Stalle Saccheggiate" },
                { "Poachers in the Night", "Ladri nella Notte" },
                { "Relentless Forces", "Una Forza Inarrestabile" },
                { "Roving Herbmaster", "Erborista Errante" },
                { "Shores of Anduin", "Rive dell'Anduin" },
                { "To the River!", "Verso il Fiume!" },
                { "Veteran Eagle", "Aquila Veterana" },
                { "White Mountain Beastmaster", "Ammaestratore dei Monti Bianchi" },
                { "Wild Steeds", "Destrieri Selvaggi" },
                { "Wolf", "Lupo" },

                //The Gap of Rohan
                { "A Dangerous Pursuit", "Un Inseguimento Pericoloso" },
                { "A Stout Heart", "Un Cuore Coraggioso" },
                { "Archet Alekeeper", "Oste di Arceto" },
                { "Barliman Butterbur", "Omorzo Cactaceo" },
                { "Biting Winds", "Venti Mordenti" },
                { "Bree Pony", "Pony di Brea" },
                { "Bree-land Protector", "Custode della Terra di Brea" },
                { "Dunlending Rearguard", "Retroguardia Dunlandiana" },
                { "Exposed Ridge", "Cresta Esposta" },
                { "Frantic Dunlending", "Dunlandiano Forsennato" },
                { "Frozen Lake", "Lago Ghiacciato" },
                { "Frozen Solid", "Congelato" },
                { "Gálmód’s Escort", "Scorta di Gálmód" },
                { "Gift of Foresight", "Dono della Lungimiranza" },
                { "Giving Chase", "All'Inseguimento" },
                { "Half-pint", "Mezza Pinta" },
                { "Harry Goatleaf", "Harry Caprifoglio" },
                { "Pint", "Pinta" },
                { "Recapture the Traitor", "Catturare il Traditore" },
                { "Scheming Staddler", "Cospiratore di Staddle" },
                { "Seasoned Forager", "Foraggiatore Esperto" },
                { "Slippery Hill", "Pendio Scivoloso" },
                { "Snow Squall", "Tormenta di Neve" },
                { "Snowbank", "Banco di Neve" },
                { "Stumble in the Snow", "Sprofondare nella Neve" },
                { "Unnatural Cold", "Gelo Innaturale" },
                { "White Wall", "Muro Bianco" },

                //The Glittering Caves
                /* Determine the duplicat title entry...
                { "Alluring Paths", "Passaggi Affascinanti" },
                { "Cave Opening", "Ingresso" },
                { "Crossroads", "Incrocio" },
                { "Dark Pit", "Fossa Oscura" },
                { "Dead End", "Vicolo Cieco" },
                { "Echoes in the Deep", "Eco nelle Profondità" },
                { "Forgotten Shade", "Ombra Dimenticata" },
                { "Fork", "Diramazione" },
                { "Guard the Entrance!", "Sorvegliate l'Ingresso!" },
                { "Guarded Hall", "Stanza Sorvegliata" },
                { "Harlond Lookout", "Vedetta di Harlond" },
                { "Helm Hammerhand", "Helm Mandimartello" },
                { "Helm's Horn", "Corno di Helm" },
                { "Jewelled Cavern", "Caverna dei Gioielli" },
                { "Killing With Fear", "Un Terrore Letale" },
                { "Lay of the Nauglamír", "Lai della Nauglamír" },
                { "Legacy of Gondolin", "Eredità di Gondolin" },
                { "Locked Door", "Porta Bloccata" },
                { "Lurking Ghûl", "Ghûl in Agguato" },
                { "Onward Into Battle", "Verso la Battaglia" },
                { "Radiant Caverns", "Caverne Radiose" },
                { "Relic of Nargothrond", "Reliquia di Nargothrond" },
                { "Salvaged Supplies", "Equipaggiamento Recuperato" },
                { "Search the Caves", "Esplorare le Caverne" },
                { "Secret Passage", "Passaggio Segreto" },
                { "Small Stream", "Piccolo Torrente" },
                { "Stairwell", "Scalinata" },
                { "The Horn's Discovery", "La Scoperta del Corno" },
                { "Twisting Paths", "Sentieri Tortuosi" },
                { "Vast Cave", "Grotta Vasta" },
                { "Wandering Spirit", "Spirito Errante" },
                { "Wonders of Aglarond", "Meraviglie di Aglarond" },
                */

                //The Scouring of the Shire
                { "Against the Rules", "Vietato dalle Regole" },
                { "Ambush Sharkey's Men", "Tendere un Agguato" },
                { "Awake! Fire, Foes! Awake!", "Sveglia! Fuoco, Nemici! Sveglia!" },
                { "Brandywine Gate", "Cancello del Brandivino" },
                { "Brick Building", "Edificio di Mattoni" },
                { "Bright Mail", "Armatura Lucente" },
                { "Curse Upon the Shire", "Maledizione sulla Contea" },
                { "East Road", "Via Orientale" },
                { "Escorted “Prisoners”", "Scortare i Prigionieri" },
                { "Feather-capped Shirriff", "Guardacontea dal Cappello Piumato" },
                { "Find the Gaffer", "Trovare il Gaffiere" },
                { "Gang of Ruffians", "Banda di Furfanti" },
                { "Gríma's Choice", "La Scelta di Gríma" },
                { "Heightened Stature", "Statura Incrementata" },
                { "Hidden Blade", "Un Pugnale Nascosto" },
                { "Highway Robber", "Bandito di Strada" },
                { "Hobbiton Road", "Strada di Hobbiville" },
                { "Into the West", "Verso L'Ovest" },
                { "Many Partings", "Molte Separazioni" },
                { "Muster the Tooks", "Radunare i Tuc" },
                { "Once Beloved Place", "Luogo un Tempo Amato" },
                { "One Ill Turn", "Un Brutto Tiro" },
                { "Raise the Shire", "Sollevare la Contea" },
                { "Rouse the Cottons", "Destare i Cotton" },
                { "Roused Hobbits", "Hobbit Destati" },
                { "Scatha's Horn", "Corno di Scatha" },
                { "Set up Barriers", "Ergere Barricate" },
                { "Sharkey's Men", "Uomini di Sharkey" },
                { "Shirriff House", "Casa dei Guardacontea" },
                { "Star-like Gem", "Gemma a Stella" },
                { "Take Him, Lads!", "Prendetelo, Ragazzi!" },
                { "The Battle of Bywater", "La Battaglia di Lungacque" },
                { "The Lockholes", "Le Cellechiuse" },
                { "The Scouring of the Shire", "Percorrendo la Contea" },
                { "The Very Last Stroke", "Il Colpo Definitivo" },
                { "Thieving Ruffian", "Farabutto" },
                { "Three-Farthing Stone", "Pietra dei Tre Decumani" },
                { "To the Road Again, Worm!", "Sulla Strada, Verme!" },
                { "Voice of Saruman", "Voce di Saruman" },
                { "Watch the East Road", "Sorvegliare la Via Orientale" },
                { "Wooden Shed", "Capanno di Legno" },
            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string>
            {
                { "Armor.", "Armatura." },
                { "Artifact.", "Artefatto." },
                { "Assassin.", "Assassino." },
                { "Bree.", "Brea." },
                { "Brigand.", "Brigante." },
                { "Camp.", "Campo." },
                { "Clue.", "Indizio." },
                { "Condition.", "Condizione." },
                { "Creature.", "Creatura." },
                { "Doom.", "Fato." },
                { "Dwarf.", "Nano." },
                { "Eagle.", "Aquila." },
                { "Garrison.", "Guarnigione." },
                { "Gate.", "Cancello." },
                { "Gift.", "Dono." },
                { "Healer.", "Guaritore." },
                { "Hideout.", "Nascondiglio." },
                { "Hill.", "Collina." },
                { "Hills.", "Colline." },
                { "Inferno.", "Incendio." },
                { "Item.", "Oggetto." },
                { "Lake.", "Lago." },
                { "Mount.", "Cavalcatura." },
                { "Mountain.", "Montagna." },
                { "Noble.", "Nobile." },
                { "Orc.", "Orco." },
                { "Plains.", "Pianure." },
                { "River.", "Fiume." },
                { "Road.", "Strada." },
                { "Ruffian.", "Furfante." },
                { "Scout.", "Esploratore." },
                { "Servant.", "Servitore." },
                { "Shire.", "Contea." },
                { "Shirriff.", "Guardacontea." },
                { "Skill.", "Abilità." },
                { "Snow.", "Neve." },
                { "Song.", "Canzone." },
                { "Spirit.", "Spirito." },
                { "Spy.", "Spia." },
                { "Stair.", "Scala." },
                { "Stalking.", "Furioso." },
                { "Stream.", "Torrente." },
                { "Summoned.", "Evocato." },
                { "Suspicious.", "Sospetto." },
                { "Traitor.", "Traditore." },
                { "Trap.", "Trappola." },
                { "Undead.", "Non Morto." },
                { "Underground.", "Sotterraneo." },
                { "Village.", "Villaggio." },
                { "Warrior.", "Guerriero." },
                { "Weather.", "Clima." },
                { "Westfold.", "Ovestfalda." },
                { "Woodman.", "Guardaboschi." },
                { "Wraith.", "Spettro." },
        };
    }

    }
}