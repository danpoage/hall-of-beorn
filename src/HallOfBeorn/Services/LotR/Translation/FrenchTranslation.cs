﻿using System;
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
                { "A Chosen Path", "Le Chemin Choisi" },
                { "A Fork in the Road", "Un Embranchement sur la Route" },
                { "A Light in the Dark", "Une Lumière dans les Ténèbres" },
                { "A Test of Will", "Tester sa Volonté" },
                { "Ambush on the Shore", "Embuscade sur la Rive" },
                { "Anduin Passage", "Traversée de l'Anduin" },
                
                { "Banks of the Anduin", "Berges de l'Anduin" },
                { "Beorn's Hospitality", "Hospitalité de Beorn" },
                { "Beorn's Path", "Le Chemin de Beorn" },
                { "Black Forest Bats", "Chauves-Souris de la Forêt Noire" },
                { "Blade Mastery", "Maîtrise des Armes" },
                { "Blade of Gondolin", "Lame de Gondolin" },
                { "Brok Ironfist", "Brok Poing-de-Fer" },

                { "Caught in a Web", "Pris dans la Toile" },
                { "Cavern Guardian", "Garde de la Caverne" },
                { "Celebrían's Stone", "Pierre de Celebrían" },
                { "Chieftan Ufthak", "Chef Ufthak" },
                { "Citadel Plate", "Armure de la Citadelle" },
                { "Common Cause", "Cause Commune" },
                
                { "Dark Knowledge", "Savoir Ténébreux" },
                { "Daughter of the Nimrodel", "Fille de la Nimrodel" },
                { "Despair", "Désespoir" },
                { "Dol Guldur Beastmaster", "Maître des Bêtes de Dol Guldur" },
                { "Dol Guldur Orcs", "Orques de Dol Guldur" },
                { "Don't Leave the Path", "Ne Quittez pas le Chemin" },
                { "Driven by Shadow", "Conduit par l'Ombre" },
                { "Dungeon Jailor", "Geôlier des Cachots" },
                { "Dungeon Torch", "Torche du Donjon" },
                { "Dwarven Axe", "Hache de Nain" },
                { "Dwarven Tomb", "Tombe de Nain" },

                { "East Bight Patrol", "Patrouille de la Brèche Est" },
                { "Eastern Crows", "Corbeaux de l'Est" },
                { "Enchanted Stream", "Rivière Enchantée" },
                { "Endless Caverns", "Cavernes Sans Fin" },
                { "Erebor Hammersmith", "Forgeron d'Erebor" },
                { "Ever Vigilant", "Toujours Vigilant" },
                { "Evil Storm", "Tempête Malfaisante" },
                { "Eyes of the Forest", "Les Yeux de la Forêt" },

                { "Feint", "Feinte" },
                { "Flies and Spiders", "Mouches et Araignées" },
                { "For Gondor!", "Pour le Gondor!" },
                { "Forest Gate", "Entrée de la Forêt" },
                { "Forest Snare", "Danger de la Forêt" },
                { "Forest Spider", "Araignée des Forêts" },
                { "Fortune or Fate", "Chance ou Destin" },

                { "Gandalf's Map", "Carte de Gandalf" },
                { "Gandalf's Search", "Recherches de Gandalf" },
                { "Gladden Fields", "Champs d'Iris" },
                { "Goblin Sniper", "Tireur Embusqué Gobelin" },
                { "Gondorian Spearman", "Lancier Gondorien" },
                { "Great Forest Web", "Grande Toile de la Forêt" },
                { "Grim Resolve", "Détermination Acharnée" },
                { "Guard of the Citadel", "Garde de la Citadelle" },

                { "Hasty Stroke", "Coup Précipité" },
                { "Henamarth Riversong", "Henamarth Chantrivière" },
                { "Hill Troll", "Troll des Collines" },
                { "Horn of Gondor", "Cor du Gondor" },
                { "Horseback Archer", "Archer à Cheval" },
                { "Hummerhorns", "Vrombicornes" },

                { "Iron Shackles", "Chaînes en Fer" },
                { "King Spider", "Roi Araignée" },

                { "Longbeard Orc Slayer", "Chasseur d'Orques Longue Barbe" },
                { "Lore of Imladris", "Savoir d'Imladris" },
                { "Lórien Guide", "Guide de la Lórien" },
                { "Lórien's Wealth", "Opulence de la Lórien" },

                { "Marsh Adder", "Serpent des Marais" },
                { "Massing at Night", "Rassemblement Nocturne" },
                { "Miner of the Iron Hills", "Mineur des Monts du Fer" },
                { "Misty Mountain Goblins", "Gobelins des Monts Brumeux" },
                { "Mountains of Mirkwood", "Montagnes de la Forêt Noire" },

                { "Nazgûl of Dol Guldur", "Nazgûl de Dol Guldur" },
                { "Necromancer's Pass", "Col du Nécromancien" },
                { "Northern Tracker", "Traqueur du Nord" },

                { "Old Forest Road", "Route de la Vieille Forêt" },
                { "Out of the Dungeons", "S'enfuir des Cachots" },

                { "Power in the Earth", "Le Pouvoir de la Terre" },
                { "Protector of Lórien", "Protecteur de la Lórien" },
                { "Pursued by Shadow", "Poursuivi par l'Ombre" },

                { "Quick Strike", "Coup Rapide" },

                { "Radagast's Cunning", "Ruse de Radagast" },
                { "Rain of Arrows", "Pluie de Flèches" },

                { "Secret Paths", "Chemins Secrets" },
                { "Self Preservation", "Instinct de Survie" },
                { "Shadow Key", "Clé-de-l'Ombre" },
                { "Silverlode Archer", "Archer du Cours d'Argent" },
                { "Sneak Attack", "Attaque Furtive" },
                { "Snowbourn Scout", "Éclaireur du Snowbourn" },
                { "Son of Arnor", "Fils de l'Arnor" },
                { "Stand and Fight", "Tenir et Combattre" },
                { "Stand Together", "Faire Face Ensemble" },
                { "Steward of Gondor", "Intendant du Gondor" },
                { "Strength of Will", "Force de la Volonté" },
                { "Swift Strike", "Coup Brutal" },

                { "The Brown Lands", "Les Terres Brunes" },
                { "The East Bight", "La Brèche Est" },
                { "The Favor of the Lady", "La Faveur de la Dame" },
                { "The Galadhrim's Greeting", "Salutations des Galadhrims" },
                { "The Necromancer's Reach", "A la Merci du Nécromancien" },
                { "The Necromancer's Tower", "La Tour du Nécromancien" },
                { "Thicket of Spears", "Haie de Lances" },
                { "Through the Caverns", "Par les Cavernes" },
                { "To the River...", "Vers le Fleuve..." },
                { "Tower Gate", "Porte de la Tour" },
                { "Treacherous Fog", "Brouillard Dangereux" },

                { "Under the Shadow", "Sous l'Ombre" },
                { "Unexpected Courage", "Courage Inattendu" },
                { "Ungoliant's Spawn", "Rejeton d'Ungoliant" },

                { "Valiant Sacrifice", "Sacrifice Héroique" },
                { "Veteran Axehand", "Vétéran à la Hache" },

                { "Wandering Took", "Touque Aventureux" },
                { "Will of the West", "Volonté de l'Ouest" },
                { "Wolf Rider", "Chevaucheur de Loup" },
                
                //Children of Eorl
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