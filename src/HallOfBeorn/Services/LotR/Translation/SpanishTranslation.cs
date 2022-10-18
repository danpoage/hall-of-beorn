using System;
using System.Collections.Generic;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class SpanishTranslation
        : TranslationBase
    {
        public SpanishTranslation()
            : base(Language.ES)
        {
        }

        protected override Dictionary<string, string> AddCardTypeNames()
        {
            return new Dictionary<string, string> {
                { "Player", "Jugador" },
                { "Hero", "Héroe" },
                { "Ally", "Aliado" },
                { "Cave", "Caverna" },
                { "Character", "Personaje" },
                { "Attachment", "Vinculada" },
                { "Contract", "Contrato" },
                { "Event", "Evento" },
                { "Player-Side-Quest", "Búsqueda Secundaria del Jugador" },
                { "Encounter", "Encuentro" },
                { "Enemy", "Enemigo" },
                { "Location", "Lugar" },
                { "Treachery", "Traición" },
                { "Objective", "Objetivo" },
                { "Encounter-Side-Quest", "Búsqueda Secundaria del Encruentro" },
                { "Quest", "Búsqueda" },
            };
        }

        protected override Dictionary<string, string> AddKeywords()
        {
            return new Dictionary<string, string> {
                { "Archery 1.", "Tiro con arco 1." },
                { "Archery 2.", "Tiro con arco 2." },
                { "Archery X.", "Tiro con arco X." },
                { "Devoted.", "Devoto." },
                { "Doomed 1.", "Maldito 1." },
                { "Guarded.", "Protegido." },
                { "Guarded (enemy).", "Protegido (Enemigo)." },
                { "Guarded (location).", "Protegido (Lugar)." },
                { "Looter 0.", "Saqueador 0." },
                { "Looter 1.", "Saqueador 1." },
                { "Looter 2.", "Saqueador 2." },
                { "Looter 3.", "Saqueador 3." },
                { "Peril.", "Peligro." },
                { "Ranged.", "A distancia." },
                { "Restricted.", "Restringido." },
                { "Secrecy 1.", "En secreto 1." },
                { "Sentinel.", "Centinela." },
                { "Steeds 1 Per Player.", "Corceles 1 Per Player." },
                { "Steeds 1.", "Corceles 1." },
                { "Steeds 2.", "Corceles 2." },
                { "Steeds 3.", "Corceles 3." },
                { "Steeds 4.", "Corceles 4." },
                { "Surge.", "Oleada." },
                { "Time 7.", "Tiempo 7." },
                { "Vast.", "Vasto." },
            };
        }

        //áÁéÉíÍóÓùúûüÙÚÛÜñÑ
        protected override Dictionary<string, string> AddTitles()
        {
            var all = new Dictionary<string, string>();

            //Core Set
            SafeMap(all, new Dictionary<string, string> {
                { "Brok Ironfist", "Brok Puñohierro" },
                { "Dungeon Torch", "Antorcha de la Mazmorra" },
                { "Erebor Hammersmith", "Herrero de Erebor" },
                { "Forest Spider", "Araña del Bosque" },
                { "Guard of the Citadel", "Guardia de La Ciudadela" },
                { "Horseback Archer", "Arquero a Caballo" },
                { "Longbeard Orc Slayer", "Mataorcos de Barba Larga" },
                { "Miner of the Iron Hills", "Minero de las Colinas de Hierro" },
                { "Silverlode Archer", "Arquero del Cauce de Plata" },
                { "Veteran Axehand", "Soldado con Hacha Veterano" }
            });

            //Children of Eorl
            SafeMap(all, new Dictionary<string,string> {
                { "Defend the Beacon", "Defiende la Almenara" },
                { "Deeping Bowman", "Arquero del Muro del Bajo" },
                { "Open the Gates", "Abrir las Puertas" },
                { "Wealth of Adventure", "Riqueza de la Aventura" },
                { "Feast of Plenty", "Banquete Abundante" },
                { "Deeping Defender", "Defensor del Muro del Bajo" },
                { "Morwen Steelsheen", "Morwen Resplandor del Acero" },
                { "It Should Be Spared", "Debería Ser Perdonado" },
                { "Spring the Trap", "Activar la Trampa" },
                { "Squire of the Mark", "Escudera de la Marca" },
                { "Rammas Lookout", "Vigía de Rammas" },
                { "Light-footed Steed", "Corcel Veloz" },
                { "Rammas Sentry", "Centinela de Rammas" },
                { "Live Bait", "Cebo Vivo" },
                { "Worthy of Remembrance", "Digno de Recuerdo" },
                { "Need Brooks No Delay", "La Necesidad no Espera" },
                { "Wild Country", "Campo Salvaje" },
                { "Endless Grasslands", "Pradera Interminable" },
                { "Windworn Villages", "Aldeas Azotadas por el Viento" },
                { "Humpbacked Downs", "Lomas Jorobadas" },
                { "Ride Through the Night", "Cabalgata Nocturna" },
                { "The Green Sea", "El Mar Verde" },
                { "Cold from the Mountains", "Frío de las Montañas" },
                { "Exhausting Winds", "Vientos Agotadores" },
                { "Tired and Hungry", "Cansado y Hambriento" },
                { "Exposed to the Elements", "Expuestos a los Elementos" },
                { "Old Farmhouse", "Antigua Granja" },
                { "Abandoned Mill", "Molino Abandonado" },
                { "Dunland Chieftain", "Caudillo de las Tierras Brunas" },
                { "Wild Ravager", "Devastador Salvaje" },
                { "Dunlending Berserker", "Bersérker Dunlendino" },
                { "Hillman Scout", "Explorador Montañés" },
                { "Surprise Attack", "Ataque Sorpresa" },
                { "A History of Strife", "Una Historia de Rencores" },
                { "Recreant Rider", "Jinete Abyecto" },
                { "Deadly Defector", "Desertor Letal" },
                { "Orc Battalion", "Batallón de Orcos" },
                { "Servant of the Eye", "Sirviente del Ojo" },
                { "Black Land Scouts", "Exploradores de la Tierra Negra" },
                { "Orcish Horse-butcher", "Carnicero de Caballos Orco" },
                { "Crimson Banner", "Estandarte Carmesí" },
                { "White Mountain Reinforcements", "Refuerzos de las Montañas Blancas" },
                { "Brigand Ringleader", "Cabecilla de los Bandidos" },
                { "Plundered Goods", "Bienes Saqueados" },
                { "Pillaging Swordsman", "Espadachín Saqueador" },
                { "Grasping Slaver", "Esclavista Avaro" },
                { "Vengeful Bowman", "Arquero Vengativo" },
                { "Sneaky Thief", "Ladrón Furtivo" },
                { "Erelas Gates", "Puertas de Erelas" },
                { "Crossroads", "Encrucijada" },
                { "Erelas Stables", "Establos de Erelas" },
                { "Chaos in the Hills", "Caos en las Colinas" },
                { "Looted Weapons", "Armas Saqueadas" },
                { "Stockpile Barricade", "Barricada de Reservas" },
                { "Erelas Beacon", "Almenara de Erelas" },
                { "Host of Rohan", "Hueste de Rohan" },
                { "Enraged Dunlending", "Dunlendino Enfurecido" },
                { "Bald Hill", "Colina Calva" },
                { "Wooden Barricade", "Barricada de Madera" },
                { "Rocky Slope", "Pendiente Rocosa" },
                { "Surrounding Grassland", "Pastizales Circundantes" },
                { "Narrow Stair", "Escalera Estrecha" },
                { "From All Sides", "Desde Todos Lados" },
                { "Another Wave", "Otra Ola" },
                { "Assault Upon Erelas", "Asalto a Erelas" },
                { "Reclaim the Beacon", "Recupera la Almenara" },
                { "Stolen Steeds", "Corceles Robados" },
                { "Flinthoof", "Cascoduro" },
                { "Brightmane", "Crinbrillante" },
                { "Saddle-slasher", "Corta-Sillas" },
                { "Rein-ripper", "Arranca-Riendas" },
                { "Bridle-biter", "Muerde-Bridas" },
                { "Pommel-pouncer", "Salta-Pomos" },
                { "Spoiled Pasture", "Pasto Estropeado" },
                { "Horse Thieves' Hovel", "Antro de Ladrones de Caballos" },
                { "Horse Lord's Lodge", "Logia del Señor de los Caballos" },
                { "Thirst for Horse Blood", "Sed de Sangre de Caballo" },
                { "Overburdened", "Sobrecargado" },
                { "The Last Alliance", "La Última Alianza" },
                { "Drive them Away", "Expulsarlos" },
                { "Ambush!", "¡Emboscada!" },
                { "Battle for the Hill", "Batalla por la Colina" },
                { "Hold the Hilltop", "Mantengan la Cima" },
                { "The Last Push", "El Último Empujón" },
                { "Thieves and Coursers", "Ladrones y Corceles" },
                { "The King's Stallion", "El Semental del Rey" },
                { "The Sweeping Tide", "La Marea Incontrolable" }
            });

            //The Aldburg Plot
            SafeMap(all, new Dictionary<string,string> {

                { "A Case of Identity", "Un Caso de Identidad" },
                { "A Fire Rises", "Un Fuego se Propaga" },
                { "A Lesson in Caution", "Una Lección de Precaución" },
                { "Aldburg Malcontent", "Descontento de Aldburg" },

                { "Buckland Shirriff", "Oficial de los Gamos" },
                { "Decrepit Hovel", "Choza Decrépita" },
                { "Dunlending Agents", "Agentes Dunlendinos" },
                { "Evil Under the Moon", "Maldad Bajo la Luna" },
                { "False Lead", "Pista Falsa" },
                { "Fatty Bolger", "Gordo Bolger" },
                { "Fear! Fire! Foes!", "¡Peligro! ¡Fuego! ¡Enemigos!" },
                { "Garrison Barracks", "Cuartel de la Guarnición" },
                { "Gathering Clues", "Reuniendo Pistas" },
                { "Great Mead Hall", "Gran Salón de Hidromiel" },
                { "Horn-call of Buckland", "Cuerno de los Gamos" },

                { "Letter from Dunland", "Carta de las Tierras Brunas" },
                { "Lily Cotton", "Lily Coto" },
                { "Misty Street", "Calle Brumosa" },
                
                { "Prison Key", "Llave de la Prisión" },
                { "Raven Signet Ring", "Anillo con Sello de Cuervo" },
                { "Red Fletched Arrow", "Flecha de Pluma Roja" },
                { "Red Harvest", "Cosecha Roja" },
                { "Rohirric Coins", "Monedas Rohirrim" },
                { "Ruby Cloak-pin", "Alfiler de Capa Rubí" },
                { "Silver Dagger", "Daga Plateada" },
                { "Spreading Inferno", "Infierno Esparciéndose" },
                { "Sudden Ambush", "Emboscada Repentina" },

                { "Taken by the Night", "Secuestrado por la Noche" },
                { "The Armoury", "La Armería" },
                { "The Horse's Tail", "La Cola de Caballo" },
                { "The Man with the Twisted Lip", "El Hombre del Labio Torcido" },
                { "The Prisoner in White", "El Prisionero de Blanco" },
                { "The Spy Master", "El Maestro de Espías" },
                { "The Uncertain Dawn", "El Amanecer Incierto" },
                { "The Whisperer", "La Susurradora" },
                { "There and Back Again", "Una Ida y una Vuelta" },
                { "Town Guard", "Guardia de la Ciudad" },
                { "Traitor's Confession", "Confesión del Traidor" },
                { "Weep No More!", "Dejemos de Llorar" },
                { "Well-lit Hall", "Salón Bien Iluminado" },
                { "Whisperer in the Darkness", "Susurradora en la Oscuridad" },
                { "Young Tom", "Joven Tom" }
            });

            //The Scouring of the Shire
            SafeMap(all, new Dictionary<string,string> {
                { "Against the Rules", "Contra Las Reglas" },
                { "Ambush Sharkey's Men", "Emboscar a los Hombres de Zarquino" },
                { "Awake! Fire, Foes! Awake!", "¡Despertad! ¡Fuego! ¡Enemigos! ¡Despertad!" },
                { "Brandywine Gate", "Puerta del Brandivino" },
                { "Brick Building", "Construcción de Ladrillos" },
                { "Bright Mail", "Cota de Malla Brillante" },
                { "Curse Upon the Shire", "Maldición Sobre la Comarca" },
                { "East Road", "Camino del Este" },
                { "Escorted “Prisoners”", "«Prisioneros» Bajo Escolta" },
                { "Feather-capped Shirriff", "Oficial con Sombrero Emplumado" },
                { "Find the Gaffer", "Encontrar al Tío" },
                { "Frodo Baggins", "Frodo Bolsón" },
                { "Gang of Ruffians", "Pandilla de Rufianes" },
                { "Gríma's Choice", "La Decisión de Gríma" },
                { "Heightened Stature", "Estatura Aumentada" },
                { "Hidden Blade", "Puñal Escondido" },
                { "Highway Robber", "Asaltante de Caminos" },
                { "Hobbiton Road", "Camino de Hobbiton" },
                { "Into the West", "Rumbo al Oeste" },
                { "Many Partings", "Numerosas Separaciones" },
                { "Muster the Tooks", "Reunir a los Tuk" },
                { "Once Beloved Place", "Lugar Antes Tan Querido" },
                { "One Ill Turn", "Un Acto Vil" },
                { "Raise the Shire", "Sublevar a la Comarca" },
                { "Rouse the Cottons", "Reclutar a los Coto" },
                { "Roused Hobbits", "Hobbits Incitados" },
                { "Scatha's Horn", "Cuerno de Scatha" },
                { "Set up Barriers", "Levantar Barricadas" },
                { "Sharkey's Men", "Hombres de Zarquino" },
                { "Shirriff House", "Casa de los Oficiales" },
                { "Star-like Gem", "Gema Como Una Estrella" },
                { "Take Him, Lads!", "¡Prendedlo, Muchachos!" },
                { "The Battle of Bywater", "La Batalla de Delagua" },
                { "The Lockholes", "Celdas Agujeros" },
                { "The Scouring of the Shire", "El Saneamiento de la Comarca" },
                { "The Very Last Stroke", "El Golpe Definitivo" },
                { "Thieving Ruffian", "Rufián Bandido" },
                { "Three-Farthing Stone", "Piedra de las Tres Cuadernas" },
                { "To the Road Again, Worm!", "¡A los Caminos, Serpiente!" },
                { "Voice of Saruman", "La Voz de Saruman" },
                { "Watch the East Road", "Vigilar el Camino del Este" },
                { "Wooden Shed", "Cobertizo de Madera" }
            });

            //Fire on the Eastemnet
            SafeMap(all, new Dictionary<string,string> {
                { "Box of Earth", "Caja de Tierra" },
                { "Breath of Arda", "Aliento de Arda" },
                { "Captured Steeds", "Corceles Capturados" },
                { "Chieftain of the Skies", "Jefe de los Cielos" },
                { "Cracking Horse Whip", "Látigo Restallante" },
                { "Eastemnet Pasture", "Pastura del Estemnet" },
                { "Entwash Crossings", "Cruces del Entaguas" },
                { "Exhausted Pursuit", "Persecución Agotadora" },
                { "Expanded Search", "Búsqueda Ampliada" },
                { "Fang", "Colmillo" },
                { "Golden Crown", "Corona de Oro" },
                { "Grip", "Garra" },
                { "Guided by Fate", "Guiada por el Destino" },
                { "Hidden Orc Camp", "Campamento Orco Escondido" },
                { "Hidden Roosts", "Nidos Ocultos" },
                { "Messenger of Manwë", "Mensajero de Manwë" },
                { "Open Meadows", "Prados Abiertos" },
                { "Orc Lookout", "Vigía Orco" },
                { "Orcish Wrangler", "Cuatrero Orco" },
                { "Panicked Horses", "Caballos Aterrados" },
                { "Pillaged Stables", "Establos Saqueados" },
                { "Poachers in the Night", "Cazadores Furtivos en la Noche" },
                { "Relentless Forces", "Fuerzas Implacables" },
                { "Roving Herbmaster", "Herborista Errante" },
                { "Shores of Anduin", "Orillas del Anduin" },
                { "To the River!", "¡Al Río!" },
                { "Veteran Eagle", "Águila Veterana" },
                { "White Mountain Beastmaster", "Amo de Bestias de las Montañas Blancas" },
                { "Wild Steeds", "Corceles Salvajes" },
                { "Wolf", "Lobo" }
            });

            //The Gap of Rohan
            SafeMap(all, new Dictionary<string,string> {
                { "A Dangerous Pursuit", "Una Persecución Peligrosa" },
                { "A Stout Heart", "Un Corazón a Toda Prueba" },
                { "Archet Alekeeper", "Tabernero de Archet" },
                { "Barliman Butterbur", "Cebadilla Mantecona" },
                { "Biting Winds", "Vientos Penetrantes" },
                { "Bree Pony", "Póney de Bree" },
                { "Bree-land Protector", "Protectora de las Tierras de Bree" },
                { "Dunlending Rearguard", "Retaguardia Dunlendina" },
                { "Exposed Ridge", "Cresta Expuesta" },
                { "Frantic Dunlending", "Dunlendino Frenético" },
                { "Frozen Lake", "Lago Congelado" },
                { "Frozen Solid", "Congelado" },
                { "Gálmód’s Escort", "Escolta de Gálmód" },
                { "Gift of Foresight", "Don de la Previsión" },
                { "Giving Chase", "Dando Caza" },
                { "Half-pint", "Media Pinta" },
                { "Harry Goatleaf", "Enrique Madreselva" },
                { "Pint", "Pinta" },
                { "Recapture the Traitor", "Recapturar al Traidor" },
                { "Scheming Staddler", "Intrigante de Entibo" },
                { "Seasoned Forager", "Recolector Experto" },
                { "Slippery Hill", "Colina Resbaladiza" },
                { "Snow Squall", "Borrasca de Nieve" },
                { "Snowbank", "Banco de Nieve" },
                { "Stumble in the Snow", "Tropiezo en la Nieve" },
                { "Unnatural Cold", "Frío Antinatural" },
                { "White Wall", "Muro Blanco" },
            });

            //The Glittering Caves
            SafeMap(all, new Dictionary<string, string> {
                { "Alluring Paths", "Caminos Seductores" },
                { "Cave Opening", "Pasaje Abierto" },
                { "Crossroads", "Encrucijada" },
                { "Dark Pit", "Pozo Oscuro" },
                { "Dead End", "Cueva sin Salida" },
                { "Echoes in the Deep", "Ecos en el Abismo" },
                { "Forgotten Shade", "Sombra Olvidada" },
                { "Fork", "Bifurcación" },
                { "Guard the Entrance!", "¡Vigilen la Entrada!" },
                { "Guarded Hall", "Salón Protegido" },
                { "Harlond Lookout", "Vigía de Harlond" },
                { "Helm Hammerhand", "Helm Mano de Hierro" },
                { "Helm's Horn", "Cuerno de Helm" },
                { "Jewelled Cavern", "Cueva Enjoyada" },
                { "Killing With Fear", "Matar de Miedo" },
                { "Lay of the Nauglamír", "Balada del Nauglamír" },
                { "Legacy of Gondolin", "Legado de Gondolin" },
                { "Locked Door", "Puerta Cerrada" },
                { "Lurking Ghûl", "Ghûl Acechante" },
                { "Onward Into Battle", "Denodado en la Batalla" },
                { "Radiant Caverns", "Cavernas Radiantes" },
                { "Relic of Nargothrond", "Reliquia de Nargothrond" },
                { "Salvaged Supplies", "Suministros Recuperados" },
                { "Search the Caves", "Registrar las Cavernas" },
                { "Secret Passage", "Pasadizo Secreto" },
                { "Small Stream", "Arroyo Pequeño" },
                { "Stairwell", "Escalinata" },
                { "The Horn's Discovery", "El Hallazgo del Cuerno" },
                { "Tunnel", "Túnel" },
                { "Twisting Paths", "Caminos Serpenteantes" },
                { "Vast Cave", "Cueva Inmensa" },
                { "Wandering Spirit", "Espíritu Errante" },
                { "Wonders of Aglarond", "Maravillas de Aglarond" },
            });

            return all;
        }

        protected override Dictionary<string, string> AddTraits()
        {
            /*
                
                
             */

            return new Dictionary<string, string> {
                { "Archer.", "Arquero." },
                { "Armor.", "Armadura." },
                { "Artifact.", "Artefacto." },
                { "Assassin.", "Asesino." },

                { "Beorning.", "Beórnida." },
                { "Brigand.", "Bandido." },

                { "Camp.", "Campamento." },
                { "Clue.", "Pista." },
                { "Condition.", "Condición." },
                { "Craftsman.", "Artesano." },
                { "Creature.", "Criatura." },
                
                { "Doom.", "Perdición." },
                { "Dunland.", "Tierras Brunas." },
                { "Dwarf.", "Enano." },
                
                { "Eagle.", "Águila." },

                { "Garrison.", "Guarnición." },
                { "Gate.", "Puerta." },
                { "Gift.", "Regalo." },

                { "Healer.", "Curandero." },
                { "Hideout.", "Escondrijo." },
                { "Hill.", "Colina." },
                { "Hills.", "Colinas." },

                { "Inferno.", "Infierno." },
                { "Item.", "Objeto." },

                { "Lake.", "Lago." },

                { "Mount.", "Montura." },
                { "Mountain.", "Montaña." },

                { "Orc.", "Orco." },

                { "Plains.", "Llanuras." },

                { "Ranger.", "Montaraz." },
                { "River.", "Río." },
                { "Road.", "Camino." },
                { "Ruffian.", "Rufián." },
                
                { "Scout.", "Explorador." },
                { "Servant.", "Servidor." },
                { "Sharkey.", "Zarquino." },
                { "Shire.", "Comarca." },
                { "Shirriff.", "Oficial de la Comarca." },
                { "Silvan.", "Silvano." },
                { "Skill.", "Habilidad." },
                { "Snow.", "Nieve." },
                { "Song.", "Canción." },
                { "Spider.", "Araña." },
                { "Spirit.", "Espíritu." },
                { "Spy.", "Espía." },
                { "Stair.", "Escalera." },
                { "Stalking.", "Acechando." },
                { "Stream.", "Arroyo." },
                { "Summoned.", "Convocado." },
                { "Suspicious.", "Sospechoso." },
                
                { "Traitor.", "Traidor." },
                { "Trap.", "Trampa." },

                { "Undead.", "Muerto viviente." },
                { "Underground.", "Subterráneo." },

                { "Village.", "Aldea." },
                
                { "Warrior.", "Guerrero." },
                { "Weather.", "Tiempo atmosférico." },
                { "Westfold.", "Folde Oeste." },
                { "Woodman.", "Leñador." },
                { "Wraith.", "Espectro." },
            };
        }
    }
}