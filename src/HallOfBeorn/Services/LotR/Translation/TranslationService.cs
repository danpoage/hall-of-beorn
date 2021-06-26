﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using HallOfBeorn.Models;
using HallOfBeorn.Models.LotR;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class TranslationService : ITranslationService
    {
        public TranslationService()
        {
            cardTypeNameMap.Add(Language.DE, new Dictionary<string, string> {
                { "Hero", "Held" },
                { "Ally", "Verbündeter" },
                { "Attachment", "Verstärkung" },
                { "Event", "Ereignis" },
                { "Enemy", "Gegner" },
            });

            cardTypeNameMap.Add(Language.ES, new Dictionary<string, string> {
                { "Hero", "Héroe" },
                { "Ally", "Aliado" },
                { "Attachment", "Vinculada" },
                { "Event", "Evento" },
                { "Enemy", "Enemigo" }
            });

            cardTypeNameMap.Add(Language.FR, new Dictionary<string, string> {
                { "Hero", "Héros" },
                { "Ally", "Allié" },
                { "Attachment", "Attachement" },
                { "Event", "Événement" },
                { "Enemy", "Ennemi" }
            });

            keywordMap.Add(Language.DE, new Dictionary<string, string> {
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

            });

            keywordMap.Add(Language.ES, new Dictionary<string, string> {
                //CoE
                { "Ranged.", "A distancia." },
                { "Devoted.", "Devoto." },
                { "Doomed 1.", "Maldito 1." },
                { "Vast.", "Vasto." },
                { "Archery 2.", "Tiro con arco 2." },
                { "Surge.", "Oleada." },
                { "Looter 3.", "Saqueador 3." },
                { "Looter 1.", "Saqueador 1." },
                { "Looter 2.", "Saqueador 2." },
                { "Archery X.", "Tiro con arco X." },
                { "Looter 0.", "Saqueador 0." },
                { "Sentinel.", "Centinela." },
                { "Archery 1.", "Tiro con arco 1." },
                { "Guarded (enemy).", "Protegido (Enemigo)." },
                { "Restricted.", "Restringido." },
                { "Guarded (location).", "Protegido (Lugar)." },
            });

            keywordMap.Add(Language.FR, new Dictionary<string, string> {
                { "Ranged.", "À distance." },
                { "Devoted.", "Dévoué." },
                { "Doomed 1.", "Maudit 1." },
                { "Vast.", "Vaste." },
                { "Archery 2.", "Archerie 2." },
                { "Surge.", "Renfort." },
                { "Looter 3.", "Maraude 3." },
                { "Looter 1.", "Maraude 1." },
                { "Looter 2.", "Maraude 2." },
                { "Archery X.", "Archerie X." },
                { "Looter 0.", "Maraude 0." },
                { "Sentinel.", "Sentinelle." },
                { "Archery 1.", "Archerie 1." },
                { "Guarded (enemy).", "Protégé (ennemi)." },
                { "Restricted.", "Restreint." },
                { "Guarded (location).", "Protégé (lieu)." },
            });

            keywordMap.Add(Language.IT, new Dictionary<string, string>
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
            });

            keywordMap.Add(Language.PL, new Dictionary<string, string>
            {
                { "Ranged.", "Dystans." },
                { "Devoted.", "Oddany." },
                { "Doomed 1.", "Zguba 1." },
                { "Vast.", "Rozlegly." },
                { "Archery 2.", "Lucznictwo 2." },
                { "Surge.", "Mroczna fala." },
                { "Looter 3.", "Zlupienie 3." },
                { "Looter 1.", "Zlupienie 1." },
                { "Looter 2.", "Zlupienie 2." },
                { "Archery X.", "Lucznictwo X." },
                { "Looter 0.", "Zlupienie 0." },
                { "Sentinel.", "Wartownik." },
                { "Archery 1.", "Lucznictwo 1." },
                { "Guarded (enemy).", "Strzezony (wróg)." },
                { "Restricted.", "Ograniczenie." },
                { "Guarded (location).", "Strzezony (obszar)." },
            });

            titleMap.Add(Language.DE, new Dictionary<string, string> {
                { "Guard of the Citadel", "Wächter der Veste" },

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
            });

            titleMap.Add(Language.ES, new Dictionary<string, string> {
                { "Guard of the Citadel", "Guardia de La Ciudadela" },
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
            });

            titleMap.Add(Language.FR, new Dictionary<string, string> {
                { "Guard of the Citadel", "Garde de la Citadelle" },

                { "Deeping Bowman", "Archer du Gouffre" },
                { "Open the Gates", "Ouvrez les Portes" },
                { "Wealth of Adventure", "Aventure Enrichissante" },
                { "Feast of Plenty", "Festin d'Abondance" },
                { "Deeping Defender", "Défenseur du Gouffre" },
                { "Morwen Steelsheen", "Morwen Lustre d'Acier" },
                { "It Should Be Spared", "Il Faut l'Épargner" },
                { "Spring the Trap", "Refermer le Piège" },
                { "Squire of the Mark", "Écuyer de la Marche" },
                { "Rammas Lookout", "Guetteur du Rammas" },
                { "Light-footed Steed", "Coursier au Pied Léger" },
                { "Rammas Sentry", "Sentinelle du Rammas" },
                { "Live Bait", "Appât vivant" },
                { "Worthy of Remembrance", "Digne de Souvenir" },
                { "Need Brooks No Delay", "Nécessité ne saurait attendre" },
                { "Wild Country", "Pays Sauvage" },
                { "Endless Grasslands", "Prairies Sans Fin" },
                { "Windworn Villages", "Villages Battus par les Vents" },
                { "Humpbacked Downs", "Côteaux Bossus" },
                { "Ride Through the Night", "Chevauchée Nocturne" },
                { "The Green Sea", "La Mer Verte" },
                { "Cold from the Mountains", "Froid des Montagnes" },
                { "Exhausting Winds", "Vents Éreintants" },
                { "Tired and Hungry", "Fatigué et Affamé" },
                { "Exposed to the Elements", "Exposé aux Éléments" },
                { "Old Farmhouse", "Vieille Grange" },
                { "Abandoned Mill", "Moulin Abandonné" },
                { "Dunland Chieftain", "Chef de Clan de Dun" },
                { "Wild Ravager", "Ravageur Sauvage" },
                { "Dunlending Berserker", "Berserker Dunlending" },
                { "Hillman Scout", "Éclaireur des Collines" },
                { "Surprise Attack", "Attaque Surprise" },
                { "A History of Strife", "Une Rivalité Ancestrale" },
                { "Recreant Rider", "Cavalier Renégat" },
                { "Deadly Defector", "Meurtrier Transfuge" },
                { "Orc Battalion", "Bataillon Orque" },
                { "Servant of the Eye", "Serviteur de l'Œil" },
                { "Black Land Scouts", "Éclaireurs des Terres Noires" },
                { "Orcish Horse-butcher", "Boucher Chevalin Orque" },
                { "Crimson Banner", "Bannière Pourpre" },
                { "White Mountain Reinforcements", "Renforts des Montagnes Blanches" },
                { "Brigand Ringleader", "Meneur Brigand" },
                { "Plundered Goods", "Biens Pillés" },
                { "Pillaging Swordsman", "Pillard Bretteur" },
                { "Grasping Slaver", "Chasseur d'Esclaves" },
                { "Vengeful Bowman", "Archer Vengeur" },
                { "Sneaky Thief", "Voleur Sournois" },
                { "Erelas Gates", "Portes de l'Erelas" },
                { "Crossroads", "La Croisée des Chemins" },
                { "Erelas Stables", "Étables de l'Erelas" },
                { "Chaos in the Hills", "Chaos dans les Collines" },
                { "Looted Weapons", "Armes Dérobées" },
                { "Stockpile Barricade", "Barricade de Fortune" },
                { "Erelas Beacon", "Feu d'Alarme de l'Erelas" },
                { "Host of Rohan", "Ost du Rohan" },
                { "Enraged Dunlending", "Dunlending Enragé" },
                { "Bald Hill", "Colline Pelée" },
                { "Wooden Barricade", "Barricade en Bois" },
                { "Rocky Slope", "Versants Rocheux" },
                { "Surrounding Grassland", "Prairies Environnantes" },
                { "Narrow Stair", "Escalier Étroit" },
                { "From All Sides", "De Tous les Côtés" },
                { "Another Wave", "Nouvelle Vague" },
                { "Assault Upon Erelas", "Assaut sur l'Erelas" },
                { "Reclaim the Beacon", "Reprendre le Feu d'Alarme" },
                { "Stolen Steeds", "Coursiers Volés" },
                { "Flinthoof", "Sabotdur" },
                { "Brightmane", "Claircrin" },
                { "Saddle-slasher", "Sabreur-de-Selle" },
                { "Rein-ripper", "Rompeur-de-Rêne" },
                { "Bridle-biter", "Broyeur-de-Bride" },
                { "Pommel-pouncer", "Arracheur-d'Arçon" },
                { "Spoiled Pasture", "Pâturage Dévasté" },
                { "Horse Thieves' Hovel", "Masure des Voleurs de Chevaux" },
                { "Horse Lord's Lodge", "Logis des Seigneurs des Chevaux" },
                { "Thirst for Horse Blood", "Soif de Sang Équin" },
                { "Overburdened", "Surchargé" },
                { "The Last Alliance", "La Dernière Alliance" },
                { "Drive them Away", "Repoussez-les" },
                { "Ambush!", "Embuscade !" },
                { "Battle for the Hill", "Bataille pour la Colline" },
                { "Hold the Hilltop", "Tenir le Sommet" },
                { "The Last Push", "L'Ultime Offensive" },
                { "Thieves and Coursers", "Voleurs et Coursiers" },
                { "The King's Stallion", "L'Étalon du Roi" },
                { "The Sweeping Tide", "Raz-de-Marée" },

            });

            titleMap.Add(Language.IT, new Dictionary<string, string>
            {
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
            });

            titleMap.Add(Language.PL, new Dictionary<string, string>
            {
                { "Deeping Bowman", "Helmowy Lucznik" },
                { "Open the Gates", "Otworzyc Brame" },
                { "Wealth of Adventure", "Bogactwo Przygody" },
                { "Feast of Plenty", "Swieto Obfitosci" },
                { "Deeping Defender", "Helmowy Obronca" },
                { "Morwen Steelsheen", "Morwena Kwiat ze Stali" },
                { "It Should Be Spared", "Nalezy go Oszczedzic" },
                { "Spring the Trap", "Uruchomic Pulapke" },
                { "Squire of the Mark", "Giermek Marchii" },
                { "Rammas Lookout", "Czujka Rammasu" },
                { "Théodwyn", "Théodwyna" },
                { "Light-footed Steed", "Chyzy Rumak" },
                { "Rammas Sentry", "Straznik Rammasu" },
                { "Live Bait", "Zywa Przyneta" },
                { "Worthy of Remembrance", "Godny Pamieci" },
                { "Need Brooks No Delay", "Lepiej pózno niz nigdy" },
                { "Wild Country", "Dziki Kraj" },
                { "Endless Grasslands", "Bezkresne Pastwiska" },
                { "Windworn Villages", "Wichrowe Wioski" },
                { "Humpbacked Downs", "Garbate Wzgórza" },
                { "Ride Through the Night", "Nocna Przejazdzka" },
                { "The Green Sea", "Zielone Morze" },
                { "Cold from the Mountains", "Chlód z Gór" },
                { "Exhausting Winds", "Wyczerpujace Wiatry" },
                { "Tired and Hungry", "Zmeczony i Glodny" },
                { "Exposed to the Elements", "Wystawiony na Zywioly" },
                { "Old Farmhouse", "Stara Farma" },
                { "Abandoned Mill", "Opuszczony Mlyn" },
                { "Dunland Chieftain", "Dunlandzki Wódz" },
                { "Wild Ravager", "Dziki Grabiezca" },
                { "Dunlending Berserker", "Dunlandzki Berserker" },
                { "Hillman Scout", "Zwiadowca ze Wzgórz" },
                { "Surprise Attack", "Niespodziewany Atak" },
                { "A History of Strife", "Historia Wojny" },
                { "Recreant Rider", "Zdradliwy Jezdziec" },
                { "Deadly Defector", "Zabójczy Dezerter" },
                { "Orc Battalion", "Zastep Orków" },
                { "Servant of the Eye", "Sluga Oka" },
                { "Black Land Scouts", "Zwiadowcy Czarnych Ziem" },
                { "Orcish Horse-butcher", "Orkowy Rzeznik Koni" },
                { "Crimson Banner", "Szkarlatny Sztandar" },
                { "White Mountain Reinforcements", "Posilki z Gór Bialych" },
                { "Brigand Ringleader", "Herszt Rozbójników" },
                { "Plundered Goods", "Spladrowane Dobra" },
                { "Pillaging Swordsman", "Szermierz Grabiezca" },
                { "Grasping Slaver", "Lowca Niewolników" },
                { "Vengeful Bowman", "Msciwy Lucznik" },
                { "Sneaky Thief", "Podstepny Zlodziej" },
                { "Erelas Gates", "Bramy Erelas" },
                { "Crossroads", "Rozdroza" },
                { "Erelas Stables", "Stajnie Erelas" },
                { "Chaos in the Hills", "Chaos Wsród Wzgórz" },
                { "Looted Weapons", "Zrabowana Bron" },
                { "Stockpile Barricade", "Wstrzymanie Zapasów" },
                { "Erelas Beacon", "Wzgórze Sygnalowe Erelas" },
                { "Host of Rohan", "Zastep Rohanu" },
                { "Enraged Dunlending", "Wsciekly Dunlending" },
                { "Bald Hill", "Lyse Wzgórze" },
                { "Wooden Barricade", "Drewniana Barykada" },
                { "Rocky Slope", "Skaliste Zbocze" },
                { "Surrounding Grassland", "Okoliczne Pastwiska" },
                { "Narrow Stair", "Waskie Schody" },
                { "From All Sides", "Ze Wszystkich Stron" },
                { "Another Wave", "Kolejna Fala" },
                { "Assault Upon Erelas", "Atak na Erelas" },
                { "Reclaim the Beacon", "Odzyskac Wzgórze Sygnalowe" },
                { "Stolen Steeds", "Skradzione Rumaki" },
                { "Flinthoof", "Krzemyk" },
                { "Brightmane", "Jasnogrzywy" },
                { "Saddle-slasher", "Siepacz Siodel" },
                { "Rein-ripper", "Rozpruwacz Cugli" },
                { "Bridle-biter", "Kasacz Uzd" },
                { "Pommel-pouncer", "Wysadzacz Jezdzców" },
                { "Spoiled Pasture", "Opuszczone Pastwisko" },
                { "Horse Thieves' Hovel", "Nora Koniokradów" },
                { "Horse Lord's Lodge", "Kwatera Wladcy Koni" },
                { "Thirst for Horse Blood", "Pragnienie Konskiej Krwi" },
                { "Overburdened", "Przeciazony" },
                { "The Last Alliance", "Ostatni Sojusz" },
                { "Drive them Away", "Pozbadzmy sie ich" },
                { "Ambush!", "Zasadzka!" },
                { "Battle for the Hill", "Bitwa o Wzgórze Sygnalowe" },
                { "Hold the Hilltop", "Utrzymac wzgórze!" },
                { "The Last Push", "Ostatnie natarcie" },
                { "Thieves and Coursers", "Koniokradzi" },
                { "The King's Stallion", "Królewskie rumaki" },
                { "The Sweeping Tide", "Nadciagajace niebezpieczenstwo" },
            });

            traitMap.Add(Language.DE, new Dictionary<string, string> {
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

            });

            traitMap.Add(Language.ES, new Dictionary<string, string> {
                { "Beorning.", "Beórnida." },
                { "Gondor.", "Góndor." },
                { "Warrior.", "Guerrero." },
                //CoE
                { "Ranger.", "Montaraz." },
                { "Skill.", "Habilidad." },
                { "Servant.", "Servidor." },
                { "Scout.", "Explorador." },
                { "Mount.", "Montura." },
                { "Trap.", "Trampa." },
                { "Plains.", "Llanuras." },
                { "Village.", "Aldea." },
                { "Weather.", "Tiempo atmosférico." },
                { "Dunland.", "Tierras Brunas." },
                { "Traitor.", "Traidor." },
                { "Orc.", "Orco." },
                { "Brigand.", "Bandido." },
                { "Gate.", "Puerta." },
                { "Road.", "Camino." },
                { "Hills.", "Colinas." },
                { "Stair.", "Escalera." },
                { "Camp.", "Campamento." },

            });

            traitMap.Add(Language.FR, new Dictionary<string, string> {
                { "Beorning.", "Beornide." },
                { "Ranger.", "Rôdeur." },
                { "Warrior.", "Guerrier." },

                { "Skill.", "Compétence." },
                { "Servant.", "Serviteur." },
                { "Scout.", "Éclaireur." },
                { "Mount.", "Monture." },
                { "Trap.", "Piège." },
                { "Plains.", "Plaines." },
                { "Weather.", "Climat." },
                { "Dunland.", "Pays de Dun." },
                { "Traitor.", "Traître." },
                { "Orc.", "Orque." },
                { "Gate.", "Porte." },
                { "Road.", "Route." },
                { "Hills.", "Collines." },
                { "Stair.", "Escalier." },

            });

            traitMap.Add(Language.IT, new Dictionary<string, string>
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
            });

            traitMap.Add(Language.PL, new Dictionary<string, string>
            {
                { "Warrior.", "Wojownik." },
                { "Ranger.", "Straznik." },
                { "Noble.", "Szlachcic." },
                { "Skill.", "Umiejetnosc." },
                { "Servant.", "Sluga." },
                { "Scout.", "Zwiadowca." },
                { "Mount.", "Wierzchowiec." },
                { "Trap.", "Pulapka." },
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
            });
        }

        private readonly TranslationMap cardTypeNameMap = new TranslationMap((s) => s.Replace('_', '-'));
        private readonly TranslationMap keywordMap = new TranslationMap();
        private readonly TranslationMap titleMap = new TranslationMap();
        private readonly TranslationMap traitMap = new TranslationMap();

        public string EnglishCardTypeName(Language lang, CardType type)
        {
            return cardTypeNameMap.GetEnglish(lang, Enum.GetName(typeof(CardType), type));
        }

        public string EnglishKeyword(Language lang, string keyword)
        {
            return keywordMap.GetEnglish(lang, keyword);
        }

        public string EnglishTitle(Language lang, string title)
        {
            return titleMap.GetEnglish(lang, title);
        }

        public string EnglishTrait(Language lang, string trait)
        {
            return traitMap.GetEnglish(lang, trait);
        }

        public string TranslateCardTypeName(Language lang, CardType type)
        {
            return cardTypeNameMap.GetTranslation(lang, type.ToString());
        }

        public string TranslateKeyword(Language lang, string keyword)
        {
            return keywordMap.GetTranslation(lang, keyword);
        }

        public string TranslateTitle(Language lang, string title)
        {
            return titleMap.GetTranslation(lang, title);
        }

        public string TranslateTrait(Language lang, string trait)
        {
            return traitMap.GetTranslation(lang, trait);
        }
    }
}