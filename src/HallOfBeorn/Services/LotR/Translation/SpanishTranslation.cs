﻿using System;
using System.Collections.Generic;
using System.Linq;

using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class SpanishTranslation
        : ITranslation
    {
        public Language Lang
        {
            get { return Language.ES; }
        }

        public Dictionary<string, string> CardTypeNames()
        {
            return new Dictionary<string, string> {
                { "Player", "Jugador" },
                { "Hero", "Héroe" },
                { "Ally", "Aliado" },
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

        public Dictionary<string, string> Keywords()
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
                { "Ranged.", "A distancia." },
                { "Restricted.", "Restringido." },
                { "Sentinel.", "Centinela." },
                { "Surge.", "Oleada." },
                { "Vast.", "Vasto." },
            };
        }

        //áÁéÉíÍóÓùúûüÙÚÛÜñÑ
        public Dictionary<string, string> Titles()
        {
            return new Dictionary<string, string> {
                { "Brok Ironfist", "Brok Puñohierro" },
                { "Dungeon Torch", "Antorcha de la Mazmorra" },
                { "Erebor Hammersmith", "Herrero de Erebor" },
                { "Forest Spider", "Araña del Bosque" },
                { "Guard of the Citadel", "Guardia de La Ciudadela" },
                { "Horseback Archer", "Arquero a Caballo" },
                { "Longbeard Orc Slayer", "Mataorcos de Barba Larga" },
                { "Miner of the Iron Hills", "Minero de las Colinas de Hierro" },
                { "Silverlode Archer", "Arquero del Cauce de Plata" },
                { "Veteran Axehand", "Soldado con Hacha Veterano" },

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
                { "The Sweeping Tide", "La Marea Incontrolable" },
            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string> {
                { "Archer.", "Arquero." },

                { "Beorning.", "Beórnida." },
                { "Brigand.", "Bandido." },

                { "Camp.", "Campamento." },
                { "Craftsman.", "Artesano." },
                { "Creature.", "Criatura." },
                
                { "Dunland.", "Tierras Brunas." },
                { "Dwarf.", "Enano." },
                
                { "Eagle.", "Águila." },

                { "Gate.", "Puerta." },

                { "Hills.", "Colinas." },

                { "Item.", "Objeto." },

                { "Mount.", "Montura." },

                { "Orc.", "Orco." },

                { "Plains.", "Llanuras." },

                { "Ranger.", "Montaraz." },
                { "Road.", "Camino." },
                
                { "Scout.", "Explorador." },
                { "Servant.", "Servidor." },
                { "Silvan.", "Silvano." },
                { "Skill.", "Habilidad." },
                { "Spider.", "Araña." },
                { "Stair.", "Escalera." },
                
                { "Traitor.", "Traidor." },
                { "Trap.", "Trampa." },
                { "Village.", "Aldea." },
                { "Warrior.", "Guerrero." },
                { "Weather.", "Tiempo atmosférico." },
            };
        }
    }
}