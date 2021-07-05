using System;
using System.Collections.Generic;
using HallOfBeorn.Models;

namespace HallOfBeorn.Services.LotR.Translation
{
    public class FrenchTranslation
        : ITranslation
    {
        public Language Lang
        {
            get { return Language.FR; }
        }

        public Dictionary<string, string> CardTypeNames()
        {
            return new Dictionary<string, string> {
                { "Player", "Joueur" },
                { "Hero", "Héros" },
                { "Ally", "Allié" },
                { "Character", "Personnage" },
                { "Attachment", "Attachement" },
                { "Event", "Événement" },
                { "Encounter", "Rencontrer" },
                { "Enemy", "Ennemi" },
                { "Location", "Lieu" },
                { "Treachery", "Traîtrise" },
                { "Objective", "Objectif" },
                { "Quest", "Quête" },
            };
        }

        public Dictionary<string, string> Keywords()
        {
            return new Dictionary<string, string> {
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
            };
        }

        public Dictionary<string, string> Titles()
        {
            return new Dictionary<string, string> {
                { "Guard of the Citadel", "Garde de la Citadelle" },

                { "Defend the Beacon", "Défendre le Feu d'Alarme" },
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

            };
        }

        public Dictionary<string, string> Traits()
        {
            return new Dictionary<string, string> {
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

            };
        }
    }
}